Public Class MotorcycleForm
    Dim form1 As New Form1()
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MotorcycleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Case 0
                ComboBox2.Items.Add("Wave 110 Alpha")
                ComboBox2.Items.Add("Click 125")
                ComboBox2.Items.Add("ADV 160")
                ComboBox2.Items.Add("PCX 160")
                PictureBox1.Image = My.Resources.Honda


        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class