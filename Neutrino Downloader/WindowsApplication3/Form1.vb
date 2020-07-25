Imports System.Net
Imports System.IO

Public Class Form1
    Public link As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        File.Delete("F:\test.html")
        link = TextBox1.Text
        Dim size As Integer
        Dim works As WebRequest
        works = WebRequest.Create(link)
        Dim webr As WebResponse = works.GetResponse
        size = webr.ContentLength
        size = size / 1024
        ProgressBar1.Maximum = size
        

        Dim wc As New WebClient
        wc.DownloadFile(link, "F:\test.html")
        Exit Sub
err:
        MsgBox("Error!")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim amount As Integer
        If System.IO.File.Exists("F:\test.html") Then
            Dim o As New System.IO.FileInfo("F:\test.html")
            amount = o.Length
            amount = amount / 1024
            ProgressBar1.Value = amount

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("done!")

    End Sub
End Class
