Imports System.Data.SqlClient

Public Class frmHistory

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub


    Dim college As New ArrayList()


    Private Sub loadCollege()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Dim sQuery As String = "SELECT College.idCollege, College.CNameAbbr FROM College WHERE CSTatus = 1 ORDER BY College.CName"
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    Dim oReader = oCommand.ExecuteReader
                    While oReader.Read
                        college.Add(New clsKeyValuePair(oReader("idCollege").ToString(), oReader("CNameAbbr").ToString))
                    End While
                End Using

                cmbCollege.DataSource = college
                cmbCollege.DisplayMember = "value"
                cmbCollege.ValueMember = "key"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub



    Private Sub loadDescription()
        rtbDescription.SuspendLayout()
        rtbDescription.Clear()
        Using oConnect As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnect.Open()
                Dim sQuery As String = "SELECT College.CName, Landmark.LName, CHistory,CDean FROM College " & _
                    "INNER JOIN Landmark ON Landmark.idLandmark = College.idLandmark WHERE CSTatus = 1 AND idCollege = @idcollege ORDER BY College.CName"
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    oCommand.Parameters.AddWithValue("@idcollege", cmbCollege.SelectedValue)
                    Dim oReader = oCommand.ExecuteReader
                    While oReader.Read
                        rtbDescription.Text = oReader("CHistory").ToString()
                        lblTitle.Text = oReader("CName")
                        lblLandmark.Text = oReader("LName")
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message & " | " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try
        End Using
        rtbDescription.ResumeLayout()
    End Sub

    Private Sub loadCourse()
        rtbCourses.SuspendLayout()
        rtbCourses.Clear()
        Using oConnect As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnect.Open()
                Dim sQuery As String = "SELECT CName FROM Course WHERE idCollege = @idcollege AND CStatus = 1"
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    oCommand.Parameters.AddWithValue("@idcollege", cmbCollege.SelectedValue)
                    Dim oReader = oCommand.ExecuteReader
                    While oReader.Read
                        rtbCourses.Text &= "• " & oReader("CName").ToString() & vbCrLf
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message & " | " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try
        End Using
        rtbCourses.ResumeLayout()
    End Sub

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCollege()
    End Sub

    Private Sub cmbCollege_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCollege.SelectedValueChanged
        rtbDescription.Clear()
        If IsNumeric(cmbCollege.SelectedValue) = True Then
            loadDescription()
            loadCourse()
        End If

    End Sub
End Class