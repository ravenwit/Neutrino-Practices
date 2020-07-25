Public Class Form1
    Inherits System.Windows.Forms.Form
    Private m_objGraphics As Graphics
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Name = "Form1"
        Me.Text = "Paint With Mouse"

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_objGraphics = Me.CreateGraphics
    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        m_objGraphics.Dispose()
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Dim recEllipse As Rectangle
        If e.Button <> MouseButtons.Left Then Exit Sub
        With recEllipse
            .X = e.X - 1
            .Y = e.Y - 1
            .Width = 2
            .Height = 2
        End With
eB‡qi mv‡_ mieivnK…Z wW‡¯‹ cÖ‡R±wU Persisting Graphics Example msiY Kiv Av‡Q| e¨enviKvix cÖ‡qvRb‡ev‡a wW¯‹ †_‡K cÖ‡R±wU †jvW K‡i Pvjbv Kiv‡Z cvi‡eb|


        m_objGraphics.DrawEllipse(System.Drawing.Pens.Black, recEllipse)
    End Sub
End Class
