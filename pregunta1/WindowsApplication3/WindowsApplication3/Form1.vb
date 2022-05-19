Public Class Form1

   


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)


     

        If a >= b And b >= c Then GoTo Ordena1 Else If a >= c And c >= b Then GoTo Ordena2 Else If b >= a And a >= c Then GoTo Ordena3 Else If b >= c And c >= a Then GoTo Ordena4 Else If c >= a And a >= b Then GoTo Ordena5 Else If c >= b And b >= a Then GoTo Ordena6

Ordena1:
        TextBox4.Text = c
        TextBox5.Text = b
        TextBox6.Text = a
        GoTo final

Ordena2:
        TextBox4.Text = b
        TextBox5.Text = c
        TextBox6.Text = a
        GoTo final
Ordena3:
        TextBox4.Text = c
        TextBox5.Text = a
        TextBox6.Text = b
        GoTo final

Ordena4:
        TextBox4.Text = a
        TextBox5.Text = c
        TextBox6.Text = b
        GoTo final

Ordena5:
        TextBox4.Text = b
        TextBox5.Text = a
        TextBox6.Text = c
        GoTo final
Ordena6:
        TextBox4.Text = a
        TextBox5.Text = b
        TextBox6.Text = c
        GoTo final
final:
    End Sub
End Class
