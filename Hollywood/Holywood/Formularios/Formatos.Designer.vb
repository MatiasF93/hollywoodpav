<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_formatos
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
        Me.grid_formatos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.cmd_volver = New System.Windows.Forms.Button()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.txt_descripcion = New WindowsApplication1.TextBox_v1()
        CType(Me.grid_formatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_formatos
        '
        Me.grid_formatos.AllowUserToAddRows = False
        Me.grid_formatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_formatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_formatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.descripcion, Me.eliminar})
        Me.grid_formatos.Location = New System.Drawing.Point(11, 134)
        Me.grid_formatos.Name = "grid_formatos"
        Me.grid_formatos.Size = New System.Drawing.Size(244, 184)
        Me.grid_formatos.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.ToolTipText = "Descripción"
        Me.descripcion.Width = 120
        '
        'eliminar
        '
        Me.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.ToolTipText = "Eliminar este formato."
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 49
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(10, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(122, 37)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Formatos"
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Image = Global.WindowsApplication1.My.Resources.Resources._077_AddFile___copia
        Me.cmd_agregar.Location = New System.Drawing.Point(215, 64)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_agregar.TabIndex = 6
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'cmd_volver
        '
        Me.cmd_volver.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.cmd_volver.Location = New System.Drawing.Point(11, 331)
        Me.cmd_volver.Name = "cmd_volver"
        Me.cmd_volver.Size = New System.Drawing.Size(40, 40)
        Me.cmd_volver.TabIndex = 7
        Me.cmd_volver.UseVisualStyleBackColor = True
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(14, 78)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(70, 13)
        Me.lbl_descripcion.TabIndex = 8
        Me.lbl_descripcion.Text = "Descripción:"
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 254
        Me.LineShape1.Y1 = 117
        Me.LineShape1.Y2 = 117
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(267, 383)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'txt_descripcion
        '
        Me.txt_descripcion._mensaje_error = "Por favor ingrese una descripción."
        Me.txt_descripcion._validar = True
        Me.txt_descripcion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.Location = New System.Drawing.Point(86, 75)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(123, 22)
        Me.txt_descripcion.TabIndex = 9
        '
        'frm_formatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 383)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.cmd_volver)
        Me.Controls.Add(Me.cmd_agregar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.grid_formatos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.Name = "frm_formatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formatos - Hollywood"
        CType(Me.grid_formatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_formatos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_volver As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txt_descripcion As WindowsApplication1.TextBox_v1
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
