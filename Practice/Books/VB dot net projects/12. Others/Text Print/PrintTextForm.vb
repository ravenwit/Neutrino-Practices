Public Class PrintTextForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.

    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Private WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PrintTextForm))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(110, 110)
        Me.PrintPreviewDialog1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Opacity = 1
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(584, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Preview && Print "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.MaxLength = 0
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(728, 408)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "TextBox1"
        '
        'PrintTextForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 453)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.TextBox1})
        Me.Name = "PrintTextForm"
        Me.Text = "Printing Text Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim txtFont As New Font("Arial", 10)
        Dim LMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim TMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim txtH As Integer = _
           PrintDocument1.DefaultPageSettings.PaperSize.Height - _
           PrintDocument1.DefaultPageSettings.Margins.Top - _
           PrintDocument1.DefaultPageSettings.Margins.Bottom
        Dim txtW As Integer = _
           PrintDocument1.DefaultPageSettings.PaperSize.Width - _
           PrintDocument1.DefaultPageSettings.Margins.Left - _
           PrintDocument1.DefaultPageSettings.Margins.Right
        Dim linesPerPage As Integer = _
           e.MarginBounds.Height / txtFont.GetHeight(e.Graphics)
        Dim R As New RectangleF(LMargin, TMargin, txtW, txtH)
        Static line As String
        Dim word As String
        Dim cols, lines As Integer
        word = GetNextWord()
        While word <> "" And lines < linesPerPage
            line = line & word
            word = GetNextWord()
            e.Graphics.MeasureString(line & word, txtFont, New SizeF(txtW, txtH), _
                                     New StringFormat(), cols, lines)
        End While
        If word = "" And Trim(line) <> "" Then
            e.Graphics.DrawString(line, txtFont, Brushes.Black, R, _
                                  New StringFormat())
            e.HasMorePages = False
            Exit Sub
        End If
        e.Graphics.DrawString(line, txtFont, Brushes.Black, R, New StringFormat())
        e.HasMorePages = True
        line = word
    End Sub

    Function GetNextWord(Optional ByVal reset As Boolean = False) As String
        Static currPos As Integer
        Dim word As String

        If reset Then currPos = 0
        If currPos >= TextBox1.Text.Length Then Return ""
        While Not System.Char.IsLetterOrDigit(TextBox1.Text.Chars(currPos))
            word = word & TextBox1.Text.Chars(currPos)
            currPos = currPos + 1
            If currPos >= TextBox1.Text.Length Then Return word
        End While
        While Not (System.Char.IsWhiteSpace(TextBox1.Text.Chars(currPos)))
            word = word & TextBox1.Text.Chars(currPos)
            currPos = currPos + 1
            If currPos >= TextBox1.Text.Length Then Return word
        End While
        Return word
    End Function

    Dim textToPrint As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        textToPrint = TextBox1.Text

        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        If PageSetupDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch exc As Exception
            MsgBox("Print operation failed " & vbCrLf & exc.Message)
        End Try
    End Sub

End Class
