Public Class Alquiler
    Dim tabla_peliculas As Data.DataTable
    Dim acceso As New Acceso_Datos With { _
         ._esquema = "dbo." _
         , ._tabla = "facturas"}
    Dim socio As Socio
    Dim numero_factura As Integer

    Public Sub New(ByVal peliculas As Data.DataTable)
        Me.tabla_peliculas = peliculas
        InitializeComponent()
    End Sub

    Private Sub Alquiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For c = 0 To Me.tabla_peliculas.Rows.Count - 1
        '    Me.grid_carro_peliculas.Rows.Add(Me.tabla_peliculas.Rows(c)("titulo"), _
        '                                     Me.tabla_peliculas.Rows(c)("formato"), _
        '                                     Me.tabla_peliculas.Rows(c)("precio"), _
        '                                     Me.tabla_peliculas.Rows(c)("codigo"))
        'Next
        lbl_usuario.Text = Inicio.principal.obtener_nombre_completo_socio()
        asignar_numero()
    End Sub

    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        registrar_alquiler()
        registrar_detalle_alquiler()
        MsgBox("Alquiler Exitoso", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub registrar_detalle_alquiler()
        Dim datos As String = ""
        Dim c As Integer = 0
        Me.acceso._tabla = "detalles_factura"
        For c = 0 To Me.grid_carro_peliculas.RowCount() - 1
            datos &= "num_factura=" & Me.numero_factura
            datos &= ", codigo_pelicula=" & Me.grid_carro_peliculas.Rows(c).Cells("codigo").Value
            datos &= ", precio=" & Me.grid_carro_peliculas.Rows(c).Cells("grid_pelicula_precio").Value
            datos &= ", fecha_devolucion=" & formatear_fecha(Me.DateTimePicker_fecha_devolucion.Value.Date.ToString)
            'datos &= ", fecha_real_devolucion=" & 
            Me.acceso.insertar(datos)
            datos = ""
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
    
    Private Function formatear_fecha(ByVal fecha As String)
        If fecha.Equals("") Then
            fecha = "-" 'Hago esto para que el campo no se muestre vacío cuando el artista no tenga fecha de baja.
        Else
            fecha = fecha.Substring(0, 10) 'Hago esto para que no se muestre la hora de baja.
        End If
        Return fecha
    End Function

    Private Sub grid_carro_peliculas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_carro_peliculas.CellContentClick
        If e.ColumnIndex = 4 Then
            Me.grid_carro_peliculas.Rows.RemoveAt(grid_carro_peliculas.CurrentRow.Index)
        End If
    End Sub

    Public Sub agregar_pelicula(ByVal titulo As String, ByVal formato As String, ByVal precio As String, ByVal codigo As String)
        Me.grid_carro_peliculas.Rows.Add(titulo, formato, precio, codigo)
        mostrar_total()
    End Sub

    Private Sub asignar_numero()
        Dim tabla As DataTable
        Dim numero As Integer
        Me.acceso._tabla = "facturas"
        tabla = Me.acceso.consultar("SELECT MAX(num_factura) AS numero FROM facturas")
        numero = Convert.ToInt16(tabla.Rows(0)("numero").ToString)
        Me.numero_factura = numero + 1
    End Sub

    Public Sub tomarSocio(ByVal socio_actual As Socio)
        Me.socio = socio_actual
    End Sub

    Private Sub mostrar_total()
        Dim total As Decimal = 0
        For c = 0 To Me.grid_carro_peliculas.Rows.Count - 1
            total = total + Convert.ToDecimal(Me.grid_carro_peliculas.Rows(c).Cells("grid_pelicula_precio").Value)
        Next
        lbl_monto_total.Text = total
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class

    '37873689