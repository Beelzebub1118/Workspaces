Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2

    Private Sub NametxtBox_TextChanged(sender As Object, e As EventArgs) Handles NametxtBox.TextChanged

        NametxtBox.ReadOnly = True
        NametxtBox.Enabled = False
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Department2txtbox.TextChanged
        Department2txtbox.ReadOnly = True
        Department2txtbox.Enabled = False
    End Sub

    Private Sub WorkingHours2txtbox_TextChanged(sender As Object, e As EventArgs) Handles WorkingHours2txtbox.TextChanged
        WorkingHours2txtbox.ReadOnly = True
        WorkingHours2txtbox.Enabled = False
    End Sub

    Private Sub RegularRate2txtbox_TextChanged(sender As Object, e As EventArgs) Handles RegularRate2txtbox.TextChanged
        RegularRate2txtbox.ReadOnly = True
        RegularRate2txtbox.Enabled = False
    End Sub

    Private Sub Overtime2txtBox_TextChanged(sender As Object, e As EventArgs) Handles Overtime2txtBox.TextChanged
        Overtime2txtBox.ReadOnly = True
        Overtime2txtBox.Enabled = False
    End Sub

    Private Sub OvertimeRate2txtbox_TextChanged(sender As Object, e As EventArgs) Handles OvertimeRate2txtbox.TextChanged
        OvertimeRate2txtbox.ReadOnly = True
        OvertimeRate2txtbox.Enabled = False
    End Sub

    Private Sub GrossSalaryDeductiontxtbox_TextChanged(sender As Object, e As EventArgs) Handles GrossSalaryDeductiontxtbox.TextChanged
        GrossSalaryDeductiontxtbox.ReadOnly = True
        GrossSalaryDeductiontxtbox.Enabled = False
    End Sub

    Private Sub SSStxtbox_TextChanged(sender As Object, e As EventArgs) Handles SSStxtbox.TextChanged
        SSStxtbox.ReadOnly = True
        SSStxtbox.Enabled = False
    End Sub

    Private Sub Philhealthtxtbox_TextChanged(sender As Object, e As EventArgs) Handles Philhealthtxtbox.TextChanged
        Philhealthtxtbox.ReadOnly = True
        Philhealthtxtbox.Enabled = False
    End Sub

    Private Sub Pagibigtxtbox_TextChanged(sender As Object, e As EventArgs) Handles Pagibigtxtbox.TextChanged
        Pagibigtxtbox.ReadOnly = True
        Pagibigtxtbox.Enabled = False
    End Sub

    Private Sub Incometaxtxtbox_TextChanged(sender As Object, e As EventArgs) Handles Incometaxtxtbox.TextChanged
        Incometaxtxtbox.ReadOnly = True
        Incometaxtxtbox.Enabled = False
    End Sub

    Private Sub Totaldeductiontxtbox_TextChanged(sender As Object, e As EventArgs) Handles Totaldeductiontxtbox.TextChanged
        Totaldeductiontxtbox.ReadOnly = True
        Totaldeductiontxtbox.Enabled = False
    End Sub

    Private Sub Netpaytxtbox_TextChanged(sender As Object, e As EventArgs) Handles Netpaytxtbox.TextChanged
        Netpaytxtbox.ReadOnly = True
        Netpaytxtbox.Enabled = False


    End Sub

    Private Sub NEWbtn_Click(sender As Object, e As EventArgs) Handles NEWbtn.Click
        Dim Form1 As New Form1()
        Form1.Show()

        Hide()
    End Sub
End Class