<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_socio
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
        Me.lbl_texto_nombre = New System.Windows.Forms.Label()
        Me.txt_domicilio = New WindowsApplication1.TextBox_v1()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_apellidos = New WindowsApplication1.TextBox_v1()
        Me.txt_nombres = New WindowsApplication1.TextBox_v1()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.lbl_nombres = New System.Windows.Forms.Label()
        Me.lbl_limite = New System.Windows.Forms.Label()
        Me.lbl_tipo_doc = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lbl_tipo_iva = New System.Windows.Forms.Label()
        Me.cmb_tipo_iva = New System.Windows.Forms.ComboBox()
        Me.txt_cuit = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cuit = New System.Windows.Forms.Label()
        Me.txt_limite = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_saldo = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_saldo = New System.Windows.Forms.Label()
        Me.txt_documento = New WindowsApplication1.MaskedTextBox_v1()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_texto_nombre
        '
        Me.lbl_texto_nombre.AutoSize = True
        Me.lbl_texto_nombre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texto_nombre.Location = New System.Drawing.Point(117, 87)
        Me.lbl_texto_nombre.Name = "lbl_texto_nombre"
        Me.lbl_texto_nombre.Size = New System.Drawing.Size(0, 13)
        Me.lbl_texto_nombre.TabIndex = 33
        '
        'txt_domicilio
        '
        Me.txt_domicilio._mensaje_error = "Por favor ingrese un domicilio."
        Me.txt_domicilio._validar = True
        Me.txt_domicilio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_domicilio.Location = New System.Drawing.Point(117, 141)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(187, 22)
        Me.txt_domicilio.TabIndex = 4
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matricula.Location = New System.Drawing.Point(56, 144)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(55, 13)
        Me.lbl_matricula.TabIndex = 29
        Me.lbl_matricula.Text = "Domicilio"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(181, 37)
        Me.lbl_titulo.TabIndex = 28
        Me.lbl_titulo.Text = "Registrar socio"
        '
        'txt_apellidos
        '
        Me.txt_apellidos._mensaje_error = "Por favor ingrese un apellido."
        Me.txt_apellidos._validar = True
        Me.txt_apellidos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellidos.Location = New System.Drawing.Point(117, 113)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(187, 22)
        Me.txt_apellidos.TabIndex = 3
        '
        'txt_nombres
        '
        Me.txt_nombres._mensaje_error = "Por favor ingrese un nombre."
        Me.txt_nombres._validar = True
        Me.txt_nombres.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombres.Location = New System.Drawing.Point(117, 85)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(187, 22)
        Me.txt_nombres.TabIndex = 2
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidos.Location = New System.Drawing.Point(56, 116)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(55, 13)
        Me.lbl_apellidos.TabIndex = 25
        Me.lbl_apellidos.Text = "Apellidos"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.AutoSize = True
        Me.lbl_nombres.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres.Location = New System.Drawing.Point(58, 87)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(53, 13)
        Me.lbl_nombres.TabIndex = 24
        Me.lbl_nombres.Text = "Nombres"
        '
        'lbl_limite
        '
        Me.lbl_limite.AutoSize = True
        Me.lbl_limite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limite.Location = New System.Drawing.Point(309, 172)
        Me.lbl_limite.Name = "lbl_limite"
        Me.lbl_limite.Size = New System.Drawing.Size(106, 13)
        Me.lbl_limite.TabIndex = 34
        Me.lbl_limite.Text = "Límite de alquileres"
        '
        'lbl_tipo_doc
        '
        Me.lbl_tipo_doc.AutoSize = True
        Me.lbl_tipo_doc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_doc.Location = New System.Drawing.Point(20, 59)
        Me.lbl_tipo_doc.Name = "lbl_tipo_doc"
        Me.lbl_tipo_doc.Size = New System.Drawing.Size(91, 13)
        Me.lbl_tipo_doc.TabIndex = 38
        Me.lbl_tipo_doc.Text = "Tipo documento"
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_tipo_doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmb_tipo_doc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(117, 56)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(187, 21)
        Me.cmb_tipo_doc.TabIndex = 0
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_documento.Location = New System.Drawing.Point(348, 60)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(67, 13)
        Me.lbl_documento.TabIndex = 36
        Me.lbl_documento.Text = "Documento"
        '
        'lbl_tipo_iva
        '
        Me.lbl_tipo_iva.AutoSize = True
        Me.lbl_tipo_iva.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_iva.Location = New System.Drawing.Point(367, 116)
        Me.lbl_tipo_iva.Name = "lbl_tipo_iva"
        Me.lbl_tipo_iva.Size = New System.Drawing.Size(49, 13)
        Me.lbl_tipo_iva.TabIndex = 41
        Me.lbl_tipo_iva.Text = "Tipo IVA"
        '
        'cmb_tipo_iva
        '
        Me.cmb_tipo_iva.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_iva.FormattingEnabled = True
        Me.cmb_tipo_iva.Location = New System.Drawing.Point(421, 113)
        Me.cmb_tipo_iva.Name = "cmb_tipo_iva"
        Me.cmb_tipo_iva.Size = New System.Drawing.Size(99, 21)
        Me.cmb_tipo_iva.TabIndex = 6
        '
        'txt_cuit
        '
        Me.txt_cuit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuit.Location = New System.Drawing.Point(421, 84)
        Me.txt_cuit.Mask = "99-99999999-9"
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(99, 22)
        Me.txt_cuit.TabIndex = 5
        '
        'lbl_cuit
        '
        Me.lbl_cuit.AutoSize = True
        Me.lbl_cuit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuit.Location = New System.Drawing.Point(385, 88)
        Me.lbl_cuit.Name = "lbl_cuit"
        Me.lbl_cuit.Size = New System.Drawing.Size(30, 13)
        Me.lbl_cuit.TabIndex = 42
        Me.lbl_cuit.Text = "CUIT"
        '
        'txt_limite
        '
        Me.txt_limite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_limite.Location = New System.Drawing.Point(421, 169)
        Me.txt_limite.Mask = "99999999"
        Me.txt_limite.Name = "txt_limite"
        Me.txt_limite.Size = New System.Drawing.Size(99, 22)
        Me.txt_limite.TabIndex = 9
        Me.txt_limite.Text = "10"
        '
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(421, 141)
        Me.txt_telefono.Mask = "99999999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(99, 22)
        Me.txt_telefono.TabIndex = 7
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(364, 144)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 45
        Me.lbl_telefono.Text = "Teléfono"
        '
        'txt_saldo
        '
        Me.txt_saldo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_saldo.Location = New System.Drawing.Point(117, 169)
        Me.txt_saldo.Mask = "999999"
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(99, 22)
        Me.txt_saldo.TabIndex = 8
        Me.txt_saldo.Text = "0"
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_saldo.Location = New System.Drawing.Point(42, 172)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(69, 13)
        Me.lbl_saldo.TabIndex = 47
        Me.lbl_saldo.Text = "Saldo inicial"
        '
        'txt_documento
        '
        Me.txt_documento._mensaje_error = "Por favor ingrese un número de documento."
        Me.txt_documento._validar = True
        Me.txt_documento.Location = New System.Drawing.Point(420, 56)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(100, 20)
        Me.txt_documento.TabIndex = 1
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 217)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.Image = Global.WindowsApplication1.My.Resources.Resources._112_Tick_Green___copia
        Me.cmd_aceptar.Location = New System.Drawing.Point(495, 217)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_aceptar.TabIndex = 13
        Me.cmd_aceptar.UseVisualStyleBackColor = True
        '
        'Registrar_socio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 272)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.txt_saldo)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txt_limite)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.lbl_cuit)
        Me.Controls.Add(Me.lbl_tipo_iva)
        Me.Controls.Add(Me.cmb_tipo_iva)
        Me.Controls.Add(Me.lbl_tipo_doc)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.lbl_documento)
        Me.Controls.Add(Me.lbl_limite)
        Me.Controls.Add(Me.lbl_texto_nombre)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.cmd_aceptar)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.lbl_matricula)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.lbl_apellidos)
        Me.Controls.Add(Me.lbl_nombres)
        Me.MaximizeBox = False
        Me.Name = "Registrar_socio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar socio - Hollywood"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_texto_nombre As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_domicilio As WindowsApplication1.TextBox_v1
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txt_apellidos As WindowsApplication1.TextBox_v1
    Friend WithEvents txt_nombres As WindowsApplication1.TextBox_v1
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_limite As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_iva As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_iva As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_cuit As System.Windows.Forms.Label
    Friend WithEvents txt_limite As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_saldo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_saldo As System.Windows.Forms.Label
    Friend WithEvents txt_documento As WindowsApplication1.MaskedTextBox_v1
    Friend WithEvents cmb_tipo_doc As System.Windows.Forms.ComboBox
End Class
