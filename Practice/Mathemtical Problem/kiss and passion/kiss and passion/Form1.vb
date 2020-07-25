Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num
        For i = 1 To 9
            For j = 0 To 9
                For k = 0 To 9
                    num = 1000 * i + 100 * j + 10 * k + k
                    If i <> j And j <> k Then
                        If (num * num).ToString.Length = 7 Then
                            If (num * num).ToString.Substring(2, 2) = (k & k).ToString And (num * num).ToString.Substring(4, 1) = j.ToString Then
                                TextBox3.AppendText(vbNewLine & num & "------" & num * num)
                            End If
                        End If
                    End If
                   
                    'TextBox1.AppendText(vbNewLine & num)
                    'TextBox2.AppendText(vbNewLine & num * num)
                Next
            Next
        Next

    End Sub
End Class
