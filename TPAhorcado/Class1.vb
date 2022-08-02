Imports System.IO

Public Class Class1

    Shared ruta As String = "C:\Users\marus\source\repos\"
    Shared archivo As String = "palabras.txt"
    Shared cantlineas As String()

    Shared Function contarlineas() As Integer
        cantlineas = File.ReadAllLines(ruta + archivo)

        Return cantlineas.LongLength
    End Function

    Shared Sub verLista()
        Dim listado As String

        listado = My.Computer.FileSystem.ReadAllText(ruta + archivo)

        Form3.TextBox1.Text = listado
        Form3.Label1.Text = "Cant: " + contarlineas().ToString
    End Sub
End Class
