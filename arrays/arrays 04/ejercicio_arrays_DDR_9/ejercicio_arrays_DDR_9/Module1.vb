Module Module1

    Sub Main()

        'Array con valores predefinidos
        Dim numeros() As Integer = {1, 0, 1, 1, 1}

        'Booleano que nos indica si es capicua o no
        Dim esCapicua As Boolean = True

        '
        Dim j As Integer = numeros.Length - 1
        For i As Integer = 0 To (numeros.Length - 1) / 2

            'Si no son iguales, salimos del bucle
            If numeros(i) <> numeros(j) Then
                esCapicua = False 'Marcamos que no es capicua
                Exit For 'Salimos del array
            End If

            'Disminuimos en uno
            j = j - 1
        Next

        'Indicamos si es capicua o no
        If esCapicua Then
            Console.WriteLine("Es capicua")
        Else
            Console.WriteLine("No es capicua")
        End If

        Console.ReadLine()

    End Sub

End Module
