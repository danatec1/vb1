Module Module1

    Sub Main()
        'dateA, dateB, dateC, dateD, dateE, dateF를 Date형 변수로 선언
        Dim dateA, dateB, dateC, dateD, dateE, dateF, dateG As Date

        dateA = #4/15/2019#        'dateA에 값 #4/15/2019#을 대입
        dateB = "2019-04-15"        'dateB에 값 "2019-04-15"을 대입
        dateC = "4/15/2019"         'dateC에 값 "4/15/2019"을 대입
        dateD = "오전 7:10:25"       'dateD에 값 "오전 7:10:25"을 대입
        dateE = "17:23:5"            'dateE에 값 "17:23:5" 을 대입

        'dateF에 값 #4/15/2019 5:23:05 PM# 을 대입
        dateF = #4/15/2019 5:23:05 PM#
        dateG = Today()

        Console.WriteLine("sdateA [{0}]", dateA)
        Console.WriteLine("sdateB [{0}]", dateB)
        Console.WriteLine("sdateC [{0}]", dateC)
        Console.WriteLine("sdateD [{0}]", dateD)
        Console.WriteLine("sdateE [{0}]", dateE)
        Console.WriteLine("sdateF [{0}]", dateF)
        Console.WriteLine("sdateG [{0}]", dateG)
        Console.ReadLine() '화면을 멈춘다
    End Sub

End Module
