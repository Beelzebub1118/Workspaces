<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Amountlbl = New System.Windows.Forms.Label()
        Me.Amounttxtbox = New System.Windows.Forms.TextBox()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tolbl = New System.Windows.Forms.Label()
        Me.Computetxtbox = New System.Windows.Forms.TextBox()
        Me.Computebtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Currencylbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Amountlbl
        '
        Me.Amountlbl.AutoSize = True
        Me.Amountlbl.BackColor = System.Drawing.SystemColors.Control
        Me.Amountlbl.Font = New System.Drawing.Font("Mongolian Baiti", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amountlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Amountlbl.Location = New System.Drawing.Point(12, 136)
        Me.Amountlbl.Name = "Amountlbl"
        Me.Amountlbl.Size = New System.Drawing.Size(77, 18)
        Me.Amountlbl.TabIndex = 0
        Me.Amountlbl.Text = "Amount:"
        '
        'Amounttxtbox
        '
        Me.Amounttxtbox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Amounttxtbox.Font = New System.Drawing.Font("Mongolian Baiti", 10.25!)
        Me.Amounttxtbox.Location = New System.Drawing.Point(108, 134)
        Me.Amounttxtbox.Name = "Amounttxtbox"
        Me.Amounttxtbox.Size = New System.Drawing.Size(305, 23)
        Me.Amounttxtbox.TabIndex = 1
        '
        'Resetbtn
        '
        Me.Resetbtn.BackColor = System.Drawing.SystemColors.Control
        Me.Resetbtn.Font = New System.Drawing.Font("Mongolian Baiti", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Resetbtn.Location = New System.Drawing.Point(426, 134)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(75, 24)
        Me.Resetbtn.TabIndex = 2
        Me.Resetbtn.Text = "Reset"
        Me.Resetbtn.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"US DOLLAR", "HKG DOLLAR", "CND DOLLAR", "IND RUPEE", "SLR RUPEE", "UAE DINAR", "PHP PESO", "UK POUND", "JPN YEN", "EURO"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 197)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 22)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"US DOLLAR", "HKG DOLLAR", "CND DOLLAR", "IND RUPEE", "SLR RUPEE", "UAE DINAR", "PHP PESO", "UK POUND", "JPN YEN", "EURO"})
        Me.ComboBox2.Location = New System.Drawing.Point(278, 197)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(223, 22)
        Me.ComboBox2.TabIndex = 4
        '
        'Tolbl
        '
        Me.Tolbl.AutoSize = True
        Me.Tolbl.BackColor = System.Drawing.Color.Transparent
        Me.Tolbl.Font = New System.Drawing.Font("Mongolian Baiti", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Tolbl.Location = New System.Drawing.Point(231, 182)
        Me.Tolbl.Name = "Tolbl"
        Me.Tolbl.Size = New System.Drawing.Size(41, 37)
        Me.Tolbl.TabIndex = 5
        Me.Tolbl.Text = "⇛"
        Me.Tolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Computetxtbox
        '
        Me.Computetxtbox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Computetxtbox.Font = New System.Drawing.Font("Mongolian Baiti", 10.25!)
        Me.Computetxtbox.Location = New System.Drawing.Point(210, 365)
        Me.Computetxtbox.Name = "Computetxtbox"
        Me.Computetxtbox.Size = New System.Drawing.Size(276, 23)
        Me.Computetxtbox.TabIndex = 7
        '
        'Computebtn
        '
        Me.Computebtn.BackColor = System.Drawing.SystemColors.Control
        Me.Computebtn.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Computebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Computebtn.Location = New System.Drawing.Point(45, 365)
        Me.Computebtn.Name = "Computebtn"
        Me.Computebtn.Size = New System.Drawing.Size(84, 23)
        Me.Computebtn.TabIndex = 8
        Me.Computebtn.Text = "Compute"
        Me.Computebtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(278, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(223, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 239)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(213, 108)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Currencylbl
        '
        Me.Currencylbl.AutoSize = True
        Me.Currencylbl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Currencylbl.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Currencylbl.Location = New System.Drawing.Point(272, 12)
        Me.Currencylbl.Name = "Currencylbl"
        Me.Currencylbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Currencylbl.Size = New System.Drawing.Size(193, 34)
        Me.Currencylbl.TabIndex = 12
        Me.Currencylbl.Text = "CURRENCY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(214, 34)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CONVERTER"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Forex.My.Resources.Resources.washing_shi
        Me.ClientSize = New System.Drawing.Size(513, 399)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Currencylbl)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Computebtn)
        Me.Controls.Add(Me.Computetxtbox)
        Me.Controls.Add(Me.Tolbl)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Resetbtn)
        Me.Controls.Add(Me.Amounttxtbox)
        Me.Controls.Add(Me.Amountlbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Amountlbl As Label
    Friend WithEvents Amounttxtbox As TextBox
    Friend WithEvents Resetbtn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Tolbl As Label
    Friend WithEvents Computetxtbox As TextBox
    Friend WithEvents Computebtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Currencylbl As Label
    Friend WithEvents Label1 As Label
End Class
