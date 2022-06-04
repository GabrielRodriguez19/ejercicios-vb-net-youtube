Module Module1

    Sub Main()


        For index = 1 To 10
            Dim p As New Password(20)

            If p.esFuerte() Then
                Console.WriteLine(p.contrasenia & " es fuerte")
            Else
                Console.WriteLine(p.contrasenia & " no es fuerte")
            End If

        Next

        Console.ReadLine()

    End Sub

End Module

