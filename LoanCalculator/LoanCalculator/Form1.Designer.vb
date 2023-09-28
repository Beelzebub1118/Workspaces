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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Computebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LoanReftxtbox = New System.Windows.Forms.TextBox()
        Me.AccNotxtbox = New System.Windows.Forms.TextBox()
        Me.Nametxtbox = New System.Windows.Forms.TextBox()
        Me.Addresstxtbox = New System.Windows.Forms.TextBox()
        Me.AmountLoantxtbox = New System.Windows.Forms.TextBox()
        Me.Interestratetxtbox = New System.Windows.Forms.TextBox()
        Me.yearstopaytxtbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.SystemColors.Control
        Me.Clearbtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearbtn.Location = New System.Drawing.Point(12, 387)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(75, 29)
        Me.Clearbtn.TabIndex = 0
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Computebtn
        '
        Me.Computebtn.BackColor = System.Drawing.SystemColors.Control
        Me.Computebtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Computebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Computebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Computebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Computebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Computebtn.Location = New System.Drawing.Point(215, 387)
        Me.Computebtn.Name = "Computebtn"
        Me.Computebtn.Size = New System.Drawing.Size(81, 29)
        Me.Computebtn.TabIndex = 1
        Me.Computebtn.Text = "Compute"
        Me.Computebtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Loan Ref. Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Amount Loan:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(12, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Interest Rate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(12, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Year(s) to Pay:"
        '
        'LoanReftxtbox
        '
        Me.LoanReftxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanReftxtbox.Location = New System.Drawing.Point(172, 143)
        Me.LoanReftxtbox.Name = "LoanReftxtbox"
        Me.LoanReftxtbox.Size = New System.Drawing.Size(100, 21)
        Me.LoanReftxtbox.TabIndex = 10
        Me.LoanReftxtbox.Text = "00001"
        Me.LoanReftxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccNotxtbox
        '
        Me.AccNotxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNotxtbox.Location = New System.Drawing.Point(172, 177)
        Me.AccNotxtbox.Name = "AccNotxtbox"
        Me.AccNotxtbox.Size = New System.Drawing.Size(100, 21)
        Me.AccNotxtbox.TabIndex = 11
        Me.AccNotxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nametxtbox
        '
        Me.Nametxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nametxtbox.Location = New System.Drawing.Point(172, 208)
        Me.Nametxtbox.Name = "Nametxtbox"
        Me.Nametxtbox.Size = New System.Drawing.Size(100, 21)
        Me.Nametxtbox.TabIndex = 12
        Me.Nametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Addresstxtbox
        '
        Me.Addresstxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addresstxtbox.Location = New System.Drawing.Point(172, 241)
        Me.Addresstxtbox.Name = "Addresstxtbox"
        Me.Addresstxtbox.Size = New System.Drawing.Size(100, 21)
        Me.Addresstxtbox.TabIndex = 13
        Me.Addresstxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmountLoantxtbox
        '
        Me.AmountLoantxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLoantxtbox.Location = New System.Drawing.Point(172, 277)
        Me.AmountLoantxtbox.Name = "AmountLoantxtbox"
        Me.AmountLoantxtbox.Size = New System.Drawing.Size(100, 21)
        Me.AmountLoantxtbox.TabIndex = 14
        Me.AmountLoantxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Interestratetxtbox
        '
        Me.Interestratetxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interestratetxtbox.Location = New System.Drawing.Point(172, 311)
        Me.Interestratetxtbox.Name = "Interestratetxtbox"
        Me.Interestratetxtbox.Size = New System.Drawing.Size(100, 21)
        Me.Interestratetxtbox.TabIndex = 15
        Me.Interestratetxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yearstopaytxtbox
        '
        Me.yearstopaytxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearstopaytxtbox.Location = New System.Drawing.Point(172, 346)
        Me.yearstopaytxtbox.Name = "yearstopaytxtbox"
        Me.yearstopaytxtbox.Size = New System.Drawing.Size(100, 21)
        Me.yearstopaytxtbox.TabIndex = 16
        Me.yearstopaytxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LoanCalculator.My.Resources.Resources.CALCULATOR__2_
        Me.ClientSize = New System.Drawing.Size(308, 421)
        Me.Controls.Add(Me.yearstopaytxtbox)
        Me.Controls.Add(Me.Interestratetxtbox)
        Me.Controls.Add(Me.AmountLoantxtbox)
        Me.Controls.Add(Me.Addresstxtbox)
        Me.Controls.Add(Me.Nametxtbox)
        Me.Controls.Add(Me.AccNotxtbox)
        Me.Controls.Add(Me.LoanReftxtbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Computebtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clearbtn As Button
    Friend WithEvents Computebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LoanReftxtbox As TextBox
    Friend WithEvents AccNotxtbox As TextBox
    Friend WithEvents Nametxtbox As TextBox
    Friend WithEvents Addresstxtbox As TextBox
    Friend WithEvents AmountLoantxtbox As TextBox
    Friend WithEvents Interestratetxtbox As TextBox
    Friend WithEvents yearstopaytxtbox As TextBox
End Class
