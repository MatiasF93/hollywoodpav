Public Class Alquiler
    Enum estado
        primero
        modificar
    End Enum
    Dim tabla_peliculas As Data.DataTable
    Dim acceso As New Acceso_Datos With { _
         ._esquema = "dbo." _
         , ._tabla = "facturas"}
    Dim socio As Socio
    Dim numero_factura As Integer
    Dim estado_alquiler As estado = estado.primero

    Public Sub New(ByVal numero As Integer)
        If numero = -1 Then
            estado_alquiler = estado.primero
        Else
            estado_alquiler = estado.modificar
            numero_factura = numero
        End If
        InitializeComponent()
    End Sub

    Private Sub Alquiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If estado_alquiler = estado.modificar Then
            Me.cargar_datos()
        End If
        lbl_usuario.Text = Inicio.principal.obtener_nombre_completo_socio()
    End Sub


    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        If Me.comprobaciones = True Then
            If estado_alquiler = estado.primero Then
                asignar_numero()
                Me.registrar_alquiler()
                Me.registrar_detalle_alquiler()
                Me.actualizar_saldo()
                MsgBox("Alquiler Exitoso", MsgBoxStyle.Information)
            Else
                Me.modificar_alquiler()
                Me.modificar_detalle_alquiler()
                MsgBox("Modificacion Exitosa", MsgBoxStyle.Information)
            End If
            Me.Close()
            Inicio.principal.cargar_grilla_peliculas()
            Inicio.principal.activar_modificar()
        End If
    End Sub

    Private Sub registrar_detalle_alquiler()
        Dim datos As String = ""
        Dim c As Integer = 0
        For c = 0 To Me.grid_carro_peliculas.RowCount() - 1
            'Grabar nuevo item del detalle
            Me.acceso._tabla = "detalles_factura"
            datos &= "num_factura=" & Me.numero_factura
            datos &= ", codigo_pelicula=" & Me.grid_carro_peliculas.Rows(c).Cells("codigo").Value
            datos &= ", precio=" & Me.grid_carro_peliculas.Rows(c).Cells("grid_pelicula_precio").Value
            datos &= ", fecha_devolucion=" & formatear_fecha(DateAdd(DateInterval.Day, 3, Date.Today).ToString)
            Me.acceso.insertar(datos)
            datos = ""
            'Modificar fecha en peliculas
            Me.acceso._tabla = "peliculas"
            Me.acceso.modificar("fecha_alquiler=" & DateAdd(DateInterval.Day, 3, Date.Today), "codigo_pelicula=" & Me.grid_carro_peliculas.Rows(c).Cells("codigo").Value)
        Next
    End Sub

    Private Sub registrar_alquiler()
        Dim datos As String = ""
        datos &= "num_factura=" & Me.numero_factura
        datos &= ", fecha=" & Date.Today
        datos &= ", num_socio=" & socio._num_socio
        datos &= ", monto_total=" & Me.lbl_monto_total.Text
        Me.acceso._tabla = "facturas"
        Me.acceso.insertar(datos)
    End Sub

    Private Sub modificar_detalle_alquiler()
        Dim datos As String = ""
        Dim c As Integer = 0

        'Limpiar detalle de factura
        '1)Setear las fechas de las peliculas
        Dim tabla As DataTable
        tabla = Me.acceso.consultar("SELECT codigo_pelicula FROM detalles_factura WHERE num_factura =" & Me.numero_factura)
        For c = 0 To tabla.Rows.Count() - 1
            Me.acceso.ejecutar("UPDATE peliculas SET fecha_alquiler = NULL WHERE codigo_pelicula=" & tabla.Rows(c)("codigo_pelicula"))
        Next
        '2)Eliminar el detalle
        Me.acceso.ejecutar("DELETE FROM detalles_factura WHERE num_factura =" & Me.numero_factura)


        'Si el socio borro todas las peliculas del carro se elimina el alquiler en este momento
        If Me.estado_alquiler = Alquiler.estado.modificar And Me.lbl_monto_total.Text = "0" Then
            Me.acceso.ejecutar("DELETE FROM facturas WHERE num_factura=" & Me.numero_factura)
            MsgBox("Usted ha cancelado el alquiler", MsgBoxStyle.Exclamation)
            Inicio.principal.activar_primero()
            Me.Dispose()
            Me.Close()

        Else
            'En cambio, si el socio realizo modificaciones sobre el carro, se graban el nuevo detalle
            For c = 0 To Me.grid_carro_peliculas.RowCount() - 1
                Me.acceso._tabla = "detalles_factura"
                datos &= "num_factura=" & Me.numero_factura
                datos &= ", codigo_pelicula=" & Me.grid_carro_peliculas.Rows(c).Cells("codigo").Value
                datos &= ", precio=" & Me.grid_carro_peliculas.Rows(c).Cells("grid_pelicula_precio").Value
                datos &= ", fecha_devolucion=" & formatear_fecha(DateAdd(DateInterval.Day, 3, Date.Today).ToString)
                Me.acceso.insertar(datos)
                datos = ""
                Me.acceso._tabla = "peliculas"
                Me.acceso.modificar("fecha_alquiler=" & DateAdd(DateInterval.Day, 3, Date.Today), "codigo_pelicula=" & Me.grid_carro_peliculas.Rows(c).Cells("codigo").Value)
            Next

            'Restar saldo al socio
            Me.actualizar_saldo()
        End If
       
    End Sub

    Private Sub modificar_alquiler()
        'Devovler saldo al socio
        Dim tabla As DataTable = Me.acceso.consultar("SELECT monto_total FROM facturas WHERE num_factura = " & Me.numero_factura)
        Me.acceso._tabla = "socios"
        Me.acceso.modificar("saldo = saldo +" & tabla.Rows(0)("monto_total"), "num_socio= " & Me.socio._num_socio)

        'Grabar nuevo monto del alquiler
        Dim datos As String = ""
        datos &= "monto_total=" & Me.lbl_monto_total.Text
        Me.acceso._tabla = "facturas"
        Me.acceso.modificar(datos, "num_factura=" & Me.numero_factura)
    End Sub

    'Resta el saldo al socio
    Private Sub actualizar_saldo()
            Me.acceso._tabla = "socios"
            Me.acceso.modificar("saldo = saldo -" & Convert.ToDouble(Me.lbl_monto_total.Text), "num_socio= " & Me.socio._num_socio)
    End Sub


    'Devuelve TRUE em caso de q el alquiler este OKEY
    Private Function comprobaciones() As Boolean
        Dim estado As Boolean = True

        'Comprobar si el socio tiene saldo suficiente
        If Me.socio._saldo < Convert.ToDouble(Me.lbl_monto_total.Text) Then
            MsgBox("Saldo insufuciente. Su saldo actual es " & Me.socio._saldo, MsgBoxStyle.Critical)
            estado = False
        End If
        'Comprobar si el socio no excede su limite de peliculas
        If Me.socio._limite_alquiler < Me.grid_carro_peliculas.Rows.Count Then
            MsgBox("Limite de peliculas sobrepasado", MsgBoxStyle.Critical)
            estado = False
        End If
        'Comprobar si el socio selecciono alguna pelicula
        If Me.lbl_monto_total.Text = "0" And estado_alquiler = Alquiler.estado.primero Then
            MsgBox("No ha seleccionado ninguna pelicula", MsgBoxStyle.Critical)
            estado = False
        End If
        Return estado
    End Function

    'Carga los datos cuando se decide modificar el alquiler que se esta efectuando
    Private Sub cargar_datos()
        Dim tabla As DataTable
        Dim consulta As String
        consulta = "SELECT detalles_factura.codigo_pelicula AS codigo, precio, formatos.descripcion AS formato, nombre FROM ((detalles_factura JOIN "
        consulta &= "peliculas ON detalles_factura.codigo_pelicula = peliculas.codigo_pelicula) "
        consulta &= "JOIN formatos ON peliculas.id_formato = formatos.id_formato) "
        consulta &= "WHERE num_factura=" & Me.numero_factura
        tabla = Me.acceso.consultar(consulta)
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_carro_peliculas.Rows.Add(tabla.Rows(c)("nombre"), tabla.Rows(c)("formato"), tabla.Rows(c)("precio"), tabla.Rows(c)("codigo"))
        Next
        tabla = Me.acceso.consultar("SELECT monto_total FROM facturas WHERE num_factura =" & Me.numero_factura)
        Me.lbl_monto_total.Text = tabla.Rows(0)("monto_total")
    End Sub

    Private Function formatear_fecha(ByVal fecha As String)
        If fecha.Equals("") Then
            fecha = "-" 'Hago esto para que el campo no se muestre vacío cuando el artista no tenga fecha de baja.
        Else
            fecha = fecha.Substring(0, 10) 'Hago esto para que no se muestre la hora de baja.
        End If
        Return fecha
    End Function

    'Quitar peliculas del carro
    Private Sub grid_carro_peliculas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_carro_peliculas.CellContentClick
        If e.ColumnIndex = 4 Then
            'Actualiza el monto del alquiler
            Me.lbl_monto_total.Text = (Convert.ToInt16(Me.lbl_monto_total.Text) - Me.grid_carro_peliculas.Rows(e.RowIndex).Cells("grid_pelicula_precio").Value).ToString

            'Añande la fila a la pagina principal
            Inicio.principal.agregar_fila(Me.grid_carro_peliculas.Rows(e.RowIndex).Cells("codigo").Value)

            'Quita del carro la pelicula
            Me.grid_carro_peliculas.Rows.RemoveAt(grid_carro_peliculas.CurrentRow.Index)
        End If
    End Sub

    'Permite agregar peliculas al carro desde el menu principal
    Public Sub agregar_pelicula(ByVal titulo As String, ByVal formato As String, ByVal precio As String, ByVal codigo As String)
        Me.grid_carro_peliculas.Rows.Add(titulo, formato, precio, codigo)
        mostrar_total()
    End Sub

    'Asigna numeros a los alquileres 
    Private Sub asignar_numero()
        Dim tabla As DataTable
        Dim numero As Integer
        Me.acceso._tabla = "facturas"
        tabla = Me.acceso.consultar("SELECT MAX(num_factura) AS numero FROM facturas")
        If String.IsNullOrEmpty(tabla.Rows(0)("numero").ToString) Then
            Me.numero_factura = 1
        Else
            numero = Convert.ToInt16(tabla.Rows(0)("numero").ToString)
            Me.numero_factura = numero + 1
        End If
        Inicio.principal.asignar_numero(Me.numero_factura)

    End Sub

    'Toma los datos del socio
    Public Sub tomarSocio(ByVal socio_actual As Socio)
        Me.socio = socio_actual
    End Sub

    'Calcula el total que se muestra en el carro
    Private Sub mostrar_total()
        Dim total As Decimal = 0
        For c = 0 To Me.grid_carro_peliculas.Rows.Count - 1
            total = total + Convert.ToDecimal(Me.grid_carro_peliculas.Rows(c).Cells("grid_pelicula_precio").Value)
        Next
        lbl_monto_total.Text = total
    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click, Me.FormClosing
        Limpiar(Me)
        If Me.estado_alquiler = estado.modificar Then
            Me.modificar_detalle_alquiler()
        End If
        Inicio.principal.cargar_grilla_peliculas()
        Inicio.principal.activar_modificar()
        Me.Dispose()
        Me.Close()

    End Sub
    

    Sub Limpiar(ByVal c1 As Control)
        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                c.Text = "" ' eliminar el texto
            Else
                Limpiar(c)
            End If
            If TypeOf c Is ComboBox Then
                c.Text = "" ' eliminar el texto
            Else
                Limpiar(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False
            Else
                Limpiar(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today ' eliminar el texto
            Else
                Limpiar(c)
            End If
        Next
    End Sub

  
End Class

    '37873689