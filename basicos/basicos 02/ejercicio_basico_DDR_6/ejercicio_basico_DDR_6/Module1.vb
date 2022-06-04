Module Module1

    Sub Main()

        'Para cambiar la ejecuccion, pinchar en propiedades -> Aplicacion -> Objeto inicio
        'Elegir modulo que queremos ejecutar

        'Definimos el contador
        Dim contador As Integer = 1

        'Indicamos la condición
        While contador <= 100

            'Mostramos
            Console.WriteLine(contador)

            'Aumentamos contador
            contador += 1

        End While

        Console.ReadLine()

    End Sub

End Module
