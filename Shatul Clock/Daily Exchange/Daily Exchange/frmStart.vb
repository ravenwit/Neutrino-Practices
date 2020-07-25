Imports System.Drawing.Drawing2D
Imports DevComponents

Public Class frmStart
    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const HTCAPTION As Integer = 2

    Private Declare Function ReleaseCapture Lib "user32.dll" () As Integer
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageW" (hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    Private Function ApplyGeneralStyle(ByVal Container As DevComponents.DotNetBar.ItemContainer) As String
        On Error Resume Next
        With Container.BackgroundStyle
            .BackColor = Color.Snow
            .BackColor2 = Color.GhostWhite
            .BackColorGradientAngle = 90
            .BackColorGradientType = DotNetBar.eGradientType.Radial
            .CornerType = DotNetBar.eCornerType.Square
        End With
        Return Nothing
    End Function
    Private Function ApplyHoverStyle(ByVal Container As DevComponents.DotNetBar.ItemContainer) As String
        On Error Resume Next
        With Container.BackgroundStyle
            .BackColor = Color.Silver
            .BackColor2 = Color.Gainsboro
            .BackColorGradientAngle = 90
            .BackColorGradientType = DotNetBar.eGradientType.Radial
            .CornerType = DotNetBar.eCornerType.Square
        End With
        Return Nothing
    End Function

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.Activate()


        ' Form Setup
        With Me.pnlAddNewExchange
            .Location = New Point(0, 62)
            .Size = New Size(1064, 433)
            .Visible = False
            .Anchor = Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        End With
        With Me.SlidePanel1
            .Location = New Point(0, 62)
            .Size = New Size(1064, 433)
            .SlideSide = DotNetBar.Controls.eSlideSide.Right
            .SlideOutButtonVisible = True
            .AnimationTime = 3000
            .Visible = True
            .IsOpen = True
            .Dock = DockStyle.Bottom
        End With

    End Sub

    Private Sub frmStart_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, TileControl1.MouseDown, lblTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
    Private Sub btnAccount_MouseHover(sender As Object, e As EventArgs) Handles btnAccount.MouseMove
        ApplyHoverStyle(itmContainerAccount)
    End Sub

    Private Sub btnAccount_MouseLeave(sender As Object, e As EventArgs) Handles btnAccount.MouseLeave
        ApplyGeneralStyle(itmContainerAccount)
    End Sub
    Private Sub btnSignOut_MouseHover(sender As Object, e As EventArgs) Handles btnSignOut.MouseMove
        ApplyHoverStyle(itmContainerSignOut)
    End Sub

    Private Sub btnSignOut_MouseLeave(sender As Object, e As EventArgs) Handles btnSignOut.MouseLeave
        ApplyGeneralStyle(itmContainerSignOut)
    End Sub

    Private Sub btnQuit_MouseHover(sender As Object, e As EventArgs) Handles btnQuit.MouseMove
        ApplyHoverStyle(itmContainerQuit)
    End Sub

    Private Sub btnQuit_MouseLeave(sender As Object, e As EventArgs) Handles btnQuit.MouseLeave
        ApplyGeneralStyle(itmContainerQuit)
    End Sub

    Private Sub TileItemAddNewExchange_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItemAddNewExchange.ItemClick
        pnlAddNewExchange.Visible = True
        SlidePanel1.IsOpen = False
        SlidePanel1.SlideOutButtonVisible = False
        MsgBox("kju)")
    End Sub

    Private Sub TileItemAddNewExchange_ItemPress(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItemAddNewExchange.ItemPress
       
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pnlAddNewExchange.Visible = False
        SlidePanel1.IsOpen = True
        SlidePanel1.SlideOutButtonVisible = True
    End Sub

    Private Sub btnQuit_MouseHover(sender As Object, e As MouseEventArgs) Handles btnQuit.MouseMove

    End Sub
    Private Sub btnSignOut_MouseHover(sender As Object, e As MouseEventArgs) Handles btnSignOut.MouseMove

    End Sub
    Private Sub btnAccount_MouseHover(sender As Object, e As MouseEventArgs) Handles btnAccount.MouseMove

    End Sub
End Class