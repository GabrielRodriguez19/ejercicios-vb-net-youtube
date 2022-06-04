Module Module1

    Sub Main()

        'Pedimos los numeros
        Console.WriteLine("Inserte el numero 1")
        Dim numero1 As Integer = Console.ReadLine()

        Console.WriteLine("Inserte el numero 2")
        Dim numero2 As Integer = Console.ReadLine()

        'Comparamos los numeros
        If numero1 >= numero2 Then

            If numero1 = numero2 Then
                'Son iguales
                Console.WriteLine("Los numeros son iguales")
            Else
                'El numero1 es mayor
                Console.WriteLine("El numero " & numero1 & " es mayor que el numero " & numero2)
            End If

        Else
            'El numero2 es mayor
            Console.WriteLine("El numero " & numero2 & " es mayor que el numero " & numero1)

        End If

        Console.ReadLine()



    End Sub

End Module
