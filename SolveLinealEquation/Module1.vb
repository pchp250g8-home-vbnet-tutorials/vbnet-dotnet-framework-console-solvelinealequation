Module Module1

    Sub Main()
        Dim a As Single, b As Single
        Console.Clear()
        Console.WriteLine("Input coefficients of lineal equation")
        Single.TryParse(Console.ReadLine(), a)
        Single.TryParse(Console.ReadLine(), b)
        Console.WriteLine("Try to solve the equation:{0}*x+{1}=0", a, b)
        If ((a = 0) And (b = 0)) Then
            Console.WriteLine("The answer is any number")
        ElseIf ((a = 0) And (b <> 0)) Then
            Console.WriteLine("The equation has no solution")
        Else
            Console.WriteLine("The equation has the following solution:{0}", -b / a)
        End If
        Console.Read()
    End Sub

End Module
