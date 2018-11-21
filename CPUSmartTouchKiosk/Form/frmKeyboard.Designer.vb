<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeyboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UcKeyboard1 = New CPUSmartTouchKiosk.ucKeyboard()
        Me.SuspendLayout()
        '
        'UcKeyboard1
        '
        Me.UcKeyboard1.Location = New System.Drawing.Point(-3, -7)
        Me.UcKeyboard1.Name = "UcKeyboard1"
        Me.UcKeyboard1.Size = New System.Drawing.Size(788, 287)
        Me.UcKeyboard1.TabIndex = 0
        '
        'frmKeyboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(779, 269)
        Me.Controls.Add(Me.UcKeyboard1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKeyboard"
        Me.Text = "frmKeyboard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcKeyboard1 As CPUSmartTouchKiosk.ucKeyboard
End Class
