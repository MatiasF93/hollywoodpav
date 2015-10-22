Public Class frm_formatos

    Dim PF As New Procesos_Formulario
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "formatos"}
    Dim conexion As Object

    Private Sub frm_formatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Public Sub cargar_grilla()
        Me.grid_formatos.Rows.Clear()
        Dim tabla As DataTable = acceso.leo_tabla
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.grid_formatos.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1))
        Next
    End Sub

    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        If PF.validar(Me.Controls) = Procesos_Formulario.valid.correcta Then
            Dim datos As String = ""
            datos += "descripcion =" + txt_descripcion.Text
            Me.acceso.insertar(datos)
            Me.cargar_grilla()
        End If
    End Sub

    ''' <summary>
    ''' Este método ejecuta eliminación de un autorizado.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grid_artistas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_formatos.CellContentClick
        If e.ColumnIndex = 2 Then
            If MsgBox("¿Está seguro que desea eliminar este formato?", MsgBoxStyle.YesNo, "Confirmación") = Windows.Forms.DialogResult.Yes Then

                Dim eliminacion As String = "DELETE FROM formatos"
                eliminacion &= " WHERE id_formato = " & Me.grid_formatos.CurrentRow.Cells(0).Value
                Me.acceso.ejecutar(eliminacion)

               
                Me.cargar_grilla()
            End If
        End If
    End Sub

    Private Sub cmd_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_volver.Click
        Me.Close()
    End Sub
End Class