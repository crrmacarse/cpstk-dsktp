Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.PowerPacks

Public Class frmCampusMap

    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"
    Private POSK As System.Diagnostics.Process = Nothing

    Dim bGettingStartPoint As Boolean
    Dim bGettingEndPoint As Boolean
    Dim oStartMarker As clsMarker
    Dim oEndMarker As clsMarker

    Private Sub LoadLandmark()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Select idLandmark,idVertex,LName,LDescription, isNull(LType,'')'LType' From Landmark Where [Status]=1 order by LName", oConnection)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    While oReader.Read
                        Dim oLandmark As New clsLandmark
                        oLandmark.idLandmark = oReader("idLandmark")
                        oLandmark.Marker = oGraph.GetMarker(oReader("idVertex"))
                        oLandmark.LandmarkName = oReader("LName")
                        oLandmark.LandmarkDescription = oReader("LDescription")
                        oLandmark.LandmarkType = oReader("LType")
                        oLandmark.Tags = getTags(oReader("idLandmark"))
                        'Tags == List(OF String)
                        lstLandmark.Add(oLandmark)

                        Dim sResult As String = String.Join(", ", oLandmark.Tags.ToArray())
                        Debug.Print(sResult)

                        'If oLandmark.Tags.Contains("NEW VALENTINE") Then
                        '    MsgBox("Found at" & oLandmark.LandmarkName)
                        'End If
                    End While
                End Using
            Catch ex As Exception
                modGeneral.showMessageBox(">>>" & ex.Message, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub SearchLandmark(keyword As String)
        If keyword = String.Empty Then Return

        'Dim sQuery As String = "SELECT LName FROM Landmark LEFT JOIN College ON College.idLandmark = Landmark.idLandmark WHERE LName LIKE @lname OR CName LIKE @cname GROUP BY LName"
        'Using oConnect As New SqlConnection(modGeneral.getConnectionString)
        '    Try
        '        oConnect.Open()
        '        Using oCommand As New SqlCommand(sQuery, oConnect)
        '            oCommand.Parameters.AddWithValue("@lname", keyword)
        '            oCommand.Parameters.AddWithValue("@cname", keyword)
        '        End Using
        '    Catch ex As Exception

        '    End Try
        'End Using
        Dim oResult As clsLandmark
        Dim frmResult As New frmCampusMapResult()
        frmResult.Left = cmbSearch.Left
        frmResult.Top = cmbSearch.Top + cmbSearch.Height
        frmResult.Width = cmbSearch.Width
        frmResult._startMarker = oStartMarker

        Dim sQuery = "SELECT Landmark.idLandmark, LName " & _
                    "FROM Landmark " & _
                    "LEFT JOIN College ON Landmark.idLandmark = College.idLandmark " & _
                    "LEFT JOIN Department ON College.idCollege = Department.idCollege " & _
                    "LEFT JOIN Course ON Course.idCollege = College.idCollege " & _
                    "LEFT JOIN Room ON Room.idLandmark = Landmark.idLandmark " & _
                    "WHERE (LName Like '%' + @Keyword +'%' OR LNameAbbr Like '%' + @Keyword +'%' OR  LType Like '%' + @Keyword +'%' OR College.CName Like '%' + @Keyword +'%' OR College.CNameAbbr Like '%' + @Keyword +'%' OR CDean Like '%' + @Keyword +'%' OR DName Like '%' + @Keyword +'%' OR DNameAbbr Like '%' + @Keyword +'%' OR Course.CCode Like '%' + @Keyword +'%' OR Course.CNameAbbr Like '%' + @Keyword +'%' OR Course.CName Like '%' + @Keyword +'%' OR RCode Like '%' + @Keyword +'%') " & _
                    "GROUP BY Landmark.idLandmark, LName "
        'Dim sQuery = "SELECT Landmark.idLandmark, LName, LNameAbbr, LType, CName, CNameAbbr, CDean, DName, DNameAbbr " & _
        '    "FROM Landmark " & _
        '    "LEFT JOIN College ON Landmark.idLandmark = College.idLandmark " & _
        '    "LEFT JOIN Department ON College.idCollege = Department.idCollege " & _
        '    "WHERE (LName Like '%' + @Keyword +'%' OR LNameAbbr Like '%' + @Keyword +'%' OR  LType Like '%' + @Keyword +'%' OR CName Like '%' + @Keyword +'%' OR CNameAbbr Like '%' + @Keyword +'%' OR CDean Like '%' + @Keyword +'%' OR DName Like '%' + @Keyword +'%' OR DNameAbbr Like '%' + @Keyword +'%')"
        Using oConnect As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    oCommand.Parameters.AddWithValue("@Keyword", keyword)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    While oReader.Read
                        oResult = (From oLandmark In lstLandmark Where oLandmark.idLandmark = oReader("idLandmark") Select oLandmark).Single

                        frmResult._result.Add(oResult)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using




        'Dim oResult = From oLandmark In lstLandmark Where oLandmark.LandmarkName.ToUpper.Contains(keyword.ToUpper) Select oLandmark
        ' ---->>>> Dim oResult = From oLandmark In lstLandmark Where oLandmark.Tags.Contains(keyword.ToUpper) Select oLandmark

        'Debug.Print("result found " & oResult.Count)

        
        'For Each oLandmark As clsLandmark In oResult
        'frmResult._result.Add(oLandmark)
        'Next

        frmResult.ShowDialog()
    End Sub

    Private Function getTags(id As Integer) As List(Of String)
        Dim res As New List(Of String)
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("SELECT LName, LNameAbbr, LType, CName, CNameAbbr, CDean FROM Landmark LEFT JOIN College ON Landmark.idLandmark = College.idLandmark WHERE Landmark.idLandmark = @idlandmark", oConnection)
                    oCommand.Parameters.AddWithValue("@idlandmark", id)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    While oReader.Read
                        'Ara oh.. gna butang ko sila sa list tapos gna return.. wait pakita ko results..
                        res.AddRange({oReader("LName").ToString.ToUpper(), oReader("LNameAbbr").ToString.ToUpper(), oReader("LType").ToString.ToUpper(), oReader("CName").ToString.ToUpper(), oReader("CNameAbbr").ToString.ToUpper(), oReader("CDean").ToString.ToUpper()})
                    End While

                    Return res
                End Using
            Catch ex As Exception
            End Try
        End Using
    End Function

    Private Sub LoadMarker()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Select Vertex.idVertex,VName,VX,VY,Visible,Label,isNull(LName,'')'LName',isNull(LType,'')'LType',isNull(LNameAbbr,'')'LNameAbbr' " & _
                    "From Vertex " & _
                    "Left Join Landmark On Vertex.idVertex = Landmark.idVertex " & _
                    "Where Vertex.[Status]=1 Order By Vertex.idVertex", oConnection)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    While oReader.Read
                        If oReader("Visible") Then
                            DrawMarker(oReader("idVertex"), oReader("VName"), oReader("LName"), oReader("LNameAbbr"), oReader("LType"), oReader("VX"), oReader("VY"))
                        End If
                        oGraph.AddMarker(oReader("idVertex"), oReader("Label"), oReader("VX"), oReader("VY"), False)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub DrawMarker(id As Integer, markername As String, label As String, abbr As String, type As String, x As Double, y As Double)
        Dim oMarker As New clsMarker
        oMarker.Name = "Marker" & id.ToString
        oMarker.Id = id
        oMarker.Font = New Font("Verdana", 7, FontStyle.Bold)
        oMarker.Text = abbr
        oMarker.TextAlign = ContentAlignment.TopCenter
        oMarker.ForeColor = ColorTranslator.FromHtml("#666")
        oMarker.Label = label

        oMarker.BackColor = Color.Transparent
        'oMarker.AutoSize = True
        oMarker.Width = 50
        oMarker.Height = 70
        Select Case type
            Case "Building"
                oMarker.Image = ilCampusMapEditor48.Images("landmark01")
            Case "Parking"
                oMarker.Image = ilCampusMapEditor48.Images("landmark02")
            Case Else
                oMarker.Image = ilCampusMapEditor48.Images("landmark01")
        End Select

        oMarker.ImageAlign = ContentAlignment.BottomCenter
        oMarker.Left = x - (oMarker.Width / 2)
        oMarker.Top = y - (oMarker.Height / 2)
        oMarker.Cursor = Cursors.Hand

        AddHandler oMarker.MouseClick, AddressOf oMarker_MouseClick

        pbCampusMap.Controls.Add(oMarker)

    End Sub

    Private Sub LoadEdge()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Select idEdge,idVertexStart,idVertexEnd,EName,ECost From Edge Where [Status]=1 Order By idEdge", oConnection)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    While oReader.Read
                        oGraph.AddEdge(oReader("idVertexStart"), oReader("idVertexEnd"), CInt(oReader("ECost")))
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub DrawEdge(oStart As clsMarker, oEnd As clsMarker)
        Dim pathInformation As New clsDijkstra(oGraph.GetNeighbor, oGraph.iMarkerCount, oStart)
        Dim paths = pathInformation.Paths
        Dim distances = pathInformation.Distances
        Dim iStart As Integer = oStart.Id
        Dim i As Integer
        Dim oResult As New List(Of clsMarker)

        i = oEnd.Id
        While i <> iStart
            oResult.Add(oGraph.GetMarkerById(i))
            i = paths(i)
        End While
        oResult.Add(oGraph.GetMarkerById(oStart.Id))

        pbCampusMap.Controls.RemoveByKey("oShapeContainer")

        Dim oCanvass As New ShapeContainer
        oCanvass.Name = "oShapeContainer"
        oCanvass.Parent = pbCampusMap

        For i = 1 To oResult.Count - 1
            Dim oLine As New LineShape

            oLine.X1 = oResult(i - 1).X
            oLine.Y1 = oResult(i - 1).Y
            oLine.X2 = oResult(i).X
            oLine.Y2 = oResult(i).Y

            oLine.BorderWidth = 3
            oLine.BorderColor = Color.Blue
            oLine.Parent = oCanvass
            oLine.Parent.Tag = oCanvass.Name
        Next
    End Sub

    Private Sub oMarker_MouseClick(sender As Object, e As System.EventArgs)
        Dim oMarkerEnd As clsMarker = DirectCast(sender, clsMarker)
        DrawEdge(oStartMarker, oMarkerEnd)
        ttLandmark.SetToolTip(sender, oMarkerEnd.Label)
    End Sub

    Private Sub frmCampusMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCampusMap.VerticalScroll.Value = pnlCampusMap.VerticalScroll.Maximum
        pnlCampusMap.HorizontalScroll.Value = pnlCampusMap.HorizontalScroll.Maximum * 0.2
        oGraph.Empty()
        oGraph.AddMarker(0, "Vertex0", 0, 0, 0)
        LoadMarker()
        LoadEdge()
        LoadLandmark()
        LoadStartingPoint()

        '----- static atm
        oStartMarker = oGraph.GetMarker(iStartingPoint)
    End Sub

    Private Sub btnStartPoint_Click(sender As Object, e As EventArgs)
        bGettingStartPoint = True
    End Sub

    Private Sub btnEndPoint_Click(sender As Object, e As EventArgs)
        bGettingEndPoint = True
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs)
        If oStartMarker Is Nothing Or oEndMarker Is Nothing Then
            MsgBox("Select start and end points")
            Return
        End If
        DrawEdge(oStartMarker, oEndMarker)
    End Sub

    'pota
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            POSK.Kill()
        Catch ex As Exception

        End Try
        lstLandmark.Clear()
        Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            POSK.Kill()
        Catch ex As Exception

        End Try
        SearchLandmark(cmbSearch.Text)
    End Sub

    Private Sub cmbSearch_Click(sender As Object, e As EventArgs) Handles cmbSearch.Click
        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                POSK = Process.Start(osk)
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            POSK = Process.Start(osk)
        End If
    End Sub

    Private Sub cmbSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSearch.KeyDown
        Dim tb As ComboBox = CType(sender, ComboBox)
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(tb, True, True, False, True)
            e.Handled = True
            btnSearch.PerformClick()
        End If
    End Sub


End Class
