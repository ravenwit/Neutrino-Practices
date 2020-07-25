Public Class Form1
    Dim S1 As String = "Created By Ayman Eldoktor Copyright© 2009         "
    Dim Counter1 As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            For i As Integer = 0 To Google.API.Translate.LanguageUtility.LanguageCollection.Count - 1

                Me.ListBox1.Items.Add(Google.API.Translate.LanguageUtility.LanguageCollection(i))
                Me.ListBox2.Items.Add(Google.API.Translate.LanguageUtility.LanguageCollection(i))
            Next
            Me.ListBox1.Items.RemoveAt(0)
            Me.ListBox2.Items.RemoveAt(0)

            Me.Label6.Text = "You Have  " & Me.ListBox1.Items.Count & "  Language"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.RichTextBox1.Text = Google.API.Translate.Translator.Translate(Me.RichTextBox2.Text, Me.ListBox1.SelectedIndex + 1, Me.ListBox2.SelectedIndex + 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim X1 As Int16
            Dim X2 As Int16

            X1 = Me.ListBox1.SelectedIndex
            X2 = Me.ListBox2.SelectedIndex

            Me.ListBox1.SelectedIndex = X2
            Me.ListBox2.SelectedIndex = X1

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub T1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Tick
        Try
            If Counter1 = S1.Length - 1 Then
                Me.Label5.Text = ""
                Counter1 = 0
            End If
            Label5.Text += S1.Chars(Counter1)
            Counter1 += 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class
