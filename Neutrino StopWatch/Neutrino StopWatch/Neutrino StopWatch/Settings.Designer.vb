<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnForecolor = New System.Windows.Forms.Button()
        Me.txtForecolor = New System.Windows.Forms.TextBox()
        Me.lblForecolor = New System.Windows.Forms.Label()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.txtFont = New System.Windows.Forms.TextBox()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBgImage = New System.Windows.Forms.RadioButton()
        Me.btnBgImage = New System.Windows.Forms.Button()
        Me.radBgColor = New System.Windows.Forms.RadioButton()
        Me.txtBgImage = New System.Windows.Forms.TextBox()
        Me.btnBgColor = New System.Windows.Forms.Button()
        Me.txtBgColor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 260)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(416, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Appearence"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnForecolor)
        Me.GroupBox2.Controls.Add(Me.txtForecolor)
        Me.GroupBox2.Controls.Add(Me.lblForecolor)
        Me.GroupBox2.Controls.Add(Me.btnFont)
        Me.GroupBox2.Controls.Add(Me.txtFont)
        Me.GroupBox2.Controls.Add(Me.lblFont)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Text"
        '
        'btnForecolor
        '
        Me.btnForecolor.Location = New System.Drawing.Point(351, 60)
        Me.btnForecolor.Name = "btnForecolor"
        Me.btnForecolor.Size = New System.Drawing.Size(29, 25)
        Me.btnForecolor.TabIndex = 9
        Me.btnForecolor.Text = "..."
        Me.btnForecolor.UseVisualStyleBackColor = True
        '
        'txtForecolor
        '
        Me.txtForecolor.Location = New System.Drawing.Point(148, 65)
        Me.txtForecolor.Name = "txtForecolor"
        Me.txtForecolor.ReadOnly = True
        Me.txtForecolor.Size = New System.Drawing.Size(197, 20)
        Me.txtForecolor.TabIndex = 10
        '
        'lblForecolor
        '
        Me.lblForecolor.AutoSize = True
        Me.lblForecolor.Location = New System.Drawing.Point(6, 70)
        Me.lblForecolor.Name = "lblForecolor"
        Me.lblForecolor.Size = New System.Drawing.Size(69, 13)
        Me.lblForecolor.TabIndex = 8
        Me.lblForecolor.Text = "Forecolor     :"
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(351, 23)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(29, 25)
        Me.btnFont.TabIndex = 7
        Me.btnFont.Text = "..."
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'txtFont
        '
        Me.txtFont.Location = New System.Drawing.Point(148, 28)
        Me.txtFont.Name = "txtFont"
        Me.txtFont.ReadOnly = True
        Me.txtFont.Size = New System.Drawing.Size(197, 20)
        Me.txtFont.TabIndex = 7
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(6, 33)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(67, 13)
        Me.lblFont.TabIndex = 0
        Me.lblFont.Text = "Font            :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBgImage)
        Me.GroupBox1.Controls.Add(Me.btnBgImage)
        Me.GroupBox1.Controls.Add(Me.radBgColor)
        Me.GroupBox1.Controls.Add(Me.txtBgImage)
        Me.GroupBox1.Controls.Add(Me.btnBgColor)
        Me.GroupBox1.Controls.Add(Me.txtBgColor)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Background"
        '
        'radBgImage
        '
        Me.radBgImage.AutoSize = True
        Me.radBgImage.Location = New System.Drawing.Point(6, 67)
        Me.radBgImage.Name = "radBgImage"
        Me.radBgImage.Size = New System.Drawing.Size(130, 17)
        Me.radBgImage.TabIndex = 3
        Me.radBgImage.TabStop = True
        Me.radBgImage.Text = "Background Image    :"
        Me.radBgImage.UseVisualStyleBackColor = True
        '
        'btnBgImage
        '
        Me.btnBgImage.Location = New System.Drawing.Point(351, 64)
        Me.btnBgImage.Name = "btnBgImage"
        Me.btnBgImage.Size = New System.Drawing.Size(29, 25)
        Me.btnBgImage.TabIndex = 5
        Me.btnBgImage.Text = "..."
        Me.btnBgImage.UseVisualStyleBackColor = True
        '
        'radBgColor
        '
        Me.radBgColor.AutoSize = True
        Me.radBgColor.Location = New System.Drawing.Point(6, 32)
        Me.radBgColor.Name = "radBgColor"
        Me.radBgColor.Size = New System.Drawing.Size(128, 17)
        Me.radBgColor.TabIndex = 2
        Me.radBgColor.TabStop = True
        Me.radBgColor.Text = "Background Color     :"
        Me.radBgColor.UseVisualStyleBackColor = True
        '
        'txtBgImage
        '
        Me.txtBgImage.Location = New System.Drawing.Point(148, 67)
        Me.txtBgImage.Name = "txtBgImage"
        Me.txtBgImage.ReadOnly = True
        Me.txtBgImage.Size = New System.Drawing.Size(197, 20)
        Me.txtBgImage.TabIndex = 4
        '
        'btnBgColor
        '
        Me.btnBgColor.Location = New System.Drawing.Point(351, 26)
        Me.btnBgColor.Name = "btnBgColor"
        Me.btnBgColor.Size = New System.Drawing.Size(29, 25)
        Me.btnBgColor.TabIndex = 2
        Me.btnBgColor.Text = "..."
        Me.btnBgColor.UseVisualStyleBackColor = True
        '
        'txtBgColor
        '
        Me.txtBgColor.Location = New System.Drawing.Point(148, 29)
        Me.txtBgColor.Name = "txtBgColor"
        Me.txtBgColor.ReadOnly = True
        Me.txtBgColor.Size = New System.Drawing.Size(197, 20)
        Me.txtBgColor.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 260)
        Me.Panel1.TabIndex = 1
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 260)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnForecolor As System.Windows.Forms.Button
    Friend WithEvents txtForecolor As System.Windows.Forms.TextBox
    Friend WithEvents lblForecolor As System.Windows.Forms.Label
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents txtFont As System.Windows.Forms.TextBox
    Friend WithEvents lblFont As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBgImage As System.Windows.Forms.Button
    Friend WithEvents txtBgImage As System.Windows.Forms.TextBox
    Friend WithEvents btnBgColor As System.Windows.Forms.Button
    Friend WithEvents txtBgColor As System.Windows.Forms.TextBox
    Friend WithEvents radBgImage As System.Windows.Forms.RadioButton
    Friend WithEvents radBgColor As System.Windows.Forms.RadioButton
End Class
