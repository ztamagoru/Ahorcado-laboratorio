Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = String.Empty Then
            MsgBox("Error. Campos sin rellenar.")
        Else
            Dim palabra As String = Environment.NewLine + TextBox1.Text.Trim
            Class1.añadirPalabra(palabra)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If InStr(1, Chr(32), e.KeyChar) = 1 Then
            MsgBox("Espacios inválidos.")
        End If
    End Sub
End Class