Imports System.Configuration

Public Class Acceso_Datos
    Enum tipo_conexion
        transaccion
        simple
    End Enum
    Enum estado_transaccion
        _ok
        _error
    End Enum

    Dim configurar_conexion As tipo_conexion = tipo_conexion.simple
    Dim transaccion As New Object
    Dim control_transaccion As estado_transaccion = estado_transaccion._ok
    Dim cadena_conexion As String = ConfigurationManager.ConnectionStrings("HollywoodBD").ConnectionString
    Dim tabla As String = ""
    Dim esquema As String = ""
    Dim conexion = New Data.SqlClient.SqlConnection
    Dim cmd = New Data.SqlClient.SqlCommand

    Public Property _tabla As String
        Get
            Return tabla
        End Get
        Set(ByVal value As String)
            tabla = value
        End Set
    End Property

    Public Property _esquema As String
        Get
            Return esquema
        End Get
        Set(ByVal value As String)
            esquema = value
        End Set
    End Property

    Public Property _cadena_conexion() As String
        Get
            Return Me.cadena_conexion
        End Get
        Set(ByVal value As String)
            Me.cadena_conexion = value
        End Set
    End Property

    Public Sub iniciar_conexion_con_transaccion()
        Me.configurar_conexion = tipo_conexion.transaccion
        Me.control_transaccion = estado_transaccion._ok
    End Sub

    Private Sub conectar()
        If Me.conexion.State.ToString() <> "Open" Then
            Me.conexion.ConnectionString = Me.cadena_conexion
            Me.conexion.Open()
            Me.cmd.Connection = conexion
            Me.cmd.CommandType = CommandType.Text

            If Me.configurar_conexion = tipo_conexion.transaccion Then
                Me.transaccion = Me.conexion.BeginTransaction()
                Me.cmd.Transaction = Me.transaccion
            End If
        End If
    End Sub

    Public Function finalizar_conexion_con_transaccion() As estado_transaccion
        If Me.control_transaccion = estado_transaccion._ok Then
            Me.transaccion.Commit()
        Else
            Me.transaccion.Rollback()
        End If
        Me.conexion.Close()
        Me.configurar_conexion = tipo_conexion.simple

        Return Me.control_transaccion
    End Function

    Public Function consultar(ByVal sql As String) As Data.DataTable
        Dim tabla As New Data.DataTable
        Me.conectar()
        Me.cmd.CommandText = sql
        Try
            tabla.Load(Me.cmd.ExecuteReader)
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error en la consulta")
        End Try
        If Me.configurar_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
        Return tabla
    End Function

    ''' <summary>
    ''' Se puede usar para realizar directamente modificaciones o eliminaciones simples.
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ejecutar(ByVal comando As String) As String
        Me.conectar()
        Me.cmd.CommandText = comando
        Try
            cmd.ExecuteNonQuery()
            Return "ok"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.control_transaccion = estado_transaccion._error
            Return ex.Message
        End Try
        If Me.configurar_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
    End Function

    Public Function modificar(ByVal valores As String, ByVal restriccion As String) As String
        Dim _update As String = "UPDATE " + Me.tabla + " SET " + Chr(13)
        Dim _set As String
        Dim _restriccion As String

        _set = Me.armar_set_update(valores)
        If _set = "error" Then
            Return "error"
        End If
        _restriccion = armar_restriccion_update(restriccion)
        If _restriccion = "error" Then
            Return "error"
        End If
        _update &= _set + _restriccion

        Dim estado As String = Me.ejecutar(_update)
        If Me.configurar_conexion = tipo_conexion.transaccion Then
            If estado = "ok" Then
                Return "ok"
            Else
                Return "error"
            End If
        Else
            Me.conexion.Close()
            Return ("ok")
        End If

    End Function

    Private Function armar_restriccion_update(ByVal restriccion As String) As String
        Dim objeto_tabla As Data.DataTable     'tabla que contiene la estructura en la base
        Dim contador As Integer = 0             'contador de bucle
        Dim c As Integer = 0                    'para recorrer las columas buscando una
        Dim coma As Integer = 0                 'ubicacion de la "," 
        Dim igual As Integer = 0                'ubicación del "="
        Dim txt_origen As String = ""           'texto origen 
        Dim nombre_campo As String = ""         'campo a buscar 
        Dim valor As String = ""                'valor del campo 
        Dim txt As String = ""                  'texto que se va formando para el insert
        Dim tipo_dato As String = ""
        Dim estado As Boolean = True
        Dim encontro As Boolean = False
        Dim primera_vez As Boolean = True

        objeto_tabla = Me.leer_estructura()
        txt_origen = restriccion.ToUpper.Trim()

        While estado
            igual = txt_origen.IndexOf("=")
            coma = IIf(txt_origen.IndexOf(",") = -1, txt_origen.Length, txt_origen.IndexOf(","))
            If txt_origen.IndexOf(",") = -1 Then
                estado = False
            End If
            nombre_campo = txt_origen.Substring(0, igual).Trim()
            valor = txt_origen.Substring(igual + 1, coma - igual - 1).Trim()
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString

            For c = 0 To objeto_tabla.Columns.Count() - 1
                If nombre_campo.Trim() = objeto_tabla.Columns(c).Caption.ToUpper.Trim() Then
                    tipo_dato = objeto_tabla.Columns(c).DataType.ToString
                    encontro = True
                End If
            Next
            If encontro Then
                If primera_vez Then
                    txt &= "WHERE " + nombre_campo + " = " + ajustar_al_tipo_dato(valor, tipo_dato) + Chr(13)
                    primera_vez = False
                Else
                    txt &= " AND " + nombre_campo + " = " + ajustar_al_tipo_dato(valor, tipo_dato) + Chr(13)
                End If
            Else
                MsgBox("no existe el nombre de columna " + nombre_campo, MsgBoxStyle.Critical, "Importante")
                txt = "error"
                Exit While
            End If
            If estado = True Then
                txt_origen = txt_origen.Substring(coma + 1)
            End If

        End While
        Return txt

    End Function

    Private Function armar_set_update(ByVal valores As String) As String
        Dim objeto_tabla As Data.DataTable     'tabla que contiene la estructura en la base
        Dim contador As Integer = 0             'contador de bucle
        Dim c As Integer = 0                    'para recorrer las columas buscando una
        Dim coma As Integer = 0                 'ubicacion de la "," 
        Dim igual As Integer = 0                'ubicación del "="
        Dim txt_origen As String = ""           'texto origen 
        Dim nombre_campo As String = ""         'campo a buscar 
        Dim valor As String = ""                'valor del campo 
        Dim txt As String = ""                  'texto que se va formando para el insert
        Dim tipo_dato As String = ""
        Dim estado As Boolean = True
        Dim encontro As Boolean = False
        Dim primera_vez As Boolean = True

        objeto_tabla = Me.leer_estructura()
        txt_origen = valores.Trim()

        While estado
            igual = txt_origen.IndexOf("=")
            coma = IIf(txt_origen.IndexOf(",") = -1, txt_origen.Length, txt_origen.IndexOf(","))
            If txt_origen.IndexOf(",") = -1 Then
                estado = False
            End If
            nombre_campo = txt_origen.Substring(0, igual).Trim
            valor = txt_origen.Substring(igual + 1, coma - igual - 1).Trim()
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString

            For c = 0 To objeto_tabla.Columns.Count() - 1
                If nombre_campo.Trim.ToUpper() = objeto_tabla.Columns(c).Caption.ToUpper.Trim() Then
                    tipo_dato = objeto_tabla.Columns(c).DataType.ToString
                    encontro = True
                End If
            Next
            If encontro Then
                If primera_vez Then
                    txt &= nombre_campo + " = " + ajustar_al_tipo_dato(valor, tipo_dato) + Chr(13)
                    primera_vez = False
                Else
                    txt &= ", " + nombre_campo + " = " + ajustar_al_tipo_dato(valor, tipo_dato) + Chr(13)
                End If
            Else
                MsgBox("no existe el nombre de columna " + nombre_campo, MsgBoxStyle.Critical, "Importante")
                txt = "error"
                Exit While
            End If
            If estado = True Then
                txt_origen = txt_origen.Substring(coma + 1)
            End If

        End While
        Return txt
    End Function

    Public Function insertar(ByVal valores As String) As String
        Dim txt_Insert As String = ""

        txt_Insert = Me.armar_insert(valores)
        txt_Insert += Me.asignar_valores_insert(valores)

        Dim estado As String = Me.ejecutar(txt_Insert)
        If Me.configurar_conexion = tipo_conexion.transaccion Then
            If estado = "ok" Then
                Return "ok"
            Else
                Return "error"
            End If
        Else
            Me.conexion.Close()
            Return ("ok")
        End If

    End Function

    Private Function armar_insert(ByRef valores As String) As String
        Dim tabla As Data.DataTable
        Dim contador As Integer = 0
        Dim txt As String = ""

        tabla = Me.leer_estructura()
        tabla = Me.excluir_columnas(tabla, valores)
        txt = "insert into " & Me.tabla & " ("

        While tabla.Columns.Count() > contador
            txt += tabla.Columns(contador).Caption
            contador += 1
            If contador < tabla.Columns.Count() Then
                txt += ", "
            End If
        End While
        txt += ") values ("

        Return txt
    End Function

    Private Function asignar_valores_insert(ByVal txt_insertar As String) As String
        Dim objeto_tabla As Data.DataTable      'tabla que contiene la estructura en la base
        Dim contador As Integer = 0             'contador de bucle
        Dim campo As Integer = 0                'ubicación del campo 
        Dim coma As Integer = 0                 'ubicacion de la "," 
        Dim igual As Integer = 0                'ubicación del "="
        Dim txt_origen As String = ""           'texto origen 
        Dim nombre_campo As String = ""         'campo a buscar 
        Dim valor As String = ""                'valor del campo 
        Dim txt As String = ""                  'texto que se va formando para el insert
        Dim tipo_dato As String = ""

        objeto_tabla = Me.leer_estructura()
        objeto_tabla = Me.excluir_columnas(objeto_tabla, txt_insertar)
        txt_origen = txt_insertar.ToUpper.Trim()
        txt_origen = txt_insertar.Trim()

        While objeto_tabla.Columns.Count() > contador

            nombre_campo = objeto_tabla.Columns(contador).Caption.Trim()
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString

            campo = txt_origen.IndexOf(nombre_campo)
            If campo <> -1 Then
                igual = txt_origen.IndexOf("=", campo)
                coma = txt_origen.IndexOf(",", campo)
            Else
                igual = -1
                coma = -1
            End If

            If campo <> -1 Then
                igual = txt_origen.IndexOf("=", campo)
                coma = txt_origen.IndexOf(",", campo)
                If coma <> -1 Then
                    valor = Me.ajustar_al_tipo_dato(txt_origen.Substring(igual + 1, coma - igual - 1), tipo_dato)
                Else
                    valor = Me.ajustar_al_tipo_dato(txt_origen.Substring(igual + 1), tipo_dato)
                End If
            Else
                valor = "null"
            End If

            txt += valor
            contador += 1
            If contador < objeto_tabla.Columns.Count() Then
                txt += ", "
            End If
        End While

        txt += ")"
        Return txt
    End Function

    Private Function ajustar_al_tipo_dato(ByVal texto As String, ByVal tipo_dato As String) As String
        Select Case tipo_dato
            Case "System.String"
                Return "'" & texto & "'"
            Case "System.Int16"
                Return texto
            Case "System.Int32"
                Return texto
            Case "System.Int64"
                Return texto
            Case "System.Byte"
                Return texto
            Case "System.Double"
                Return texto
            Case "System.Decimal"
                Return texto
            Case "System.DateTime"
                Return "'" & texto & "'"
            Case "System.DateTimeKind"
                Return "'" & texto & "'"
            Case Else
                Return texto
        End Select
    End Function

    Private Function leer_estructura() As Data.DataTable
        Dim sql As String
        Dim tabla As New DataTable
        sql = "select top 1 * from " & Me.tabla
        tabla = Me.consultar(sql)
        Return tabla
    End Function

    Public Function leo_tabla() As Data.DataTable
        Return Me.consultar("select * from " & Me.esquema & Me.tabla)
    End Function

    ''' <summary>
    ''' Sirve para hacer una consulta SQL con filtros. Este metodo ya esta preparado para agregar
    ''' automaticamente la palabra "WHERE " antes de los filtros enviados por parametros.
    ''' </summary>
    ''' <param name="filtro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function leo_tabla(ByVal filtro As String) As Data.DataTable
        Dim sql As String = "select * from " & Me.esquema & Me.tabla
        sql += " where " + filtro
        Return Me.consultar(sql)
    End Function

    Public Function leo_otra_tabla(ByVal tabla As String) As Data.DataTable
        Return Me.consultar("select * from " & Me.esquema & tabla)
    End Function

    ''' <summary>
    ''' Sirve para hacer una consulta SQL con filtros en la tabla especificada por parametro. 
    ''' Este metodo ya esta preparado para agregar automaticamente la palabra "WHERE " antes 
    ''' de los filtros enviados por parametros.
    ''' </summary>
    ''' <param name="filtro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function leo_otra_tabla(ByVal tabla As String, ByVal filtro As String) As Data.DataTable
        Dim sql As String = "select * from " & Me.esquema & tabla
        sql += " where " + filtro
        Return Me.consultar(sql)
    End Function

    ''' <summary>
    ''' Recibe por parámetros una tabla y un string con los nombres de algunas columnas de esa tabla.
    ''' Recorre las columnas de la tabla verificando que sus nombres estén dentro de dicho String y elimina
    ''' todas las columnas cuyos nombres no estén en el mismo.
    ''' </summary>
    ''' <param name="tabla_origen">Tabla a reducir</param>
    ''' <param name="columnas_a_incluir">Nombres de columnas que no se deben eliminar.</param>
    ''' <returns>Tabla reducida que incluye solo las columnas mencionadas en el string.</returns>
    ''' <remarks></remarks>
    Public Function excluir_columnas(ByRef tabla_origen As Data.DataTable, ByVal columnas_a_incluir As String) As Data.DataTable
        Dim tabla As Data.DataTable = tabla_origen
        Dim columnas As DataColumnCollection = tabla_origen.Columns
        Dim columnas_a_borrar As New List(Of String)

        'For i = 0 To columnas.Count - 1
        '    Dim nombre As String = columnas(i).ColumnName
        '    If Not columnas_a_incluir.Contains(nombre) Then
        '        tabla.Columns.Remove(nombre)
        '    End If
        'Next

        For Each columna In columnas
            Dim nombre As String = columna.ColumnName
            If Not columnas_a_incluir.Contains(nombre) Then
                columnas_a_borrar.Add(nombre)
            End If
        Next
        If columnas_a_borrar.Count > 0 Then
            For i = 0 To columnas_a_borrar.Count - 1
                tabla.Columns.Remove(columnas_a_borrar(i))
            Next
        End If

        Return tabla
    End Function

    ''' <summary>
    ''' Registra la baja de una entidad asignándole la fecha actual en la columna fecha_baja
    ''' </summary>
    ''' <param name="columna_filtro">Nombre de la columna que se utilizará como filtro</param>
    ''' <param name="filtro">Filtro a utilizar</param>
    ''' <remarks></remarks>
    Public Sub registrar_baja(ByVal columna_filtro As String, ByVal filtro As String)
        Dim sql As String = "UPDATE " + Me.tabla + " SET fecha_baja = '" + Date.Today + "'"
        sql += "WHERE " + columna_filtro + " = " + filtro
        Me.ejecutar(sql)
    End Sub

End Class