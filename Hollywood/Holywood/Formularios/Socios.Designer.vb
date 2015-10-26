<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_socios
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
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.lbl_nombres = New System.Windows.Forms.Label()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_doc = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.grid_socios = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_socio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipoIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lim_alq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Autorizados = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.recarga_saldo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_numero = New System.Windows.Forms.MaskedTextBox()
        Me.txt_documento = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_volver = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.txt_apellidos = New WindowsApplication1.TextBox_v1()
        Me.txt_nombres = New WindowsApplication1.TextBox_v1()
        CType(Me.grid_socios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Socios"
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidos.Location = New System.Drawing.Point(243, 64)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(55, 13)
        Me.lbl_apellidos.TabIndex = 9
        Me.lbl_apellidos.Text = "Apellidos"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.AutoSize = True
        Me.lbl_nombres.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres.Location = New System.Drawing.Point(15, 64)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(53, 13)
        Me.lbl_nombres.TabIndex = 8
        Me.lbl_nombres.Text = "Nombres"
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_documento.Location = New System.Drawing.Point(246, 93)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(67, 13)
        Me.lbl_documento.TabIndex = 13
        Me.lbl_documento.Text = "Documento"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.Location = New System.Drawing.Point(467, 65)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(48, 13)
        Me.lbl_numero.TabIndex = 12
        Me.lbl_numero.Text = "Número"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'lbl_tipo_doc
        '
        Me.lbl_tipo_doc.AutoSize = True
        Me.lbl_tipo_doc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_doc.Location = New System.Drawing.Point(16, 93)
        Me.lbl_tipo_doc.Name = "lbl_tipo_doc"
        Me.lbl_tipo_doc.Size = New System.Drawing.Size(91, 13)
        Me.lbl_tipo_doc.TabIndex = 17
        Me.lbl_tipo_doc.Text = "Tipo documento"
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 17
        Me.LineShape1.X2 = 1457
        Me.LineShape1.Y1 = 127
        Me.LineShape1.Y2 = 127
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1043, 573)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'grid_socios
        '
        Me.grid_socios.AllowUserToAddRows = False
        Me.grid_socios.AllowUserToDeleteRows = False
        Me.grid_socios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_socios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.nombre, Me.nro_socio, Me.tipo_doc, Me.nro_doc, Me.domicilio, Me.saldo, Me.id_tipo_doc, Me.id_tipoIVA, Me.cuit, Me.lim_alq, Me.tel, Me.fecha_baja, Me.ver, Me.Autorizados, Me.recarga_saldo, Me.modificar, Me.eliminar})
        Me.grid_socios.Location = New System.Drawing.Point(6, 127)
        Me.grid_socios.Name = "grid_socios"
        Me.grid_socios.Size = New System.Drawing.Size(1017, 375)
        Me.grid_socios.TabIndex = 21
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
        'nro_socio
        '
        Me.nro_socio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nro_socio.HeaderText = "Número"
        Me.nro_socio.Name = "nro_socio"
        Me.nro_socio.ReadOnly = True
        Me.nro_socio.Width = 69
        '
        'tipo_doc
        '
        Me.tipo_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipo_doc.HeaderText = "Tipo doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        Me.tipo_doc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tipo_doc.Width = 74
        '
        'nro_doc
        '
        Me.nro_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nro_doc.HeaderText = "Número doc"
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.ReadOnly = True
        Me.nro_doc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nro_doc.Width = 90
        '
        'domicilio
        '
        Me.domicilio.HeaderText = "Domicilio"
        Me.domicilio.Name = "domicilio"
        '
        'saldo
        '
        Me.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.MinimumWidth = 20
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 59
        '
        'id_tipo_doc
        '
        Me.id_tipo_doc.HeaderText = "id_tipo_doc"
        Me.id_tipo_doc.Name = "id_tipo_doc"
        Me.id_tipo_doc.Visible = False
        '
        'id_tipoIVA
        '
        Me.id_tipoIVA.HeaderText = "id_tipoIVA"
        Me.id_tipoIVA.Name = "id_tipoIVA"
        Me.id_tipoIVA.Visible = False
        '
        'cuit
        '
        Me.cuit.HeaderText = "cuit"
        Me.cuit.Name = "cuit"
        Me.cuit.Visible = False
        '
        'lim_alq
        '
        Me.lim_alq.HeaderText = "lim_alq"
        Me.lim_alq.Name = "lim_alq"
        Me.lim_alq.Visible = False
        '
        'tel
        '
        Me.tel.HeaderText = "tel"
        Me.tel.Name = "tel"
        Me.tel.Visible = False
        '
        'fecha_baja
        '
        Me.fecha_baja.HeaderText = "Fecha baja"
        Me.fecha_baja.Name = "fecha_baja"
        '
        'ver
        '
        Me.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ver.HeaderText = "Ver"
        Me.ver.Name = "ver"
        Me.ver.Text = "Ver"
        Me.ver.ToolTipText = "Ver los datos completos de este socio."
        Me.ver.UseColumnTextForButtonValue = True
        Me.ver.Width = 29
        '
        'Autorizados
        '
        Me.Autorizados.HeaderText = "Autorizados"
        Me.Autorizados.Name = "Autorizados"
        Me.Autorizados.Text = "Autorizados"
        Me.Autorizados.UseColumnTextForButtonValue = True
        '
        'recarga_saldo
        '
        Me.recarga_saldo.HeaderText = "Recargar"
        Me.recarga_saldo.Name = "recarga_saldo"
        Me.recarga_saldo.Text = "Recargar"
        Me.recarga_saldo.ToolTipText = "Recarga el saldo de este socio"
        Me.recarga_saldo.UseColumnTextForButtonValue = True
        '
        'modificar
        '
        Me.modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.modificar.HeaderText = "Modificar"
        Me.modificar.Name = "modificar"
        Me.modificar.Text = "Modificar"
        Me.modificar.ToolTipText = "Modificar los datos de este actor."
        Me.modificar.UseColumnTextForButtonValue = True
        Me.modificar.Width = 56
        '
        'eliminar
        '
        Me.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.eliminar.HeaderText = "Eliminar "
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Text = "Eliminar "
        Me.eliminar.ToolTipText = "Eliminar a este actor."
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 52
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(521, 61)
        Me.txt_numero.Mask = "999999"
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(116, 22)
        Me.txt_numero.TabIndex = 2
        '
        'txt_documento
        '
        Me.txt_documento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_documento.Location = New System.Drawing.Point(319, 89)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(79, 22)
        Me.txt_documento.TabIndex = 4
        '
        'cmd_volver
        '
        Me.cmd_volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_volver.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.cmd_volver.Location = New System.Drawing.Point(12, 521)
        Me.cmd_volver.Name = "cmd_volver"
        Me.cmd_volver.Size = New System.Drawing.Size(40, 40)
        Me.cmd_volver.TabIndex = 7
        Me.cmd_volver.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_nuevo.Image = Global.WindowsApplication1.My.Resources.Resources._077_AddFile___copia
        Me.cmd_nuevo.Location = New System.Drawing.Point(760, 66)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.cmd_nuevo.TabIndex = 6
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscar.Location = New System.Drawing.Point(701, 66)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar.TabIndex = 5
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'txt_apellidos
        '
        Me.txt_apellidos._mensaje_error = ""
        Me.txt_apellidos._validar = True
        Me.txt_apellidos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellidos.Location = New System.Drawing.Point(304, 61)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(127, 22)
        Me.txt_apellidos.TabIndex = 1
        '
        'txt_nombres
        '
        Me.txt_nombres._mensaje_error = ""
        Me.txt_nombres._validar = True
        Me.txt_nombres.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombres.Location = New System.Drawing.Point(85, 61)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(127, 22)
        Me.txt_nombres.TabIndex = 0
        '
        'frm_socios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_volver
        Me.ClientSize = New System.Drawing.Size(1043, 573)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.cmd_volver)
        Me.Controls.Add(Me.grid_socios)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.lbl_tipo_doc)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbl_documento)
        Me.Controls.Add(Me.lbl_numero)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.lbl_apellidos)
        Me.Controls.Add(Me.lbl_nombres)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.Name = "frm_socios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socios - Hollywood"
        CType(Me.grid_socios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_apellidos As WindowsApplication1.TextBox_v1
    Friend WithEvents txt_nombres As WindowsApplication1.TextBox_v1
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipo_doc As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents grid_socios As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_volver As System.Windows.Forms.Button
    Friend WithEvents txt_numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_socio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipoIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lim_alq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_baja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ver As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Autorizados As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents recarga_saldo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents modificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
