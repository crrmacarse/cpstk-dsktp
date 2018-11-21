<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamSchedule
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pnlExamSched = New System.Windows.Forms.Panel()
        Me.lvExamSched = New System.Windows.Forms.ListView()
        Me.chExamSchedTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedSubjectSchedule = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedSubjTeacher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedExamProc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedRoomName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.lblAccountFullName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pdExamSched = New System.Drawing.Printing.PrintDocument()
        Me.chSubjectCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlExamSched.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(928, 644)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(176, 73)
        Me.btnPrint.TabIndex = 89
        Me.btnPrint.TabStop = False
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(1132, 644)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(176, 73)
        Me.btnReturn.TabIndex = 88
        Me.btnReturn.TabStop = False
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'pnlExamSched
        '
        Me.pnlExamSched.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlExamSched.Controls.Add(Me.lvExamSched)
        Me.pnlExamSched.Controls.Add(Me.Panel1)
        Me.pnlExamSched.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlExamSched.Location = New System.Drawing.Point(0, 0)
        Me.pnlExamSched.Name = "pnlExamSched"
        Me.pnlExamSched.Size = New System.Drawing.Size(1370, 606)
        Me.pnlExamSched.TabIndex = 95
        '
        'lvExamSched
        '
        Me.lvExamSched.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvExamSched.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvExamSched.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvExamSched.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSubjectCode, Me.chExamSchedDate, Me.chExamSchedTime, Me.chExamSchedSubjectSchedule, Me.chExamSchedSubjTeacher, Me.chExamSchedExamProc, Me.chExamSchedRoomName})
        Me.lvExamSched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvExamSched.Enabled = False
        Me.lvExamSched.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvExamSched.FullRowSelect = True
        Me.lvExamSched.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvExamSched.Location = New System.Drawing.Point(38, 164)
        Me.lvExamSched.Name = "lvExamSched"
        Me.lvExamSched.Size = New System.Drawing.Size(1306, 412)
        Me.lvExamSched.TabIndex = 95
        Me.lvExamSched.UseCompatibleStateImageBehavior = False
        Me.lvExamSched.View = System.Windows.Forms.View.Details
        '
        'chExamSchedTime
        '
        Me.chExamSchedTime.Text = "Time"
        Me.chExamSchedTime.Width = 130
        '
        'chExamSchedDate
        '
        Me.chExamSchedDate.Text = "Exam Date"
        Me.chExamSchedDate.Width = 250
        '
        'chExamSchedSubjectSchedule
        '
        Me.chExamSchedSubjectSchedule.Text = "Schedule"
        Me.chExamSchedSubjectSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedSubjectSchedule.Width = 225
        '
        'chExamSchedSubjTeacher
        '
        Me.chExamSchedSubjTeacher.Text = "Subject Teacher"
        Me.chExamSchedSubjTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedSubjTeacher.Width = 257
        '
        'chExamSchedExamProc
        '
        Me.chExamSchedExamProc.Text = "Subject Proctor"
        Me.chExamSchedExamProc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedExamProc.Width = 270
        '
        'chExamSchedRoomName
        '
        Me.chExamSchedRoomName.Text = "Room"
        Me.chExamSchedRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedRoomName.Width = 120
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAccountType)
        Me.Panel1.Controls.Add(Me.lblAccountFullName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 100)
        Me.Panel1.TabIndex = 94
        '
        'lblAccountType
        '
        Me.lblAccountType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountType.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccountType.Location = New System.Drawing.Point(986, 56)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(372, 16)
        Me.lblAccountType.TabIndex = 74
        Me.lblAccountType.Text = "BS Information Technology"
        Me.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccountFullName
        '
        Me.lblAccountFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblAccountFullName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountFullName.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccountFullName.Location = New System.Drawing.Point(628, 9)
        Me.lblAccountFullName.Name = "lblAccountFullName"
        Me.lblAccountFullName.Size = New System.Drawing.Size(730, 47)
        Me.lblAccountFullName.TabIndex = 71
        Me.lblAccountFullName.Text = "Occena, Mikoy"
        Me.lblAccountFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label2.Text = "View Examination Schedule"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pdExamSched
        '
        '
        'chSubjectCode
        '
        Me.chSubjectCode.Text = "Subject Code"
        Me.chSubjectCode.Width = 0
        '
        'frmExamSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pnlExamSched)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExamSchedule"
        Me.Text = "ExamSched"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlExamSched.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents pnlExamSched As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAccountType As System.Windows.Forms.Label
    Friend WithEvents lblAccountFullName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pdExamSched As System.Drawing.Printing.PrintDocument
    Friend WithEvents lvExamSched As System.Windows.Forms.ListView
    Friend WithEvents chExamSchedTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedSubjectSchedule As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedExamProc As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedRoomName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedSubjTeacher As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSubjectCode As System.Windows.Forms.ColumnHeader
End Class
