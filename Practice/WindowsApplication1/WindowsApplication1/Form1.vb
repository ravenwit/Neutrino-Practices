Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim diff As Integer

        DateCalc(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        Label1.Text = years
        Label2.Text = months
        Label3.Text = days

    End Sub
End Class
