Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim iApril(29) As Integer
    Dim iDay As Integer

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnNewRequest As System.Windows.Forms.Button
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents txtSeats As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnNewRequest = New System.Windows.Forms.Button()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Royal Bengle Airlines, inc"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the Day in April  to fly"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Seats to Reserve"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 48)
        Me.Label4.TabIndex = 3
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnProcess
        '
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProcess.Location = New System.Drawing.Point(8, 240)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(144, 24)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        '
        'btnNewRequest
        '
        Me.btnNewRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRequest.Location = New System.Drawing.Point(160, 240)
        Me.btnNewRequest.Name = "btnNewRequest"
        Me.btnNewRequest.Size = New System.Drawing.Size(144, 24)
        Me.btnNewRequest.TabIndex = 5
        Me.btnNewRequest.Text = "New Request"
        '
        'txtDay
        '
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.Location = New System.Drawing.Point(237, 117)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(72, 29)
        Me.txtDay.TabIndex = 6
        Me.txtDay.Text = ""
        '
        'txtSeats
        '
        Me.txtSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeats.Location = New System.Drawing.Point(237, 149)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(72, 29)
        Me.txtSeats.TabIndex = 7
        Me.txtSeats.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(168, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 277)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.txtSeats, Me.txtDay, Me.btnNewRequest, Me.btnProcess, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Air Ticketing Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For iDay = 0 To 29
            iApril(iDay) = 10
        Next iDay

    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim SeatAvailable, SeatRequesred As Integer
        SeatAvailable = Val(txtDay.Text)
        SeatRequesred = Val(txtSeats.Text)
        If iApril(SeatAvailable) < SeatRequesred Then
            Label4.Text = "Sorry, only " + Str(iApril(SeatAvailable)) + " Seats Available for April " + Str(SeatAvailable)
        Else
            Label4.Text = "Reservation Confirmed. "
            iApril(SeatAvailable) = iApril(SeatAvailable) - SeatRequesred
        End If

    End Sub

    Private Sub btnNewRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRequest.Click
        txtDay.Text = ""
        txtSeats.Text = ""
        txtDay.Focus()
    End Sub
End Class
