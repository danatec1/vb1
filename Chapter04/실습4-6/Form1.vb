Public Class frmMain
    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button1.Click
        Dim Int1, Int2, Ex1 As Integer
        Int1 = TextBox1.Text
        Int2 = TextBox2.Text
        Ex1 = Int1 * Int2
        TextBox3.Text = Ex1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button2.Click
        Dim Double1, Double2, Ex2 As Double
        Double1 = TextBox4.Text
        Double2 = TextBox5.Text
        Ex2 = Double1 / Double2
        TextBox6.Text = Ex2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button3.Click
        Dim String1, String2, Ex3 As String
        String1 = TextBox7.Text
        String2 = TextBox8.Text
        Ex3 = String1 + String2
        TextBox9.Text = Ex3
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button4.Click
        Dim Var1, Var2, Ex4 As Object
        Var1 = TextBox10.Text
        Var2 = TextBox11.Text
        Ex4 = Var1 + Var2
        TextBox12.Text = Ex4
    End Sub
End Class