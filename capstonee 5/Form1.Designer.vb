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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstFileRead = New System.Windows.Forms.ListBox()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblTotalInvest = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.groupAdd = New System.Windows.Forms.GroupBox()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblAmountNum = New System.Windows.Forms.Label()
        Me.lblPercentNum = New System.Windows.Forms.Label()
        Me.menuStrip.SuspendLayout()
        Me.groupAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnExit.Location = New System.Drawing.Point(492, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.Color.LavenderBlush
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(609, 30)
        Me.menuStrip.TabIndex = 1
        Me.menuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveClearToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveClearToolStripMenuItem
        '
        Me.SaveClearToolStripMenuItem.Name = "SaveClearToolStripMenuItem"
        Me.SaveClearToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveClearToolStripMenuItem.Text = "Save + Clear"
        '
        'lstFileRead
        '
        Me.lstFileRead.BackColor = System.Drawing.Color.LavenderBlush
        Me.lstFileRead.FormattingEnabled = True
        Me.lstFileRead.ItemHeight = 16
        Me.lstFileRead.Location = New System.Drawing.Point(0, 44)
        Me.lstFileRead.Name = "lstFileRead"
        Me.lstFileRead.Size = New System.Drawing.Size(173, 260)
        Me.lstFileRead.TabIndex = 3
        Me.lstFileRead.Visible = False
        '
        'btnGetInfo
        '
        Me.btnGetInfo.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnGetInfo.Location = New System.Drawing.Point(24, 269)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnGetInfo.TabIndex = 4
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = False
        '
        'lstNames
        '
        Me.lstNames.BackColor = System.Drawing.Color.LavenderBlush
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 16
        Me.lstNames.Location = New System.Drawing.Point(24, 54)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(190, 180)
        Me.lstNames.TabIndex = 5
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(249, 82)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(55, 16)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Amount:"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(249, 133)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(56, 16)
        Me.lblPercent.TabIndex = 7
        Me.lblPercent.Text = "Percent:"
        '
        'lblTotalInvest
        '
        Me.lblTotalInvest.AutoSize = True
        Me.lblTotalInvest.Location = New System.Drawing.Point(249, 182)
        Me.lblTotalInvest.Name = "lblTotalInvest"
        Me.lblTotalInvest.Size = New System.Drawing.Size(122, 16)
        Me.lblTotalInvest.TabIndex = 8
        Me.lblTotalInvest.Text = "Total # of Investors:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnAdd.Location = New System.Drawing.Point(127, 269)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(139, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add An Investor"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnRemove.Location = New System.Drawing.Point(288, 269)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(175, 23)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove An Investor"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(390, 182)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(16, 16)
        Me.lblNum.TabIndex = 11
        Me.lblNum.Text = "   "
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtName.Location = New System.Drawing.Point(62, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 12
        '
        'txtPercent
        '
        Me.txtPercent.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtPercent.Location = New System.Drawing.Point(62, 100)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(100, 22)
        Me.txtPercent.TabIndex = 13
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtAmount.Location = New System.Drawing.Point(62, 62)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 22)
        Me.txtAmount.TabIndex = 14
        '
        'groupAdd
        '
        Me.groupAdd.Controls.Add(Me.lblP)
        Me.groupAdd.Controls.Add(Me.lblA)
        Me.groupAdd.Controls.Add(Me.lblN)
        Me.groupAdd.Controls.Add(Me.txtName)
        Me.groupAdd.Controls.Add(Me.txtAmount)
        Me.groupAdd.Controls.Add(Me.txtPercent)
        Me.groupAdd.Location = New System.Drawing.Point(421, 71)
        Me.groupAdd.Name = "groupAdd"
        Me.groupAdd.Size = New System.Drawing.Size(168, 142)
        Me.groupAdd.TabIndex = 16
        Me.groupAdd.TabStop = False
        Me.groupAdd.Text = "Add An Investor:"
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(22, 100)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(22, 16)
        Me.lblP.TabIndex = 17
        Me.lblP.Text = "%:"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(1, 65)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(55, 16)
        Me.lblA.TabIndex = 16
        Me.lblA.Text = "Amount:"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(9, 24)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(47, 16)
        Me.lblN.TabIndex = 15
        Me.lblN.Text = "Name:"
        '
        'lblAmountNum
        '
        Me.lblAmountNum.AutoSize = True
        Me.lblAmountNum.Location = New System.Drawing.Point(334, 82)
        Me.lblAmountNum.Name = "lblAmountNum"
        Me.lblAmountNum.Size = New System.Drawing.Size(13, 16)
        Me.lblAmountNum.TabIndex = 17
        Me.lblAmountNum.Text = "  "
        '
        'lblPercentNum
        '
        Me.lblPercentNum.AutoSize = True
        Me.lblPercentNum.Location = New System.Drawing.Point(334, 136)
        Me.lblPercentNum.Name = "lblPercentNum"
        Me.lblPercentNum.Size = New System.Drawing.Size(19, 16)
        Me.lblPercentNum.TabIndex = 18
        Me.lblPercentNum.Text = "    "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(609, 306)
        Me.Controls.Add(Me.lblPercentNum)
        Me.Controls.Add(Me.lblAmountNum)
        Me.Controls.Add(Me.groupAdd)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTotalInvest)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.lstFileRead)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmMain"
        Me.Text = "Hell & Taxes Inc."
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.groupAdd.ResumeLayout(False)
        Me.groupAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstFileRead As ListBox
    Friend WithEvents btnGetInfo As Button
    Friend WithEvents lstNames As ListBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblTotalInvest As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblNum As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPercent As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents groupAdd As GroupBox
    Friend WithEvents lblP As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblN As Label
    Friend WithEvents SaveClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAmountNum As Label
    Friend WithEvents lblPercentNum As Label
End Class
