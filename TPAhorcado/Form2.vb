Imports System.IO

Public Class Form2
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Form1.TextBox1.Text = ""
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.Text.Length > 0 Then
            Dim letra As String
            letra = TextBox1.Text(0)

            TextBox1.Text = ""

            MsgBox("error. max limite")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo.Text = tiempo.Text + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
    End Sub

    Private Sub ComenzarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComenzarToolStripMenuItem.Click
        MsgBox("cantidad de palabras del archivo: " +
               Class1.contarlineas.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
End Class