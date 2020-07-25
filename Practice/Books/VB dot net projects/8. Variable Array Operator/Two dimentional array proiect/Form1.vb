Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim Question(100) As String
    Dim Answer(100) As String
    Dim QuestionNo As Integer
    Dim Subscript As Integer

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
    Friend WithEvents btnQuestion As System.Windows.Forms.Button
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtQuestionNo As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtQuestionNo = New System.Windows.Forms.TextBox()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Question No"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Question"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Answer"
        '
        'btnQuestion
        '
        Me.btnQuestion.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestion.Location = New System.Drawing.Point(288, 32)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.TabIndex = 3
        Me.btnQuestion.Text = "Question"
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(288, 88)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.TabIndex = 4
        Me.btnAnswer.Text = "Answer"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(288, 144)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        '
        'txtQuestionNo
        '
        Me.txtQuestionNo.Location = New System.Drawing.Point(96, 32)
        Me.txtQuestionNo.Name = "txtQuestionNo"
        Me.txtQuestionNo.Size = New System.Drawing.Size(56, 20)
        Me.txtQuestionNo.TabIndex = 6
        Me.txtQuestionNo.Text = ""
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(96, 88)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(168, 20)
        Me.txtQuestion.TabIndex = 7
        Me.txtQuestion.Text = ""
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(96, 144)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(168, 20)
        Me.txtAnswer.TabIndex = 8
        Me.txtAnswer.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAnswer, Me.txtQuestion, Me.txtQuestionNo, Me.btnExit, Me.btnAnswer, Me.btnQuestion, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Two Dimensional Array"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuestionNo.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        QuestionNo = 10
        Question(1) = "What is Computer ?"
        Answer(1) = "Computer is a Eletronic Machine."
        Question(2) = "What is Abacus ?"
        Answer(2) = "Abacus is Wooden counting machine"
        Question(3) = "Who is called father of Computer."
        Answer(3) = "Charles Babage. "
        Question(4) = "What is Visual Basic."
        Answer(4) = "It's a high leve progrmming language."
        Question(5) = "What is Windows."
        Answer(5) = "It's a Operating System"
        Question(6) = "When first computer came into exixtance ?"
        Answer(6) = " In 1948 "
        Question(7) = "What is the name of first computer?"
        Answer(7) = " Mark - 1"
        Question(8) = "How many geneation computer has ?"
        Answer(8) = " Five Generation"
        Question(9) = "What will be the outcome of 5th Generation ?"
        Answer(9) = " Artificial Intelligency of computer"
        Question(10) = "What is your interest ?"
        Answer(10) = " To make fun with computer"
        btnQuestion.Enabled = True
        btnQuestion.Enabled = True

    End Sub

    Private Sub btnQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        Subscript = txtQuestionNo.Text
        txtQuestion.Text = Question(Subscript)
        txtAnswer.Text = ""
        btnQuestion.Enabled = False
        btnAnswer.Enabled = True

    End Sub

    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        txtAnswer.Text = Answer(Subscript)
        btnQuestion.Enabled = True
        btnAnswer.Enabled = False

    End Sub
End Class
