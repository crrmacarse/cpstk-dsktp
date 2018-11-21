Imports System.Data.SqlClient

Public Class frmExamSchedule

    Dim schoolyear As New ArrayList()

    'Private Sub loadSemestralYear()

    '        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
    '            Try
    '                oConnection.Open()
    '                Dim sQuery As String = "SELECT idPeriod, SYYear, PName, PStatus FROM Period INNER JOIN SchoolYear ON SchoolYear.idSchoolYear =" & _
    '                                        " Period.idSchoolYear WHERE PSTatus = 1 ORDER BY SYYear"
    '                Using oCommand As New SqlCommand(sQuery, oConnection)
    '                    Dim oReader = oCommand.ExecuteReader
    '                    While oReader.Read
    '                        schoolyear.Add(New clsKeyValuePair(oReader("idPeriod").ToString(), oReader("PName").ToString & " " & oReader("SYYear").ToString))
    '                    End While
    '                End Using

    '                cmbSchoolYear.DataSource = schoolyear
    '                cmbSchoolYear.DisplayMember = "value"
    '                cmbSchoolYear.ValueMember = "key"
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        End Using
    '    End Sub


    Private Sub loadExamSchedule()
        lvExamSched.BeginUpdate()
        lvExamSched.Items.Clear()
        lvExamSched.Groups.Clear()
        Dim group As ListViewGroup = Nothing
        Using oConnect As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnect.Open()
                Dim sQuery As String = "SELECT idExamScheduleFinal, EXAMDATE, EXTIMESTART, EXTIMEEND, ExamScheduleFinal.SUBJCODE, SUBJSTART, SUBJEND, SUBJDAY," & _
                        " SUBJTEACHER, EXPROCTOR,EXROOM FROM ExamScheduleFinal INNER JOIN ClassScheduleFinal ON ClassScheduleFinal.SUBJCODE = ExamScheduleFinal.SUBJCODE WHERE ClassScheduleFinal.STUDID = @id ORDER BY EXAMDATE"

                Using oCommand As New SqlCommand(sQuery, oConnect)
                    oCommand.Parameters.AddWithValue("@id", cAccountUser.username)
                    Using oReader = oCommand.ExecuteReader
                        While oReader.Read
                            Dim oItem As New ListViewItem

                            group = Nothing
                            For Each oGroup As ListViewGroup In lvExamSched.Groups
                                If oGroup.Header = oReader("SUBJCODE") Then
                                    group = oGroup
                                    Exit For
                                End If
                            Next

                            If group Is Nothing Then
                                group = New ListViewGroup(oReader("SUBJCODE"))

                                lvExamSched.Groups.Add(group)
                            End If

                            oItem.Group = group
                            oItem.SubItems.Add(oReader("EXAMDATE"))
                            oItem.SubItems.Add(oReader("EXTIMESTART") & " - " & oReader("EXTIMEEND"))
                            oItem.SubItems.Add(oReader("SUBJSTART") & " - " & oReader("SUBJEND") & " " & oReader("SUBJDAY"))
                            oItem.SubItems.Add(oReader("SUBJTEACHER"))
                            oItem.SubItems.Add(oReader("EXPROCTOR"))
                            oItem.SubItems.Add(oReader("EXROOM").ToString())

                            lvExamSched.Items.Add(oItem)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        lvExamSched.EndUpdate()
    End Sub


    Private Sub frmExamSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAccountFullName.Text = cAccountUser.Fullname
        lblAccountType.Text = cAccountUser.Information
        loadExamSchedule()
        'cmbExam.SelectedIndex = 0
        'loadSemestralYear()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub

    'Private Sub cmbSchoolYear_SelectedValueChanged(sender As Object, e As EventArgs)
    '    lvExamSched.Items.Clear()
    '    If IsNumeric(cmbSchoolYear.SelectedValue) = True Then
    '        loadExamSchedule()
    '    End If
    'End Sub

    Private Sub cmbExam_SelectedIndexChanged(sender As Object, e As EventArgs)
        loadExamSchedule()
    End Sub

    Private Sub pdExamSched_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdExamSched.PrintPage
        Dim rect As New Rectangle(0, 0, pnlExamSched.Width, pnlExamSched.Height)
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


    Private Sub ShowPrintDialog()
        Dim dialog As PrintDialog = New PrintDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            pdExamSched.DefaultPageSettings.Landscape = True
            pdExamSched.Print()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ShowPrintDialog()
    End Sub

    Private Sub lvExamSched_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvExamSched.SelectedIndexChanged

    End Sub
End Class