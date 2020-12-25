Module Module1

    Sub Main()
        Dim x As Integer = 10, y1 As Integer = 0
        Dim y2 As Integer = 2, z As Integer = 10
        Console.WriteLine("main: z= {0}", z)

        Try
            Console.WriteLine("try: before 'divide by 0'")
            z = x / y1
            Console.WriteLine("try: after 'divide by 0'")

        Catch ex As Exception When y1 = 0
            Console.WriteLine("catch(ArithmeticException) = {0} ", ex)

        Finally
            Console.WriteLine("finally: z= {0}", z)
        End Try

        Console.WriteLine("main: z= {0}", z)
        Console.ReadLine()
    End Sub

End Module