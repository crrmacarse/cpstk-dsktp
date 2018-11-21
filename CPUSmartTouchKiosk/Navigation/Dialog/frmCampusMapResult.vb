Public Class frmCampusMapResult
    Public _result As New List(Of clsLandmark)
    Public _startMarker As clsMarker

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCampusMapResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each oItem As clsLandmark In _result
            Dim oButton As New Button

            'Dim res As New ucResult
            'res.Title = oItem.LandmarkName
            'res.Dock = DockStyle.Top
            'res.Tag = oItem.Marker


            oButton.Text = oItem.LandmarkName
            oButton.Dock = DockStyle.Top
            oButton.BackColor = ColorTranslator.FromHtml("255, 204, 0")
            oButton.FlatStyle = FlatStyle.Flat
            oButton.ForeColor = ColorTranslator.FromHtml("0, 0, 153")
            oButton.Tag = oItem.Marker
            AddHandler oButton.Click, AddressOf oButton_Click
            pnlResult.Controls.Add(oButton)
        Next
    End Sub

    Private Sub oButton_Click(sender As Object, e As EventArgs)
        Dim oButton = DirectCast(sender, Button)
        Dim _endMarker As clsMarker = DirectCast(oButton.Tag, clsMarker)
   
        Me.Hide()

        frmCampusMap.DrawEdge(oGraph.GetMarker(_startMarker.Id), oGraph.GetMarker(_endMarker.Id))
        Me.Dispose()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()

    End Sub
End Class