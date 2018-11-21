Imports System.Data.SqlClient

Public Class frmEvents

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub

    Private Sub frmEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData()
        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Dim SQuery As String = "SELECT TOP 12 idEventsList, ELStart, ELEnd, ELTitle, ELDescription, ELImage, ELDateCreated, ELStatus FROM EventsList WHERE ELStatus = 1 AND ELEnd >= GETDATE() ORDER BY idEventsList"
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
End Class