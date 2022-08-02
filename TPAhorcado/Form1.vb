Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = String.Empty Then
            MsgBox("Campos vacíos.")
        Else
            Form2.cabeza.Visible = False
            Form2.brazoIzq.Visible = False
            Form2.Cuerpo.Visible = False
            Form2.piernaIzq.Visible = False
            Form2.brazoDer.Visible = False
            Form2.piernaDer.Visible = False

            Form2.letras.Text = "No hay errores."

            Form2.nombre.Text = TextBox1.Text.Trim
            Form2.Show()

            MsgBox("Para comenzar con una partida del ahorcado, tocar" + Environment.NewLine +
                   "el botón de Partida y luego el de Comenzar.")

            Me.Hide()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End
    End Sub

    Private Sub VerPalabrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPalabrasToolStripMenuItem.Click
        Form3.Show()
        Class1.verLista()
    End Sub
End Class
