<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtCountSelSum = New System.Windows.Forms.TextBox()
        Me.txtCountAllSum = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtAllSUm = New System.Windows.Forms.TextBox()
        Me.txtSelSum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCountSelSum
        '
        Me.txtCountSelSum.Location = New System.Drawing.Point(679, 0)
        Me.txtCountSelSum.Name = "txtCountSelSum"
        Me.txtCountSelSum.Size = New System.Drawing.Size(100, 20)
        Me.txtCountSelSum.TabIndex = 11
        '
        'txtCountAllSum
        '
        Me.txtCountAllSum.Location = New System.Drawing.Point(355, 0)
        Me.txtCountAllSum.Name = "txtCountAllSum"
        Me.txtCountAllSum.Size = New System.Drawing.Size(100, 20)
        Me.txtCountAllSum.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(533, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtAllSUm
        '
        Me.txtAllSUm.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtAllSUm.Location = New System.Drawing.Point(0, 0)
        Me.txtAllSUm.Multiline = True
        Me.txtAllSUm.Name = "txtAllSUm"
        Me.txtAllSUm.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAllSUm.Size = New System.Drawing.Size(349, 503)
        Me.txtAllSUm.TabIndex = 8
        '
        'txtSelSum
        '
        Me.txtSelSum.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtSelSum.Location = New System.Drawing.Point(858, 0)
        Me.txtSelSum.Multiline = True
        Me.txtSelSum.Name = "txtSelSum"
        Me.txtSelSum.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSelSum.Size = New System.Drawing.Size(344, 503)
        Me.txtSelSum.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 503)
        Me.Controls.Add(Me.txtCountSelSum)
        Me.Controls.Add(Me.txtCountAllSum)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtAllSUm)
        Me.Controls.Add(Me.txtSelSum)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCountSelSum As System.Windows.Forms.TextBox
    Friend WithEvents txtCountAllSum As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtAllSUm As System.Windows.Forms.TextBox
    Friend WithEvents txtSelSum As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
