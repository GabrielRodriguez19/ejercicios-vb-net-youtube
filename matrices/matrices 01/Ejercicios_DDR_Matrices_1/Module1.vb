Module Module1

    Sub Main()

        'Creo la mnatriz de 3x3
        Dim matriz(2, 2) As Integer

        'Recorro la matriz
        For i = 0 To matriz.GetLength(0) - 1
            For j = 0 To matriz.GetLength(1) - 1
                'Le doy valor a la posicion de la matriz
                matriz(i, j) = (i * matriz.GetLength(0)) + (j + 1)
                Console.Write(matriz(i, j) & " ") 'Lo muestro

            Next
            Console.WriteLine() 'Salto de linea
        Next


        Console.ReadLine()

    End Sub

End Module
