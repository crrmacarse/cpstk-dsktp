Public Class frmSettings

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Application.Exit()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub

End Class