Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Origintxtbox.ReadOnly = True
        Destinationtxtbox.ReadOnly = True
        GrossFaretxtbox.ReadOnly = True
        Discounttxtbox.ReadOnly = True
        Netfaretxtbox.ReadOnly = True


    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Origintxtbox.Clear()
        Destinationtxtbox.Clear()
        GrossFaretxtbox.Clear()
        Discounttxtbox.Clear()
        Netfaretxtbox.Clear()
    End Sub

    Private Sub Proceedbtn_Click(sender As Object, e As EventArgs) Handles Proceedbtn.Click

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("ComboBox is empty.")
        ElseIf ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("ComboBox is empty.")
        ElseIf ComboBox3.SelectedIndex = -1 Then
            MessageBox.Show("ComboBox is empty.")
        Else
            MessageBox.Show("You are already in this destination", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If ComboBox1.SelectedIndex > ComboBox2.SelectedIndex Then
            Dim sum As Integer = ComboBox1.SelectedIndex - ComboBox2.SelectedIndex
            sum = sum * 20
            Dim DC As Integer = ComboBox3.SelectedIndex

            Select Case DC
                Case 0
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Discounttxtbox.Text = "0"
                    Netfaretxtbox.Text = sum
                Case 1
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Dim discounts As Integer = sum * 0.1
                    Discounttxtbox.Text = discounts
                    Netfaretxtbox.Text = sum - discounts
                Case 2
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Dim discounts As Integer = sum * 0.15
                    Discounttxtbox.Text = discounts
                    Netfaretxtbox.Text = sum - discounts
                Case 3
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Dim discounts As Integer = sum * 0.2
                    Discounttxtbox.Text = discounts
                    Netfaretxtbox.Text = sum - discounts
                Case 4
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Dim discounts As Integer = sum * 0.5
                    Discounttxtbox.Text = discounts
                    Netfaretxtbox.Text = sum - discounts
            End Select

        ElseIf ComboBox1.SelectedIndex < ComboBox2.SelectedIndex Then
            Dim sum As Integer = ComboBox2.SelectedIndex - ComboBox1.SelectedIndex
            sum = sum * 20
            Dim DC As Integer = ComboBox3.SelectedIndex

            Select Case DC
                Case 0
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Discounttxtbox.Text = "0"
                    Netfaretxtbox.Text = sum
                Case 1
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Dim discounts As Integer = sum * 0.1
                    Discounttxtbox.Text = discounts
                    Netfaretxtbox.Text = sum - discounts
                Case 3
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Dim discounts As Integer = sum * 0.2
                    Discounttxtbox.Text = discounts
                    Netfaretxtbox.Text = sum - discounts
                Case 4
                    Origintxtbox.Text = ComboBox1.SelectedItem
                    Destinationtxtbox.Text = ComboBox2.SelectedItem
                    GrossFaretxtbox.Text = sum
                    Dim discounts As Integer = sum * 0.5
                    Discounttxtbox.Text = discounts
                    Netfaretxtbox.Text = sum - discounts

            End Select
        ElseIf ComboBox1.SelectedIndex = ComboBox2.SelectedIndex Then


        End If

    End Sub
End Class
