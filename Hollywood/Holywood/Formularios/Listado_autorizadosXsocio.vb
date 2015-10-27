Public Class Listado_autorizadosXsocio
    Dim acceso_aut As New Acceso_Datos With { _
       ._esquema = "dbo.", ._tabla = "autorizados_x_socio"}

    Private Sub Listado_autorizadosXsocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT tipos_documento.tipo_documento, autorizados_x_socio.documento"
        sql += " FROM dbo.autorizados_x_socio"
        sql += " JOIN tipos_documento ON autorizados_x_socio.id_tipo_documento = tipos_documento.id_tipo_documento "
        Me.DataSet_autorizadosXsocioBindingSource.DataSource = acceso_aut.consultar(sql)
        'DataSet_autorizadosXsocio es el nombre del conjunto de datos que tiene el reporte de esta pantalla.
        Me.reporte_autorizadosXsocio.RefreshReport()
        'reporte_autorizadosXSocio es el nombre del reporte de esta pantalla.
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim sql As String = "SELECT tipos_documento.tipo_documento, autorizados_x_socio.documento"
        sql += " FROM dbo.autorizados_x_socio"
        sql += " JOIN tipos_documento ON autorizados_x_socio.id_tipo_documento = tipos_documento.id_tipo_documento "
        If txt_documento.Text <> "" Then
            sql &= " WHERE documento like '%" & Me.txt_documento.Text & "%'"
        End If
        Me.DataSet_autorizadosXsocioBindingSource.DataSource = acceso_aut.consultar(sql)
        Me.reporte_autorizadosXsocio.RefreshReport()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub reporte_autorizadosXsocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reporte_autorizadosXsocio.Load

    End Sub
End Class