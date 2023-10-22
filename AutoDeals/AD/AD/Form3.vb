Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
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
            'Audi'
            Case 0
                ComboBox2.Items.Clear()
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
                PictureBox2.Image = Nothing
                ComboBox2.Items.Add("A4")
                ComboBox2.Items.Add("R8")
                ComboBox2.Items.Add("Q3")
                ComboBox2.Items.Add("A6")
                PictureBox1.Image = My.Resources.Audi
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
                TotalPrice.Text = ""
                MonthlyDues.Text = ""
                TextBox1.Text = ""
                TextBox1.Enabled = True

                 'TESLA'
            Case 1
                ComboBox2.Items.Clear()
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
                PictureBox2.Image = Nothing
                ComboBox2.Items.Add("Model S")
                ComboBox2.Items.Add("Model 3")
                ComboBox2.Items.Add("Model X")
                ComboBox2.Items.Add("Model Y")
                PictureBox1.Image = My.Resources.Tesla
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
                TotalPrice.Text = ""
                MonthlyDues.Text = ""
                TextBox1.Text = ""
                TextBox1.Enabled = True

                'Honda'
            Case 2
                ComboBox2.Items.Clear()
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
                PictureBox2.Image = Nothing
                ComboBox2.Items.Add("Civic")
                ComboBox2.Items.Add("Civic Type R")
                ComboBox2.Items.Add("Honda City")
                ComboBox2.Items.Add("Cr V")
                PictureBox1.Image = My.Resources.Honda_Car
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
                TotalPrice.Text = ""
                MonthlyDues.Text = ""
                TextBox1.Text = ""
                TextBox1.Enabled = True

                 'Chevrolet'
            Case 3
                ComboBox2.Items.Clear()
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
                PictureBox2.Image = Nothing
                ComboBox2.Items.Add("Camaro")
                ComboBox2.Items.Add("Corvette")
                ComboBox2.Items.Add("Cruze")
                ComboBox2.Items.Add("Impala")
                PictureBox1.Image = My.Resources.Chevrolet
                Price.Text = ""
                AnnualInterest.Text = ""
                Engine.Text = ""
                Power.Text = ""
                NOC.Text = ""
                FT.Text = ""
                TransmissionType.Text = ""
                Bodyttype.Text = ""
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
                    'Audi'
                    Case 0
                        'A4'
                        PictureBox2.Image = My.Resources.Audi_A4
                        Price.Text = "₱3,450,000"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1998CC"
                        Power.Text = "320 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Automatic"
                        Bodyttype.Text = "Sedan"
                    Case 1
                        'R8'
                        PictureBox2.Image = My.Resources.Audi_R8
                        Price.Text = "₱10,909,515"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "5204CC"
                        Power.Text = "620 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Automatic"
                        Bodyttype.Text = "Sports Car"
                    Case 2
                        'Q3'
                        PictureBox2.Image = My.Resources.Audi_Q3
                        Price.Text = "₱3,900,000"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1984CC"
                        Power.Text = "221 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "SUV"
                    Case 3
                        'A6'
                        PictureBox2.Image = My.Resources.Audi_A6
                        Price.Text = "₱4,690,000"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1984 CC"
                        Power.Text = "252 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "Sedan"
                End Select
            Case 1

                Select Case ComboBox2.SelectedIndex
                    'Tesla'
                    Case 0
                        'S'
                        PictureBox2.Image = My.Resources.ModelS
                        Price.Text = "₱4,049,460"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1020hp"
                        Power.Text = "670 Nm"
                        NOC.Text = "(Combustion Engine)"
                        FT.Text = "Electricity"
                        TransmissionType.Text = "Automatic"
                        Bodyttype.Text = "Sedan"
                    Case 1
                        '3'
                        PictureBox2.Image = My.Resources.Model3
                        Price.Text = "₱3,135,000"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "720hp"
                        Power.Text = "540 Nm"
                        NOC.Text = "(Combustion Engine)"
                        FT.Text = "Electricity"
                        TransmissionType.Text = "Automatic"
                        Bodyttype.Text = "Sedan"
                    Case 2
                        'X'
                        PictureBox2.Image = My.Resources.ModelX
                        Price.Text = "₱4,560,000"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "670hp"
                        Power.Text = "498 Nm"
                        NOC.Text = "(Combustion Engine)"
                        FT.Text = "Electricity"
                        TransmissionType.Text = "Automatic"
                        Bodyttype.Text = "SUV"
                    Case 3
                        'Y'
                        PictureBox2.Image = My.Resources.Model_Y
                        Price.Text = "₱2,736,000"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "520hp"
                        Power.Text = "390 Nm"
                        NOC.Text = "(Combustion Engine)"
                        FT.Text = "Electricity"
                        TransmissionType.Text = "Automatic"
                        Bodyttype.Text = "SUV"
                End Select
            Case 2

                Select Case ComboBox2.SelectedIndex
                    'Honda'
                    Case 0
                        'Civic'
                        PictureBox2.Image = My.Resources.Civic
                        Price.Text = "₱1,583,000.00"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1498 cc"
                        Power.Text = "400 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "Sedan"
                    Case 1
                        'Type R'
                        PictureBox2.Image = My.Resources.Civic_Type_R
                        Price.Text = "₱3,870,000.00"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1996 cc"
                        Power.Text = "420 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "Sports Car"
                    Case 2
                        'City'
                        PictureBox2.Image = My.Resources.Honda_City
                        Price.Text = "₱973,000.00"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1498 hp"
                        Power.Text = "145 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "Sedan"
                    Case 3
                        'CR V'
                        PictureBox2.Image = My.Resources.Cr_V
                        Price.Text = "₱2,590,000.00"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1993  hp"
                        Power.Text = "187 Nm"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "SUV"
                End Select

            Case 3

                Select Case ComboBox2.SelectedIndex
                    'Chevrolet'
                    Case 0
                        'Camaro'
                        PictureBox2.Image = My.Resources.Camaro
                        Price.Text = "₱4,266,888.00"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1998 cc"
                        Power.Text = "275 hp"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Automatic"
                        Bodyttype.Text = "Pony"
                    Case 1
                        'Corvette'
                        PictureBox2.Image = My.Resources.Corvette
                        Price.Text = "₱12,421,888.00"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "6162 cc"
                        Power.Text = "490 hp"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "Sports Car"
                    Case 2
                        'Cruze'
                        PictureBox2.Image = My.Resources.Cruze
                        Price.Text = "₱1,104,000"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "1998 cc"
                        Power.Text = "163.7 hp"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "Sedan"
                    Case 3
                        'Impala'
                        PictureBox2.Image = My.Resources.Impala
                        Price.Text = "₱3,053,490.00"
                        AnnualInterest.Text = "10%"
                        Engine.Text = "2457 hp"
                        Power.Text = "305 hp"
                        NOC.Text = "4"
                        FT.Text = "Petrol"
                        TransmissionType.Text = "Manual"
                        Bodyttype.Text = "Sedan"
                End Select

        End Select
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Price.Text = ""
        AnnualInterest.Text = ""
        Engine.Text = ""
        Power.Text = ""
        NOC.Text = ""
        FT.Text = ""
        TransmissionType.Text = ""
        Bodyttype.Text = ""
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

                                Dim price As Integer = 3450000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 1
                                Dim price As Integer = 10909515.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 2
                                Dim price As Integer = 3900000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)
                            Case 3
                                Dim price As Integer = 4690000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD * TextBox1.Text
                                Dim YearstoPay As Integer = YearstoPay

                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                        End Select
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0

                                Dim price As Integer = 4049460.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 1
                                Dim price As Integer = 3135000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 2
                                Dim price As Integer = 4560000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)
                            Case 3
                                Dim price As Integer = 2736000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD * TextBox1.Text
                                Dim YearstoPay As Integer = YearstoPay

                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                        End Select

                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0

                                Dim price As Integer = 1589000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 1
                                Dim price As Integer = 3870000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 2
                                Dim price As Integer = 973000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)
                            Case 3
                                Dim price As Integer = 2590000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD * TextBox1.Text
                                Dim YearstoPay As Integer = YearstoPay

                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                        End Select

                    Case 3

                        Select Case ComboBox2.SelectedIndex
                            Case 0

                                Dim price As Integer = 4266888.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 1
                                Dim price As Integer = 12421888.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)

                            Case 2
                                Dim price As Integer = 1104000.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD + price


                                TotalPrice.Text = String.Format("₱ {0:N2}", Tprice)
                                MonthlyDues.Text = String.Format("₱ {0:N2}", MD)
                            Case 3
                                Dim price As Integer = 3053490.0
                                Dim MD As Integer = (price * 0.1) * TextBox1.Text
                                Dim Tprice As Integer = MD * TextBox1.Text
                                Dim YearstoPay As Integer = YearstoPay

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
