Module Module1

    Sub Main()


        Console.WriteLine("Introduce una longitud")
        Dim longitud As Integer = Convert.ToInt32(Console.ReadLine())

        Dim numeros(longitud - 1) As Integer

        For i = 0 To numeros.Length - 1

            numeros(i) = numAleatorioEntre(1, 10)
            Console.WriteLine(numeros(i))

        Next

        Console.ReadLine()

    End Sub

    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

End Module
