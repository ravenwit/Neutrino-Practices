Imports System
Imports System.IO

Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.OpenFileDialog1.FileName
        Try
            FileSystem.Unlock(Form1.OpenFileDialog1.FileName)
            FileSystem.Kill(Form1.OpenFileDialog1.FileName)
            File.Delete(Form1.OpenFileDialog1.FileName)
            File.Delete(TextBox1.Text)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FileSystem.Unlock(Form1.OpenFileDialog1.FileName)
        FileSystem.Kill(Form1.OpenFileDialog1.FileName)
        File.Delete(Form1.OpenFileDialog1.FileName)
        File.Delete(TextBox1.Text)
        Me.Close()
    End Sub
End Class