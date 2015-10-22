Public Class frm_socios
    Dim registrar As Registrar_socio
    Dim recarga As Recarga_saldo
    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "socios"}
    Dim registrarAut As Autorizados_socio

    Private Sub frm_socios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar_grilla("")
        Me.carga_combo(ComboBox1, Me.acceso.leo_otra_tabla("tipos_documento"), "id_tipo_documento", "tipo_documento")
        Me.ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        registrar = New Registrar_socio(Registrar_socio.estado.insertar)
        registrar.ShowDialog()
        registrar = Nothing
    End Sub

    Private Sub cmd_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_volver.Click
        Me.Close()
    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, _
                           ByVal descripcion As String)
        combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    ''' <summary>
    ''' Carga nuevamente la grilla, actualizándo su información desde la BD.
    ''' </summary>
    ''' <param name="filtros"></param>
    ''' <remarks></remarks>
    Public Sub cargar_grilla(ByVal filtros As String)
        Me.grid_socios.Rows.Clear()
        Dim tabla As DataTable
        If filtros.Length = 0 Then
            tabla = acceso.leo_tabla()
        Else
            tabla = acceso.leo_tabla(filtros)
        End If
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1

            Dim Sql = "SELECT tipo_documento FROM tipos_documento WHERE id_tipo_documento = " _
                      & tabla.Rows(c)("id_tipo_documento")
            Dim tabla2 = acceso.consultar(Sql)
            Dim tipo_doc As String = tabla2.Rows(0)("tipo_documento")
            Me.grid_socios.Rows.Add(tabla.Rows(c)("apellido"), _
                                    tabla.Rows(c)("nombres"), _
                                    tabla.Rows(c)("num_socio"), _
                                    tipo_doc, _
                                    tabla.Rows(c)("nro_documento"), _
                                    tabla.Rows(c)("domicilio"), _
                                    tabla.Rows(c)("saldo"), "", "", "", "", _
                                    tabla.Rows(c)("id_tipo_documento"), _
                                    tabla.Rows(c)("fecha_baja"), _
                                    tabla.Rows(c)("id_tipoIVA"), _
                                    tabla.Rows(c)("CUIT"), _
                                    tabla.Rows(c)("limite_alquiler"), _
                                    tabla.Rows(c)("telefono"))

        Next
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        Dim filtros As String = obtener_filtros()
        cargar_grilla(filtros)
    End Sub

    Private Function obtener_filtros() As String
        Dim filtros As String = ""
        Dim hay_filtros As Boolean = False

        If txt_apellidos.Text.Length > 0 Then
            filtros += "(apellido LIKE '%" + txt_apellidos.Text + "%')"
            hay_filtros = True
        End If

        If txt_nombres.Text.Length > 0 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(nombres LIKE '%" + txt_nombres.Text + "%')"
            hay_filtros = True
        End If

        If txt_documento.Text.Length > 0 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(nro_documento LIKE '%" + txt_documento.Text + "%')"
            hay_filtros = True
        End If

        If txt_numero.Text.Length > 0 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(num_socio LIKE '%" + txt_numero.Text + "%')"
            hay_filtros = True
        End If

        Return filtros
    End Function

    Private Sub grid_socios_CellContentClick(ByVal sender As System.Object, ByVal e As  _
                                             System.Windows.Forms.DataGridViewCellEventArgs) _
                                         Handles grid_socios.CellContentClick

        If Me.grid_socios("fecha_baja", e.RowIndex).Value.ToString.Equals("") Then
            If e.ColumnIndex = 14 Then
                registrarAut = New Autorizados_socio(Convert.ToInt16(Me.grid_socios.Rows(e.RowIndex).Cells(2).Value))
                registrarAut.ShowDialog()
                registrarAut = Nothing
            End If

            If e.ColumnIndex = 15 Then
                recarga = New Recarga_saldo()
                recarga.carga_campos(Me.grid_socios.Rows(e.RowIndex).Cells(1).Value, _
                                     Me.grid_socios.Rows(e.RowIndex).Cells(0).Value, _
                                     Me.grid_socios.Rows(e.RowIndex).Cells(2).Value, _
                                     Me.grid_socios.Rows(e.RowIndex).Cells(6).Value)
                recarga.txt_nuevo_saldo.Focus()
                recarga.ShowDialog()
                Me.cargar_grilla("")
            End If

            If e.ColumnIndex = 16 Then
                registrar = New Registrar_socio(Registrar_socio.estado.modificar)
                registrar.cargar_campos(Me.grid_socios.Rows(e.RowIndex).Cells("id_tipo_doc").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("apellido").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("nombre").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("nro_doc").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("saldo").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("domicilio").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("cuit").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("tel").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("lim_alq").Value, _
                                        Me.grid_socios.Rows(e.RowIndex).Cells("id_tipoIVA").Value)
                registrar.ShowDialog()
            End If

            If e.ColumnIndex = 17 Then
                Me.registrar_baja_socio()
                Me.cargar_grilla("")
            End If

        Else
            MsgBox("No es posible modificar ni dar de baja artistas que ya fueron dados de baja.", _
                  MsgBoxStyle.Information, "Error")

        End If
        

    End Sub

    Private Sub eliminar_socio()
        If MsgBox("¿Está seguro que desea eliminar este socio?", MsgBoxStyle.YesNo, "Confirmación") = Windows.Forms.DialogResult.Yes Then
            Dim eliminacion As String = "DELETE FROM socios "
            eliminacion += "WHERE num_socio = " + Me.grid_socios.CurrentRow.Cells(2).Value.ToString()
            Me.acceso.ejecutar(eliminacion)
            MsgBox("Socio eliminado exitosamente.", MsgBoxStyle.Information, "Eliminación exitosa")
        End If
    End Sub

    Private Sub registrar_baja_socio()
        If MsgBox("¿Está seguro que desea dar de baja este socio?", MsgBoxStyle.YesNo, "Confirmación") _
                = Windows.Forms.DialogResult.Yes Then
            Me.acceso.registrar_baja("num_socio", Me.grid_socios.CurrentRow.Cells(2).Value.ToString())
            MsgBox("Socio eliminado exitosamente.", MsgBoxStyle.Information, "Eliminación exitosa")
        End If
    End Sub
    ''' <summary>
    ''' Blanquea todos los filtros de la pantalla.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub limpiar_filtros()
        Me.txt_apellidos.Clear()
        Me.txt_nombres.Clear()
        Me.txt_numero.Clear()
        Me.txt_documento.Clear()
    End Sub

End Class