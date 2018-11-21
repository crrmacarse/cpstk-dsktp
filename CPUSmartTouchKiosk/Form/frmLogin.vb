Public Class frmLogin

    Dim numpadToggler As Boolean

    Private Sub txtFill(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDash.Click
        If numpadToggler = True And txtUsername.Text.Count < 10 Then
            txtUsername.AppendText(sender.Tag)
        ElseIf numpadToggler = False And txtPassword.Text.Count < 10 Then
            txtPassword.AppendText(sender.Tag)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If numpadToggler = True Then
            txtUsername.Clear()
        ElseIf numpadToggler = False Then
            txtPassword.Clear()
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text.Count = 2 Or txtUsername.Text.Count = 7 Then
            txtUsername.AppendText("-")
        ElseIf txtUsername.Text.Count > 9 Then
            txtPassword.Select()
        End If
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        numpadToggler = True
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        numpadToggler = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        authenticateUser()
    End Sub

    Private Sub authenticateUser()
        If txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Then
            modGeneral.showMessageBox("Please Fill in the blanks", MessageBoxIcon.Warning, "Log-in Error")
        Else
            Dim b As Boolean = modAccountUser.authenticate(txtUsername.Text.Replace("-", "").Trim, txtPassword.Text.Trim)
            If b = True Then
                Close()
                Dim Main As New frmUser()
                Main.ShowDialog()
            Else
                txtPassword.Clear()
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If numpadToggler = True And txtUsername.Text.Length > 0 Then
            If txtUsername.Text.Count = 3 Or txtUsername.Text.Count = 8 Then
                txtUsername.Text = txtUsername.Text.Remove(txtUsername.Text.Length - 2)
            Else
                txtUsername.Text = txtUsername.Text.Remove(txtUsername.Text.Length - 1)
            End If
        ElseIf numpadToggler = False And txtPassword.Text.Length > 0 Then
            txtPassword.Text = txtPassword.Text.Remove(txtPassword.Text.Length - 1)
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
    End Sub

End Class