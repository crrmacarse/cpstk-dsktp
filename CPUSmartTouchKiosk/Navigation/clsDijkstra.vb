Public Class clsDijkstra
    Private dShortestDistances() As Double
    Private dPreviousMarkers() As Double
    Private iUnvisitedMarkers As New List(Of Integer)

    Public Sub New(neighbor As Double(,), markerMax As Integer, markerStart As clsMarker)
        ReDim dShortestDistances(markerMax)
        ReDim dPreviousMarkers(markerMax)

        For i As Integer = 1 To markerMax
            iUnvisitedMarkers.Add(i)
            dShortestDistances(i) = Double.PositiveInfinity
        Next
        dShortestDistances(markerStart.Id) = 0

        While iUnvisitedMarkers.Count > 0
            Dim iCurrentMarker As Integer = getNextMarker()

            For i As Integer = 1 To markerMax
                If neighbor(iCurrentMarker, i) > 0 Then
                    If dShortestDistances(i) > dShortestDistances(iCurrentMarker) + neighbor(iCurrentMarker, i) Then
                        dShortestDistances(i) = dShortestDistances(iCurrentMarker) + neighbor(iCurrentMarker, i)
                        dPreviousMarkers(i) = iCurrentMarker
                    End If
                End If
            Next

        End While
    End Sub

    Private Function getNextMarker() As Integer
        Dim iSmallestDistance As Double = Double.PositiveInfinity
        Dim iMarker As Integer = -1

        For Each value As Integer In iUnvisitedMarkers
            If dShortestDistances(value) <= iSmallestDistance Then
                iSmallestDistance = dShortestDistances(value)
                iMarker = value
            End If
        Next

        iUnvisitedMarkers.Remove(iMarker)
        Return iMarker
    End Function

    Public ReadOnly Property Distances() As Double()
        Get
            Return dShortestDistances
        End Get
    End Property

    Public ReadOnly Property Paths() As Double()
        Get
            Return dPreviousMarkers
        End Get
    End Property
End Class
