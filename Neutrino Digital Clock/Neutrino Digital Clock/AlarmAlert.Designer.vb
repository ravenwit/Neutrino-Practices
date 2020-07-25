<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmAlert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlarmAlert))
        Me.lblAlarmCount = New System.Windows.Forms.Label()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAlarmText = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowAlarmInterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAlarmCount
        '
        Me.lblAlarmCount.BackColor = System.Drawing.Color.Transparent
        Me.lblAlarmCount.Font = New System.Drawing.Font("Consolas", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmCount.ForeColor = System.Drawing.Color.Black
        Me.lblAlarmCount.Location = New System.Drawing.Point(196, 52)
        Me.lblAlarmCount.Name = "lblAlarmCount"
        Me.lblAlarmCount.Size = New System.Drawing.Size(190, 36)
        Me.lblAlarmCount.TabIndex = 0
        Me.lblAlarmCount.Text = "1234567890"
        Me.lblAlarmCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOff
        '
        Me.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOff.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.ForeColor = System.Drawing.Color.Red
        Me.btnOff.Image = CType(resources.GetObject("btnOff.Image"), System.Drawing.Image)
        Me.btnOff.Location = New System.Drawing.Point(268, 350)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(47, 47)
        Me.btnOff.TabIndex = 1
        Me.btnOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnOff, "Alarm Off")
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lblAlarmText
        '
        Me.lblAlarmText.BackColor = System.Drawing.Color.Transparent
        Me.lblAlarmText.Font = New System.Drawing.Font("Courier New", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmText.ForeColor = System.Drawing.Color.MistyRose
        Me.lblAlarmText.Location = New System.Drawing.Point(12, 101)
        Me.lblAlarmText.Name = "lblAlarmText"
        Me.lblAlarmText.Size = New System.Drawing.Size(558, 229)
        Me.lblAlarmText.TabIndex = 3
        Me.lblAlarmText.Text = "1234567890"
        Me.lblAlarmText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClose
        '
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Image = CType(resources.GetObject("lblClose.Image"), System.Drawing.Image)
        Me.lblClose.Location = New System.Drawing.Point(544, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(36, 36)
        Me.lblClose.TabIndex = 4
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblClose, "Close")
        '
        'lblMinimize
        '
        Me.lblMinimize.BackColor = System.Drawing.Color.Transparent
        Me.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimize.Image = CType(resources.GetObject("lblMinimize.Image"), System.Drawing.Image)
        Me.lblMinimize.Location = New System.Drawing.Point(500, 0)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(38, 36)
        Me.lblMinimize.TabIndex = 5
        Me.lblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblMinimize, "Minimize to system tray")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAlarmInterfaceToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(188, 26)
        '
        'ShowAlarmInterfaceToolStripMenuItem
        '
        Me.ShowAlarmInterfaceToolStripMenuItem.Name = "ShowAlarmInterfaceToolStripMenuItem"
        Me.ShowAlarmInterfaceToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ShowAlarmInterfaceToolStripMenuItem.Text = "Show Alarm Interface"
        '
        'AlarmAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 409)
        Me.Controls.Add(Me.lblMinimize)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblAlarmText)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.lblAlarmCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "AlarmAlert"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAlarmCount As System.Windows.Forms.Label
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblAlarmText As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblMinimize As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowAlarmInterfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
