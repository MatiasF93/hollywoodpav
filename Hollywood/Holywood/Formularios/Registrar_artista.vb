Public Class Registrar_Artista
    Enum estado 'esto se usa para determinar si se está registrando o modificando un artista.
        insertar
        modificar
    End Enum

    Dim accion As estado = estado.insertar
    Dim matricula As Integer
    Dim PF As New Procesos_Formulario
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "artistas"}

    Sub New(ByVal estado_inicial As estado)
        Me.InitializeComponent()
        ' TODO: Complete member initialization 
        Me.accion = estado_inicial
    End Sub

    ''' <summary>
    ''' Carga los controles de la ventana, fijándose antes si se utilizará para un registro o para una modificación, en 
    ''' cuyo caso cambia el título y deshabilita el campo Matrícula (ya que la misma no se puede cambiar).
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub registrar_artista_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.accion = estado.modificar Then
            Me.lbl_titulo.Text = "Modificar artista"
            Me.Text = "Modificar artista - Hollywood"
            Me.txt_matricula.Enabled = False
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Valida que los campos no estén vacíos y registra al nuevo artista o modifica al artista seleccionado según 
    ''' corresponda.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        If (PF.validar(Me.Controls) = Procesos_Formulario.valid.correcta) And (Me.validar_seleccion_tipo_artista()) Then
            Dim es_actor As Integer = Convert.ToInt32(chb_actor.Checked)
            Dim es_director As Integer = Convert.ToInt32(chb_director.Checked)
            Dim datos As String = ""
            datos &= "matricula =" + txt_matricula.Text
            datos &= ", apellido =" + txt_apellidos.Text
            datos &= ", nombres =" + txt_nombres.Text
            datos &= ", id_tipo_artista =" + Me.obtener_tipo_artista().ToString
            datos &= ", fecha_nacimiento =" + dtp_fecha_nac.Value

            If accion = estado.insertar Then
                Me.acceso.insertar(datos)
                MsgBox("El actor/director se registró con éxito.", MsgBoxStyle.Information)

            Else
                Me.acceso.modificar(datos, "matricula =" + txt_matricula.Text)
                MsgBox("El actor/director se modificó con éxito.", MsgBoxStyle.Information)
            End If

            Inicio.artistas.cargar_grilla("")
            Inicio.artistas.limpiar_filtros()
            Me.Dispose()

        Else
            'Esto es muy raro, pero si no pongo este Else, el msj de error se muestra vacio... Pongan siempre este Else para la validacion.
        End If
    End Sub

    ''' <summary>
    ''' -SOLO PARA MODIFICACION- Toma los datos del artista seleccionado y los carga en los controles para su posterior 
    ''' modificación.
    ''' </summary>
    ''' <param name="matricula"></param>
    ''' <param name="apellido"></param>
    ''' <param name="nombre"></param>
    ''' <param name="es_actor"></param>
    ''' <param name="es_director"></param>
    ''' <param name="fecha_nacimiento"></param>
    ''' <remarks></remarks>
    Public Sub cargar_campos(ByVal matricula As Integer, ByVal apellido As String, ByVal nombre As String, ByVal es_actor As Boolean, ByVal es_director As Boolean, ByVal fecha_nacimiento As Date)
        Me.txt_matricula.Text = matricula
        Me.txt_nombres.Text = nombre
        Me.txt_apellidos.Text = apellido
        Me.dtp_fecha_nac.Value = fecha_nacimiento
        Me.chb_actor.Checked = es_actor
        Me.chb_director.Checked = es_director
    End Sub

    ''' <summary>
    ''' Verifica cuál o cuáles de los checkbox "Es actor" y "Es director" están seleccionados y de acuerdo
    ''' a ello retorna un int que hace referencia al tipo de artista (si es actor, director o ambos).
    ''' </summary>
    ''' <returns>Tipo de artista</returns>
    ''' <remarks></remarks>
    Private Function obtener_tipo_artista() As Integer
        If chb_actor.Checked Then
            If chb_director.Checked Then
                Return 2
            Else
                Return 1
            End If
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Valida que el programa no permita registrar artistas que no sean directores ni actores.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function validar_seleccion_tipo_artista() As Boolean
        If (chb_actor.Checked Or chb_director.Checked) Then
            Return True
        Else
            MsgBox("Por favor indique si el artista es actor, director o ambos.", MsgBoxStyle.Exclamation, _
                   "Falta información")
            Return False
        End If
    End Function

End Class