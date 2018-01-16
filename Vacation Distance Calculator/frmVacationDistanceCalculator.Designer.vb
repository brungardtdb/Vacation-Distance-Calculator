<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacationDistanceCalculator
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblInstructionsDays = New System.Windows.Forms.Label()
        Me.lblInstructionsMPH = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtMPH = New System.Windows.Forms.TextBox()
        Me.btnDays = New System.Windows.Forms.Button()
        Me.btnMPH = New System.Windows.Forms.Button()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblMPH = New System.Windows.Forms.Label()
        Me.btnCalculateDistance = New System.Windows.Forms.Button()
        Me.lstTotalMiles = New System.Windows.Forms.ListBox()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(51, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(345, 27)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Vacation Distance Calculator"
        '
        'lblInstructionsDays
        '
        Me.lblInstructionsDays.AutoSize = True
        Me.lblInstructionsDays.Location = New System.Drawing.Point(10, 55)
        Me.lblInstructionsDays.Name = "lblInstructionsDays"
        Me.lblInstructionsDays.Size = New System.Drawing.Size(427, 20)
        Me.lblInstructionsDays.TabIndex = 1
        Me.lblInstructionsDays.Text = "Enter the number of days you will be traveling"
        '
        'lblInstructionsMPH
        '
        Me.lblInstructionsMPH.AutoSize = True
        Me.lblInstructionsMPH.Location = New System.Drawing.Point(3, 142)
        Me.lblInstructionsMPH.Name = "lblInstructionsMPH"
        Me.lblInstructionsMPH.Size = New System.Drawing.Size(440, 20)
        Me.lblInstructionsMPH.TabIndex = 2
        Me.lblInstructionsMPH.Text = "Enter the speed limit (MPH) you will be traveling"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(185, 93)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 27)
        Me.txtDays.TabIndex = 3
        '
        'txtMPH
        '
        Me.txtMPH.Location = New System.Drawing.Point(185, 181)
        Me.txtMPH.Name = "txtMPH"
        Me.txtMPH.Size = New System.Drawing.Size(100, 27)
        Me.txtMPH.TabIndex = 4
        '
        'btnDays
        '
        Me.btnDays.Location = New System.Drawing.Point(42, 90)
        Me.btnDays.Name = "btnDays"
        Me.btnDays.Size = New System.Drawing.Size(123, 33)
        Me.btnDays.TabIndex = 5
        Me.btnDays.Text = "Enter Days"
        Me.btnDays.UseVisualStyleBackColor = True
        '
        'btnMPH
        '
        Me.btnMPH.Enabled = False
        Me.btnMPH.Location = New System.Drawing.Point(42, 178)
        Me.btnMPH.Name = "btnMPH"
        Me.btnMPH.Size = New System.Drawing.Size(123, 33)
        Me.btnMPH.TabIndex = 6
        Me.btnMPH.Text = "Enter Speed"
        Me.btnMPH.UseVisualStyleBackColor = True
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(331, 96)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(73, 20)
        Me.lblDays.TabIndex = 7
        Me.lblDays.Text = "88 Days"
        Me.lblDays.Visible = False
        '
        'lblMPH
        '
        Me.lblMPH.AutoSize = True
        Me.lblMPH.Location = New System.Drawing.Point(329, 184)
        Me.lblMPH.Name = "lblMPH"
        Me.lblMPH.Size = New System.Drawing.Size(75, 20)
        Me.lblMPH.TabIndex = 8
        Me.lblMPH.Text = "106 MPH"
        Me.lblMPH.Visible = False
        '
        'btnCalculateDistance
        '
        Me.btnCalculateDistance.Enabled = False
        Me.btnCalculateDistance.Location = New System.Drawing.Point(130, 232)
        Me.btnCalculateDistance.Name = "btnCalculateDistance"
        Me.btnCalculateDistance.Size = New System.Drawing.Size(184, 32)
        Me.btnCalculateDistance.TabIndex = 9
        Me.btnCalculateDistance.Text = "Calculate Distance"
        Me.btnCalculateDistance.UseVisualStyleBackColor = True
        '
        'lstTotalMiles
        '
        Me.lstTotalMiles.FormattingEnabled = True
        Me.lstTotalMiles.ItemHeight = 20
        Me.lstTotalMiles.Location = New System.Drawing.Point(163, 282)
        Me.lstTotalMiles.Name = "lstTotalMiles"
        Me.lstTotalMiles.Size = New System.Drawing.Size(120, 164)
        Me.lstTotalMiles.TabIndex = 10
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.AutoSize = True
        Me.lblTotalMiles.Location = New System.Drawing.Point(136, 477)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(114, 20)
        Me.lblTotalMiles.TabIndex = 11
        Me.lblTotalMiles.Text = "Total Miles:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(446, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'frmVacationDistanceCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(446, 517)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.lstTotalMiles)
        Me.Controls.Add(Me.btnCalculateDistance)
        Me.Controls.Add(Me.lblMPH)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.btnMPH)
        Me.Controls.Add(Me.btnDays)
        Me.Controls.Add(Me.txtMPH)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.lblInstructionsMPH)
        Me.Controls.Add(Me.lblInstructionsDays)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmVacationDistanceCalculator"
        Me.Text = "Vacation Distance Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblInstructionsDays As Label
    Friend WithEvents lblInstructionsMPH As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtMPH As TextBox
    Friend WithEvents btnDays As Button
    Friend WithEvents btnMPH As Button
    Friend WithEvents lblDays As Label
    Friend WithEvents lblMPH As Label
    Friend WithEvents btnCalculateDistance As Button
    Friend WithEvents lstTotalMiles As ListBox
    Friend WithEvents lblTotalMiles As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
