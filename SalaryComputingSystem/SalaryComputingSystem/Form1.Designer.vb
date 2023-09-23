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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.NametxtBox1 = New System.Windows.Forms.TextBox()
        Me.DepartmenttxtBox = New System.Windows.Forms.TextBox()
        Me.Departmentlbl = New System.Windows.Forms.Label()
        Me.WorkingHourstxtBox = New System.Windows.Forms.TextBox()
        Me.WorkingHourslbl = New System.Windows.Forms.Label()
        Me.RegularRatetxtBox = New System.Windows.Forms.TextBox()
        Me.RegularRatelbl = New System.Windows.Forms.Label()
        Me.OvertimetxtBox = New System.Windows.Forms.TextBox()
        Me.Overtimelbl = New System.Windows.Forms.Label()
        Me.OvertimeRatetxtBox = New System.Windows.Forms.TextBox()
        Me.OvertimeRatelbl = New System.Windows.Forms.Label()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Convertbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Namelbl.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(111, 98)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(53, 22)
        Me.Namelbl.TabIndex = 0
        Me.Namelbl.Text = "Name:"
        '
        'NametxtBox1
        '
        Me.NametxtBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NametxtBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NametxtBox1.Location = New System.Drawing.Point(76, 122)
        Me.NametxtBox1.Name = "NametxtBox1"
        Me.NametxtBox1.Size = New System.Drawing.Size(128, 24)
        Me.NametxtBox1.TabIndex = 1
        '
        'DepartmenttxtBox
        '
        Me.DepartmenttxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DepartmenttxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmenttxtBox.Location = New System.Drawing.Point(76, 178)
        Me.DepartmenttxtBox.Name = "DepartmenttxtBox"
        Me.DepartmenttxtBox.Size = New System.Drawing.Size(128, 24)
        Me.DepartmenttxtBox.TabIndex = 3
        '
        'Departmentlbl
        '
        Me.Departmentlbl.AutoSize = True
        Me.Departmentlbl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Departmentlbl.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departmentlbl.Location = New System.Drawing.Point(89, 154)
        Me.Departmentlbl.Name = "Departmentlbl"
        Me.Departmentlbl.Size = New System.Drawing.Size(95, 22)
        Me.Departmentlbl.TabIndex = 2
        Me.Departmentlbl.Text = "Department:"
        '
        'WorkingHourstxtBox
        '
        Me.WorkingHourstxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WorkingHourstxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingHourstxtBox.Location = New System.Drawing.Point(76, 237)
        Me.WorkingHourstxtBox.Name = "WorkingHourstxtBox"
        Me.WorkingHourstxtBox.Size = New System.Drawing.Size(128, 24)
        Me.WorkingHourstxtBox.TabIndex = 5
        '
        'WorkingHourslbl
        '
        Me.WorkingHourslbl.AutoSize = True
        Me.WorkingHourslbl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.WorkingHourslbl.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingHourslbl.Location = New System.Drawing.Point(81, 212)
        Me.WorkingHourslbl.Name = "WorkingHourslbl"
        Me.WorkingHourslbl.Size = New System.Drawing.Size(114, 22)
        Me.WorkingHourslbl.TabIndex = 4
        Me.WorkingHourslbl.Text = "Working Hours"
        '
        'RegularRatetxtBox
        '
        Me.RegularRatetxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RegularRatetxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegularRatetxtBox.Location = New System.Drawing.Point(76, 301)
        Me.RegularRatetxtBox.Name = "RegularRatetxtBox"
        Me.RegularRatetxtBox.Size = New System.Drawing.Size(128, 24)
        Me.RegularRatetxtBox.TabIndex = 7
        '
        'RegularRatelbl
        '
        Me.RegularRatelbl.AutoSize = True
        Me.RegularRatelbl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.RegularRatelbl.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegularRatelbl.Location = New System.Drawing.Point(89, 275)
        Me.RegularRatelbl.Name = "RegularRatelbl"
        Me.RegularRatelbl.Size = New System.Drawing.Size(99, 22)
        Me.RegularRatelbl.TabIndex = 6
        Me.RegularRatelbl.Text = "Regular Rate"
        '
        'OvertimetxtBox
        '
        Me.OvertimetxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OvertimetxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvertimetxtBox.Location = New System.Drawing.Point(76, 362)
        Me.OvertimetxtBox.Name = "OvertimetxtBox"
        Me.OvertimetxtBox.Size = New System.Drawing.Size(128, 24)
        Me.OvertimetxtBox.TabIndex = 9
        '
        'Overtimelbl
        '
        Me.Overtimelbl.AutoSize = True
        Me.Overtimelbl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Overtimelbl.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overtimelbl.Location = New System.Drawing.Point(102, 337)
        Me.Overtimelbl.Name = "Overtimelbl"
        Me.Overtimelbl.Size = New System.Drawing.Size(72, 22)
        Me.Overtimelbl.TabIndex = 8
        Me.Overtimelbl.Text = "Overtime"
        '
        'OvertimeRatetxtBox
        '
        Me.OvertimeRatetxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OvertimeRatetxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvertimeRatetxtBox.Location = New System.Drawing.Point(76, 426)
        Me.OvertimeRatetxtBox.Name = "OvertimeRatetxtBox"
        Me.OvertimeRatetxtBox.Size = New System.Drawing.Size(128, 24)
        Me.OvertimeRatetxtBox.TabIndex = 11
        '
        'OvertimeRatelbl
        '
        Me.OvertimeRatelbl.AutoSize = True
        Me.OvertimeRatelbl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.OvertimeRatelbl.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvertimeRatelbl.Location = New System.Drawing.Point(89, 401)
        Me.OvertimeRatelbl.Name = "OvertimeRatelbl"
        Me.OvertimeRatelbl.Size = New System.Drawing.Size(107, 22)
        Me.OvertimeRatelbl.TabIndex = 10
        Me.OvertimeRatelbl.Text = "Overtime Rate"
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Clearbtn.Location = New System.Drawing.Point(40, 456)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(79, 27)
        Me.Clearbtn.TabIndex = 12
        Me.Clearbtn.Text = "CLEAR"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Convertbtn
        '
        Me.Convertbtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Convertbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Convertbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Convertbtn.Location = New System.Drawing.Point(153, 456)
        Me.Convertbtn.Name = "Convertbtn"
        Me.Convertbtn.Size = New System.Drawing.Size(79, 27)
        Me.Convertbtn.TabIndex = 13
        Me.Convertbtn.Text = "CONVERT"
        Me.Convertbtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SalaryComputingSystem.My.Resources.Resources.S
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(280, 508)
        Me.Controls.Add(Me.Convertbtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.OvertimeRatetxtBox)
        Me.Controls.Add(Me.OvertimeRatelbl)
        Me.Controls.Add(Me.OvertimetxtBox)
        Me.Controls.Add(Me.Overtimelbl)
        Me.Controls.Add(Me.RegularRatetxtBox)
        Me.Controls.Add(Me.RegularRatelbl)
        Me.Controls.Add(Me.WorkingHourstxtBox)
        Me.Controls.Add(Me.WorkingHourslbl)
        Me.Controls.Add(Me.DepartmenttxtBox)
        Me.Controls.Add(Me.Departmentlbl)
        Me.Controls.Add(Me.NametxtBox1)
        Me.Controls.Add(Me.Namelbl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Namelbl As Label
    Friend WithEvents NametxtBox1 As TextBox
    Friend WithEvents DepartmenttxtBox As TextBox
    Friend WithEvents Departmentlbl As Label
    Friend WithEvents WorkingHourstxtBox As TextBox
    Friend WithEvents WorkingHourslbl As Label
    Friend WithEvents RegularRatetxtBox As TextBox
    Friend WithEvents RegularRatelbl As Label
    Friend WithEvents OvertimetxtBox As TextBox
    Friend WithEvents Overtimelbl As Label
    Friend WithEvents OvertimeRatetxtBox As TextBox
    Friend WithEvents OvertimeRatelbl As Label
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Convertbtn As Button
End Class
