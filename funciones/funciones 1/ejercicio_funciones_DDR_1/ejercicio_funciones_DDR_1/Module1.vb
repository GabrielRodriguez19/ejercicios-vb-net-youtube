Module Module1

    Sub Main()

        'Creamos dos variables
        Dim numero1 As Integer = 10
        Dim numero2 As Integer = 5

        'Invocamos la funcion  guardamos el resultado en una variable
        Dim suma As Integer = sumaNumeros(numero1, numero2)

        'Mostramos el resultado
        Console.WriteLine("La suma es " & suma)

        Console.ReadLine()

    End Sub

    Function sumaNumeros(num1 As Integer, num2 As Integer) As Integer

        Dim suma As Integer = num1 + num2

        Return suma 'Tambien se puede poner num1+num2 directamente

    End Function

End Module
