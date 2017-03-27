Imports System.IO
Module Directory_

    Sub Main()
        'creating a DirectoryInfo object
        Dim mydir As DirectoryInfo = New DirectoryInfo("c:\Windows")
        ' getting the files in the directory, their names and size
        Dim f As FileInfo() = mydir.GetFiles()
        Dim file As FileInfo
        For Each file In f
            Console.WriteLine("File Name: {0} Size: {1} ", file.Name,
            file.Length)
        Next file
        Console.ReadKey()
    End Sub
End Module
