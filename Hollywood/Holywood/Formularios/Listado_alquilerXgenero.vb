Public Class Listado_alquilerXgenero
    Dim acceso As Acceso_Datos
    Private Sub Listado_alquilerXgenero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = ""
        sql = "SELECT  peliculas.nombre as nombre_pelicula,  generos.descripcion as nombre_genero, SUM(detalles_factura.codigo_pelicula) AS cantidadAlq "
        sql &= " FROM            ((detalles_factura INNER JOIN "
        sql &= "                 peliculas ON detalles_factura.codigo_pelicula = peliculas.codigo_pelicula) INNER JOIN "
        sql &= "                 generos ON peliculas.id_genero = generos.id_genero) "
        sql &= " WHERE generos.descripcion LIKE '%" & Me.txt_nombre_genero.Text & "%' "
        sql &= " AND peliculas.nombre LIKE '%" & Me.txt_nombre_pelicula.Text & "%'"
        sql &= " GROUP BY peliculas.nombre, generos.descripcion "
        DataSet_alquilerXgeneroBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()

        Dim sql2 As String = ""
        sql2 = "SELECT  generos.descripcion as nombre_genero, SUM(detalles_factura.codigo_pelicula) AS cantidadAlq "
        sql2 &= " FROM            ((detalles_factura INNER JOIN "
        sql2 &= "                 peliculas ON detalles_factura.codigo_pelicula = peliculas.codigo_pelicula) INNER JOIN "
        sql2 &= "                 generos ON peliculas.id_genero = generos.id_genero) "
        sql2 &= " GROUP BY generos.descripcion "
        If Me.txt_menor.Text <> "" And Me.txt_mayor.Text <> "" Then
            sql2 &= " HAVING SUM(detalles_factura.codigo_pelicula) > " & Me.txt_menor.Text
            sql2 &= " AND SUM(detalles_factura.codigo_pelicula) < " & Me.txt_mayor.Text
        End If

        DataSet_alquilerXgeneroBindingSource.DataSource = acceso.consultar(sql2)
        Me.ReportViewer2.RefreshReport()

    End Sub

  

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        sql = "SELECT  peliculas.nombre as nombre_pelicula,  generos.descripcion as nombre_genero, SUM(detalles_factura.codigo_pelicula) AS cantidadAlq "
        sql &= " FROM            ((detalles_factura INNER JOIN "
        sql &= "                 peliculas ON detalles_factura.codigo_pelicula = peliculas.codigo_pelicula) INNER JOIN "
        sql &= "                 generos ON peliculas.id_genero = generos.id_genero) "
        sql &= " WHERE generos.descripcion LIKE '%" & Me.txt_nombre_genero.Text & "%' "
        sql &= " AND peliculas.nombre LIKE '%" & Me.txt_nombre_pelicula.Text & "%'"
        sql &= " GROUP BY peliculas.nombre, generos.descripcion "
        DataSet_alquilerXgeneroBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cmd_buscarEst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscarEst.Click
        Dim sql2 As String = ""
        sql2 = "SELECT  generos.descripcion as nombre_genero, SUM(detalles_factura.codigo_pelicula) AS cantidadAlq "
        sql2 &= " FROM            ((detalles_factura INNER JOIN "
        sql2 &= "                 peliculas ON detalles_factura.codigo_pelicula = peliculas.codigo_pelicula) INNER JOIN "
        sql2 &= "                 generos ON peliculas.id_genero = generos.id_genero) "
        sql2 &= " GROUP BY generos.descripcion "
        If Me.txt_menor.Text <> "" And Me.txt_mayor.Text <> "" Then
            sql2 &= " HAVING SUM(detalles_factura.codigo_pelicula) > " & Me.txt_menor.Text
            sql2 &= " AND SUM(detalles_factura.codigo_pelicula) < " & Me.txt_mayor.Text
        End If

        DataSet_alquilerXgeneroBindingSource.DataSource = acceso.consultar(sql2)
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class