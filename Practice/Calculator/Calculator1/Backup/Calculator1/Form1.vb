
Public Class Form1
    Dim opperan As String = ""
    Dim value1 As Double = 0
    Dim value2 As Double = 0
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        TextBox1.Text += "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub Btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnplus.Click
        opperan = "+"

        If CInt(True) Then value1 = CDbl(TextBox1.Text)
        Label2.Text = "+"
        TextBox1.Clear()
    End Sub

    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminus.Click
        opperan = "-"

        If CInt(True) Then value1 = CDbl(TextBox1.Text)
        Label2.Text = "-"
        TextBox1.Clear()
    End Sub

    Private Sub btndivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivide.Click
        opperan = "/"

        If CInt(True) Then value1 = CDbl(TextBox1.Text)
        Label2.Text = "/"
        TextBox1.Clear()
    End Sub

    Private Sub btntimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntimes.Click
        opperan = "*"

        If CInt(True) Then value1 = CDbl(TextBox1.Text)
        Label2.Text = "*"
        TextBox1.Clear()
    End Sub

    Private Sub btnequals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequals.Click
        value2 = Val(TextBox1.Text)
        Label2.Text = ""
        Select Case opperan

            Case Is = "+"
                TextBox1.Text = (value1 + value2).ToString()

            Case Is = "-"
                TextBox1.Text = (value1 - value2).ToString()

            Case Is = "*"
                TextBox1.Text = (value1 * value2).ToString()

            Case Is = "/"

                If value2 <> 0 Then

                    TextBox1.Text = (value1 / value2).ToString
                End If
        End Select
    End Sub

    Private Sub allclearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allclearbtn.Click
        TextBox1.Clear()
    End Sub
    Private Sub btnmemplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmemplus.Click
        My.Settings.memory = TextBox1.Text
        If My.Settings.memory = "" Then
            Label1.Text = ""
            MsgBox("Feild is empty", MsgBoxStyle.Exclamation)
        Else
            Label1.Text = "M"
            If Me.BackColor = Color.Black Then
                Label1.ForeColor = Color.Red
            Else
                Label1.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnmemminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmemminus.Click
        My.Settings.memory = ""
        Label1.Text = ""
    End Sub

    Private Sub btnmemrecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmemrecall.Click
        If My.Settings.memory = "" Then
            MsgBox("Your Memory is empty", MsgBoxStyle.Exclamation)
        Else
            TextBox1.Text = My.Settings.memory
        End If
    End Sub

    Private Sub btndec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndec.Click
        Dim dot As Boolean = False

        If TextBox1.Text.IndexOf(".") >= 0 Then dot = True

        If dot = False Then TextBox1.Text += "."
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = ""
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Divide Then
            opperan = "/"

            If CInt(True) Then value1 = CDbl(TextBox1.Text)

            TextBox1.Clear()
        Else
            If e.KeyCode = Keys.Add Then
                opperan = "+"

                If CInt(True) Then value1 = CDbl(TextBox1.Text)

                Label2.Text = "+"

                TextBox1.Clear()
            Else
                If e.KeyCode = Keys.Subtract Then
                    opperan = "-"

                    If CInt(True) Then value1 = CDbl(TextBox1.Text)
                    Label2.Text = "-"
                    TextBox1.Clear()
                Else
                    If e.KeyCode = Keys.Multiply Then
                        opperan = "*"

                        If CInt(True) Then value1 = CDbl(TextBox1.Text)
                        Label2.Text = "*"
                        TextBox1.Clear()
                    Else
                        If e.KeyCode = Keys.Divide Then
                            opperan = "/"

                            If CInt(True) Then value1 = CDbl(TextBox1.Text)
                            Label2.Text = "/"
                            TextBox1.Clear()
                        Else
                            If e.KeyCode = Keys.Enter Then
                                value2 = Val(TextBox1.Text)
                                Label2.Text = ""
                                Select Case opperan

                                    Case Is = "+"
                                        TextBox1.Text = (value1 + value2).ToString()

                                    Case Is = "-"
                                        TextBox1.Text = (value1 - value2).ToString()

                                    Case Is = "*"
                                        TextBox1.Text = (value1 * value2).ToString()

                                    Case Is = "/"

                                        If value2 <> 0 Then

                                            TextBox1.Text = (value1 / value2).ToString
                                        End If
                                End Select
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub SimpleToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleToolStripMenuItem.Click
        Me.BackColor = Color.White()
    End Sub
    Private Sub Cut()
        If Me.TextBox1.Text.Length > 0 Then
            Clipboard.SetDataObject(Me.TextBox1.SelectedText)
            Me.TextBox1.Cut()
        End If
    End Sub

    Private Sub Copy()
        If Me.TextBox1.Text.Length > 0 Then
            Me.TextBox1.Copy()
        End If
    End Sub

    Private Sub Paste()
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then
            Me.TextBox1.Paste()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Cut()
    End Sub
    Private Sub PinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PinkToolStripMenuItem.Click
        Me.BackColor = Color.Pink
    End Sub

    Private Sub BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlackToolStripMenuItem.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub RedToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.Blue
    End Sub
End Class
