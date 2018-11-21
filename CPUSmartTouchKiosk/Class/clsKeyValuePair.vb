Public Class clsKeyValuePair

    'This is mainly used for pairing 2 values. Common scenario is id and its corresponding value

    ' IMPORTANT: _key is a STRING. use CSTR()

    Private _key As String
    Private _value As String

    Public Sub New(key, value)
        _key = key
        _value = value
    End Sub

    Public Overrides Function ToString() As String
        Return _value
    End Function

    Public Property key As String
        Get
            Return _key
        End Get
        Set(value As String)
            _key = value
        End Set
    End Property

    Public Property value As String
        Get
            Return _value
        End Get
        Set(value As String)
            _value = value
        End Set
    End Property

End Class
