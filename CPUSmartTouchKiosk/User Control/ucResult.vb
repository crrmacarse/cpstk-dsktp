Public Class ucResult

    Private _title As String

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(title As String)
        InitializeComponent()

        _title = title
    End Sub

    'Private Sub ucResult_Click(sender As Object, e As EventArgs) Handles Me.Click, lblTitle.Click, pbResult.Click
    '    Dim _endMarker As clsMarker = DirectCast(Me.Tag, clsMarker)

    '    Me.Hide()

    '    frmCampusMap.DrawEdge(oGraph.GetMarker(_startMarker.Id), oGraph.GetMarker(_endMarker.Id))
    '    Me.Dispose()
    'End Sub

    Private Sub ucResult_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTitle.Text = _title
    End Sub

    Private Sub oButton_Click(sender As Object, e As EventArgs)
        Dim oButton = DirectCast(sender, Button)
       
    End Sub

End Class
