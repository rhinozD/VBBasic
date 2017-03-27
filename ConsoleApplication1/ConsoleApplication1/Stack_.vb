Module Stack_
    Sub main()

        Dim st As Stack = New Stack()
        Dim jgArray As String()() = New String(3)() {}

        st.Push("Duong")
        st.Push("Dang")
        st.Push("Thuc")
        st.Push("Hanh")
        st.Push("Stack")
        Console.WriteLine("Number of element: {0}", st.Count)
        Console.WriteLine("Current stack: ")
        Dim c As String
        For Each c In st
            Console.Write(c + " ")
        Next c
        Console.WriteLine(st.Contains("Duong"))
        Dim str As String
        str = st.Peek
        Console.WriteLine(str)
        Console.WriteLine("Pop: {0}", st.Pop)
        Console.WriteLine("To array: ")
        Dim ar As Object() = New Object() {}
        Dim oj As Object = New Object()
        Dim i As Integer
        ar = st.ToArray()
        Dim strArray As String() = New String(ar.Length) {}
        For i = 0 To ar.Length - 1
            strArray(i) = ar(i).ToString()
        Next
        For Each c In strArray
            Console.WriteLine(c)
        Next
        Console.ReadKey()

    End Sub
End Module
