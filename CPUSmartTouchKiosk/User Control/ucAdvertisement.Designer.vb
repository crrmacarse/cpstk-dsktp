<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAdvertisement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblAdvertTitle = New System.Windows.Forms.Label()
        Me.lblAdvertDate = New System.Windows.Forms.Label()
        Me.lblAdvertInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAdvertTitle
        '
        Me.lblAdvertTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdvertTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertTitle.Location = New System.Drawing.Point(2, 30)
        Me.lblAdvertTitle.Name = "lblAdvertTitle"
        Me.lblAdvertTitle.Size = New System.Drawing.Size(249, 23)
        Me.lblAdvertTitle.TabIndex = 1
        Me.lblAdvertTitle.Text = "Christ Emphasis Week"
        Me.lblAdvertTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAdvertDate
        '
        Me.lblAdvertDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdvertDate.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertDate.Location = New System.Drawing.Point(0, 53)
        Me.lblAdvertDate.Name = "lblAdvertDate"
        Me.lblAdvertDate.Size = New System.Drawing.Size(247, 19)
        Me.lblAdvertDate.TabIndex = 2
        Me.lblAdvertDate.Text = "June 17 - 18, 2018"
        Me.lblAdvertDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAdvertInfo
        '
        Me.lblAdvertInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdvertInfo.Font = New System.Drawing.Font("Century Gothic", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertInfo.Location = New System.Drawing.Point(3, 83)
        Me.lblAdvertInfo.Name = "lblAdvertInfo"
        Me.lblAdvertInfo.Size = New System.Drawing.Size(244, 88)
        Me.lblAdvertInfo.TabIndex = 3
        Me.lblAdvertInfo.Text = "Take a moment and appreciate God"
        Me.lblAdvertInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ucAdvertisement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.lblAdvertInfo)
        Me.Controls.Add(Me.lblAdvertDate)
        Me.Controls.Add(Me.lblAdvertTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "ucAdvertisement"
        Me.Size = New System.Drawing.Size(250, 200)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAdvertTitle As System.Windows.Forms.Label
    Friend WithEvents lblAdvertDate As System.Windows.Forms.Label
    Friend WithEvents lblAdvertInfo As System.Windows.Forms.Label

End Class
