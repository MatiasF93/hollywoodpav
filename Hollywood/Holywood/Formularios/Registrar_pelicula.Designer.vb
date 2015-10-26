<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_pelicula
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.cmd_volver = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grid_artistas = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.matricula_artista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.cmb_director = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_actor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_personaje = New WindowsApplication1.TextBox_v1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_codigo_pelicula = New System.Windows.Forms.Label()
        Me.cmb_formato = New System.Windows.Forms.ComboBox()
        Me.lbl_formato = New System.Windows.Forms.Label()
        Me.cmb_genero = New System.Windows.Forms.ComboBox()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.dtp_fecha_estreno = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_de_estreno = New System.Windows.Forms.Label()
        Me.lbl_precio_alquiler = New System.Windows.Forms.Label()
        Me.lbl_titulo_pelicula = New System.Windows.Forms.Label()
        Me.txt_precio = New WindowsApplication1.MaskedTextBox_v1()
        Me.txt_codigo = New WindowsApplication1.MaskedTextBox_v1()
        Me.txt_titulo = New WindowsApplication1.TextBox_v1()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_artistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(209, 37)
        Me.lbl_titulo.TabIndex = 9
        Me.lbl_titulo.Text = "Registrar película"
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.Image = Global.WindowsApplication1.My.Resources.Resources._112_Tick_Green___copia
        Me.cmd_aceptar.Location = New System.Drawing.Point(636, 527)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_aceptar.TabIndex = 6
        Me.cmd_aceptar.UseVisualStyleBackColor = True
        '
        'cmd_volver
        '
        Me.cmd_volver.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.cmd_volver.Location = New System.Drawing.Point(10, 527)
        Me.cmd_volver.Name = "cmd_volver"
        Me.cmd_volver.Size = New System.Drawing.Size(40, 40)
        Me.cmd_volver.TabIndex = 7
        Me.cmd_volver.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_artistas)
        Me.Panel1.Controls.Add(Me.cmd_agregar)
        Me.Panel1.Controls.Add(Me.cmb_director)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmb_actor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_personaje)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(10, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 325)
        Me.Panel1.TabIndex = 43
        '
        'grid_artistas
        '
        Me.grid_artistas.AllowUserToAddRows = False
        Me.grid_artistas.AllowUserToDeleteRows = False
        Me.grid_artistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_artistas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.nombre, Me.Personaje, Me.quitar, Me.matricula_artista})
        Me.grid_artistas.Location = New System.Drawing.Point(17, 120)
        Me.grid_artistas.Name = "grid_artistas"
        Me.grid_artistas.Size = New System.Drawing.Size(637, 200)
        Me.grid_artistas.TabIndex = 27
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
        'Personaje
        '
        Me.Personaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Personaje.HeaderText = "Personaje"
        Me.Personaje.Name = "Personaje"
        Me.Personaje.ReadOnly = True
        Me.Personaje.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Personaje.Width = 79
        '
        'quitar
        '
        Me.quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.quitar.HeaderText = "Quitar"
        Me.quitar.Name = "quitar"
        Me.quitar.Text = "Quitar"
        Me.quitar.ToolTipText = "Quitar a este artista."
        Me.quitar.UseColumnTextForButtonValue = True
        Me.quitar.Width = 41
        '
        'matricula_artista
        '
        Me.matricula_artista.HeaderText = "matricula_artista"
        Me.matricula_artista.Name = "matricula_artista"
        Me.matricula_artista.Visible = False
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_agregar.Image = Global.WindowsApplication1.My.Resources.Resources._112_Plus_Green___copia
        Me.cmd_agregar.Location = New System.Drawing.Point(616, 69)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(38, 37)
        Me.cmd_agregar.TabIndex = 3
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'cmb_director
        '
        Me.cmb_director.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_director.FormattingEnabled = True
        Me.cmb_director.Location = New System.Drawing.Point(111, 51)
        Me.cmb_director.Name = "cmb_director"
        Me.cmb_director.Size = New System.Drawing.Size(223, 21)
        Me.cmb_director.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre director"
        '
        'cmb_actor
        '
        Me.cmb_actor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_actor.FormattingEnabled = True
        Me.cmb_actor.Location = New System.Drawing.Point(111, 78)
        Me.cmb_actor.Name = "cmb_actor"
        Me.cmb_actor.Size = New System.Drawing.Size(223, 21)
        Me.cmb_actor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre actor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registrar artistas en película"
        '
        'txt_personaje
        '
        Me.txt_personaje._mensaje_error = ""
        Me.txt_personaje._validar = True
        Me.txt_personaje.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_personaje.Location = New System.Drawing.Point(403, 77)
        Me.txt_personaje.Name = "txt_personaje"
        Me.txt_personaje.Size = New System.Drawing.Size(207, 22)
        Me.txt_personaje.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Personaje"
        '
        'lbl_codigo_pelicula
        '
        Me.lbl_codigo_pelicula.AutoSize = True
        Me.lbl_codigo_pelicula.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_pelicula.Location = New System.Drawing.Point(378, 62)
        Me.lbl_codigo_pelicula.Name = "lbl_codigo_pelicula"
        Me.lbl_codigo_pelicula.Size = New System.Drawing.Size(45, 13)
        Me.lbl_codigo_pelicula.TabIndex = 38
        Me.lbl_codigo_pelicula.Text = "Código"
        '
        'cmb_formato
        '
        Me.cmb_formato.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_formato.FormattingEnabled = True
        Me.cmb_formato.Location = New System.Drawing.Point(429, 87)
        Me.cmb_formato.Name = "cmb_formato"
        Me.cmb_formato.Size = New System.Drawing.Size(146, 21)
        Me.cmb_formato.TabIndex = 4
        '
        'lbl_formato
        '
        Me.lbl_formato.AutoSize = True
        Me.lbl_formato.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_formato.Location = New System.Drawing.Point(373, 90)
        Me.lbl_formato.Name = "lbl_formato"
        Me.lbl_formato.Size = New System.Drawing.Size(50, 13)
        Me.lbl_formato.TabIndex = 36
        Me.lbl_formato.Text = "Formato"
        '
        'cmb_genero
        '
        Me.cmb_genero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_genero.FormattingEnabled = True
        Me.cmb_genero.Location = New System.Drawing.Point(109, 87)
        Me.cmb_genero.Name = "cmb_genero"
        Me.cmb_genero.Size = New System.Drawing.Size(223, 21)
        Me.cmb_genero.TabIndex = 1
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genero.Location = New System.Drawing.Point(58, 90)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(45, 13)
        Me.lbl_genero.TabIndex = 34
        Me.lbl_genero.Text = "Género"
        '
        'dtp_fecha_estreno
        '
        Me.dtp_fecha_estreno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_estreno.Location = New System.Drawing.Point(110, 114)
        Me.dtp_fecha_estreno.Name = "dtp_fecha_estreno"
        Me.dtp_fecha_estreno.Size = New System.Drawing.Size(222, 22)
        Me.dtp_fecha_estreno.TabIndex = 2
        Me.dtp_fecha_estreno.Value = New Date(2015, 9, 21, 21, 2, 47, 0)
        '
        'lbl_fecha_de_estreno
        '
        Me.lbl_fecha_de_estreno.AutoSize = True
        Me.lbl_fecha_de_estreno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha_de_estreno.Location = New System.Drawing.Point(9, 117)
        Me.lbl_fecha_de_estreno.Name = "lbl_fecha_de_estreno"
        Me.lbl_fecha_de_estreno.Size = New System.Drawing.Size(95, 13)
        Me.lbl_fecha_de_estreno.TabIndex = 32
        Me.lbl_fecha_de_estreno.Text = "Fecha de estreno"
        '
        'lbl_precio_alquiler
        '
        Me.lbl_precio_alquiler.AutoSize = True
        Me.lbl_precio_alquiler.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_alquiler.Location = New System.Drawing.Point(382, 117)
        Me.lbl_precio_alquiler.Name = "lbl_precio_alquiler"
        Me.lbl_precio_alquiler.Size = New System.Drawing.Size(41, 13)
        Me.lbl_precio_alquiler.TabIndex = 31
        Me.lbl_precio_alquiler.Text = "Precio "
        '
        'lbl_titulo_pelicula
        '
        Me.lbl_titulo_pelicula.AutoSize = True
        Me.lbl_titulo_pelicula.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo_pelicula.Location = New System.Drawing.Point(67, 62)
        Me.lbl_titulo_pelicula.Name = "lbl_titulo_pelicula"
        Me.lbl_titulo_pelicula.Size = New System.Drawing.Size(36, 13)
        Me.lbl_titulo_pelicula.TabIndex = 29
        Me.lbl_titulo_pelicula.Text = "Título"
        '
        'txt_precio
        '
        Me.txt_precio._mensaje_error = "Por favor ingrese un precio."
        Me.txt_precio._validar = True
        Me.txt_precio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(429, 114)
        Me.txt_precio.Mask = "999999"
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(146, 22)
        Me.txt_precio.TabIndex = 5
        '
        'txt_codigo
        '
        Me.txt_codigo._mensaje_error = "Por favor ingrese un código."
        Me.txt_codigo._validar = True
        Me.txt_codigo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(429, 59)
        Me.txt_codigo.Mask = "999999"
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(146, 22)
        Me.txt_codigo.TabIndex = 3
        '
        'txt_titulo
        '
        Me.txt_titulo._mensaje_error = "Por favor ingrese un título"
        Me.txt_titulo._validar = True
        Me.txt_titulo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_titulo.Location = New System.Drawing.Point(109, 59)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(223, 22)
        Me.txt_titulo.TabIndex = 0
        '
        'frm_registrar_pelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 579)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.lbl_codigo_pelicula)
        Me.Controls.Add(Me.cmb_formato)
        Me.Controls.Add(Me.lbl_formato)
        Me.Controls.Add(Me.cmb_genero)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.dtp_fecha_estreno)
        Me.Controls.Add(Me.lbl_fecha_de_estreno)
        Me.Controls.Add(Me.lbl_precio_alquiler)
        Me.Controls.Add(Me.txt_titulo)
        Me.Controls.Add(Me.lbl_titulo_pelicula)
        Me.Controls.Add(Me.cmd_aceptar)
        Me.Controls.Add(Me.cmd_volver)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "frm_registrar_pelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar película - Hollywood"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid_artistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents cmd_volver As System.Windows.Forms.Button
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_artistas As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_director As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_actor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_personaje As WindowsApplication1.TextBox_v1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As WindowsApplication1.MaskedTextBox_v1
    Friend WithEvents txt_codigo As WindowsApplication1.MaskedTextBox_v1
    Friend WithEvents lbl_codigo_pelicula As System.Windows.Forms.Label
    Friend WithEvents cmb_formato As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_formato As System.Windows.Forms.Label
    Friend WithEvents cmb_genero As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_genero As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_estreno As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_de_estreno As System.Windows.Forms.Label
    Friend WithEvents lbl_precio_alquiler As System.Windows.Forms.Label
    Friend WithEvents txt_titulo As WindowsApplication1.TextBox_v1
    Friend WithEvents lbl_titulo_pelicula As System.Windows.Forms.Label
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Personaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quitar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents matricula_artista As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
