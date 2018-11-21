<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCampusMapEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCampusMapEditor))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSelectedObjectID = New System.Windows.Forms.TextBox()
        Me.txtSelectedObject = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnEndPoint = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnStartPoint = New System.Windows.Forms.Button()
        Me.tsCampusMapEditor = New System.Windows.Forms.ToolStrip()
        Me.tsbtnAddAVertex = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnMarker = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnLandmark = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAddAnEdge = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.lblLandmarkName = New System.Windows.Forms.Label()
        Me.txtLandmarkName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLandmarkType = New System.Windows.Forms.Label()
        Me.cmbLandmarkType = New System.Windows.Forms.ComboBox()
        Me.lblNameAbbr = New System.Windows.Forms.Label()
        Me.txtLandmarkNameAbbr = New System.Windows.Forms.TextBox()
        Me.chkStartingPoint = New System.Windows.Forms.CheckBox()
        Me.rbLandmark = New System.Windows.Forms.RadioButton()
        Me.rbPoint = New System.Windows.Forms.RadioButton()
        Me.lblLandmarkDescription = New System.Windows.Forms.Label()
        Me.txtLandmarkDescription = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pnlMap = New System.Windows.Forms.Panel()
        Me.pbCampusMap = New System.Windows.Forms.PictureBox()
        Me.ilCampusMapEditor = New System.Windows.Forms.ImageList(Me.components)
        Me.tsCampusMapEditor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlMap.SuspendLayout()
        CType(Me.pbCampusMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Instance Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "InstanceID"
        '
        'txtSelectedObjectID
        '
        Me.txtSelectedObjectID.Enabled = False
        Me.txtSelectedObjectID.Location = New System.Drawing.Point(13, 26)
        Me.txtSelectedObjectID.Name = "txtSelectedObjectID"
        Me.txtSelectedObjectID.Size = New System.Drawing.Size(184, 20)
        Me.txtSelectedObjectID.TabIndex = 0
        Me.txtSelectedObjectID.TabStop = False
        '
        'txtSelectedObject
        '
        Me.txtSelectedObject.Enabled = False
        Me.txtSelectedObject.Location = New System.Drawing.Point(13, 65)
        Me.txtSelectedObject.Name = "txtSelectedObject"
        Me.txtSelectedObject.Size = New System.Drawing.Size(184, 20)
        Me.txtSelectedObject.TabIndex = 1
        Me.txtSelectedObject.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 505)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(192, 212)
        Me.ListBox1.TabIndex = 34
        Me.ListBox1.TabStop = False
        '
        'btnEndPoint
        '
        Me.btnEndPoint.Location = New System.Drawing.Point(13, 447)
        Me.btnEndPoint.Name = "btnEndPoint"
        Me.btnEndPoint.Size = New System.Drawing.Size(192, 23)
        Me.btnEndPoint.TabIndex = 7
        Me.btnEndPoint.TabStop = False
        Me.btnEndPoint.Text = "End Point : "
        Me.btnEndPoint.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(13, 476)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(192, 23)
        Me.btnShow.TabIndex = 8
        Me.btnShow.TabStop = False
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnStartPoint
        '
        Me.btnStartPoint.Location = New System.Drawing.Point(13, 418)
        Me.btnStartPoint.Name = "btnStartPoint"
        Me.btnStartPoint.Size = New System.Drawing.Size(192, 23)
        Me.btnStartPoint.TabIndex = 6
        Me.btnStartPoint.TabStop = False
        Me.btnStartPoint.Text = "Start Point :"
        Me.btnStartPoint.UseVisualStyleBackColor = True
        '
        'tsCampusMapEditor
        '
        Me.tsCampusMapEditor.Dock = System.Windows.Forms.DockStyle.Left
        Me.tsCampusMapEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAddAVertex, Me.tsbtnMarker, Me.tsbtnLandmark, Me.tsbtnAddAnEdge, Me.tsbtnDelete})
        Me.tsCampusMapEditor.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCampusMapEditor.Location = New System.Drawing.Point(0, 0)
        Me.tsCampusMapEditor.Name = "tsCampusMapEditor"
        Me.tsCampusMapEditor.Size = New System.Drawing.Size(24, 749)
        Me.tsCampusMapEditor.TabIndex = 42
        Me.tsCampusMapEditor.Text = "ToolStrip1"
        '
        'tsbtnAddAVertex
        '
        Me.tsbtnAddAVertex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAddAVertex.Image = CType(resources.GetObject("tsbtnAddAVertex.Image"), System.Drawing.Image)
        Me.tsbtnAddAVertex.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddAVertex.Name = "tsbtnAddAVertex"
        Me.tsbtnAddAVertex.Size = New System.Drawing.Size(21, 20)
        Me.tsbtnAddAVertex.Text = "A&rrow"
        Me.tsbtnAddAVertex.ToolTipText = "Arrow"
        '
        'tsbtnMarker
        '
        Me.tsbtnMarker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnMarker.Image = CType(resources.GetObject("tsbtnMarker.Image"), System.Drawing.Image)
        Me.tsbtnMarker.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMarker.Name = "tsbtnMarker"
        Me.tsbtnMarker.Size = New System.Drawing.Size(21, 20)
        Me.tsbtnMarker.Text = "P&oint"
        '
        'tsbtnLandmark
        '
        Me.tsbtnLandmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnLandmark.Image = CType(resources.GetObject("tsbtnLandmark.Image"), System.Drawing.Image)
        Me.tsbtnLandmark.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnLandmark.Name = "tsbtnLandmark"
        Me.tsbtnLandmark.Size = New System.Drawing.Size(21, 20)
        Me.tsbtnLandmark.Text = "L&andmark"
        '
        'tsbtnAddAnEdge
        '
        Me.tsbtnAddAnEdge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAddAnEdge.Image = CType(resources.GetObject("tsbtnAddAnEdge.Image"), System.Drawing.Image)
        Me.tsbtnAddAnEdge.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddAnEdge.Name = "tsbtnAddAnEdge"
        Me.tsbtnAddAnEdge.Size = New System.Drawing.Size(21, 20)
        Me.tsbtnAddAnEdge.Text = "W&aypoint"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnDelete.Image = CType(resources.GetObject("tsbtnDelete.Image"), System.Drawing.Image)
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(21, 20)
        Me.tsbtnDelete.Text = "E&raser"
        '
        'lblLandmarkName
        '
        Me.lblLandmarkName.AutoSize = True
        Me.lblLandmarkName.Enabled = False
        Me.lblLandmarkName.Location = New System.Drawing.Point(16, 211)
        Me.lblLandmarkName.Name = "lblLandmarkName"
        Me.lblLandmarkName.Size = New System.Drawing.Size(35, 13)
        Me.lblLandmarkName.TabIndex = 46
        Me.lblLandmarkName.Text = "Name"
        '
        'txtLandmarkName
        '
        Me.txtLandmarkName.Enabled = False
        Me.txtLandmarkName.Location = New System.Drawing.Point(16, 228)
        Me.txtLandmarkName.MaxLength = 50
        Me.txtLandmarkName.Name = "txtLandmarkName"
        Me.txtLandmarkName.Size = New System.Drawing.Size(184, 20)
        Me.txtLandmarkName.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblLandmarkType)
        Me.Panel1.Controls.Add(Me.cmbLandmarkType)
        Me.Panel1.Controls.Add(Me.lblNameAbbr)
        Me.Panel1.Controls.Add(Me.txtLandmarkNameAbbr)
        Me.Panel1.Controls.Add(Me.chkStartingPoint)
        Me.Panel1.Controls.Add(Me.rbLandmark)
        Me.Panel1.Controls.Add(Me.rbPoint)
        Me.Panel1.Controls.Add(Me.lblLandmarkDescription)
        Me.Panel1.Controls.Add(Me.txtLandmarkDescription)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.txtSelectedObjectID)
        Me.Panel1.Controls.Add(Me.lblLandmarkName)
        Me.Panel1.Controls.Add(Me.btnStartPoint)
        Me.Panel1.Controls.Add(Me.txtLandmarkName)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Controls.Add(Me.btnEndPoint)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.txtSelectedObject)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1014, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 749)
        Me.Panel1.TabIndex = 47
        '
        'lblLandmarkType
        '
        Me.lblLandmarkType.AutoSize = True
        Me.lblLandmarkType.Enabled = False
        Me.lblLandmarkType.Location = New System.Drawing.Point(13, 336)
        Me.lblLandmarkType.Name = "lblLandmarkType"
        Me.lblLandmarkType.Size = New System.Drawing.Size(81, 13)
        Me.lblLandmarkType.TabIndex = 54
        Me.lblLandmarkType.Text = "Landmark Type"
        '
        'cmbLandmarkType
        '
        Me.cmbLandmarkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLandmarkType.FormattingEnabled = True
        Me.cmbLandmarkType.Items.AddRange(New Object() {"Building", "Parking"})
        Me.cmbLandmarkType.Location = New System.Drawing.Point(13, 352)
        Me.cmbLandmarkType.Name = "cmbLandmarkType"
        Me.cmbLandmarkType.Size = New System.Drawing.Size(184, 21)
        Me.cmbLandmarkType.TabIndex = 6
        '
        'lblNameAbbr
        '
        Me.lblNameAbbr.AutoSize = True
        Me.lblNameAbbr.Enabled = False
        Me.lblNameAbbr.Location = New System.Drawing.Point(13, 166)
        Me.lblNameAbbr.Name = "lblNameAbbr"
        Me.lblNameAbbr.Size = New System.Drawing.Size(97, 13)
        Me.lblNameAbbr.TabIndex = 52
        Me.lblNameAbbr.Text = "Name Abbreviation"
        '
        'txtLandmarkNameAbbr
        '
        Me.txtLandmarkNameAbbr.Enabled = False
        Me.txtLandmarkNameAbbr.Location = New System.Drawing.Point(16, 184)
        Me.txtLandmarkNameAbbr.MaxLength = 50
        Me.txtLandmarkNameAbbr.Name = "txtLandmarkNameAbbr"
        Me.txtLandmarkNameAbbr.Size = New System.Drawing.Size(184, 20)
        Me.txtLandmarkNameAbbr.TabIndex = 3
        '
        'chkStartingPoint
        '
        Me.chkStartingPoint.AutoSize = True
        Me.chkStartingPoint.Location = New System.Drawing.Point(13, 386)
        Me.chkStartingPoint.Name = "chkStartingPoint"
        Me.chkStartingPoint.Size = New System.Drawing.Size(119, 17)
        Me.chkStartingPoint.TabIndex = 7
        Me.chkStartingPoint.TabStop = False
        Me.chkStartingPoint.Text = "Set as starting point"
        Me.chkStartingPoint.UseVisualStyleBackColor = True
        '
        'rbLandmark
        '
        Me.rbLandmark.AutoSize = True
        Me.rbLandmark.Location = New System.Drawing.Point(19, 128)
        Me.rbLandmark.Name = "rbLandmark"
        Me.rbLandmark.Size = New System.Drawing.Size(72, 17)
        Me.rbLandmark.TabIndex = 2
        Me.rbLandmark.Text = "Landmark"
        Me.rbLandmark.UseVisualStyleBackColor = True
        '
        'rbPoint
        '
        Me.rbPoint.AutoSize = True
        Me.rbPoint.Location = New System.Drawing.Point(19, 105)
        Me.rbPoint.Name = "rbPoint"
        Me.rbPoint.Size = New System.Drawing.Size(49, 17)
        Me.rbPoint.TabIndex = 1
        Me.rbPoint.Text = "Point"
        Me.rbPoint.UseVisualStyleBackColor = True
        '
        'lblLandmarkDescription
        '
        Me.lblLandmarkDescription.AutoSize = True
        Me.lblLandmarkDescription.Enabled = False
        Me.lblLandmarkDescription.Location = New System.Drawing.Point(13, 254)
        Me.lblLandmarkDescription.Name = "lblLandmarkDescription"
        Me.lblLandmarkDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblLandmarkDescription.TabIndex = 49
        Me.lblLandmarkDescription.Text = "Description"
        '
        'txtLandmarkDescription
        '
        Me.txtLandmarkDescription.Enabled = False
        Me.txtLandmarkDescription.Location = New System.Drawing.Point(13, 270)
        Me.txtLandmarkDescription.MaxLength = 250
        Me.txtLandmarkDescription.Multiline = True
        Me.txtLandmarkDescription.Name = "txtLandmarkDescription"
        Me.txtLandmarkDescription.Size = New System.Drawing.Size(184, 60)
        Me.txtLandmarkDescription.TabIndex = 5
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(5, 723)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(192, 23)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'pnlMap
        '
        Me.pnlMap.AutoScroll = True
        Me.pnlMap.BackColor = System.Drawing.Color.White
        Me.pnlMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlMap.Controls.Add(Me.pbCampusMap)
        Me.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMap.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.pnlMap.Location = New System.Drawing.Point(24, 0)
        Me.pnlMap.Name = "pnlMap"
        Me.pnlMap.Size = New System.Drawing.Size(990, 749)
        Me.pnlMap.TabIndex = 48
        '
        'pbCampusMap
        '
        Me.pbCampusMap.Image = CType(resources.GetObject("pbCampusMap.Image"), System.Drawing.Image)
        Me.pbCampusMap.Location = New System.Drawing.Point(3, 3)
        Me.pbCampusMap.Name = "pbCampusMap"
        Me.pbCampusMap.Size = New System.Drawing.Size(1921, 1908)
        Me.pbCampusMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbCampusMap.TabIndex = 0
        Me.pbCampusMap.TabStop = False
        '
        'ilCampusMapEditor
        '
        Me.ilCampusMapEditor.ImageStream = CType(resources.GetObject("ilCampusMapEditor.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCampusMapEditor.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCampusMapEditor.Images.SetKeyName(0, "point")
        Me.ilCampusMapEditor.Images.SetKeyName(1, "landmark")
        '
        'frmCampusMapEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 749)
        Me.Controls.Add(Me.pnlMap)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsCampusMapEditor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCampusMapEditor"
        Me.Text = "frmCampusMapEditor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsCampusMapEditor.ResumeLayout(False)
        Me.tsCampusMapEditor.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMap.ResumeLayout(False)
        Me.pnlMap.PerformLayout()
        CType(Me.pbCampusMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedObjectID As System.Windows.Forms.TextBox
    Friend WithEvents txtSelectedObject As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnEndPoint As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnStartPoint As System.Windows.Forms.Button
    Friend WithEvents tsCampusMapEditor As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnAddAVertex As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnAddAnEdge As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblLandmarkName As System.Windows.Forms.Label
    Friend WithEvents txtLandmarkName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReturn As Button
    Friend WithEvents pnlMap As Panel
    Friend WithEvents tsbtnLandmark As ToolStripButton
    Friend WithEvents tsbtnMarker As ToolStripButton
    Friend WithEvents ilCampusMapEditor As ImageList
    Friend WithEvents lblLandmarkDescription As Label
    Friend WithEvents txtLandmarkDescription As TextBox
    Friend WithEvents rbLandmark As RadioButton
    Friend WithEvents rbPoint As RadioButton
    Friend WithEvents pbCampusMap As System.Windows.Forms.PictureBox
    Friend WithEvents chkStartingPoint As System.Windows.Forms.CheckBox
    Friend WithEvents lblNameAbbr As System.Windows.Forms.Label
    Friend WithEvents txtLandmarkNameAbbr As System.Windows.Forms.TextBox
    Friend WithEvents lblLandmarkType As System.Windows.Forms.Label
    Friend WithEvents cmbLandmarkType As System.Windows.Forms.ComboBox
End Class
