Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BMItxtbox.ReadOnly = True
        BMICATtxtbox.ReadOnly = True
        BMItxtbox.Enabled = False
        BMICATtxtbox.Enabled = False
        Weighttxtbox.TabStop = False
        Heighttxtbox.TabStop = False
        Weighttxtbox.Text = "KG"
        Heighttxtbox.Text = "CM"
        Weighttxtbox.ForeColor = Color.Gray
        Heighttxtbox.ForeColor = Color.Gray
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Weighttxtbox.Text = String.Empty
        Heighttxtbox.Text = String.Empty
        BMItxtbox.Text = String.Empty
        BMICATtxtbox.Text = String.Empty

    End Sub

    Private Sub Convertbtn_Click(sender As Object, e As EventArgs) Handles Convertbtn.Click
        Dim Weight As Double
        Dim Height As Double
        Dim BMI As Double
        Dim meter As Double

        Dim WeightUser As String = Weighttxtbox.Text ' Assuming the user input is in a TextBox named TextBox1

        ' Try to parse the user input as a double
        Dim WeightInput As Double
        If Double.TryParse(WeightUser, WeightInput) Then
            ' Check if the parsed value is a whole number (integer)
            If WeightInput = Math.Floor(WeightInput) Then
                ' The user input is a valid integer
                MessageBox.Show("Valid integer input: " & WeightInput.ToString())
            Else
                ' The user input is not a valid integer
                MessageBox.Show("Invalid input. Please enter an integer.")
            End If
        Else
            ' The user input is not a valid double
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If

        Dim HeightUser As String = Weighttxtbox.Text ' Assuming the user input is in a TextBox named TextBox1

        ' Try to parse the user input as a double
        Dim HeightInput As Double
        If Double.TryParse(HeightUser, HeightInput) Then
            ' Check if the parsed value is a whole number (integer)
            If HeightInput = Math.Floor(HeightInput) Then
                ' The user input is a valid integer
                MessageBox.Show("Valid integer input " & HeightInput.ToString())
            Else
                ' The user input is not a valid integer
                MessageBox.Show("Invalid input. Please enter an integer.")
            End If
        Else
            ' The user input is not a valid double
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If





        Weight = Weighttxtbox.Text
        Height = Heighttxtbox.Text

        meter = Weight / 100
        BMI = Height / (meter * meter)
        BMItxtbox.Text = Math.Round(BMI, 2)

        If BMI < 15 Then
            BMICATtxtbox.Text = "Very severely underweight"

        ElseIf BMI >= 15 And BMI <= 16 Then
            BMICATtxtbox.Text = "Severely underweight"
        ElseIf BMI >= 15 And BMI <= 25 Then
            BMICATtxtbox.Text = "Underweight"
        ElseIf BMI >= 25 And BMI <= 30 Then
            BMICATtxtbox.Text = "Normal (Healthy Weight)"
        ElseIf BMI >= 30 And BMI <= 35 Then
            BMICATtxtbox.Text = "Overweight"
        ElseIf BMI >= 30 And BMI <= 35 Then
            BMICATtxtbox.Text = "Moderately Obese"
        ElseIf BMI >= 35 And BMI <= 40 Then
            BMICATtxtbox.Text = "Severely Obese"
        ElseIf BMI > 40 Then
            BMICATtxtbox.Text = "Very Severely Obese"


        End If
    End Sub
    Private Sub Weighttxtbox_GotFocus(sender As Object, e As EventArgs) Handles Weighttxtbox.GotFocus

        If Weighttxtbox.Text = "KG" Then
            Weighttxtbox.Clear()
            Weighttxtbox.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Heighttxtbox_GotFocus(sender As Object, e As EventArgs) Handles Heighttxtbox.GotFocus
        If Heighttxtbox.Text = "CM" Then
            Heighttxtbox.Clear()
            Heighttxtbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Weighttxtbox_LostFocus(sender As Object, e As EventArgs) Handles Weighttxtbox.LostFocus
        If Weighttxtbox.Text = "" Then
            Weighttxtbox.Text = "KG"
            Weighttxtbox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Heighttxtbox_LostFocus(sender As Object, e As EventArgs) Handles Heighttxtbox.LostFocus
        If Heighttxtbox.Text = "" Then
            Heighttxtbox.Text = "CM"
            Heighttxtbox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        For Each i As TextBox In Me.Controls.OfType(Of TextBox)()

        Next
        Weighttxtbox.Text = "KG"
        Weighttxtbox.ForeColor = Color.Gray
        Heighttxtbox.Text = "CM"
        Heighttxtbox.ForeColor = Color.Gray

    End Sub
    Private Sub Weighttxtbox_TextChanged(sender As Object, e As EventArgs) Handles Weighttxtbox.TextChanged

    End Sub
End Class
