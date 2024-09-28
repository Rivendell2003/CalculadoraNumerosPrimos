Public Class Evaluaciones
    ' aca solo aceptamos numeros
    Public Function IsNumeric(num As String) As Boolean
        Try
            Dim x As Double = Convert.ToDouble(num)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' verifico que sea par
    Public Function Par(num As Integer) As Boolean
        Return num Mod 2 = 0
    End Function

    ' verifico que sea par perfecto
    Public Function Perfecto(num As Integer) As Boolean
        Dim sum As Integer = 0
        For i As Integer = 1 To num - 1
            If num Mod i = 0 Then
                sum += i
            End If
        Next
        Return sum = num
    End Function

    ' verifico que sea  primo
    Public Function Primo(num As Integer) As Boolean
        Dim cont As Integer = 0
        For i As Integer = 1 To num
            If num Mod i = 0 Then
                cont += 1
            End If
        Next
        Return cont = 2
    End Function
End Class
