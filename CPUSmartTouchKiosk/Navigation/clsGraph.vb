Public Class clsGraph
    Private Const iMarkerMax As Integer = 400
    Public iMarkerCount As Integer
    Private Markers() As clsMarker
    Private Neighbor(,) As Double

    Public Sub New()
        ReDim Markers(iMarkerMax)
        ReDim Neighbor(iMarkerMax, iMarkerMax)

        For i = 0 To iMarkerMax - 1
            For j = 0 To iMarkerMax
                Neighbor(i, j) = 0
            Next
        Next

        iMarkerCount = 0
    End Sub

    Public Sub Empty()
        iMarkerCount = 0
        ReDim Markers(iMarkerMax)
        ReDim Neighbor(iMarkerMax, iMarkerMax)

        For i = 0 To iMarkerMax - 1
            For j = 0 To iMarkerMax
                Neighbor(i, j) = 0
            Next
        Next

        iMarkerCount = 0
    End Sub

    Public Sub AddMarker(id As Integer, label As String, x As Double, y As Double, visited As Boolean)
        Markers(iMarkerCount) = New clsMarker(id, label, x, y, visited)
        iMarkerCount += 1
    End Sub

    Public Sub AddEdge(StartMarker As Integer, EndMarker As Integer, Cost As Double)
        Neighbor(StartMarker, EndMarker) = Cost
        Neighbor(EndMarker, StartMarker) = Cost
    End Sub

    Public Function GetMarker(id As Integer) As clsMarker
        Return Markers(id)
    End Function

    Public Function GetMarkerById(id As Integer) As clsMarker
        Dim value As clsMarker = Markers(0)

        For Each oMarker As clsMarker In Markers
            If oMarker.Id = id Then
                value = oMarker
                Exit For
            End If
        Next

        Return value
    End Function

    Public Function GetNeighbor()
        Return Neighbor
    End Function

End Class
