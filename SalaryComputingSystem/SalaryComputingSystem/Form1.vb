Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1

    Private Sub Convertbtn_Click(sender As Object, e As EventArgs) Handles Convertbtn.Click
        Dim form2 As New Form2()
        form2.NametxtBox.Text = NametxtBox1.Text
        form2.Department2txtbox.Text = DepartmenttxtBox.Text
        form2.WorkingHours2txtbox.Text = WorkingHourstxtBox.Text
        form2.RegularRate2txtbox.Text = RegularRatetxtBox.Text
        form2.Overtime2txtBox.Text = OvertimetxtBox.Text
        form2.OvertimeRate2txtbox.Text = OvertimeRatetxtBox.Text


        Dim textFields As TextBox() = {NametxtBox1, DepartmenttxtBox, WorkingHourstxtBox, RegularRatetxtBox, OvertimetxtBox, OvertimeRatetxtBox}

        For Each textField As TextBox In textFields
            If String.IsNullOrWhiteSpace(textField.Text) Then
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Exit the event handler without further processing
            End If
        Next
        Dim userInput As String = NametxtBox1.Text


        Dim userInput1 As String = WorkingHourstxtBox.Text
        Dim userInput2 As String = RegularRatetxtBox.Text
        Dim userInput3 As String = OvertimetxtBox.Text
        Dim userInput4 As String = OvertimeRatetxtBox.Text

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

        If allValid Then
            ' All inputs are valid numbers

        Else
            ' At least one input is not a valid number
            MessageBox.Show("Please enter valid number:.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nameInput As String = NametxtBox1.Text
        Dim departmentInput As String = DepartmenttxtBox.Text

        Dim number1 As Integer
        Dim number2 As Integer

        If Integer.TryParse(nameInput, number1) Then
            ' Input in txtField1 is a number
            MessageBox.Show("Please enter a string in the first field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Integer.TryParse(departmentInput, number2) Then
            ' Input in txtField2 is a number
            MessageBox.Show("Please enter a string in the second field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        form2.Show()
        Hide()
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Dim textFields As TextBox() = {NametxtBox1, DepartmenttxtBox, WorkingHourstxtBox, RegularRatetxtBox, OvertimetxtBox, OvertimeRatetxtBox}

        For Each textField As TextBox In textFields
            textField.Text = "" ' Clear the text field
        Next
    End Sub

    Private Sub NametxtBox_TextChanged(sender As Object, e As EventArgs) Handles NametxtBox1.TextChanged

    End Sub
End Class
