Module Module1

    Sub Main()

        Dim numeros(5) As Integer

        For i As Integer = 0 To (numeros.Length - 1)

            Console.WriteLine("Inserte un numero en la posicion " & i)
            numeros(i) = Console.ReadLine()

        Next

        Console.WriteLine("Resultado")
        For i As Integer = 0 To (numeros.Length - 1)

            Console.WriteLine(numeros(i))
            
        Next

        Console.ReadLine()

    End Sub

End Module
