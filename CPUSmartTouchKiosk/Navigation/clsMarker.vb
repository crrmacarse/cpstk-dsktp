Public Class clsMarker
    Inherits Windows.Forms.Label

    Public Id As Integer
    Public Label As String
    Public X As Double
    Public Y As Double
    Public Visited As Boolean

    Public Sub New()
        Me.Id = 0
        Me.Label = String.Empty
        Me.X = 0
        Me.Y = 0
        Me.Visited = False
    End Sub

    Public Sub New(id As Integer, label As String, x As Double, y As Double, visited As Boolean)
        Me.Id = id
        Me.Label = label
        Me.X = x
        Me.Y = y
        Me.Visited = visited
    End Sub
End Class