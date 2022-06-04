Module Module1

    Sub Main()

        Dim numeroAleatorio As Integer

        For i = 1 To 10

            numeroAleatorio = numAleatorioEntre(1, 10)

            Console.WriteLine("El numero generado es: " & numeroAleatorio)

        Next



        Console.ReadLine()

    End Sub

    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

End Module
