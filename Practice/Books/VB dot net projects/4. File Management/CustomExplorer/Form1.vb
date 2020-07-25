Option Strict On
Imports System.IO
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
    Friend WithEvents DrivesList As System.Windows.Forms.ComboBox
    Friend WithEvents FoldersList As System.Windows.Forms.ListBox
    Friend WithEvents FilesList As System.Windows.Forms.ListBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.FoldersList = New System.Windows.Forms.ListBox()
        Me.FilesList = New System.Windows.Forms.ListBox()
        Me.DrivesList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'FoldersList
        '
        Me.FoldersList.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.FoldersList.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoldersList.ItemHeight = 14
        Me.FoldersList.Location = New System.Drawing.Point(8, 36)
        Me.FoldersList.Name = "FoldersList"
        Me.FoldersList.Size = New System.Drawing.Size(216, 172)
        Me.FoldersList.TabIndex = 1
        '
        'FilesList
        '
        Me.FilesList.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.FilesList.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilesList.ItemHeight = 14
        Me.FilesList.Location = New System.Drawing.Point(232, 36)
        Me.FilesList.Name = "FilesList"
        Me.FilesList.Size = New System.Drawing.Size(272, 172)
        Me.FilesList.TabIndex = 2
        '
        'DrivesList
        '
        Me.DrivesList.DropDownWidth = 232
        Me.DrivesList.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrivesList.Location = New System.Drawing.Point(8, 8)
        Me.DrivesList.Name = "DrivesList"
        Me.DrivesList.Size = New System.Drawing.Size(112, 22)
        Me.DrivesList.TabIndex = 0
        Me.DrivesList.Text = "ComboBox1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 213)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.FilesList, Me.FoldersList, Me.DrivesList})
        Me.Name = "Form1"
        Me.Text = "Custom Explorer Project"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) _
                        Handles MyBase.Load
        ShowAllDrives()
        DrivesList.SelectedIndex = 1
        Me.Text = Directory.GetCurrentDirectory
    End Sub

    Sub ShowAllDrives()
        Dim drives() As String
        drives = Directory.GetLogicalDrives()
        Dim aDrive As String
        DrivesList.Items.Clear()
        For Each aDrive In drives
            DrivesList.Items.Add(aDrive)
        Next
    End Sub

    Sub ShowFoldersInDrive(ByVal drive As String)
        Dim folders() As String
        Try
            folders = Directory.GetDirectories(drive)
        Catch exception As Exception
            MsgBox(exception.Message)
            Exit Sub
        End Try

        Dim fldr As String
        FoldersList.Items.Clear()
        Dim DI As DirectoryInfo
        For Each fldr In folders
            DI = New DirectoryInfo(fldr)
            FoldersList.Items.Add(DI.Name)
        Next
        Directory.SetCurrentDirectory(drive)
        Me.Text = Directory.GetCurrentDirectory
    End Sub

    Sub ShowFilesInFolder()
        Dim file As String
        Dim FI As FileInfo
        FilesList.Items.Clear()
        For Each file In Directory.GetFiles(Directory.GetCurrentDirectory)
            FI = New FileInfo(file)
            FilesList.Items.Add(FI.Name)
        Next
    End Sub

    Private Sub DrivesList_SelectedIndexChanged(ByVal sender As System.Object, _
                                                ByVal e As System.EventArgs) _
                                                Handles DrivesList.SelectedIndexChanged
        ShowFoldersInDrive(DrivesList.Text)
    End Sub

    Private Sub FoldersList_SelectedIndexChanged(ByVal sender As System.Object, _
                                                 ByVal e As System.EventArgs) _
                                                 Handles FoldersList.SelectedIndexChanged

        Dim DI As DirectoryInfo
        Select Case FoldersList.Text
            Case ""
                MsgBox("Please select a folder to expand")
                Exit Sub
            Case ".."
                Directory.SetCurrentDirectory("..")
            Case Else
                Directory.SetCurrentDirectory(Directory.GetCurrentDirectory & _
                             "\" & FoldersList.Text)
                Me.Text = Directory.GetCurrentDirectory
        End Select
        Dim folders() As String
        Dim selectedFolder As String = FoldersList.Text
        folders = Directory.GetDirectories(Directory.GetCurrentDirectory)
        FoldersList.Items.Clear()
        If Directory.GetCurrentDirectory <> _
                             Directory.GetDirectoryRoot(selectedFolder) Then _
            FoldersList.Items.Add("..")
        Dim fldr As String
        For Each fldr In folders
            DI = New DirectoryInfo(fldr)
            FoldersList.Items.Add(DI.Name)
        Next
        ShowFilesInFolder()
    End Sub

    Private Sub FilesList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilesList.SelectedIndexChanged
        Dim selectedFile As String = FilesList.Text
        Dim FI As New FileInfo(Directory.GetCurrentDirectory & "\" & selectedFile)
        Console.WriteLine(FI.Name)
        Console.WriteLine("   LENGTH      " & _
                    FI.Length.ToString)
        Console.WriteLine("   EXTENSION   " & _
                    FI.Extension)
        Console.WriteLine("   CREATED     " & _
                    FI.CreationTime)
        Console.WriteLine("   ACCESSED    " & _
                    FI.LastAccessTime.ToShortDateString)
        If (FI.Attributes And FileAttributes.Normal) > 0 Then
            Console.Write(" NORMAL FILE ")
            Exit Sub
        End If
        Console.Write("   ATTRIBUTES ")
        If (FI.Attributes And FileAttributes.Archive) > 0 Then _
                    Console.Write(" Archive ")

        If (FI.Attributes And FileAttributes.Compressed) > 0 Then _
                Console.Write(" Compressed ")
        If (FI.Attributes And FileAttributes.Directory) > 0 Then _
                    Console.Write(" Directory ")
        If (FI.Attributes And FileAttributes.Encrypted) > 0 Then _
                    Console.Write(" Encrypted ")
        If (FI.Attributes And FileAttributes.Hidden) > 0 Then _
                    Console.Write(" Hidden ")
        If (FI.Attributes And FileAttributes.NotContentIndexed) > 0 Then _
                Console.Write(" Not Indexed ")
        If (FI.Attributes And FileAttributes.Offline) > 0 Then _
                    Console.Write(" OffLine ")
        If (FI.Attributes And FileAttributes.ReadOnly) > 0 Then _
                Console.Write(" ReadOnly ")
        If (FI.Attributes And FileAttributes.System) > 0 Then _
                Console.Write(" System ")
        If (FI.Attributes And FileAttributes.Temporary) > 0 Then _
                Console.Write(" Temp File ")
        Console.WriteLine()
    End Sub

End Class
