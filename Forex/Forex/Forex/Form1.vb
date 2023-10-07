Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Computetxtbox.ReadOnly = True
        PictureBox3.Image = My.Resources.Globe
        PictureBox1.Hide()
        PictureBox2.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        Amounttxtbox.Text = ""
        Computetxtbox.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox1.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub Tolbl_Click(sender As Object, e As EventArgs) Handles Tolbl.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox1.Show()

        Select Case ComboBox1.SelectedIndex
            Case 0
                PictureBox1.Image = My.Resources.Untitled_design
            Case 1
                PictureBox1.Image = My.Resources.HKG_DOLLAR
            Case 2
                PictureBox1.Image = My.Resources.CND_DOLLAR
            Case 3
                PictureBox1.Image = My.Resources.IND_RUPEE
            Case 4
                PictureBox1.Image = My.Resources.Sri_lanka_money
            Case 5
                PictureBox1.Image = My.Resources.UAE_Dirham
            Case 6
                PictureBox1.Image = My.Resources.PHP
            Case 7
                PictureBox1.Image = My.Resources.UK_pound
            Case 8
                PictureBox1.Image = My.Resources.JPN_YEN
            Case 9
                PictureBox1.Image = My.Resources.Euro
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        PictureBox2.Show()
        Select Case ComboBox2.SelectedIndex
            Case 0
                PictureBox2.Image = My.Resources.Untitled_design
            Case 1
                PictureBox2.Image = My.Resources.HKG_DOLLAR
            Case 2
                PictureBox2.Image = My.Resources.CND_DOLLAR
            Case 3
                PictureBox2.Image = My.Resources.IND_RUPEE
            Case 4
                PictureBox2.Image = My.Resources.Sri_lanka_money
            Case 5
                PictureBox2.Image = My.Resources.UAE_Dirham
            Case 6
                PictureBox2.Image = My.Resources.PHP
            Case 7
                PictureBox2.Image = My.Resources.UK_pound
            Case 8
                PictureBox2.Image = My.Resources.JPN_YEN
            Case 9
                PictureBox2.Image = My.Resources.Euro
        End Select
    End Sub
    Private Sub Computebtn_Click(sender As Object, e As EventArgs) Handles Computebtn.Click
        Dim userInput As String = Amounttxtbox.Text
        Dim number As Double



        If Double.TryParse(userInput, number) Then
            Select Case ComboBox1.SelectedIndex
                'US DOLLAR'
                Case 0
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 0
                            MessageBox.Show("Cannot convert to the same currency")

                        'HKD CVT'
                        Case 1
                            Dim sum As Double = number * 7.83
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 1.37
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 83.12
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 322.66
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 3.67
                            Computetxtbox.Text = String.Format("{0:N2}د.إ ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 56.7
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK POUND CVT'
                            Dim sum As Double = number * 0.82
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'JPN YEN CVT'
                            Dim sum As Double = number * 149.22
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.94
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select

                    'HKD'
                Case 1
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 1
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 0.13
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 0.17
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 10.61
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 41.2
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 0.47
                            Computetxtbox.Text = String.Format("{0:N2}د.إ ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 7.24
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK CVT'
                            Dim sum As Double = number * 0.1
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'Japan yen CVT'
                            Dim sum As Double = number * 19.05
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.12
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select
                   ' CND'
                Case 2
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 2
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 0.73
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 5.72
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 60.74
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 235.8
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 2.68
                            Computetxtbox.Text = String.Format("{0:N2}د.إ ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 41.44
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK CVT'
                            Dim sum As Double = number * 0.6
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'JAPAN YEN CVT'
                            Dim sum As Double = number * 109.05
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.69
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select

                      ' IND'
                Case 3
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 3
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 0.012
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 0.094
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 0.016
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 3.88
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 0.044
                            Computetxtbox.Text = String.Format("{0:N2}د.إ ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 0.68
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK CVT'
                            Dim sum As Double = number * 0.0098
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'JAPAN YEN CVT'
                            Dim sum As Double = number * 1.8
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.011
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select
                     ' SRL'
                Case 4
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 4
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 0.0031
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 0.024
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 0.0042
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 0.26
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 0.011
                            Computetxtbox.Text = String.Format("{0:N2}د.إ ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 0.18
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK CVT'
                            Dim sum As Double = number * 0.0025
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'JAPAN YEN CVT'
                            Dim sum As Double = number * 0.46
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.0029
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select
                    ' UAE'
                Case 5
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 5
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 0.27
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 2.13
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 0.37
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 22.63
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 87.85
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 15.44
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK CVT'
                            Dim sum As Double = number * 0.22
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'JAPAN YEN CVT'
                            Dim sum As Double = number * 40.63
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.26
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select

                    ' PHP'
                Case 6
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 6
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 0.018
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 0.14
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 0.024
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 1.47
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 5.69
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 0.065
                            Computetxtbox.Text = String.Format("{0:N2} د.إ", sum)
                        Case 7
                            'UK CVT'
                            Dim sum As Double = number * 0.014
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'JAPAN YEN CVT'
                            Dim sum As Double = number * 2.63
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.017
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select

                    ' UK'

                Case 7
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 7
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 1.22
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 9.59
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 1.67
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 101.74
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 394.94
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 4.5
                            Computetxtbox.Text = String.Format("{0:N2} د.إ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 69.4
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 8
                            'JAPAN YEN CVT'
                            Dim sum As Double = number * 182.65
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 1.15
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select

                    ' YEN'

                Case 8
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 8
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 0.0067
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 0.052
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 0.0092
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 0.56
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 2.16
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 0.025
                            Computetxtbox.Text = String.Format("{0:N2} د.إ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 0.38
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK POUND YEN CVT'
                            Dim sum As Double = number * 0.0055
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 9
                            'EURO CVT'
                            Dim sum As Double = number * 0.0063
                            Computetxtbox.Text = String.Format("€ {0:N2}", sum)
                    End Select

                    ' EURO'

                Case 9
                    Select Case ComboBox2.SelectedIndex
                        'MSGBOX'
                        Case 9
                            MessageBox.Show("Cannot convert to the same currency")

                        Case 0
                            'USD CVT'
                            Dim sum As Double = number * 1.06
                            Computetxtbox.Text = String.Format("$ {0:N2}", sum)
                        Case 1
                            'HKD CVT'
                            Dim sum As Double = number * 8.3
                            Computetxtbox.Text = String.Format("HK$ {0:N2}", sum)
                        Case 2
                            'CND CVT'
                            Dim sum As Double = number * 1.45
                            Computetxtbox.Text = String.Format("Can$ {0:N2}", sum)
                        Case 3
                            'IND CVT'
                            Dim sum As Double = number * 88.12
                            Computetxtbox.Text = String.Format("₹ {0:N2}", sum)
                        Case 4
                            'SRL CVT'
                            Dim sum As Double = number * 342.07
                            Computetxtbox.Text = String.Format("ரூ {0:N2}", sum)
                        Case 5
                            'UAE CVT'
                            Dim sum As Double = number * 3.89
                            Computetxtbox.Text = String.Format("{0:N2} د.إ", sum)
                        Case 6
                            'PHP CVT'
                            Dim sum As Double = number * 60.11
                            Computetxtbox.Text = String.Format("₱ {0:N2}", sum)
                        Case 7
                            'UK POUND YEN CVT'
                            Dim sum As Double = number * 0.87
                            Computetxtbox.Text = String.Format("£ {0:N2}", sum)
                        Case 8
                            'YEN CVT'
                            Dim sum As Double = number * 158.22
                            Computetxtbox.Text = String.Format("¥ {0:N2}", sum)
                    End Select
            End Select
        ElseIf Amounttxtbox.Text = "" Then
            ' Conversion failed, user did not enter a valid number
            MessageBox.Show("Textbox is empty. Please enter amount to change.")

        Else
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class
