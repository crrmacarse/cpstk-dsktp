Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.PowerPacks
Public Class frmCampusMapEditor
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim bGettingStartPoint As Boolean
    Dim bGettingEndPoint As Boolean
    Dim oStartMarker As clsMarker
    Dim oEndMarker As clsMarker

    Private Sub ResetTools()
        tsbtnAddAVertex.Checked = False
        tsbtnAddAnEdge.Checked = False
        tsbtnMarker.Checked = False
        tsbtnLandmark.Checked = False
        tsbtnDelete.Checked = False
        pnlMap.Cursor = Cursors.Default
    End Sub

    Private Function DistanceBetween(ByVal X1 As Single, ByVal Y1 As Single, ByVal X2 As Single, ByVal Y2 As Single) As Single
        DistanceBetween = Math.Sqrt((Math.Abs(X2 - X1) ^ 2) + (Math.Abs(Y2 - Y1) ^ 2))
    End Function

    Private Sub SaveStartPoint(idVertex As Integer)
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Update Settings Set SStartingPoint=@idVertex Where idSettings=1", oConnection)
                    oCommand.Parameters.AddWithValue("@idVertex", idVertex)
                    oCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadMarker()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Select idVertex,VName,VX,VY,Visible,Label From Vertex Where [Status]=1 Order By idVertex", oConnection)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    While oReader.Read
                        DrawMarker(oReader("idVertex"), oReader("VName").ToString, CDbl(oReader("VX")), CDbl(oReader("VY")), CBool(oReader("Visible")))
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub DrawMarker(VertexID As Integer, VertexName As String, VX As Double, VY As Double, Visible As Boolean)
        Dim oMarker As New clsMarker
        oMarker.Name = "Marker_" & VertexID.ToString
        oMarker.Id = VertexID
        oMarker.Label = VertexName
        oMarker.BackColor = Color.Transparent
        oMarker.Width = 12
        oMarker.Height = 12

        If Visible Then
            oMarker.Image = ilCampusMapEditor.Images("landmark")
        Else
            oMarker.Image = ilCampusMapEditor.Images("point")
        End If

        oMarker.ImageAlign = ContentAlignment.MiddleCenter
        oMarker.TextAlign = ContentAlignment.MiddleCenter
        oMarker.Left = VX - (oMarker.Width / 2)
        oMarker.Top = VY - (oMarker.Height / 2)


        txtSelectedObjectID.Text = VertexID
        txtSelectedObject.Text = VertexName
        txtSelectedObject.Tag = oMarker

        AddHandler oMarker.MouseHover, AddressOf oMarker_MouseHover
        AddHandler oMarker.MouseLeave, AddressOf oMarker_MouseLeave
        AddHandler oMarker.MouseClick, AddressOf oMarker_MouseClick

        oGraph.AddMarker(VertexID, VertexName, VX, VY, False)
        pbCampusMap.Controls.Add(oMarker)
    End Sub

    Private Function SaveMarker(VName As String, VX As Double, VY As Double, Visible As Boolean, sLabel As String, Status As Boolean, Optional idVertex As Integer = 0) As Integer
        Dim sQuery As String

        If idVertex = 0 Then
            sQuery = "Insert Into Vertex (VName,VX,VY,Visible,Label,[Status]) Values ('Vertex' + Cast((Select isnull(Max(idVertex),0)+1 From Vertex) as Nvarchar(4)),@VX,@VY,@Visible,'',1); Select Max(idVertex) From Vertex"
        Else
            sQuery = "Update Vertex Set VName=@VName,VX=@VX,VY=@VY,Visible=@Visible,Label=@Label,[Status]=@Status Where idVertex=@idVertex; Select Max(idVertex) From Vertex"
        End If
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@VName", VName)
                    oCommand.Parameters.AddWithValue("@VX", VX)
                    oCommand.Parameters.AddWithValue("@VY", VY)
                    oCommand.Parameters.AddWithValue("@Visible", Visible)
                    oCommand.Parameters.AddWithValue("@Label", sLabel)
                    oCommand.Parameters.AddWithValue("@Status", Status)
                    oCommand.Parameters.AddWithValue("@idVertex", idVertex)
                    Return oCommand.ExecuteScalar()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return 0
            End Try
        End Using
    End Function

    Private Sub DeleteMarker(oMarker As clsMarker)
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommandVertex As New SqlCommand("Update Vertex Set [Status]=0 Where idVertex=@idVertex", oConnection)
                    oCommandVertex.Parameters.AddWithValue("@idVertex", oMarker.Id)
                    oCommandVertex.ExecuteNonQuery()
                End Using
                Using oCommandEdge As New SqlCommand("Update Edge Set [Status]=0 Where idVertexStart=@idVertex or idVertexEnd=@idVertex", oConnection)
                    oCommandEdge.Parameters.AddWithValue("@idVertex", oMarker.Id)
                    oCommandEdge.ExecuteNonQuery()
                End Using
                Using oCommandLandmark As New SqlCommand("Update Landmark Set [Status]=0 Where idVertex=@idVertex", oConnection)
                    oCommandLandmark.Parameters.AddWithValue("@idVertex", oMarker.Id)
                    oCommandLandmark.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadLandmark(idVertex As Integer)
        Dim idLandmark As Integer = 0

        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Select LName, LNameAbbr, LDescription, isNull(LType,'')'LType', [Status] from Landmark Where idVertex=@idVertex", oConnection)
                    oCommand.Parameters.AddWithValue("@idVertex", idVertex)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    oReader.Read()
                    If oReader.HasRows Then
                        If CBool(oReader("Status")) Then
                            rbLandmark.Checked = True
                            txtLandmarkName.Text = oReader("LName")
                            txtLandmarkNameAbbr.Text = oReader("LNameAbbr")
                            txtLandmarkDescription.Text = oReader("LDescription")
                            cmbLandmarkType.SelectedIndex = cmbLandmarkType.FindStringExact(oReader("LType"))
                        Else
                            rbLandmark.Checked = False
                        End If
                    Else
                        rbLandmark.Checked = False
                    End If
                    oReader.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SaveLandmark(landmarkName As String, landmarkNameAbbr As String, landmarkDescription As String, ltype As String, status As Boolean, Optional idVertex As Integer = 0)

        Dim sQuery As String
        Dim idLandmark As Integer = 0

        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommandCheck As New SqlCommand("Select idLandmark from Landmark Where idVertex=@idVertex", oConnection)
                    oCommandCheck.Parameters.AddWithValue("@idVertex", idVertex)
                    Dim oReader As SqlDataReader
                    oReader = oCommandCheck.ExecuteReader
                    oReader.Read()
                    If oReader.HasRows Then
                        idLandmark = oReader("idLandmark")
                    End If
                    oReader.Close()
                End Using

                If idLandmark = 0 Then
                    sQuery = "Insert Into Landmark(idVertex,LName,LNameAbbr, LDescription, LType, [Status]) Values (@idVertex,@LName,@LNameAbbr, @LDescription, @LType, 1)"
                Else
                    sQuery = "Update Landmark Set LName=@LName, LNameAbbr = @LNameAbbr, LDescription=@LDescription, LType = @LType, [Status]=@Status Where idVertex=@idVertex"
                End If
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@LName", landmarkName)
                    oCommand.Parameters.AddWithValue("@LDescription", landmarkDescription)
                    oCommand.Parameters.AddWithValue("@LNameAbbr", landmarkNameAbbr)
                    oCommand.Parameters.AddWithValue("@LType", ltype)
                    oCommand.Parameters.AddWithValue("@Status", status)
                    oCommand.Parameters.AddWithValue("@idVertex", idVertex)
                    oCommand.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub


    Private Sub ShowPath(oStart As clsMarker, oEnd As clsMarker)
        Dim pathInformation As New clsDijkstra(oGraph.GetNeighbor, oGraph.iMarkerCount, oStart)
        Dim paths = pathInformation.Paths
        Dim distances = pathInformation.Distances
        Dim iStart As Integer = oStart.Id
        Dim i As Integer
        Dim oStack As New Stack(Of Integer)

        ListBox1.Items.Clear()

        For i = 1 To paths.Count - 1
            ListBox1.Items.Add("Marker_" & i & " From Marker_" & paths(i) & " Distance=" & distances(i))
        Next

        i = oEnd.Id
        While i <> iStart
            If oStack.Count > 5000 Then
                MsgBox("Cannot find any path connected to the destination")
                Return
            End If
            oStack.Push(paths(i))
            i = paths(i)
        End While
        oStack.Push(oEnd.Id)

        For Each o As Object In pbCampusMap.Controls
            If TypeOf o Is clsMarker Then
                CType(o, clsMarker).BackColor = Color.Transparent
            End If
        Next

        Dim oMarker As New clsMarker
        For j = 1 To oStack.Count
            oMarker = DirectCast(pbCampusMap.Controls("Marker_" & oStack.Pop.ToString), clsMarker)
            oMarker.BackColor = Color.Red
        Next

    End Sub

    Private Sub DrawEdge(VertexFrom As clsMarker, VertexTo As clsMarker)
        Dim oCanvass As New ShapeContainer
        If Not pbCampusMap.Controls("Edge_" & VertexTo.Id & "_" & VertexFrom.Id) Is Nothing Then Return

        oCanvass.Parent = pbCampusMap
        oCanvass.Name = "Edge_" & VertexFrom.Id & "_" & VertexTo.Id
        Dim oLine As New LineShape
        oLine.X1 = VertexFrom.Left + (VertexFrom.Width / 2)
        oLine.Y1 = VertexFrom.Top + (VertexFrom.Height / 2)
        oLine.X2 = VertexTo.Left + (VertexTo.Width / 2)
        oLine.Y2 = VertexTo.Top + (VertexTo.Height / 2)

        oLine.BorderWidth = 3
        oLine.BorderColor = Color.Blue
        oLine.Parent = oCanvass
        oLine.Parent.Tag = oCanvass.Name

        Dim dCost As Double = DistanceBetween(oLine.X1, oLine.Y1, oLine.X2, oLine.Y2)

        AddHandler oLine.MouseClick, AddressOf oLine_MouseClick
        'AddHandler oLine .KeyUp, AddressOf oLine_KeyUp

        oGraph.AddEdge(VertexFrom.Id, VertexTo.Id, CInt(dCost))
    End Sub

    Private Function SaveEdge(EdgeName As String, VertexFrom As clsMarker, VertexTo As clsMarker, Status As Boolean, Optional idEdge As Integer = 0) As Integer
        Dim sQuery As String
        Dim ECost As Double

        If idEdge = 0 Then
            sQuery = "Insert Into Edge (idVertexStart,idVertexEnd,EName,ECost,[Status]) " &
                "Values (@idVertexStart,@idVertexEnd,'Edge' + Cast((Select isnull(Max(idEdge),0)+1 From Edge) as Nvarchar(4)),@ECost,1); " &
                "Select Max(idEdge) From Edge"
        Else
            sQuery = "Update Edge Set idVertexStart=@idVertexStart,idVertexEnd=@idVertexEnd,EName=@EName,ECost=@ECost,[Status]=@Status where idEdge=@idEdge;" &
                "Select Max(idEdge) From Edge"
        End If

        ECost = DistanceBetween(VertexFrom.Left, VertexFrom.Top, VertexTo.Left, VertexTo.Top)

        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idVertexStart", VertexFrom.Id)
                    oCommand.Parameters.AddWithValue("@idVertexEnd", VertexTo.Id)
                    oCommand.Parameters.AddWithValue("@EName", EdgeName)
                    oCommand.Parameters.AddWithValue("@ECost", ECost)
                    oCommand.Parameters.AddWithValue("@Status", Status)
                    oCommand.Parameters.AddWithValue("@idEdge", idEdge)

                    Return oCommand.ExecuteScalar()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return 0
            End Try
        End Using
    End Function

    Private Sub DeleteEdge(idVertexStart As Integer, idVertexEnd As Integer)
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommandEdge As New SqlCommand("Update Edge Set [Status]=0 Where (idVertexStart=@idVertexStart and idVertexEnd=@idVertexEnd) or (idVertexStart=@idVertexEnd and idVertexEnd=@idVertexStart)", oConnection)
                    oCommandEdge.Parameters.AddWithValue("@idVertexStart", idVertexStart)
                    oCommandEdge.Parameters.AddWithValue("@idVertexEnd", idVertexEnd)
                    oCommandEdge.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadEdge()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("Select idEdge,idVertexStart,idVertexEnd,EName,ECost From Edge Where [Status]=1 Order By idEdge", oConnection)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader
                    While oReader.Read
                        Dim VertexFrom = DirectCast(pbCampusMap.Controls("Marker_" & oReader("idVertexStart")), clsMarker)
                        Dim VertexTo = DirectCast(pbCampusMap.Controls("Marker_" & oReader("idVertexEnd")), clsMarker)
                        DrawEdge(VertexFrom, VertexTo)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using

    End Sub

    Private Sub pbCampusMap_MouseMove(sender As Object, e As MouseEventArgs) Handles pbCampusMap.MouseMove
        pnlMap_MouseMove(sender, e)
    End Sub

    Private Sub pnlMap_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlMap.MouseMove
        mouseX = e.X
        mouseY = e.Y
    End Sub

    Private Sub pbCampusMap_Click(sender As Object, e As EventArgs) Handles pbCampusMap.Click
        pnlMap_Click(sender, e)
    End Sub

    Private Sub pnlMap_Click(sender As Object, e As EventArgs) Handles pnlMap.Click
        Dim idMarker As Integer
        If tsbtnMarker.Checked Then
            idMarker = SaveMarker("", mouseX, mouseY, False, "", True)
            DrawMarker(idMarker, "Marker" & idMarker.ToString, mouseX, mouseY, False)
            Return
        End If

        If tsbtnLandmark.Checked Then
            idMarker = SaveMarker("", mouseX, mouseY, True, "", True)
            SaveLandmark("Landmark", "Landmark", "", cmbLandmarkType.SelectedItem, True, idMarker)
            DrawMarker(idMarker, "Marker" & idMarker.ToString, mouseX, mouseY, True)
            Return
        End If
    End Sub

    Private Sub oMarker_MouseHover(sender As Object, e As System.EventArgs)
        Dim oMarker As clsMarker = DirectCast(sender, clsMarker)
        oMarker.BackColor = Color.Red
    End Sub

    Private Sub oMarker_MouseLeave(sender As Object, e As System.EventArgs)
        Dim oMarker As clsMarker = DirectCast(sender, clsMarker)
        oMarker.BackColor = Color.Transparent
    End Sub

    Private Sub oMarker_MouseClick(sender As Object, e As System.EventArgs)
        Dim oMarker As clsMarker = DirectCast(sender, clsMarker)

        If bGettingStartPoint Then
            oStartMarker = oMarker
            btnStartPoint.Text = "Start Point : " & oMarker.Name
            bGettingStartPoint = False
            Return
        End If

        If bGettingEndPoint Then
            oEndMarker = oMarker
            btnEndPoint.Text = "End Point : " & oMarker.Name
            bGettingEndPoint = False
            Return
        End If

        If tsbtnAddAnEdge.Checked Then
            Dim idEdge As Integer

            idEdge = SaveEdge("", txtSelectedObject.Tag, oMarker, 1)
            idEdge = SaveEdge("", oMarker, txtSelectedObject.Tag, 1)

            DrawEdge(txtSelectedObject.Tag, oMarker)
        End If

        txtSelectedObjectID.Text = oMarker.Id
        txtSelectedObject.Text = oMarker.Label
        txtSelectedObject.Tag = oMarker

        If oMarker.Id = iStartingPoint Then chkStartingPoint.Checked = True Else chkStartingPoint.Checked = False

        LoadLandmark(oMarker.Id)

        If tsbtnDelete.Checked Then
            If Not MsgBox("Deleting [" & oMarker.Label & "]. Are you sure?", vbYesNo) = vbYes Then Return

            If txtSelectedObject.Tag.GetType.ToString = "CPUSmartTouchKiosk.clsMarker" Then
                DeleteMarker(oMarker)
                oMarker.Dispose()
            End If
        End If
    End Sub

    Private Sub oLine_MouseClick(sender As Object, e As System.EventArgs)
        Dim oLine As LineShape = DirectCast(sender, LineShape)
        oLine.BorderColor = Color.Red

        txtSelectedObjectID.Text = oLine.Parent.Name
        txtSelectedObject.Text = oLine.Parent.Tag
        txtSelectedObject.Tag = oLine.Parent

        If tsbtnDelete.Checked Then
            If Not MsgBox("Deleting Waypoint [" & oLine.Parent.Tag & "]. Are you sure?", vbYesNo) = vbYes Then Return

            If txtSelectedObject.Tag.GetType.ToString = "Microsoft.VisualBasic.PowerPacks.ShapeContainer" Then
                Dim Markers As String()
                Markers = Split(Replace(oLine.Parent.Tag, "Edge_", ""), "_")
                DeleteEdge(CInt(Markers(0)), CInt(Markers(1)))
                Dim oParent As ShapeContainer = DirectCast(txtSelectedObject.Tag, ShapeContainer)
                oParent.Dispose()
            End If
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'If txtSelectedObject.Tag Is Nothing Then Return

        'Dim oVertex As clsMarker = DirectCast(txtSelectedObject.Tag, clsMarker)

        'If e.KeyCode = Keys.Up Then oVertex.Top -= 5
        'If e.KeyCode = Keys.Down Then oVertex.Top += 5
        'If e.KeyCode = Keys.Left Then oVertex.Left -= 5
        'If e.KeyCode = Keys.Right Then oVertex.Left += 5

        'Dim dTop As Double
        'Dim dLeft As Double

        'dTop = oVertex.Top + (oVertex.Height / 2)
        'dLeft = oVertex.Left + (oVertex.Width / 2)

        'SaveMarker(oVertex.Label, dLeft, dTop, oVertex.Visible, "", 1, oVertex.Id)
        'e.Handled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        pnlMap.VerticalScroll.Value = pnlMap.VerticalScroll.Maximum
        pnlMap.HorizontalScroll.Value = pnlMap.HorizontalScroll.Maximum * 0.2

        oGraph.Empty()
        oGraph.AddMarker(0, "Marker0", 0, 0, False)
        LoadMarker()
        LoadEdge()

        LoadStartingPoint()

        Me.KeyPreview = True
        Me.ResumeLayout()
    End Sub

    Private Sub btnStartPoint_Click(sender As Object, e As EventArgs) Handles btnStartPoint.Click
        bGettingStartPoint = True
    End Sub

    Private Sub btnEndPoint_Click(sender As Object, e As EventArgs) Handles btnEndPoint.Click
        bGettingEndPoint = True
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If oStartMarker Is Nothing Or oEndMarker Is Nothing Then
            MsgBox("Select start and end points")
            Return
        End If
        ShowPath(oStartMarker, oEndMarker)
    End Sub

    Private Sub tsbtnAddAVertex_Click(sender As Object, e As EventArgs) Handles tsbtnAddAVertex.Click
        ResetTools()
        tsbtnAddAVertex.Checked = True
    End Sub

    Private Sub tsbtnAddAnEdge_Click(sender As Object, e As EventArgs) Handles tsbtnAddAnEdge.Click
        ResetTools()
        tsbtnAddAnEdge.Checked = True
    End Sub

    Private Sub tsbtnAddAVertex_Click_1(sender As Object, e As EventArgs) Handles tsbtnAddAVertex.Click
        ResetTools()
        tsbtnAddAVertex.Checked = True
    End Sub

    Private Sub tsbtnAddAnEdge_Click_1(sender As Object, e As EventArgs) Handles tsbtnAddAnEdge.Click
        ResetTools()
        tsbtnAddAnEdge.Checked = True
    End Sub

    Private Sub tsbtnMarker_Click(sender As Object, e As EventArgs) Handles tsbtnMarker.Click
        ResetTools()
        tsbtnMarker.Checked = True
        pnlMap.Cursor = Cursors.Cross
    End Sub

    Private Sub tsbtnLandmark_Click(sender As Object, e As EventArgs) Handles tsbtnLandmark.Click
        ResetTools()
        tsbtnLandmark.Checked = True
        pnlMap.Cursor = Cursors.Cross
    End Sub

    Private Sub tsbtnDelete_Click(sender As Object, e As EventArgs) Handles tsbtnDelete.Click
        ResetTools()
        tsbtnDelete.Checked = True
        pnlMap.Cursor = Cursors.Hand
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Dispose()
    End Sub

    Private Sub txtLandmarkName_Leave(sender As Object, e As EventArgs) Handles txtLandmarkName.Leave
        If txtSelectedObject.Tag Is Nothing Then Return
        Dim oMarker As clsMarker = DirectCast(txtSelectedObject.Tag, clsMarker)
        SaveLandmark(txtLandmarkName.Text, txtLandmarkNameAbbr.Text, txtLandmarkDescription.Text, cmbLandmarkType.SelectedItem, True, oMarker.Id)
    End Sub

    Private Sub txtLandmarkDescription_Leave(sender As Object, e As EventArgs) Handles txtLandmarkDescription.Leave
        If txtSelectedObject.Tag Is Nothing Then Return
        Dim oMarker As clsMarker = DirectCast(txtSelectedObject.Tag, clsMarker)
        SaveLandmark(txtLandmarkName.Text, txtLandmarkNameAbbr.Text, txtLandmarkDescription.Text, cmbLandmarkType.SelectedItem, True, oMarker.Id)
    End Sub

    Private Sub txtLandmarkNameAbbr_Leave(sender As Object, e As EventArgs) Handles txtLandmarkNameAbbr.Leave
        If txtSelectedObject.Tag Is Nothing Then Return
        Dim oMarker As clsMarker = DirectCast(txtSelectedObject.Tag, clsMarker)
        SaveLandmark(txtLandmarkName.Text, txtLandmarkNameAbbr.Text, txtLandmarkDescription.Text, cmbLandmarkType.SelectedItem, True, oMarker.Id)
    End Sub

    Private Sub cmbLandmarkType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLandmarkType.SelectedIndexChanged
        If txtSelectedObject.Tag Is Nothing Then Return
        Dim oMarker As clsMarker = DirectCast(txtSelectedObject.Tag, clsMarker)
        SaveLandmark(txtLandmarkName.Text, txtLandmarkNameAbbr.Text, txtLandmarkDescription.Text, cmbLandmarkType.SelectedItem, True, oMarker.Id)
    End Sub


    Private Sub rbLandmark_CheckedChanged(sender As Object, e As EventArgs) Handles rbLandmark.CheckedChanged
        If rbLandmark.Checked Then
            lblNameAbbr.Enabled = True
            txtLandmarkNameAbbr.Enabled = True
            lblLandmarkName.Enabled = True
            txtLandmarkName.Enabled = True
            lblLandmarkDescription.Enabled = True
            txtLandmarkDescription.Enabled = True
            lblLandmarkType.Enabled = True
        Else
            lblLandmarkName.Enabled = False
            lblNameAbbr.Enabled = False
            txtLandmarkName.Enabled = False
            txtLandmarkNameAbbr.Text = String.Empty
            txtLandmarkNameAbbr.Enabled = False
            txtLandmarkName.Text = String.Empty
            lblLandmarkDescription.Enabled = False
            txtLandmarkDescription.Enabled = False
            txtLandmarkDescription.Text = String.Empty
            lblLandmarkType.Enabled = False
            cmbLandmarkType.SelectedIndex = -1
            rbPoint.Checked = True
        End If
    End Sub

    Private Sub rbPoint_Click(sender As Object, e As EventArgs) Handles rbPoint.Click
        If txtSelectedObject.Tag Is Nothing Then Return
        If MsgBox("Converting this instance type to Point. Are you sure?", vbYesNo) = vbNo Then Return
        Dim oMarker As clsMarker = DirectCast(txtSelectedObject.Tag, clsMarker)

        SaveMarker("", (oMarker.Left + (oMarker.Width / 2)), (oMarker.Top + (oMarker.Height / 2)), False, "", True, oMarker.Id)
        SaveLandmark(String.Empty, String.Empty, String.Empty, String.Empty, False, oMarker.Id)
        oMarker.Image = ilCampusMapEditor.Images("point")
    End Sub

    Private Sub rbLandmark_Click(sender As Object, e As EventArgs) Handles rbLandmark.Click
        If txtSelectedObject.Tag Is Nothing Then Return
        If MsgBox("Converting this instance type to Landmark. Are you sure?", vbYesNo) = vbNo Then Return
        Dim oMarker As clsMarker = DirectCast(txtSelectedObject.Tag, clsMarker)

        SaveMarker("", (oMarker.Left + (oMarker.Width / 2)), (oMarker.Top + (oMarker.Height / 2)), True, "", True, oMarker.Id)
        SaveLandmark("Landmark", "", "", "", True, oMarker.Id)
        oMarker.Image = ilCampusMapEditor.Images("landmark")
    End Sub

    Private Sub chkStartingPoint_Click(sender As Object, e As EventArgs) Handles chkStartingPoint.Click
        If chkStartingPoint.Checked Then
            SaveStartPoint(Val(txtSelectedObjectID.Text))
        End If
    End Sub

End Class
