﻿Public Class Informes
    Dim listado_peliculasXartista As Listado_peliculasXartista
    Dim listado_autorizados As Listado_autorizadosXsocio
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class