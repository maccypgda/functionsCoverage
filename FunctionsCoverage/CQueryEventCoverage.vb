Imports Resco.ResFramework
Imports Resco.ResServer
Imports System.Linq


Class CQueryEventCoverage
    Inherits CQueryEventTest
    Public Shared Function ShowMethods(ByVal type As Type) As List(Of String)
        Dim tempArrayList As New List(Of String)
        tempArrayList.Clear()
        For Each method In type.GetMethods()
            Dim parameters = method.GetParameters()
            If (method.IsPublic And method.Name.Contains("Insert") OrElse method.Name.Contains("Select") OrElse method.Name.Contains("Exists")) Then
                tempArrayList.Add(method.Name)
            End If
        Next

        Return tempArrayList
    End Function
    Shared Sub EventMain(ByVal path As String)
        Dim arrayList, arrayTestList, validArrayTestList As New List(Of String)
        arrayTestList = ShowMethods(GetType(CQueryEventTest))
        arrayList = ShowMethods(GetType(CQueryEvent))
        Dim className = GetType(CQueryEvent).Name
        WriteToCsvFile.WriteData(arrayList, arrayTestList, path, className)
    End Sub
End Class
