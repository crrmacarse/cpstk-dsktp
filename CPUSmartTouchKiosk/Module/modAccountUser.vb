Imports System.Data.SqlClient

Module modAccountUser

    Public cAccountUser As clsAccountUser

    Public Class clsAccountUser
        Public id As Integer
        Public course As String
        Public username As Integer
        Public password As String
        Public lastname As String
        Public firstname As String
        Public middlename As String
        Public yearlevel As String
        Public guardianname As String
        Public status As Boolean

        ReadOnly Property Fullname
            Get
                Dim s = String.Empty
                If lastname.Length > 0 Then
                    s &= UCase(lastname) & ", "
                End If
                s &= UCase(firstname(0)) & firstname.Substring(1) & " " & middlename.ElementAt(0)
                Return s
            End Get
        End Property

        ReadOnly Property Information
            Get
                Return course
            End Get
        End Property

    End Class

    Public Function authenticate(username As String, password As String) As Boolean
        Using oConnect As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand("SELECT idStudent, CName, SUsername, SPassword, SLastName, SFirstName, " & _
                                                 "SMiddleName, SYearLevel, SGuardianName, SDateCreated, SStatus FROM Student " & _
                                                 "INNER JOIN Course ON Course.CCode = Student.CCode WHERE Student.SStatus = 1" & _
                                                 "AND Student.SUsername = @username AND Student.SPassword = @password", oConnect)
                    oCommand.Parameters.AddWithValue("@username", username)
                    oCommand.Parameters.AddWithValue("@password", password.ToString())
                    Using oReader = oCommand.ExecuteReader
                        If oReader.Read Then
                            cAccountUser = New clsAccountUser
                            With cAccountUser
                                .id = oReader("idStudent")
                                .course = oReader("CName")
                                .username = oReader("SUsername")
                                .password = oReader("SPassword")
                                .lastname = oReader("SLastName")
                                .firstname = oReader("SFirstName").ToString()
                                .middlename = oReader("SMiddleName")
                                .yearlevel = oReader("SYearLevel")
                                .guardianname = oReader("SGuardianName")
                                .status = oReader("SStatus")
                            End With
                            Return True
                        End If
                        modGeneral.showMessageBox("There is an error in username or password", MessageBoxIcon.Error, "Wrong Credentials")
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Return False
    End Function

    Public Function changePassword(password As String) As Boolean
        Using oConnect As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand("UPDATE Student SET SPassWord = @password WHERE idStudent = @idstudent", oConnect)
                    oCommand.Parameters.AddWithValue("@password", password)
                    oCommand.Parameters.AddWithValue("@idstudent", cAccountUser.id)
                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                modGeneral.showMessageBox(ex.Message, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

End Module
