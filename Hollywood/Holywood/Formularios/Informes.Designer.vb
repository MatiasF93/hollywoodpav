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
        Me.cmd_autorizadosxsocio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_pelixartista
        '
        Me.cmd_pelixartista.Location = New System.Drawing.Point(12, 96)
        Me.cmd_pelixartista.Name = "cmd_pelixartista"
        Me.cmd_pelixartista.Size = New System.Drawing.Size(232, 38)
        Me.cmd_pelixartista.TabIndex = 0
        Me.cmd_pelixartista.Text = "Listado de artistas por pelicula"
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
        'cmd_autorizadosxsocio
        '
        Me.cmd_autorizadosxsocio.Location = New System.Drawing.Point(12, 52)
        Me.cmd_autorizadosxsocio.Name = "cmd_autorizadosxsocio"
        Me.cmd_autorizadosxsocio.Size = New System.Drawing.Size(232, 38)
        Me.cmd_autorizadosxsocio.TabIndex = 2
        Me.cmd_autorizadosxsocio.Text = "Listado de autorizados por socio"
        Me.cmd_autorizadosxsocio.UseVisualStyleBackColor = True
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 327)
        Me.Controls.Add(Me.cmd_autorizadosxsocio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_pelixartista)
        Me.Name = "Informes"
        Me.Text = "Informes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_pelixartista As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_autorizadosxsocio As System.Windows.Forms.Button
End Class
