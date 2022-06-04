Module Module1

    Sub Main()

        Dim numeros(5) As Integer

        For i As Integer = 0 To (numeros.Length - 1)

            numeros(i) = i

            Console.WriteLine(numeros(i))

        Next

        Console.ReadLine()

    End Sub

End Module
