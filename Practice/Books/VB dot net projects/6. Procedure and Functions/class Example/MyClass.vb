
Public Class _MyClass
    Private m_IngHeight As Long
    Public Property Height() As Long
        Get
            Height = m_IngHeight

        End Get
        Set(ByVal Value As Long)
            If m_IngHeight < 10 Then Exit Property
            m_IngHeight = Value
        End Set
    End Property
    Public Function AddTwoNumbers(ByVal intNumber1 As Integer, ByVal intNumber2 As Integer) As Long
        AddTwoNumbers = intNumber1 + intNumber2
    End Function
End Class
