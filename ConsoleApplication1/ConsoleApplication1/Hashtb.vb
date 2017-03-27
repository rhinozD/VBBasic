Module Hashtb
    Sub main()
        Dim ht As Hashtable = New Hashtable()
        Dim k As Integer
        ht.Add(1, "Duong")
        ht.Add(2, "Long")
        ht.Add(3, "Trang")
        ht.Add(4, "Nguoi deo hieu duoc")
        ht.Add(5, "Ong noi nham")
        ht.Add(6, "Sep - Ong di la vui")
        ht.Add(7, "Thu ki - Beo")
        Console.WriteLine("Count: {0}", ht.Count)
        Console.WriteLine("IsFixedSize : {0}", ht.IsFixedSize)
        Console.WriteLine("IsReadOnly : {0}", ht.IsReadOnly)
        Console.WriteLine("Item 3 : {0}", ht.Item(3))
        Dim key As ICollection = ht.Keys
        For Each k In key
            Console.WriteLine(" {0} : {1}", k, ht(k))
        Next k

        Console.ReadKey()
    End Sub
End Module
