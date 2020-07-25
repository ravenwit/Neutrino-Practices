Imports System.Runtime.InteropServices
Public Class Form1
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    <StructLayout(LayoutKind.Sequential)>
    Public Structure MARGINS
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim margins As MARGINS = New MARGINS
        margins.Left = -1
        margins.Right = -1
        margins.Top = -1
        margins.Bottom = -1
        Dim hwnd As IntPtr = Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)

    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer
        If e.Button = MouseButtons.Left Then
            xOffset = -e.X - SystemInformation.FrameBorderSize.Width
            yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        ' Changes the isMouseDown field so that the form does
        ' not move unless the user is pressing the left mouse button.
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub
End Class
