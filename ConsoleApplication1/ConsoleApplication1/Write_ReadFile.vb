Imports System.IO
Module Write_ReadFile
    Sub main()
        Try
            Using writerStream As StreamWriter = New StreamWriter("text.txt")
                Dim str As String() = New String() {"I'm still there every where", "I'm the dust in the wind",
                                                    "I'm the star on the northern Sky", "next", "next", "I never stay anywhere",
                                                    "I'm the wind on the trees", "Would you wait for me forever?"}
                Dim iStr As String
                For Each iStr In str
                    If iStr = "next" Then
                        writerStream.WriteLine()
                    Else
                        writerStream.WriteLine(iStr)
                    End If
                Next
            End Using
        Catch ex As Exception
            Console.WriteLine("The file could not be read!")
            Console.WriteLine(ex.Message)
        End Try
        Try
            Using readerStream As StreamReader = New StreamReader("text.txt")
                Dim line As String
                line = readerStream.ReadLine
                While (readerStream.EndOfStream <> True)
                    Console.WriteLine(line)
                    line = readerStream.ReadLine
                    'If line = Nothing Then
                    '    line = readerStream.ReadLine
                    '    If line = Nothing Then
                    '        Exit While
                    '    Else
                    '        Console.WriteLine()
                    '    End If
                    'End If
                End While
                Console.WriteLine(line)
            End Using
        Catch ex As Exception
            Console.WriteLine("The file could not be read!")
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
