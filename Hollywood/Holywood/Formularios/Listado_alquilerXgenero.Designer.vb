<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_alquilerXgenero
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataSet_alquilerXgeneroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.txt_nombre_genero = New System.Windows.Forms.TextBox()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.txt_nombre_pelicula = New System.Windows.Forms.TextBox()
        Me.lbl_pelicula = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cmd_buscarEst = New System.Windows.Forms.Button()
        Me.txt_mayor = New System.Windows.Forms.TextBox()
        Me.txt_menor = New System.Windows.Forms.TextBox()
        Me.lbl_menor = New System.Windows.Forms.Label()
        Me.lbl_mayor = New System.Windows.Forms.Label()
        CType(Me.DataSet_alquilerXgeneroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet_alquilerXgeneroBindingSource
        '
        Me.DataSet_alquilerXgeneroBindingSource.DataMember = "Listado alquiler_x_genero"
        Me.DataSet_alquilerXgeneroBindingSource.DataSource = GetType(WindowsApplication1.DataSet_alquilerXgenero)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(686, 349)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmd_buscar)
        Me.TabPage1.Controls.Add(Me.txt_nombre_genero)
        Me.TabPage1.Controls.Add(Me.lbl_genero)
        Me.TabPage1.Controls.Add(Me.txt_nombre_pelicula)
        Me.TabPage1.Controls.Add(Me.lbl_pelicula)
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(678, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de alquileres por genero"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscar.Location = New System.Drawing.Point(462, 260)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar.TabIndex = 11
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'txt_nombre_genero
        '
        Me.txt_nombre_genero.Location = New System.Drawing.Point(296, 271)
        Me.txt_nombre_genero.Name = "txt_nombre_genero"
        Me.txt_nombre_genero.Size = New System.Drawing.Size(138, 20)
        Me.txt_nombre_genero.TabIndex = 10
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Location = New System.Drawing.Point(248, 274)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(42, 13)
        Me.lbl_genero.TabIndex = 9
        Me.lbl_genero.Text = "Género"
        '
        'txt_nombre_pelicula
        '
        Me.txt_nombre_pelicula.Location = New System.Drawing.Point(68, 271)
        Me.txt_nombre_pelicula.Name = "txt_nombre_pelicula"
        Me.txt_nombre_pelicula.Size = New System.Drawing.Size(164, 20)
        Me.txt_nombre_pelicula.TabIndex = 8
        '
        'lbl_pelicula
        '
        Me.lbl_pelicula.AutoSize = True
        Me.lbl_pelicula.Location = New System.Drawing.Point(16, 274)
        Me.lbl_pelicula.Name = "lbl_pelicula"
        Me.lbl_pelicula.Size = New System.Drawing.Size(46, 13)
        Me.lbl_pelicula.TabIndex = 7
        Me.lbl_pelicula.Text = "Película"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataSet_alquilerXgeneroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Reporte_alquilerXgenero.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(663, 249)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmd_buscarEst)
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Controls.Add(Me.txt_mayor)
        Me.TabPage2.Controls.Add(Me.lbl_menor)
        Me.TabPage2.Controls.Add(Me.lbl_mayor)
        Me.TabPage2.Controls.Add(Me.txt_menor)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(678, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estadistica de cantidad de alquileres por genero"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.DataSet_alquilerXgeneroBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.ReporteEst_alquilerXgenero.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(14, 6)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(661, 265)
        Me.ReportViewer2.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 360)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_buscarEst
        '
        Me.cmd_buscarEst.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscarEst.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscarEst.Location = New System.Drawing.Point(501, 273)
        Me.cmd_buscarEst.Name = "cmd_buscarEst"
        Me.cmd_buscarEst.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscarEst.TabIndex = 16
        Me.cmd_buscarEst.UseVisualStyleBackColor = True
        '
        'txt_mayor
        '
        Me.txt_mayor.Location = New System.Drawing.Point(307, 284)
        Me.txt_mayor.Name = "txt_mayor"
        Me.txt_mayor.Size = New System.Drawing.Size(173, 20)
        Me.txt_mayor.TabIndex = 15
        '
        'txt_menor
        '
        Me.txt_menor.Location = New System.Drawing.Point(54, 284)
        Me.txt_menor.Name = "txt_menor"
        Me.txt_menor.Size = New System.Drawing.Size(173, 20)
        Me.txt_menor.TabIndex = 14
        '
        'lbl_menor
        '
        Me.lbl_menor.AutoSize = True
        Me.lbl_menor.Location = New System.Drawing.Point(11, 287)
        Me.lbl_menor.Name = "lbl_menor"
        Me.lbl_menor.Size = New System.Drawing.Size(37, 13)
        Me.lbl_menor.TabIndex = 13
        Me.lbl_menor.Text = "Menor"
        '
        'lbl_mayor
        '
        Me.lbl_mayor.AutoSize = True
        Me.lbl_mayor.Location = New System.Drawing.Point(250, 287)
        Me.lbl_mayor.Name = "lbl_mayor"
        Me.lbl_mayor.Size = New System.Drawing.Size(36, 13)
        Me.lbl_mayor.TabIndex = 12
        Me.lbl_mayor.Text = "Mayor"
        '
        'Listado_alquilerXgenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 412)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Listado_alquilerXgenero"
        Me.Text = "Listado_alquilerXgenero"
        CType(Me.DataSet_alquilerXgeneroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_pelicula As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_pelicula As System.Windows.Forms.TextBox
    Friend WithEvents lbl_genero As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_genero As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents DataSet_alquilerXgeneroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmd_buscarEst As System.Windows.Forms.Button
    Friend WithEvents txt_mayor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_menor As System.Windows.Forms.Label
    Friend WithEvents lbl_mayor As System.Windows.Forms.Label
    Friend WithEvents txt_menor As System.Windows.Forms.TextBox
End Class
