Imports System.IO

Public Class Class1

    Shared ruta As String = "C:\Users\marus\source\repos\"
    Shared archivo As String = "palabras.txt"
    Shared cantlineas As String()

    Shared Function contarlineas() As Integer
        cantlineas = File.ReadAllLines(ruta + archivo)

        Return cantlineas.LongLength
    End Function


End Class
