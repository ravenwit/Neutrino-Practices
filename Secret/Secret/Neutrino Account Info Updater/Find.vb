Public Class Find
    Dim SearchModeStr As Microsoft.VisualBasic.CompareMethod
    Dim SearchModeF As Windows.Forms.RichTextBoxFinds
    Dim txtSearchField As TextBox = frmMain.txtEditor

    Private Sub Find_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        If Not txtFind.Text = vbNullString Then
            btnFind.Enabled = True
            btnFindN.Enabled = True
        ElseIf txtFind.Text = vbNullString Then
            btnFind.Enabled = False
            btnFindN.Enabled = False
        End If
        If Not txtReplace.Text = vbNullString Then
            btnReplace.Enabled = True
            btnReplaceA.Enabled = True
        ElseIf txtReplace.Text = vbNullString Then
            btnReplace.Enabled = False
            btnReplaceA.Enabled = False

        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim SelStart As Integer

        SelStart = InStr(frmMain.txtEditor.Text, txtFind.Text, SearchModeStr)
        If SelStart = 0 Then
            MsgBox("Can't Find The Word.", MsgBoxStyle.Information, "Find")
            Exit Sub
        End If
        frmMain.txtEditor.Select(SelStart - 1, txtFind.Text.Length)
        btnFindN.Enabled = True
        frmMain.txtEditor.ScrollToCaret()
    End Sub

    Private Sub chkMC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMC.CheckedChanged
        If chkMC.Checked = True Then
            SearchModeStr = CompareMethod.Binary
        ElseIf chkMC.Checked = False Then
            SearchModeStr = CompareMethod.Text
        End If
    End Sub

    Private Sub chkWW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWW.CheckedChanged
        If chkWW.Checked = True Then
            SearchModeF = RichTextBoxFinds.WholeWord
        ElseIf chkWW.Checked = False Then
            SearchModeF = RichTextBoxFinds.None
        End If
    End Sub

    Private Sub btnFindN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindN.Click
        Dim SelStart As Integer

        SelStart = InStr(frmMain.txtEditor.SelectionStart + 2, frmMain.txtEditor.Text, txtFind.Text, SearchModeStr)
        If SelStart = 0 Then
            MsgBox("No More Matches.", MsgBoxStyle.Information, "Find")
            Exit Sub
        End If

        frmMain.txtEditor.Select(SelStart - 1, txtFind.Text.Length)
        frmMain.txtEditor.ScrollToCaret()

    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        If frmMain.txtEditor.SelectedText <> vbNullString Then
            frmMain.txtEditor.SelectedText = txtReplace.Text
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReplace.TextChanged
        If Not txtReplace.Text = vbNullString Then
            btnReplace.Enabled = True
            btnReplaceA.Enabled = True
        ElseIf txtReplace.Text = vbNullString Then
            btnReplace.Enabled = False
            btnReplaceA.Enabled = False

        End If
    End Sub

    Private Sub btnReplaceA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceA.Click
        Dim SelStart, SelLength As Integer
        SelStart = frmMain.txtEditor.SelectionStart
        SelLength = frmMain.txtEditor.SelectionLength

        frmMain.txtEditor.Text = Replace(frmMain.txtEditor.Text, Trim(txtFind.Text), Trim(txtReplace.Text))
        frmMain.txtEditor.SelectionStart = SelStart
        frmMain.txtEditor.SelectionLength = SelLength
    End Sub
End Class