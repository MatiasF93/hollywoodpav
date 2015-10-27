<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_peliculasXartista
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataSet_peliculasXartistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre_artista = New System.Windows.Forms.TextBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_listado_artistasXpelicula = New System.Windows.Forms.TabPage()
        Me.tab_grafico_peliculasXartista = New System.Windows.Forms.TabPage()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.DataSet_peliculasXartistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_listado_artistasXpelicula.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet_peliculasXartistaBindingSource
        '
        Me.DataSet_peliculasXartistaBindingSource.DataMember = "peliculas_x_artista"
        Me.DataSet_peliculasXartistaBindingSource.DataSource = GetType(WindowsApplication1.DataSet_peliculasXartista)
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet_peliculas_por_artista"
        ReportDataSource2.Value = Me.DataSet_peliculasXartistaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Reporte_peliculasXartista.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 6)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(731, 332)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombe de artista"
        '
        'txt_nombre_artista
        '
        Me.txt_nombre_artista.Location = New System.Drawing.Point(263, 355)
        Me.txt_nombre_artista.Name = "txt_nombre_artista"
        Me.txt_nombre_artista.Size = New System.Drawing.Size(244, 20)
        Me.txt_nombre_artista.TabIndex = 2
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscar.Location = New System.Drawing.Point(513, 344)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar.TabIndex = 3
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_listado_artistasXpelicula)
        Me.TabControl1.Controls.Add(Me.tab_grafico_peliculasXartista)
        Me.TabControl1.Location = New System.Drawing.Point(15, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(751, 416)
        Me.TabControl1.TabIndex = 4
        '
        'tab_listado_artistasXpelicula
        '
        Me.tab_listado_artistasXpelicula.Controls.Add(Me.ReportViewer1)
        Me.tab_listado_artistasXpelicula.Controls.Add(Me.cmd_buscar)
        Me.tab_listado_artistasXpelicula.Controls.Add(Me.txt_nombre_artista)
        Me.tab_listado_artistasXpelicula.Controls.Add(Me.Label1)
        Me.tab_listado_artistasXpelicula.Location = New System.Drawing.Point(4, 22)
        Me.tab_listado_artistasXpelicula.Name = "tab_listado_artistasXpelicula"
        Me.tab_listado_artistasXpelicula.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_listado_artistasXpelicula.Size = New System.Drawing.Size(743, 390)
        Me.tab_listado_artistasXpelicula.TabIndex = 0
        Me.tab_listado_artistasXpelicula.Text = "Listado de artistas por pelicula"
        Me.tab_listado_artistasXpelicula.UseVisualStyleBackColor = True
        '
        'tab_grafico_peliculasXartista
        '
        Me.tab_grafico_peliculasXartista.Location = New System.Drawing.Point(4, 22)
        Me.tab_grafico_peliculasXartista.Name = "tab_grafico_peliculasXartista"
        Me.tab_grafico_peliculasXartista.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_grafico_peliculasXartista.Size = New System.Drawing.Size(712, 390)
        Me.tab_grafico_peliculasXartista.TabIndex = 1
        Me.tab_grafico_peliculasXartista.Text = "Gráfico de películas por artista"
        Me.tab_grafico_peliculasXartista.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 434)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Listado_peliculasXartista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 483)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Listado_peliculasXartista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de películas y artistas - Hollywood"
        CType(Me.DataSet_peliculasXartistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_listado_artistasXpelicula.ResumeLayout(False)
        Me.tab_listado_artistasXpelicula.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_artista As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents DataSet_peliculasXartistaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_listado_artistasXpelicula As System.Windows.Forms.TabPage
    Friend WithEvents tab_grafico_peliculasXartista As System.Windows.Forms.TabPage
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
