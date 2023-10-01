Public Class Form1
    Dim firstNum, secondNum, result As Double
    Dim op As String

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Num_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button19.Click, Button17.Click, Button15.Click, Button14.Click, Button13.Click, Button10.Click, btn4.Click
        Dim btn As Button = sender

        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If

        If btn.Text = "." And Not TextBox1.Text.Contains(".") Then
            TextBox1.Text += btn.Text
        ElseIf btn.Text <> "." Then
            TextBox1.Text += btn.Text
        End If
    End Sub

    Private Sub BtnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If

        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Op_Click(sender As Object, e As EventArgs) Handles Button8.Click, Button4.Click, Button3.Click, Button2.Click, Button18.Click, btnMOD.Click
        Dim btn As Button = sender

        firstNum = TextBox1.Text
        op = btn.Text
        TextBox1.Text = ""
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        secondNum = TextBox1.Text

        Try
            If op = "+" Then
                result = firstNum + secondNum
            ElseIf op = "-" Then
                result = firstNum - secondNum
            ElseIf op = "*" Then
                result = firstNum * secondNum
            ElseIf op = "/" Then
                If secondNum = 0 Then
                    Throw New Exception("Cannot divide by zero!")
                End If
                result = firstNum / secondNum
            ElseIf op = "MOD" Then
                result = firstNum Mod secondNum
            ElseIf op = "^" Then
                result = Math.Pow(firstNum, secondNum)
            End If

            TextBox1.Text = result.ToString()
        Catch ex As Exception
            TextBox1.Text = "Error: " & ex.Message
        End Try
    End Sub
End Class
