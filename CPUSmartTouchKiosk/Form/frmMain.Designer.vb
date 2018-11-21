<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnNavigation = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblMainLoadingScreen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tMain = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.pbLoadingScreenLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbLoadingScreenLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNavigation
        '
        Me.btnNavigation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnNavigation.FlatAppearance.BorderSize = 0
        Me.btnNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavigation.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavigation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNavigation.Location = New System.Drawing.Point(731, 556)
        Me.btnNavigation.Name = "btnNavigation"
        Me.btnNavigation.Size = New System.Drawing.Size(266, 114)
        Me.btnNavigation.TabIndex = 0
        Me.btnNavigation.TabStop = False
        Me.btnNavigation.Text = "Navigation"
        Me.btnNavigation.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(1030, 556)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(266, 114)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.TabStop = False
        Me.btnLogin.Text = "Log-in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblMainLoadingScreen
        '
        Me.lblMainLoadingScreen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMainLoadingScreen.AutoSize = True
        Me.lblMainLoadingScreen.Font = New System.Drawing.Font("Century Gothic", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainLoadingScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMainLoadingScreen.Location = New System.Drawing.Point(398, 52)
        Me.lblMainLoadingScreen.Name = "lblMainLoadingScreen"
        Me.lblMainLoadingScreen.Size = New System.Drawing.Size(926, 80)
        Me.lblMainLoadingScreen.TabIndex = 2
        Me.lblMainLoadingScreen.Text = "Central Philippine University"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(630, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Smart Touch Information Kiosk"
        '
        'tMain
        '
        Me.tMain.Enabled = True
        Me.tMain.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbLoadingScreenLogo)
        Me.Panel1.Location = New System.Drawing.Point(72, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 286)
        Me.Panel1.TabIndex = 56
        '
        'btnHistory
        '
        Me.btnHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHistory.Location = New System.Drawing.Point(426, 556)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(266, 114)
        Me.btnHistory.TabIndex = 57
        Me.btnHistory.TabStop = False
        Me.btnHistory.Text = "Learn History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'pbLoadingScreenLogo
        '
        Me.pbLoadingScreenLogo.Image = CType(resources.GetObject("pbLoadingScreenLogo.Image"), System.Drawing.Image)
        Me.pbLoadingScreenLogo.Location = New System.Drawing.Point(32, 35)
        Me.pbLoadingScreenLogo.Name = "pbLoadingScreenLogo"
        Me.pbLoadingScreenLogo.Size = New System.Drawing.Size(225, 212)
        Me.pbLoadingScreenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLoadingScreenLogo.TabIndex = 55
        Me.pbLoadingScreenLogo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMainLoadingScreen)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnNavigation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbLoadingScreenLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNavigation As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblMainLoadingScreen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tMain As System.Windows.Forms.Timer
    Friend WithEvents pbLoadingScreenLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnHistory As System.Windows.Forms.Button
End Class
