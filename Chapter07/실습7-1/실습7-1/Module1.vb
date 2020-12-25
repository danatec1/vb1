Module Module1

    Sub Main()
        '객체를 생성한다.
        Dim Man As Class1 = New Class1

        '값을 설정한다.
        Man.ObjSex = "남성"
        Man.ObjSkin = "백인"

        '결과자료를 콘솔 화면에 출력한다.
        Console.WriteLine("생성된 사람 객체의 성별은 {0}",
                          Man.ObjSex)
        Console.WriteLine("생성된 사람 객체의 인종은 " &
                          Man.ObjSkin)
        Console.ReadLine()
    End Sub

End Module
