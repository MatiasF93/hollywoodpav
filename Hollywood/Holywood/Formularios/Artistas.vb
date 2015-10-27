Public Class frm_artistas
    Dim registrar As Registrar_Artista
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "artistas"}
    Dim listado As Listado_peliculasXartista
    Private Sub artistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar_grilla(obtener_filtros())
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        registrar = New Registrar_Artista(Registrar_Artista.estado.insertar)
        registrar.ShowDialog()
        registrar = Nothing
    End Sub

    Private Sub cmd_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_volver.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Carga nuevamente la grilla, actualizándo su información desde la BD.
    ''' </summary>
    ''' <param name="filtros"></param>
    ''' <remarks></remarks>
    Public Sub cargar_grilla(ByVal filtros As String)
        Me.grid_artistas.Rows.Clear()
        Dim tabla As DataTable
        If filtros = "(es_actor = 0) AND (es_director = 0)" Or filtros.Length = 0 Then
            tabla = acceso.leo_tabla()
        Else
            tabla = acceso.leo_tabla(filtros)
        End If
        For c = 0 To tabla.Rows.Count - 1
            Me.grid_artistas.Rows.Add(tabla.Rows(c)("apellido"), tabla.Rows(c)("nombres"), _
                                      tabla.Rows(c)("matricula"), es_tipo_actor(tabla.Rows(c)("id_tipo_artista")), _
                                      es_tipo_director(tabla.Rows(c)("id_tipo_artista")), _
                                      Me.formatear_fecha(tabla.Rows(c)("fecha_nacimiento")).ToString, _
                                      Me.formatear_fecha(tabla.Rows(c)("fecha_baja").ToString))
        Next
        If chb_dados_baja.Checked Then
            Me.grid_artistas.Columns("fecha_baja").Visible = True
        Else
            Me.grid_artistas.Columns("fecha_baja").Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Verifica el número recibido por parámetros para determinar si corresponde indicar que el artista
    ''' es un actor o no.
    ''' </summary>
    ''' <param name="tipo_artista"></param>
    ''' <returns>String que indica si es actor ("Si") o no ("No")</returns>
    ''' <remarks></remarks>
    Private Function es_tipo_actor(ByVal tipo_artista As Integer) As String
        If tipo_artista = 1 Or tipo_artista = 2 Then
            Return "Si"
        Else
            Return "No"
        End If
    End Function

    ''' <summary>
    ''' Verifica el número recibido por parámetros para determinar si corresponde indicar que el artista
    ''' es un director o no.
    ''' </summary>
    ''' <param name="tipo_artista"></param>
    ''' <returns>String que indica si es director ("Si") o no ("No")</returns>
    ''' <remarks></remarks>
    Private Function es_tipo_director(ByVal tipo_artista As Integer) As String
        If tipo_artista = 0 Or tipo_artista = 2 Then
            Return "Si"
        Else
            Return "No"
        End If
    End Function

    ''' <summary>
    ''' Recibe por parámetros una fecha (objeto de tipo String, no Date). Si la misma está vacía, devuelve un guión
    ''' ("-"). Si no está vacía, le quita la hora y devuelve solo los valores del día, mes y año.
    ''' </summary>
    ''' <param name="fecha">Fecha a la que se le quiere dar formato.</param>
    ''' <returns>Fecha formateada.</returns>
    ''' <remarks></remarks>
    Private Function formatear_fecha(ByVal fecha As String)
        If fecha.Equals("") Then
            fecha = "-" 'Hago esto para que el campo no se muestre vacío cuando el artista no tenga fecha de baja.
        Else
            fecha = fecha.Substring(0, 10) 'Hago esto para que no se muestre la hora de baja.
        End If
        Return fecha
    End Function

    ''' <summary>
    ''' Este método ejecuta la modificación o la baja de un artista según corresponda.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grid_artistas_CellContentClick(ByVal sender As System.Object, ByVal e As  _
                                               System.Windows.Forms.DataGridViewCellEventArgs) _
                                           Handles grid_artistas.CellContentClick
        If Me.grid_artistas("fecha_baja", e.RowIndex).Value.ToString.Equals("-") Then
            If e.ColumnIndex = 7 Then
                registrar = New Registrar_Artista(Registrar_Artista.estado.modificar)
                registrar.cargar_campos(Me.grid_artistas.Rows(e.RowIndex).Cells(2).Value, _
                                        Me.grid_artistas.Rows(e.RowIndex).Cells(0).Value, _
                                        Me.grid_artistas.Rows(e.RowIndex).Cells(1).Value, _
                                        revertir_si_no(Me.grid_artistas.Rows(e.RowIndex).Cells(3).Value), _
                                        revertir_si_no(Me.grid_artistas.Rows(e.RowIndex).Cells(4).Value), _
                                        Me.grid_artistas.Rows(e.RowIndex).Cells(5).Value)
                registrar.ShowDialog()
                registrar = Nothing
            End If
            If e.ColumnIndex = 8 Then
                Me.registrar_baja_artista()
                Me.cargar_grilla(Me.obtener_filtros())
            End If
        Else
            MsgBox("No es posible modificar ni dar de baja artistas que ya fueron dados de baja.", _
                   MsgBoxStyle.Information, "Error")
        End If
    End Sub

    ''' <summary>
    ''' Convierte un String recibido por parametros en otro String convertible a boolean 
    ''' ("Si" -> "True", "No" -> "False").
    ''' </summary>
    ''' <param name="valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function revertir_si_no(ByVal valor As String) As String
        If valor = "Si" Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Ejecuta una consulta a la BD según los filtros ingresados y muestra los resultados en la grilla.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cargar_grilla(obtener_filtros())
    End Sub

    ''' <summary>
    ''' Evalúa los datos cargados en todos los filtros, armando un String que contiene una consulta lista para ser
    ''' ejecutada en una BD SQL Server.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function obtener_filtros() As String
        Dim filtros As String = ""
        Dim hay_filtros As Boolean = False

        If txt_apellidos.Text.Length > 0 Then
            filtros += "(apellido LIKE '%" + txt_apellidos.Text + "%')"
            hay_filtros = True
        End If

        If txt_nombres.Text.Length > 0 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(nombres LIKE '%" + txt_nombres.Text + "%')"
            hay_filtros = True
        End If

        If chb_actor.Checked Or chb_director.Checked Then
            If hay_filtros Then
                filtros += " AND "
            End If
            If chb_actor.Checked Then
                filtros += "(es_actor = 1)"
            Else
                filtros += "(es_actor = 0)"
            End If
            filtros += " AND "
            If chb_director.Checked Then
                filtros += "(es_director = 1)"
            Else
                filtros += "(es_director = 0)"
            End If
        End If

        If chb_dados_baja.Checked = False Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "fecha_baja IS NULL"
            hay_filtros = True
        End If

        Return filtros
    End Function

    Private Sub registrar_baja_artista()
        If MsgBox("¿Está seguro que desea dar de baja este artista?", MsgBoxStyle.YesNo, "Confirmación") _
                = Windows.Forms.DialogResult.Yes Then
            Me.acceso.registrar_baja("matricula", Me.grid_artistas.CurrentRow.Cells("matricula").Value.ToString())
            MsgBox("Artista eliminado exitosamente.", MsgBoxStyle.Information, "Eliminación exitosa")
        End If
    End Sub

    ''' <summary>
    ''' Blanquea todos los filtros de la pantalla.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub limpiar_filtros()
        Me.txt_apellidos.Clear()
        Me.txt_nombres.Clear()
        Me.chb_actor.Checked = False
        Me.chb_director.Checked = False
    End Sub

End Class