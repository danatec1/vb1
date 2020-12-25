Module Module1

    Sub Main()
        Dim aByte As Byte
        Dim aChar As Char
        Dim aInteger As Integer
        Dim aSingle As Single
        Dim aLong As Long
        Dim aDouble As Double

        aByte = 255
        aInteger = 2147483647
        aLong = 5000000000
        Console.WriteLine("aByte={0}, aInteger={1}, aLong={2}" _
                         , aByte, aInteger, aLong)

        aChar = "비"
        aSingle = 12345.6789
        aDouble = 123456789.12345679
        Console.WriteLine("aChar={0}, aSingle={1}, aDouble={2}" _
                         , aChar, aSingle, aDouble)
        Console.ReadLine() '화면을 멈춘다
    End Sub

End Module
