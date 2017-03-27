Module TryCatch
    Sub Div(ByVal x As Integer, ByVal y As Integer)
        Dim result As Integer
        Try
            result = x / y
        Catch ex As OverflowException
            Console.WriteLine("Exception: {0}", ex)
        Finally
            Console.WriteLine("Result: {0}", result)
        End Try
    End Sub
    Sub main()
        Div(12, 0)
        Console.ReadKey()
    End Sub
End Module
