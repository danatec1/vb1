Module Module1

    Sub Main()
        Dim decimalVal As Decimal
        Dim doubleVal As Double
        Dim integerVal As Integer
        Dim charVal As Char
        Dim boolVal As Boolean
        Dim stringVal As String = "123.456"
        Dim stringVal2 As String = "123456"

        decimalVal = Convert.ToDecimal(stringVal)
        Console.WriteLine("decimal : {0}", decimalVal)

        doubleVal = Convert.ToDouble(stringVal)
        Console.WriteLine("double : {0}", doubleVal)

        integerVal = Convert.ToInt32(stringVal2)
        Console.WriteLine("integer : {0}", integerVal)

        stringVal2 = "1"
        charVal = Convert.ToChar(stringVal2)
        Console.WriteLine("char : {0}", charVal)

        stringVal2 = "True"
        boolVal = Convert.ToBoolean(stringVal2)
        Console.WriteLine("bool : {0}", boolVal)

        stringVal2 = Convert.ToString(stringVal)
        Console.WriteLine("StringVal : {0}", stringVal2)

        doubleVal = Double.Parse(doubleVal)
        Console.WriteLine("doubleVal : {0}", doubleVal)

        Console.ReadLine()
    End Sub

End Module