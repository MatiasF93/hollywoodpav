<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recarga_saldo
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
        Me.lbl_etiqueta = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_num_socio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_saldo_actual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_cargar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.txt_nuevo_saldo = New WindowsApplication1.MaskedTextBox_v1()
        Me.SuspendLayout()
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Segoe UI Light", 20.25!)
        Me.lbl_etiqueta.Location = New System.Drawing.Point(37, 24)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(210, 42)
        Me.lbl_etiqueta.TabIndex = 0
        Me.lbl_etiqueta.Text = "Recarga de saldo"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(91, 84)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(132, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(91, 110)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(132, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'txt_num_socio
        '
        Me.txt_num_socio.Location = New System.Drawing.Point(91, 136)
        Me.txt_num_socio.Name = "txt_num_socio"
        Me.txt_num_socio.Size = New System.Drawing.Size(132, 20)
        Me.txt_num_socio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero Socio"
        '
        'txt_saldo_actual
        '
        Me.txt_saldo_actual.Location = New System.Drawing.Point(91, 162)
        Me.txt_saldo_actual.Name = "txt_saldo_actual"
        Me.txt_saldo_actual.Size = New System.Drawing.Size(132, 20)
        Me.txt_saldo_actual.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Saldo Actual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Saldo a Cargar"
        '
        'cmd_cargar
        '
        Me.cmd_cargar.Location = New System.Drawing.Point(44, 238)
        Me.cmd_cargar.Name = "cmd_cargar"
        Me.cmd_cargar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cargar.TabIndex = 3
        Me.cmd_cargar.Text = "Cargar"
        Me.cmd_cargar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(148, 238)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 3
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'txt_nuevo_saldo
        '
        Me.txt_nuevo_saldo._mensaje_error = ""
        Me.txt_nuevo_saldo._validar = True
        Me.txt_nuevo_saldo.Location = New System.Drawing.Point(91, 183)
        Me.txt_nuevo_saldo.Mask = "99999"
        Me.txt_nuevo_saldo.Name = "txt_nuevo_saldo"
        Me.txt_nuevo_saldo.Size = New System.Drawing.Size(132, 20)
        Me.txt_nuevo_saldo.TabIndex = 4
        Me.txt_nuevo_saldo.ValidatingType = GetType(Integer)
        '
        'Recarga_saldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 311)
        Me.Controls.Add(Me.txt_nuevo_saldo)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_cargar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_saldo_actual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_num_socio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_etiqueta)
        Me.Name = "Recarga_saldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recarga_saldo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_etiqueta As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_num_socio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_saldo_actual As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_cargar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_nuevo_saldo As WindowsApplication1.MaskedTextBox_v1
End Class
