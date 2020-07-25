Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count = 0
        Dim countes = 0

        For i = 1 To 10
            For j = 1 To 10
                For k = 1 To 10
                    'TextBox1.AppendText(vbCrLf & i & "---" & j & "---" & k & "---    " & ((j + k) / i) & "     " & ((j / i) + (k / i)))
                    If Val(((j + k) / i)) <> Val(((j / i) + (k / i))) Then
                        TextBox1.AppendText(vbCrLf & i & "---" & j & "---" & k & "---    " & ((j + k) / i) & "     " & ((j / i) + (k / i)))
                    End If
                    ' countes += 1
                    If Val(((j + k) / i)) = Val(((j / i) + (k / i))) Then
                        count += 1

                    End If

                    'Val((i / (j + k))) = Val(((i / j) + (i / k)))
                    'Val(((j + k) / i)) = Val(((j / i) + (k / i)))
                Next
            Next
        Next
        TextBox2.Text = count.ToString
    End Sub
End Class
