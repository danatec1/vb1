Module Module1
    Sub a(ByVal n1, ByRef n2) '서브 프로시저의 시작
        Dim sum As Integer
        sum = n1 + n2
        Console.WriteLine("여기는 서브 프로시저입니다")
        Console.WriteLine("실인수로 부터 가인수로 전달한 값")
        Console.WriteLine("n ---> n1 = {0}", n1)
        Console.WriteLine("m ---> n2 = {0}", n2)
        Console.WriteLine("sum = {0}", sum)
        Console.WriteLine("-------------------------------------")
        n1 = 100 : n2 = 200
    End Sub
    Sub Main() '프로그램의 시작 지점
        Dim n As Integer, m As Integer
        n = 20 : m = 50
        a(n, m) '서브 프로시저의 호출
        Console.WriteLine("여기는 메인 프로시저")
        Console.WriteLine("가인수로 부터 실인수로 전달된 값")
        Console.Write("n1은 Call By Value이므로 ")
        Console.WriteLine("대응 실인수는 변경불가")
        Console.WriteLine("n = 20 ---> n = {0}", n)
        Console.WriteLine("m = 200 ---> m = {0}", m)
        Console.ReadLine()
    End Sub
End Module