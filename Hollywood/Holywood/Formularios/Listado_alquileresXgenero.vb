Public Class Listado_alquileresXgenero
    Dim acceso As New Acceso_Datos
    Private Sub Listado_alquileresXgenero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = ""
        sql = "SELECT  peliculas.nombre as nombre_alquiler,  generos.descripcion as nombre_genero  "
        sql &= " FROM generos INNER JOIN peliculas ON peliculas.id_genero = generos.id_genero "
        sql &= " WHERE (peliculas.fecha_alquiler IS NOT NULL) AND (generos.descripcion) LIKE '%" & Me.txt_nombre_genero.Text & "%'"
        DataSet_alquileresXgeneroBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        sql = "SELECT  peliculas.nombre as nombre_alquiler,  generos.descripcion as nombre_genero  "
        sql &= " FROM generos INNER JOIN peliculas ON peliculas.id_genero = generos.id_genero "
        sql &= " WHERE (peliculas.fecha_alquiler IS NOT NULL) AND (generos.descripcion) LIKE '%" & Me.txt_nombre_genero.Text & "%'"
        DataSet_alquileresXgeneroBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub btn_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class