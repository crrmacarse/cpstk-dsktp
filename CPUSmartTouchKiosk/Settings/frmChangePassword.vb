Public Class frmChangePassword

    Dim numpadToggler As Boolean = True

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If modGeneral.showMessageBox("Are you sure you want to change your Password", MessageBoxIcon.Question, "Password Change") = Windows.Forms.DialogResult.No Then
            Return
        End If

        If txtNewPassword.Text <> txtRENewPassword.Text Then
            modGeneral.showMessageBox("Password mismatch. Please try again", MessageBoxIcon.Error, "Password Change Error")
            txtRENewPassword.Clear()
            txtRENewPassword.Focus()
        ElseIf txtNewPassword.Text.Length < 3 Then
            modGeneral.showMessageBox("Password is too short. Minimum Allowable Password Length is 3", MessageBoxIcon.Error, "Password Change Error")
            txtNewPassword.Clear()
            txtRENewPassword.Clear()
            txtNewPassword.Focus()
        ElseIf Not IsNumeric(txtNewPassword.Text) Or Not IsNumeric(txtRENewPassword.Text) Then
            modGeneral.showMessageBox("Password only accepts 11 Minum numbers", MessageBoxIcon.Error, "Error")
        ElseIf modAccountUser.changePassword(txtNewPassword.Text.Trim) Then
            modGeneral.showMessageBox("Succesfully Changed Password")
            Close()
        Else
            modGeneral.showMessageBox("There seems to be an Error in Changing Password", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAccountFullName.Text = cAccountUser.Fullname
        lblAccountType.Text = cAccountUser.Information
        txtNewPassword.Focus()
    End Sub


    Private Sub txtFill(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDash.Click
        If numpadToggler = True Then
            txtNewPassword.AppendText(sender.Tag)
        ElseIf numpadToggler = False Then
            txtRENewPassword.AppendText(sender.Tag)
        End If
    End Sub

    Private Sub txtNewPassword_Enter(sender As Object, e As EventArgs) Handles txtNewPassword.Enter
        numpadToggler = True
    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        numpadToggler = True
    End Sub

    Private Sub txtRENewPassword_Click(sender As Object, e As EventArgs) Handles txtRENewPassword.Click
        If txtNewPassword.TextLength > 0 Then
            numpadToggler = False
            txtRENewPassword.ReadOnly = False
        End If
    End Sub

    Private Sub txtRENewPassword_Enter(sender As Object, e As EventArgs) Handles txtRENewPassword.Enter
        If txtNewPassword.TextLength > 0 Then
            numpadToggler = False
            txtRENewPassword.ReadOnly = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If numpadToggler = True Then
            txtNewPassword.Clear()
        ElseIf numpadToggler = False Then
            txtRENewPassword.Clear()
        End If
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If numpadToggler = True And txtNewPassword.Text.Length > 0 Then
            txtNewPassword.Text = txtNewPassword.Text.Remove(txtNewPassword.Text.Length - 1)
        ElseIf numpadToggler = False And txtRENewPassword.Text.Length > 0 Then
            txtRENewPassword.Text = txtRENewPassword.Text.Remove(txtRENewPassword.Text.Length - 1)
        End If
    End Sub

End Class