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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAskBeforeExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMessage As System.Windows.Forms.MenuItem
    Friend WithEvents mnuText As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGreeting As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWhite As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRed As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGreen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBlack As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYellow As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.mnuAskBeforeExit = New System.Windows.Forms.MenuItem()
        Me.mnuMessage = New System.Windows.Forms.MenuItem()
        Me.mnuText = New System.Windows.Forms.MenuItem()
        Me.mnuGreeting = New System.Windows.Forms.MenuItem()
        Me.mnuOptions = New System.Windows.Forms.MenuItem()
        Me.mnuWhite = New System.Windows.Forms.MenuItem()
        Me.mnuRed = New System.Windows.Forms.MenuItem()
        Me.mnuBlack = New System.Windows.Forms.MenuItem()
        Me.mnuGreen = New System.Windows.Forms.MenuItem()
        Me.mnuYellow = New System.Windows.Forms.MenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuMessage, Me.mnuOptions})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit, Me.mnuAskBeforeExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 0
        Me.mnuExit.Text = "Exit"
        '
        'mnuAskBeforeExit
        '
        Me.mnuAskBeforeExit.Checked = True
        Me.mnuAskBeforeExit.Index = 1
        Me.mnuAskBeforeExit.Text = "Ask Before Exit"
        '
        'mnuMessage
        '
        Me.mnuMessage.Index = 1
        Me.mnuMessage.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuText, Me.mnuGreeting})
        Me.mnuMessage.Text = "Message"
        '
        'mnuText
        '
        Me.mnuText.Index = 0
        Me.mnuText.Text = "Text"
        '
        'mnuGreeting
        '
        Me.mnuGreeting.Index = 1
        Me.mnuGreeting.Shortcut = System.Windows.Forms.Shortcut.CtrlK
        Me.mnuGreeting.Text = "Greeting"
        '
        'mnuOptions
        '
        Me.mnuOptions.Index = 2
        Me.mnuOptions.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuWhite, Me.mnuRed, Me.mnuBlack, Me.mnuGreen, Me.mnuYellow})
        Me.mnuOptions.Text = "Background"
        '
        'mnuWhite
        '
        Me.mnuWhite.Index = 0
        Me.mnuWhite.Text = "White"
        '
        'mnuRed
        '
        Me.mnuRed.Index = 1
        Me.mnuRed.Text = "Red"
        '
        'mnuBlack
        '
        Me.mnuBlack.Index = 2
        Me.mnuBlack.Text = "Black"
        '
        'mnuGreen
        '
        Me.mnuGreen.Index = 3
        Me.mnuGreen.Text = "Green"
        '
        'mnuYellow
        '
        Me.mnuYellow.Index = 4
        Me.mnuYellow.Text = "Yellow"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(32, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TextBox1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 209)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1, Me.Label1})
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mnuAskBeforeExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAskBeforeExit.Click
        mnuAskBeforeExit.Checked = Not (mnuAskBeforeExit.Checked)

    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If mnuAskBeforeExit.Checked Then
            If MsgBox("Do you Really want to exit ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Me.Close()

    End Sub

    Private Sub mnuWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWhite.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub mnuRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRed.Click
        Me.BackColor = Color.Red

    End Sub

    Private Sub mnuGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGreen.Click
        Me.BackColor = Color.Green

    End Sub

    Private Sub mnuBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBlack.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub mnuYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYellow.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub mnuPlain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label1.ForeColor = Color.Blue
        TextBox1.ForeColor = Color.Blue
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuText.Click
        Dim Message As String, Title As String
        Message = "Enter name of the person you want to greet."
        Title = " Name please"
        TextBox1.Text = InputBox(Message, Title, "You")
    End Sub

    Private Sub mnuGreeting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGreeting.Click
        mnuGreeting.Checked = Not (mnuGreeting.Checked)
        If mnuGreeting.Checked = True Then
            Label1.Text = "Wel come to "
        Else
            Label1.Text = ""
        End If
    End Sub
End Class
