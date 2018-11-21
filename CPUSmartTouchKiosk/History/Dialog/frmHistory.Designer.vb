<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCollege = New System.Windows.Forms.ComboBox()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rtbCourses = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLandmark = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(1107, 609)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(176, 73)
        Me.btnReturn.TabIndex = 80
        Me.btnReturn.TabStop = False
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 100)
        Me.Panel1.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(48, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(730, 47)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "College History"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCollege
        '
        Me.cmbCollege.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCollege.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCollege.FormattingEnabled = True
        Me.cmbCollege.Location = New System.Drawing.Point(1008, 152)
        Me.cmbCollege.Name = "cmbCollege"
        Me.cmbCollege.Size = New System.Drawing.Size(311, 31)
        Me.cmbCollege.TabIndex = 91
        '
        'rtbDescription
        '
        Me.rtbDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescription.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescription.Location = New System.Drawing.Point(46, 295)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.ReadOnly = True
        Me.rtbDescription.Size = New System.Drawing.Size(927, 387)
        Me.rtbDescription.TabIndex = 94
        Me.rtbDescription.TabStop = False
        Me.rtbDescription.Text = "Description"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(38, 198)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(261, 47)
        Me.lblTitle.TabIndex = 93
        Me.lblTitle.Text = "College Title"
        '
        'rtbCourses
        '
        Me.rtbCourses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbCourses.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbCourses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbCourses.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCourses.Location = New System.Drawing.Point(1008, 263)
        Me.rtbCourses.Name = "rtbCourses"
        Me.rtbCourses.ReadOnly = True
        Me.rtbCourses.Size = New System.Drawing.Size(323, 288)
        Me.rtbCourses.TabIndex = 96
        Me.rtbCourses.TabStop = False
        Me.rtbCourses.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1104, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 32)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Courses Offered"
        '
        'lblLandmark
        '
        Me.lblLandmark.Font = New System.Drawing.Font("Century Gothic", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLandmark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblLandmark.Location = New System.Drawing.Point(43, 245)
        Me.lblLandmark.Name = "lblLandmark"
        Me.lblLandmark.Size = New System.Drawing.Size(410, 23)
        Me.lblLandmark.TabIndex = 97
        Me.lblLandmark.Text = "Mary Thomas"
        Me.lblLandmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.lblLandmark)
        Me.Controls.Add(Me.rtbCourses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbCollege)
        Me.Controls.Add(Me.btnReturn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCollege As System.Windows.Forms.ComboBox
    Friend WithEvents rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents rtbCourses As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLandmark As System.Windows.Forms.Label
End Class
