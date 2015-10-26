Public Class Principal
    Enum estado_actual
        primera
        modificar
    End Enum
    Dim registrar As frm_registrar_pelicula
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "peliculas"}
    Dim alquiler_actual As Data.DataTable
    Dim estado_alquiler As estado_actual = estado_actual.primera
    Dim numero_alquiler As Integer = -1
    Public socio_actual As Socio

    Public Sub New(ByVal num_socio As Integer)
        Me.socio_actual = Me.obtener_socio(num_socio)
        InitializeComponent()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Function obtener_socio(ByVal num_socio As Integer) As Socio
        Dim tabla As Data.DataTable
        tabla = Me.acceso.leo_otra_tabla("socios", "num_socio = " + num_socio.ToString)
        Dim socio As New Socio(tabla.Rows(0)("num_socio"), tabla.Rows(0)("nombres"), tabla.Rows(0)("apellido"), _
                               tabla.Rows(0)("id_tipo_documento"), tabla.Rows(0)("nro_documento"), _
                               tabla.Rows(0)("domicilio"), tabla.Rows(0)("id_tipoIVA"), tabla.Rows(0)("CUIT"), _
                               tabla.Rows(0)("limite_alquiler"), tabla.Rows(0)("telefono"), _
                               tabla.Rows(0)("saldo"))
        Return socio
    End Function

    Private Sub cmd_actores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles cmd_artistas.Click
        Inicio.artistas = New frm_artistas()
        Inicio.artistas.ShowDialog() 'el metodo ShowDialog hace que la nueva ventana se muestre de forma que _
        ' no permita seguir usando esta ventana hasta que se cierre la nueva.
        Inicio.artistas = Nothing 'esto libera un poco la memoria que usa la aplicacion.
    End Sub

    Private Sub cmd_socios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_socios.Click
        Inicio.socios = New frm_socios()
        Inicio.socios.ShowDialog()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If Me.socio_actual Is Nothing Then
            Me.mostrar_vista_admin()
        Else
            Me.mostrar_vista_socio()
        End If
        Me.cargar_grilla_peliculas(Me.obtener_filtros())
        Me.carga_combo(Me.cmb_genero, Me.acceso.leo_otra_tabla("generos"), "id_genero", "descripcion")
        Me.cmb_genero.SelectedIndex = -1
        Me.alquiler_actual = New Data.DataTable
        Me.alquiler_actual.Columns.Add("titulo")
        Me.alquiler_actual.Columns.Add("formato")
        Me.alquiler_actual.Columns.Add("precio")
        Me.alquiler_actual.Columns.Add("codigo")
    End Sub

    Private Sub cmd_nueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nueva.Click
        Me.registrar = New frm_registrar_pelicula(frm_registrar_pelicula.estado.insertar)
        Me.registrar.ShowDialog()
        registrar = Nothing
    End Sub

    Public Sub cargar_grilla_peliculas()
        Me.cargar_grilla_peliculas(Me.obtener_filtros)
    End Sub
    Public Sub cargar_grilla_peliculas(ByVal filtros As String)
        Me.grid_peliculas.Rows.Clear()
        Me.grid_peliculas_usuarios.Rows.Clear()
        Dim tabla As DataTable
        Dim tabla_gen As DataTable
        Dim tabla_form As DataTable
        Dim sql As String
        If filtros.Length = 0 Then
            tabla = acceso.leo_tabla()
        Else
            tabla = acceso.leo_tabla(filtros)
        End If
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            sql = "SELECT descripcion FROM generos WHERE id_genero = " & tabla.Rows(c)("id_genero")
            tabla_gen = acceso.consultar(sql)
            Dim genero As String = tabla_gen.Rows(0)("descripcion")
            sql = "SELECT descripcion FROM formatos WHERE id_formato = " & tabla.Rows(c)("id_formato")
            tabla_form = acceso.consultar(sql)
            Dim formato As String = tabla_form.Rows(0)("descripcion")
            Dim fecha_estreno As String = (tabla.Rows(c)("fecha_estreno")).ToString.Substring(0, 10)
            Me.grid_peliculas.Rows.Add(tabla.Rows(c)("nombre"), fecha_estreno, genero, formato, _
                                        tabla.Rows(c)("precio_alquiler"), _
                                        Me.formatear_fecha(tabla.Rows(c)("fecha_baja").ToString), "", "", _
                                        tabla.Rows(c)("codigo_pelicula"), tabla.Rows(c)("id_genero"), _
                                        tabla.Rows(c)("id_formato"))
            Me.grid_peliculas_usuarios.Rows.Add(tabla.Rows(c)("nombre"), fecha_estreno, genero, formato, _
                                        tabla.Rows(c)("precio_alquiler"), "", tabla.Rows(c)("codigo_pelicula"), _
                                        tabla.Rows(c)("id_genero"), _
                                        tabla.Rows(c)("id_formato"))
        Next
        If chb_dados_baja.Checked Then
            Me.grid_peliculas.Columns("grid_fecha_baja").Visible = True
        Else
            Me.grid_peliculas.Columns("grid_fecha_baja").Visible = False
        End If
    End Sub

    Private Sub grid_artistas_CellContentClick(ByVal sender As System.Object, _
                        ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                        Handles grid_peliculas.CellContentClick
        If Me.grid_peliculas.Rows(e.RowIndex).Cells("grid_fecha_baja").Value <> "-" Then
            MsgBox("No es posible modificar ni dar de baja películas que ya fueron dadas de baja.", _
                   MsgBoxStyle.Information, "Error")
        Else
            If e.ColumnIndex = 6 Then
                registrar = New frm_registrar_pelicula(frm_registrar_pelicula.estado.modificar)
                registrar.cargar_campos(Me.grid_peliculas.Rows(e.RowIndex).Cells("grid_pelicula_codigo").Value, _
                                        Me.grid_peliculas.Rows(e.RowIndex).Cells("grid_pelicula_titulo").Value, _
                                        Me.grid_peliculas.Rows(e.RowIndex).Cells("grid_pelicula_fecha_estreno").Value, _
                                        Me.grid_peliculas.Rows(e.RowIndex).Cells("grid_id_genero").Value, _
                                        Me.grid_peliculas.Rows(e.RowIndex).Cells("grid_id_formato").Value, _
                                        Me.grid_peliculas.Rows(e.RowIndex).Cells("grid_pelicula_precio").Value)
                registrar.ShowDialog()
                registrar = Nothing
            End If
            If e.ColumnIndex = 7 Then
                Me.dar_baja()
                Me.cargar_grilla_peliculas(Me.obtener_filtros())
            End If
        End If
    End Sub

    Private Function dar_baja() As Boolean
        If MsgBox("¿Está seguro que desea dar de baja esta pelicula?", MsgBoxStyle.YesNo, "Confirmación") _
                            = Windows.Forms.DialogResult.Yes Then
            Me.acceso.registrar_baja("codigo_pelicula", _
                            Me.grid_peliculas.CurrentRow.Cells("grid_pelicula_codigo").Value.ToString())
            MsgBox("Pelicula se ha dado de baja exitosamente.", MsgBoxStyle.Information, "Dada de baja exitosa")
            Return True
        End If
        Return False
    End Function

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim filtros As String = obtener_filtros()
        cargar_grilla_peliculas(filtros)
    End Sub

    Private Function obtener_filtros() As String
        Dim filtros As String = ""
        Dim hay_filtros As Boolean = False

        If Me.txt_actor.Text.Length > 0 Then
            filtros += "(apellido LIKE '%" + txt_actor.Text + "%')"
            hay_filtros = True
        End If

        If txt_pelicula.Text.Length > 0 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(nombre LIKE '%" + txt_pelicula.Text + "%')"
            hay_filtros = True
        End If

        If txt_director.Text.Length > 0 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(director LIKE '%" + txt_director.Text + "%')"
            hay_filtros = True
        End If

        If cmb_genero.SelectedIndex <> -1 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(id_genero LIKE '" & cmb_genero.SelectedValue & "')"
            hay_filtros = True
        End If

        If chb_dados_baja.Checked = False Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "fecha_baja IS NULL"
            hay_filtros = True
        End If

        If Me.socio_actual Is Nothing Then

        Else
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "fecha_alquiler IS NULL"
            hay_filtros = True
        End If

        Return filtros
    End Function

    Public Sub limpiar_filtros()
        Me.txt_pelicula.Clear()
        Me.txt_actor.Clear()
        Me.txt_director.Clear()
        Me.cmb_genero.SelectedIndex = -1
    End Sub

    Private Sub grid_artistas_usuarios_CellContentClick(ByVal sender As System.Object, _
                        ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                    Handles grid_peliculas_usuarios.CellContentClick
        If e.ColumnIndex = 5 Then
            'Me.alquiler_actual.Rows.Add(Me.grid_peliculas_usuarios("titulo", e.RowIndex).Value, _
            '                            Me.grid_peliculas_usuarios("formato", e.RowIndex).Value, _
            '                            Me.grid_peliculas_usuarios("precio", e.RowIndex).Value, _
            '                            Me.grid_peliculas_usuarios("codigo", e.RowIndex).Value)

            If Inicio.registrar_alquiler Is Nothing Or estado_alquiler = estado_actual.modificar Then
                Inicio.registrar_alquiler = New Registrar_alquiler(Me.numero_alquiler)
                Inicio.registrar_alquiler.Show()
                Inicio.registrar_alquiler.tomarSocio(Me.socio_actual)
                estado_alquiler = estado_actual.primera
            Else
                Inicio.registrar_alquiler.BringToFront()
            End If
            Inicio.registrar_alquiler.agregar_pelicula(Me.grid_peliculas_usuarios.Rows(e.RowIndex).Cells("titulo").Value, _
                                       Me.grid_peliculas_usuarios.Rows(e.RowIndex).Cells("formato").Value, _
                                        Me.grid_peliculas_usuarios.Rows(e.RowIndex).Cells("precio").Value, _
                                        Me.grid_peliculas_usuarios.Rows(e.RowIndex).Cells("codigo").Value)
            Me.grid_peliculas_usuarios.Rows.RemoveAt(grid_peliculas_usuarios.CurrentRow.Index)
        End If

    End Sub


    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, _
                        ByVal descripcion As String)
        combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub cmd_formatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                        Handles cmd_formatos.Click
        Inicio.formatos = New frm_formatos()
        Inicio.formatos.ShowDialog()
        Inicio.formatos = Nothing
    End Sub

    Private Function formatear_fecha(ByVal fecha As String)
        If fecha.Equals("") Then
            fecha = "-" 'Hago esto para que el campo no se muestre vacío cuando el artista no tenga fecha de baja.
        Else
            fecha = fecha.Substring(0, 10) 'Hago esto para que no se muestre la hora de baja.
        End If
        Return fecha
    End Function

    Private Sub mostrar_vista_socio()
        lbl_bienvenido.Text = Me.obtener_nombre_completo_socio()
        pnl_botones_admin.Visible = False
        pnl_botones_socio.Visible = True
        Me.grid_peliculas.Visible = False
        Me.grid_peliculas_usuarios.Visible = True
        Me.chb_dados_baja.Visible = False
        Me.cmd_alquilar.Visible = True
        Me.cmd_nueva.Visible = False
    End Sub

    Public Function obtener_nombre_completo_socio() As String
        Dim nombre_completo As String = Me.socio_actual._nombres + " " + Me.socio_actual._apellido
        Return nombre_completo
    End Function

    Private Sub mostrar_vista_admin()
        lbl_bienvenido.Text = "Bienvenido, administrador"
        pnl_botones_admin.Visible = True
        pnl_botones_socio.Visible = False
        Me.grid_peliculas.Visible = True
        Me.grid_peliculas_usuarios.Visible = False
        Me.chb_dados_baja.Visible = True
        Me.cmd_alquilar.Visible = False
        Me.cmd_nueva.Visible = True
    End Sub

    Private Sub cmd_alquilar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                        Handles cmd_alquilar.Click
        If Me.alquiler_actual Is Nothing Then
            MessageBox.Show("Debe agregar películas al carrito para poder proceder con el alquiler.", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Inicio.registrar_alquiler = New Registrar_alquiler(Me.numero_alquiler)
            Inicio.registrar_alquiler.Show()
            Inicio.registrar_alquiler.tomarSocio(Me.socio_actual)
            estado_alquiler = estado_actual.primera
        End If
    End Sub

    Public Sub agregar_fila(ByVal codigo_pel As Integer)
        Dim c As Integer = 0
        Dim consulta As String
        consulta = "SELECT nombre,fecha_estreno,generos.descripcion AS genero,formatos.descripcion AS formato,precio_alquiler, codigo_pelicula FROM ((peliculas JOIN formatos ON peliculas.id_formato = formatos.id_formato) JOIN generos ON peliculas.id_genero = generos.id_genero) WHERE codigo_pelicula =" & codigo_pel
        Dim tabla As DataTable = Me.acceso.consultar(consulta)
        Me.grid_peliculas_usuarios.Rows.Add(tabla.Rows(c)("nombre"), _
                                           (tabla.Rows(c)("fecha_estreno")).ToString.Substring(0, 10), _
                                            tabla.Rows(c)("genero"), _
                                            tabla.Rows(c)("formato"), _
                                            tabla.Rows(c)("precio_alquiler"), "",
                                            tabla.Rows(c)("codigo_pelicula"))
    End Sub

    Public Sub activar_modificar()
        Me.grid_peliculas_usuarios.Columns("DataGridViewButtonColumn1").HeaderText = "Modifcar"
        Me.estado_alquiler = estado_actual.modificar
    End Sub

    Public Sub activar_primero()
        Me.grid_peliculas_usuarios.Columns("DataGridViewButtonColumn1").HeaderText = "Añadir"
        Me.estado_alquiler = estado_actual.primera
        Me.numero_alquiler = -1
    End Sub

    Public Sub asignar_numero(ByVal num As Integer)
        Me.numero_alquiler = num
    End Sub


    Private Sub cmd_sesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sesion.Click
        Dim respuesta As Integer = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Cerrar sesión", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Inicio.salir = False
            Inicio.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub Principal_FormClosing(ByVal sender As System.Object, _
                        ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuesta As Integer = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "Salir", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Inicio.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Principal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Inicio.cerrar_aplicacion()
    End Sub

    Private Sub cmd_alquileres_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_alquileres_admin.Click
        Inicio.alquileres = New Alquileres()
        Inicio.alquileres.ShowDialog()
        Inicio.alquileres = Nothing
    End Sub
End Class