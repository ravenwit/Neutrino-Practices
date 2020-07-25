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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmbDateFormat = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTimeFormat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkTop = New System.Windows.Forms.CheckBox()
        Me.chkMiniSysTray = New System.Windows.Forms.CheckBox()
        Me.chkTaskbar = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkday = New System.Windows.Forms.CheckBox()
        Me.chkAlertHour = New System.Windows.Forms.CheckBox()
        Me.chkBeep = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.nmuMaxSelection = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTodayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkShowWeek = New System.Windows.Forms.CheckBox()
        Me.chkTodayCircle = New System.Windows.Forms.CheckBox()
        Me.chkShowToday = New System.Windows.Forms.CheckBox()
        Me.cmbFirstDayWeek = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nmuDimensionHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nmuDimensionWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.nmuMaxSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmuDimensionHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmuDimensionWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(378, 304)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(370, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmbDateFormat)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.cmbTimeFormat)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(354, 79)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Time and Date Format"
        '
        'cmbDateFormat
        '
        Me.cmbDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDateFormat.FormattingEnabled = True
        Me.cmbDateFormat.Items.AddRange(New Object() {"General", "Long Date", "Short Date"})
        Me.cmbDateFormat.Location = New System.Drawing.Point(125, 48)
        Me.cmbDateFormat.Name = "cmbDateFormat"
        Me.cmbDateFormat.Size = New System.Drawing.Size(190, 21)
        Me.cmbDateFormat.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Date Format   :"
        '
        'cmbTimeFormat
        '
        Me.cmbTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeFormat.FormattingEnabled = True
        Me.cmbTimeFormat.Items.AddRange(New Object() {"General", "Long Time ", "Short Time"})
        Me.cmbTimeFormat.Location = New System.Drawing.Point(125, 20)
        Me.cmbTimeFormat.Name = "cmbTimeFormat"
        Me.cmbTimeFormat.Size = New System.Drawing.Size(190, 21)
        Me.cmbTimeFormat.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Time Format   :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkTop)
        Me.GroupBox6.Controls.Add(Me.chkMiniSysTray)
        Me.GroupBox6.Controls.Add(Me.chkTaskbar)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 188)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(354, 76)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Taskbar Visibility"
        '
        'chkTop
        '
        Me.chkTop.AutoSize = True
        Me.chkTop.Location = New System.Drawing.Point(11, 19)
        Me.chkTop.Name = "chkTop"
        Me.chkTop.Size = New System.Drawing.Size(92, 17)
        Me.chkTop.TabIndex = 2
        Me.chkTop.Text = "Always on top"
        Me.chkTop.UseVisualStyleBackColor = True
        '
        'chkMiniSysTray
        '
        Me.chkMiniSysTray.AutoSize = True
        Me.chkMiniSysTray.Location = New System.Drawing.Point(11, 48)
        Me.chkMiniSysTray.Name = "chkMiniSysTray"
        Me.chkMiniSysTray.Size = New System.Drawing.Size(133, 17)
        Me.chkMiniSysTray.TabIndex = 1
        Me.chkMiniSysTray.Text = "Minimize to system tray"
        Me.chkMiniSysTray.UseVisualStyleBackColor = True
        '
        'chkTaskbar
        '
        Me.chkTaskbar.AutoSize = True
        Me.chkTaskbar.Location = New System.Drawing.Point(205, 19)
        Me.chkTaskbar.Name = "chkTaskbar"
        Me.chkTaskbar.Size = New System.Drawing.Size(110, 17)
        Me.chkTaskbar.TabIndex = 0
        Me.chkTaskbar.Text = "Show on Taskbar"
        Me.chkTaskbar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkday)
        Me.GroupBox5.Controls.Add(Me.chkAlertHour)
        Me.GroupBox5.Controls.Add(Me.chkBeep)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 98)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(354, 84)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Beep Sound"
        '
        'chkday
        '
        Me.chkday.AutoSize = True
        Me.chkday.Location = New System.Drawing.Point(205, 52)
        Me.chkday.Name = "chkday"
        Me.chkday.Size = New System.Drawing.Size(121, 17)
        Me.chkday.TabIndex = 2
        Me.chkday.Text = "Turn off alert for day"
        Me.chkday.UseVisualStyleBackColor = True
        '
        'chkAlertHour
        '
        Me.chkAlertHour.AutoSize = True
        Me.chkAlertHour.Location = New System.Drawing.Point(11, 52)
        Me.chkAlertHour.Name = "chkAlertHour"
        Me.chkAlertHour.Size = New System.Drawing.Size(125, 17)
        Me.chkAlertHour.TabIndex = 1
        Me.chkAlertHour.Text = "Turn off alert for hour"
        Me.chkAlertHour.UseVisualStyleBackColor = True
        '
        'chkBeep
        '
        Me.chkBeep.AutoSize = True
        Me.chkBeep.Location = New System.Drawing.Point(11, 21)
        Me.chkBeep.Name = "chkBeep"
        Me.chkBeep.Size = New System.Drawing.Size(168, 17)
        Me.chkBeep.TabIndex = 0
        Me.chkBeep.Text = "Turn off beep sound (Second)"
        Me.chkBeep.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.nmuDimensionHeight)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.nmuDimensionWidth)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(370, 278)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Calendar Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.nmuMaxSelection)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.dtpTodayDate)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.chkShowWeek)
        Me.GroupBox7.Controls.Add(Me.chkTodayCircle)
        Me.GroupBox7.Controls.Add(Me.chkShowToday)
        Me.GroupBox7.Controls.Add(Me.cmbFirstDayWeek)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 50)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(356, 220)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Behavior"
        '
        'nmuMaxSelection
        '
        Me.nmuMaxSelection.AutoSize = True
        Me.nmuMaxSelection.Location = New System.Drawing.Point(149, 89)
        Me.nmuMaxSelection.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nmuMaxSelection.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmuMaxSelection.Name = "nmuMaxSelection"
        Me.nmuMaxSelection.Size = New System.Drawing.Size(121, 20)
        Me.nmuMaxSelection.TabIndex = 5
        Me.nmuMaxSelection.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Maximum Selection Count :"
        '
        'dtpTodayDate
        '
        Me.dtpTodayDate.Location = New System.Drawing.Point(149, 28)
        Me.dtpTodayDate.Name = "dtpTodayDate"
        Me.dtpTodayDate.ShowUpDown = True
        Me.dtpTodayDate.Size = New System.Drawing.Size(187, 20)
        Me.dtpTodayDate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Today Date :"
        '
        'chkShowWeek
        '
        Me.chkShowWeek.AutoSize = True
        Me.chkShowWeek.Location = New System.Drawing.Point(13, 167)
        Me.chkShowWeek.Name = "chkShowWeek"
        Me.chkShowWeek.Size = New System.Drawing.Size(125, 17)
        Me.chkShowWeek.TabIndex = 4
        Me.chkShowWeek.Text = "Show Week Number"
        Me.chkShowWeek.UseVisualStyleBackColor = True
        '
        'chkTodayCircle
        '
        Me.chkTodayCircle.AutoSize = True
        Me.chkTodayCircle.Location = New System.Drawing.Point(13, 144)
        Me.chkTodayCircle.Name = "chkTodayCircle"
        Me.chkTodayCircle.Size = New System.Drawing.Size(115, 17)
        Me.chkTodayCircle.TabIndex = 3
        Me.chkTodayCircle.Text = "Show Today Circle"
        Me.chkTodayCircle.UseVisualStyleBackColor = True
        '
        'chkShowToday
        '
        Me.chkShowToday.AutoSize = True
        Me.chkShowToday.Location = New System.Drawing.Point(13, 121)
        Me.chkShowToday.Name = "chkShowToday"
        Me.chkShowToday.Size = New System.Drawing.Size(86, 17)
        Me.chkShowToday.TabIndex = 2
        Me.chkShowToday.Text = "Show Today"
        Me.chkShowToday.UseVisualStyleBackColor = True
        '
        'cmbFirstDayWeek
        '
        Me.cmbFirstDayWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFirstDayWeek.FormattingEnabled = True
        Me.cmbFirstDayWeek.Items.AddRange(New Object() {"Default", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cmbFirstDayWeek.Location = New System.Drawing.Point(149, 57)
        Me.cmbFirstDayWeek.Name = "cmbFirstDayWeek"
        Me.cmbFirstDayWeek.Size = New System.Drawing.Size(121, 21)
        Me.cmbFirstDayWeek.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Day of Week :"
        '
        'nmuDimensionHeight
        '
        Me.nmuDimensionHeight.Location = New System.Drawing.Point(206, 12)
        Me.nmuDimensionHeight.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nmuDimensionHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmuDimensionHeight.Name = "nmuDimensionHeight"
        Me.nmuDimensionHeight.Size = New System.Drawing.Size(40, 20)
        Me.nmuDimensionHeight.TabIndex = 3
        Me.nmuDimensionHeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X"
        '
        'nmuDimensionWidth
        '
        Me.nmuDimensionWidth.Location = New System.Drawing.Point(119, 12)
        Me.nmuDimensionWidth.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nmuDimensionWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmuDimensionWidth.Name = "nmuDimensionWidth"
        Me.nmuDimensionWidth.Size = New System.Drawing.Size(40, 20)
        Me.nmuDimensionWidth.TabIndex = 1
        Me.nmuDimensionWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calendar Dimension :"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(370, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clock Appearance"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 266)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appearance"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(340, 171)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Custom Theme"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboBox2)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 108)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Background"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Image Layout :"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"None", "Tile", "Center", "Stretch", "Zoom"})
        Me.ComboBox2.Location = New System.Drawing.Point(178, 81)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(178, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 25)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Set Background Image"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(178, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Set Background Color"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(24, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Transparent"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Set Forecolor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Set Font"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 58)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Theme"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Harry Potter", "Matrix"})
        Me.ComboBox1.Location = New System.Drawing.Point(51, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 304)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.nmuMaxSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmuDimensionHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmuDimensionWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkday As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlertHour As System.Windows.Forms.CheckBox
    Friend WithEvents chkBeep As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTaskbar As System.Windows.Forms.CheckBox
    Friend WithEvents chkMiniSysTray As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkTop As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents nmuDimensionWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents nmuMaxSelection As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTodayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkShowWeek As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodayCircle As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowToday As System.Windows.Forms.CheckBox
    Friend WithEvents cmbFirstDayWeek As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nmuDimensionHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDateFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbTimeFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
