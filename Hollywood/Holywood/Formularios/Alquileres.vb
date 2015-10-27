Public Class Alquileres

    Dim acceso As New Acceso_Datos With { _
        ._esquema = "dbo." _
        , ._tabla = "facturas"}
    Public socio_actual As Socio

    Private Sub Alquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Principal.carga_combo(Me.cmb_tipo_doc, Me.acceso.leo_otra_tabla("tipos_documento"), "id_tipo_documento", _
                              "tipo_documento")
        Me.cargar_grilla("")
    End Sub

    Private Sub cargar_grilla(ByVal filtros As String)
        Me.grid_alquileres.Rows.Clear()
        Dim tabla As Data.DataTable = Me.acceso.leo_tabla()
        For Each row As Data.DataRow In tabla.Rows
            Dim socio As Socio = Principal.obtener_socio(row("num_socio"))
            Dim tabla_detalles As Data.DataTable = Me.acceso.leo_otra_tabla("detalles_factura", _
                                "num_factura = " + row("num_factura").ToString())
            Me.grid_alquileres.Rows.Add(socio._tipo_documento, socio._nro_documento, socio._apellido, _
                                row("num_factura").ToString(), tabla_detalles.Rows.Count, _
                                row("monto_total").ToString(), row("fecha").ToString())
        Next

    End Sub

    Private Function obtener_filtros() As String
        Dim filtros As String = ""
        Dim hay_filtros As Boolean = False

        Dim fecha As String = Me.dtp_fecha_alquiler.Value.Date.ToString.Substring(0, 10)
        If Not fecha Is "31/12/1999" Then
            filtros += "(fecha LIKE '%" + fecha + "%')"
            hay_filtros = True
        End If

        If Me.txt_nro_factura.Text.Length > 0 Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "(nombre LIKE '%" + Me.txt_nro_factura.Text + "%')"
            hay_filtros = True
        End If

        If Me.chb_incluir_devueltos.Checked = False Then
            If hay_filtros Then
                filtros += " AND "
            End If
            filtros += "fecha_baja IS NULL"
            hay_filtros = True
        End If

        Return filtros
    End Function

    Private Function obtener_filtros_socio() As String
        Dim filtros As String = ""
        Dim hay_filtros As Boolean = False
        'If cmb_genero.SelectedIndex <> -1 Then
        '    If hay_filtros Then
        '        filtros += " AND "
        '    End If
        '    filtros += "(id_genero LIKE '" & cmb_genero.SelectedValue & "')"
        '    hay_filtros = True
        'End If

        'If Me.socio_actual Is Nothing Then

        'Else
        '    If hay_filtros Then
        '        filtros += " AND "
        '    End If
        '    filtros += "fecha_alquiler IS NULL"
        '    hay_filtros = True
        'End If
        Return filtros
    End Function

    Public Sub limpiar_filtros()
        Me.dtp_fecha_alquiler.Value = "31/12/1999 17:33"
        Me.txt_nro_factura.Clear()
        Me.txt_documento.Clear()
        Me.cmb_tipo_doc.SelectedIndex = -1
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class