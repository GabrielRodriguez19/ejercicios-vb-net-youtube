Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        'Filtro de ficheros
        OFD.Filter = "JPG | *.jpg"

        'Mostramos la ventana y esta nos devuelve la accion que hemos realizado
        Dim eleccion As Integer = OFD.ShowDialog(Me)

        'Si el usuario ha pulsado aceptar
        If eleccion = DialogResult.OK Then

            'Carga la imagen en el pictureBox
            pbAvatar.Image = System.Drawing.Image.FromFile(OFD.FileName)
            'Adaptamos la imagen para que se vea correctamente
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage

        End If


    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        'Me indica los errores que hay
        Dim errores As String = ""

        'Si el nombre esta vacio, añadimos el error a mostrar
        If txtNombre.Text = "" Then
            errores &= "- El nombre no puede estar vacio " & vbCrLf
        End If

        'Si el password tiene menos de 6 caracteres, añadimos el error a mostrar
        If txtPassword.Text.Length < 6 Then
            errores &= "- El password debe tener minimo 6 caracteres " & vbCrLf
        End If

        'Si la diferencia es menor que 18, añadimos el error a mostrar
        'DateDiff solo da la diferencia de años sin importar los dias y meses
        If DateDiff(DateInterval.Year, dtpEdad.Value, Date.Now) < 18 Then
            errores &= "- El usuario debe tener 18 o mas años " & vbCrLf
        End If

        'Si no hemos elegido foto, añadimos el error a mostrar
        If IsNothing(pbAvatar.Image) Then
            errores &= "- Debes elegir una imagen " & vbCrLf
        End If

        'Sino hay errores significa que todo ha ido bien
        If errores = "" Then
            MsgBox("usuario correcto e insertado")
        Else
            MsgBox(errores) 'Muestro errores
        End If


    End Sub
End Class
