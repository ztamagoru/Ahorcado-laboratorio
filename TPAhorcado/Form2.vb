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
        If Timer1.Enabled = False Then
            MsgBox("El tiempo aún no ha iniciado")
        ElseIf TextBox1.Text.Trim = String.Empty Then
            MsgBox("Campos en blanco" + Environment.NewLine +
                   "Ingrese una letra para confirmar")
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub ComenzarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComenzarToolStripMenuItem.Click
        TextBox1.Enabled = True
        Timer1.Enabled = True
        Timer1.Start()

        ''
    End Sub

    Private Sub VerPalabrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPalabrasToolStripMenuItem.Click
        Form3.Show()
        Class1.verLista()
    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        Form4.Show()
        Form4.TextBox1.Clear()
    End Sub
End Class