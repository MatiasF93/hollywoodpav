<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_artistas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombres = New System.Windows.Forms.Label()
        Me.lbl_Apellidos = New System.Windows.Forms.Label()
        Me.grid_artistas = New System.Windows.Forms.DataGridView()
        Me.cmd_volver = New System.Windows.Forms.Button()
        Me.chb_actor = New System.Windows.Forms.CheckBox()
        Me.chb_director = New System.Windows.Forms.CheckBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.chb_dados_baja = New System.Windows.Forms.CheckBox()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.es_actor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.es_director = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_apellidos = New WindowsApplication1.TextBox_v1()
        Me.txt_nombres = New WindowsApplication1.TextBox_v1()
        CType(Me.grid_artistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artistas"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.AutoSize = True
        Me.lbl_nombres.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres.Location = New System.Drawing.Point(24, 63)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(53, 13)
        Me.lbl_nombres.TabIndex = 1
        Me.lbl_nombres.Text = "Nombres"
        '
        'lbl_Apellidos
        '
        Me.lbl_Apellidos.AutoSize = True
        Me.lbl_Apellidos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellidos.Location = New System.Drawing.Point(22, 98)
        Me.lbl_Apellidos.Name = "lbl_Apellidos"
        Me.lbl_Apellidos.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Apellidos.TabIndex = 3
        Me.lbl_Apellidos.Text = "Apellidos"
        '
        'grid_artistas
        '
        Me.grid_artistas.AllowUserToAddRows = False
        Me.grid_artistas.AllowUserToDeleteRows = False
        Me.grid_artistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_artistas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.nombre, Me.matricula, Me.es_actor, Me.es_director, Me.fecha_nac, Me.fecha_baja, Me.modificar, Me.eliminar})
        Me.grid_artistas.Location = New System.Drawing.Point(19, 145)
        Me.grid_artistas.Name = "grid_artistas"
        Me.grid_artistas.Size = New System.Drawing.Size(657, 224)
        Me.grid_artistas.TabIndex = 5
        '
        'cmd_volver
        '
        Me.cmd_volver.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.cmd_volver.Location = New System.Drawing.Point(19, 375)
        Me.cmd_volver.Name = "cmd_volver"
        Me.cmd_volver.Size = New System.Drawing.Size(40, 40)
        Me.cmd_volver.TabIndex = 10
        Me.cmd_volver.UseVisualStyleBackColor = True
        '
        'chb_actor
        '
        Me.chb_actor.AutoSize = True
        Me.chb_actor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_actor.Location = New System.Drawing.Point(277, 62)
        Me.chb_actor.Name = "chb_actor"
        Me.chb_actor.Size = New System.Drawing.Size(66, 17)
        Me.chb_actor.TabIndex = 11
        Me.chb_actor.Text = "Es actor"
        Me.chb_actor.UseVisualStyleBackColor = True
        '
        'chb_director
        '
        Me.chb_director.AutoSize = True
        Me.chb_director.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_director.Location = New System.Drawing.Point(277, 97)
        Me.chb_director.Name = "chb_director"
        Me.chb_director.Size = New System.Drawing.Size(80, 17)
        Me.chb_director.TabIndex = 12
        Me.chb_director.Text = "Es director"
        Me.chb_director.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = Global.WindowsApplication1.My.Resources.Resources._077_AddFile___copia
        Me.cmd_nuevo.Location = New System.Drawing.Point(596, 68)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.cmd_nuevo.TabIndex = 9
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscar.Location = New System.Drawing.Point(537, 68)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar.TabIndex = 8
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 667
        Me.LineShape1.Y1 = 131
        Me.LineShape1.Y2 = 131
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(701, 421)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'chb_dados_baja
        '
        Me.chb_dados_baja.AutoSize = True
        Me.chb_dados_baja.Location = New System.Drawing.Point(376, 81)
        Me.chb_dados_baja.Name = "chb_dados_baja"
        Me.chb_dados_baja.Size = New System.Drawing.Size(134, 17)
        Me.chb_dados_baja.TabIndex = 14
        Me.chb_dados_baja.Text = "Incluir dados de baja"
        Me.chb_dados_baja.UseVisualStyleBackColor = True
        '
        'apellido
        '
        Me.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 120
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 120
        '
        'matricula
        '
        Me.matricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.matricula.HeaderText = "Matrícula"
        Me.matricula.Name = "matricula"
        Me.matricula.ReadOnly = True
        Me.matricula.Width = 60
        '
        'es_actor
        '
        Me.es_actor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.es_actor.HeaderText = "Es actor"
        Me.es_actor.Name = "es_actor"
        Me.es_actor.ReadOnly = True
        Me.es_actor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.es_actor.Width = 50
        '
        'es_director
        '
        Me.es_director.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.es_director.HeaderText = "Es director"
        Me.es_director.Name = "es_director"
        Me.es_director.ReadOnly = True
        Me.es_director.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.es_director.Width = 50
        '
        'fecha_nac
        '
        Me.fecha_nac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.fecha_nac.HeaderText = "Fecha de nacimiento"
        Me.fecha_nac.MinimumWidth = 20
        Me.fecha_nac.Name = "fecha_nac"
        Me.fecha_nac.ReadOnly = True
        Me.fecha_nac.Width = 20
        '
        'fecha_baja
        '
        Me.fecha_baja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecha_baja.HeaderText = "Fecha de baja"
        Me.fecha_baja.Name = "fecha_baja"
        Me.fecha_baja.Visible = False
        Me.fecha_baja.Width = 74
        '
        'modificar
        '
        Me.modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.modificar.HeaderText = "Modificar"
        Me.modificar.Name = "modificar"
        Me.modificar.Text = "Modificar"
        Me.modificar.ToolTipText = "Modificar los datos de este actor."
        Me.modificar.UseColumnTextForButtonValue = True
        Me.modificar.Width = 62
        '
        'eliminar
        '
        Me.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.eliminar.HeaderText = "Eliminar "
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Text = "Eliminar "
        Me.eliminar.ToolTipText = "Eliminar a este actor."
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 57
        '
        'txt_apellidos
        '
        Me.txt_apellidos._mensaje_error = ""
        Me.txt_apellidos._validar = True
        Me.txt_apellidos.Location = New System.Drawing.Point(88, 95)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(161, 22)
        Me.txt_apellidos.TabIndex = 7
        '
        'txt_nombres
        '
        Me.txt_nombres._mensaje_error = ""
        Me.txt_nombres._validar = True
        Me.txt_nombres.Location = New System.Drawing.Point(88, 60)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(161, 22)
        Me.txt_nombres.TabIndex = 6
        '
        'frm_artistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 421)
        Me.Controls.Add(Me.chb_dados_baja)
        Me.Controls.Add(Me.chb_director)
        Me.Controls.Add(Me.chb_actor)
        Me.Controls.Add(Me.cmd_volver)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.grid_artistas)
        Me.Controls.Add(Me.lbl_Apellidos)
        Me.Controls.Add(Me.lbl_nombres)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frm_artistas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artistas - Hollywood"
        CType(Me.grid_artistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellidos As System.Windows.Forms.Label
    Friend WithEvents grid_artistas As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombres As WindowsApplication1.TextBox_v1
    Friend WithEvents txt_apellidos As WindowsApplication1.TextBox_v1
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_volver As System.Windows.Forms.Button
    Friend WithEvents chb_actor As System.Windows.Forms.CheckBox
    Friend WithEvents chb_director As System.Windows.Forms.CheckBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents chb_dados_baja As System.Windows.Forms.CheckBox
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents es_actor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents es_director As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_baja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
