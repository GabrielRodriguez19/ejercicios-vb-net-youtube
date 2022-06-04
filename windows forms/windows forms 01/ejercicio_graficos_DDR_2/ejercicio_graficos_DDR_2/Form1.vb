Public Class Form1



    Private Sub btnPulsame_Click(sender As Object, e As EventArgs) Handles btnPulsame.Click

        Dim veces As Integer = Convert.ToInt32(txtVeces.Text)

        txtVeces.Text = veces + 1

    End Sub

End Class
