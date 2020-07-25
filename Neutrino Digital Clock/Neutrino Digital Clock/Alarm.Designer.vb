<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alarm))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.pnlAlarm = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.dtpAlarmTime = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radAlarmText = New System.Windows.Forms.RadioButton()
        Me.radAlarmTone = New System.Windows.Forms.RadioButton()
        Me.txtAlarmText = New System.Windows.Forms.TextBox()
        Me.txtAlarmTone = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.chkCustom = New System.Windows.Forms.CheckBox()
        Me.cmbAlarmTone = New System.Windows.Forms.ComboBox()
        Me.chkAlarm = New System.Windows.Forms.CheckBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAlarmTextDisplay = New System.Windows.Forms.TextBox()
        Me.lnkPreview = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlAlarmAppearence = New System.Windows.Forms.Panel()
        Me.txtAlarmBcolor = New System.Windows.Forms.TextBox()
        Me.cmbAlarmBLayout = New System.Windows.Forms.ComboBox()
        Me.btnAlarmBcolor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlarmBimage = New System.Windows.Forms.TextBox()
        Me.radAlarmBImage = New System.Windows.Forms.RadioButton()
        Me.btnAlarmBimage = New System.Windows.Forms.Button()
        Me.radAlarmBcolor = New System.Windows.Forms.RadioButton()
        Me.cmbAlarmTheme = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.pnlAlarm.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlAlarmAppearence.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(408, 310)
        Me.TabControl2.TabIndex = 2
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.pnlAlarm)
        Me.TabPage5.Controls.Add(Me.chkAlarm)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(400, 284)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Alarm"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'pnlAlarm
        '
        Me.pnlAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAlarm.Controls.Add(Me.LinkLabel1)
        Me.pnlAlarm.Controls.Add(Me.dtpAlarmTime)
        Me.pnlAlarm.Controls.Add(Me.Label10)
        Me.pnlAlarm.Controls.Add(Me.GroupBox10)
        Me.pnlAlarm.Location = New System.Drawing.Point(3, 29)
        Me.pnlAlarm.Name = "pnlAlarm"
        Me.pnlAlarm.Size = New System.Drawing.Size(389, 222)
        Me.pnlAlarm.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(269, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 18)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Stop Alarm"
        '
        'dtpAlarmTime
        '
        Me.dtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpAlarmTime.Location = New System.Drawing.Point(90, 12)
        Me.dtpAlarmTime.Name = "dtpAlarmTime"
        Me.dtpAlarmTime.ShowUpDown = True
        Me.dtpAlarmTime.Size = New System.Drawing.Size(92, 20)
        Me.dtpAlarmTime.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Alarm Time   :"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Panel2)
        Me.GroupBox10.Controls.Add(Me.chkCustom)
        Me.GroupBox10.Controls.Add(Me.cmbAlarmTone)
        Me.GroupBox10.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(360, 168)
        Me.GroupBox10.TabIndex = 16
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Alarm Tone"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.radAlarmText)
        Me.Panel2.Controls.Add(Me.radAlarmTone)
        Me.Panel2.Controls.Add(Me.txtAlarmText)
        Me.Panel2.Controls.Add(Me.txtAlarmTone)
        Me.Panel2.Controls.Add(Me.btnBrowse)
        Me.Panel2.Location = New System.Drawing.Point(10, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 71)
        Me.Panel2.TabIndex = 6
        '
        'radAlarmText
        '
        Me.radAlarmText.AutoSize = True
        Me.radAlarmText.Location = New System.Drawing.Point(7, 44)
        Me.radAlarmText.Name = "radAlarmText"
        Me.radAlarmText.Size = New System.Drawing.Size(55, 17)
        Me.radAlarmText.TabIndex = 8
        Me.radAlarmText.TabStop = True
        Me.radAlarmText.Text = "Text  :"
        Me.radAlarmText.UseVisualStyleBackColor = True
        '
        'radAlarmTone
        '
        Me.radAlarmTone.AutoSize = True
        Me.radAlarmTone.Location = New System.Drawing.Point(7, 16)
        Me.radAlarmTone.Name = "radAlarmTone"
        Me.radAlarmTone.Size = New System.Drawing.Size(56, 17)
        Me.radAlarmTone.TabIndex = 7
        Me.radAlarmTone.TabStop = True
        Me.radAlarmTone.Text = "Tone :"
        Me.radAlarmTone.UseVisualStyleBackColor = True
        '
        'txtAlarmText
        '
        Me.txtAlarmText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAlarmText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarmText.Location = New System.Drawing.Point(64, 40)
        Me.txtAlarmText.Name = "txtAlarmText"
        Me.txtAlarmText.Size = New System.Drawing.Size(221, 21)
        Me.txtAlarmText.TabIndex = 6
        '
        'txtAlarmTone
        '
        Me.txtAlarmTone.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAlarmTone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarmTone.Location = New System.Drawing.Point(64, 13)
        Me.txtAlarmTone.Name = "txtAlarmTone"
        Me.txtAlarmTone.ReadOnly = True
        Me.txtAlarmTone.Size = New System.Drawing.Size(221, 21)
        Me.txtAlarmTone.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.AutoSize = True
        Me.btnBrowse.Location = New System.Drawing.Point(291, 13)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(26, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'chkCustom
        '
        Me.chkCustom.AutoSize = True
        Me.chkCustom.Checked = True
        Me.chkCustom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCustom.Location = New System.Drawing.Point(11, 48)
        Me.chkCustom.Name = "chkCustom"
        Me.chkCustom.Size = New System.Drawing.Size(64, 17)
        Me.chkCustom.TabIndex = 2
        Me.chkCustom.Text = "Custom "
        Me.chkCustom.UseVisualStyleBackColor = True
        '
        'cmbAlarmTone
        '
        Me.cmbAlarmTone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlarmTone.FormattingEnabled = True
        Me.cmbAlarmTone.Location = New System.Drawing.Point(70, 19)
        Me.cmbAlarmTone.Name = "cmbAlarmTone"
        Me.cmbAlarmTone.Size = New System.Drawing.Size(221, 21)
        Me.cmbAlarmTone.TabIndex = 0
        '
        'chkAlarm
        '
        Me.chkAlarm.AutoSize = True
        Me.chkAlarm.Location = New System.Drawing.Point(6, 6)
        Me.chkAlarm.Name = "chkAlarm"
        Me.chkAlarm.Size = New System.Drawing.Size(52, 17)
        Me.chkAlarm.TabIndex = 0
        Me.chkAlarm.Text = "Alarm"
        Me.chkAlarm.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtAlarmTextDisplay)
        Me.TabPage1.Controls.Add(Me.lnkPreview)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.pnlAlarmAppearence)
        Me.TabPage1.Controls.Add(Me.cmbAlarmTheme)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(400, 284)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Alarm Appearence"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtAlarmTextDisplay
        '
        Me.txtAlarmTextDisplay.Location = New System.Drawing.Point(135, 181)
        Me.txtAlarmTextDisplay.Multiline = True
        Me.txtAlarmTextDisplay.Name = "txtAlarmTextDisplay"
        Me.txtAlarmTextDisplay.Size = New System.Drawing.Size(253, 78)
        Me.txtAlarmTextDisplay.TabIndex = 30
        '
        'lnkPreview
        '
        Me.lnkPreview.AutoSize = True
        Me.lnkPreview.Location = New System.Drawing.Point(180, 267)
        Me.lnkPreview.Name = "lnkPreview"
        Me.lnkPreview.Size = New System.Drawing.Size(45, 13)
        Me.lnkPreview.TabIndex = 32
        Me.lnkPreview.TabStop = True
        Me.lnkPreview.Text = "Preview"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Alarm Text   :"
        '
        'pnlAlarmAppearence
        '
        Me.pnlAlarmAppearence.Controls.Add(Me.txtAlarmBcolor)
        Me.pnlAlarmAppearence.Controls.Add(Me.cmbAlarmBLayout)
        Me.pnlAlarmAppearence.Controls.Add(Me.btnAlarmBcolor)
        Me.pnlAlarmAppearence.Controls.Add(Me.Label2)
        Me.pnlAlarmAppearence.Controls.Add(Me.txtAlarmBimage)
        Me.pnlAlarmAppearence.Controls.Add(Me.radAlarmBImage)
        Me.pnlAlarmAppearence.Controls.Add(Me.btnAlarmBimage)
        Me.pnlAlarmAppearence.Controls.Add(Me.radAlarmBcolor)
        Me.pnlAlarmAppearence.Location = New System.Drawing.Point(6, 49)
        Me.pnlAlarmAppearence.Name = "pnlAlarmAppearence"
        Me.pnlAlarmAppearence.Size = New System.Drawing.Size(388, 126)
        Me.pnlAlarmAppearence.TabIndex = 29
        '
        'txtAlarmBcolor
        '
        Me.txtAlarmBcolor.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarmBcolor.Location = New System.Drawing.Point(129, 10)
        Me.txtAlarmBcolor.Name = "txtAlarmBcolor"
        Me.txtAlarmBcolor.ReadOnly = True
        Me.txtAlarmBcolor.Size = New System.Drawing.Size(215, 23)
        Me.txtAlarmBcolor.TabIndex = 17
        '
        'cmbAlarmBLayout
        '
        Me.cmbAlarmBLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlarmBLayout.FormattingEnabled = True
        Me.cmbAlarmBLayout.Items.AddRange(New Object() {"None", "Tile", "Center", "Stretch", "Zoom"})
        Me.cmbAlarmBLayout.Location = New System.Drawing.Point(129, 87)
        Me.cmbAlarmBLayout.Name = "cmbAlarmBLayout"
        Me.cmbAlarmBLayout.Size = New System.Drawing.Size(253, 21)
        Me.cmbAlarmBLayout.TabIndex = 26
        '
        'btnAlarmBcolor
        '
        Me.btnAlarmBcolor.Location = New System.Drawing.Point(350, 6)
        Me.btnAlarmBcolor.Name = "btnAlarmBcolor"
        Me.btnAlarmBcolor.Size = New System.Drawing.Size(32, 27)
        Me.btnAlarmBcolor.TabIndex = 18
        Me.btnAlarmBcolor.Text = "..."
        Me.btnAlarmBcolor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Background Layout  :"
        '
        'txtAlarmBimage
        '
        Me.txtAlarmBimage.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarmBimage.Location = New System.Drawing.Point(129, 50)
        Me.txtAlarmBimage.Name = "txtAlarmBimage"
        Me.txtAlarmBimage.ReadOnly = True
        Me.txtAlarmBimage.Size = New System.Drawing.Size(215, 23)
        Me.txtAlarmBimage.TabIndex = 19
        '
        'radAlarmBImage
        '
        Me.radAlarmBImage.AutoSize = True
        Me.radAlarmBImage.Location = New System.Drawing.Point(11, 52)
        Me.radAlarmBImage.Name = "radAlarmBImage"
        Me.radAlarmBImage.Size = New System.Drawing.Size(118, 17)
        Me.radAlarmBImage.TabIndex = 24
        Me.radAlarmBImage.TabStop = True
        Me.radAlarmBImage.Text = "Background Image:"
        Me.radAlarmBImage.UseVisualStyleBackColor = True
        '
        'btnAlarmBimage
        '
        Me.btnAlarmBimage.Location = New System.Drawing.Point(350, 47)
        Me.btnAlarmBimage.Name = "btnAlarmBimage"
        Me.btnAlarmBimage.Size = New System.Drawing.Size(32, 27)
        Me.btnAlarmBimage.TabIndex = 20
        Me.btnAlarmBimage.Text = "..."
        Me.btnAlarmBimage.UseVisualStyleBackColor = True
        '
        'radAlarmBcolor
        '
        Me.radAlarmBcolor.AutoSize = True
        Me.radAlarmBcolor.Location = New System.Drawing.Point(11, 12)
        Me.radAlarmBcolor.Name = "radAlarmBcolor"
        Me.radAlarmBcolor.Size = New System.Drawing.Size(116, 17)
        Me.radAlarmBcolor.TabIndex = 23
        Me.radAlarmBcolor.TabStop = True
        Me.radAlarmBcolor.Text = "Background Color :"
        Me.radAlarmBcolor.UseVisualStyleBackColor = True
        '
        'cmbAlarmTheme
        '
        Me.cmbAlarmTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlarmTheme.FormattingEnabled = True
        Me.cmbAlarmTheme.Items.AddRange(New Object() {"Windows Default ", "Neutrino", "Aero"})
        Me.cmbAlarmTheme.Location = New System.Drawing.Point(126, 22)
        Me.cmbAlarmTheme.Name = "cmbAlarmTheme"
        Me.cmbAlarmTheme.Size = New System.Drawing.Size(262, 21)
        Me.cmbAlarmTheme.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alarm Theme   :"
        '
        'Alarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 310)
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alarm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.pnlAlarm.ResumeLayout(False)
        Me.pnlAlarm.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlAlarmAppearence.ResumeLayout(False)
        Me.pnlAlarmAppearence.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents pnlAlarm As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents dtpAlarmTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents radAlarmText As System.Windows.Forms.RadioButton
    Friend WithEvents radAlarmTone As System.Windows.Forms.RadioButton
    Friend WithEvents txtAlarmText As System.Windows.Forms.TextBox
    Friend WithEvents txtAlarmTone As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents chkCustom As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAlarmTone As System.Windows.Forms.ComboBox
    Friend WithEvents chkAlarm As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmbAlarmTheme As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlAlarmAppearence As System.Windows.Forms.Panel
    Friend WithEvents txtAlarmBcolor As System.Windows.Forms.TextBox
    Friend WithEvents cmbAlarmBLayout As System.Windows.Forms.ComboBox
    Friend WithEvents btnAlarmBcolor As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlarmBimage As System.Windows.Forms.TextBox
    Friend WithEvents radAlarmBImage As System.Windows.Forms.RadioButton
    Friend WithEvents btnAlarmBimage As System.Windows.Forms.Button
    Friend WithEvents radAlarmBcolor As System.Windows.Forms.RadioButton
    Friend WithEvents txtAlarmTextDisplay As System.Windows.Forms.TextBox
    Friend WithEvents lnkPreview As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
