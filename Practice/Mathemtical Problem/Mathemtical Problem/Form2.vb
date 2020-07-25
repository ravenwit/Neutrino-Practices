Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim set_1 As New SortedList
        With set_1
            .Add(1, 15)
            .Add(2, 22)
            .Add(3, 31)
            .Add(4, 45)
            .Add(5, 56)
            .Add(6, 67)
            .Add(7, 79)

        End With
        solveit()



    End Sub
    Private Function solveit() As Integer
        Dim way As Integer = 0
        Dim sumway As Integer = 0

        Dim set_1 As New SortedList
        Dim set_2 As New SortedList
        Dim set_3 As New SortedList
        Dim set_4 As New SortedList
        Dim sum
        '''''input

        With set_1
            .Add(1, 15)
            .Add(2, 22)
            .Add(3, 31)
            .Add(4, 45)
            .Add(5, 56)
            .Add(6, 67)
            .Add(7, 79)

        End With

        With set_2
            .Add(1, 2)
            .Add(2, 3)
            .Add(3, 5)
            .Add(4, 6)
            .Add(5, 7)
            .Add(6, 9)
            .Add(7, 12)
            .Add(8, 94)

        End With

        With set_3
            .Add(1, 14)
            .Add(2, 21)
            .Add(3, 31)
            .Add(4, 40)
            .Add(5, 53)
            .Add(6, 62)
            .Add(7, 78)
            .Add(8, 81)
            .Add(9, 90)

        End With

        With set_4
            .Add(1, 11)
            .Add(2, 12)
            .Add(3, 17)
            .Add(4, 23)
            .Add(5, 54)
            .Add(6, 55)
            .Add(7, 62)
            .Add(8, 98)
            .Add(9, 110)
            .Add(10, 111)
        End With
        '''end input

        For i = 0 To set_1.Count - 1
            For j = 0 To set_2.Count - 1
                For k = 0 To set_3.Count - 1
                    For l = 0 To set_4.Count - 1
                        sum = set_1.GetByIndex(i) + set_2.GetByIndex(j) + set_3.GetByIndex(k) + set_4.GetByIndex(l)
                        sumway += 1

                        txtAllSUm.Text = txtAllSUm.Text & vbCrLf & "[" & sumway & "]  " & set_1.GetByIndex(i) & " + " & set_2.GetByIndex(j) & " + " & set_3.GetByIndex(k) & " + " & set_4.GetByIndex(l) & " =" & sum

                        If sum / 8 = Math.Truncate(sum / 8) Then

                            way += 1
                            txtSelSum.Text = txtSelSum.Text & vbCrLf & "[" & way & "]  " & set_1.GetByIndex(i) & " + " & set_2.GetByIndex(j) & " + " & set_3.GetByIndex(k) & " + " & set_4.GetByIndex(l) & " =" & sum


                        End If

                    Next
                Next
            Next
        Next
        txtCountAllSum.Text = sumway
        txtCountSelSum.Text = way

        Return way



    End Function


    
End Class
