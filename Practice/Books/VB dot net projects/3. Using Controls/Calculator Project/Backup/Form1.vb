Public Class frmCalculatorProject
    Inherits System.Windows.Forms.Form
    Dim ClearDisplay As Boolean
    Dim Number1 As Double
    Dim Number2 As Double
    Dim Operator As String

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
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnPeriod As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnPeriod = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(16, 64)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(35, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(56, 64)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(35, 23)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(100, 64)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(35, 23)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(16, 92)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(35, 23)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(56, 92)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(35, 23)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(100, 92)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(35, 23)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(16, 120)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(35, 23)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(56, 120)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(35, 23)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(100, 120)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(35, 23)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(16, 149)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(35, 23)
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(100, 149)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(35, 23)
        Me.btnC.TabIndex = 11
        Me.btnC.Text = "C"
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnPlus.Location = New System.Drawing.Point(152, 120)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(35, 23)
        Me.btnPlus.TabIndex = 12
        Me.btnPlus.Text = "+"
        '
        'btnPeriod
        '
        Me.btnPeriod.Font = New System.Drawing.Font("Arial", 15.25!, System.Drawing.FontStyle.Bold)
        Me.btnPeriod.Location = New System.Drawing.Point(56, 149)
        Me.btnPeriod.Name = "btnPeriod"
        Me.btnPeriod.Size = New System.Drawing.Size(35, 23)
        Me.btnPeriod.TabIndex = 13
        Me.btnPeriod.Text = "."
        '
        'btnEqual
        '
        Me.btnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnEqual.Location = New System.Drawing.Point(153, 149)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(72, 23)
        Me.btnEqual.TabIndex = 14
        Me.btnEqual.Text = "="
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnMinus.Location = New System.Drawing.Point(192, 120)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(35, 23)
        Me.btnMinus.TabIndex = 15
        Me.btnMinus.Text = "-"
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnMultiply.Location = New System.Drawing.Point(152, 88)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(35, 23)
        Me.btnMultiply.TabIndex = 16
        Me.btnMultiply.Text = "*"
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnDivision.Location = New System.Drawing.Point(192, 88)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(35, 23)
        Me.btnDivision.TabIndex = 17
        Me.btnDivision.Text = "/"
        '
        'frmCalculatorProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(237, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDivision, Me.btnMultiply, Me.btnMinus, Me.btnEqual, Me.btnPeriod, Me.btnPlus, Me.btnC, Me.btn0, Me.btn9, Me.btn8, Me.btn7, Me.btn6, Me.btn5, Me.btn4, Me.btn3, Me.btn2, Me.btn1, Me.Label1})
        Me.Name = "frmCalculatorProject"
        Me.Text = "Sample Calculator"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        If ClearDisplay Then
            Label1.Text = ""
            ClearDisplay = False
        End If

        Label1.Text = Label1.Text + sender.text
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        Label1.Text = ""
    End Sub

    Private Sub btnPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriod.Click
        If Label1.Text.IndexOf(".") > 0 Then
            Exit Sub
        Else
            Label1.Text = Label1.Text & "."
        End If

    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        Number1 = Val(Label1.Text)
        Operator = "+"
        ClearDisplay = True

    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        Number1 = Val(Label1.Text)
        Operator = "-"
        ClearDisplay = True
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        Number1 = Val(Label1.Text)
        Operator = "*"
        ClearDisplay = True
    End Sub

    Private Sub btnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivision.Click
        Number1 = Val(Label1.Text)
        Operator = "/"
        ClearDisplay = True
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        Dim result As Double
        Number2 = Val(Label1.Text)
        Select Case Operator
            Case "+"
                result = Number1 + Number2
            Case "-"
                result = Number1 - Number2
            Case "*"
                result = Number1 * Number2
            Case "/"
                If Number2 <> "0" Then
                    result = Number1 / Number2
                End If
        End Select
        Label1.Text = result
        ClearDisplay = True
    End Sub

End Class
