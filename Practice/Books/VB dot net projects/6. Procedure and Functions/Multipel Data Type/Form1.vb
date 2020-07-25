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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblJoining As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblJoining = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Country"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Balance"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Company"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Joining date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(376, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Next Record"
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(128, 64)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(264, 23)
        Me.lblAddress.TabIndex = 1
        '
        'lblCompany
        '
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(128, 16)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(224, 23)
        Me.lblCompany.TabIndex = 1
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountry.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(128, 112)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(160, 23)
        Me.lblCountry.TabIndex = 1
        '
        'lblCity
        '
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCity.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(128, 88)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(144, 23)
        Me.lblCity.TabIndex = 1
        '
        'lblJoining
        '
        Me.lblJoining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJoining.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoining.Location = New System.Drawing.Point(128, 40)
        Me.lblJoining.Name = "lblJoining"
        Me.lblJoining.Size = New System.Drawing.Size(104, 23)
        Me.lblJoining.TabIndex = 1
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBalance.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(128, 136)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(104, 23)
        Me.lblBalance.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 221)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblBalance, Me.lblCountry, Me.lblCity, Me.lblAddress, Me.lblJoining, Me.lblCompany, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "Multiple Data Type"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Structure Customer
        Dim Company As String
        Dim Manager As String
        Dim Address As String
        Dim City As String
        Dim Country As String
        Dim CustomerSince As Date
        Dim Balance As Decimal
    End Structure
    Private Customers(8) As Customer
    Private cust As Customer
    Private currentIndex As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If currentIndex = CountCustomers() Then currentIndex = 0

        Dim aCustomer As Customer
        aCustomer = GetCustomer(currentIndex)
        ShowCustomer(currentIndex)
        currentIndex = currentIndex + 1
    End Sub

    Function CountCustomers() As Integer
        Return (Customers.Length)
    End Function

    Function GetCustomer(ByVal idx As Integer) As Customer
        Return (Customers(idx))
    End Function

    Sub ShowCustomer(ByVal idx As Integer)
        Dim aCustomer As Customer
        aCustomer = GetCustomer(idx)
        lblCompany.Text = aCustomer.Company
        lblJoining.Text = aCustomer.CustomerSince
        lblAddress.Text = aCustomer.Address
        lblCity.Text = aCustomer.City
        lblCountry.Text = aCustomer.Country
        lblBalance.Text = aCustomer.Balance
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cust As Customer
        cust.Company = "Computer Lireracy House"
        cust.Manager = "A.R.Khan"
        cust.Address = "23 Middle Paikpara."
        cust.City = "Mirpur"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #10/20/2003#
        cust.Balance = 33500
        Customers(0) = cust

        cust = New Customer()
        cust.Company = "Sky Shope"
        cust.Manager = "Mahmud Ahmed"
        cust.Address = "21 Kakali Road "
        cust.City = "Barguna"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #1/2/2002#
        cust.Balance = 2400
        Customers(1) = cust

        cust = New Customer()
        cust.Company = "Media Agency"
        cust.Manager = "Babui Khan "
        cust.Address = "42 Bibichini"
        cust.City = "Barisal"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #12/22/2001#
        cust.Balance = 300
        Customers(2) = cust

        cust = New Customer()
        cust.Company = "Great Hill Corporationt"
        cust.Manager = "Zawad Rahman"
        cust.Address = "27  Niamati."
        cust.City = "Bakergonj"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #1/3/2002#
        cust.Balance = 6500
        Customers(3) = cust

        cust = New Customer()
        cust.Company = "Icom Corporation"
        cust.Manager = "Sadia Anjum"
        cust.Address = "31/16-B Middle Paikpara"
        cust.City = "Dhaka"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #1/1/0200#
        cust.Balance = 23400
        Customers(4) = cust

        cust = New Customer()
        cust.Company = "Titas Telecom"
        cust.Manager = "Mahaboob Ali"
        cust.Address = "63 Zigatola."
        cust.City = "Dhaka"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #1/1/2001#
        cust.Balance = 23400
        Customers(5) = cust

        cust = New Customer()
        cust.Company = "Com[uter Media Ltd"
        cust.Manager = "Karl Jablonski"
        cust.Address = "305  South Avenue"
        cust.City = "Comilla"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #5/11/2002#
        cust.Balance = 12000
        Customers(6) = cust

        cust = New Customer()
        cust.Company = "Progati Publications"
        cust.Manager = "Mukti Mamun"
        cust.Address = "45 Fultala "
        cust.City = "Barguna"
        cust.Country = "Bangladesh"
        cust.CustomerSince = #1/3/2002#
        cust.Balance = 2500
        Customers(7) = cust

        Button1_Click(sender, e)
    End Sub
End Class
