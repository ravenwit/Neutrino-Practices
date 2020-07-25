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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtJoining As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtHouseRent As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtJoining = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtHouseRent = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Joining (mm/dd/yy)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salary"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "House Rent"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total"
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(32, 184)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(240, 40)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "Total"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(160, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(128, 20)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = ""
        '
        'txtJoining
        '
        Me.txtJoining.Location = New System.Drawing.Point(160, 36)
        Me.txtJoining.Name = "txtJoining"
        Me.txtJoining.Size = New System.Drawing.Size(128, 20)
        Me.txtJoining.TabIndex = 7
        Me.txtJoining.Text = ""
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(160, 70)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(128, 20)
        Me.txtSalary.TabIndex = 8
        Me.txtSalary.Text = ""
        '
        'txtHouseRent
        '
        Me.txtHouseRent.Location = New System.Drawing.Point(160, 96)
        Me.txtHouseRent.Name = "txtHouseRent"
        Me.txtHouseRent.Size = New System.Drawing.Size(128, 20)
        Me.txtHouseRent.TabIndex = 9
        Me.txtHouseRent.Text = ""
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(160, 130)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(128, 20)
        Me.txtTotal.TabIndex = 10
        Me.txtTotal.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 237)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtTotal, Me.txtHouseRent, Me.txtSalary, Me.txtJoining, Me.txtName, Me.btnTotal, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Lost Focus Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtJoining_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJoining.MouseLeave
        If Not IsDate(txtJoining.Text) Then
            MsgBox("Invalid Date")
            txtJoining.Text = ""
        End If

    End Sub

    Private Sub txtSalary_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalary.MouseLeave
        If Not IsNumeric(txtSalary.Text) Then
            MsgBox("Invalid Salary")
            txtSalary.Text = ""
        End If

    End Sub

    Private Sub txtHouseRent_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHouseRent.Leave
        If Not IsNumeric(txtHouseRent.Text) Then
            MsgBox("Invalid House Rent")
            txtHouseRent.Text = ""
        End If

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim Sal, HRent As Integer
        Sal = Val(txtSalary.Text)
        HRent = Val(txtHouseRent.Text)
        txtTotal.Text = Sal + HRent

    End Sub
End Class
