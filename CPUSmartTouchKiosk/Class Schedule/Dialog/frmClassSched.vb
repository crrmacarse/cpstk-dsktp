Imports System.Data.SqlClient

Public Class frmClassSched

    Dim schoolyear As New ArrayList()

    'Private Sub loadSemestralYear()

    '    Using oConnection As New SqlConnection(modGeneral.getConnectionString())
    '        Try
    '            oConnection.Open()
    '            Dim sQuery As String = "SELECT idPeriod, SYYear, PName, PStatus FROM Period INNER JOIN SchoolYear ON SchoolYear.idSchoolYear =" & _
    '                                    " Period.idSchoolYear WHERE PSTatus = 1 ORDER BY SYYear"
    '            Using oCommand As New SqlCommand(sQuery, oConnection)
    '                Dim oReader = oCommand.ExecuteReader
    '                While oReader.Read
    '                    schoolyear.Add(New clsKeyValuePair(oReader("idPeriod").ToString(), oReader("PName").ToString & " " & oReader("SYYear").ToString))
    '                End While
    '            End Using

    '            cmbSchoolYear.DataSource = schoolyear
    '            cmbSchoolYear.DisplayMember = "value"
    '            cmbSchoolYear.ValueMember = "key"
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Using
    'End Sub

    
    Private Sub frmClassSched_Load(sender As Object, e As EventArgs) Handles Me.Load
        'loadSemestralYear()
        loadClassSched()
        lblAccountFullName.Text = cAccountUser.Fullname
        lblAccountType.Text = cAccountUser.Information
    End Sub

    Private Sub loadClassSched()
        lvClassSched.BeginUpdate()
        lvClassSched.Items.Clear()
        Using oConnect As New SqlConnection(modGeneral.getConnectionString)
            Try

                oConnect.Open()
                Dim sQuery As String = "SELECT idClassScheduleFinal, STUDID, SUBJCODE, STUBCODE, STARTCLASS, ENDCLASS, CLASSDAYS," & _
                " CLASSTYPE, EMPLOYEEID, EMPLOYEENAME, ROOMCODE, CLASSSTATUSCODE FROM ClassScheduleFinal WHERE STUDID = @id"
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    oCommand.Parameters.AddWithValue("@id", cAccountUser.username)
                    Dim oReader = oCommand.ExecuteReader
                    While oReader.Read
                        Dim oItem As New ListViewItem
                        oItem.Text = oReader("STUBCODE").ToString

                        oItem.SubItems.Add(oReader("SUBJCODE").ToString())
                        oItem.SubItems.Add(oReader("STARTCLASS") & " - " & oReader("ENDCLASS"))
                        oItem.SubItems.Add(oReader("CLASSDAYS"))
                        oItem.SubItems.Add(oReader("ROOMCODE"))
                        oItem.SubItems.Add(oReader("EMPLOYEENAME"))

                        lvClassSched.Items.Add(oItem)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message & " | " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try
        End Using
        lvClassSched.EndUpdate()
    End Sub

    'Private Sub cmbSchoolYear_SelectedValueChanged(sender As Object, e As EventArgs)
    '    lvClassSched.Items.Clear()
    '    If IsNumeric(cmbSchoolYear.SelectedValue) = True Then
    '        loadClassSched()
    '    End If
    'End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub

    Private Sub ShowPrintDialog()
        Dim dialog As PrintDialog = New PrintDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            pdClassSched.DefaultPageSettings.Landscape = True
            pdClassSched.Print()
        End If
    End Sub

    Private Sub pdClassSched_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdClassSched.PrintPage
        Dim rect As New Rectangle(0, 0, pnlClassSched.Width, pnlClassSched.Height)
        Dim bmp As New Bitmap(rect.Width, rect.Height)
        Me.DrawToBitmap(bmp, rect)

        Dim l, t, w, h As Integer
        Dim ratio As Single = bmp.Width / bmp.Height

        'size to fit window
        If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then
            w = e.MarginBounds.Width
            h = w / ratio
            t = (e.MarginBounds.Height / 2) - (h / 2)
        Else
            h = e.MarginBounds.Height
            w = h * ratio
            l = (e.MarginBounds.Width / 2) - (w / 2)
        End If

        'draw the image on the graphics
        e.Graphics.DrawImage(bmp, e.MarginBounds.Left + l, e.MarginBounds.Top + t, w, h)
    End Sub

    Private Sub btnClassSchedPrint_Click(sender As Object, e As EventArgs) Handles btnClassSchedPrint.Click
        ShowPrintDialog()
    End Sub

End Class