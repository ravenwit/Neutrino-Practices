Public Class Options

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim curr As Date
        'Dim des As Date
        'Dim tddif As Integer
        'Dim ydif As Integer
        'Dim mdif As Integer
        'Dim ddif As Integer


        'curr = d1.Value
        'des = DateSerial(2012, 12, 21)
        'des = d2.Value
        ''''''''' Total Day Calculation '''''''''''''
        'tddif = DateDiff(DateInterval.Day, curr, des)
        ''''''''''''' Year Calculations ''''''''''''
        'ydif = DateDiff(DateInterval.Year, curr, des)
        ''''''''''''' Month and Day Calculation ''''''
        'If curr.Date.Day > des.Date.Day Then
        'mdif = DateDiff(DateInterval.Month, DateSerial(des.Date.Year, curr.Month, curr.Day), des) - 1
        'ddif = DateDiff(DateInterval.Day, DateSerial(des.Date.Year, des.Date.Month - 1, curr.Date.Day), des)
        'End If
        ' If curr.Date.Day < des.Date.Day Then
        'mdif = DateDiff(DateInterval.Month, DateSerial(des.Date.Year, curr.Date.Month, curr.Date.Day), des)
        'ddif = DateDiff(DateInterval.Day, DateSerial(des.Date.Year, des.Date.Month, curr.Date.Day), des)
        'End If
        ''''''''''''' Print Results ''''''''''''''''''''''
        'lblDays.Text = tddif
        'lblDiff.Text = ydif & " " & " years, " & mdif & " months, " & ddif & " days"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim birDate As Date
        Dim curr As Date
        Dim voice, msg

        curr = My.Computer.Clock.LocalTime.Date
        birDate = dbDate.Value
        If birDate > curr Then
            MsgBox("Please Enter a valid birth date. You can't be from future.")
        Else
            DateCalc(curr, birDate)
            ' year = dbDate.Value.Subtract(birDate)

            ''''''''''''''''' Print Result ''''''''''''''''''''
            lblResult.Text = "You are " & years & "  years , " & months & "  months and " & days & "  days old. "
            msg = lblResult.Text
            voice = CreateObject("sapi.spvoice")
            If My.Settings.Voice = True And chkVoice.Checked = False Then
                voice.Speak(msg)
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If dcount.Value < My.Computer.Clock.LocalTime.Date Then
            MsgBox("Invalid Date. Enter a valid date.")
        Else
            My.Settings.DesDate = dcount.Value
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.DesDate = DateSerial(2012, 12, 21)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CountDown.ShowInTaskbar = False
        ElseIf CheckBox1.Checked = False Then
            CountDown.ShowInTaskbar = True
        End If
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim desdate As Date
        Dim curr As Date
        Dim t_d_dif As Integer
        Dim msg, voice
        If d_des.Value > d_curr.Value Then
            desdate = d_curr.Value
            curr = d_des.Value
        ElseIf d_des.Value < d_curr.Value Then
            curr = d_curr.Value
            desdate = d_des.Value
        End If
        t_d_dif = DateDiff(DateInterval.Day, desdate, curr)
        DateCalc(curr, desdate)

            ' year = dbDate.Value.Subtract(birDate)

            ''''''''''''''''' Print Result ''''''''''''''''''''
        lblTDayResult.Text = t_d_dif
        lblDifResult.Text = "The difference : " & years & "  years , " & months & "   months and " & days & "  days. "
        msg = lblDifResult.Text
        voice = CreateObject("sapi.spvoice")
        If My.Settings.Voice = True And chkVoice.Checked = False Then
            voice.Speak(msg)
        End If
    End Sub

    Private Sub lblDayResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkbeep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbeep.CheckedChanged
        If chkbeep.Checked = True Then
            My.Settings.BeepSound = False
            My.Settings.Save()
            CountDown.Timer2.Enabled = False
        ElseIf chkbeep.Checked = False Then
            My.Settings.BeepSound = True
            My.Settings.Save()
            CountDown.Timer2.Enabled = True
        End If
    End Sub

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Voice = True Then
            Me.chkVoice.Checked = False
        ElseIf My.Settings.Voice = False Then
            Me.chkVoice.Checked = True
        End If
    End Sub

    Private Sub chkVoice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVoice.CheckedChanged
        If chkVoice.Checked = True Then
            My.Settings.Voice = False
        ElseIf chkVoice.Checked = False Then
            My.Settings.Voice = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMiniSys.CheckedChanged
        If chkMiniSys.Checked = True Then
            Me.Close()
            CountDown.Hide()
        ElseIf chkMiniSys.Checked = False Then
            CountDown.Show()
            
        End If
    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

  
End Class