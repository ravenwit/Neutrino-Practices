﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecret
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecret))
        Me.tmrSecret = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSecret = New System.Windows.Forms.Panel()
        Me.lblPlatinum = New System.Windows.Forms.Label()
        Me.tmrMsg = New System.Windows.Forms.Timer(Me.components)
        Me.lblSecret = New System.Windows.Forms.Label()
        Me.pnlSecret.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrSecret
        '
        '
        'pnlSecret
        '
        Me.pnlSecret.Controls.Add(Me.lblSecret)
        Me.pnlSecret.Controls.Add(Me.lblPlatinum)
        Me.pnlSecret.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlSecret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSecret.Location = New System.Drawing.Point(0, 0)
        Me.pnlSecret.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSecret.Name = "pnlSecret"
        Me.pnlSecret.Size = New System.Drawing.Size(966, 448)
        Me.pnlSecret.TabIndex = 1
        '
        'lblPlatinum
        '
        Me.lblPlatinum.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPlatinum.Font = New System.Drawing.Font("DS-Terminal", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatinum.Location = New System.Drawing.Point(0, 0)
        Me.lblPlatinum.Name = "lblPlatinum"
        Me.lblPlatinum.Size = New System.Drawing.Size(966, 77)
        Me.lblPlatinum.TabIndex = 0
        Me.lblPlatinum.Text = "Welcome to Platinum"
        Me.lblPlatinum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrMsg
        '
        Me.tmrMsg.Enabled = True
        Me.tmrMsg.Interval = 80
        '
        'lblSecret
        '
        Me.lblSecret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSecret.Font = New System.Drawing.Font("Terminus (TTF)", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecret.Location = New System.Drawing.Point(0, 77)
        Me.lblSecret.Name = "lblSecret"
        Me.lblSecret.Size = New System.Drawing.Size(966, 371)
        Me.lblSecret.TabIndex = 3
        Me.lblSecret.Text = "Label1"
        Me.lblSecret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSecret
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(966, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlSecret)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSecret"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secret"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSecret.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrSecret As System.Windows.Forms.Timer
    Friend WithEvents pnlSecret As System.Windows.Forms.Panel
    Friend WithEvents lblPlatinum As System.Windows.Forms.Label
    Friend WithEvents tmrMsg As System.Windows.Forms.Timer
    Friend WithEvents lblSecret As System.Windows.Forms.Label

End Class
