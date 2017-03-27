Module PassByValueOrRef
    'Pass by value function
    Sub swap1(x As Integer, y As Integer)
        Dim c As Integer
        c = x
        x = y
        y = c
    End Sub
    Sub swap2(ByRef x As Integer, ByRef y As Integer)
        Dim c As Integer
        c = x
        x = y
        y = c
    End Sub
    Sub main()
        Dim a As Integer = 5
        Dim b As Integer = 4
        Console.WriteLine("Before swap: ")
        Console.WriteLine("a : {0}", a)
        Console.WriteLine("b : {0}", b)
        Console.WriteLine("After swap pass by value: ")
        swap1(a, b)
        Console.WriteLine("a : {0}", a)
        Console.WriteLine("b : {0}", b)
        Console.WriteLine("After swap pass by reference: ")
        swap2(a, b)
        Console.WriteLine("a : {0}", a)
        Console.WriteLine("b : {0}", b)
        Console.ReadKey()
    End Sub
End Module
