<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_autorizadosXsocio
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataSet_autorizadosXsocioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmd_volver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.reporte_autorizadosXsocio = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.txt_documento = New WindowsApplication1.MaskedTextBox_v1()
        CType(Me.DataSet_autorizadosXsocioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet_autorizadosXsocioBindingSource
        '
        Me.DataSet_autorizadosXsocioBindingSource.DataMember = "Autorizados"
        Me.DataSet_autorizadosXsocioBindingSource.DataSource = GetType(WindowsApplication1.DataSet_autorizadosXsocio)
        '
        'cmd_volver
        '
        Me.cmd_volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_volver.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.cmd_volver.Location = New System.Drawing.Point(325, 441)
        Me.cmd_volver.Name = "cmd_volver"
        Me.cmd_volver.Size = New System.Drawing.Size(40, 40)
        Me.cmd_volver.TabIndex = 24
        Me.cmd_volver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, -124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 37)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Socios"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.Button1.Location = New System.Drawing.Point(0, 565)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 26
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 37)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Listado de autorizados por socio"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 306)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'reporte_autorizadosXsocio
        '
        ReportDataSource1.Name = "dataset_autorizadosXsocio"
        ReportDataSource1.Value = Me.DataSet_autorizadosXsocioBindingSource
        Me.reporte_autorizadosXsocio.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reporte_autorizadosXsocio.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Reporte_autorizadosXsocio.rdlc"
        Me.reporte_autorizadosXsocio.Location = New System.Drawing.Point(12, 40)
        Me.reporte_autorizadosXsocio.Name = "reporte_autorizadosXsocio"
        Me.reporte_autorizadosXsocio.Size = New System.Drawing.Size(714, 260)
        Me.reporte_autorizadosXsocio.TabIndex = 4
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(269, 320)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(118, 13)
        Me.lbl_documento.TabIndex = 29
        Me.lbl_documento.Text = "Número de documento:"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscar.Location = New System.Drawing.Point(499, 305)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'txt_documento
        '
        Me.txt_documento._mensaje_error = ""
        Me.txt_documento._validar = True
        Me.txt_documento.Location = New System.Drawing.Point(393, 317)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(100, 20)
        Me.txt_documento.TabIndex = 0
        '
        'Listado_autorizadosXsocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 358)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.lbl_documento)
        Me.Controls.Add(Me.reporte_autorizadosXsocio)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_volver)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Listado_autorizadosXsocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de autorizados por socio - Hollywood"
        CType(Me.DataSet_autorizadosXsocioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_volver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents reporte_autorizadosXsocio As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet_autorizadosXsocioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents txt_documento As WindowsApplication1.MaskedTextBox_v1
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
End Class
