Public Class Listado_peliculasXartista
    Dim acceso As New Acceso_Datos
    Private Sub Listado_peliculasXartista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = ""
        sql = "SELECT  (artistas.nombres+' '+artistas.apellido) as nombre_artista,  peliculas.nombre as nombre_pelicula ,artistas_x_pelicula.personaje as personaje "
        sql &= " FROM artistas_x_pelicula INNER JOIN peliculas ON artistas_x_pelicula.codigo_pelicula = peliculas.codigo_pelicula INNER JOIN artistas ON artistas_x_pelicula.matricula = artistas.matricula "
        DataSet_peliculasXartistaBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

  
    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        sql = "SELECT  (artistas.nombres+' '+artistas.apellido) as nombre_artista,  peliculas.nombre as nombre_pelicula ,artistas_x_pelicula.personaje as personaje "
        sql &= " FROM artistas_x_pelicula INNER JOIN peliculas ON artistas_x_pelicula.codigo_pelicula = peliculas.codigo_pelicula INNER JOIN artistas ON artistas_x_pelicula.matricula = artistas.matricula "
        sql &= " WHERE (artistas.nombres+' '+artistas.apellido) LIKE '%" & Me.txt_nombre_artista.Text & "%'"
        DataSet_peliculasXartistaBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class