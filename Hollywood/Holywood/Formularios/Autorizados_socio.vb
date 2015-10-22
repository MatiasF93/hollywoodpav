Public Class Autorizados_socio

    Dim PF As New Procesos_Formulario
    Dim num_socio As Integer
    Dim acceso_aut As New Acceso_Datos With { _
       ._esquema = "dbo.", ._tabla = "autorizados_x_socio"}
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo.", ._tabla = "socios"}
    Dim registrar As Listado_autorizadosXsocio

    Public Sub New(ByVal num_socio As Integer)
        Me.num_socio = num_socio
        InitializeComponent()
    End Sub

    Private Sub Autorizados_socio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar_grilla("")
        Me.carga_combo(cmb_tipo_doc_aut, Me.acceso.leo_otra_tabla("tipos_documento"), "id_tipo_documento", "tipo_documento")
    End Sub

    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.grid_autorizados.Rows.Add(cmb_tipo_doc_aut.Text, txt_documento_aut.Text, cmb_tipo_doc_aut.SelectedValue)
        txt_documento_aut.Clear()
        cmb_tipo_doc_aut.SelectedIndex = -1
    End Sub

    Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, _
                            ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cmd_agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        If PF.validar(Me.Controls) = Procesos_Formulario.valid.correcta Then
            Me.registrar_asociado()
            Me.cargar_grilla("")
        End If
    End Sub

    Private Sub registrar_asociado()
        Dim sql As String = "INSERT INTO autorizados_x_socio(num_socio,documento,id_tipo_documento) VALUES "
        sql += "(" & Me.num_socio & " , " & Me.txt_documento_aut.Text & " , " & Me.cmb_tipo_doc_aut.SelectedValue & " )"
        Me.acceso_aut.ejecutar(sql)
    End Sub

    Private Sub grid_autorizados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_autorizados.CellContentClick
        If e.ColumnIndex = 3 Then
            Me.eliminar_asociado()
            Me.cargar_grilla("")
        End If
    End Sub

    Private Sub eliminar_asociado()
        If MsgBox("¿Está seguro que desea eliminar este autorizado? ", MsgBoxStyle.YesNo, "Confirmación") = Windows.Forms.DialogResult.Yes Then
            Dim eliminacion As String = " DELETE FROM autorizados_x_socio "
            eliminacion += " WHERE documento = " + Me.grid_autorizados.CurrentRow.Cells(1).Value.ToString()
            eliminacion += " AND id_tipo_documento = " + Me.grid_autorizados.CurrentRow.Cells(2).Value.ToString()
            Me.acceso_aut.ejecutar(eliminacion)
            MsgBox("Autorizado eliminado exitosamente.", MsgBoxStyle.Information, "Eliminación exitosa")
        End If
    End Sub

    Public Sub cargar_grilla(ByVal filtros As String)
        Me.grid_autorizados.Rows.Clear()
        Dim tabla As DataTable
        If filtros.Length = 0 Then
            tabla = acceso_aut.leo_tabla()
        Else
            tabla = acceso_aut.leo_tabla(filtros)
        End If

        Dim sql2 As String
        sql2 = "SELECT documento,id_tipo_documento FROM autorizados_x_socio WHERE num_socio = " & Me.num_socio
        Dim tabla2 = acceso_aut.consultar(sql2)

        Dim c As Integer = 0
        For c = 0 To tabla2.Rows.Count - 1

            Dim Sql = "SELECT tipo_documento FROM tipos_documento WHERE id_tipo_documento = " & tabla.Rows(c)("id_tipo_documento")
            Dim tabla3 = acceso.consultar(Sql)
            Dim tipo_doc As String = tabla3.Rows(0)("tipo_documento")
            Me.grid_autorizados.Rows.Add(tipo_doc, _
                                    tabla.Rows(c)("documento"),
                                    tabla.Rows(c)("id_tipo_documento"))
        Next
    End Sub

    Private Function obtener_autorizados() As System.Data.DataTable
        Dim tabla_aut As New DataTable
        tabla_aut = TryCast(Me.grid_autorizados.DataSource, DataTable)
        Return tabla_aut
    End Function

    Private Sub cmd_listado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_listado.Click
        registrar = New Listado_autorizadosXsocio()
        registrar.ShowDialog()
        registrar = Nothing
    End Sub
End Class