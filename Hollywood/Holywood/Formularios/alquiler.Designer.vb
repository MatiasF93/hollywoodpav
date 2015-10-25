<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquiler
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
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_alquiler = New System.Windows.Forms.Label()
        Me.grid_carro_peliculas = New System.Windows.Forms.DataGridView()
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_pelicula_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbl_carro = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.lbl_monto_total = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        CType(Me.grid_carro_peliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lbl_usuario.Location = New System.Drawing.Point(351, 9)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(129, 19)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Nombre del Usuario"
        '
        'lbl_alquiler
        '
        Me.lbl_alquiler.AutoSize = True
        Me.lbl_alquiler.Font = New System.Drawing.Font("Segoe UI Light", 20.25!)
        Me.lbl_alquiler.Location = New System.Drawing.Point(12, 9)
        Me.lbl_alquiler.Name = "lbl_alquiler"
        Me.lbl_alquiler.Size = New System.Drawing.Size(111, 37)
        Me.lbl_alquiler.TabIndex = 2
        Me.lbl_alquiler.Text = "Alquiler "
        '
        'grid_carro_peliculas
        '
        Me.grid_carro_peliculas.AllowUserToAddRows = False
        Me.grid_carro_peliculas.AllowUserToDeleteRows = False
        Me.grid_carro_peliculas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_carro_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_carro_peliculas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.titulo, Me.formato, Me.grid_pelicula_precio, Me.codigo, Me.quitar})
        Me.grid_carro_peliculas.Location = New System.Drawing.Point(19, 98)
        Me.grid_carro_peliculas.Name = "grid_carro_peliculas"
        Me.grid_carro_peliculas.Size = New System.Drawing.Size(458, 250)
        Me.grid_carro_peliculas.TabIndex = 23
        '
        'titulo
        '
        Me.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.titulo.HeaderText = "Título"
        Me.titulo.Name = "titulo"
        Me.titulo.ToolTipText = "Título"
        Me.titulo.Width = 62
        '
        'formato
        '
        Me.formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.formato.HeaderText = "Formato"
        Me.formato.Name = "formato"
        Me.formato.ToolTipText = "Formato"
        Me.formato.Width = 78
        '
        'grid_pelicula_precio
        '
        Me.grid_pelicula_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.grid_pelicula_precio.HeaderText = "Precio"
        Me.grid_pelicula_precio.Name = "grid_pelicula_precio"
        Me.grid_pelicula_precio.Width = 67
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.Visible = False
        '
        'quitar
        '
        Me.quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.quitar.DataPropertyName = "Quitar"
        Me.quitar.HeaderText = "Quitar"
        Me.quitar.Name = "quitar"
        Me.quitar.Text = "Quitar"
        Me.quitar.ToolTipText = "Quitar pelicula"
        Me.quitar.UseColumnTextForButtonValue = True
        Me.quitar.Width = 46
        '
        'lbl_carro
        '
        Me.lbl_carro.AutoSize = True
        Me.lbl_carro.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.lbl_carro.Location = New System.Drawing.Point(25, 65)
        Me.lbl_carro.Name = "lbl_carro"
        Me.lbl_carro.Size = New System.Drawing.Size(179, 30)
        Me.lbl_carro.TabIndex = 35
        Me.lbl_carro.Text = "Carro de Peliculas"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 394)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 37
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.Image = Global.WindowsApplication1.My.Resources.Resources._112_Tick_Green___copia
        Me.cmd_aceptar.Location = New System.Drawing.Point(440, 394)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_aceptar.TabIndex = 36
        Me.cmd_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_monto_total
        '
        Me.lbl_monto_total.AutoSize = True
        Me.lbl_monto_total.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_monto_total.Location = New System.Drawing.Point(422, 361)
        Me.lbl_monto_total.Name = "lbl_monto_total"
        Me.lbl_monto_total.Size = New System.Drawing.Size(18, 21)
        Me.lbl_monto_total.TabIndex = 39
        Me.lbl_monto_total.Text = "0"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_total.Location = New System.Drawing.Point(367, 361)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(59, 21)
        Me.lbl_total.TabIndex = 40
        Me.lbl_total.Text = "Total: $"
        '
        'Alquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 446)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_monto_total)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.cmd_aceptar)
        Me.Controls.Add(Me.lbl_carro)
        Me.Controls.Add(Me.grid_carro_peliculas)
        Me.Controls.Add(Me.lbl_alquiler)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Alquiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alquiler"
        CType(Me.grid_carro_peliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_alquiler As System.Windows.Forms.Label
    Friend WithEvents grid_carro_peliculas As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_carro As System.Windows.Forms.Label
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_monto_total As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents formato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_pelicula_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quitar As System.Windows.Forms.DataGridViewButtonColumn
End Class
