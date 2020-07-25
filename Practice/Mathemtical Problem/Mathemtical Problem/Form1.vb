Imports System.String
Imports System.Text

Public Class Form1


    Dim WithEvents hg As New Button

    Private Sub CreteInterface()

        hg.Text = "Solve"
        hg.Size = New Size(150, 150)
        Me.Controls.Add(hg)
        hg.Location = New Point(Me.Width / 2, Me.Height / 2)
        hg.Visible = True
        hg.Show()
    End Sub
    Private Function Solve() As Integer

        Dim i, k, j As Integer
        j = 0
        Dim v
        Dim f
        For i = 1 To 1000

            v = i / 9
            If v = Math.Truncate(v) Then
                f = i / 6
                If f = Math.Truncate(f) Then
                    j += 1
                End If
            End If
        Next

        Return j
    End Function

    Private Function solveagain() As Integer
        Dim f = 6 ^ 20
        Dim gh As String = f

        Return (Len(gh))
    End Function


    Private Sub gfclick(sender As Object, e As EventArgs) Handles hg.Click
        MsgBox(Solve)

    End Sub

    Private Function OperationM(ByVal a As Double, ByVal b As Double) As Double
        Dim res As Double = Nothing
        res = a * b - 4 * (a + b) + 20
        Return res
    End Function

    Private Sub DOOP() Handles Button1.Click

        Static b
        Static res = 1
        For i As Integer = 1 To 19
            b = i + 1
            res = OperationM(res, Math.Sqrt(b))
        Next
        MsgBox(res)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreteInterface()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(solveagain())

    End Sub

    Private Sub DOOP(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Static reyu = 1
        For k As Integer = 1 To 99999
            reyu = reyu + (1 / reyu)

        Next
        MsgBox(reyu)
        reyu = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Static uh
        Static yh
        For h As Integer = 0 To 9
            For d As Integer = 0 To 9
                If (h + d) / 3 = Math.Truncate((h + d) / 3) Then
                    uh += 1
                    If h = d Then yh += 1
                End If
            Next
        Next
        MsgBox(uh)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox(solveit)

    End Sub

    Private Function solveit() As Integer
        Dim way As Integer = 0

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

        For i = 1 To set_1.Count
            For j = 1 To set_2.Count
                For k = 1 To set_3.Count
                    For l = 1 To set_4.Count
                        sum = set_1.GetByIndex(set_1.IndexOfKey(i)) + set_2.GetByIndex(set_2.IndexOfKey(j)) + set_3.GetByIndex(set_3.IndexOfKey(k)) + set_4.GetByIndex(set_4.IndexOfKey(l))

                        If sum / 8 = Math.Truncate(sum / 8) Then way += 1
                    Next
                Next
            Next
        Next


        Return way

    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        MsgBox(SolveItNow)


    End Sub

    Private Function SolveItNow() As Integer
        Dim res As Integer = 0
        Dim nk As Integer = 0

        For i = 1 To 2013
            nk = i
            For j = 1 To 9
                nk = FindDigitSum(nk)

            Next
            If nk.ToString.Contains(9) Then res += 1

        Next


        Return res


    End Function

    Private Function FindDigitSum(ByVal Number As Integer) As Integer
        Dim DigitSum As Integer = 0
        Dim numberstring = CStr(Number)
        For i = 1 To numberstring.Length
            DigitSum += Mid(numberstring, i, 1)

        Next

        Return DigitSum

    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DoOperationAlge()

    End Sub
    Sub DoOperationAlge()
        Dim res = 0
        Dim i As Integer
        For i = -5 To 5
            For j = -5 To 5
                res = i * (i - 4) - 2 * j * (i - j)
                txtList.Text = txtList.Text & vbCrLf & res
            Next
        Next

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cookies = 100
        cookies = cookies + 1
        cookies = cookies - 1
        For i = 0 To 88
            cookies = cookies + 1
            cookies = cookies - 1
            cookies = cookies - 1
        Next
        MsgBox(cookies)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Result.Text = Val(Number1.Text) + Val(Number2.Text)

    End Sub
End Class
