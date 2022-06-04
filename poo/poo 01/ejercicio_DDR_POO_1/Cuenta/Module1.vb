Module Module1

    Sub Main()

        Dim cuenta_1 As New Cuenta("DDR")
        Dim cuenta_2 As New Cuenta("Fernando", 300)

        cuenta_1.ingresar(300)
        cuenta_2.ingresar(400)

        cuenta_1.retirar(1000)
        cuenta_2.retirar(200)

        Console.WriteLine(cuenta_1.ToString())
        Console.WriteLine(cuenta_2.ToString())

        Console.ReadLine()

    End Sub

End Module
