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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnShowDialog As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShowDialog = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnShowDialog
        '
        Me.btnShowDialog.Location = New System.Drawing.Point(216, 16)
        Me.btnShowDialog.Name = "btnShowDialog"
        Me.btnShowDialog.Size = New System.Drawing.Size(88, 23)
        Me.btnShowDialog.TabIndex = 0
        Me.btnShowDialog.Text = "Show Dialog"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(40, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(136, 108)
        Me.ListBox1.TabIndex = 2
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "TextBox1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1, Me.ListBox1, Me.btnShowDialog})
        Me.Name = "Form1"
        Me.Text = "Common DialogBox Project "
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Open File Dialog Box ... ")
        ListBox1.Items.Add("Save File  Dialog Box... ")
        ListBox1.Items.Add("Font Dialog Box...")
        ListBox1.Items.Add("Color Dialog Box...")
        ListBox1.Items.Add("Print Dialog Box...")

    End Sub

    Private Sub btnShowDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDialog.Click
        If ListBox1.Text = ListBox1.Items(0) Then
            OpenFileDialog1.DefaultExt = ".Doc"
            OpenFileDialog1.Filter = "Word Files |*.Doc"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
            End If

        ElseIf ListBox1.Text = ListBox1.Items(1) Then
            SaveFileDialog1.DefaultExt = "Document File *.Doc"
            SaveFileDialog1.Filter = "Word Files |*.Doc"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = SaveFileDialog1.FileName
            End If


        ElseIf ListBox1.Text = ListBox1.Items(2) Then
            If FontDialog1.ShowDialog = DialogResult.OK Then
                TextBox1.Font = FontDialog1.Font
            End If

        ElseIf ListBox1.Text = ListBox1.Items(3) Then
            If ColorDialog1.ShowDialog = DialogResult.OK Then
                Me.BackColor = ColorDialog1.Color
            End If

        ElseIf ListBox1.Text = ListBox1.Items(4) Then
            PrintDialog1.PrinterSettings = New System.Drawing.Printing.PrinterSettings()
            PrintDialog1.ShowDialog()
            Console.WriteLine("My name : A.R.Khan")
            Console.WriteLine("My Address :Dhaka, Banglasedh")
            Console.WriteLine("My E-mail :ark@bangla.net")
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
