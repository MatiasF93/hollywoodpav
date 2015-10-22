Public Class frm_registrar_pelicula
    Enum estado
        insertar
        modificar
    End Enum

    Dim accion As estado = estado.insertar
    Dim matricula As Integer
    Dim PF As New Procesos_Formulario
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "peliculas"}
    Dim accesoArtistasXPeli As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "artistas_x_pelicula"}
    Dim accesoArtistas As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "artistas"}

    Sub New(ByVal estado_inicial As estado)
        Me.InitializeComponent()
        Me.accion = estado_inicial
    End Sub

    Private Sub pelicula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.accion = estado.modificar Then
            Me.lbl_titulo.Text = "Modificar Pelicula"
            Me.txt_codigo.ReadOnly = True
            Me.cargar_grilla(Me.txt_codigo.Text)
        Else
            Panel1.Enabled = False
        End If
        carga_combo(Me.cmb_genero, Me.acceso.leo_otra_tabla("generos"), "id_genero", "descripcion")
        carga_combo(Me.cmb_formato, Me.acceso.leo_otra_tabla("formatos"), "id_formato", "descripcion")
        carga_combo_doble(Me.cmb_director, Me.cmb_actor, Me.acceso.leo_otra_tabla("artistas"), "matricula")

    End Sub

    Private Sub cmd_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_aceptar.Click
        If PF.validar(Me.Controls) = Procesos_Formulario.valid.correcta Then
            If accion = estado.insertar Then
                Me._grabar_pelicula()
                Me._grabar_artista()
                MsgBox("La película se registró con éxito", MsgBoxStyle.Information)
            Else
                Me._actualizar_pelicula()
                Me._actualizar_artista()
                'Me.acceso.actualizar_pelicula(Convert.ToInt32(Me.txt_codigo.Text), Me.txt_titulo.Text, Convert.ToDecimal(Me.txt_precio.Text), _
                '                           Me.cmb_genero.SelectedValue(), Me.cmb_formato.SelectedValue(), Me.dtp_fecha_estreno.Value)

                MsgBox("La película se modificó con éxito", MsgBoxStyle.Information)
            End If
            Inicio.principal.cargar_grilla_peliculas("")
            Me.Dispose()

        Else
            'Esto es muy raro, pero si no pongo este Else, el msj de error se muestra vacio... Pongan siempre este Else para la validacion.
        End If
    End Sub

    Private Sub _grabar_pelicula()
        Dim datos As String = ""
        datos &= "codigo_pelicula=" & Me.txt_codigo.Text
        datos &= ", nombre=" & Me.txt_titulo.Text
        datos &= ", precio_alquiler=" & Me.txt_precio.Text.Trim
        datos &= ", id_genero=" & Me.cmb_genero.SelectedValue
        datos &= ", id_formato=" & Me.cmb_formato.SelectedValue
        datos &= ", fecha_estreno=" & Me.dtp_fecha_estreno.Value.Date.ToString

        Me.acceso._tabla = "peliculas"
        Me.acceso.insertar(datos)
    End Sub

    Private Sub _grabar_artista()
        Dim c As Integer = 0
        Dim txt_insert As String = ""
        Me.acceso._tabla = "artistas_x_pelicula"

        'Registrar director
        txt_insert &= "codigo_pelicula=" & Me.txt_codigo.Text
        txt_insert &= ", matricula=" & Me.cmb_director.SelectedValue
        txt_insert &= ", id_tipo_artista =" & 1
        txt_insert &= ", personaje= - "
        Me.acceso.insertar(txt_insert)
        txt_insert = ""

        'Registrar actores
        For c = 0 To Me.grid_artistas.RowCount() - 1
            txt_insert &= "codigo_pelicula=" & Me.txt_codigo.Text
            txt_insert &= ", matricula=" & Me.grid_artistas.Rows(c).Cells("matricula_artista").Value
            txt_insert &= ", id_tipo_artista =" & 0
            txt_insert &= ", personaje=" & Me.grid_artistas.Rows(c).Cells("Personaje").Value
            Me.acceso.insertar(txt_insert)
            txt_insert = ""
        Next
    End Sub

    Private Sub _actualizar_pelicula()
        Dim datos As String = ""
        datos &= "codigo_pelicula=" & Me.txt_codigo.Text
        datos &= ", nombre=" & Me.txt_titulo.Text
        datos &= ", precio_alquiler=" & Me.txt_precio.Text.Trim
        datos &= ", id_genero=" & Me.cmb_genero.SelectedValue
        datos &= ", id_formato=" & Me.cmb_formato.SelectedValue
        datos &= ", fecha_estreno=" & Me.dtp_fecha_estreno.Value.Date.ToString

        Me.acceso._tabla = "peliculas"
        Me.acceso.modificar(datos, "codigo_pelicula=" & Me.txt_codigo.Text)
    End Sub

    Private Sub _actualizar_artista()

        Me.acceso._tabla = "artistas_x_pelicula"
        Dim consulta As String = ""
        consulta &= "DELETE FROM artistas_x_pelicula WHERE codigo_pelicula=" & Me.txt_codigo.Text
        acceso.ejecutar(consulta)
        Dim c As Integer = 0
        Dim txt_insert As String = ""

        'Registrar director
        txt_insert &= "codigo_pelicula=" & Me.txt_codigo.Text
        txt_insert &= ", matricula=" & Me.cmb_director.SelectedValue
        txt_insert &= ", id_tipo_artista =" & 1
        txt_insert &= ", personaje= - "
        Me.acceso.insertar(txt_insert)
        txt_insert = ""

        'Registrar actores
        For c = 0 To Me.grid_artistas.RowCount() - 1
            txt_insert &= "codigo_pelicula=" & Me.txt_codigo.Text
            txt_insert &= ", matricula=" & Me.grid_artistas.Rows(c).Cells("matricula_artista").Value
            txt_insert &= ", id_tipo_artista =" & 0
            txt_insert &= ", personaje=" & Me.grid_artistas.Rows(c).Cells("Personaje").Value
            Me.acceso.insertar(txt_insert)
            txt_insert = ""
        Next
    End Sub


    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        If (cmb_actor.SelectedIndex = -1 Or txt_personaje.Text = "") Then
        Else
            Dim tabla As New DataTable
            Dim consulta As String
            Dim rol As String = "0"
            consulta = "SELECT matricula, apellido, nombres FROM artistas WHERE matricula = " & Me.cmb_actor.SelectedValue
            tabla = Me.acceso.consultar(consulta)
            Me.grid_artistas.Rows.Add(tabla.Rows(0)("apellido"), tabla.Rows(0)("nombres"), Me.txt_personaje.Text, "", tabla.Rows(0)("matricula"))
        End If
        Me.cmb_actor.SelectedIndex = 0
        Me.txt_personaje.Text = ""
    End Sub

    Public Sub cargar_campos(ByVal cod As Integer, ByVal titulo As String, ByVal fecha As String, _
                             ByVal genero As String, ByVal formato As String, ByVal precio As String)
        carga_combo(Me.cmb_genero, Me.acceso.leo_otra_tabla("generos"), "id_genero", "descripcion")
        carga_combo(Me.cmb_formato, Me.acceso.leo_otra_tabla("formatos"), "id_formato", "descripcion")
        carga_combo_doble(Me.cmb_actor, Me.cmb_director, Me.acceso.leo_otra_tabla("artistas"), "matricula")
        Me.txt_codigo.Text = cod
        Me.txt_titulo.Text = titulo
        Me.txt_precio.Text = precio
        Me.cmb_genero.SelectedValue = genero
        Me.cmb_formato.SelectedValue = formato
        Me.dtp_fecha_estreno.Value = fecha

    End Sub

    Public Sub cargar_grilla(ByVal cod As Integer)
        Dim tabla As New DataTable
        Dim consulta = "SELECT artistas.apellido AS apellido, artistas.nombres AS nombres, artistas_x_pelicula.personaje AS personaje, artistas_x_pelicula.id_tipo_artista AS id_tipo_artista, artistas.matricula AS matricula "
        consulta &= "FROM ((artistas_x_pelicula INNER JOIN "
        consulta &= "artistas ON artistas_x_pelicula.matricula = artistas.matricula) "
        consulta &= "INNER JOIN tipos_artista ON artistas_x_pelicula.id_tipo_artista = tipos_artista.id_tipo_artista) "
        consulta &= "WHERE artistas_x_pelicula.codigo_pelicula=" & cod
        tabla = acceso.consultar(consulta)
        Me.grid_artistas.Rows.Clear()
        'cargar director y eliminar de la tabla
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            If tabla.Rows(c)("id_tipo_artista") = 1 Then
                Me.cmb_director.SelectedValue = tabla.Rows(c)("matricula")
            Else
                Me.grid_artistas.Rows.Add(tabla.Rows(c)("apellido"), tabla.Rows(c)("nombres"), _
                              tabla.Rows(c)("personaje"), "", tabla.Rows(c)("matricula"))
            End If
        Next
        Me.cmb_actor.SelectedIndex = -1
    End Sub

    Private Sub carga_combo_doble(ByRef combo As ComboBox, ByRef combo2 As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String)
        'combo.Items.Clear()

        Dim tabla As New Data.DataTable
        Dim command As New SqlClient.SqlCommand
        Dim conexion As New Data.SqlClient.SqlConnection

        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("HollywoodBD").ConnectionString
        conexion.Open()
        command.Connection = conexion
        command.CommandType = CommandType.Text
        command.CommandText = "SELECT matricula,(nombres+' '+apellido) As nombre FROM artistas WHERE id_tipo_artista = 0 OR id_tipo_artista = 2 "
        tabla.Load(command.ExecuteReader())
        conexion.Close()
        With combo
            .DataSource = tabla
            .DisplayMember = "nombre"
            .ValueMember = "matricula"

        End With

        conexion.Open()
        Dim tabla2 As New Data.DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT matricula,(nombres+' '+apellido) As nombre FROM artistas WHERE id_tipo_artista = 2 OR  id_tipo_artista = 1"
        tabla2.Load(cmd.ExecuteReader())
        conexion.Close()
        With combo2
            .DataSource = tabla2
            .DisplayMember = "nombre"
            .ValueMember = "matricula"
        End With

    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub cmd_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_volver.Click
        Me.Close()
    End Sub

    Private Sub txt_codigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        Me.Panel1.Enabled = True
    End Sub

    Private Sub grid_artistas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_artistas.CellContentClick
        If e.ColumnIndex = 3 Then
            Me.grid_artistas.Rows.RemoveAt(grid_artistas.CurrentRow.Index)
        End If
    End Sub

  
End Class