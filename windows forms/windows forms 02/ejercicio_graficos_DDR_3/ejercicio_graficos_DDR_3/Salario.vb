Public Class Salario
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Donde guardaremos la razon del salario
        Dim desglose As String = ""
        'Total del salario
        Dim total As Integer = 0

        'Compruebo si los radiobutton estan marcados
        'En los que no se ingresa nada, no hace falta ponerlos
        If rbObrero.Checked Then
            desglose &= "- Cobras 800€ por ser " & rbObrero.Text & vbCrLf
            total += 800
        End If

        If rbAdm.Checked Then
            desglose &= "- Cobras 900€ por ser " & rbAdm.Text & vbCrLf
            total += 900
        End If

        If rbTec.Checked Then
            desglose &= "- Cobras 1000€ por ser " & rbTec.Text & vbCrLf
            total += 1000
        End If

        If rbPro.Checked Then
            desglose &= "- Cobras 1200€ por ser " & rbPro.Text & vbCrLf
            total += 1200
        End If

        If rbSi.Checked Then
            desglose &= "- Cobras 50€ mas por estar inscrito en un sindicato" & vbCrLf
            total += 50
        End If

        If rb5_10.Checked Then
            desglose &= "- Cobras 100€ mas por tener entre 5 y 10 años de servicio" & vbCrLf
            total += 100
        End If

        If rb10años.Checked Then
            desglose &= "- Cobras 200€ mas por tener mas de 10 años de servicio" & vbCrLf
            total += 200
        End If

        Dim añadido_hijos As Integer = (nupHijos.Value * 100)

        If nupHijos.Value > 0 Then
            desglose &= "- Cobras " & añadido_hijos & "€ por tener " & nupHijos.Value & " hijo/s" & vbCrLf
        End If

        total += añadido_hijos

        MsgBox(desglose & "El total es: " & total & "€")


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Marcamos los valores por defecto
        rbObrero.Checked = True
        rbNo.Checked = True
        rb5años.Checked = True
        nupHijos.Value = 0
    End Sub


End Class
