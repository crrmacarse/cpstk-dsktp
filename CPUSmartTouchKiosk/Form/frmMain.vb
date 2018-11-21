Public Class frmMain

    Dim toggle As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Hide()
        Dim n = New frmLogin
        n.ShowDialog()
    End Sub

    Private Sub tMain_Tick(sender As Object, e As EventArgs) Handles tMain.Tick
        toggle += 1
        If toggle = 500 Then
            Close()
        End If
    End Sub

    Private Sub btnNavigation_Click(sender As Object, e As EventArgs) Handles btnNavigation.Click
        frmCampusMap.ShowDialog()
        Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        frmHistory.ShowDialog()
    End Sub

    Private Sub pbLoadingScreenLogo_Click(sender As Object, e As EventArgs) Handles pbLoadingScreenLogo.Click
        frmShutdown.ShowDialog()
    End Sub

End Class

