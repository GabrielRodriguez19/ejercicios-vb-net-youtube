Module Module1

    Sub Main()

        'Pedimos el valor del radio
        Console.WriteLine("Introduzca el valor del radio")
        Dim radio As Integer = Console.ReadLine()

        'Calculamos el area
        Dim area As Double = Math.PI * radio ^ 2

        'Mostramos el valor
        Console.WriteLine("El area es " & area)

        Console.ReadLine()

    End Sub

End Module
