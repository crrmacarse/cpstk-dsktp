Imports System.Data.SqlClient


Public Class frmLoadingScreen

    Private Sub frmLoadingScreen_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Hide()
        Dim n As New frmMain
        n.ShowDialog()
    End Sub

    Private Sub loadData()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Dim SQuery As String = "SELECT TOP 10 idEventsList, ELStart, ELEnd, ELTitle, ELDescription, ELImage, ELDateCreated, ELStatus FROM EventsList WHERE ELStatus = 1 AND ELEnd >= GETDATE() ORDER BY ELStart"
                Using oCommand As New SqlCommand(SQuery, oConnection)
                    Dim oReader As SqlDataReader
                    oReader = oCommand.ExecuteReader()
                    Dim counter As Integer = 1
                    While oReader.Read
                        Dim Adverts As ucAdvertisement = DirectCast(Me.Controls("ucAdvertisement" + counter.ToString), ucAdvertisement)
                        Adverts.Title = oReader("ELTitle").ToString()
                        Adverts.Descript = oReader("ELDescription").ToString()
                        Adverts.Schedule = oReader("ELStart").ToString() & " - " & oReader("ELEnd").ToString()
                        Adverts.ImagePath = oReader("ELImage").ToString()
                        counter += 1
                    End While

                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub frmLoadingScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
    End Sub

End Class