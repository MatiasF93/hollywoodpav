﻿Public Class Informes
    Dim listado_peliculasXartista As Listado_peliculasXartista
    Dim listado_autorizados As Listado_autorizadosXsocio
    Dim listado_alquilerXgenero As Listado_alquileresXgenero
    Dim listado_alquileresXsocio As Listado_alquileresXsocio
    Private Sub cmd_pelixartista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pelixartista.Click
        listado_peliculasXartista = New Listado_peliculasXartista()
        listado_peliculasXartista.ShowDialog()
        listado_peliculasXartista = Nothing

    End Sub

    Private Sub cmd_autorizadosxsocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        listado_autorizados = New Listado_autorizadosXsocio()
        listado_autorizados.ShowDialog()
        listado_autorizados = Nothing

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

   
    Private Sub cmd_alquilerxgenero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_alquilerxgenero.Click
        listado_alquilerXgenero = New Listado_alquileresXgenero()
        listado_alquilerXgenero.ShowDialog()
        listado_alquilerXgenero = Nothing
    End Sub

    Private Sub cmd_alquilerxsocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_alquilerxsocio.Click
        listado_alquileresXsocio = New Listado_alquileresXsocio()
        listado_alquileresXsocio.ShowDialog()
        listado_alquileresXsocio = Nothing

    End Sub
End Class