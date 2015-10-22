Public Class Socio
    Dim acceso As New Acceso_Datos
    Dim num_socio As Integer, nombres As String, apellido As String, tipo_documento As String, _
        nro_documento As Integer, domicilio As String, tipoIVA As String, CUIT As String, limite_alquiler As Integer, _
        telefono As Integer, saldo As Integer

    Public Sub New(ByVal num_socio As Integer, ByVal nombres As String, ByVal apellido As String, _
                   ByVal id_tipo_documento As Integer, ByVal nro_documento As Integer, ByVal domicilio As String, _
                   ByVal id_tipoIVA As Integer, ByVal CUIT As String, ByVal limite_alquiler As Integer, _
                   ByVal telefono As Integer, ByVal saldo As Integer)
        Me.num_socio = num_socio
        Me.nombres = nombres
        Me.apellido = apellido
        Me.nro_documento = nro_documento
        Me.domicilio = domicilio
        Me.CUIT = CUIT
        Me.limite_alquiler = limite_alquiler
        Me.telefono = telefono
        Me.saldo = saldo
        Me.tipo_documento = Me.acceso.consultar _
            ("SELECT tipo_documento FROM dbo.tipos_documento WHERE id_tipo_documento = " _
             + id_tipo_documento.ToString).Rows(0)("tipo_documento")
        Me.tipoIVA = Me.acceso.consultar _
            ("SELECT descripcion FROM dbo.tipos_IVA WHERE id_tipo_IVA = " _
             + id_tipoIVA.ToString).Rows(0)("descripcion")
    End Sub

    Public Property _num_socio As Integer
        Get
            Return num_socio
        End Get
        Set(ByVal value As Integer)
            Me.num_socio = value
        End Set
    End Property

    Public Property _nombres As String
        Get
            Return nombres
        End Get
        Set(ByVal value As String)
            Me.nombres = value
        End Set
    End Property

    Public Property _apellido As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            Me.apellido = value
        End Set
    End Property

    Public Property _tipo_documento As String
        Get
            Return tipo_documento
        End Get
        Set(ByVal value As String)
            Me.tipo_documento = value
        End Set
    End Property

    Public Property _nro_documento As Integer
        Get
            Return nro_documento
        End Get
        Set(ByVal value As Integer)
            Me.nro_documento = value
        End Set
    End Property

    Public Property _domicilio As String
        Get
            Return domicilio
        End Get
        Set(ByVal value As String)
            Me.domicilio = value
        End Set
    End Property

    Public Property _tipoIVA As String
        Get
            Return tipoIVA
        End Get
        Set(ByVal value As String)
            Me.tipo_documento = value
        End Set
    End Property

    Public Property _CUIT As String
        Get
            Return CUIT
        End Get
        Set(ByVal value As String)
            Me.CUIT = value
        End Set
    End Property

    Public Property _limite_alquiler As Integer
        Get
            Return limite_alquiler
        End Get
        Set(ByVal value As Integer)
            Me.limite_alquiler = value
        End Set
    End Property

    Public Property _telefono As Integer
        Get
            Return telefono
        End Get
        Set(ByVal value As Integer)
            Me.telefono = value
        End Set
    End Property

    Public Property _saldo As Integer
        Get
            Return saldo
        End Get
        Set(ByVal value As Integer)
            Me.saldo = value
        End Set
    End Property

End Class
