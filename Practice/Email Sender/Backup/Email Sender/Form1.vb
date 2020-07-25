Imports System.Net.Mail

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim t0, subject, username, password, body, server, attach, portnumber As String
            t0 = TextBox2.Text
            portnumber = TextBox8.Text
            attach = TextBox7.Text
            subject = TextBox1.Text
            username = TextBox4.Text
            password = TextBox5.Text
            body = TextBox3.Text
            server = TextBox6.Text
            Dim smtpserver As New SmtpClient()
            Dim mail As New MailMessage()
            Dim mailat As New Attachment(attach)
            smtpserver.Credentials = New Net.NetworkCredential(username, password)
            smtpserver.Port = portnumber
            smtpserver.Host = server
            smtpserver.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress(username)
            mail.To.Add(t0)
            mail.Subject = subject
            mail.Attachments.Add(mailat)
            mail.Body = body
            smtpserver.Send(mail)
            MsgBox("Message Sent Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Smtp Error: You supplied incorrect information, please check supplied information.", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Smtp_Help.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim open As New OpenFileDialog()
            open.Title = "Choose A File To Attach"
            open.ShowDialog()
            TextBox7.Text = open.FileName
        Catch ex As Exception
            MsgBox("Error Processing Attachment")
        End Try
    End Sub

End Class
