Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = String.Empty Then
            MsgBox("Error. Campos sin rellenar.")
        Else

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If InStr(1, "1234567890") Then

        End If
    End Sub
End Class