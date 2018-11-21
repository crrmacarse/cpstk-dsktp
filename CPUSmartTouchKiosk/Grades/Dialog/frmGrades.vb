Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmGrades

    Dim schoolyear As New ArrayList()

    Private Sub loadSemestralYear()

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Dim sQuery As String = "SELECT ACADEMICSCHOOLYEAR, ACADEMICSEMESTERID FROM GradeFinal " & _
                    "GROUP BY ACADEMICSCHOOLYEAR, ACADEMICSEMESTERID ORDER BY ACADEMICSCHOOLYEAR"
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    Dim oReader = oCommand.ExecuteReader
                    While oReader.Read
                        schoolyear.Add(New clsKeyValuePair(oReader("ACADEMICSCHOOLYEAR") & "," & oReader("ACADEMICSEMESTERID").ToString(), convertSemester(oReader("ACADEMICSEMESTERID")) & " " & oReader("ACADEMICSCHOOLYEAR")))
                    End While
                End Using

                cmbSchoolYear.DataSource = schoolyear
                cmbSchoolYear.DisplayMember = "value"
                cmbSchoolYear.ValueMember = "key"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub loadGrades()
        lvGrades.BeginUpdate()
        lvGrades.Items.Clear()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Dim sQuery As String = "WITH GradeList AS(SELECT STUBCODE, SUBJCODE, STGRADE, GRADERMK, ACADEMICSCHOOLYEAR + ',' + CAST(ACADEMICSEMESTERID AS VARCHAR) AS SCHOOLYEAR FROM GradeFinal WHERE STIDNUM = @id)" & _
                " SELECT STUBCODE, SUBJCODE, STGRADE, GRADERMK, SCHOOLYEAR FROM GradeList WHERE SCHOOLYEAR = @schoolyear"
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@id", cAccountUser.username)
                    oCommand.Parameters.AddWithValue("@schoolyear", cmbSchoolYear.SelectedValue.ToString())
                    Dim oReader = oCommand.ExecuteReader
                    While oReader.Read
                        Dim oItem As New ListViewItem
                        oItem.Text = oReader("STUBCODE").ToString()

                        oItem.SubItems.Add(oReader("SUBJCODE"))
                        oItem.SubItems.Add(oReader("STGRADE"))
                        oItem.SubItems.Add(oReader("GRADERMK")).ToString()

                        oItem.Tag = oReader("STUBCODE").ToString()
                        lvGrades.Items.Add(oItem)
                    End While

                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        lvGrades.EndUpdate()
    End Sub

    Private Sub frmGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSemestralYear()
        loadGrades()
        lblAccountFullName.Text = cAccountUser.Fullname
        lblAccountType.Text = cAccountUser.Information
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub

    Private Sub cmbSchoolYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSchoolYear.SelectedValueChanged
        lvGrades.Items.Clear()
        If Not IsNothing(cmbSchoolYear.SelectedValue) Then
            loadGrades()
        End If
    End Sub

    Private Sub pdGrades_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdGrades.PrintPage
        Dim rect As New Rectangle(0, 0, pnlGrades.Width, pnlGrades.Height)
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

    Private Sub btnGradesPrint_Click(sender As Object, e As EventArgs) Handles btnGradesPrint.Click
        ShowPrintDialog()
    End Sub

    Private Sub ShowPrintDialog()
        Dim dialog As PrintDialog = New PrintDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            pdGrades.DefaultPageSettings.Landscape = True
            pdGrades.Print()
        End If
    End Sub

End Class