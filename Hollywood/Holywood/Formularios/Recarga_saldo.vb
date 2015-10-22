Public Class Recarga_saldo
    Dim acceso As New Acceso_Datos With { _
       ._esquema = "dbo." _
       , ._tabla = "socios"}

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.Close()

    End Sub
    Private Function nuevo_saldo() As Integer
        Dim tabla As New Data.DataTable
        Dim nuevo As New Integer

        tabla = (Me.acceso.consultar("select saldo from dbo.socios where num_socio = " & Me.txt_num_socio.Text))

        nuevo = tabla.Rows(0)("saldo") + Me.txt_nuevo_saldo.Text

        Return nuevo

    End Function


    Public Sub carga_campos(ByVal nombre As String, ByVal apellido As String, ByVal num_socio As Integer, ByVal saldo_actual As Integer)

        Me.txt_nombre.Text = nombre
        Me.txt_apellido.Text = apellido
        Me.txt_num_socio.Text = num_socio
        Me.txt_saldo_actual.Text = saldo_actual
        Me.txt_nombre.Enabled = False
        Me.txt_apellido.Enabled = False
        Me.txt_num_socio.Enabled = False
        Me.txt_saldo_actual.Enabled = False



    End Sub

    Private Sub cmd_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cargar.Click

            Dim sql As String = ""
            sql = "update dbo.socios set saldo = " & nuevo_saldo() & "where num_socio = " & Me.txt_num_socio.Text
            Me.acceso.ejecutar(sql)
            Me.Close()


    End Sub
End Class