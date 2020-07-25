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
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Items.AddRange(New Object() {"5001", "5002", "5003", "5004", "5005", "5006", "5007", "5008", "5009", "5010"})
        Me.ListBox1.Location = New System.Drawing.Point(8, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(80, 121)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.Items.AddRange(New Object() {"Printer  LQ 2170", "Fax Modem 56 kbs", "Key Board", "Floppy Drive", "Mouse -Genius", "Monitor -Philiph", "Computer Desk", "Speaker", "CD Drive", "Scanner"})
        Me.ListBox2.Location = New System.Drawing.Point(104, 16)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 121)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox3
        '
        Me.ListBox3.Items.AddRange(New Object() {"7500.00", "2600.00", "200.00", "500.00", "100.00", "6000.00", "8500.00", "800.00", "2000.00", "7400.00"})
        Me.ListBox3.Location = New System.Drawing.Point(248, 16)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(88, 121)
        Me.ListBox3.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListBox3, Me.ListBox2, Me.ListBox1})
        Me.Name = "Form1"
        Me.Text = "Multi List Box Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static PrevList1 As Integer
        Dim TopList1 As Integer
        TopList1 = ListBox1.TopIndex
        If TopList1 <> PrevList1 Then
            ListBox2.TopIndex = TopList1
            ListBox3.TopIndex = TopList1
            PrevList1 = TopList1
        End If

        If ListBox1.SelectedIndex <> ListBox2.SelectedIndex Or ListBox1.SelectedIndex <> ListBox3.SelectedIndex Then
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            ListBox3.SelectedIndex = ListBox1.SelectedIndex
        End If

    End Sub
End Class
