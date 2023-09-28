Public Class Form2
    Private counter As Integer = 1
    Private Sub NEWbtn_Click(sender As Object, e As EventArgs) Handles NEWbtn.Click
        Dim Form1 As New Form1
        Dim txtboxes As TextBox() = {Form1.AccNotxtbox, Form1.Nametxtbox, Form1.Addresstxtbox, Form1.AmountLoantxtbox, Form1.Interestratetxtbox, Form1.yearstopaytxtbox}
        counter += 1
        ' Format the counter as a five-digit string with leading zeros
        Dim counterText As String = counter.ToString("00000")

        ' Set the formatted counter text in the counter textbox
        Form1.LoanReftxtbox.Text = counterText
        Form1.Show()

        Hide()
    End Sub
End Class