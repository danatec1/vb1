Module Module1

    Sub Main()
        ' 수치형 변수 선언
        Dim byteA As Byte
        Dim sbyteB As SByte
        Dim srtA, srtB As Short
        Dim intA, intB As Integer

        byteA = 255
        sbyteB = -128

        srtA = 32767
        srtB = -32768

        intA = 2147483647
        intB = -2147483648

        ' 수치형 변수 출력
        Console.WriteLine("byteA = {0}, sbyteB = {1}", byteA, sbyteB)
        Console.WriteLine("srtA = {0}, srtB = {1}", srtA, srtB)
        Console.WriteLine("intA = {0}, intB = {1}", intA, intB)
        Console.ReadLine() '화면을 멈춘다

    End Sub

End Module
