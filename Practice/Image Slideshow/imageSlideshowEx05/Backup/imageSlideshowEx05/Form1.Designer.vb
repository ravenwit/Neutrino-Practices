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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        Me.pic = New System.Windows.Forms.PictureBox
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.lblHeight = New System.Windows.Forms.Label
        Me.lblWidth = New System.Windows.Forms.Label
        Me.ss = New System.Windows.Forms.StatusStrip
        Me.ssStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.ssCurrentImageNumber = New System.Windows.Forms.ToolStripStatusLabel
        Me.ts2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.lblCount = New System.Windows.Forms.ToolStripLabel
        Me.cmbPaths = New System.Windows.Forms.ToolStripComboBox
        Me.tsBtnPlaySound = New System.Windows.Forms.ToolStripButton
        Me.tsBtnStopSound = New System.Windows.Forms.ToolStripButton
        Me.tsBtnOpenSound = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsBtnRotateLeft = New System.Windows.Forms.ToolStripButton
        Me.tsBtnRotateRight = New System.Windows.Forms.ToolStripButton
        Me.ts = New System.Windows.Forms.ToolStrip
        Me.tsBtnOpen = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.tsBtnPrevious = New System.Windows.Forms.ToolStripButton
        Me.tsBtnNext = New System.Windows.Forms.ToolStripButton
        Me.tsBtnStart = New System.Windows.Forms.ToolStripButton
        Me.tsBtnStop = New System.Windows.Forms.ToolStripButton
        Me.tsBtnAddItem = New System.Windows.Forms.ToolStripButton
        Me.tsBtnAddDirectory = New System.Windows.Forms.ToolStripButton
        Me.tsBtnViewMode = New System.Windows.Forms.ToolStripDropDownButton
        Me.tsMnuNormal = New System.Windows.Forms.ToolStripMenuItem
        Me.tsMnuStretch = New System.Windows.Forms.ToolStripMenuItem
        Me.tsMnuAutosize = New System.Windows.Forms.ToolStripMenuItem
        Me.tsMnuCenter = New System.Windows.Forms.ToolStripMenuItem
        Me.tsMnuZoom = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsMnuSizeToView = New System.Windows.Forms.ToolStripMenuItem
        Me.tsBtnDelay = New System.Windows.Forms.ToolStripDropDownButton
        Me.mnuOne = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTwo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuThree = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFour = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFive = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCustomDelay = New System.Windows.Forms.ToolStripMenuItem
        Me.pnl.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ss.SuspendLayout()
        Me.ts2.SuspendLayout()
        Me.ts.SuspendLayout()
        Me.SuspendLayout()
        '
        'tTip
        '
        Me.tTip.IsBalloon = True
        '
        'pnl
        '
        Me.pnl.AutoScroll = True
        Me.pnl.AutoSize = True
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pic)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 64)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(869, 378)
        Me.pnl.TabIndex = 5
        '
        'pic
        '
        Me.pic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pic.Location = New System.Drawing.Point(0, 0)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(867, 376)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic.TabIndex = 2
        Me.pic.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.UseAntiAlias = True
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = ""
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.ShowHelp = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'lblHeight
        '
        Me.lblHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Image = Global.imageSlideshowEx05.My.Resources.Resources.menu
        Me.lblHeight.Location = New System.Drawing.Point(780, 447)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(0, 13)
        Me.lblHeight.TabIndex = 8
        '
        'lblWidth
        '
        Me.lblWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Image = Global.imageSlideshowEx05.My.Resources.Resources.menu
        Me.lblWidth.Location = New System.Drawing.Point(709, 447)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(0, 13)
        Me.lblWidth.TabIndex = 7
        '
        'ss
        '
        Me.ss.BackgroundImage = Global.imageSlideshowEx05.My.Resources.Resources.menu
        Me.ss.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssStatus, Me.ssCurrentImageNumber})
        Me.ss.Location = New System.Drawing.Point(0, 442)
        Me.ss.Name = "ss"
        Me.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ss.Size = New System.Drawing.Size(869, 22)
        Me.ss.Stretch = False
        Me.ss.TabIndex = 4
        Me.ss.Text = "StatusStrip1"
        '
        'ssStatus
        '
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Size = New System.Drawing.Size(42, 17)
        Me.ssStatus.Text = "Status:"
        '
        'ssCurrentImageNumber
        '
        Me.ssCurrentImageNumber.Name = "ssCurrentImageNumber"
        Me.ssCurrentImageNumber.Size = New System.Drawing.Size(102, 17)
        Me.ssCurrentImageNumber.Text = "Current Image: #0"
        '
        'ts2
        '
        Me.ts2.BackgroundImage = Global.imageSlideshowEx05.My.Resources.Resources.menu
        Me.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.lblCount, Me.cmbPaths, Me.tsBtnPlaySound, Me.tsBtnStopSound, Me.tsBtnOpenSound, Me.ToolStripSeparator1, Me.tsBtnRotateLeft, Me.tsBtnRotateRight})
        Me.ts2.Location = New System.Drawing.Point(0, 39)
        Me.ts2.Name = "ts2"
        Me.ts2.Size = New System.Drawing.Size(869, 25)
        Me.ts2.TabIndex = 3
        Me.ts2.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblCount
        '
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(64, 22)
        Me.lblCount.Text = "Count: n/a"
        '
        'cmbPaths
        '
        Me.cmbPaths.AutoToolTip = True
        Me.cmbPaths.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbPaths.MaxDropDownItems = 10
        Me.cmbPaths.Name = "cmbPaths"
        Me.cmbPaths.Size = New System.Drawing.Size(300, 25)
        Me.cmbPaths.Sorted = True
        Me.cmbPaths.ToolTipText = "Contains the list of images. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IF you want to delete a image from the list then" & _
            " select the image and press the delete button on the keyboard."
        '
        'tsBtnPlaySound
        '
        Me.tsBtnPlaySound.Enabled = False
        Me.tsBtnPlaySound.Image = Global.imageSlideshowEx05.My.Resources.Resources.play_16x16
        Me.tsBtnPlaySound.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPlaySound.Name = "tsBtnPlaySound"
        Me.tsBtnPlaySound.Size = New System.Drawing.Size(49, 22)
        Me.tsBtnPlaySound.Text = "Play"
        Me.tsBtnPlaySound.ToolTipText = "Play Sound File"
        '
        'tsBtnStopSound
        '
        Me.tsBtnStopSound.Enabled = False
        Me.tsBtnStopSound.Image = Global.imageSlideshowEx05.My.Resources.Resources.stop_16x16
        Me.tsBtnStopSound.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnStopSound.Name = "tsBtnStopSound"
        Me.tsBtnStopSound.Size = New System.Drawing.Size(51, 22)
        Me.tsBtnStopSound.Text = "Stop"
        Me.tsBtnStopSound.ToolTipText = "Stop Sound File"
        '
        'tsBtnOpenSound
        '
        Me.tsBtnOpenSound.Image = Global.imageSlideshowEx05.My.Resources.Resources.music_note_SH_32x32
        Me.tsBtnOpenSound.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnOpenSound.Name = "tsBtnOpenSound"
        Me.tsBtnOpenSound.Size = New System.Drawing.Size(93, 22)
        Me.tsBtnOpenSound.Text = "Open Sound"
        Me.tsBtnOpenSound.ToolTipText = "Open a Sound File to Play"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnRotateLeft
        '
        Me.tsBtnRotateLeft.Image = CType(resources.GetObject("tsBtnRotateLeft.Image"), System.Drawing.Image)
        Me.tsBtnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnRotateLeft.Name = "tsBtnRotateLeft"
        Me.tsBtnRotateLeft.Size = New System.Drawing.Size(61, 22)
        Me.tsBtnRotateLeft.Text = "Rotate"
        Me.tsBtnRotateLeft.ToolTipText = "Rotate the Image Left by 90*"
        '
        'tsBtnRotateRight
        '
        Me.tsBtnRotateRight.Image = CType(resources.GetObject("tsBtnRotateRight.Image"), System.Drawing.Image)
        Me.tsBtnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnRotateRight.Name = "tsBtnRotateRight"
        Me.tsBtnRotateRight.Size = New System.Drawing.Size(61, 22)
        Me.tsBtnRotateRight.Text = "Rotate"
        Me.tsBtnRotateRight.ToolTipText = "Rotate the Image Right 90*"
        '
        'ts
        '
        Me.ts.AllowItemReorder = True
        Me.ts.BackgroundImage = Global.imageSlideshowEx05.My.Resources.Resources.navbar1
        Me.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnOpen, Me.toolStripSeparator, Me.tsBtnPrevious, Me.tsBtnNext, Me.tsBtnStart, Me.tsBtnStop, Me.tsBtnAddItem, Me.tsBtnAddDirectory, Me.tsBtnViewMode, Me.tsBtnDelay})
        Me.ts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ts.Location = New System.Drawing.Point(0, 0)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(869, 39)
        Me.ts.TabIndex = 0
        Me.ts.Text = "ToolStrip1"
        '
        'tsBtnOpen
        '
        Me.tsBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnOpen.Image = CType(resources.GetObject("tsBtnOpen.Image"), System.Drawing.Image)
        Me.tsBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnOpen.Name = "tsBtnOpen"
        Me.tsBtnOpen.Size = New System.Drawing.Size(23, 36)
        Me.tsBtnOpen.Text = "&Open"
        Me.tsBtnOpen.Visible = False
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'tsBtnPrevious
        '
        Me.tsBtnPrevious.Image = Global.imageSlideshowEx05.My.Resources.Resources.Undo_32x32
        Me.tsBtnPrevious.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPrevious.Name = "tsBtnPrevious"
        Me.tsBtnPrevious.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnPrevious.ToolTipText = "Previous Image"
        '
        'tsBtnNext
        '
        Me.tsBtnNext.Image = Global.imageSlideshowEx05.My.Resources.Resources.Redo_32x32
        Me.tsBtnNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnNext.Name = "tsBtnNext"
        Me.tsBtnNext.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnNext.ToolTipText = "Next Image"
        '
        'tsBtnStart
        '
        Me.tsBtnStart.Image = Global.imageSlideshowEx05.My.Resources.Resources.play_32x32
        Me.tsBtnStart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsBtnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnStart.Name = "tsBtnStart"
        Me.tsBtnStart.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnStart.ToolTipText = "Start Slideshow"
        '
        'tsBtnStop
        '
        Me.tsBtnStop.Image = Global.imageSlideshowEx05.My.Resources.Resources.stop_32x32
        Me.tsBtnStop.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsBtnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnStop.Name = "tsBtnStop"
        Me.tsBtnStop.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnStop.ToolTipText = "Stop Slideshow"
        '
        'tsBtnAddItem
        '
        Me.tsBtnAddItem.Image = Global.imageSlideshowEx05.My.Resources.Resources.image_add_24x24
        Me.tsBtnAddItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnAddItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAddItem.Name = "tsBtnAddItem"
        Me.tsBtnAddItem.Size = New System.Drawing.Size(28, 36)
        Me.tsBtnAddItem.ToolTipText = "Add Image"
        '
        'tsBtnAddDirectory
        '
        Me.tsBtnAddDirectory.Image = Global.imageSlideshowEx05.My.Resources.Resources.folder_add_24x24
        Me.tsBtnAddDirectory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnAddDirectory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAddDirectory.Name = "tsBtnAddDirectory"
        Me.tsBtnAddDirectory.Size = New System.Drawing.Size(28, 36)
        Me.tsBtnAddDirectory.ToolTipText = "Add Directory"
        '
        'tsBtnViewMode
        '
        Me.tsBtnViewMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsBtnViewMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMnuNormal, Me.tsMnuStretch, Me.tsMnuAutosize, Me.tsMnuCenter, Me.tsMnuZoom, Me.ToolStripMenuItem2, Me.tsMnuSizeToView})
        Me.tsBtnViewMode.Image = Global.imageSlideshowEx05.My.Resources.Resources.image_24x24
        Me.tsBtnViewMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnViewMode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnViewMode.Name = "tsBtnViewMode"
        Me.tsBtnViewMode.Size = New System.Drawing.Size(105, 36)
        Me.tsBtnViewMode.Text = "Image View"
        '
        'tsMnuNormal
        '
        Me.tsMnuNormal.AutoToolTip = True
        Me.tsMnuNormal.Name = "tsMnuNormal"
        Me.tsMnuNormal.Size = New System.Drawing.Size(158, 22)
        Me.tsMnuNormal.Text = "Normal"
        '
        'tsMnuStretch
        '
        Me.tsMnuStretch.AutoToolTip = True
        Me.tsMnuStretch.Name = "tsMnuStretch"
        Me.tsMnuStretch.Size = New System.Drawing.Size(158, 22)
        Me.tsMnuStretch.Text = "Stretch"
        '
        'tsMnuAutosize
        '
        Me.tsMnuAutosize.AutoToolTip = True
        Me.tsMnuAutosize.Name = "tsMnuAutosize"
        Me.tsMnuAutosize.Size = New System.Drawing.Size(158, 22)
        Me.tsMnuAutosize.Tag = "Actual"
        Me.tsMnuAutosize.Text = "Autosize"
        '
        'tsMnuCenter
        '
        Me.tsMnuCenter.AutoToolTip = True
        Me.tsMnuCenter.Checked = True
        Me.tsMnuCenter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsMnuCenter.Name = "tsMnuCenter"
        Me.tsMnuCenter.Size = New System.Drawing.Size(158, 22)
        Me.tsMnuCenter.Text = "Center"
        '
        'tsMnuZoom
        '
        Me.tsMnuZoom.AutoToolTip = True
        Me.tsMnuZoom.Name = "tsMnuZoom"
        Me.tsMnuZoom.Size = New System.Drawing.Size(158, 22)
        Me.tsMnuZoom.Text = "Zoom"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(155, 6)
        '
        'tsMnuSizeToView
        '
        Me.tsMnuSizeToView.Name = "tsMnuSizeToView"
        Me.tsMnuSizeToView.Size = New System.Drawing.Size(158, 22)
        Me.tsMnuSizeToView.Text = "Size to Full View"
        '
        'tsBtnDelay
        '
        Me.tsBtnDelay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsBtnDelay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOne, Me.mnuTwo, Me.mnuThree, Me.mnuFour, Me.mnuFive, Me.ToolStripMenuItem1, Me.mnuCustomDelay})
        Me.tsBtnDelay.Image = Global.imageSlideshowEx05.My.Resources.Resources.Slide_Show_32x32
        Me.tsBtnDelay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsBtnDelay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDelay.Name = "tsBtnDelay"
        Me.tsBtnDelay.Size = New System.Drawing.Size(137, 36)
        Me.tsBtnDelay.Text = "Slideshow Delay"
        '
        'mnuOne
        '
        Me.mnuOne.Name = "mnuOne"
        Me.mnuOne.Size = New System.Drawing.Size(176, 22)
        Me.mnuOne.Text = "One (1) - Second"
        '
        'mnuTwo
        '
        Me.mnuTwo.Checked = True
        Me.mnuTwo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuTwo.Name = "mnuTwo"
        Me.mnuTwo.Size = New System.Drawing.Size(176, 22)
        Me.mnuTwo.Text = "Two (2) - Seconds"
        '
        'mnuThree
        '
        Me.mnuThree.Name = "mnuThree"
        Me.mnuThree.Size = New System.Drawing.Size(176, 22)
        Me.mnuThree.Text = "Three (3) - Seconds"
        '
        'mnuFour
        '
        Me.mnuFour.Name = "mnuFour"
        Me.mnuFour.Size = New System.Drawing.Size(176, 22)
        Me.mnuFour.Text = "Four (4) - Seconds"
        '
        'mnuFive
        '
        Me.mnuFive.Name = "mnuFive"
        Me.mnuFive.Size = New System.Drawing.Size(176, 22)
        Me.mnuFive.Text = "Five (5) - Seconds"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
        '
        'mnuCustomDelay
        '
        Me.mnuCustomDelay.Name = "mnuCustomDelay"
        Me.mnuCustomDelay.Size = New System.Drawing.Size(176, 22)
        Me.mnuCustomDelay.Text = "Custom..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(869, 464)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.ss)
        Me.Controls.Add(Me.ts2)
        Me.Controls.Add(Me.ts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VBCodeMagic - Image Slide Show"
        Me.pnl.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ss.ResumeLayout(False)
        Me.ss.PerformLayout()
        Me.ts2.ResumeLayout(False)
        Me.ts2.PerformLayout()
        Me.ts.ResumeLayout(False)
        Me.ts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ts As System.Windows.Forms.ToolStrip
    Friend WithEvents tsBtnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsBtnPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents tTip As System.Windows.Forms.ToolTip
    Friend WithEvents tsBtnAddItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnAddDirectory As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnDelay As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuOne As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTwo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuThree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFour As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCustomDelay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsBtnStart As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnViewMode As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsMnuNormal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMnuStretch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMnuAutosize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMnuCenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMnuZoom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbPaths As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ss As System.Windows.Forms.StatusStrip
    Friend WithEvents ssStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssCurrentImageNumber As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsMnuSizeToView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsBtnPlaySound As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnStopSound As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnOpenSound As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnRotateLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnRotateRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label

End Class
