Module Module1

    Sub Main()

        'Invocamos la funcion
        calculadora(10, 0, "+")

        Console.ReadLine()

    End Sub

    Sub calculadora(num1 As Integer, num2 As Integer, tipo As Char)

        'Segun el tipo haremos una operacion u otra
        Select Case tipo
            Case "+"
                Console.WriteLine(num1 + num2)
            Case "-"
                Console.WriteLine(num1 - num2)
            Case "*"
                Console.WriteLine(num1 * num2)
            Case "/"
                Console.WriteLine(num1 / num2)
            Case Else
                Console.WriteLine("No puedes hacer una operacion con ese simbolo")
        End Select

    End Sub


End Module
