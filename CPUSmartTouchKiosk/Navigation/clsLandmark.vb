Public Class clsLandmark
    Private _idLandmark As Integer
    Private _Marker As clsMarker
    Private _LandmarkName As String
    Private _LandmarkDescription As String
    Private _LandmarkType As String
    Private _tags As List(Of String)

    Public Property idLandmark As Integer
        Get
            Return _idLandmark
        End Get
        Set(value As Integer)
            _idLandmark = value
        End Set
    End Property

    Public Property Marker As clsMarker
        Get
            Return _Marker
        End Get
        Set(value As clsMarker)
            _Marker = value
        End Set
    End Property

    Public Property LandmarkName As String
        Get
            Return _LandmarkName
        End Get
        Set(value As String)
            _LandmarkName = value
        End Set
    End Property
    Public Property LandmarkDescription As String
        Get
            Return _LandmarkDescription
        End Get
        Set(value As String)
            _LandmarkDescription = value
        End Set
    End Property

    Public Property LandmarkType As String
        Get
            Return _LandmarkType
        End Get
        Set(value As String)
            _LandmarkType = value
        End Set
    End Property

    Public Property Tags As List(Of String)
        Get
            Return _tags
        End Get
        Set(value As List(Of String))
            _tags = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(idLandmark As Integer, marker As clsMarker, landmarkName As String, landmarkDescription As String, landmarkType As String)
        _idLandmark = idLandmark
        _Marker = marker
        _LandmarkName = landmarkName
        _LandmarkDescription = landmarkDescription
        _LandmarkType = landmarkType
    End Sub

    Public Overrides Function ToString() As String
        Return _LandmarkName
    End Function

End Class
