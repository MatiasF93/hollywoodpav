Public Class MaskedTextBox_v1
    Inherits MaskedTextBox

    Dim validar As Boolean = False
    Dim mensaje_error As String = ""

    Public Property _validar As Boolean
        Get 'esto manipula la propiedad publica. Es el camino de entrada para que se ofrezca informacion al exterior.
            Return validar
        End Get
        Set(ByVal value As Boolean) 'trae informacion desde el exterior a la variable
            Me.validar = True
        End Set
    End Property

    Public Property _mensaje_error As String
        Get
            Return Me.mensaje_error
        End Get
        Set(ByVal value As String)
            Me.mensaje_error = value
        End Set
    End Property

End Class
