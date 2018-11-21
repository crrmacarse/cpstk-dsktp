<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassSched
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
        Me.btnClassSchedPrint = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pdClassSched = New System.Drawing.Printing.PrintDocument()
        Me.pnlClassSched = New System.Windows.Forms.Panel()
        Me.lvClassSched = New System.Windows.Forms.ListView()
        Me.chClassSchedStubcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chClassSchedDescriptTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chClassSchedTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chClassSchedDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chClassSchedRoom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chClassSchedTeacher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAccountFullName = New System.Windows.Forms.Label()
        Me.pnlClassSched.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClassSchedPrint
        '
        Me.btnClassSchedPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClassSchedPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClassSchedPrint.FlatAppearance.BorderSize = 0
        Me.btnClassSchedPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClassSchedPrint.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassSchedPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClassSchedPrint.Location = New System.Drawing.Point(922, 612)
        Me.btnClassSchedPrint.Name = "btnClassSchedPrint"
        Me.btnClassSchedPrint.Size = New System.Drawing.Size(176, 73)
        Me.btnClassSchedPrint.TabIndex = 74
        Me.btnClassSchedPrint.TabStop = False
        Me.btnClassSchedPrint.Text = "Print"
        Me.btnClassSchedPrint.UseVisualStyleBackColor = False
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
        Me.btnReturn.TabIndex = 73
        Me.btnReturn.TabStop = False
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'pdClassSched
        '
        '
        'pnlClassSched
        '
        Me.pnlClassSched.Controls.Add(Me.lvClassSched)
        Me.pnlClassSched.Controls.Add(Me.Panel1)
        Me.pnlClassSched.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlClassSched.Location = New System.Drawing.Point(0, 0)
        Me.pnlClassSched.Name = "pnlClassSched"
        Me.pnlClassSched.Size = New System.Drawing.Size(1354, 597)
        Me.pnlClassSched.TabIndex = 88
        '
        'lvClassSched
        '
        Me.lvClassSched.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvClassSched.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvClassSched.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvClassSched.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chClassSchedStubcode, Me.chClassSchedDescriptTitle, Me.chClassSchedTime, Me.chClassSchedDay, Me.chClassSchedRoom, Me.chClassSchedTeacher})
        Me.lvClassSched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvClassSched.Enabled = False
        Me.lvClassSched.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvClassSched.FullRowSelect = True
        Me.lvClassSched.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvClassSched.Location = New System.Drawing.Point(56, 164)
        Me.lvClassSched.Name = "lvClassSched"
        Me.lvClassSched.Size = New System.Drawing.Size(1246, 397)
        Me.lvClassSched.TabIndex = 87
        Me.lvClassSched.UseCompatibleStateImageBehavior = False
        Me.lvClassSched.View = System.Windows.Forms.View.Details
        '
        'chClassSchedStubcode
        '
        Me.chClassSchedStubcode.Text = "Stubcode"
        Me.chClassSchedStubcode.Width = 150
        '
        'chClassSchedDescriptTitle
        '
        Me.chClassSchedDescriptTitle.Text = "Subject Code"
        Me.chClassSchedDescriptTitle.Width = 250
        '
        'chClassSchedTime
        '
        Me.chClassSchedTime.Text = "Time"
        Me.chClassSchedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chClassSchedTime.Width = 190
        '
        'chClassSchedDay
        '
        Me.chClassSchedDay.Text = "Day"
        Me.chClassSchedDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chClassSchedDay.Width = 155
        '
        'chClassSchedRoom
        '
        Me.chClassSchedRoom.Text = "Room"
        Me.chClassSchedRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chClassSchedRoom.Width = 180
        '
        'chClassSchedTeacher
        '
        Me.chClassSchedTeacher.Text = "Subject Teacher"
        Me.chClassSchedTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chClassSchedTeacher.Width = 319
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAccountType)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblAccountFullName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 100)
        Me.Panel1.TabIndex = 86
        '
        'lblAccountType
        '
        Me.lblAccountType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountType.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccountType.Location = New System.Drawing.Point(970, 52)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(372, 16)
        Me.lblAccountType.TabIndex = 74
        Me.lblAccountType.Text = "BS Information Technology"
        Me.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label2.Text = "View Class Schedule"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAccountFullName
        '
        Me.lblAccountFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblAccountFullName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountFullName.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccountFullName.Location = New System.Drawing.Point(612, 9)
        Me.lblAccountFullName.Name = "lblAccountFullName"
        Me.lblAccountFullName.Size = New System.Drawing.Size(730, 47)
        Me.lblAccountFullName.TabIndex = 71
        Me.lblAccountFullName.Text = "Occena, Mikoy"
        Me.lblAccountFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmClassSched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.btnClassSchedPrint)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pnlClassSched)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClassSched"
        Me.Text = "frmClassSched"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlClassSched.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClassSchedPrint As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents pdClassSched As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlClassSched As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAccountType As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAccountFullName As System.Windows.Forms.Label
    Friend WithEvents lvClassSched As System.Windows.Forms.ListView
    Friend WithEvents chClassSchedStubcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents chClassSchedDescriptTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents chClassSchedTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents chClassSchedDay As System.Windows.Forms.ColumnHeader
    Friend WithEvents chClassSchedRoom As System.Windows.Forms.ColumnHeader
    Friend WithEvents chClassSchedTeacher As System.Windows.Forms.ColumnHeader
End Class
