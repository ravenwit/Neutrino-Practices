Imports Encryption
Public Class Form1
    Dim crypto As New Crypt("", 0)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 12
            ComboBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        crypto.UpdateKeyShift(txtKey.Text, Val(txtShift.Text))
        plaintext.Text = crypto.Encrypt(plaintext.Text, Val(ComboBox1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        crypto.UpdateKeyShift(txtKey.Text, Val(txtShift.Text))
        plaintext.Text = crypto.Decrypt(plaintext.Text, Val(ComboBox1.Text))
    End Sub
End Class
