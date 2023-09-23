<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Weighttxtbox = New System.Windows.Forms.TextBox()
        Me.Heighttxtbox = New System.Windows.Forms.TextBox()
        Me.BMItxtbox = New System.Windows.Forms.TextBox()
        Me.BMICATtxtbox = New System.Windows.Forms.TextBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Convertbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Weighttxtbox
        '
        Me.Weighttxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weighttxtbox.Location = New System.Drawing.Point(142, 142)
        Me.Weighttxtbox.Name = "Weighttxtbox"
        Me.Weighttxtbox.Size = New System.Drawing.Size(196, 24)
        Me.Weighttxtbox.TabIndex = 0
        Me.Weighttxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Heighttxtbox
        '
        Me.Heighttxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heighttxtbox.Location = New System.Drawing.Point(142, 220)
        Me.Heighttxtbox.Name = "Heighttxtbox"
        Me.Heighttxtbox.Size = New System.Drawing.Size(196, 24)
        Me.Heighttxtbox.TabIndex = 1
        Me.Heighttxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BMItxtbox
        '
        Me.BMItxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMItxtbox.Location = New System.Drawing.Point(142, 303)
        Me.BMItxtbox.Name = "BMItxtbox"
        Me.BMItxtbox.Size = New System.Drawing.Size(196, 24)
        Me.BMItxtbox.TabIndex = 2
        Me.BMItxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BMICATtxtbox
        '
        Me.BMICATtxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMICATtxtbox.Location = New System.Drawing.Point(251, 394)
        Me.BMICATtxtbox.Name = "BMICATtxtbox"
        Me.BMICATtxtbox.Size = New System.Drawing.Size(196, 24)
        Me.BMICATtxtbox.TabIndex = 3
        Me.BMICATtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearbtn.Location = New System.Drawing.Point(12, 459)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(88, 27)
        Me.Clearbtn.TabIndex = 4
        Me.Clearbtn.Text = "CLEAR"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Convertbtn
        '
        Me.Convertbtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Convertbtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Convertbtn.Location = New System.Drawing.Point(359, 459)
        Me.Convertbtn.Name = "Convertbtn"
        Me.Convertbtn.Size = New System.Drawing.Size(88, 27)
        Me.Convertbtn.TabIndex = 5
        Me.Convertbtn.Text = "CONVERT"
        Me.Convertbtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMICalculator.My.Resources.Resources.BMI_CAlculator__475_x_537_px_
        Me.ClientSize = New System.Drawing.Size(459, 498)
        Me.Controls.Add(Me.Convertbtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.BMICATtxtbox)
        Me.Controls.Add(Me.BMItxtbox)
        Me.Controls.Add(Me.Heighttxtbox)
        Me.Controls.Add(Me.Weighttxtbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Weighttxtbox As TextBox
    Friend WithEvents Heighttxtbox As TextBox
    Friend WithEvents BMItxtbox As TextBox
    Friend WithEvents BMICATtxtbox As TextBox
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Convertbtn As Button
End Class
