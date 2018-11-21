Public Class frmShutdown

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        If txtBackdoorPassword.Text = modGeneral.sAdministratorPassword Then
            Application.Exit()
        Else
            modGeneral.showMessageBox("Password Incorrect", MessageBoxIcon.Error, "Invalid Credentials")
            txtBackdoorPassword.Clear()
        End If
    End Sub

    Private Sub txtBackdoorPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBackdoorPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnShutdown.PerformClick()
        End If
    End Sub
End Class