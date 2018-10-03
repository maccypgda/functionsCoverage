Public Class WriteToCsvFile
    Shared Sub WriteData(ByVal _arrayList As List(Of String), ByVal _arrayTestList As List(Of String),
                          ByVal _path As String, ByVal _classname As String)
        Dim maxFlag, crashFlag, infoFlag As String
        Dim _validArrayTestList As New List(Of String)
        Dim streamWriter As System.IO.StreamWriter
        streamWriter = My.Computer.FileSystem.OpenTextFileWriter(_path, True)

        For Each element In _arrayTestList
            If (element.Contains("Max") OrElse element.Contains("Crash")) Then
                _validArrayTestList.Add(element)
            End If
        Next
        streamWriter.WriteLine(_classname)
        streamWriter.WriteLine("#####TEST RESULTS#####")
        streamWriter.WriteLine("METHOD NAME,CRASH TEST,MAX TEST,INFO")
        For Each methodName In _arrayList
            crashFlag = "-"
            maxFlag = "-"
            infoFlag = ""
            For Each testName In _validArrayTestList
                If (testName.Contains(methodName) And testName.Contains("Max")) Then
                    maxFlag = "OK"
                    crashFlag = "OK"
                    infoFlag = ""
                ElseIf (testName.Contains(methodName) And testName.Contains("Crash") And testName.Contains("Exists")) Then
                    crashFlag = "OK"
                    infoFlag = "Exists method"
                ElseIf (testName.Contains(methodName) And testName.Contains("Crash") And testName.Contains("Insert")) Then
                    crashFlag = "OK"
                    infoFlag = "Insert method"
                ElseIf (testName.Contains(methodName) And testName.Contains("Crash") And testName.Contains("Count")) Then
                    If (crashFlag.Equals("OK") And maxFlag.Equals("OK")) Then
                    Else
                        crashFlag = "OK"
                        infoFlag = "Count method"
                    End If
                ElseIf (testName.Contains(methodName) And testName.Contains("Crash")) Then
                    crashFlag = "OK"
                End If
            Next
            streamWriter.WriteLine("{0},{1},{2},{3}", methodName, crashFlag, maxFlag, infoFlag)
        Next
        streamWriter.WriteLine(System.Environment.NewLine)
        streamWriter.Close()
    End Sub
End Class
