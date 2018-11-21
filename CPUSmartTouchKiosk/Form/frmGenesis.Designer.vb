<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenesis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenesis))
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.btnConfigure = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblApplicationVersion = New System.Windows.Forms.Label()
        Me.lblMainLoadingScreen = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlConfigure = New System.Windows.Forms.Panel()
        Me.tcConfigure = New System.Windows.Forms.TabControl()
        Me.tpDatabase = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.tpMapping = New System.Windows.Forms.TabPage()
        Me.cbMappingAgreed = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLaunchMappingEditor = New System.Windows.Forms.Button()
        Me.tpPrinter = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrinter = New System.Windows.Forms.TextBox()
        Me.tpChangelog = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.tpAboutUs = New System.Windows.Forms.TabPage()
        Me.rtbAbouUs = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbLoadingScreenLogo = New System.Windows.Forms.PictureBox()
        Me.pnlTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlConfigure.SuspendLayout()
        Me.tcConfigure.SuspendLayout()
        Me.tpDatabase.SuspendLayout()
        Me.tpMapping.SuspendLayout()
        Me.tpPrinter.SuspendLayout()
        Me.tpChangelog.SuspendLayout()
        Me.tpAboutUs.SuspendLayout()
        CType(Me.pbLoadingScreenLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLaunch
        '
        Me.btnLaunch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLaunch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLaunch.FlatAppearance.BorderSize = 0
        Me.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaunch.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnLaunch.Location = New System.Drawing.Point(337, 399)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(201, 34)
        Me.btnLaunch.TabIndex = 91
        Me.btnLaunch.TabStop = False
        Me.btnLaunch.Text = "Launch Application"
        Me.btnLaunch.UseVisualStyleBackColor = False
        '
        'btnConfigure
        '
        Me.btnConfigure.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfigure.FlatAppearance.BorderSize = 0
        Me.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigure.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfigure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnConfigure.Location = New System.Drawing.Point(12, 399)
        Me.btnConfigure.Name = "btnConfigure"
        Me.btnConfigure.Size = New System.Drawing.Size(104, 34)
        Me.btnConfigure.TabIndex = 92
        Me.btnConfigure.TabStop = False
        Me.btnConfigure.Text = "Configure"
        Me.btnConfigure.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(544, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 34)
        Me.btnExit.TabIndex = 93
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblApplicationVersion)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(660, 26)
        Me.pnlTop.TabIndex = 60
        '
        'lblApplicationVersion
        '
        Me.lblApplicationVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApplicationVersion.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationVersion.ForeColor = System.Drawing.Color.White
        Me.lblApplicationVersion.Location = New System.Drawing.Point(456, 5)
        Me.lblApplicationVersion.Name = "lblApplicationVersion"
        Me.lblApplicationVersion.Size = New System.Drawing.Size(202, 13)
        Me.lblApplicationVersion.TabIndex = 61
        Me.lblApplicationVersion.Text = "Application Version 1.1"
        Me.lblApplicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMainLoadingScreen
        '
        Me.lblMainLoadingScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMainLoadingScreen.AutoSize = True
        Me.lblMainLoadingScreen.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainLoadingScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMainLoadingScreen.Location = New System.Drawing.Point(60, 251)
        Me.lblMainLoadingScreen.Name = "lblMainLoadingScreen"
        Me.lblMainLoadingScreen.Size = New System.Drawing.Size(556, 47)
        Me.lblMainLoadingScreen.TabIndex = 3
        Me.lblMainLoadingScreen.Text = "Central Philippine University"
        Me.lblMainLoadingScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 355)
        Me.Panel2.TabIndex = 57
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(658, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 355)
        Me.Panel3.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.pnlConfigure)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pbLoadingScreenLogo)
        Me.Panel1.Controls.Add(Me.lblMainLoadingScreen)
        Me.Panel1.Controls.Add(Me.pnlTop)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 381)
        Me.Panel1.TabIndex = 0
        '
        'pnlConfigure
        '
        Me.pnlConfigure.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlConfigure.Controls.Add(Me.tcConfigure)
        Me.pnlConfigure.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigure.Location = New System.Drawing.Point(2, 26)
        Me.pnlConfigure.Name = "pnlConfigure"
        Me.pnlConfigure.Size = New System.Drawing.Size(656, 355)
        Me.pnlConfigure.TabIndex = 98
        Me.pnlConfigure.Visible = False
        '
        'tcConfigure
        '
        Me.tcConfigure.Controls.Add(Me.tpDatabase)
        Me.tcConfigure.Controls.Add(Me.tpMapping)
        Me.tcConfigure.Controls.Add(Me.tpPrinter)
        Me.tcConfigure.Controls.Add(Me.tpChangelog)
        Me.tcConfigure.Controls.Add(Me.tpAboutUs)
        Me.tcConfigure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcConfigure.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcConfigure.Location = New System.Drawing.Point(0, 0)
        Me.tcConfigure.Name = "tcConfigure"
        Me.tcConfigure.SelectedIndex = 0
        Me.tcConfigure.Size = New System.Drawing.Size(656, 355)
        Me.tcConfigure.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tcConfigure.TabIndex = 94
        '
        'tpDatabase
        '
        Me.tpDatabase.Controls.Add(Me.btnSave)
        Me.tpDatabase.Controls.Add(Me.Label1)
        Me.tpDatabase.Controls.Add(Me.txtPort)
        Me.tpDatabase.Controls.Add(Me.btnTestConnection)
        Me.tpDatabase.Controls.Add(Me.lblPassword)
        Me.tpDatabase.Controls.Add(Me.txtPassword)
        Me.tpDatabase.Controls.Add(Me.lblUsername)
        Me.tpDatabase.Controls.Add(Me.txtUsername)
        Me.tpDatabase.Controls.Add(Me.lblDatabaseName)
        Me.tpDatabase.Controls.Add(Me.txtDatabaseName)
        Me.tpDatabase.Controls.Add(Me.lblServerName)
        Me.tpDatabase.Controls.Add(Me.txtServerName)
        Me.tpDatabase.Location = New System.Drawing.Point(4, 23)
        Me.tpDatabase.Name = "tpDatabase"
        Me.tpDatabase.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDatabase.Size = New System.Drawing.Size(648, 328)
        Me.tpDatabase.TabIndex = 0
        Me.tpDatabase.Text = "Database"
        Me.tpDatabase.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(527, 267)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 40)
        Me.btnSave.TabIndex = 7
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(491, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtPort.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.ForeColor = System.Drawing.Color.DimGray
        Me.txtPort.Location = New System.Drawing.Point(494, 37)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(138, 29)
        Me.txtPort.TabIndex = 2
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnTestConnection.FlatAppearance.BorderSize = 0
        Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestConnection.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestConnection.ForeColor = System.Drawing.Color.White
        Me.btnTestConnection.Location = New System.Drawing.Point(383, 267)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(138, 40)
        Me.btnTestConnection.TabIndex = 6
        Me.btnTestConnection.TabStop = False
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(15, 129)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(63, 16)
        Me.lblPassword.TabIndex = 102
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(18, 149)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(614, 29)
        Me.txtPassword.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(15, 75)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 16)
        Me.lblUsername.TabIndex = 100
        Me.lblUsername.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(18, 95)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(614, 29)
        Me.txtUsername.TabIndex = 3
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDatabaseName.Location = New System.Drawing.Point(15, 188)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(101, 16)
        Me.lblDatabaseName.TabIndex = 98
        Me.lblDatabaseName.Text = "Database name"
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDatabaseName.BackColor = System.Drawing.SystemColors.Window
        Me.txtDatabaseName.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabaseName.ForeColor = System.Drawing.Color.DimGray
        Me.txtDatabaseName.Location = New System.Drawing.Point(18, 208)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(614, 29)
        Me.txtDatabaseName.TabIndex = 5
        '
        'lblServerName
        '
        Me.lblServerName.AutoSize = True
        Me.lblServerName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblServerName.Location = New System.Drawing.Point(15, 17)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(84, 16)
        Me.lblServerName.TabIndex = 96
        Me.lblServerName.Text = "Server Name"
        '
        'txtServerName
        '
        Me.txtServerName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtServerName.BackColor = System.Drawing.SystemColors.Window
        Me.txtServerName.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerName.ForeColor = System.Drawing.Color.DimGray
        Me.txtServerName.Location = New System.Drawing.Point(18, 37)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(461, 29)
        Me.txtServerName.TabIndex = 1
        '
        'tpMapping
        '
        Me.tpMapping.Controls.Add(Me.cbMappingAgreed)
        Me.tpMapping.Controls.Add(Me.Label6)
        Me.tpMapping.Controls.Add(Me.btnLaunchMappingEditor)
        Me.tpMapping.Location = New System.Drawing.Point(4, 23)
        Me.tpMapping.Name = "tpMapping"
        Me.tpMapping.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMapping.Size = New System.Drawing.Size(648, 328)
        Me.tpMapping.TabIndex = 1
        Me.tpMapping.Text = "Mapping"
        Me.tpMapping.UseVisualStyleBackColor = True
        '
        'cbMappingAgreed
        '
        Me.cbMappingAgreed.AutoSize = True
        Me.cbMappingAgreed.Location = New System.Drawing.Point(44, 55)
        Me.cbMappingAgreed.Name = "cbMappingAgreed"
        Me.cbMappingAgreed.Size = New System.Drawing.Size(15, 14)
        Me.cbMappingAgreed.TabIndex = 107
        Me.cbMappingAgreed.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(75, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(554, 157)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'btnLaunchMappingEditor
        '
        Me.btnLaunchMappingEditor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLaunchMappingEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnLaunchMappingEditor.FlatAppearance.BorderSize = 0
        Me.btnLaunchMappingEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaunchMappingEditor.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunchMappingEditor.ForeColor = System.Drawing.Color.White
        Me.btnLaunchMappingEditor.Location = New System.Drawing.Point(407, 259)
        Me.btnLaunchMappingEditor.Name = "btnLaunchMappingEditor"
        Me.btnLaunchMappingEditor.Size = New System.Drawing.Size(222, 40)
        Me.btnLaunchMappingEditor.TabIndex = 105
        Me.btnLaunchMappingEditor.TabStop = False
        Me.btnLaunchMappingEditor.Text = "Launch Mapping Editor"
        Me.btnLaunchMappingEditor.UseVisualStyleBackColor = False
        '
        'tpPrinter
        '
        Me.tpPrinter.Controls.Add(Me.Button4)
        Me.tpPrinter.Controls.Add(Me.Label7)
        Me.tpPrinter.Controls.Add(Me.txtPrinter)
        Me.tpPrinter.Location = New System.Drawing.Point(4, 23)
        Me.tpPrinter.Name = "tpPrinter"
        Me.tpPrinter.Size = New System.Drawing.Size(648, 328)
        Me.tpPrinter.TabIndex = 2
        Me.tpPrinter.Text = "Printer"
        Me.tpPrinter.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(494, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 40)
        Me.Button4.TabIndex = 105
        Me.Button4.TabStop = False
        Me.Button4.Text = "Test Print"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Printer Info"
        '
        'txtPrinter
        '
        Me.txtPrinter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrinter.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrinter.ForeColor = System.Drawing.Color.DimGray
        Me.txtPrinter.Location = New System.Drawing.Point(18, 59)
        Me.txtPrinter.MaxLength = 10
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.ReadOnly = True
        Me.txtPrinter.Size = New System.Drawing.Size(614, 29)
        Me.txtPrinter.TabIndex = 97
        '
        'tpChangelog
        '
        Me.tpChangelog.Controls.Add(Me.RichTextBox1)
        Me.tpChangelog.Location = New System.Drawing.Point(4, 23)
        Me.tpChangelog.Name = "tpChangelog"
        Me.tpChangelog.Size = New System.Drawing.Size(648, 328)
        Me.tpChangelog.TabIndex = 3
        Me.tpChangelog.Text = "Changelog"
        Me.tpChangelog.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(648, 328)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'tpAboutUs
        '
        Me.tpAboutUs.AutoScroll = True
        Me.tpAboutUs.Controls.Add(Me.rtbAbouUs)
        Me.tpAboutUs.Location = New System.Drawing.Point(4, 23)
        Me.tpAboutUs.Name = "tpAboutUs"
        Me.tpAboutUs.Size = New System.Drawing.Size(648, 328)
        Me.tpAboutUs.TabIndex = 4
        Me.tpAboutUs.Text = "About Us"
        Me.tpAboutUs.UseVisualStyleBackColor = True
        '
        'rtbAbouUs
        '
        Me.rtbAbouUs.BackColor = System.Drawing.Color.White
        Me.rtbAbouUs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbAbouUs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbAbouUs.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbAbouUs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.rtbAbouUs.Location = New System.Drawing.Point(0, 0)
        Me.rtbAbouUs.Name = "rtbAbouUs"
        Me.rtbAbouUs.Size = New System.Drawing.Size(648, 328)
        Me.rtbAbouUs.TabIndex = 0
        Me.rtbAbouUs.TabStop = False
        Me.rtbAbouUs.Text = resources.GetString("rtbAbouUs.Text")
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(148, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(403, 33)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Smart Touch Information Kiosk"
        '
        'pbLoadingScreenLogo
        '
        Me.pbLoadingScreenLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLoadingScreenLogo.Image = CType(resources.GetObject("pbLoadingScreenLogo.Image"), System.Drawing.Image)
        Me.pbLoadingScreenLogo.Location = New System.Drawing.Point(237, 69)
        Me.pbLoadingScreenLogo.Name = "pbLoadingScreenLogo"
        Me.pbLoadingScreenLogo.Size = New System.Drawing.Size(199, 152)
        Me.pbLoadingScreenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLoadingScreenLogo.TabIndex = 56
        Me.pbLoadingScreenLogo.TabStop = False
        '
        'frmGenesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConfigure)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGenesis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGenesis"
        Me.pnlTop.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlConfigure.ResumeLayout(False)
        Me.tcConfigure.ResumeLayout(False)
        Me.tpDatabase.ResumeLayout(False)
        Me.tpDatabase.PerformLayout()
        Me.tpMapping.ResumeLayout(False)
        Me.tpMapping.PerformLayout()
        Me.tpPrinter.ResumeLayout(False)
        Me.tpPrinter.PerformLayout()
        Me.tpChangelog.ResumeLayout(False)
        Me.tpAboutUs.ResumeLayout(False)
        CType(Me.pbLoadingScreenLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents btnConfigure As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblApplicationVersion As System.Windows.Forms.Label
    Friend WithEvents lblMainLoadingScreen As System.Windows.Forms.Label
    Friend WithEvents pbLoadingScreenLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlConfigure As System.Windows.Forms.Panel
    Friend WithEvents tcConfigure As System.Windows.Forms.TabControl
    Friend WithEvents tpDatabase As System.Windows.Forms.TabPage
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents btnTestConnection As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblDatabaseName As System.Windows.Forms.Label
    Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents lblServerName As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents tpMapping As System.Windows.Forms.TabPage
    Friend WithEvents cbMappingAgreed As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLaunchMappingEditor As System.Windows.Forms.Button
    Friend WithEvents tpPrinter As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrinter As System.Windows.Forms.TextBox
    Friend WithEvents tpChangelog As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents tpAboutUs As System.Windows.Forms.TabPage
    Friend WithEvents rtbAbouUs As System.Windows.Forms.RichTextBox
End Class
