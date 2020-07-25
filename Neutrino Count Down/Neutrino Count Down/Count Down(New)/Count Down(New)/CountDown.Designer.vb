<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountDown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountDown))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblYearp = New System.Windows.Forms.Label()
        Me.lblMonthp = New System.Windows.Forms.Label()
        Me.lblDayp = New System.Windows.Forms.Label()
        Me.lbltDayp = New System.Windows.Forms.Label()
        Me.lbltDay = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgeCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 47)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("MATRIX", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Cyan
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(2, 155)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(70, 34)
        Me.lblYear.TabIndex = 21
        Me.lblYear.Text = "Day"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Font = New System.Drawing.Font("MATRIX", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.Cyan
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(86, 155)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(67, 34)
        Me.lblMonth.TabIndex = 20
        Me.lblMonth.Text = "Day"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("MATRIX", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.Cyan
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(167, 155)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(66, 34)
        Me.lblDay.TabIndex = 19
        Me.lblDay.Text = "Day"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYearp
        '
        Me.lblYearp.AutoSize = True
        Me.lblYearp.BackColor = System.Drawing.Color.Transparent
        Me.lblYearp.Font = New System.Drawing.Font("Harrington", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblYearp.ForeColor = System.Drawing.Color.Pink
        Me.lblYearp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearp.Location = New System.Drawing.Point(18, 139)
        Me.lblYearp.Name = "lblYearp"
        Me.lblYearp.Size = New System.Drawing.Size(37, 15)
        Me.lblYearp.TabIndex = 18
        Me.lblYearp.Text = "Year"
        Me.lblYearp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthp
        '
        Me.lblMonthp.AutoSize = True
        Me.lblMonthp.BackColor = System.Drawing.Color.Transparent
        Me.lblMonthp.Font = New System.Drawing.Font("Harrington", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblMonthp.ForeColor = System.Drawing.Color.Pink
        Me.lblMonthp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthp.Location = New System.Drawing.Point(96, 140)
        Me.lblMonthp.Name = "lblMonthp"
        Me.lblMonthp.Size = New System.Drawing.Size(47, 15)
        Me.lblMonthp.TabIndex = 17
        Me.lblMonthp.Text = "Month"
        Me.lblMonthp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDayp
        '
        Me.lblDayp.AutoSize = True
        Me.lblDayp.BackColor = System.Drawing.Color.Transparent
        Me.lblDayp.Font = New System.Drawing.Font("Harrington", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblDayp.ForeColor = System.Drawing.Color.Pink
        Me.lblDayp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayp.Location = New System.Drawing.Point(184, 139)
        Me.lblDayp.Name = "lblDayp"
        Me.lblDayp.Size = New System.Drawing.Size(33, 15)
        Me.lblDayp.TabIndex = 16
        Me.lblDayp.Text = "Day"
        Me.lblDayp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltDayp
        '
        Me.lbltDayp.BackColor = System.Drawing.Color.Transparent
        Me.lbltDayp.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbltDayp.ForeColor = System.Drawing.Color.Pink
        Me.lbltDayp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbltDayp.Location = New System.Drawing.Point(57, 56)
        Me.lbltDayp.Name = "lbltDayp"
        Me.lbltDayp.Size = New System.Drawing.Size(121, 25)
        Me.lbltDayp.TabIndex = 15
        Me.lbltDayp.Text = "Total Days"
        Me.lbltDayp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltDay
        '
        Me.lbltDay.BackColor = System.Drawing.Color.Transparent
        Me.lbltDay.Font = New System.Drawing.Font("MATRIX", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltDay.ForeColor = System.Drawing.Color.Cyan
        Me.lbltDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbltDay.Location = New System.Drawing.Point(12, 81)
        Me.lbltDay.Name = "lbltDay"
        Me.lbltDay.Size = New System.Drawing.Size(209, 40)
        Me.lbltDay.TabIndex = 14
        Me.lbltDay.Text = "Count Down 2012"
        Me.lbltDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHour
        '
        Me.lblHour.BackColor = System.Drawing.Color.Transparent
        Me.lblHour.Font = New System.Drawing.Font("MATRIX", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.ForeColor = System.Drawing.Color.Cyan
        Me.lblHour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHour.Location = New System.Drawing.Point(28, 189)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(66, 34)
        Me.lblHour.TabIndex = 27
        Me.lblHour.Text = "Day"
        Me.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinute
        '
        Me.lblMinute.BackColor = System.Drawing.Color.Transparent
        Me.lblMinute.Font = New System.Drawing.Font("MATRIX", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.ForeColor = System.Drawing.Color.Cyan
        Me.lblMinute.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinute.Location = New System.Drawing.Point(93, 189)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(67, 34)
        Me.lblMinute.TabIndex = 26
        Me.lblMinute.Text = "Day"
        Me.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecond
        '
        Me.lblSecond.BackColor = System.Drawing.Color.Transparent
        Me.lblSecond.Font = New System.Drawing.Font("MATRIX", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.ForeColor = System.Drawing.Color.Cyan
        Me.lblSecond.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecond.Location = New System.Drawing.Point(157, 189)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(65, 34)
        Me.lblSecond.TabIndex = 25
        Me.lblSecond.Text = "Day"
        Me.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Options"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.SetDateToolStripMenuItem, Me.ExitToolStripMenuItem, Me.AgeCalculatorToolStripMenuItem, Me.MonthViewerToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(227, 136)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SetDateToolStripMenuItem
        '
        Me.SetDateToolStripMenuItem.Name = "SetDateToolStripMenuItem"
        Me.SetDateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.SetDateToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.SetDateToolStripMenuItem.Text = "Set Date"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ExitToolStripMenuItem.Text = "Date Calculator"
        '
        'AgeCalculatorToolStripMenuItem
        '
        Me.AgeCalculatorToolStripMenuItem.Name = "AgeCalculatorToolStripMenuItem"
        Me.AgeCalculatorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.AgeCalculatorToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AgeCalculatorToolStripMenuItem.Text = "Age Calculator"
        '
        'MonthViewerToolStripMenuItem
        '
        Me.MonthViewerToolStripMenuItem.Name = "MonthViewerToolStripMenuItem"
        Me.MonthViewerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MonthViewerToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.MonthViewerToolStripMenuItem.Text = "Month Calendar"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(226, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Count Down"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(227, 160)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.AutoToolTip = True
        Me.RestoreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.RestoreToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        Me.RestoreToolStripMenuItem.ToolTipText = "Restore Count Down Window"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(226, 26)
        Me.ToolStripMenuItem1.Text = "Options"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(226, 26)
        Me.ToolStripMenuItem3.Text = "Date Calculator"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(226, 26)
        Me.ToolStripMenuItem4.Text = "Age Calculator"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(226, 26)
        Me.ToolStripMenuItem5.Text = "Month Calendar"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(226, 26)
        Me.ToolStripMenuItem6.Text = "Exit"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'CountDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(234, 262)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMinute)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblYearp)
        Me.Controls.Add(Me.lblMonthp)
        Me.Controls.Add(Me.lblDayp)
        Me.Controls.Add(Me.lbltDay)
        Me.Controls.Add(Me.lbltDayp)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CountDown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Count Down"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblYearp As System.Windows.Forms.Label
    Friend WithEvents lblMonthp As System.Windows.Forms.Label
    Friend WithEvents lblDayp As System.Windows.Forms.Label
    Friend WithEvents lbltDayp As System.Windows.Forms.Label
    Friend WithEvents lbltDay As System.Windows.Forms.Label
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents lblMinute As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgeCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
