Imports System.Reflection

Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private counter As Integer = 1
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Dim txtboxes As TextBox() = {AccNotxtbox, Nametxtbox, Addresstxtbox, AmountLoantxtbox, Interestratetxtbox, yearstopaytxtbox}


        For Each TB As TextBox In txtboxes
            TB.Text = ""
        Next

        counter += 1
        ' Format the counter as a five-digit string with leading zeros
        Dim counterText As String = counter.ToString("00000")

        ' Set the formatted counter text in the counter textbox
        LoanReftxtbox.Text = counterText


    End Sub

    Private Sub Computebtn_Click(sender As Object, e As EventArgs) Handles Computebtn.Click
        Dim form2 As New Form2()
        Dim txtboxes As TextBox() = {LoanReftxtbox, AccNotxtbox, Nametxtbox, Addresstxtbox, AmountLoantxtbox, Interestratetxtbox, yearstopaytxtbox}
        For Each textField As TextBox In txtboxes
            If String.IsNullOrWhiteSpace(textField.Text) Then
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Exit the event handler without further processing

            End If

        Next

        Dim userInput1 As String = LoanReftxtbox.Text
        Dim userInput2 As String = AccNotxtbox.Text
        Dim userInput3 As String = AmountLoantxtbox.Text
        Dim userInput4 As String = Interestratetxtbox.Text
        Dim userInput5 As String = yearstopaytxtbox.Text

        Dim allValid As Boolean = True

        If Not Integer.TryParse(userInput1, Nothing) Then
            allValid = False
        End If

        If Not Integer.TryParse(userInput2, Nothing) Then
            allValid = False
        End If

        If Not Integer.TryParse(userInput3, Nothing) Then
            allValid = False
        End If

        If Not Integer.TryParse(userInput4, Nothing) Then
            allValid = False
        End If

        If Not Integer.TryParse(userInput5, Nothing) Then
            allValid = False
        End If

        If allValid Then
            ' All inputs are valid numbers

        Else
            ' At least one input is not a valid number
            MessageBox.Show("Please enter valid number:.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        form2.LoanReftxtbox2.Text = LoanReftxtbox.Text
        form2.AccountNotxtbox2.Text = AccNotxtbox.Text
        form2.Nametxtbox2.Text = Nametxtbox.Text
        form2.Addresstxtbox2.Text = Addresstxtbox.Text
        form2.AmountLoantxtbox2.Text = "₱" + AmountLoantxtbox.Text
        form2.Yearstopaytxtbox2.Text = yearstopaytxtbox.Text
        form2.InterestRatetxtbox2.Text = Interestratetxtbox.Text + "%"

        Dim IR As Double = Interestratetxtbox.Text / 100
        Dim YTP As Integer = yearstopaytxtbox.Text
        Dim AL As Integer = AmountLoantxtbox.Text

        Dim totalinterest As Double = (AL * IR) * YTP
        form2.TotalInteresttxtbox2.Text = "₱" + totalinterest.ToString("N0")


        Dim TI As Double = AL + totalinterest
        form2.TotalLoantxtbox2.Text = "₱" + TI.ToString("N0")

        Dim MP As Double = totalinterest / (YTP * 12)

        form2.MonthlyPaymenttxtbox2.Text = "₱" + MP.ToString("N2")

        Dim TA As Double = TI / YTP
        form2.TotalAnnualtxtbox2.Text = "₱" + TA.ToString("N0")
        form2.Show()

        form2.LoanReftxtbox2.ReadOnly = True
        form2.AccountNotxtbox2.ReadOnly = True
        form2.Nametxtbox2.ReadOnly = True
        form2.Addresstxtbox2.ReadOnly = True
        form2.AmountLoantxtbox2.ReadOnly = True
        form2.InterestRatetxtbox2.ReadOnly = True
        form2.Yearstopaytxtbox2.ReadOnly = True
        form2.MonthlyPaymenttxtbox2.ReadOnly = True
        form2.TotalInteresttxtbox2.ReadOnly = True
        form2.TotalAnnualtxtbox2.ReadOnly = True
        form2.TotalLoantxtbox2.ReadOnly = True

        Hide()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoanReftxtbox.ReadOnly = True
    End Sub
End Class
