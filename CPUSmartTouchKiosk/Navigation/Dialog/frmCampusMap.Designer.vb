<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCampusMap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCampusMap))
        Me.pbCampusMap = New System.Windows.Forms.PictureBox()
        Me.pnlCampusMap = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ilCampusMapEditor = New System.Windows.Forms.ImageList(Me.components)
        Me.ilCampusMapEditor48 = New System.Windows.Forms.ImageList(Me.components)
        Me.ttLandmark = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbCampusMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCampusMap.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbCampusMap
        '
        Me.pbCampusMap.BackgroundImage = CType(resources.GetObject("pbCampusMap.BackgroundImage"), System.Drawing.Image)
        Me.pbCampusMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbCampusMap.Location = New System.Drawing.Point(0, 0)
        Me.pbCampusMap.Name = "pbCampusMap"
        Me.pbCampusMap.Size = New System.Drawing.Size(1921, 1908)
        Me.pbCampusMap.TabIndex = 15
        Me.pbCampusMap.TabStop = False
        '
        'pnlCampusMap
        '
        Me.pnlCampusMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCampusMap.AutoScroll = True
        Me.pnlCampusMap.Controls.Add(Me.pbCampusMap)
        Me.pnlCampusMap.Location = New System.Drawing.Point(12, 106)
        Me.pnlCampusMap.Name = "pnlCampusMap"
        Me.pnlCampusMap.Size = New System.Drawing.Size(1205, 578)
        Me.pnlCampusMap.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbSearch)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1229, 100)
        Me.Panel1.TabIndex = 88
        '
        'cmbSearch
        '
        Me.cmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(573, 21)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(332, 48)
        Me.cmbSearch.TabIndex = 91
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(923, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(144, 51)
        Me.btnSearch.TabIndex = 90
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(1073, 21)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(144, 51)
        Me.btnReturn.TabIndex = 80
        Me.btnReturn.TabStop = False
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(48, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(730, 47)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Campus Map Navigation"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ilCampusMapEditor
        '
        Me.ilCampusMapEditor.ImageStream = CType(resources.GetObject("ilCampusMapEditor.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCampusMapEditor.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCampusMapEditor.Images.SetKeyName(0, "point")
        Me.ilCampusMapEditor.Images.SetKeyName(1, "landmark")
        '
        'ilCampusMapEditor48
        '
        Me.ilCampusMapEditor48.ImageStream = CType(resources.GetObject("ilCampusMapEditor48.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCampusMapEditor48.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCampusMapEditor48.Images.SetKeyName(0, "landmark01")
        Me.ilCampusMapEditor48.Images.SetKeyName(1, "landmark02")
        '
        'frmCampusMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 696)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlCampusMap)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCampusMap"
        Me.Text = "frmCampusMap"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbCampusMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCampusMap.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbCampusMap As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCampusMap As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents ilCampusMapEditor As ImageList
    Friend WithEvents ilCampusMapEditor48 As System.Windows.Forms.ImageList
    Friend WithEvents ttLandmark As System.Windows.Forms.ToolTip
End Class
