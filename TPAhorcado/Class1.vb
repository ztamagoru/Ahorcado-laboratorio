Imports System.IO

Public Class Class1

    Shared ruta As String = "C:\Users\marus\source\repos\"
    Shared archivo As String = "palabras.txt"
    Shared cantlineas As String()
    Shared escribir As New StreamWriter(ruta + archivo, True)

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

    Shared Sub añadirPalabra(palabra As String)
        escribir.WriteLine(palabra)
        escribir.Close()
        MsgBox("Palabra guardada correctamente." + Environment.NewLine +
               "Cantidad de palabras actual: " + contarlineas().ToString)

        Form4.TextBox1.Clear()
    End Sub
End Class
