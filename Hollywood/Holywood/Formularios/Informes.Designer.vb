<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Me.cmd_pelixartista = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cmd_devolucionatrasada = New System.Windows.Forms.Button()
        Me.cmd_alquilerxgenero = New System.Windows.Forms.Button()
        Me.cmd_alquilerxsocio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_pelixartista
        '
        Me.cmd_pelixartista.Location = New System.Drawing.Point(48, 52)
        Me.cmd_pelixartista.Name = "cmd_pelixartista"
        Me.cmd_pelixartista.Size = New System.Drawing.Size(164, 38)
        Me.cmd_pelixartista.TabIndex = 0
        Me.cmd_pelixartista.Text = "Películas y artistas"
        Me.cmd_pelixartista.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 16.16!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reportes y estadísticas"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 239)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_devolucionatrasada
        '
        Me.cmd_devolucionatrasada.Location = New System.Drawing.Point(48, 184)
        Me.cmd_devolucionatrasada.Name = "cmd_devolucionatrasada"
        Me.cmd_devolucionatrasada.Size = New System.Drawing.Size(164, 38)
        Me.cmd_devolucionatrasada.TabIndex = 4
        Me.cmd_devolucionatrasada.Text = "Devoluciones atrasadas"
        Me.cmd_devolucionatrasada.UseVisualStyleBackColor = True
        '
        'cmd_alquilerxgenero
        '
        Me.cmd_alquilerxgenero.Location = New System.Drawing.Point(48, 96)
        Me.cmd_alquilerxgenero.Name = "cmd_alquilerxgenero"
        Me.cmd_alquilerxgenero.Size = New System.Drawing.Size(164, 38)
        Me.cmd_alquilerxgenero.TabIndex = 5
        Me.cmd_alquilerxgenero.Text = "Alquileres por género"
        Me.cmd_alquilerxgenero.UseVisualStyleBackColor = True
        '
        'cmd_alquilerxsocio
        '
        Me.cmd_alquilerxsocio.Location = New System.Drawing.Point(48, 140)
        Me.cmd_alquilerxsocio.Name = "cmd_alquilerxsocio"
        Me.cmd_alquilerxsocio.Size = New System.Drawing.Size(164, 38)
        Me.cmd_alquilerxsocio.TabIndex = 6
        Me.cmd_alquilerxsocio.Text = "Alquileres por socio"
        Me.cmd_alquilerxsocio.UseVisualStyleBackColor = True
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 291)
        Me.Controls.Add(Me.cmd_alquilerxsocio)
        Me.Controls.Add(Me.cmd_alquilerxgenero)
        Me.Controls.Add(Me.cmd_devolucionatrasada)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_pelixartista)
        Me.MaximizeBox = False
        Me.Name = "Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes - Hollywood"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_pelixartista As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_devolucionatrasada As System.Windows.Forms.Button
    Friend WithEvents cmd_alquilerxgenero As System.Windows.Forms.Button
    Friend WithEvents cmd_alquilerxsocio As System.Windows.Forms.Button
End Class
