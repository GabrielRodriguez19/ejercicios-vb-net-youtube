Module Module1

    Sub Main()

        'Pedimos los numeros
        Console.WriteLine("Inserte el numero 1")
        Dim numero1 As Integer = Console.ReadLine()

        Console.WriteLine("Inserte el numero 2")
        Dim numero2 As Integer = Console.ReadLine()

        'Usammos una estructura condicional
        If numero1 Mod numero2 = 0 Then
            'Es divisible entre dos
            Console.WriteLine("El numero " & numero1 & " es divisible entre " & numero2)

        Else
            'No es divisible entre dos
            Console.WriteLine("El numero " & numero1 & " no es divisible entre " & numero2)

        End If

        Console.ReadLine()

    End Sub

End Module
