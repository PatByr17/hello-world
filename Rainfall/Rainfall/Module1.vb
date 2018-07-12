Module Module1

    Sub Main()
        Dim rainfall(12) As Integer
        Dim total As Integer
        For m As Integer = 1 To 12
            Console.Write("Month " + m.ToString + ": ")
            rainfall(m) = Console.ReadLine
            total += rainfall(m)
        Next
        Dim min As Integer
        Console.WriteLine("What is the minimum value?")
        min = Console.ReadLine
        For i As Integer = 1 To 12
            If rainfall(i) < min Then
                Console.WriteLine(i.ToString + ", ")
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
