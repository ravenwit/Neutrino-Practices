Public Class frmPaintbrush
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private WithEvents picDraw As System.Windows.Forms.PictureBox
    Private WithEvents pnlOptions As System.Windows.Forms.Panel
    Private WithEvents mnuMain As System.Windows.Forms.MainMenu
    Private WithEvents mnuFile As System.Windows.Forms.MenuItem
    Private WithEvents mnuFileNew As System.Windows.Forms.MenuItem
    Private WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
    Private WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Private WithEvents mnuFileSep As System.Windows.Forms.MenuItem
    Private WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Private WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Private WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Private WithEvents pnlPenOptions As System.Windows.Forms.Panel
    Private WithEvents lblColor As System.Windows.Forms.Label
    Private WithEvents cboColors As System.Windows.Forms.ComboBox
    Private WithEvents lblPenWidth As System.Windows.Forms.Label
    Private WithEvents updPenWidth As System.Windows.Forms.NumericUpDown
    Private WithEvents pnlShapeOptions As System.Windows.Forms.Panel
    Private WithEvents lblShapeType As System.Windows.Forms.Label
    Private WithEvents cboShapeType As System.Windows.Forms.ComboBox
    Private WithEvents lblShapeHeight As System.Windows.Forms.Label
    Private WithEvents updShapeHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents updShapeWidth As System.Windows.Forms.NumericUpDown
    Private WithEvents lblShapeWidth As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Private WithEvents optText As System.Windows.Forms.RadioButton
    Private WithEvents optShape As System.Windows.Forms.RadioButton
    Private WithEvents optPen As System.Windows.Forms.RadioButton
    Private WithEvents pnlTools As System.Windows.Forms.Panel
    Private WithEvents updFontSize As System.Windows.Forms.NumericUpDown
    Private WithEvents lblFontSize As System.Windows.Forms.Label
    Private WithEvents cboTextFont As System.Windows.Forms.ComboBox
    Private WithEvents lblTextFont As System.Windows.Forms.Label
    Private WithEvents txtText As System.Windows.Forms.TextBox
    Private WithEvents lblText As System.Windows.Forms.Label
    Private WithEvents pnlTextOptions As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPaintbrush))
        Me.updShapeHeight = New System.Windows.Forms.NumericUpDown()
        Me.cboColors = New System.Windows.Forms.ComboBox()
        Me.pnlShapeOptions = New System.Windows.Forms.Panel()
        Me.lblShapeWidth = New System.Windows.Forms.Label()
        Me.updShapeWidth = New System.Windows.Forms.NumericUpDown()
        Me.lblShapeHeight = New System.Windows.Forms.Label()
        Me.cboShapeType = New System.Windows.Forms.ComboBox()
        Me.lblShapeType = New System.Windows.Forms.Label()
        Me.updPenWidth = New System.Windows.Forms.NumericUpDown()
        Me.picDraw = New System.Windows.Forms.PictureBox()
        Me.pnlPenOptions = New System.Windows.Forms.Panel()
        Me.lblPenWidth = New System.Windows.Forms.Label()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuMain = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileNew = New System.Windows.Forms.MenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileSep = New System.Windows.Forms.MenuItem()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.pnlTextOptions = New System.Windows.Forms.Panel()
        Me.updFontSize = New System.Windows.Forms.NumericUpDown()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.cboTextFont = New System.Windows.Forms.ComboBox()
        Me.lblTextFont = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.optText = New System.Windows.Forms.RadioButton()
        Me.optShape = New System.Windows.Forms.RadioButton()
        Me.optPen = New System.Windows.Forms.RadioButton()
        Me.pnlTools = New System.Windows.Forms.Panel()
        CType(Me.updShapeHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlShapeOptions.SuspendLayout()
        CType(Me.updShapeWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updPenWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPenOptions.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.pnlTextOptions.SuspendLayout()
        CType(Me.updFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'updShapeHeight
        '
        Me.updShapeHeight.Location = New System.Drawing.Point(64, 32)
        Me.updShapeHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updShapeHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updShapeHeight.Name = "updShapeHeight"
        Me.updShapeHeight.Size = New System.Drawing.Size(48, 20)
        Me.updShapeHeight.TabIndex = 3
        Me.updShapeHeight.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'cboColors
        '
        Me.cboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColors.DropDownWidth = 136
        Me.cboColors.Location = New System.Drawing.Point(8, 24)
        Me.cboColors.Name = "cboColors"
        Me.cboColors.Size = New System.Drawing.Size(136, 21)
        Me.cboColors.TabIndex = 2
        '
        'pnlShapeOptions
        '
        Me.pnlShapeOptions.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblShapeWidth, Me.updShapeWidth, Me.updShapeHeight, Me.lblShapeHeight, Me.cboShapeType, Me.lblShapeType})
        Me.pnlShapeOptions.Location = New System.Drawing.Point(160, 16)
        Me.pnlShapeOptions.Name = "pnlShapeOptions"
        Me.pnlShapeOptions.Size = New System.Drawing.Size(274, 56)
        Me.pnlShapeOptions.TabIndex = 0
        '
        'lblShapeWidth
        '
        Me.lblShapeWidth.Location = New System.Drawing.Point(128, 32)
        Me.lblShapeWidth.Name = "lblShapeWidth"
        Me.lblShapeWidth.Size = New System.Drawing.Size(48, 16)
        Me.lblShapeWidth.TabIndex = 2
        Me.lblShapeWidth.Text = "Width:"
        '
        'updShapeWidth
        '
        Me.updShapeWidth.Location = New System.Drawing.Point(184, 32)
        Me.updShapeWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updShapeWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updShapeWidth.Name = "updShapeWidth"
        Me.updShapeWidth.Size = New System.Drawing.Size(48, 20)
        Me.updShapeWidth.TabIndex = 3
        Me.updShapeWidth.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'lblShapeHeight
        '
        Me.lblShapeHeight.Location = New System.Drawing.Point(8, 32)
        Me.lblShapeHeight.Name = "lblShapeHeight"
        Me.lblShapeHeight.Size = New System.Drawing.Size(48, 16)
        Me.lblShapeHeight.TabIndex = 2
        Me.lblShapeHeight.Text = "Height:"
        '
        'cboShapeType
        '
        Me.cboShapeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShapeType.DropDownWidth = 121
        Me.cboShapeType.Location = New System.Drawing.Point(64, 8)
        Me.cboShapeType.Name = "cboShapeType"
        Me.cboShapeType.Size = New System.Drawing.Size(121, 21)
        Me.cboShapeType.TabIndex = 1
        '
        'lblShapeType
        '
        Me.lblShapeType.Location = New System.Drawing.Point(8, 8)
        Me.lblShapeType.Name = "lblShapeType"
        Me.lblShapeType.Size = New System.Drawing.Size(48, 16)
        Me.lblShapeType.TabIndex = 0
        Me.lblShapeType.Text = "Type:"
        '
        'updPenWidth
        '
        Me.updPenWidth.Location = New System.Drawing.Point(96, 8)
        Me.updPenWidth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.updPenWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updPenWidth.Name = "updPenWidth"
        Me.updPenWidth.Size = New System.Drawing.Size(48, 20)
        Me.updPenWidth.TabIndex = 1
        Me.updPenWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'picDraw
        '
        Me.picDraw.BackColor = System.Drawing.SystemColors.Window
        Me.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDraw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDraw.Image = CType(resources.GetObject("picDraw.Image"), System.Drawing.Bitmap)
        Me.picDraw.Location = New System.Drawing.Point(64, 0)
        Me.picDraw.Name = "picDraw"
        Me.picDraw.Size = New System.Drawing.Size(436, 260)
        Me.picDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDraw.TabIndex = 2
        Me.picDraw.TabStop = False
        '
        'pnlPenOptions
        '
        Me.pnlPenOptions.Controls.AddRange(New System.Windows.Forms.Control() {Me.updPenWidth, Me.lblPenWidth})
        Me.pnlPenOptions.Location = New System.Drawing.Point(160, 9)
        Me.pnlPenOptions.Name = "pnlPenOptions"
        Me.pnlPenOptions.Size = New System.Drawing.Size(274, 56)
        Me.pnlPenOptions.TabIndex = 0
        '
        'lblPenWidth
        '
        Me.lblPenWidth.Location = New System.Drawing.Point(8, 8)
        Me.lblPenWidth.Name = "lblPenWidth"
        Me.lblPenWidth.Size = New System.Drawing.Size(80, 16)
        Me.lblPenWidth.TabIndex = 0
        Me.lblPenWidth.Text = "Pen Width:"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 4
        Me.mnuFileExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSep, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Index = 0
        Me.mnuFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Index = 1
        Me.mnuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.mnuFileOpen.Text = "&Open..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Index = 2
        Me.mnuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSep
        '
        Me.mnuFileSep.Index = 3
        Me.mnuFileSep.Text = "-"
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlTextOptions, Me.pnlShapeOptions, Me.cboColors, Me.lblColor, Me.pnlPenOptions})
        Me.pnlOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlOptions.Location = New System.Drawing.Point(64, 260)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(436, 72)
        Me.pnlOptions.TabIndex = 1
        '
        'pnlTextOptions
        '
        Me.pnlTextOptions.Controls.AddRange(New System.Windows.Forms.Control() {Me.updFontSize, Me.lblFontSize, Me.cboTextFont, Me.lblTextFont, Me.txtText, Me.lblText})
        Me.pnlTextOptions.Location = New System.Drawing.Point(160, 11)
        Me.pnlTextOptions.Name = "pnlTextOptions"
        Me.pnlTextOptions.Size = New System.Drawing.Size(274, 56)
        Me.pnlTextOptions.TabIndex = 0
        '
        'updFontSize
        '
        Me.updFontSize.Location = New System.Drawing.Point(208, 32)
        Me.updFontSize.Maximum = New Decimal(New Integer() {72, 0, 0, 0})
        Me.updFontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.updFontSize.Name = "updFontSize"
        Me.updFontSize.Size = New System.Drawing.Size(48, 20)
        Me.updFontSize.TabIndex = 5
        Me.updFontSize.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'lblFontSize
        '
        Me.lblFontSize.Location = New System.Drawing.Point(160, 32)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(40, 16)
        Me.lblFontSize.TabIndex = 4
        Me.lblFontSize.Text = "Size:"
        '
        'cboTextFont
        '
        Me.cboTextFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTextFont.DropDownWidth = 104
        Me.cboTextFont.ItemHeight = 13
        Me.cboTextFont.Location = New System.Drawing.Point(48, 32)
        Me.cboTextFont.Name = "cboTextFont"
        Me.cboTextFont.Size = New System.Drawing.Size(104, 21)
        Me.cboTextFont.TabIndex = 3
        '
        'lblTextFont
        '
        Me.lblTextFont.Location = New System.Drawing.Point(8, 32)
        Me.lblTextFont.Name = "lblTextFont"
        Me.lblTextFont.Size = New System.Drawing.Size(40, 16)
        Me.lblTextFont.TabIndex = 2
        Me.lblTextFont.Text = "Font:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(48, 8)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(208, 20)
        Me.txtText.TabIndex = 1
        Me.txtText.Text = "Pintbrush Project"
        '
        'lblText
        '
        Me.lblText.Location = New System.Drawing.Point(8, 8)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(40, 16)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Text:"
        '
        'lblColor
        '
        Me.lblColor.Location = New System.Drawing.Point(8, 8)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(48, 16)
        Me.lblColor.TabIndex = 1
        Me.lblColor.Text = "Color:"
        '
        'dlgSave
        '
        Me.dlgSave.DefaultExt = "bmp"
        Me.dlgSave.FileName = "MyPaint1"
        Me.dlgSave.Filter = "Bitmap files|*.bmp|PNG files|*.png"
        '
        'dlgOpen
        '
        Me.dlgOpen.DefaultExt = "bmp"
        Me.dlgOpen.Filter = "Bitmap files|*.bmp|PNG files|*.png"
        '
        'optText
        '
        Me.optText.Appearance = System.Windows.Forms.Appearance.Button
        Me.optText.Location = New System.Drawing.Point(8, 88)
        Me.optText.Name = "optText"
        Me.optText.Size = New System.Drawing.Size(48, 36)
        Me.optText.TabIndex = 0
        Me.optText.Text = "Text"
        Me.optText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optShape
        '
        Me.optShape.Appearance = System.Windows.Forms.Appearance.Button
        Me.optShape.Location = New System.Drawing.Point(8, 48)
        Me.optShape.Name = "optShape"
        Me.optShape.Size = New System.Drawing.Size(48, 36)
        Me.optShape.TabIndex = 0
        Me.optShape.Text = "Shape"
        Me.optShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optPen
        '
        Me.optPen.Appearance = System.Windows.Forms.Appearance.Button
        Me.optPen.Checked = True
        Me.optPen.Location = New System.Drawing.Point(8, 8)
        Me.optPen.Name = "optPen"
        Me.optPen.Size = New System.Drawing.Size(48, 36)
        Me.optPen.TabIndex = 0
        Me.optPen.TabStop = True
        Me.optPen.Text = "Pen"
        Me.optPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTools
        '
        Me.pnlTools.Controls.AddRange(New System.Windows.Forms.Control() {Me.optText, Me.optShape, Me.optPen})
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(64, 332)
        Me.pnlTools.TabIndex = 0
        '
        'frmPaintbrush
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(500, 332)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.picDraw, Me.pnlOptions, Me.pnlTools})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Menu = Me.mnuMain
        Me.Name = "frmPaintbrush"
        Me.Text = "Paintbrush Project"
        CType(Me.updShapeHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlShapeOptions.ResumeLayout(False)
        CType(Me.updShapeWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updPenWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPenOptions.ResumeLayout(False)
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlTextOptions.ResumeLayout(False)
        CType(Me.updFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Enumerations"
    Public Enum DrawingTools
        Pen
        Shape
        Text
    End Enum
#End Region

#Region "Member variables for properties"
    Private m_sFileName As String
    Private m_bDrawing As Boolean
    Private m_eCurrentTool As DrawingTools
#End Region

#Region "Private variables"
    Private oGraphics As System.Drawing.Graphics
    Private oTool As Object
    Private sngX As Single
    Private sngY As Single
#End Region

#Region "Properties"
    Public Property FileName() As String
        Get
            Return m_sFileName
        End Get
        Set(ByVal Value As String)
            m_sFileName = Value
        End Set
    End Property

    Public Property Drawing() As Boolean
        Get
            Return m_bDrawing
        End Get
        Set(ByVal Value As Boolean)
            m_bDrawing = Value
        End Set
    End Property

    Public Property CurrentTool() As DrawingTools
        Get
            Return m_eCurrentTool
        End Get
        Set(ByVal Value As DrawingTools)
            m_eCurrentTool = Value
            'destroy the existing tool
            If Not oTool Is Nothing Then
                CType(oTool, IDisposable).Dispose()
            End If
        End Set
    End Property

#End Region

#Region "Menu commands"
    Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click
        Me.oGraphics.Clear(Color.White)
        'force the refresh
        Me.picDraw.Refresh()
    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        If Me.dlgOpen.ShowDialog = DialogResult.OK Then
            Me.picDraw.Image.FromFile(Me.dlgOpen.FileName)
        End If
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        Dim sFileName As String
        Dim oFormat As System.Drawing.Imaging.ImageFormat

        'get the filename to save to
        If dlgSave.ShowDialog = DialogResult.OK Then
            sFileName = dlgSave.FileName
            Select Case dlgSave.FilterIndex
                Case 0  'save as bitmap
                    oFormat = System.Drawing.Imaging.ImageFormat.Bmp
                Case 1  'save as PNG
                    oFormat = System.Drawing.Imaging.ImageFormat.Png
                Case Else
                    'should never happen
            End Select
            'possible exception on save
            Try
                Me.picDraw.Image.Save(sFileName, oFormat)

            Catch ex As Exception
                'just display for now
                MessageBox.Show(ex.Message, "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

#End Region

#Region "PictureBox Event Handlers"

    Private Sub picDraw_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDraw.MouseMove
        If Me.Drawing Then
            'this is only true if the current tool is a pen
            oGraphics.DrawLine(oTool, sngX, sngY, e.X, e.Y)
            sngX = e.X
            sngY = e.Y
            'force a redraw
            Me.picDraw.Refresh()
        End If
    End Sub

    Private Sub picDraw_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDraw.MouseUp
        'we can stop drawing now
        Me.Drawing = False
    End Sub

    Private Sub picDraw_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDraw.MouseDown
        'start drawing
        'Shape and Text are stamps, Pen works on MouseMove
        'we need to create the tool and either draw it, or get ready to draw it
        Select Case Me.CurrentTool
            Case DrawingTools.Shape
                Select Case Me.cboShapeType.Text
                    Case "Rectangle"
                        oGraphics.FillRectangle(New SolidBrush(Color.FromName(Me.cboColors.Text)), _
                            e.X, _
                            e.Y, _
                            Me.updShapeWidth.Value, _
                            Me.updShapeHeight.Value)
                    Case "Ellipse"
                        oGraphics.FillEllipse(New SolidBrush(Color.FromName(Me.cboColors.Text)), _
                        e.X, _
                        e.Y, _
                        Me.updShapeWidth.Value, _
                        Me.updShapeHeight.Value)
                    Case Else
                End Select
                'force a redraw
                Me.picDraw.Refresh()
            Case DrawingTools.Text
                'create a font
                oTool = New System.Drawing.Font(Me.cboTextFont.Text, Me.updFontSize.Value)
                'draw the text at the current mouse location
                oGraphics.DrawString(Me.txtText.Text, _
                    oTool, New SolidBrush(Color.FromName(Me.cboColors.Text)), _
                    e.X, e.Y)
                'force a redraw
                Me.picDraw.Refresh()
            Case DrawingTools.Pen
                'create the pen (for drawing in MouseMove)
                oTool = New System.Drawing.Pen(Color.FromName(Me.cboColors.Text), Me.updPenWidth.Value)
                sngX = e.X
                sngY = e.Y
                Me.Drawing = True
        End Select
    End Sub
#End Region

#Region "Other Event Handlers"
    Private Sub frmPaintbrush_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set up the Color ComboBox
        FillLists()
        'create the graphics we'll be drawing on
        Me.picDraw.Image = New Bitmap(picDraw.Width, picDraw.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
        Me.oGraphics = Graphics.FromImage(Me.picDraw.Image)
        'set the background to white
        Me.oGraphics.Clear(Color.White)
        'set the initial tool to the Pen
        optPen_Click(Nothing, Nothing)
    End Sub

    Private Sub optPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPen.Click
        'set the tool to a pen
        Me.CurrentTool = DrawingTools.Pen
        'hide all the other tool's panels
        pnlPenOptions.Visible = True
        pnlShapeOptions.Visible = False
        pnlTextOptions.Visible = False
    End Sub

    Private Sub optShape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optShape.Click
        'set the tool to a Shape
        Me.CurrentTool = DrawingTools.Shape
        'hide all the other tool's panels
        pnlPenOptions.Visible = False
        pnlShapeOptions.Visible = True
        pnlTextOptions.Visible = False
    End Sub

    Private Sub optText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optText.Click
        'set the tool to Text
        Me.CurrentTool = DrawingTools.Text
        'hide all the other tool's panels
        pnlPenOptions.Visible = False
        pnlShapeOptions.Visible = False
        pnlTextOptions.Visible = True
    End Sub
#End Region

#Region "Assorted methods"
    Private Sub FillLists()
        With cboColors.Items
            .Add("Black")
            .Add("Red")
            .Add("Green")
            .Add("Blue")
        End With
        cboColors.SelectedIndex = 0

        With cboShapeType.Items
            .Add("Rectangle")
            .Add("Ellipse")
        End With
        cboShapeType.SelectedIndex = 0

        With cboTextFont.Items
            .Add("Arial")
            .Add("Times New Roman")
            .Add("Courier New")
        End With
        cboTextFont.SelectedIndex = 0
    End Sub
#End Region

    Private Sub pnlTools_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTools.Paint

    End Sub



End Class
