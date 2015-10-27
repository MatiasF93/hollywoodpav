<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquileres
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_documento = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_tipo_doc = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.grid_alquileres = New System.Windows.Forms.DataGridView()
        Me.dtp_fecha_alquiler = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_alquiler = New System.Windows.Forms.Label()
        Me.chb_incluir_devueltos = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txt_nro_factura = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tipo_doc_socio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc_socio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido_socio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant_pelis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_alquiler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_devolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.devolucion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.anular = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.grid_alquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 460)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alquileres"
        '
        'txt_documento
        '
        Me.txt_documento.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txt_documento.Location = New System.Drawing.Point(488, 105)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(79, 22)
        Me.txt_documento.TabIndex = 20
        '
        'lbl_tipo_doc
        '
        Me.lbl_tipo_doc.AutoSize = True
        Me.lbl_tipo_doc.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lbl_tipo_doc.Location = New System.Drawing.Point(185, 109)
        Me.lbl_tipo_doc.Name = "lbl_tipo_doc"
        Me.lbl_tipo_doc.Size = New System.Drawing.Size(91, 13)
        Me.lbl_tipo_doc.TabIndex = 23
        Me.lbl_tipo_doc.Text = "Tipo documento"
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(282, 106)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(120, 21)
        Me.cmb_tipo_doc.TabIndex = 19
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lbl_documento.Location = New System.Drawing.Point(415, 110)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(67, 13)
        Me.lbl_documento.TabIndex = 22
        Me.lbl_documento.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Búsqueda por socio"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.cmd_buscar.Location = New System.Drawing.Point(716, 75)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar.TabIndex = 30
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'grid_alquileres
        '
        Me.grid_alquileres.AllowUserToAddRows = False
        Me.grid_alquileres.AllowUserToDeleteRows = False
        Me.grid_alquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_alquileres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipo_doc_socio, Me.nro_doc_socio, Me.apellido_socio, Me.nro_factura, Me.cant_pelis, Me.monto, Me.fecha_alquiler, Me.fecha_devolucion, Me.ver, Me.devolucion, Me.anular})
        Me.grid_alquileres.Location = New System.Drawing.Point(12, 147)
        Me.grid_alquileres.Name = "grid_alquileres"
        Me.grid_alquileres.Size = New System.Drawing.Size(962, 307)
        Me.grid_alquileres.TabIndex = 31
        '
        'dtp_fecha_alquiler
        '
        Me.dtp_fecha_alquiler.Location = New System.Drawing.Point(110, 59)
        Me.dtp_fecha_alquiler.Name = "dtp_fecha_alquiler"
        Me.dtp_fecha_alquiler.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha_alquiler.TabIndex = 32
        Me.dtp_fecha_alquiler.Value = New Date(1999, 12, 31, 17, 33, 0, 0)
        '
        'lbl_fecha_alquiler
        '
        Me.lbl_fecha_alquiler.AutoSize = True
        Me.lbl_fecha_alquiler.Location = New System.Drawing.Point(16, 65)
        Me.lbl_fecha_alquiler.Name = "lbl_fecha_alquiler"
        Me.lbl_fecha_alquiler.Size = New System.Drawing.Size(88, 13)
        Me.lbl_fecha_alquiler.TabIndex = 33
        Me.lbl_fecha_alquiler.Text = "Fecha de alquiler"
        '
        'chb_incluir_devueltos
        '
        Me.chb_incluir_devueltos.AutoSize = True
        Me.chb_incluir_devueltos.Location = New System.Drawing.Point(517, 61)
        Me.chb_incluir_devueltos.Name = "chb_incluir_devueltos"
        Me.chb_incluir_devueltos.Size = New System.Drawing.Size(164, 17)
        Me.chb_incluir_devueltos.TabIndex = 34
        Me.chb_incluir_devueltos.Text = "Incluir alquileres ya devueltos"
        Me.chb_incluir_devueltos.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(986, 512)
        Me.ShapeContainer1.TabIndex = 35
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 677
        Me.LineShape1.Y1 = 95
        Me.LineShape1.Y2 = 95
        '
        'txt_nro_factura
        '
        Me.txt_nro_factura.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txt_nro_factura.Location = New System.Drawing.Point(410, 57)
        Me.txt_nro_factura.Mask = "99999999"
        Me.txt_nro_factura.Name = "txt_nro_factura"
        Me.txt_nro_factura.Size = New System.Drawing.Size(79, 22)
        Me.txt_nro_factura.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(337, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nro factura"
        '
        'tipo_doc_socio
        '
        Me.tipo_doc_socio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipo_doc_socio.HeaderText = "Tipo doc socio"
        Me.tipo_doc_socio.Name = "tipo_doc_socio"
        Me.tipo_doc_socio.ToolTipText = "Tipo doc socio"
        Me.tipo_doc_socio.Width = 102
        '
        'nro_doc_socio
        '
        Me.nro_doc_socio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nro_doc_socio.HeaderText = "Documento socio"
        Me.nro_doc_socio.Name = "nro_doc_socio"
        Me.nro_doc_socio.Width = 105
        '
        'apellido_socio
        '
        Me.apellido_socio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.apellido_socio.HeaderText = "Apellido socio"
        Me.apellido_socio.Name = "apellido_socio"
        Me.apellido_socio.Width = 89
        '
        'nro_factura
        '
        Me.nro_factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nro_factura.HeaderText = "Número factura"
        Me.nro_factura.Name = "nro_factura"
        Me.nro_factura.Width = 96
        '
        'cant_pelis
        '
        Me.cant_pelis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cant_pelis.HeaderText = "Cantidad películas"
        Me.cant_pelis.Name = "cant_pelis"
        Me.cant_pelis.Width = 110
        '
        'monto
        '
        Me.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.Width = 62
        '
        'fecha_alquiler
        '
        Me.fecha_alquiler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecha_alquiler.HeaderText = "Fecha alquiler"
        Me.fecha_alquiler.Name = "fecha_alquiler"
        Me.fecha_alquiler.Width = 90
        '
        'fecha_devolucion
        '
        Me.fecha_devolucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fecha_devolucion.HeaderText = "Fecha devolución"
        Me.fecha_devolucion.Name = "fecha_devolucion"
        Me.fecha_devolucion.Visible = False
        Me.fecha_devolucion.Width = 107
        '
        'ver
        '
        Me.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ver.HeaderText = "Ver"
        Me.ver.Name = "ver"
        Me.ver.Text = "Ver"
        Me.ver.ToolTipText = "Ver"
        Me.ver.UseColumnTextForButtonValue = True
        Me.ver.Width = 29
        '
        'devolucion
        '
        Me.devolucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.devolucion.HeaderText = "Devolución"
        Me.devolucion.Name = "devolucion"
        Me.devolucion.Text = "Devolución"
        Me.devolucion.ToolTipText = "Devolución"
        Me.devolucion.UseColumnTextForButtonValue = True
        Me.devolucion.Width = 67
        '
        'anular
        '
        Me.anular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.anular.HeaderText = "Anular"
        Me.anular.Name = "anular"
        Me.anular.Text = "Anular"
        Me.anular.ToolTipText = "Anular"
        Me.anular.UseColumnTextForButtonValue = True
        Me.anular.Width = 43
        '
        'Alquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 512)
        Me.Controls.Add(Me.txt_nro_factura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chb_incluir_devueltos)
        Me.Controls.Add(Me.lbl_fecha_alquiler)
        Me.Controls.Add(Me.dtp_fecha_alquiler)
        Me.Controls.Add(Me.grid_alquileres)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.lbl_tipo_doc)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.lbl_documento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Alquileres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alquileres - Hollywood"
        CType(Me.grid_alquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_tipo_doc As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents grid_alquileres As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_fecha_alquiler As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha_alquiler As System.Windows.Forms.Label
    Friend WithEvents chb_incluir_devueltos As System.Windows.Forms.CheckBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txt_nro_factura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tipo_doc_socio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc_socio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido_socio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant_pelis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_alquiler As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_devolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ver As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents devolucion As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents anular As System.Windows.Forms.DataGridViewButtonColumn
End Class
