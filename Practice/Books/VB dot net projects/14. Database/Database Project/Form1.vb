Public Class Form1
    Inherits System.Windows.Forms.Form

    Private m_cnADOConnection As New ADODB.Connection()
    Private m_rstCustomers As New ADODB.Recordset()
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
    Friend WithEvents txtCustNo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPreviues As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddRecord As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCustNo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPreviues = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCustNo
        '
        Me.txtCustNo.Location = New System.Drawing.Point(32, 32)
        Me.txtCustNo.Name = "txtCustNo"
        Me.txtCustNo.TabIndex = 0
        Me.txtCustNo.Text = ""
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(32, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(32, 104)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(208, 20)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.Text = ""
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(32, 144)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(208, 20)
        Me.txtCity.TabIndex = 3
        Me.txtCity.Text = ""
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(32, 184)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(208, 20)
        Me.txtPhone.TabIndex = 4
        Me.txtPhone.Text = ""
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(8, 225)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.TabIndex = 5
        Me.btnFirst.Text = "First Record"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(96, 225)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next Record"
        '
        'btnPreviues
        '
        Me.btnPreviues.Location = New System.Drawing.Point(176, 225)
        Me.btnPreviues.Name = "btnPreviues"
        Me.btnPreviues.Size = New System.Drawing.Size(100, 23)
        Me.btnPreviues.TabIndex = 7
        Me.btnPreviues.Text = "Previous Record"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(280, 225)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.TabIndex = 8
        Me.btnLast.Text = "Last Record"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(320, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(320, 56)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.TabIndex = 10
        Me.btnAddRecord.Text = "New Record"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(320, 96)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 261)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDelete, Me.btnAddRecord, Me.btnSave, Me.btnLast, Me.btnPreviues, Me.btnNext, Me.btnFirst, Me.txtPhone, Me.txtCity, Me.txtAddress, Me.txtName, Me.txtCustNo})
        Me.Name = "Form1"
        Me.Text = "Database Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        m_cnADOConnection.Open("Provider=Microsoft.jet.OLEDB.4.0;" & _
             "Data source = E:\Vb dot net projects\sales.mdb")

        m_rstCustomers.Open("Customers", m_cnADOConnection, _
                ADODB.CursorTypeEnum.adOpenDynamic, _
                ADODB.LockTypeEnum.adLockOptimistic)
        Call showRecord()
    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        m_cnADOConnection.Close()
        'm_rstCustomers.Close()
    End Sub
    Private Sub showRecord()
        If m_rstCustomers.BOF Or m_rstCustomers.EOF Then
            txtCustNo.Text = ""
            txtName.Text = ""
            txtAddress.Text = ""
            txtCity.Text = ""
            txtPhone.Text = ""
        End If
        txtCustNo.Text = m_rstCustomers.Fields("CustNo").Value
        txtName.Text = m_rstCustomers.Fields("Name").Value
        txtAddress.Text = m_rstCustomers.Fields("Address").Value
        txtCity.Text = m_rstCustomers.Fields("City").Value
        txtPhone.Text = m_rstCustomers.Fields("Phone").Value
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        If Not (m_rstCustomers.BOF And m_rstCustomers.EOF) Then
            m_rstCustomers.MoveFirst()
            Call showRecord()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Not (m_rstCustomers.EOF) Then
            m_rstCustomers.MoveNext()
            Call showRecord()
        End If
    End Sub

    Private Sub btnPreviues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviues.Click
        If Not (m_rstCustomers.BOF) Then
            m_rstCustomers.MovePrevious()
            Call showRecord()
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        If Not (m_rstCustomers.BOF And m_rstCustomers.EOF) Then
            m_rstCustomers.MoveLast()
            Call showRecord()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not (m_rstCustomers.BOF And m_rstCustomers.EOF) Then
            m_rstCustomers.Fields("CustNo").Value = txtCustNo.Text
            m_rstCustomers.Fields("Name").Value = txtName.Text
            m_rstCustomers.Fields("Address").Value = txtAddress.Text
            m_rstCustomers.Fields("City").Value = txtCity.Text
            m_rstCustomers.Fields("Phone").Value = txtPhone.Text
            m_rstCustomers.Update()
        End If
    End Sub

    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecord.Click
        m_rstCustomers.AddNew()
        txtCustNo.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtPhone.Text = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Message As String

        If m_rstCustomers.BOF Or m_rstCustomers.EOF Then Exit Sub

        Message = MsgBox("Delete  this Record?", vbQuestion + vbYesNo, "Answer the Question ! ")
        If Message = vbYes Then
            m_rstCustomers.Delete()
            m_rstCustomers.MoveFirst()
            Call showRecord()
        End If
    End Sub
End Class

