Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Shell("C:\Programme Files\Screen Capture\Screen Capture.bat", AppWinStyle.Hide)
    End Sub
End Class
