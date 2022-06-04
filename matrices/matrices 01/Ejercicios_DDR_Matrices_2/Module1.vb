Module Module1

    Sub Main()

        'Pedimos el numero de filas
        Console.WriteLine("Escribe el numero de filas")
        Dim filas As Integer = Convert.ToInt32(Console.ReadLine())

        'Restamos al numero de filas 1 para que se compense
        Dim matriz(filas - 1, 1) As String

        'Para mayor comodidad, os dejo ambas versiones en el mismo fichero
        'Solo teneis que comentar una parte y descomentar la otra

        'Version 1

        'For i = 0 To matriz.GetLength(0) - 1

        '    Console.WriteLine("Escribe el nombre del usuario " & (i + 1))
        '    matriz(i, 0) = Console.ReadLine()

        '    Console.WriteLine("Escribe el passwors del usuario " & (i + 1))
        '    matriz(i, 1) = Console.ReadLine()

        'Next

        'Version 2

        For i = 0 To matriz.GetLength(0) - 1
            For j = 0 To matriz.GetLength(1) - 1

                Select Case j
                    Case 0
                        Console.WriteLine("Escribe el nombre del usuario " & (i + 1))
                        matriz(i, 0) = Console.ReadLine()
                    Case 1
                        Console.WriteLine("Escribe el password del usuario " & (i + 1))
                        matriz(i, 1) = Console.ReadLine()
                End Select

            Next
        Next

        Console.WriteLine()

        Console.WriteLine("nombre " & " pass")

        'Mostramos el estado de la matriz
        For i = 0 To matriz.GetLength(0) - 1
            For j = 0 To matriz.GetLength(1) - 1

                Console.Write(matriz(i, j) & " ")

            Next
            Console.WriteLine()
        Next

        Console.ReadLine()

    End Sub

End Module
