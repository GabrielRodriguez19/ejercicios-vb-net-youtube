Module Module1

    Sub Main()

        'Creamos una constante IVA
        Const IVA As Double = 0.21

        'Pedimos un valor por consola
        Console.WriteLine("Inserte el valor de un producto")
        Dim producto As Double = Console.ReadLine()

        'Creamos dos variables que nos seran de ayuda
        Dim valorIVA As Double = producto * IVA
        Dim valorFinal As Double = producto + valorIVA

        'Mostramos valores
        Console.WriteLine("El valor del IVA del producto es " & valorIVA & " euros")
        Console.WriteLine("El valor final es " & valorFinal & " euros")

        Console.ReadLine()

    End Sub

End Module
