Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New Evaluaciones()

        ' aqi se valida si es un numero entero y no una letra
        If Not obj.IsNumeric(TextBox1.Text) Then
            Label5.Text = "Ingrese valor entero..."
        Else
            Label5.Text = String.Empty
            Dim num As Integer = Convert.ToInt32(TextBox1.Text)

            ' aca si es par o no
            Dim res1 As Boolean = obj.Par(num)
            Label2.Text = res1.ToString()

            ' aqui si es operfecto o no
            Dim res2 As Boolean = obj.Perfecto(num)
            Label3.Text = res2.ToString()

            ' aca si el número es primo o no
            Dim res3 As Boolean = obj.Primo(num)
            Label4.Text = res3.ToString()
        End If
    End Sub

End Class
