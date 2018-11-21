Public Class frmUser

    
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim frm As New frmEvents
        frm.ShowDialog()
    End Sub

    Private Sub btnExamSchedule_Click(sender As Object, e As EventArgs) Handles btnExamSchedule.Click
        Dim frm As New frmExamSchedule
        frm.ShowDialog()

    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        Dim frm As New frmGrades
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        modAccountUser.cAccountUser = Nothing
        Close()
    End Sub


    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
       

        lblAccountFullName.Text = cAccountUser.Fullname
        lblAccountType.Text = cAccountUser.Information
    End Sub



    Private Sub btnClassSchedule_Click(sender As Object, e As EventArgs) Handles btnClassSchedule.Click
        Dim frm As New frmClassSched
        frm.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim frm As New frmChangePassword
        frm.ShowDialog()
        '    If cAccountUser.id = 1 Then
        '        frmSettings.ShowDialog()
        '    Else
        '        modGeneral.showMessageBox("For the meantime, this function is limited for Administrator Use.", MessageBoxIcon.Warning, "Sorry")
        '    End If
        'modGeneral.showMessageBox("This function is still under construction...", MessageBoxIcon.Warning, "Sorry :(")
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        modGeneral.showMessageBox("This function is still under construction...", MessageBoxIcon.Warning, "Sorry :(")
    End Sub

    Private Sub btnNotifcations_Click(sender As Object, e As EventArgs) Handles btnNotifcations.Click
        modGeneral.showMessageBox("Got Feedback?" & Environment.NewLine & Environment.NewLine & "---" & Environment.NewLine & "Press YES for nothing and NO for nothing.", MessageBoxIcon.Question, "Feedback Form")
    End Sub

End Class