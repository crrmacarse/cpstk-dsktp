<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnClassSchedule = New System.Windows.Forms.Button()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.btnExamSchedule = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblAccountFullName = New System.Windows.Forms.Label()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbLoadingScreenLogo = New System.Windows.Forms.PictureBox()
        Me.btnNotifcations = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pbLoadingScreenLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAccount
        '
        Me.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAccount.Location = New System.Drawing.Point(672, 154)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(292, 119)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.TabStop = False
        Me.btnAccount.Text = "Events"
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnClassSchedule
        '
        Me.btnClassSchedule.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClassSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClassSchedule.FlatAppearance.BorderSize = 0
        Me.btnClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClassSchedule.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClassSchedule.Location = New System.Drawing.Point(1019, 302)
        Me.btnClassSchedule.Name = "btnClassSchedule"
        Me.btnClassSchedule.Size = New System.Drawing.Size(292, 119)
        Me.btnClassSchedule.TabIndex = 3
        Me.btnClassSchedule.TabStop = False
        Me.btnClassSchedule.Text = "Class Schedule"
        Me.btnClassSchedule.UseVisualStyleBackColor = False
        '
        'btnGrades
        '
        Me.btnGrades.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGrades.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnGrades.FlatAppearance.BorderSize = 0
        Me.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrades.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGrades.Location = New System.Drawing.Point(1019, 154)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(292, 119)
        Me.btnGrades.TabIndex = 4
        Me.btnGrades.TabStop = False
        Me.btnGrades.Text = "Grades"
        Me.btnGrades.UseVisualStyleBackColor = False
        '
        'btnExamSchedule
        '
        Me.btnExamSchedule.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExamSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExamSchedule.FlatAppearance.BorderSize = 0
        Me.btnExamSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExamSchedule.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExamSchedule.Location = New System.Drawing.Point(672, 302)
        Me.btnExamSchedule.Name = "btnExamSchedule"
        Me.btnExamSchedule.Size = New System.Drawing.Size(292, 119)
        Me.btnExamSchedule.TabIndex = 5
        Me.btnExamSchedule.TabStop = False
        Me.btnExamSchedule.Text = "Exam Schedule"
        Me.btnExamSchedule.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChangePassword.Location = New System.Drawing.Point(672, 443)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(292, 119)
        Me.btnChangePassword.TabIndex = 3
        Me.btnChangePassword.TabStop = False
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(1019, 443)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(292, 119)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.TabStop = False
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(1135, 614)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(176, 73)
        Me.btnLogout.TabIndex = 51
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Log-out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblAccountFullName
        '
        Me.lblAccountFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountFullName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountFullName.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccountFullName.Location = New System.Drawing.Point(588, 21)
        Me.lblAccountFullName.Name = "lblAccountFullName"
        Me.lblAccountFullName.Size = New System.Drawing.Size(730, 47)
        Me.lblAccountFullName.TabIndex = 58
        Me.lblAccountFullName.Text = "Occena, Mikoy"
        Me.lblAccountFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccountType
        '
        Me.lblAccountType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountType.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccountType.Location = New System.Drawing.Point(843, 68)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(468, 23)
        Me.lblAccountType.TabIndex = 59
        Me.lblAccountType.Text = "Student"
        Me.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.pbLoadingScreenLogo)
        Me.Panel1.Location = New System.Drawing.Point(72, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 286)
        Me.Panel1.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(64, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 19)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Smart Touch Info Kiosk"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 22)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Central Philippine University"
        '
        'pbLoadingScreenLogo
        '
        Me.pbLoadingScreenLogo.Image = CType(resources.GetObject("pbLoadingScreenLogo.Image"), System.Drawing.Image)
        Me.pbLoadingScreenLogo.Location = New System.Drawing.Point(38, 30)
        Me.pbLoadingScreenLogo.Name = "pbLoadingScreenLogo"
        Me.pbLoadingScreenLogo.Size = New System.Drawing.Size(214, 181)
        Me.pbLoadingScreenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLoadingScreenLogo.TabIndex = 55
        Me.pbLoadingScreenLogo.TabStop = False
        '
        'btnNotifcations
        '
        Me.btnNotifcations.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNotifcations.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnNotifcations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifcations.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotifcations.ForeColor = System.Drawing.Color.White
        Me.btnNotifcations.Location = New System.Drawing.Point(39, 632)
        Me.btnNotifcations.Name = "btnNotifcations"
        Me.btnNotifcations.Size = New System.Drawing.Size(57, 55)
        Me.btnNotifcations.TabIndex = 61
        Me.btnNotifcations.TabStop = False
        Me.btnNotifcations.UseVisualStyleBackColor = False
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 722)
        Me.Controls.Add(Me.btnNotifcations)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblAccountType)
        Me.Controls.Add(Me.lblAccountFullName)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnExamSchedule)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnGrades)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnClassSchedule)
        Me.Controls.Add(Me.btnAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbLoadingScreenLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAccount As System.Windows.Forms.Button
    Friend WithEvents btnClassSchedule As System.Windows.Forms.Button
    Friend WithEvents btnGrades As System.Windows.Forms.Button
    Friend WithEvents btnExamSchedule As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblAccountFullName As System.Windows.Forms.Label
    Friend WithEvents lblAccountType As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pbLoadingScreenLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnNotifcations As System.Windows.Forms.Button
End Class
