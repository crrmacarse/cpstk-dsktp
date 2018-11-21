Public Class ucNumpad

    Public TextboxState As Collection

    Public Sub appendTextBox(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDash.Click
        If frmLogin.txtUsername.TextLength < 10 Then
            frmLogin.txtUsername.AppendText(sender.Tag.ToString)
        End If
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If (frmLogin.txtUsername.Text.Length > 0) Then
            frmLogin.txtUsername.Text = frmLogin.txtUsername.Text.Remove(frmLogin.txtUsername.Text.Length - 1)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        frmLogin.txtUsername.Clear()
    End Sub
End Class
