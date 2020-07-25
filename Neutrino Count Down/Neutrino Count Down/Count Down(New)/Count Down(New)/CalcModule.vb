Module CalcModule
    Public years As Integer
    Public months As Integer
    Public days As Integer
    Sub main()
        CountDown.Show()
    End Sub
    Public Function DateCalc(ByVal Date1 As Date, ByVal Date2 As Date)
        Dim fDate As Date
        Dim sDate As Date

        If Date1 < Date2 Then
            fDate = Date1
            sDate = Date2
        ElseIf Date1 > Date2 Then
            fDate = Date2
            sDate = Date1
        End If

        '''''''''''''''''' Date Calculation ''''''''''''''''''''''

        If sDate.Date.Month < fDate.Date.Month Then
            years = DateDiff(DateInterval.Year, fDate, sDate) - 1
            If sDate.Date.Day < fDate.Date.Day Then
                months = DateDiff(DateInterval.Month, DateSerial(fDate.Date.Year + years, fDate.Date.Month, fDate.Date.Day), sDate) - 1
                days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month - 1, fDate.Date.Day), sDate)
            ElseIf sDate.Date.Day = fDate.Date.Day Then
                months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year - 1, fDate.Date.Month, fDate.Date.Day), sDate)
                days = 0
            ElseIf sDate.Date.Day > fDate.Date.Day Then
                months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year - 1, fDate.Date.Month, fDate.Date.Day), sDate)
                days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month, fDate.Date.Day), sDate)
            End If
        ElseIf sDate.Date.Month = fDate.Date.Month Then
            If sDate.Date.Day < fDate.Date.Day Then
                years = DateDiff(DateInterval.Year, fDate, sDate) - 1
                months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year - 1, fDate.Date.Month, fDate.Date.Day), sDate) - 1
                days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month - 1, fDate.Date.Day), sDate)
            ElseIf sDate.Date.Day = fDate.Date.Day Then
                years = DateDiff(DateInterval.Year, fDate, sDate)
                months = 0
                days = 0
            ElseIf sDate.Date.Day > fDate.Date.Day Then
                years = DateDiff(DateInterval.Year, fDate, sDate)
                months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year, fDate.Month, fDate.Date.Day), sDate)
                days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month, fDate.Date.Day), sDate)
            End If
        ElseIf sDate.Date.Month > fDate.Date.Month Then
            years = DateDiff(DateInterval.Year, fDate, sDate)
            If sDate.Date.Day < fDate.Date.Day Then
                months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year, fDate.Date.Month, fDate.Date.Day), sDate) - 1
                days = DateDiff(DateInterval.Day, DateSerial(sDate.Date.Year, sDate.Date.Month - 1, fDate.Date.Day), sDate)
            ElseIf sDate.Date.Day = fDate.Date.Day Then
                months = DateDiff(DateInterval.Month, DateSerial(sDate.Date.Year, fDate.Date.Month, fDate.Date.Day), sDate)
                days = 0
            ElseIf sDate.Date.Day > fDate.Date.Day Then
                months = DateDiff(DateInterval.Month, DateSerial(fDate.Date.Year + years, fDate.Date.Month, fDate.Date.Day), sDate)
                days = DateDiff(DateInterval.Day, DateSerial(fDate.Date.Year + years, sDate.Date.Month, fDate.Date.Day), sDate)
            End If
        End If
        Return 0
    End Function
End Module
