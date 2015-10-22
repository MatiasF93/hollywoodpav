<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autorizados_socio
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
        Me.txt_documento_aut = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_tipo_doc_aut = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc_aut = New System.Windows.Forms.ComboBox()
        Me.lbl_documento_aut = New System.Windows.Forms.Label()
        Me.grid_autorizados = New System.Windows.Forms.DataGridView()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cmd_listado = New System.Windows.Forms.Button()
        CType(Me.grid_autorizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_documento_aut
        '
        Me.txt_documento_aut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_documento_aut.Location = New System.Drawing.Point(354, 64)
        Me.txt_documento_aut.Mask = "99999999"
        Me.txt_documento_aut.Name = "txt_documento_aut"
        Me.txt_documento_aut.Size = New System.Drawing.Size(73, 22)
        Me.txt_documento_aut.TabIndex = 56
        '
        'lbl_tipo_doc_aut
        '
        Me.lbl_tipo_doc_aut.AutoSize = True
        Me.lbl_tipo_doc_aut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_doc_aut.Location = New System.Drawing.Point(15, 68)
        Me.lbl_tipo_doc_aut.Name = "lbl_tipo_doc_aut"
        Me.lbl_tipo_doc_aut.Size = New System.Drawing.Size(91, 13)
        Me.lbl_tipo_doc_aut.TabIndex = 60
        Me.lbl_tipo_doc_aut.Text = "Tipo documento"
        '
        'cmb_tipo_doc_aut
        '
        Me.cmb_tipo_doc_aut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_doc_aut.FormattingEnabled = True
        Me.cmb_tipo_doc_aut.Location = New System.Drawing.Point(112, 65)
        Me.cmb_tipo_doc_aut.Name = "cmb_tipo_doc_aut"
        Me.cmb_tipo_doc_aut.Size = New System.Drawing.Size(163, 21)
        Me.cmb_tipo_doc_aut.TabIndex = 55
        '
        'lbl_documento_aut
        '
        Me.lbl_documento_aut.AutoSize = True
        Me.lbl_documento_aut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_documento_aut.Location = New System.Drawing.Point(281, 67)
        Me.lbl_documento_aut.Name = "lbl_documento_aut"
        Me.lbl_documento_aut.Size = New System.Drawing.Size(67, 13)
        Me.lbl_documento_aut.TabIndex = 59
        Me.lbl_documento_aut.Text = "Documento"
        '
        'grid_autorizados
        '
        Me.grid_autorizados.AllowUserToAddRows = False
        Me.grid_autorizados.AllowUserToDeleteRows = False
        Me.grid_autorizados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_autorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_autorizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipo_doc, Me.nro_doc, Me.id_tipo_doc, Me.eliminar})
        Me.grid_autorizados.Location = New System.Drawing.Point(68, 104)
        Me.grid_autorizados.Name = "grid_autorizados"
        Me.grid_autorizados.Size = New System.Drawing.Size(294, 142)
        Me.grid_autorizados.TabIndex = 58
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
        'id_tipo_doc
        '
        Me.id_tipo_doc.HeaderText = "id_tipo_doc"
        Me.id_tipo_doc.Name = "id_tipo_doc"
        Me.id_tipo_doc.ReadOnly = True
        Me.id_tipo_doc.Visible = False
        '
        'eliminar
        '
        Me.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.eliminar.HeaderText = "Eliminar "
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Text = "Eliminar "
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 52
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_agregar.Image = Global.WindowsApplication1.My.Resources.Resources._112_Plus_Green___copia
        Me.cmd_agregar.Location = New System.Drawing.Point(443, 54)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(40, 40)
        Me.cmd_agregar.TabIndex = 57
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(263, 37)
        Me.lbl_titulo.TabIndex = 61
        Me.lbl_titulo.Text = "Autorizados por socio"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources._112_LeftArrowLong_Blue___copia
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 255)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.TabIndex = 62
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_listado
        '
        Me.cmd_listado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_listado.Location = New System.Drawing.Point(377, 155)
        Me.cmd_listado.Name = "cmd_listado"
        Me.cmd_listado.Size = New System.Drawing.Size(77, 36)
        Me.cmd_listado.TabIndex = 63
        Me.cmd_listado.Text = "Ver listado"
        Me.cmd_listado.UseVisualStyleBackColor = True
        '
        'Autorizados_socio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 307)
        Me.Controls.Add(Me.cmd_listado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.cmd_agregar)
        Me.Controls.Add(Me.txt_documento_aut)
        Me.Controls.Add(Me.lbl_tipo_doc_aut)
        Me.Controls.Add(Me.cmb_tipo_doc_aut)
        Me.Controls.Add(Me.lbl_documento_aut)
        Me.Controls.Add(Me.grid_autorizados)
        Me.Name = "Autorizados_socio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorizados por socio - Hollywood"
        CType(Me.grid_autorizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents txt_documento_aut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_tipo_doc_aut As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_doc_aut As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_documento_aut As System.Windows.Forms.Label
    Friend WithEvents grid_autorizados As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_listado As System.Windows.Forms.Button
End Class
