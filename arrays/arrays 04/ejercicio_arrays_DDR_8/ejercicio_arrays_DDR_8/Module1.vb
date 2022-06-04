Module Module1

    Sub Main()

        'Array con los valores originales
        Dim numeros() As Integer = {1, 2, 3, 4, 5}

        'Array auxiliar con los valores inversos
        Dim numeros_aux(numeros.Length - 1) As Integer

        'Usaremos la j como indice del array auxiliar
        'Usaremos la i como indice del array original
        Dim j As Integer = 0
        For i As Integer = numeros.Length - 1 To 0 Step -1

            'guardamos el valor en el array auxiliar
            numeros_aux(j) = numeros(i)

            'Imprimo el valor actual
            Console.Write(numeros_aux(j) & " ")

            'Incremento la j
            j = j + 1
        Next

        Console.ReadLine()

    End Sub

End Module
