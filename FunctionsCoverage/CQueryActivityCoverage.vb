Imports Resco.ResFramework
Imports Resco.ResServer
Imports System.Linq


Class CQueryActivityCoverage
    Inherits CQueryActivityTest
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
    Shared Sub ActivityMain(ByVal path As String)
        Dim arrayList, arrayTestList, validArrayTestList As New List(Of String)
        Dim className As String
        arrayTestList = ShowMethods(GetType(CQueryActivityTest))
        arrayList = ShowMethods(GetType(CQueryActivity))
        className = GetType(CQueryActivity).Name
        WriteToCsvFile.WriteData(arrayList, arrayTestList, path, className)
    End Sub
End Class
