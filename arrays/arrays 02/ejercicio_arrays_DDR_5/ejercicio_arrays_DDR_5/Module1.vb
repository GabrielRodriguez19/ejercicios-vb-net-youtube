Module Module1

    Sub Main()

        Dim numeros(9) As Integer

        Dim suma As Integer = 0
        Dim media As Double = 0

        For i As Integer = 0 To numeros.Length - 1

            Console.WriteLine("Inserta un numero en la posicion " & i)
            numeros(i) = Console.ReadLine()

            suma += numeros(i)

        Next

        media = suma / numeros.Length

        Console.WriteLine("La media es de " & media)

        Console.ReadLine()

    End Sub

End Module
