<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Neutrino_StopWatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Neutrino_StopWatch))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblMillisecond = New System.Windows.Forms.Label()
        Me.lbld1 = New System.Windows.Forms.Label()
        Me.lbld2 = New System.Windows.Forms.Label()
        Me.lbld3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.krpLstBox = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.KryptonContextMenu1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
        Me.KryptonContextMenuHeading2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItem1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.KryptonContextMenuItem2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonContextMenuImageSelect1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuImageSelect()
        Me.KryptonContextMenuHeading1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem6, Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 288)
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.StartToolStripMenuItem.Image = Global.Neutrino_StopWatch.My.Resources.Resources._1333566198_stopwatch_start
        Me.StartToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(181, 38)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.ResetToolStripMenuItem.Image = Global.Neutrino_StopWatch.My.Resources.Resources._1333566209_stopwatch_finish
        Me.ResetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(181, 38)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SplitToolStripMenuItem, Me.LapToolStripMenuItem})
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(181, 38)
        Me.ToolStripMenuItem6.Text = "Mode"
        '
        'SplitToolStripMenuItem
        '
        Me.SplitToolStripMenuItem.CheckOnClick = True
        Me.SplitToolStripMenuItem.Name = "SplitToolStripMenuItem"
        Me.SplitToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.SplitToolStripMenuItem.Text = "Split"
        '
        'LapToolStripMenuItem
        '
        Me.LapToolStripMenuItem.CheckOnClick = True
        Me.LapToolStripMenuItem.Name = "LapToolStripMenuItem"
        Me.LapToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.LapToolStripMenuItem.Text = "Lap"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(181, 38)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(178, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 38)
        Me.ToolStripMenuItem3.Text = "Minimize"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 38)
        Me.ToolStripMenuItem4.Text = "Fit to Screen"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lblHour
        '
        Me.lblHour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHour.AutoSize = True
        Me.lblHour.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblHour.Font = New System.Drawing.Font("Comic Sans MS", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblHour.Location = New System.Drawing.Point(56, 28)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(92, 71)
        Me.lblHour.TabIndex = 1
        Me.lblHour.Text = "00"
        Me.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinute
        '
        Me.lblMinute.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinute.AutoSize = True
        Me.lblMinute.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblMinute.Font = New System.Drawing.Font("Comic Sans MS", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblMinute.Location = New System.Drawing.Point(196, 28)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(92, 71)
        Me.lblMinute.TabIndex = 2
        Me.lblMinute.Text = "00"
        Me.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecond
        '
        Me.lblSecond.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSecond.AutoSize = True
        Me.lblSecond.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblSecond.Font = New System.Drawing.Font("Comic Sans MS", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblSecond.Location = New System.Drawing.Point(345, 28)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(92, 71)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "00"
        Me.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMillisecond
        '
        Me.lblMillisecond.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMillisecond.AutoSize = True
        Me.lblMillisecond.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblMillisecond.Font = New System.Drawing.Font("Comic Sans MS", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillisecond.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblMillisecond.Location = New System.Drawing.Point(494, 28)
        Me.lblMillisecond.Name = "lblMillisecond"
        Me.lblMillisecond.Size = New System.Drawing.Size(92, 71)
        Me.lblMillisecond.TabIndex = 4
        Me.lblMillisecond.Text = "00"
        Me.lblMillisecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbld1
        '
        Me.lbld1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbld1.AutoSize = True
        Me.lbld1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbld1.Font = New System.Drawing.Font("Comic Sans MS", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld1.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbld1.Location = New System.Drawing.Point(145, 28)
        Me.lbld1.Name = "lbld1"
        Me.lbld1.Size = New System.Drawing.Size(45, 71)
        Me.lbld1.TabIndex = 5
        Me.lbld1.Text = ":"
        Me.lbld1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbld2
        '
        Me.lbld2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbld2.AutoSize = True
        Me.lbld2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbld2.Font = New System.Drawing.Font("Comic Sans MS", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld2.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbld2.Location = New System.Drawing.Point(294, 28)
        Me.lbld2.Name = "lbld2"
        Me.lbld2.Size = New System.Drawing.Size(45, 71)
        Me.lbld2.TabIndex = 6
        Me.lbld2.Text = ":"
        Me.lbld2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbld3
        '
        Me.lbld3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbld3.AutoSize = True
        Me.lbld3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbld3.Font = New System.Drawing.Font("Comic Sans MS", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld3.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbld3.Location = New System.Drawing.Point(443, 28)
        Me.lbld3.Name = "lbld3"
        Me.lbld3.Size = New System.Drawing.Size(42, 71)
        Me.lbld3.TabIndex = 7
        Me.lbld3.Text = "."
        Me.lbld3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblMillisecond)
        Me.Panel1.Controls.Add(Me.lblMinute)
        Me.Panel1.Controls.Add(Me.lbld1)
        Me.Panel1.Controls.Add(Me.lblHour)
        Me.Panel1.Controls.Add(Me.lbld2)
        Me.Panel1.Controls.Add(Me.lbld3)
        Me.Panel1.Controls.Add(Me.lblSecond)
        Me.Panel1.Location = New System.Drawing.Point(55, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 126)
        Me.Panel1.TabIndex = 8
        '
        'krpLstBox
        '
        Me.krpLstBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.krpLstBox.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary
        Me.krpLstBox.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon
        Me.krpLstBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"})
        Me.krpLstBox.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini
        Me.krpLstBox.KryptonContextMenu = Me.KryptonContextMenu1
        Me.krpLstBox.Location = New System.Drawing.Point(458, 12)
        Me.krpLstBox.Name = "krpLstBox"
        Me.krpLstBox.Padding = New System.Windows.Forms.Padding(3)
        Me.krpLstBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.krpLstBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.krpLstBox.Size = New System.Drawing.Size(305, 37)
        Me.krpLstBox.TabIndex = 9
        '
        'KryptonContextMenu1
        '
        Me.KryptonContextMenu1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuHeading2, Me.KryptonContextMenuItems2})
        Me.KryptonContextMenu1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.KryptonContextMenu1.StateNormal.ItemHighlight.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.KryptonContextMenu1.StateNormal.ItemHighlight.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonContextMenu1.StateNormal.ItemTextStandard.LongText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonContextMenu1.StateNormal.ItemTextStandard.Padding = New System.Windows.Forms.Padding(1)
        Me.KryptonContextMenu1.StateNormal.ItemTextStandard.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'KryptonContextMenuHeading2
        '
        Me.KryptonContextMenuHeading2.ExtraText = ""
        Me.KryptonContextMenuHeading2.Text = "Split"
        '
        'KryptonContextMenuItems2
        '
        Me.KryptonContextMenuItems2.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItem1, Me.KryptonContextMenuItem2})
        '
        'KryptonContextMenuItem1
        '
        Me.KryptonContextMenuItem1.ExtraText = "Remove Selected Data(s)"
        Me.KryptonContextMenuItem1.LargeKryptonCommandImage = True
        Me.KryptonContextMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.KryptonContextMenuItem1.SplitSubMenu = True
        Me.KryptonContextMenuItem1.Text = "Remove"
        '
        'KryptonContextMenuItem2
        '
        Me.KryptonContextMenuItem2.ExtraText = "Clear All Data"
        Me.KryptonContextMenuItem2.LargeKryptonCommandImage = True
        Me.KryptonContextMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KryptonContextMenuItem2.SplitSubMenu = True
        Me.KryptonContextMenuItem2.Text = "Clear"
        '
        'KryptonManager1
        '
        Me.KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'KryptonContextMenuHeading1
        '
        Me.KryptonContextMenuHeading1.ExtraText = ""
        '
        'Neutrino_StopWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(775, 411)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.krpLstBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Neutrino_StopWatch"
        Me.Text = "Neutrino StopWatch"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbld3 As System.Windows.Forms.Label
    Friend WithEvents lbld2 As System.Windows.Forms.Label
    Friend WithEvents lbld1 As System.Windows.Forms.Label
    Friend WithEvents lblMillisecond As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblMinute As System.Windows.Forms.Label
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents krpLstBox As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonContextMenu1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuHeading2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItem1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents KryptonContextMenuItem2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents KryptonContextMenuImageSelect1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuImageSelect
    Friend WithEvents KryptonContextMenuHeading1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading

End Class
