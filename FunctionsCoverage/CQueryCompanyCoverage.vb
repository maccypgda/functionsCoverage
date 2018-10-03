﻿Imports Resco.ResFramework
Imports Resco.ResServer
Imports System.Linq


Class CQueryCompanyCoverage
    Inherits CQueryCompanyTest
    Public Shared Function ShowMethods(ByVal type As Type) As List(Of String)
        Dim tempArrayList As New List(Of String)
        tempArrayList.Clear()
        For Each method In type.GetMethods()
            Dim parameters = method.GetParameters()
            If (method.IsPublic And method.Name.Contains("Insert") OrElse method.Name.Contains("Select") OrElse method.Name.Contains("Exists")) Then
                'Console.WriteLine("{0} {1}", method.IsPublic, method.Name)
                tempArrayList.Add(method.Name)
            End If
        Next

        Return tempArrayList
    End Function
    Shared Sub CompanyMain(ByVal path As String)
        Dim arrayList, arrayTestList, validArrayTestList As New List(Of String)
        arrayTestList = ShowMethods(GetType(CQueryCompanyTest))
        arrayList = ShowMethods(GetType(CQueryCompany))
        Dim className = GetType(CQueryCompany).Name
        WriteToCsvFile.WriteData(arrayList, arrayTestList, path, className)
    End Sub
End Class
