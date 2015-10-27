Public Class Listado_alquileresXsocio
    Dim acceso As New Acceso_Datos

    Private Sub Listado_alquileresXsocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sql As String = ""
        sql = "SELECT (socios.apellido+' '+socios.nombres) as nombre_socio, peliculas.nombre as pelicula_alquilada,  facturas.fecha as fecha_alquiler, detalles_factura.fecha_devolucion as devolucion_estimada"
        sql &= " FROM facturas INNER JOIN detalles_factura ON facturas.num_factura = detalles_factura.num_factura INNER JOIN "
        sql &= " socios ON facturas.num_socio = socios.num_socio INNER JOIN peliculas ON detalles_factura.codigo_pelicula = peliculas.codigo_pelicula"
        DataSet_alquileresXsocioBindingSource.DataSource = Me.acceso.consultar(sql)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        sql = "SELECT (socios.apellido+' '+socios.nombres) as nombre_socio, peliculas.nombre as pelicula_alquilada,  facturas.fecha as fecha_alquiler, detalles_factura.fecha_devolucion as devolucion_estimada"
        sql &= " FROM facturas INNER JOIN detalles_factura ON facturas.num_factura = detalles_factura.num_factura INNER JOIN "
        sql &= " socios ON facturas.num_socio = socios.num_socio INNER JOIN peliculas ON detalles_factura.codigo_pelicula = peliculas.codigo_pelicula "
        sql &= "WHERE (socios.apellido+' '+socios.nombres) LIKE '% " & Me.txt_nombre.Text & "%'"
        DataSet_alquileresXsocioBindingSource.DataSource = Me.acceso.consultar(sql)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer2.Load
        Dim sql As String = ""
        sql = "SELECT (socios.nombres+''+socios.apellido) as nombre_socio, COUNT(detalles_factura.codigo_pelicula) as cantidad FROM "
        sql &= "facturas INNER JOIN detalles_factura ON facturas.num_factura = detalles_factura.num_factura INNER JOIN"
        sql &= " socios ON facturas.num_socio = socios.num_socio"
        sql &= " GROUP BY (socios.nombres+''+socios.apellido)"
        cantidad_alquileresDataTableBindingSource.DataSource = Me.acceso.consultar(sql)
        Me.ReportViewer2.RefreshReport()

    End Sub
End Class