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
        Me.radbtnFile = New System.Windows.Forms.RadioButton()
        Me.radbtnFolder = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radbtnHide = New System.Windows.Forms.RadioButton()
        Me.radbtnUnhide = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'radbtnFile
        '
        Me.radbtnFile.AutoSize = True
        Me.radbtnFile.Location = New System.Drawing.Point(34, 32)
        Me.radbtnFile.Name = "radbtnFile"
        Me.radbtnFile.Size = New System.Drawing.Size(41, 17)
        Me.radbtnFile.TabIndex = 0
        Me.radbtnFile.TabStop = True
        Me.radbtnFile.Text = "File"
        Me.radbtnFile.UseVisualStyleBackColor = True
        '
        'radbtnFolder
        '
        Me.radbtnFolder.AutoSize = True
        Me.radbtnFolder.Location = New System.Drawing.Point(301, 32)
        Me.radbtnFolder.Name = "radbtnFolder"
        Me.radbtnFolder.Size = New System.Drawing.Size(54, 17)
        Me.radbtnFolder.TabIndex = 1
        Me.radbtnFolder.TabStop = True
        Me.radbtnFolder.Text = "Folder"
        Me.radbtnFolder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radbtnFile)
        Me.GroupBox1.Controls.Add(Me.radbtnFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 71)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a case first"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(147, 244)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 6
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(50, 35)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(293, 20)
        Me.txtPath.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Path  :"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(349, 35)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(27, 20)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.txtPath)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 76)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Path"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radbtnHide)
        Me.GroupBox3.Controls.Add(Me.radbtnUnhide)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(382, 57)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Attrib"
        '
        'radbtnHide
        '
        Me.radbtnHide.AutoSize = True
        Me.radbtnHide.Location = New System.Drawing.Point(31, 20)
        Me.radbtnHide.Name = "radbtnHide"
        Me.radbtnHide.Size = New System.Drawing.Size(47, 17)
        Me.radbtnHide.TabIndex = 2
        Me.radbtnHide.TabStop = True
        Me.radbtnHide.Text = "Hide"
        Me.radbtnHide.UseVisualStyleBackColor = True
        '
        'radbtnUnhide
        '
        Me.radbtnUnhide.AutoSize = True
        Me.radbtnUnhide.Location = New System.Drawing.Point(298, 20)
        Me.radbtnUnhide.Name = "radbtnUnhide"
        Me.radbtnUnhide.Size = New System.Drawing.Size(59, 17)
        Me.radbtnUnhide.TabIndex = 3
        Me.radbtnUnhide.TabStop = True
        Me.radbtnUnhide.Text = "Unhide"
        Me.radbtnUnhide.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 288)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "HUAttrib"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radbtnFile As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnFolder As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radbtnHide As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnUnhide As System.Windows.Forms.RadioButton

End Class
