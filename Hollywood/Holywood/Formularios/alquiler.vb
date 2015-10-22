Public Class Alquiler
    Dim tabla_peliculas As Data.DataTable

    Public Sub New(ByVal peliculas As Data.DataTable)
        Me.tabla_peliculas = peliculas
        InitializeComponent()
    End Sub

    Private Sub Alquiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For c = 0 To Me.tabla_peliculas.Rows.Count - 1
            Me.grid_carro_peliculas.Rows.Add(Me.tabla_peliculas.Rows(c)("titulo"), _
                                             Me.tabla_peliculas.Rows(c)("formato"), _
                                             Me.tabla_peliculas.Rows(c)("precio"), _
                                             Me.tabla_peliculas.Rows(c)("codigo"))
        Next
        lbl_usuario.Text = Inicio.principal.obtener_nombre_completo_socio()
        'Me.mostrar_total()
    End Sub

    'Private Sub mostrar_total()
    '    Dim total As Integer = 0
    '    For c = 0 To Me.grid_carro_peliculas.Rows.Count - 1
    '        total += Me.grid_carro_peliculas.Rows.
    '    Next
    '    lbl_total.Text = "Total: $" + total
    'End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class