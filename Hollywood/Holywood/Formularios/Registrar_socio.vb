Public Class Registrar_socio
    Enum estado
        insertar
        modificar
        ver
    End Enum

    Dim iddoc As Integer
    Dim idfac As Integer
    Dim PF As New Procesos_Formulario
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo.", ._tabla = "socios"}
    Dim acceso_aut As New Acceso_Datos With { _
        ._esquema = "dbo.", ._tabla = "autorizados_x_socio"}
    Dim accion As estado = estado.insertar

    Sub New(ByVal estado_inicial As estado)
        Me.InitializeComponent()
        ' TODO: Complete member initialization 
        Me.accion = estado_inicial
    End Sub

    ''' <summary>
    ''' Carga los controles de la ventana, fijándose antes si se utilizará para un registro, modificación o vista de los
    ''' datos del socio, cambiando el título según corresponda.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub registrar_socio_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.accion = estado.modificar Then
            Me.lbl_titulo.Text = "Modificar socio"
            Me.Text = "Modificar socio - Hollywood"
            Me.carga_combo(cmb_tipo_doc, Me.acceso.leo_otra_tabla("tipos_documento"), "id_tipo_documento", _
                           "tipo_documento")

            Me.carga_combo(cmb_tipo_iva, Me.acceso.leo_otra_tabla("tipos_IVA"), "id_tipo_IVA", "descripcion")
            Me.cmb_tipo_doc.SelectedIndex = iddoc - 1
            Me.cmb_tipo_iva.SelectedIndex = idfac - 1

            Me.cmb_tipo_doc.Enabled = False
            Me.cmb_tipo_doc.Enabled = False
            Me.txt_documento.Enabled = False

        ElseIf Me.accion = estado.ver Then
            Me.lbl_titulo.Text = "Ver socio"
            Me.Text = "Ver socio - Hollywood"
            Me.carga_combo(cmb_tipo_doc, Me.acceso.leo_otra_tabla("tipos_documento"), "id_tipo_documento", _
                           "tipo_documento")

            Me.carga_combo(cmb_tipo_iva, Me.acceso.leo_otra_tabla("tipos_IVA"), "id_tipo_IVA", "descripcion")
            Me.cmb_tipo_doc.SelectedIndex = -1
            Me.cmb_tipo_iva.SelectedIndex = -1

            Me.cmb_tipo_doc.Enabled = True
            Me.cmb_tipo_doc.Enabled = True
            Me.txt_documento.Enabled = True
        End If
        If Me.accion = estado.insertar Then
            Me.carga_combo(cmb_tipo_doc, Me.acceso.leo_otra_tabla("tipos_documento"), _
                           "id_tipo_documento", "tipo_documento")
            Me.carga_combo(cmb_tipo_iva, Me.acceso.leo_otra_tabla("tipos_IVA"), "id_tipo_IVA", "descripcion")
        End If

    End Sub

    Public Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, _
                            ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        If PF.validar(Me.Controls) = Procesos_Formulario.valid.correcta Then
            If accion = estado.insertar Then
                Me.registrar_socio()
            Else
                Me.acceso.modificar(Me.obtener_datos_socio, "nro_documento = " & Me.txt_documento.Text)
            End If
            Inicio.socios.cargar_grilla("")
            Me.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Registra un nuevo socio y sus autorizados en la BD a partir de los datos ingresados.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub registrar_socio()
        Me.acceso.insertar(Me.obtener_datos_socio())

        MsgBox("El nuevo socio se registró con éxito.", MsgBoxStyle.Information)
    End Sub

    Private Sub modificar_socio()
        Me.acceso.modificar(Me.obtener_datos_socio, "num_socio = " + Me.obtener_num_socio_actual.ToString)
        MsgBox("El socio se modificó con éxito.", MsgBoxStyle.Information)
    End Sub

    ''' <summary>
    ''' Toma los datos del socio a registrar desde los elementos de la pantalla y los guarda en un string,
    ''' el cual tiene la estructura adecuada para el método de inserción de la clase Acceso_Datos.
    ''' </summary>
    ''' <returns>String con los datos del socio</returns>
    ''' <remarks></remarks>
    Private Function obtener_datos_socio() As String
        Dim datos As String = ""
        datos &= "apellido =" + txt_apellidos.Text
        datos &= ", nombres =" + txt_nombres.Text
        datos &= ", id_tipo_documento =" + cmb_tipo_doc.SelectedValue.ToString
        datos &= ", nro_documento =" + txt_documento.Text
        datos &= ", domicilio =" + txt_domicilio.Text
        datos &= ", id_tipoIVA =" + cmb_tipo_iva.SelectedValue.ToString
        datos &= ", CUIT =" + txt_cuit.Text
        datos &= ", limite_alquiler =" + txt_limite.Text
        datos &= ", telefono =" + txt_telefono.Text
        datos &= ", saldo =" + txt_saldo.Text
        Return datos
    End Function


    ''' <summary>
    ''' Obtiene el número del socio que se acaba de registrar en la BD.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function obtener_num_socio_actual() As Integer
        Dim tabla As System.Data.DataTable
        tabla = Me.acceso.leo_tabla("(tipos_documento = " & Me.cmb_tipo_doc.SelectedValue.ToString & _
                                    ") AND (nro_documento = " & txt_documento.Text + ")")
        Return tabla.Rows(0)("num_socio")
    End Function

    ''' <summary>
    ''' Carga los campos de la pantalla Modificar socio tomando los mismos desde la tabla de la consulta.
    ''' </summary>
    ''' <param name="tipo_doc">Tipo de documento</param>
    ''' <param name="apellido">Apellido</param>
    ''' <param name="nombres">Nombres</param>
    ''' <param name="documento">Número de documento</param>
    ''' <param name="saldo">Saldo</param>
    ''' <param name="domicilio">Domicilio</param>
    ''' <param name="cuit">CUIT</param>
    ''' <param name="telefono">Teléfono</param>
    ''' <param name="limite">Límite de alquileres</param>
    ''' <param name="tipo_iva">Tipo de IVA</param>
    ''' <remarks></remarks>
    Public Sub cargar_campos(ByVal tipo_doc As Integer, ByVal apellido As String, ByVal nombres As String, _
                             ByVal documento As Integer, ByVal saldo As Integer, ByVal domicilio As String, _
                             ByVal cuit As String, ByVal telefono As Long, ByVal limite As Integer, _
                             ByVal tipo_iva As Integer)
        Me.txt_apellidos.Text = apellido
        Me.txt_nombres.Text = nombres
        Me.txt_domicilio.Text = domicilio
        Me.txt_telefono.Text = telefono
        Me.txt_limite.Text = limite
        Me.txt_saldo.Text = saldo
        Me.txt_cuit.Text = cuit
        Me.txt_documento.Text = documento

        iddoc = tipo_doc
        idfac = tipo_iva
    End Sub
    
End Class