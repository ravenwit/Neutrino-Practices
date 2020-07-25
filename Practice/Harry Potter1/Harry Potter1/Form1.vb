Public Class frmHarryPotter

    Private Sub frmHarryPotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Shell("C:\Windows\explorer.exe \F:\Harry Potter", AppWinStyle.MaximizedFocus)

    End Sub
End Class
