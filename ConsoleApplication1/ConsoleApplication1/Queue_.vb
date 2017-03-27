Module Queue_
    Sub main()
        Dim que As Queue = New Queue()
        Dim str As String
        que.Enqueue("D")
        que.Enqueue("U")
        que.Enqueue("O")
        que.Enqueue("N")
        que.Enqueue("G")
        For Each str In que
            Console.Write("{0}", str + vbTab)
        Next
        Console.WriteLine()
        Console.WriteLine("Que count: {0}", que.Count)
        Console.WriteLine(que.Contains("G"))
        que.Dequeue()
        For Each str In que
            Console.Write("{0}", str + vbTab)
        Next
        Console.WriteLine()
        Dim oj As Object() = New Object() {}
        oj = que.ToArray
        For Each str In oj
            Console.Write("{0}", str + vbTab)
        Next
        Console.ReadKey()
    End Sub
End Module
