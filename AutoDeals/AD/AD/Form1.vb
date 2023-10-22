Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form2 As New Form2
        Dim form3 As New Form3
        Button1.BackColor = SystemColors.Control
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0

        Button2.BackColor = SystemColors.Control
        Button2.FlatStyle = FlatStyle.Flat
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Button1Enter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ' Enlarge the picture when the mouse enters.
        Dim currentSize As Size = Button1.Size
        Dim newSize As New Size(currentSize.Width + 10, currentSize.Height + 10) ' Adjust the size as needed
        Button1.Size = newSize
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat


    End Sub

    Private Sub Button2Enter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Dim currentSize As Size = Button2.Size
        Dim newSize As New Size(currentSize.Width + 10, currentSize.Height + 10)
        Button2.Size = newSize
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        ' Shrink the picture back to its default size when the mouse leaves.
        Dim currentSize As Size = Button1.Size
        Dim newSize As New Size(currentSize.Width - 10, currentSize.Height - 10) ' Adjust the size as needed
        Button1.Size = newSize
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        ' Shrink the picture back to its default size when the mouse leaves.
        Dim currentSize As Size = Button2.Size
        Dim newSize As New Size(currentSize.Width - 10, currentSize.Height - 10) ' Adjust the size as needed
        Button2.Size = newSize
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
        MessageBox.Show("Press Auto Deals to go back in the main page", "For your information", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
        MessageBox.Show("Press Auto Deals to go back in the main page", "For your information", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub

End Class
