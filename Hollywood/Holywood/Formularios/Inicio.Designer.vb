<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.lbl_tipo_doc = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_ingresar = New System.Windows.Forms.Button()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.chb_admin = New System.Windows.Forms.CheckBox()
        Me.txt_contrasena = New WindowsApplication1.MaskedTextBox_v1()
        Me.txt_documento = New WindowsApplication1.MaskedTextBox_v1()
        Me.SuspendLayout()
        '
        'lbl_logo
        '
        Me.lbl_logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_logo.AutoEllipsis = True
        Me.lbl_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_logo.Font = New System.Drawing.Font("SF Hollywood Hills", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logo.Location = New System.Drawing.Point(19, 9)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(313, 148)
        Me.lbl_logo.TabIndex = 1
        Me.lbl_logo.Text = "HOLLYWOOD"
        Me.lbl_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_tipo_doc
        '
        Me.lbl_tipo_doc.AutoSize = True
        Me.lbl_tipo_doc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_doc.Location = New System.Drawing.Point(47, 202)
        Me.lbl_tipo_doc.Name = "lbl_tipo_doc"
        Me.lbl_tipo_doc.Size = New System.Drawing.Size(91, 13)
        Me.lbl_tipo_doc.TabIndex = 42
        Me.lbl_tipo_doc.Text = "Tipo documento"
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_tipo_doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmb_tipo_doc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(144, 199)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(155, 21)
        Me.cmb_tipo_doc.TabIndex = 0
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_documento.Location = New System.Drawing.Point(71, 229)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(67, 13)
        Me.lbl_documento.TabIndex = 41
        Me.lbl_documento.Text = "Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 30)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Bienvenido"
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = CType(resources.GetObject("cmd_salir.Image"), System.Drawing.Image)
        Me.cmd_salir.Location = New System.Drawing.Point(12, 329)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(40, 40)
        Me.cmd_salir.TabIndex = 5
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_ingresar
        '
        Me.cmd_ingresar.Image = CType(resources.GetObject("cmd_ingresar.Image"), System.Drawing.Image)
        Me.cmd_ingresar.Location = New System.Drawing.Point(304, 329)
        Me.cmd_ingresar.Name = "cmd_ingresar"
        Me.cmd_ingresar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_ingresar.TabIndex = 4
        Me.cmd_ingresar.UseVisualStyleBackColor = True
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.AutoSize = True
        Me.lbl_contrasena.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contrasena.Location = New System.Drawing.Point(77, 297)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(66, 13)
        Me.lbl_contrasena.TabIndex = 47
        Me.lbl_contrasena.Text = "Contraseña"
        Me.lbl_contrasena.Visible = False
        '
        'chb_admin
        '
        Me.chb_admin.AutoSize = True
        Me.chb_admin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_admin.Location = New System.Drawing.Point(50, 271)
        Me.chb_admin.Name = "chb_admin"
        Me.chb_admin.Size = New System.Drawing.Size(174, 17)
        Me.chb_admin.TabIndex = 2
        Me.chb_admin.Text = "Ingresar como administrador"
        Me.chb_admin.UseVisualStyleBackColor = True
        '
        'txt_contrasena
        '
        Me.txt_contrasena._mensaje_error = ""
        Me.txt_contrasena._validar = True
        Me.txt_contrasena.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contrasena.Location = New System.Drawing.Point(144, 294)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contrasena.Size = New System.Drawing.Size(100, 22)
        Me.txt_contrasena.TabIndex = 3
        Me.txt_contrasena.Visible = False
        '
        'txt_documento
        '
        Me.txt_documento._mensaje_error = "Por favor ingrese un número de documento."
        Me.txt_documento._validar = True
        Me.txt_documento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_documento.Location = New System.Drawing.Point(144, 226)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(100, 22)
        Me.txt_documento.TabIndex = 1
        '
        'Inicio
        '
        Me.AcceptButton = Me.cmd_ingresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 381)
        Me.Controls.Add(Me.chb_admin)
        Me.Controls.Add(Me.txt_contrasena)
        Me.Controls.Add(Me.lbl_contrasena)
        Me.Controls.Add(Me.cmd_ingresar)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.lbl_tipo_doc)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.lbl_documento)
        Me.Controls.Add(Me.lbl_logo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(372, 420)
        Me.MinimumSize = New System.Drawing.Size(372, 420)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hollywood - Iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_logo As System.Windows.Forms.Label
    Friend WithEvents txt_documento As WindowsApplication1.MaskedTextBox_v1
    Friend WithEvents lbl_tipo_doc As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_ingresar As System.Windows.Forms.Button
    Friend WithEvents lbl_contrasena As System.Windows.Forms.Label
    Friend WithEvents txt_contrasena As WindowsApplication1.MaskedTextBox_v1
    Friend WithEvents chb_admin As System.Windows.Forms.CheckBox
End Class
