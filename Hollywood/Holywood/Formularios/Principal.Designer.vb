<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.cmd_sesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_botones_socio = New System.Windows.Forms.Panel()
        Me.cmd_alquileres = New System.Windows.Forms.Button()
        Me.cmd_autorizados = New System.Windows.Forms.Button()
        Me.pnl_botones_admin = New System.Windows.Forms.Panel()
        Me.cmd_artistas = New System.Windows.Forms.Button()
        Me.cmd_socios = New System.Windows.Forms.Button()
        Me.cmd_formatos = New System.Windows.Forms.Button()
        Me.lbl_catalogo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_alquilar = New System.Windows.Forms.Button()
        Me.grid_peliculas_usuarios = New System.Windows.Forms.DataGridView()
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_estreno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chb_dados_baja = New System.Windows.Forms.CheckBox()
        Me.grid_peliculas = New System.Windows.Forms.DataGridView()
        Me.grid_pelicula_titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_pelicula_fecha_estreno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_pelicula_genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_pelicula_formato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_pelicula_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_fecha_baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.grid_pelicula_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_id_genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_id_formato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_nueva = New System.Windows.Forms.Button()
        Me.txt_director = New WindowsApplication1.TextBox_v1()
        Me.txt_actor = New WindowsApplication1.TextBox_v1()
        Me.txt_pelicula = New WindowsApplication1.TextBox_v1()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.lbl_director = New System.Windows.Forms.Label()
        Me.lbl_actor = New System.Windows.Forms.Label()
        Me.cmb_genero = New System.Windows.Forms.ComboBox()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.lbl_pelicula = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.pnl_botones_socio.SuspendLayout()
        Me.pnl_botones_admin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grid_peliculas_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_peliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_logo
        '
        Me.lbl_logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_logo.AutoEllipsis = True
        Me.lbl_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_logo.Font = New System.Drawing.Font("SF Hollywood Hills", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logo.Location = New System.Drawing.Point(24, 10)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(332, 148)
        Me.lbl_logo.TabIndex = 0
        Me.lbl_logo.Text = "HOLLYWOOD"
        Me.lbl_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.Location = New System.Drawing.Point(25, 193)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(331, 38)
        Me.lbl_bienvenido.TabIndex = 1
        Me.lbl_bienvenido.Text = "Bienvenido, administrador"
        Me.lbl_bienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_sesion
        '
        Me.cmd_sesion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmd_sesion.Location = New System.Drawing.Point(118, 469)
        Me.cmd_sesion.Name = "cmd_sesion"
        Me.cmd_sesion.Size = New System.Drawing.Size(131, 27)
        Me.cmd_sesion.TabIndex = 3
        Me.cmd_sesion.Text = "Cerrar sesión"
        Me.cmd_sesion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.pnl_botones_socio)
        Me.Panel1.Controls.Add(Me.pnl_botones_admin)
        Me.Panel1.Controls.Add(Me.lbl_logo)
        Me.Panel1.Controls.Add(Me.cmd_sesion)
        Me.Panel1.Controls.Add(Me.lbl_bienvenido)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 527)
        Me.Panel1.TabIndex = 4
        '
        'pnl_botones_socio
        '
        Me.pnl_botones_socio.Controls.Add(Me.cmd_alquileres)
        Me.pnl_botones_socio.Controls.Add(Me.cmd_autorizados)
        Me.pnl_botones_socio.Location = New System.Drawing.Point(103, 247)
        Me.pnl_botones_socio.Name = "pnl_botones_socio"
        Me.pnl_botones_socio.Size = New System.Drawing.Size(162, 162)
        Me.pnl_botones_socio.TabIndex = 10
        Me.pnl_botones_socio.Visible = False
        '
        'cmd_alquileres
        '
        Me.cmd_alquileres.Location = New System.Drawing.Point(15, 3)
        Me.cmd_alquileres.Name = "cmd_alquileres"
        Me.cmd_alquileres.Size = New System.Drawing.Size(131, 46)
        Me.cmd_alquileres.TabIndex = 12
        Me.cmd_alquileres.Text = "Alquileres"
        Me.cmd_alquileres.UseVisualStyleBackColor = True
        '
        'cmd_autorizados
        '
        Me.cmd_autorizados.Location = New System.Drawing.Point(15, 55)
        Me.cmd_autorizados.Name = "cmd_autorizados"
        Me.cmd_autorizados.Size = New System.Drawing.Size(131, 46)
        Me.cmd_autorizados.TabIndex = 11
        Me.cmd_autorizados.Text = "Autorizados"
        Me.cmd_autorizados.UseVisualStyleBackColor = True
        '
        'pnl_botones_admin
        '
        Me.pnl_botones_admin.Controls.Add(Me.cmd_artistas)
        Me.pnl_botones_admin.Controls.Add(Me.cmd_socios)
        Me.pnl_botones_admin.Controls.Add(Me.cmd_formatos)
        Me.pnl_botones_admin.Location = New System.Drawing.Point(103, 247)
        Me.pnl_botones_admin.Name = "pnl_botones_admin"
        Me.pnl_botones_admin.Size = New System.Drawing.Size(162, 162)
        Me.pnl_botones_admin.TabIndex = 9
        '
        'cmd_artistas
        '
        Me.cmd_artistas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmd_artistas.Location = New System.Drawing.Point(18, 3)
        Me.cmd_artistas.Name = "cmd_artistas"
        Me.cmd_artistas.Size = New System.Drawing.Size(131, 46)
        Me.cmd_artistas.TabIndex = 4
        Me.cmd_artistas.Text = "Artistas"
        Me.cmd_artistas.UseVisualStyleBackColor = True
        '
        'cmd_socios
        '
        Me.cmd_socios.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmd_socios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_socios.Location = New System.Drawing.Point(18, 55)
        Me.cmd_socios.Name = "cmd_socios"
        Me.cmd_socios.Size = New System.Drawing.Size(131, 46)
        Me.cmd_socios.TabIndex = 5
        Me.cmd_socios.Text = "Socios"
        Me.cmd_socios.UseVisualStyleBackColor = True
        '
        'cmd_formatos
        '
        Me.cmd_formatos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmd_formatos.Location = New System.Drawing.Point(18, 107)
        Me.cmd_formatos.Name = "cmd_formatos"
        Me.cmd_formatos.Size = New System.Drawing.Size(131, 46)
        Me.cmd_formatos.TabIndex = 6
        Me.cmd_formatos.Text = "Formatos"
        Me.cmd_formatos.UseVisualStyleBackColor = True
        '
        'lbl_catalogo
        '
        Me.lbl_catalogo.AutoSize = True
        Me.lbl_catalogo.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_catalogo.Location = New System.Drawing.Point(25, 10)
        Me.lbl_catalogo.Name = "lbl_catalogo"
        Me.lbl_catalogo.Size = New System.Drawing.Size(258, 37)
        Me.lbl_catalogo.TabIndex = 5
        Me.lbl_catalogo.Text = "Catálogo de películas"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.cmd_alquilar)
        Me.Panel2.Controls.Add(Me.grid_peliculas_usuarios)
        Me.Panel2.Controls.Add(Me.chb_dados_baja)
        Me.Panel2.Controls.Add(Me.grid_peliculas)
        Me.Panel2.Controls.Add(Me.cmd_nueva)
        Me.Panel2.Controls.Add(Me.txt_director)
        Me.Panel2.Controls.Add(Me.txt_actor)
        Me.Panel2.Controls.Add(Me.txt_pelicula)
        Me.Panel2.Controls.Add(Me.cmd_buscar)
        Me.Panel2.Controls.Add(Me.lbl_director)
        Me.Panel2.Controls.Add(Me.lbl_actor)
        Me.Panel2.Controls.Add(Me.cmb_genero)
        Me.Panel2.Controls.Add(Me.lbl_genero)
        Me.Panel2.Controls.Add(Me.lbl_pelicula)
        Me.Panel2.Controls.Add(Me.lbl_catalogo)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(363, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 527)
        Me.Panel2.TabIndex = 6
        '
        'cmd_alquilar
        '
        Me.cmd_alquilar.Location = New System.Drawing.Point(590, 67)
        Me.cmd_alquilar.Name = "cmd_alquilar"
        Me.cmd_alquilar.Size = New System.Drawing.Size(68, 40)
        Me.cmd_alquilar.TabIndex = 24
        Me.cmd_alquilar.Text = "Alquilar"
        Me.cmd_alquilar.UseVisualStyleBackColor = True
        Me.cmd_alquilar.Visible = False
        '
        'grid_peliculas_usuarios
        '
        Me.grid_peliculas_usuarios.AllowUserToAddRows = False
        Me.grid_peliculas_usuarios.AllowUserToDeleteRows = False
        Me.grid_peliculas_usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_peliculas_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid_peliculas_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_peliculas_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.titulo, Me.fecha_estreno, Me.genero, Me.formato, Me.precio, Me.DataGridViewButtonColumn1, Me.codigo})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_peliculas_usuarios.DefaultCellStyle = DataGridViewCellStyle8
        Me.grid_peliculas_usuarios.Location = New System.Drawing.Point(32, 160)
        Me.grid_peliculas_usuarios.Name = "grid_peliculas_usuarios"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_peliculas_usuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grid_peliculas_usuarios.Size = New System.Drawing.Size(715, 336)
        Me.grid_peliculas_usuarios.TabIndex = 23
        Me.grid_peliculas_usuarios.Visible = False
        '
        'titulo
        '
        Me.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.titulo.HeaderText = "Título"
        Me.titulo.Name = "titulo"
        Me.titulo.ToolTipText = "Título"
        Me.titulo.Width = 60
        '
        'fecha_estreno
        '
        Me.fecha_estreno.HeaderText = "Fecha de Estreno"
        Me.fecha_estreno.Name = "fecha_estreno"
        '
        'genero
        '
        Me.genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.genero.HeaderText = "Género"
        Me.genero.Name = "genero"
        Me.genero.ToolTipText = "Género"
        Me.genero.Width = 67
        '
        'formato
        '
        Me.formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.formato.HeaderText = "Formato"
        Me.formato.Name = "formato"
        Me.formato.Width = 70
        '
        'precio
        '
        Me.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.Width = 62
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewButtonColumn1.DataPropertyName = "Añadir"
        Me.DataGridViewButtonColumn1.HeaderText = "Añadir"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Añadir"
        Me.DataGridViewButtonColumn1.ToolTipText = "Añadir pelicula al carro"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 43
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.Visible = False
        '
        'chb_dados_baja
        '
        Me.chb_dados_baja.AutoSize = True
        Me.chb_dados_baja.Location = New System.Drawing.Point(534, 122)
        Me.chb_dados_baja.Name = "chb_dados_baja"
        Me.chb_dados_baja.Size = New System.Drawing.Size(124, 17)
        Me.chb_dados_baja.TabIndex = 23
        Me.chb_dados_baja.Text = "Incluir dados de baja"
        Me.chb_dados_baja.UseVisualStyleBackColor = True
        '
        'grid_peliculas
        '
        Me.grid_peliculas.AllowUserToAddRows = False
        Me.grid_peliculas.AllowUserToDeleteRows = False
        Me.grid_peliculas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_peliculas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grid_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_peliculas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grid_pelicula_titulo, Me.grid_pelicula_fecha_estreno, Me.grid_pelicula_genero, Me.grid_pelicula_formato, Me.grid_pelicula_precio, Me.grid_fecha_baja, Me.modificar, Me.eliminar, Me.grid_pelicula_codigo, Me.grid_id_genero, Me.grid_id_formato})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_peliculas.DefaultCellStyle = DataGridViewCellStyle11
        Me.grid_peliculas.Location = New System.Drawing.Point(32, 160)
        Me.grid_peliculas.Name = "grid_peliculas"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_peliculas.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grid_peliculas.Size = New System.Drawing.Size(715, 336)
        Me.grid_peliculas.TabIndex = 22
        '
        'grid_pelicula_titulo
        '
        Me.grid_pelicula_titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.grid_pelicula_titulo.HeaderText = "Título"
        Me.grid_pelicula_titulo.Name = "grid_pelicula_titulo"
        Me.grid_pelicula_titulo.ToolTipText = "Título"
        Me.grid_pelicula_titulo.Width = 60
        '
        'grid_pelicula_fecha_estreno
        '
        Me.grid_pelicula_fecha_estreno.HeaderText = "Fecha de Estreno"
        Me.grid_pelicula_fecha_estreno.Name = "grid_pelicula_fecha_estreno"
        '
        'grid_pelicula_genero
        '
        Me.grid_pelicula_genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.grid_pelicula_genero.HeaderText = "Género"
        Me.grid_pelicula_genero.Name = "grid_pelicula_genero"
        Me.grid_pelicula_genero.ToolTipText = "Género"
        Me.grid_pelicula_genero.Width = 67
        '
        'grid_pelicula_formato
        '
        Me.grid_pelicula_formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.grid_pelicula_formato.HeaderText = "Formato"
        Me.grid_pelicula_formato.Name = "grid_pelicula_formato"
        Me.grid_pelicula_formato.Width = 70
        '
        'grid_pelicula_precio
        '
        Me.grid_pelicula_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.grid_pelicula_precio.HeaderText = "Precio"
        Me.grid_pelicula_precio.Name = "grid_pelicula_precio"
        Me.grid_pelicula_precio.Width = 62
        '
        'grid_fecha_baja
        '
        Me.grid_fecha_baja.HeaderText = "Fecha de Baja"
        Me.grid_fecha_baja.Name = "grid_fecha_baja"
        Me.grid_fecha_baja.Visible = False
        '
        'modificar
        '
        Me.modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.modificar.DataPropertyName = "Modificar"
        Me.modificar.HeaderText = "Modificar"
        Me.modificar.Name = "modificar"
        Me.modificar.Text = "Modificar"
        Me.modificar.ToolTipText = "Modificar datos de pelicula"
        Me.modificar.UseColumnTextForButtonValue = True
        Me.modificar.Width = 56
        '
        'eliminar
        '
        Me.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.eliminar.DataPropertyName = "Eliminar"
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.ToolTipText = "Eliminar pelicula"
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 49
        '
        'grid_pelicula_codigo
        '
        Me.grid_pelicula_codigo.HeaderText = "codigo"
        Me.grid_pelicula_codigo.Name = "grid_pelicula_codigo"
        Me.grid_pelicula_codigo.Visible = False
        '
        'grid_id_genero
        '
        Me.grid_id_genero.HeaderText = "grid_id_genero"
        Me.grid_id_genero.Name = "grid_id_genero"
        Me.grid_id_genero.Visible = False
        '
        'grid_id_formato
        '
        Me.grid_id_formato.HeaderText = "grid_id_formato"
        Me.grid_id_formato.Name = "grid_id_formato"
        Me.grid_id_formato.Visible = False
        '
        'cmd_nueva
        '
        Me.cmd_nueva.Image = Global.WindowsApplication1.My.Resources.Resources._077_AddFile___copia
        Me.cmd_nueva.Location = New System.Drawing.Point(589, 67)
        Me.cmd_nueva.Name = "cmd_nueva"
        Me.cmd_nueva.Size = New System.Drawing.Size(40, 40)
        Me.cmd_nueva.TabIndex = 20
        Me.cmd_nueva.UseVisualStyleBackColor = True
        '
        'txt_director
        '
        Me.txt_director._mensaje_error = ""
        Me.txt_director._validar = True
        Me.txt_director.Location = New System.Drawing.Point(352, 98)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(164, 20)
        Me.txt_director.TabIndex = 17
        '
        'txt_actor
        '
        Me.txt_actor._mensaje_error = ""
        Me.txt_actor._validar = True
        Me.txt_actor.Location = New System.Drawing.Point(352, 64)
        Me.txt_actor.Name = "txt_actor"
        Me.txt_actor.Size = New System.Drawing.Size(164, 20)
        Me.txt_actor.TabIndex = 16
        '
        'txt_pelicula
        '
        Me.txt_pelicula._mensaje_error = ""
        Me.txt_pelicula._validar = True
        Me.txt_pelicula.Location = New System.Drawing.Point(95, 64)
        Me.txt_pelicula.Name = "txt_pelicula"
        Me.txt_pelicula.Size = New System.Drawing.Size(167, 20)
        Me.txt_pelicula.TabIndex = 15
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscar.Location = New System.Drawing.Point(534, 67)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar.TabIndex = 14
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'lbl_director
        '
        Me.lbl_director.AutoSize = True
        Me.lbl_director.Location = New System.Drawing.Point(299, 101)
        Me.lbl_director.Name = "lbl_director"
        Me.lbl_director.Size = New System.Drawing.Size(44, 13)
        Me.lbl_director.TabIndex = 12
        Me.lbl_director.Text = "Director"
        '
        'lbl_actor
        '
        Me.lbl_actor.AutoSize = True
        Me.lbl_actor.Location = New System.Drawing.Point(299, 67)
        Me.lbl_actor.Name = "lbl_actor"
        Me.lbl_actor.Size = New System.Drawing.Size(32, 13)
        Me.lbl_actor.TabIndex = 10
        Me.lbl_actor.Text = "Actor"
        '
        'cmb_genero
        '
        Me.cmb_genero.FormattingEnabled = True
        Me.cmb_genero.Location = New System.Drawing.Point(95, 98)
        Me.cmb_genero.Name = "cmb_genero"
        Me.cmb_genero.Size = New System.Drawing.Size(167, 21)
        Me.cmb_genero.TabIndex = 9
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Location = New System.Drawing.Point(32, 101)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(42, 13)
        Me.lbl_genero.TabIndex = 8
        Me.lbl_genero.Text = "Género"
        '
        'lbl_pelicula
        '
        Me.lbl_pelicula.AutoSize = True
        Me.lbl_pelicula.Location = New System.Drawing.Point(32, 67)
        Me.lbl_pelicula.Name = "lbl_pelicula"
        Me.lbl_pelicula.Size = New System.Drawing.Size(46, 13)
        Me.lbl_pelicula.TabIndex = 6
        Me.lbl_pelicula.Text = "Película"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(780, 527)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 36
        Me.LineShape1.X2 = 749
        Me.LineShape1.Y1 = 144
        Me.LineShape1.Y2 = 144
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hollywood"
        Me.Panel1.ResumeLayout(False)
        Me.pnl_botones_socio.ResumeLayout(False)
        Me.pnl_botones_admin.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grid_peliculas_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_peliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_logo As System.Windows.Forms.Label
    Friend WithEvents lbl_bienvenido As System.Windows.Forms.Label
    Friend WithEvents cmd_sesion As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_catalogo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_director As System.Windows.Forms.Label
    Friend WithEvents lbl_actor As System.Windows.Forms.Label
    Friend WithEvents cmb_genero As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_genero As System.Windows.Forms.Label
    Friend WithEvents lbl_pelicula As System.Windows.Forms.Label
    Friend WithEvents txt_director As WindowsApplication1.TextBox_v1
    Friend WithEvents txt_actor As WindowsApplication1.TextBox_v1
    Friend WithEvents txt_pelicula As WindowsApplication1.TextBox_v1
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmd_socios As System.Windows.Forms.Button
    Friend WithEvents cmd_artistas As System.Windows.Forms.Button
    Friend WithEvents cmd_nueva As System.Windows.Forms.Button
    Friend WithEvents cmd_formatos As System.Windows.Forms.Button
    Friend WithEvents grid_peliculas As System.Windows.Forms.DataGridView
    Friend WithEvents grid_peliculas_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents chb_dados_baja As System.Windows.Forms.CheckBox
    Friend WithEvents grid_pelicula_titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_pelicula_fecha_estreno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_pelicula_genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_pelicula_formato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_pelicula_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_fecha_baja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents grid_pelicula_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_id_genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_id_formato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnl_botones_admin As System.Windows.Forms.Panel
    Friend WithEvents pnl_botones_socio As System.Windows.Forms.Panel
    Friend WithEvents cmd_alquileres As System.Windows.Forms.Button
    Friend WithEvents cmd_autorizados As System.Windows.Forms.Button
    Friend WithEvents cmd_alquilar As System.Windows.Forms.Button
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_estreno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents formato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
