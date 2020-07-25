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
    Friend WithEvents btnAutomateExcel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnAutomateExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAutomateExcel
        '
        Me.btnAutomateExcel.Location = New System.Drawing.Point(96, 130)
        Me.btnAutomateExcel.Name = "btnAutomateExcel"
        Me.btnAutomateExcel.Size = New System.Drawing.Size(105, 25)
        Me.btnAutomateExcel.TabIndex = 0
        Me.btnAutomateExcel.Text = "Automate Excel"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAutomateExcel})
        Me.Name = "Form1"
        Me.Text = "Automate Excel Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAutomateExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutomateExcel.Click
        Dim objExcel As New Excel.Application()
        objExcel.Visible = True
        objExcel.Workbooks.Add()

        objExcel.Range("A1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "500"
        objExcel.Range("B1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "200"
        objExcel.Range("c1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "225"
        objExcel.Range("D1").Select()
        objExcel.ActiveCell.FormulaR1C1 = "110"

        objExcel.Range("A1:D1").Select()
        objExcel.Range("E1").Activate()
        objExcel.ActiveCell.FormulaR1C1 = "=SUM(RC[ -4 ]: RC [ -1] )"

        objExcel.Range("A1:E1").Select()
        objExcel.Selection.Font.Bold = True

        objExcel = Nothing

    End Sub
End Class
