Public Class Listado_alquileresXgenero
    Dim acceso As New Acceso_Datos
    Private Sub Listado_alquileresXgenero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = ""
        sql = "SELECT  generos.descripcion as genero, COUNT(peliculas.nombre) as cantidad    "
        sql &= " FROM generos INNER JOIN peliculas ON peliculas.id_genero = generos.id_genero "
        sql &= "GROUP BY generos.descripcion"
        DataSet_alquileresXgeneroBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        sql = "SELECT  generos.descripcion as genero, COUNT(peliculas.nombre) as cantidad  "
        sql &= " FROM generos INNER JOIN peliculas ON peliculas.id_genero = generos.id_genero "
        sql &= " GORUP BY generos.descripcion "
        sql &= " HAVING SUM(peliculas.nombre) > " & Me.txt_menor.Text
        sql &= " AND SUM(peliculas.nombre) < " & Me.txt_mayor.Text
        DataSet_alquileresXgeneroBindingSource.DataSource = acceso.consultar(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub btn_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class