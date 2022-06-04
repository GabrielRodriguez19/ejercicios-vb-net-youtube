Module Module1

    Sub Main()

        Dim tabMult(10) As Integer

        Console.WriteLine("Inserte un numero para ver su tabla")
        Dim numeroUsuario As Integer = Console.ReadLine()

        For i As Integer = 0 To (tabMult.Length - 1)

            tabMult(i) = numeroUsuario * i

            Console.WriteLine(numeroUsuario & "x" & i & "=" & tabMult(i))

        Next

        Console.ReadLine()

    End Sub

End Module
