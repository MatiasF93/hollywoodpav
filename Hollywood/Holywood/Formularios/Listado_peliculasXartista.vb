Public Class Listado_peliculasXartista
    Dim acceso As New Acceso_Datos
    Private Sub Listado_peliculasXartista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = ""
        sql = "SELECT  (artistas.nombres+' '+artistas.apellido) as nombre_artista,  peliculas.nombre as nombre_pelicula ,artistas_x_pelicula.personaje as personaje "
        sql &= " FROM artistas_x_pelicula INNER JOIN peliculas ON artistas_x_pelicula.codigo_pelicula = peliculas.codigo_pelicula INNER JOIN artistas ON artistas_x_pelicula.matricula = artistas.matricula "
        peliculasXartistaBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
        Dim sql2 As String = ""

        sql2 = " SELECT  (artistas.nombres+' '+artistas.apellido) as nombre_artista, COUNT(artistas_x_pelicula.codigo_pelicula) AS cantidadp"
        sql2 &= " FROM  artistas_x_pelicula INNER JOIN artistas ON artistas.matricula = artistas_x_pelicula.matricula "
        sql2 &= " GROUP BY (artistas.nombres+' '+artistas.apellido) "
        If Me.txt_menor.Text <> "" And Me.txt_mayor.Text <> "" Then
            sql2 &= " HAVING SUM(artistas_x_pelicula.codigo_pelicula) > " & Me.txt_menor.Text
            sql2 &= " AND SUM(artistas_x_pelicula.codigo_pelicula) < " & Me.txt_mayor.Text
        End If

        DataSet_peliculasXartistaBindingSource.DataSource = acceso.consultar(sql2)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

  
    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        sql = "SELECT  (artistas.nombres+' '+artistas.apellido) as nombre_artista,  peliculas.nombre as nombre_pelicula ,artistas_x_pelicula.personaje as personaje "
        sql &= " FROM artistas_x_pelicula INNER JOIN peliculas ON artistas_x_pelicula.codigo_pelicula = peliculas.codigo_pelicula INNER JOIN artistas ON artistas_x_pelicula.matricula = artistas.matricula "
        sql &= " WHERE (artistas.nombres+' '+artistas.apellido) LIKE '%" & Me.txt_nombre_artista.Text & "%'"
        PeliculasxartistaBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

   
    Private Sub cmd_buscarEst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscarEst.Click
        Dim sql As String = ""

        sql = " SELECT  (artistas.nombres+' '+artistas.apellido) as nombre_artista, COUNT(artistas_x_pelicula.codigo_pelicula) AS cantidadp"
        sql &= " FROM  artistas_x_pelicula INNER JOIN artistas ON artistas.matricula = artistas_x_pelicula.matricula "
        sql &= " GROUP BY (artistas.nombres+' '+artistas.apellido) "
        If Me.txt_menor.Text <> "" And Me.txt_mayor.Text <> "" Then
            sql &= " HAVING SUM(artistas_x_pelicula.codigo_pelicula) > " & Me.txt_menor.Text
            sql &= " AND SUM(artistas_x_pelicula.codigo_pelicula) < " & Me.txt_mayor.Text
        End If

        DataSet_peliculasXartistaBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer2.RefreshReport()
    End Sub


    Private Sub ReportViewer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer2.Load

    End Sub
End Class