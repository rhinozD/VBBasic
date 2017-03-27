Module Array_List
    Sub main()
        Dim numAl As ArrayList = New ArrayList()
        Dim testNum As ArrayList = New ArrayList()
        Dim i As Integer
        Console.WriteLine("Adding some numbers:")
        numAl.Add(12)
        numAl.Add(30)
        numAl.Add(23)
        numAl.Add(399)
        numAl.Add(29)
        numAl.Add(39)
        numAl.Add(40)
        numAl.Add(2489)
        numAl.Add(100)
        Console.WriteLine("Capacity: {0}", numAl.Capacity)
        Console.WriteLine("Count: {0}", numAl.Count)
        Console.WriteLine("isFixedSize: {0}", numAl.IsFixedSize)
        Console.WriteLine("Item 3: {0}", numAl.Item(3))
        Console.WriteLine(numAl.Contains("12"))
        numAl.RemoveAt(3)
        Console.WriteLine("Content: ")
        numAl.Insert(3, 1234)
        numAl.Add(2984)
        For Each i In numAl
            Console.Write("{0}" + vbTab, i)
        Next
        Console.WriteLine()
        numAl.Sort()
        Console.WriteLine("Sorted Contents:")
        For Each i In numAl
            Console.Write("{0}" + vbTab, i)
        Next
        numAl.TrimToSize()
        Console.WriteLine("Capacity: {0}", numAl.Capacity)
        Console.ReadKey()
    End Sub
End Module
