Module Module1

    Sub Main()

        Console.WriteLine("Introduce una longitud")
        Dim longitud As Integer = Convert.ToInt32(Console.ReadLine())

        Dim numeros(longitud - 1) As Integer
        Console.WriteLine("")
        For i = 0 To numeros.Length - 1

            numeros(i) = numAleatorioEntre(1, 10)
            Console.WriteLine(numeros(i))

        Next


        Console.WriteLine("Introduce numero a buscar")
        Dim numero_buscado As Integer = Convert.ToInt32(Console.ReadLine())
        Dim encontrado As Boolean = False

        For i = 0 To numeros.Length - 1 And Not encontrado

            If numeros(i) = numero_buscado Then
                encontrado = True
            End If

        Next

        If encontrado Then
            Console.WriteLine("El numero esta en el array")
        Else
            Console.WriteLine("El numero no esta en el array")
        End If


        Console.ReadLine()

    End Sub

    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

End Module
