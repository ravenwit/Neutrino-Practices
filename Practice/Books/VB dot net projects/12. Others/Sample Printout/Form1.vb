Public Class Form1
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(32, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(32, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Page Setup"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Read margin into Local Variable
        Dim Lmargin, RMargin, TMargin, BMargin As Integer
        With PrintDocument1.DefaultPageSettings.Margins
            Lmargin = .Left
            RMargin = .Right
            TMargin = .Top
            BMargin = .Bottom
        End With
        'Calculate the diamentions of the orintable area
        Dim PrintWidth, PrintHeight As Integer
        With PrintDocument1.DefaultPageSettings.PaperSize
            PrintWidth = .Width - Lmargin - RMargin
            PrintHeight = .Height - TMargin - TMargin
        End With
        'Preparing Rectangle in total Printable area
        Dim R As Rectangle
        R = New Rectangle(Lmargin, TMargin, PrintWidth, PrintHeight)
        e.Graphics.DrawRectangle(Pens.Black, R)

        If PrintDocument1.DefaultPageSettings.Landscape Then
            With PrintDocument1.DefaultPageSettings.PaperSize
                PrintWidth = .Height - TMargin - BMargin
                PrintHeight = Width - RMargin - Lmargin
                Width = PrintWidth
                Height = PrintHeight
            End With
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        PageSetupDialog1.ShowDialog()
        PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
