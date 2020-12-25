Module Module1

    Sub Main()
        Dim txt As String = ""

        ' IndexesOf 메소드 결과
        txt &= IndexesOf()

        ' Reverse 메소드 결과
        txt &= Reverse()

        ' Sort 메소드 결과
        txt &= SortPeople()

        ' Sort 메소드의 관리 결과
        txt &= SortManagers()

        ' 이진 검색.
        txt &= BinarySearch()
        Console.WriteLine(txt)
        Console.Read()

    End Sub
    Private Function IndexesOf() As String
        Dim txt As String = ""

        Dim values(10) As Integer
        For i As Integer = 0 To 5
            values(i) = i
        Next i
        For i As Integer = 6 To 10
            values(i) = 10 - i
        Next i

        txt &= "Indexes: "
        For i As Integer = 0 To 10
            txt &= values(i) & " "
        Next i
        txt &= vbCrLf
        txt &= "    Index of 4 :  " & Array.IndexOf(values, 4).ToString & vbCrLf
        txt &= "    Index of 6 : " & Array.IndexOf(values, 6).ToString & vbCrLf
        txt &= "    Last index of 3 : " & _
            Array.LastIndexOf(values, 3).ToString & vbCrLf
        Return txt & vbCrLf
    End Function

    Private Function Reverse() As String
        Dim txt As String = ""

        Dim values(9) As Integer
        For i As Integer = 0 To 9
            values(i) = i
        Next i

        txt &= "배열 :    "
        For i As Integer = 0 To 9
            txt &= values(i) & " "
        Next i
        txt &= vbCrLf

        Array.Reverse(values)

        txt &= "Reversed: "
        For i As Integer = 0 To 9
            txt &= values(i) & " "
        Next i
        txt &= vbCrLf

        Return txt & vbCrLf
    End Function

    Private Function SortPeople() As String
        '  Person 객체 배열 작성
        Dim people(4) As Person
        people(0) = New Person("홍길동", "이순신")
        people(1) = New Person("강감찬", "이성계")
        people(2) = New Person("임꺽정", "단군")
        people(3) = New Person("왕건", "이이")
        people(4) = New Person("신사임당", "안중근")

        Dim txt As String = "People : " & vbCrLf
        For i As Integer = 0 To people.Length - 1
            txt &= "    " & people(i).ToString() & vbCrLf
        Next i

        ' Sort.
        Array.Sort(people)

        txt &= "Sorted : " & vbCrLf
        For i As Integer = 0 To people.Length - 1
            txt &= "    " & people(i).ToString() & vbCrLf
        Next i

        Return txt & vbCrLf
    End Function

    Private Function SortManagers() As String
        ' 배열 객체 작성
        Dim managers(4) As Manager
        managers(0) = New Manager("홍길동", "이순신")
        managers(1) = New Manager("강감찬", "이성계")
        managers(2) = New Manager("임꺽정", "단군")
        managers(3) = New Manager("왕건", "이이")
        managers(4) = New Manager("신사임당", "안중근")

        Dim txt As String = "Managers:" & vbCrLf
        For i As Integer = 0 To managers.Length - 1
            txt &= "    " & managers(i).ToString() & vbCrLf
        Next i

        ' 비교 작성.
        Dim manager_comparer As New ManagerComparer

        ' 정렬.
        Array.Sort(managers, manager_comparer)

        txt &= "Sorted:" & vbCrLf
        For i As Integer = 0 To managers.Length - 1
            txt &= "    " & managers(i).ToString() & vbCrLf
        Next i

        Return txt & vbCrLf
    End Function

    Private Function BinarySearch() As String
        '  Person 객체 배열 작성.
        Dim people(4) As Person
        people(0) = New Person("홍길동", "이순신")
        people(1) = New Person("강감찬", "이성계")
        people(2) = New Person("임꺽정", "단군")
        people(3) = New Person("왕건", "이이")
        people(4) = New Person("신사임당", "안중근")

        ' 배열 정렬
        Array.Sort(people)

        ' 홍길동 이순신 검색
        Dim target_person As New Person("홍길동", "이순신")
        Dim target_index As Integer _
               = Array.BinarySearch(people, target_person)
        target_person = people(target_index)

        Return "BinarySearch 검색 " & _
            target_person.ToString & " 색인 " & _
            target_index & vbCrLf & vbCrLf
    End Function

    Public Class Person
        Implements IComparable

        Public FirstName As String
        Public LastName As String

        Public Sub New(first_name As String, _
                    last_name As String)
            FirstName = first_name
            LastName = last_name
        End Sub

        Public Overrides Function ToString() As String
            Return LastName & ", " & FirstName
        End Function

        Public Function CompareTo(obj As Object) As Integer _
         Implements System.IComparable.CompareTo
            Dim other_Person As Person = DirectCast(obj, Person)
            Return String.Compare(Me.ToString, other_Person.ToString)
        End Function
    End Class

    Public Class Manager
        Public FirstName As String
        Public LastName As String

        Public Sub New(first_name As String, last_name As String)
            FirstName = first_name
            LastName = last_name
        End Sub

        Public Overrides Function ToString() As String
            Return LastName & ", " & FirstName
        End Function
    End Class

    Public Class ManagerComparer
        Implements IComparer

        Public Function Compare(x As Object, _
                   y As Object) As Integer _
         Implements System.Collections.IComparer.Compare
            Dim mgr1 As Manager = DirectCast(x, Manager)
            Dim mgr2 As Manager = DirectCast(y, Manager)

            Return String.Compare(mgr1.ToString, mgr2.ToString)
        End Function
    End Class

End Module