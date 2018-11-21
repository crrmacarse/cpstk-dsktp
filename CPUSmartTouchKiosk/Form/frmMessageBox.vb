Public Class frmMessageBox

    Public _message As String
    Public _caption As String
    Public _icon As MessageBoxIcon

    Public Sub New(message As String, icon As MessageBoxIcon, caption As String)
        InitializeComponent()
        _message = message
        _caption = caption
        _icon = icon
    End Sub

    Private Sub frmMessageBox_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblMessageBoxTitle.Text = _caption
        rtbMessageBoxContent.Text = _message

        Select Case _icon
            Case MessageBoxIcon.Information
                btnOk.Visible = True
            Case MessageBoxIcon.Exclamation
                btnOk.Visible = True
            Case MessageBoxIcon.Question
                btnYes.Visible = True
                btnNo.Visible = True
            Case MessageBoxIcon.Warning
                btnOk.Visible = True
            Case MessageBoxIcon.Error
                btnOk.Visible = True
        End Select
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        DialogResult = Windows.Forms.DialogResult.No
    End Sub


    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub rtbMessageBoxContent_KeyDown(sender As Object, e As KeyEventArgs) Handles rtbMessageBoxContent.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnOk.Visible = True Then
                btnOk.PerformClick()
            ElseIf btnYes.Visible Then
                btnYes.PerformClick()
            End If
        End If
    End Sub

End Class