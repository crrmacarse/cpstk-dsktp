<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
        Me.chExamSchedDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedDateStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedDateEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedSubject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedSubjectSchedule = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedSubjectProf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedSubjectProc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExamSchedRoomName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnGradesPrint = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pdGrades = New System.Drawing.Printing.PrintDocument()
        Me.pnlGrades = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSchoolYear = New System.Windows.Forms.ComboBox()
        Me.lvGrades = New System.Windows.Forms.ListView()
        Me.chGradeStubCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGradeDescriptiveTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGradeSubjectGrade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGradeRemarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.lblAccountFullName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlGrades.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chExamSchedDay
        '
        Me.chExamSchedDay.Text = "Exam Date"
        Me.chExamSchedDay.Width = 135
        '
        'chExamSchedDateStart
        '
        Me.chExamSchedDateStart.Text = "Start"
        Me.chExamSchedDateStart.Width = 100
        '
        'chExamSchedDateEnd
        '
        Me.chExamSchedDateEnd.Text = "End"
        Me.chExamSchedDateEnd.Width = 137
        '
        'chExamSchedSubject
        '
        Me.chExamSchedSubject.Text = "Subject"
        Me.chExamSchedSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedSubject.Width = 148
        '
        'chExamSchedSubjectSchedule
        '
        Me.chExamSchedSubjectSchedule.Text = "Schedule"
        Me.chExamSchedSubjectSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedSubjectSchedule.Width = 135
        '
        'chExamSchedSubjectProf
        '
        Me.chExamSchedSubjectProf.Text = "Subject Teacher"
        Me.chExamSchedSubjectProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedSubjectProf.Width = 276
        '
        'chExamSchedSubjectProc
        '
        Me.chExamSchedSubjectProc.Text = "Subject Proctor"
        Me.chExamSchedSubjectProc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedSubjectProc.Width = 285
        '
        'chExamSchedRoomName
        '
        Me.chExamSchedRoomName.Text = "Room"
        Me.chExamSchedRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chExamSchedRoomName.Width = 110
        '
        'btnGradesPrint
        '
        Me.btnGradesPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGradesPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnGradesPrint.FlatAppearance.BorderSize = 0
        Me.btnGradesPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGradesPrint.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGradesPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGradesPrint.Location = New System.Drawing.Point(922, 612)
        Me.btnGradesPrint.Name = "btnGradesPrint"
        Me.btnGradesPrint.Size = New System.Drawing.Size(176, 73)
        Me.btnGradesPrint.TabIndex = 80
        Me.btnGradesPrint.TabStop = False
        Me.btnGradesPrint.Text = "Print"
        Me.btnGradesPrint.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(1126, 612)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(176, 73)
        Me.btnReturn.TabIndex = 79
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'pdGrades
        '
        '
        'pnlGrades
        '
        Me.pnlGrades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGrades.Controls.Add(Me.Label1)
        Me.pnlGrades.Controls.Add(Me.cmbSchoolYear)
        Me.pnlGrades.Controls.Add(Me.lvGrades)
        Me.pnlGrades.Controls.Add(Me.Panel1)
        Me.pnlGrades.Location = New System.Drawing.Point(0, 0)
        Me.pnlGrades.Name = "pnlGrades"
        Me.pnlGrades.Size = New System.Drawing.Size(1355, 606)
        Me.pnlGrades.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(834, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 23)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "SCHOOL YEAR:"
        '
        'cmbSchoolYear
        '
        Me.cmbSchoolYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchoolYear.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchoolYear.FormattingEnabled = True
        Me.cmbSchoolYear.Items.AddRange(New Object() {"School Year 2018 1st sem Prelim", "School Year 2018 1st sem Midterm", "School Year 2018 1st sem Finals", "School Year 2018 2nd sem Prelim"})
        Me.cmbSchoolYear.Location = New System.Drawing.Point(1004, 145)
        Me.cmbSchoolYear.Name = "cmbSchoolYear"
        Me.cmbSchoolYear.Size = New System.Drawing.Size(311, 31)
        Me.cmbSchoolYear.TabIndex = 85
        '
        'lvGrades
        '
        Me.lvGrades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvGrades.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvGrades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvGrades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chGradeStubCode, Me.chGradeDescriptiveTitle, Me.chGradeSubjectGrade, Me.chGradeRemarks})
        Me.lvGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvGrades.Enabled = False
        Me.lvGrades.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGrades.ForeColor = System.Drawing.Color.Black
        Me.lvGrades.FullRowSelect = True
        Me.lvGrades.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvGrades.Location = New System.Drawing.Point(44, 189)
        Me.lvGrades.Margin = New System.Windows.Forms.Padding(5)
        Me.lvGrades.Name = "lvGrades"
        Me.lvGrades.Size = New System.Drawing.Size(1271, 375)
        Me.lvGrades.TabIndex = 80
        Me.lvGrades.UseCompatibleStateImageBehavior = False
        Me.lvGrades.View = System.Windows.Forms.View.Details
        '
        'chGradeStubCode
        '
        Me.chGradeStubCode.Text = "Stubcode"
        Me.chGradeStubCode.Width = 150
        '
        'chGradeDescriptiveTitle
        '
        Me.chGradeDescriptiveTitle.Text = "Descriptive Title"
        Me.chGradeDescriptiveTitle.Width = 350
        '
        'chGradeSubjectGrade
        '
        Me.chGradeSubjectGrade.Text = "Subject Grade"
        Me.chGradeSubjectGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chGradeSubjectGrade.Width = 310
        '
        'chGradeRemarks
        '
        Me.chGradeRemarks.Text = "Remarks"
        Me.chGradeRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chGradeRemarks.Width = 430
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
        Me.Panel1.Size = New System.Drawing.Size(1355, 100)
        Me.Panel1.TabIndex = 87
        '
        'lblAccountType
        '
        Me.lblAccountType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountType.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccountType.Location = New System.Drawing.Point(971, 56)
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
        Me.lblAccountFullName.Location = New System.Drawing.Point(613, 9)
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
        Me.Label2.Text = "View Grades"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.btnGradesPrint)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pnlGrades)
        Me.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Name = "frmGrades"
        Me.Text = "Grades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlGrades.ResumeLayout(False)
        Me.pnlGrades.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chExamSchedDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedDateStart As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedDateEnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedSubject As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedSubjectSchedule As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedSubjectProf As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedSubjectProc As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExamSchedRoomName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGradesPrint As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents pdGrades As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlGrades As System.Windows.Forms.Panel
    Friend WithEvents lvGrades As System.Windows.Forms.ListView
    Friend WithEvents chGradeStubCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents chGradeDescriptiveTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents chGradeSubjectGrade As System.Windows.Forms.ColumnHeader
    Friend WithEvents chGradeRemarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSchoolYear As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAccountType As System.Windows.Forms.Label
    Friend WithEvents lblAccountFullName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
