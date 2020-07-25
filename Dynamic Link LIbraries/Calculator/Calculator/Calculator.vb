
<ComClass(Class1.ClassId, Class1.InterfaceId, Class1.EventsId)> Public Class Class1
    Public Const ClassId As String = "98349785-8BE2-4604-848D-F5B103D61715"
    Public Const InterfaceId As String = "36613EE9-125F-493d-9968-771E18C2226A"
    Public Const EventsId As String = "A036F02F-F87E-4548-A536-7DD7EA8E62B5"

    Dim Result As Double

    Public Function Addition(ByVal Number1 As Double, ByVal Number2 As Double) As Double

        If Number1.GetType.ToString = "System.Integer" Then
            Number1 = CInt(Number1)
            Result = CInt(Result)
        End If

        If Number2.GetType.ToString = "System.Integer" Then
            Number2 = CInt(Number2)
            Result = CInt(Result)
        End If

        Result = Number1 + Number2

        Return Result

    End Function

    Public Function Subtraction(ByVal Number1 As Double, ByVal Number2 As Double) As Double
        If Number1.GetType.ToString = "System.Integer" Then
            Number1 = CInt(Number1)
            Result = CInt(Result)
        End If

        If Number2.GetType.ToString = "System.Integer" Then
            Number2 = CInt(Number2)
            Result = CInt(Result)
        End If

        Result = Number1 - Number2

        Return Result
    End Function

    Public Function Multiplication(ByVal Number1 As Double, ByVal Number2 As Double) As Double
        If Number1.GetType.ToString = "System.Integer" Then
            Number1 = CInt(Number1)
            Result = CInt(Result)
        End If

        If Number2.GetType.ToString = "System.Integer" Then
            Number2 = CInt(Number2)
            Result = CInt(Result)
        End If

        Result = Number1 * Number2

        Return Result
    End Function

    Public Function Division(ByVal Number1 As Double, ByVal Number2 As Double) As Double
        If Number1.GetType.ToString = "System.Integer" Then
            Number1 = CInt(Number1)
            Result = CInt(Result)
        End If

        If Number2.GetType.ToString = "System.Integer" Then
            Number2 = CInt(Number2)
            Result = CInt(Result)
        End If

        Result = Number1 - Number2

        Return Result
    End Function


    Public Function Modulus(ByVal Number1 As Double, ByVal Number2 As Double) As Double
        If Number1.GetType.ToString = "System.Integer" Then
            Number1 = CInt(Number1)
            Result = CInt(Result)
        End If

        If Number2.GetType.ToString = "System.Integer" Then
            Number2 = CInt(Number2)
            Result = CInt(Result)
        End If

        Result = Number1 Mod Number2

        Return Result

    End Function

    Public Function Square(ByVal Number As Double) As Double
        If Number.GetType.ToString = "System.Integer" Then
            Number = CInt(Number)
            Result = CInt(Result)
        End If


        Result = Number * Number
        Return Result
    End Function

    Public Function Qube(ByVal Number As Double) As Double
        If Number.GetType.ToString = "System.Integer" Then
            Number = CInt(Number)
            Result = CInt(Result)
        End If



        Result = Number * Number * Number

        Return Result

    End Function

    Public Function Power(ByVal Number As Double, ByVal PowerValue As Double) As Double
        If Number.GetType.ToString = "System.Integer" Then
            Number = CInt(Number)
            Result = CInt(Result)
        End If

        If PowerValue.GetType.ToString = "System.Integer" Then
            Power = CInt(PowerValue)
            Result = CInt(Result)
        End If

        Result = Number ^ PowerValue

        Return Result

    End Function

    Public Function Inverse(ByVal Number As Double) As Double
        If Number.GetType.ToString = "System.Integer" Then
            Number = CInt(Number)
            Result = CInt(Result)
        End If



        Result = 1 / Number

        Return Result

    End Function

    '_____________ Trigonometric Operation ________________'

    Public Function Sin(ByVal Angle As Double) As Double
        If Angle.GetType.ToString = "System.Integer" Then
            Angle = CInt(Angle)
            Result = CInt(Result)
        End If

        Result = Math.Sin(Angle)

        Return Result

    End Function

    Public Function Cos(ByVal Angle As Double) As Double
        If Angle.GetType.ToString = "System.Integer" Then
            Angle = CInt(Angle)
            Result = CInt(Result)
        End If
        Return Result
    End Function
End Class
