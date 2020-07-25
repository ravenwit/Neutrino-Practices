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
        Me.lblPlatinum = New System.Windows.Forms.Label()
        Me.btnPI = New System.Windows.Forms.Button()
        Me.btnAI = New System.Windows.Forms.Button()
        Me.btnPD = New System.Windows.Forms.Button()
        Me.pnlBtn = New System.Windows.Forms.Panel()
        Me.pnlBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPlatinum
        '
        Me.lblPlatinum.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPlatinum.Font = New System.Drawing.Font("DS-Terminal", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatinum.Location = New System.Drawing.Point(0, 0)
        Me.lblPlatinum.Name = "lblPlatinum"
        Me.lblPlatinum.Size = New System.Drawing.Size(1134, 77)
        Me.lblPlatinum.TabIndex = 1
        Me.lblPlatinum.Text = "Platinum"
        Me.lblPlatinum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPI
        '
        Me.btnPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPI.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPI.Location = New System.Drawing.Point(275, 91)
        Me.btnPI.Name = "btnPI"
        Me.btnPI.Size = New System.Drawing.Size(585, 27)
        Me.btnPI.TabIndex = 2
        Me.btnPI.Text = "Button1"
        Me.btnPI.UseVisualStyleBackColor = True
        '
        'btnAI
        '
        Me.btnAI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAI.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAI.Location = New System.Drawing.Point(275, 153)
        Me.btnAI.Name = "btnAI"
        Me.btnAI.Size = New System.Drawing.Size(585, 27)
        Me.btnAI.TabIndex = 3
        Me.btnAI.Text = "Button2"
        Me.btnAI.UseVisualStyleBackColor = True
        '
        'btnPD
        '
        Me.btnPD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPD.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPD.Location = New System.Drawing.Point(275, 215)
        Me.btnPD.Name = "btnPD"
        Me.btnPD.Size = New System.Drawing.Size(585, 27)
        Me.btnPD.TabIndex = 4
        Me.btnPD.Text = "Button3"
        Me.btnPD.UseVisualStyleBackColor = True
        '
        'pnlBtn
        '
        Me.pnlBtn.Controls.Add(Me.btnPD)
        Me.pnlBtn.Controls.Add(Me.btnAI)
        Me.pnlBtn.Controls.Add(Me.btnPI)
        Me.pnlBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBtn.Location = New System.Drawing.Point(0, 77)
        Me.pnlBtn.Name = "pnlBtn"
        Me.pnlBtn.Size = New System.Drawing.Size(1134, 403)
        Me.pnlBtn.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 480)
        Me.Controls.Add(Me.pnlBtn)
        Me.Controls.Add(Me.lblPlatinum)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.pnlBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPlatinum As System.Windows.Forms.Label
    Friend WithEvents btnPI As System.Windows.Forms.Button
    Friend WithEvents btnAI As System.Windows.Forms.Button
    Friend WithEvents btnPD As System.Windows.Forms.Button
    Friend WithEvents pnlBtn As System.Windows.Forms.Panel
End Class
