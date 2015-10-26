<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Artista
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
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.lbl_nombres = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.chb_actor = New System.Windows.Forms.CheckBox()
        Me.chb_director = New System.Windows.Forms.CheckBox()
        Me.lbl_fecha_nac = New System.Windows.Forms.Label()
        Me.dtp_fecha_nac = New System.Windows.Forms.DateTimePicker()
        Me.txt_matricula = New WindowsApplication1.TextBox_v1()
        Me.txt_apellidos = New WindowsApplication1.TextBox_v1()
        Me.txt_nombres = New WindowsApplication1.TextBox_v1()
        Me.lbl_texto_nombre = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Location = New System.Drawing.Point(71, 101)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(49, 13)
        Me.lbl_apellidos.TabIndex = 9
        Me.lbl_apellidos.Text = "Apellidos"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.AutoSize = True
        Me.lbl_nombres.Location = New System.Drawing.Point(68, 66)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(49, 13)
        Me.lbl_nombres.TabIndex = 8
        Me.lbl_nombres.Text = "Nombres"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(191, 37)
        Me.lbl_titulo.TabIndex = 12
        Me.lbl_titulo.Text = "Registrar artista"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(68, 136)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(52, 13)
        Me.lbl_matricula.TabIndex = 13
        Me.lbl_matricula.Text = "Matrícula"
        '
        'chb_actor
        '
        Me.chb_actor.AutoSize = True
        Me.chb_actor.Location = New System.Drawing.Point(361, 65)
        Me.chb_actor.Name = "chb_actor"
        Me.chb_actor.Size = New System.Drawing.Size(51, 17)
        Me.chb_actor.TabIndex = 4
        Me.chb_actor.Text = "Actor"
        Me.chb_actor.UseVisualStyleBackColor = True
        '
        'chb_director
        '
        Me.chb_director.AutoSize = True
        Me.chb_director.Location = New System.Drawing.Point(361, 100)
        Me.chb_director.Name = "chb_director"
        Me.chb_director.Size = New System.Drawing.Size(63, 17)
        Me.chb_director.TabIndex = 5
        Me.chb_director.Text = "Director"
        Me.chb_director.UseVisualStyleBackColor = True
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(12, 175)
        Me.lbl_fecha_nac.Name = "lbl_fecha_nac"
        Me.lbl_fecha_nac.Size = New System.Drawing.Size(106, 13)
        Me.lbl_fecha_nac.TabIndex = 19
        Me.lbl_fecha_nac.Text = "Fecha de nacimiento"
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(137, 169)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha_nac.TabIndex = 3
        Me.dtp_fecha_nac.Value = New Date(2015, 9, 21, 4, 35, 22, 0)
        '
        'txt_matricula
        '
        Me.txt_matricula._mensaje_error = "Por favor ingrese una matrícula."
        Me.txt_matricula._validar = True
        Me.txt_matricula.Location = New System.Drawing.Point(137, 133)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(100, 20)
        Me.txt_matricula.TabIndex = 2
        '
        'txt_apellidos
        '
        Me.txt_apellidos._mensaje_error = "Por favor ingrese un apellido."
        Me.txt_apellidos._validar = True
        Me.txt_apellidos.Location = New System.Drawing.Point(137, 98)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(161, 20)
        Me.txt_apellidos.TabIndex = 1
        '
        'txt_nombres
        '
        Me.txt_nombres._mensaje_error = "Por favor ingrese un nombre."
        Me.txt_nombres._validar = True
        Me.txt_nombres.Location = New System.Drawing.Point(137, 63)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(161, 20)
        Me.txt_nombres.TabIndex = 0
        '
        'lbl_texto_nombre
        '
        Me.lbl_texto_nombre.AutoSize = True
        Me.lbl_texto_nombre.Location = New System.Drawing.Point(137, 65)
        Me.lbl_texto_nombre.Name = "lbl_texto_nombre"
        Me.lbl_texto_nombre.Size = New System.Drawing.Size(0, 13)
        Me.lbl_texto_nombre.TabIndex = 23
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 208)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.Image = Global.WindowsApplication1.My.Resources.Resources._112_Tick_Green___copia
        Me.cmd_aceptar.Location = New System.Drawing.Point(396, 208)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_aceptar.TabIndex = 6
        Me.cmd_aceptar.UseVisualStyleBackColor = True
        '
        'Registrar_Artista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 258)
        Me.Controls.Add(Me.lbl_texto_nombre)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.cmd_aceptar)
        Me.Controls.Add(Me.dtp_fecha_nac)
        Me.Controls.Add(Me.lbl_fecha_nac)
        Me.Controls.Add(Me.chb_director)
        Me.Controls.Add(Me.chb_actor)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.lbl_matricula)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.lbl_apellidos)
        Me.Controls.Add(Me.lbl_nombres)
        Me.MaximizeBox = False
        Me.Name = "Registrar_Artista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar artista - Hollywood"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_apellidos As WindowsApplication1.TextBox_v1
    Friend WithEvents txt_nombres As WindowsApplication1.TextBox_v1
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents txt_matricula As WindowsApplication1.TextBox_v1
    Friend WithEvents chb_actor As System.Windows.Forms.CheckBox
    Friend WithEvents chb_director As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_fecha_nac As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_texto_nombre As System.Windows.Forms.Label
End Class
