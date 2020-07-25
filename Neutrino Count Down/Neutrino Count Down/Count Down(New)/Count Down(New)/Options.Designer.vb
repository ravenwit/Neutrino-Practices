<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkVoice = New System.Windows.Forms.CheckBox()
        Me.chkbeep = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMiniSys = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dcount = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTDayResult = New System.Windows.Forms.Label()
        Me.lblDifResult = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.d_curr = New System.Windows.Forms.DateTimePicker()
        Me.d_des = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.dbDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(315, 262)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(307, 236)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackgroundImage = CType(resources.GetObject("GroupBox7.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox7.Controls.Add(Me.chkVoice)
        Me.GroupBox7.Controls.Add(Me.chkbeep)
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox7.Location = New System.Drawing.Point(9, 189)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(290, 44)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Sound"
        '
        'chkVoice
        '
        Me.chkVoice.AutoSize = True
        Me.chkVoice.BackColor = System.Drawing.Color.Black
        Me.chkVoice.ForeColor = System.Drawing.SystemColors.Info
        Me.chkVoice.Location = New System.Drawing.Point(145, 22)
        Me.chkVoice.Name = "chkVoice"
        Me.chkVoice.Size = New System.Drawing.Size(80, 17)
        Me.chkVoice.TabIndex = 1
        Me.chkVoice.Text = "Mute Voice"
        Me.chkVoice.UseVisualStyleBackColor = False
        '
        'chkbeep
        '
        Me.chkbeep.AutoSize = True
        Me.chkbeep.BackColor = System.Drawing.Color.Black
        Me.chkbeep.ForeColor = System.Drawing.SystemColors.Info
        Me.chkbeep.Location = New System.Drawing.Point(6, 19)
        Me.chkbeep.Name = "chkbeep"
        Me.chkbeep.Size = New System.Drawing.Size(122, 17)
        Me.chkbeep.TabIndex = 0
        Me.chkbeep.Text = "Turn off beep sound"
        Me.chkbeep.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.chkMiniSys)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Location = New System.Drawing.Point(9, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 42)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Taskbar Visibility"
        '
        'chkMiniSys
        '
        Me.chkMiniSys.AutoSize = True
        Me.chkMiniSys.BackColor = System.Drawing.Color.Black
        Me.chkMiniSys.ForeColor = System.Drawing.SystemColors.Info
        Me.chkMiniSys.Location = New System.Drawing.Point(145, 19)
        Me.chkMiniSys.Name = "chkMiniSys"
        Me.chkMiniSys.Size = New System.Drawing.Size(139, 17)
        Me.chkMiniSys.TabIndex = 1
        Me.chkMiniSys.Text = "Minimize to System Tray"
        Me.chkMiniSys.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Black
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Hide"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dcount)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date to Count Down"
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button4.Location = New System.Drawing.Point(100, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Set Date"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button1.Location = New System.Drawing.Point(100, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reset Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose the date from the Date Picker"
        '
        'dcount
        '
        Me.dcount.Location = New System.Drawing.Point(56, 41)
        Me.dcount.Name = "dcount"
        Me.dcount.Size = New System.Drawing.Size(182, 20)
        Me.dcount.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.Info
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(307, 236)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Date Calculator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.d_curr)
        Me.GroupBox3.Controls.Add(Me.d_des)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 222)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Difference between two date"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(105, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.lblTDayResult)
        Me.GroupBox4.Controls.Add(Me.lblDifResult)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox4.Location = New System.Drawing.Point(9, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(276, 111)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Difference"
        '
        'lblTDayResult
        '
        Me.lblTDayResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDayResult.ForeColor = System.Drawing.Color.LightCyan
        Me.lblTDayResult.Location = New System.Drawing.Point(10, 40)
        Me.lblTDayResult.Name = "lblTDayResult"
        Me.lblTDayResult.Size = New System.Drawing.Size(257, 30)
        Me.lblTDayResult.TabIndex = 3
        Me.lblTDayResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDifResult
        '
        Me.lblDifResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifResult.ForeColor = System.Drawing.Color.LightCyan
        Me.lblDifResult.Location = New System.Drawing.Point(10, 70)
        Me.lblDifResult.Name = "lblDifResult"
        Me.lblDifResult.Size = New System.Drawing.Size(257, 38)
        Me.lblDifResult.TabIndex = 2
        Me.lblDifResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Difference (Days)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_curr
        '
        Me.d_curr.Location = New System.Drawing.Point(85, 46)
        Me.d_curr.Name = "d_curr"
        Me.d_curr.Size = New System.Drawing.Size(200, 20)
        Me.d_curr.TabIndex = 3
        '
        'd_des
        '
        Me.d_des.Location = New System.Drawing.Point(85, 19)
        Me.d_des.Name = "d_des"
        Me.d_des.Size = New System.Drawing.Size(200, 20)
        Me.d_des.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Second Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Date       :"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.Info
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(307, 236)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Age Calculator"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.dbDate)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox5.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(291, 175)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Age Calculator"
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(108, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImage = CType(resources.GetObject("GroupBox6.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox6.Controls.Add(Me.lblResult)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox6.Location = New System.Drawing.Point(6, 78)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(279, 54)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Your Age"
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.LightCyan
        Me.lblResult.Location = New System.Drawing.Point(6, 16)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(267, 35)
        Me.lblResult.TabIndex = 0
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dbDate
        '
        Me.dbDate.Location = New System.Drawing.Point(45, 43)
        Me.dbDate.Name = "dbDate"
        Me.dbDate.Size = New System.Drawing.Size(200, 20)
        Me.dbDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Enter your Birth Date"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Black
        Me.TabPage4.Controls.Add(Me.MonthCalendar1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(307, 236)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Month Calendar"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Saturday
        Me.MonthCalendar1.Location = New System.Drawing.Point(37, 34)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowWeekNumbers = True
        Me.MonthCalendar1.TabIndex = 0
        Me.MonthCalendar1.TodayDate = New Date(2011, 12, 22, 0, 0, 0, 0)
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(315, 262)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dcount As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents dbDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDifResult As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents d_curr As System.Windows.Forms.DateTimePicker
    Friend WithEvents d_des As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTDayResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chkbeep As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents chkVoice As System.Windows.Forms.CheckBox
    Friend WithEvents chkMiniSys As System.Windows.Forms.CheckBox
End Class
