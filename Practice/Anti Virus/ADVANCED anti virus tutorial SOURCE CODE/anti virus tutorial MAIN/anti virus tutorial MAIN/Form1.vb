Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Windows.Forms
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        TabControl1.SelectTab(1)
        Try
            For Each strDir As String In
            System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

                For Each strFile As String In System.IO.Directory.GetFiles(strDir)

                    ListBox1.Items.Add(strFile)

                Next

            Next
        Catch ex As Exception
        End Try

        Timer1.Start()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FolderBrowserDialog1.SelectedPath = ("C:/")

        Try
            For Each strDir As String In
            System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)

                For Each strFile As String In System.IO.Directory.GetFiles(strDir)

                    ListBox1.Items.Add(strFile)

                Next

            Next
        Catch ex As Exception
        End Try

        Timer1.Start()
    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        Try
            Labellastreal.Text = e.FullPath
            ListBox3.Items.Add(Labellastreal.Text)
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            f.Close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                Form2.ShowDialog()

            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Try
            Labellastreal.Text = e.FullPath
            ListBox3.Items.Add(Labellastreal.Text)
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            f.Close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                Form2.ShowDialog()

            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Renamed(ByVal sender As System.Object, ByVal e As System.IO.RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        Try
            Labellastreal.Text = e.FullPath
            ListBox3.Items.Add(Labellastreal.Text)
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            f.Close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                Form2.ShowDialog()

            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FileSystemWatcher1.EnableRaisingEvents = True
        realtime.Text = "Real-time Enabled"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FileSystemWatcher1.EnableRaisingEvents = False
        realtime.Text = "Real-time Disabled"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Kill(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)



            MsgBox("Threat Was Removed Successfully!", MsgBoxStyle.Information)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            If Not ListBox2.Items.Count = 0 Then
                ListBox2.SelectedIndex += 1
                Kill(ListBox1.SelectedItem)
                ListBox2.Items.Remove(ListBox2.SelectedItem)
            Else
                Timer1.Stop()
                Timer2.Stop()

                MsgBox("Threat Was Removed Successfully!", MsgBoxStyle.Information)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Maximum = Conversions.ToString(ListBox1.Items.Count)
        total.Text = Conversions.ToString(ListBox1.Items.Count)

        If Not ProgressBar1.Value = ProgressBar1.Maximum Then
            Try

                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                TextBox1.Text = ListBox1.SelectedItem.ToString
            Catch ex As Exception
            End Try



            Try

                Dim scanbox As New TextBox
                Dim read As String = My.Computer.FileSystem.ReadAllText("viruslist.txt")
                ProgressBar1.Increment(1)
                detected.Text = Conversions.ToString(ListBox2.Items.Count)
                files.Text = Conversions.ToString(ProgressBar1.Value)
                scanbox.Text = read.ToString
                Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
                Dim f As FileStream = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next

                If scanbox.Text.Contains(buff.ToString) Then



                    ListBox2.Items.Add(ListBox1.SelectedItem)
                End If
            Catch ex As Exception
            End Try
        Else
            Timer1.Stop()
            MsgBox("Finished Scanning Folder!")
            TabControl1.SelectTab(3)
            If ListBox1.Items.Count = 0 Then
                MsgBox("No Threats were detected, Scan Window will close!", MsgBoxStyle.Information)

            End If
        End If
    End Sub
End Class
