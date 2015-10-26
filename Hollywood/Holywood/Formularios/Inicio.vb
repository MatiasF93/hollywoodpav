Public Class Inicio
    Public artistas As frm_artistas
    Public socios As frm_socios
    Public formatos As frm_formatos
    Public registrar_alquiler As Registrar_alquiler
    Public inicio As Inicio
    Public principal As Principal
    Public alquileres As Alquileres
    Public salir As Boolean = False
    Dim PF As New Procesos_Formulario
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo.", ._tabla = "socios"}

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.carga_combo(cmb_tipo_doc, Me.acceso.leo_otra_tabla("tipos_documento"), "id_tipo_documento", "tipo_documento")
    End Sub

    Public Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, _
                            ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub chb_admin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chb_admin.CheckedChanged
        If Me.chb_admin.Checked = True Then
            Me.lbl_contrasena.Visible = True
            Me.txt_contrasena.Visible = True
            Me.cmb_tipo_doc.Enabled = False
            Me.txt_documento.Enabled = False
            Me.txt_documento.Clear()
            Me.txt_contrasena.Focus()
        Else
            Me.lbl_contrasena.Visible = False
            Me.txt_contrasena.Visible = False
            Me.cmb_tipo_doc.Enabled = True
            Me.txt_documento.Enabled = True
            Me.txt_contrasena.Clear()
            Me.txt_documento.Focus()
        End If
    End Sub

    Private Sub cmd_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        cmd_ingresar.Click
        If Me.chb_admin.Checked Then
            If Me.validar_contrasena() Then
                If Not principal Is Nothing Then
                    Me.principal.Dispose()
                End If
                Me.principal = New Principal()
                Me.principal.Show()
                Me.Visible = False
            End If
        Else
            Me.principal = New Principal(obtener_num_socio_actual())
            Me.principal.Show()
            Me.Visible = False
        End If
        Me.txt_documento.Clear()
        Me.txt_contrasena.Clear()
    End Sub

    Private Function validar_contrasena() As Boolean
        If Me.txt_contrasena.Text = "123" Then
            Return True
        Else
            MessageBox.Show("La contraseña ingresada no es válida.", "Error de ingreso", MessageBoxButtons.OK, _
                            MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    ''' <summary>
    ''' Obtiene el número del socio que se acaba de registrar en la BD.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function obtener_num_socio_actual() As Integer
        Dim tabla As System.Data.DataTable
        tabla = Me.acceso.leo_tabla("(id_tipo_documento = " & Me.cmb_tipo_doc.SelectedValue & _
                                    ") AND (nro_documento = " & txt_documento.Text + ")")
        Return tabla.Rows(0)("num_socio")
    End Function

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Dim respuesta As Integer = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "Salir", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Public Sub cerrar_aplicacion()
        If salir Then
            Application.Exit()
        End If
    End Sub

End Class