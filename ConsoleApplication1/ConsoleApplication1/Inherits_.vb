Module Inherits_
    Class People
        Public Shared name As String
        Public Shared age As Integer
        Public Shared gender As String
        Sub setName(ByVal n As String)
            name = n
        End Sub
        Sub setAge(ByVal t As Integer)
            age = t
        End Sub
        Sub setGender(ByVal g As String)
            gender = g
        End Sub
        Function getName() As String
            Return name
        End Function
        Function getAge() As String
            Return age
        End Function
        Function getGender() As String
            Return gender
        End Function
        Public Overridable Sub PrintInfor()
            Console.Write("Name: {0}" + vbTab + "Age: {1}" + vbTab + "Gender: {2}",
                              name, age, gender)
        End Sub
    End Class
    Class Student : Inherits People
        Public Shared cl As String
        Sub setClass(ByVal c As String)
            cl = c
        End Sub
        Function getClass() As String
            Return cl
        End Function
        Public Overrides Sub PrintInfor()
            MyBase.PrintInfor()
            Console.WriteLine(vbTab + "Class: {0}", cl)
        End Sub
    End Class
    Sub main()
        Dim st As Student = New Student()
        st.setName("Nguyen Van Duong")
        st.setAge(25)
        st.setGender("Male")
        st.setClass("10T1")
        st.PrintInfor()
        Console.ReadKey()
    End Sub
End Module
