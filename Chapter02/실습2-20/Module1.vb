Module Module1

    Sub Main()
        Dim value As Double
        Dim sf As String
        Dim perMilleFmt As String = "#0.## " & ChrW(&H2030)

        value = 1.2
        Console.WriteLine("0.00  = {0}", value.ToString("0.00"))
        Console.WriteLine("#.##  = {0}", value.ToString("#.##"))

        value = 1234567890
        Console.WriteLine("# = {0} ", value.ToString("#"))
        Console.WriteLine("#,# = {0}", value.ToString("#,#"))

        sf = String.Format("{0:n0}", value)
        Console.WriteLine("String.Format(0:n0) = {0}", sf)
        Console.WriteLine("String.Format(c) = {0}" _
                             , value.ToString("c"))

        value = 86000
        Console.WriteLine("0.###E+0 = {0} " _
                            , value.ToString("0.###E+0"))

        value = 0.00354
        sf = String.Format("{0:p1}", value)
        Console.WriteLine("String.Format(0:p1) = {0}", sf)
        Console.WriteLine("#0.##  = {0} " _
                            , value.ToString(perMilleFmt))

        Console.ReadLine()
    End Sub

End Module