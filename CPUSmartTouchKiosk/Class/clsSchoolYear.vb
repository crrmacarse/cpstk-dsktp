Public Class clsSchoolYear

    Private sSchoolYear As String
    Private idPeriod As String

    Public Sub New(ByVal sy As String, ByVal idsy As String)
        Me.sSchoolYear = sy
        Me.idPeriod = idPeriod
    End Sub

    Public Property SchoolYear As String
        Get
            Return sSchoolYear
        End Get
        Set(value As String)
            sSchoolYear = value
        End Set
    End Property

    Public Property Period As String
        Get
            Return idPeriod
        End Get
        Set(value As String)
            idPeriod = value
        End Set
    End Property

End Class
