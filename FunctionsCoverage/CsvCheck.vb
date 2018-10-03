Imports System
Imports System.IO
Imports System.Text
Public Class CsvCheck
    Public Shared Sub Check(ByVal path As String)

        'Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, False)
        'outFile.Close()

        If System.IO.File.Exists(path) Then
            File.Delete(path)
        Else
            'Dim newfile As FileStream
            Dim newfile = File.Create(path)
            newfile.Close()
        End If


    End Sub
End Class
