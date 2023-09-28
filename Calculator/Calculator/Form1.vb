Public Class Form1
    Dim firstNum, secondNum, result As Double
    Dim op As String
    Dim isNewOperation As Boolean = True ' Indicates if a new operation should start.

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = "0"
        isNewOperation = True
        firstNum = 0 ' Initialize firstNum to 0.
    End Sub

    Private Sub Num_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button19.Click, Button17.Click, Button15.Click, Button14.Click, Button13.Click, Button10.Click, btn4.Click
        Dim btn As Button = sender

        If isNewOperation Then
            TextBox1.Text = ""
            isNewOperation = False
        End If

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.ReadOnly = True
    End Sub

    Private Sub Op_Click(sender As Object, e As EventArgs) Handles Button8.Click, Button4.Click, Button3.Click, Button2.Click, Button18.Click, btnMOD.Click
        Dim btn As Button = sender

        ' Update the operator only if a number is entered.
        If Not isNewOperation Then
            ' Store the value entered by the user in firstNum.
            Double.TryParse(TextBox1.Text, firstNum)
        End If

        ' Set the new operator.
        op = btn.Text

        TextBox1.Text = ""
        isNewOperation = True
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
            firstNum = result ' Update firstNum with the new result.
        Catch ex As Exception
            TextBox1.Text = "Error: " & ex.Message
        End Try
        isNewOperation = True ' Set isNewOperation to True after the result is calculated.
    End Sub
End Class
