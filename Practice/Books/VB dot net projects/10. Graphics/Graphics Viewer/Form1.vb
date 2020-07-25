Public Class frmViewer
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
    Friend WithEvents btnSelectPicture As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents PicShowPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ofdSelectPicture As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSelectPicture = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PicShowPicture = New System.Windows.Forms.PictureBox()
        Me.ofdSelectPicture = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Location = New System.Drawing.Point(24, 296)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(90, 25)
        Me.btnSelectPicture.TabIndex = 0
        Me.btnSelectPicture.Text = "Select Picture"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(160, 296)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 25)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        '
        'PicShowPicture
        '
        Me.PicShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicShowPicture.Location = New System.Drawing.Point(8, 8)
        Me.PicShowPicture.Name = "PicShowPicture"
        Me.PicShowPicture.Size = New System.Drawing.Size(282, 275)
        Me.PicShowPicture.TabIndex = 2
        Me.PicShowPicture.TabStop = False
        '
        'ofdSelectPicture
        '
        Me.ofdSelectPicture.Filter = "Windows Bitmaps|*.BMP| JPEG Files|*.JPG"
        Me.ofdSelectPicture.Title = "Select Picture"
        '
        'frmViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PicShowPicture, Me.btnQuit, Me.btnSelectPicture})
        Me.Name = "frmViewer"
        Me.Text = "Picture Viewer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSelectPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPicture.Click
        'Show the Open File Dialog Box
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            'Load the Picture into picture Box.
            PicShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' Show the name of the file in the Form Caption.
            Me.Text = "Picture Viewer(" & ofdSelectPicture.FileName & ")"
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
