Public Class Procesos_Formulario
    Enum valid
        correcta
        errores
    End Enum

    ''' <summary>
    ''' Recibe por parámetros un control o conjunto de controles y verifica que los mismos no estén vacíos.
    ''' </summary>
    ''' <param name="controles"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function validar(ByRef controles As Control.ControlCollection) As valid
        For Each obj As Windows.Forms.Control In controles
            If obj.GetType().ToString.IndexOf("MaskedTextBox_v1") <> -1 Then
                Dim actual As MaskedTextBox_v1 = obj
                If actual._validar = True Then
                    If actual.Text = "" Then
                        MsgBox(actual._mensaje_error, MsgBoxStyle.Exclamation, "Error")
                        actual.Focus()
                        Return valid.errores
                    End If
                End If
            ElseIf obj.GetType().ToString.IndexOf("TextBox_v1") <> -1 Then
                Dim actual As TextBox_v1 = obj
                If actual._validar = True Then
                    If actual.Text = "" Then
                        MsgBox(actual._mensaje_error, MsgBoxStyle.Exclamation, "Error")
                        actual.Focus()
                        Return valid.errores
                    End If
                End If
            End If
            
        Next
        Return valid.correcta
    End Function

End Class
