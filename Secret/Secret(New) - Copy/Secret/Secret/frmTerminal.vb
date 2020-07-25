#Region "Imports"
Imports System.IO
Imports System.Management
Imports DevComponents.DotNetBar
Imports System.Drawing.Drawing2D
#End Region

Public Class frmTerminal

#Region "Declaration"

#End Region

#Region "System Essentials"

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Protected Overrides ReadOnly Property Createparams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_INCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_INCLOSE
            Return cp
        End Get
    End Property

#End Region

#Region "Custom Objects"
    Private Sub CreateTerminal()
        System.Windows.Forms.Cursor.Hide()
        With Me
            .Activate()
            .ControlBox = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            .TopMost = True
            .BackColor = Color.Black
            .Font = My.Settings.MainFont
            .ForeColor = My.Settings.MainForecolor
            .lblTime.Location = New Point(1170, 32)
            .lblTime.Text = (Now.TimeOfDay).ToString
            .lblDate.Location = New Point(24, 32)
            .lblDate.Text = Now.Date

            .tmrTerminal.Enabled = True
            .tmrTerminal.Interval = 10
        End With
    End Sub
#End Region

#Region "Form Componenets"
    Private Sub frmTerminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

End Class