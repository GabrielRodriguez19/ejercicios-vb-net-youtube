Module Module1

    Sub Main()

        'Invocamos la funcion
        sumaNumeros(10, 5)

        Console.ReadLine()

    End Sub

    Sub sumaNumeros(num1 As Integer, num2 As Integer)

        'Mostramos el resultado directamente
        Console.WriteLine("La suma es " & (num1 + num2))

    End Sub

End Module
