Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim form1 As New Form1()


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = SystemColors.Control
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
    End Sub



    Private Sub Button1Enter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ' Enlarge the picture when the mouse enters.
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        form1.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedIndex
            'HONDA'
            Case 0
                ComboBox2.Items.Clear()
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                GroundClearance.Text = ""
                StartOption.Text = ""
                TransmissionType.Text = ""
                FrontBrake.Text = ""
                PictureBox2.Image = Nothing
                ComboBox2.Items.Add("PCX 160")
                ComboBox2.Items.Add("ADV 160")
                ComboBox2.Items.Add("Click 125")
                ComboBox2.Items.Add("Dio 110")
                PictureBox1.Image = My.Resources.Honda
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                GroundClearance.Text = ""
                StartOption.Text = ""
                TransmissionType.Text = ""
                FrontBrake.Text = ""
                TotalPrice.Text = ""
                MonthlyDues.Text = ""
                TextBox1.Text = ""
                TextBox1.Enabled = True
                'YAMAHA'

            Case 1
                ComboBox2.Items.Clear()
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                GroundClearance.Text = ""
                StartOption.Text = ""
                TransmissionType.Text = ""
                FrontBrake.Text = ""
                PictureBox2.Image = Nothing
                ComboBox2.Items.Add("Aerox 155")
                ComboBox2.Items.Add("Mio i125")
                ComboBox2.Items.Add("Nmax 155")
                ComboBox2.Items.Add("Xsr 155")
                PictureBox1.Image = My.Resources.Yamaha
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                GroundClearance.Text = ""
                StartOption.Text = ""
                TransmissionType.Text = ""
                FrontBrake.Text = ""
                TotalPrice.Text = ""
                MonthlyDues.Text = ""
                TextBox1.Text = ""
                TextBox1.Enabled = True
        End Select




    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0

                Select Case ComboBox2.SelectedIndex

                    Case 0
                        'PCX'
                        PictureBox2.Image = My.Resources.Pcx160
                        Price.Text = "₱127,900"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "157CC"
                        Power.Text = "11.8 Nm"
                        GroundClearance.Text = "134mm"
                        StartOption.Text = "Electric"
                        TransmissionType.Text = "Automatic"
                        FrontBrake.Text = "Disc Brake"
                    Case 1
                        'ADV'
                        PictureBox2.Image = My.Resources.ADV1601
                        Price.Text = "₱164,900"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "157CC"
                        Power.Text = "15.8 Nm"
                        GroundClearance.Text = "165mm"
                        StartOption.Text = "Electric"
                        TransmissionType.Text = "Automatic"
                        FrontBrake.Text = "Disc Brake"
                    Case 2
                        'Click'
                        PictureBox2.Image = My.Resources.Click125
                        Price.Text = "₱81,200"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "125CC"
                        Power.Text = "11 Nm"
                        GroundClearance.Text = "132mm"
                        StartOption.Text = "Electric"
                        TransmissionType.Text = "Automatic"
                        FrontBrake.Text = "Disc Brake"
                    Case 3
                        'xsr'
                        PictureBox2.Image = My.Resources.Dio
                        Price.Text = "₱62,400"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "109.20CC"
                        Power.Text = "8.77 Nm"
                        GroundClearance.Text = "158mm"
                        StartOption.Text = "Kick/self"
                        TransmissionType.Text = "Automatic"
                        FrontBrake.Text = "CBS"
                End Select

            Case 1
                Select Case ComboBox2.SelectedIndex
                    Case 0
                        'Aerox'
                        PictureBox2.Image = My.Resources.Aerox_155
                        Price.Text = "₱135,700"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "155CC"
                        Power.Text = "15.1 Nm"
                        GroundClearance.Text = "145mm"
                        StartOption.Text = "Electric"
                        TransmissionType.Text = "Automatic"
                        FrontBrake.Text = "Disc Brake"
                    Case 1
                        'MioI'
                        PictureBox2.Image = My.Resources.Mio
                        Price.Text = "₱80,400"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "125CC"
                        Power.Text = "9.3 Nm"
                        GroundClearance.Text = "135mm"
                        StartOption.Text = "Kick & Electric"
                        TransmissionType.Text = "Automatic"
                        FrontBrake.Text = "Disc Brake"
                    Case 2
                        'Nmax'
                        PictureBox2.Image = My.Resources.Nmax
                        Price.Text = "₱151,900"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "155CC"
                        Power.Text = "15.1 Nm"
                        GroundClearance.Text = "125mm"
                        StartOption.Text = "Electric"
                        TransmissionType.Text = "Automatic"
                        FrontBrake.Text = "Disc Brake"
                    Case 2
                        'XSR'
                        PictureBox2.Image = My.Resources.Xsr
                        Price.Text = "₱162,900"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "155CC"
                        Power.Text = "14.7 Nm"
                        GroundClearance.Text = "170mm"
                        StartOption.Text = "Electric"
                        TransmissionType.Text = "Manual"
                        FrontBrake.Text = "Disc Brake"

                End Select
        End Select
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Price.Text = ""
        AnnualInterest.Text = ""
        Engine.Text = ""
        Power.Text = ""
        GroundClearance.Text = ""
        StartOption.Text = ""
        TransmissionType.Text = ""
        FrontBrake.Text = ""
        TotalPrice.Text = ""
        MonthlyDues.Text = ""
        TextBox1.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.Items.Clear()
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing

    End Sub
    Private Sub Clearbtn_MouseEnter(sender As Object, e As EventArgs) Handles Clearbtn.MouseEnter
        ' Change the button's appearance when the mouse enters.
        Clearbtn.BackColor = Color.DarkGray
        Clearbtn.ForeColor = Color.White
    End Sub

    Private Sub Clearbtn_MouseLeave(sender As Object, e As EventArgs) Handles Clearbtn.MouseLeave
        ' Restore the button's appearance when the mouse leaves.
        Clearbtn.BackColor = Color.Transparent
        Clearbtn.ForeColor = Color.White
        TextBox1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim userInput As String = TextBox1.Text
        TextBox1.Enabled = False

        ' Check if the user didn't input anything.
        If String.IsNullOrEmpty(userInput) Then
            TextBox1.Enabled = True
            MessageBox.Show("Please enter a value.")
        Else
            ' Attempt to parse the input as an integer.
            Dim result As Integer

            If Integer.TryParse(userInput, result) Then
                TextBox1.Enabled = False
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        Select Case ComboBox2.SelectedIndex
                            Case 0

                                Dim price As Integer = 127900.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 1
                                Dim price As Integer = 164900.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 2
                                Dim price As Integer = 81200.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)
                            Case 3
                                Dim price As Integer = 62400.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD * TextBox1.Text
                                Dim YearstoPay As Integer = YearstoPay

                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                        End Select

                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0

                                Dim price As Integer = 135700.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 1
                                Dim price As Integer = 80400.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 2
                                Dim price As Integer = 151900.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)
                            Case 3
                                Dim price As Integer = 162000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                        End Select
                End Select
            Else
                ' The input is not a valid integer.
                TextBox1.Enabled = True
                MessageBox.Show("Invalid input. Please enter a valid integer.")
            End If
        End If
    End Sub
End Class
