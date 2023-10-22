<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotorcycleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Pricelbl = New System.Windows.Forms.Label()
        Me.AnnualAmountlbl = New System.Windows.Forms.Label()
        Me.TotalPricelbl = New System.Windows.Forms.Label()
        Me.MonthlyDuelbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(164, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Brand:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(85, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(486, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Car Model:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Honda", "Yamaha", "Suzuki", "Kawasaki"})
        Me.ComboBox1.Location = New System.Drawing.Point(281, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 25)
        Me.ComboBox1.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(614, 50)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(157, 25)
        Me.ComboBox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(323, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Specifications:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(12, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Year(s) to Pay:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(12, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Annual Interest:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(12, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(12, 525)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Monthly Due:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Carloan.My.Resources.Resources.logo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(-3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 110)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(490, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(321, 271)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Pricelbl
        '
        Me.Pricelbl.AutoSize = True
        Me.Pricelbl.BackColor = System.Drawing.Color.Transparent
        Me.Pricelbl.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pricelbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Pricelbl.Location = New System.Drawing.Point(176, 315)
        Me.Pricelbl.Name = "Pricelbl"
        Me.Pricelbl.Size = New System.Drawing.Size(66, 21)
        Me.Pricelbl.TabIndex = 13
        Me.Pricelbl.Text = "Pricelbl"
        '
        'AnnualAmountlbl
        '
        Me.AnnualAmountlbl.AutoSize = True
        Me.AnnualAmountlbl.BackColor = System.Drawing.Color.Transparent
        Me.AnnualAmountlbl.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnualAmountlbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.AnnualAmountlbl.Location = New System.Drawing.Point(176, 417)
        Me.AnnualAmountlbl.Name = "AnnualAmountlbl"
        Me.AnnualAmountlbl.Size = New System.Drawing.Size(42, 21)
        Me.AnnualAmountlbl.TabIndex = 15
        Me.AnnualAmountlbl.Text = "10%"
        '
        'TotalPricelbl
        '
        Me.TotalPricelbl.AutoSize = True
        Me.TotalPricelbl.BackColor = System.Drawing.Color.Transparent
        Me.TotalPricelbl.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPricelbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TotalPricelbl.Location = New System.Drawing.Point(176, 473)
        Me.TotalPricelbl.Name = "TotalPricelbl"
        Me.TotalPricelbl.Size = New System.Drawing.Size(48, 21)
        Me.TotalPricelbl.TabIndex = 16
        Me.TotalPricelbl.Text = "TPlbl"
        '
        'MonthlyDuelbl
        '
        Me.MonthlyDuelbl.AutoSize = True
        Me.MonthlyDuelbl.BackColor = System.Drawing.Color.Transparent
        Me.MonthlyDuelbl.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyDuelbl.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.MonthlyDuelbl.Location = New System.Drawing.Point(176, 525)
        Me.MonthlyDuelbl.Name = "MonthlyDuelbl"
        Me.MonthlyDuelbl.Size = New System.Drawing.Size(53, 21)
        Me.MonthlyDuelbl.TabIndex = 17
        Me.MonthlyDuelbl.Text = "MDlbl"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(169, 370)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 18
        '
        'MotorcycleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(842, 653)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MonthlyDuelbl)
        Me.Controls.Add(Me.TotalPricelbl)
        Me.Controls.Add(Me.AnnualAmountlbl)
        Me.Controls.Add(Me.Pricelbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MotorcycleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Pricelbl As Label
    Friend WithEvents AnnualAmountlbl As Label
    Friend WithEvents TotalPricelbl As Label
    Friend WithEvents MonthlyDuelbl As Label
    Friend WithEvents TextBox1 As TextBox
End Class
