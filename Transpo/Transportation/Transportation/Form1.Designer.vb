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
        Me.Fromlbl = New System.Windows.Forms.Label()
        Me.Tolbl = New System.Windows.Forms.Label()
        Me.Discountlbl = New System.Windows.Forms.Label()
        Me.originlbl = New System.Windows.Forms.Label()
        Me.Destinationlbl = New System.Windows.Forms.Label()
        Me.GrossFarelbl = New System.Windows.Forms.Label()
        Me.Discountlbl2 = New System.Windows.Forms.Label()
        Me.NetFarelbl = New System.Windows.Forms.Label()
        Me.Origintxtbox = New System.Windows.Forms.TextBox()
        Me.Destinationtxtbox = New System.Windows.Forms.TextBox()
        Me.GrossFaretxtbox = New System.Windows.Forms.TextBox()
        Me.Discounttxtbox = New System.Windows.Forms.TextBox()
        Me.Netfaretxtbox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Proceedbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Fromlbl
        '
        Me.Fromlbl.AutoSize = True
        Me.Fromlbl.BackColor = System.Drawing.Color.AliceBlue
        Me.Fromlbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fromlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Fromlbl.Image = CType(resources.GetObject("Fromlbl.Image"), System.Drawing.Image)
        Me.Fromlbl.Location = New System.Drawing.Point(77, 96)
        Me.Fromlbl.Name = "Fromlbl"
        Me.Fromlbl.Size = New System.Drawing.Size(52, 18)
        Me.Fromlbl.TabIndex = 0
        Me.Fromlbl.Text = "From:"
        '
        'Tolbl
        '
        Me.Tolbl.AutoSize = True
        Me.Tolbl.BackColor = System.Drawing.Color.AliceBlue
        Me.Tolbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tolbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Tolbl.Image = CType(resources.GetObject("Tolbl.Image"), System.Drawing.Image)
        Me.Tolbl.Location = New System.Drawing.Point(77, 208)
        Me.Tolbl.Name = "Tolbl"
        Me.Tolbl.Size = New System.Drawing.Size(32, 18)
        Me.Tolbl.TabIndex = 1
        Me.Tolbl.Text = "To:"
        '
        'Discountlbl
        '
        Me.Discountlbl.AutoSize = True
        Me.Discountlbl.BackColor = System.Drawing.Color.AliceBlue
        Me.Discountlbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discountlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Discountlbl.Image = CType(resources.GetObject("Discountlbl.Image"), System.Drawing.Image)
        Me.Discountlbl.Location = New System.Drawing.Point(50, 328)
        Me.Discountlbl.Name = "Discountlbl"
        Me.Discountlbl.Size = New System.Drawing.Size(79, 18)
        Me.Discountlbl.TabIndex = 2
        Me.Discountlbl.Text = "Discount:"
        '
        'originlbl
        '
        Me.originlbl.AutoSize = True
        Me.originlbl.BackColor = System.Drawing.Color.AliceBlue
        Me.originlbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.originlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.originlbl.Image = CType(resources.GetObject("originlbl.Image"), System.Drawing.Image)
        Me.originlbl.Location = New System.Drawing.Point(467, 96)
        Me.originlbl.Name = "originlbl"
        Me.originlbl.Size = New System.Drawing.Size(61, 18)
        Me.originlbl.TabIndex = 3
        Me.originlbl.Text = "Origin:"
        '
        'Destinationlbl
        '
        Me.Destinationlbl.AutoSize = True
        Me.Destinationlbl.BackColor = System.Drawing.Color.AliceBlue
        Me.Destinationlbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destinationlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Destinationlbl.Image = CType(resources.GetObject("Destinationlbl.Image"), System.Drawing.Image)
        Me.Destinationlbl.Location = New System.Drawing.Point(467, 154)
        Me.Destinationlbl.Name = "Destinationlbl"
        Me.Destinationlbl.Size = New System.Drawing.Size(100, 18)
        Me.Destinationlbl.TabIndex = 4
        Me.Destinationlbl.Text = "Destination:"
        '
        'GrossFarelbl
        '
        Me.GrossFarelbl.AutoSize = True
        Me.GrossFarelbl.BackColor = System.Drawing.Color.AliceBlue
        Me.GrossFarelbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossFarelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GrossFarelbl.Image = CType(resources.GetObject("GrossFarelbl.Image"), System.Drawing.Image)
        Me.GrossFarelbl.Location = New System.Drawing.Point(467, 208)
        Me.GrossFarelbl.Name = "GrossFarelbl"
        Me.GrossFarelbl.Size = New System.Drawing.Size(93, 18)
        Me.GrossFarelbl.TabIndex = 5
        Me.GrossFarelbl.Text = "Gross Fare:"
        '
        'Discountlbl2
        '
        Me.Discountlbl2.AutoSize = True
        Me.Discountlbl2.BackColor = System.Drawing.Color.AliceBlue
        Me.Discountlbl2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discountlbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Discountlbl2.Image = CType(resources.GetObject("Discountlbl2.Image"), System.Drawing.Image)
        Me.Discountlbl2.Location = New System.Drawing.Point(467, 263)
        Me.Discountlbl2.Name = "Discountlbl2"
        Me.Discountlbl2.Size = New System.Drawing.Size(79, 18)
        Me.Discountlbl2.TabIndex = 6
        Me.Discountlbl2.Text = "Discount:"
        '
        'NetFarelbl
        '
        Me.NetFarelbl.AutoSize = True
        Me.NetFarelbl.BackColor = System.Drawing.Color.AliceBlue
        Me.NetFarelbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetFarelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NetFarelbl.Image = CType(resources.GetObject("NetFarelbl.Image"), System.Drawing.Image)
        Me.NetFarelbl.Location = New System.Drawing.Point(467, 328)
        Me.NetFarelbl.Name = "NetFarelbl"
        Me.NetFarelbl.Size = New System.Drawing.Size(77, 18)
        Me.NetFarelbl.TabIndex = 7
        Me.NetFarelbl.Text = "Net Fare:"
        '
        'Origintxtbox
        '
        Me.Origintxtbox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Origintxtbox.Location = New System.Drawing.Point(577, 89)
        Me.Origintxtbox.Name = "Origintxtbox"
        Me.Origintxtbox.Size = New System.Drawing.Size(205, 25)
        Me.Origintxtbox.TabIndex = 11
        '
        'Destinationtxtbox
        '
        Me.Destinationtxtbox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destinationtxtbox.Location = New System.Drawing.Point(577, 147)
        Me.Destinationtxtbox.Name = "Destinationtxtbox"
        Me.Destinationtxtbox.Size = New System.Drawing.Size(205, 25)
        Me.Destinationtxtbox.TabIndex = 12
        '
        'GrossFaretxtbox
        '
        Me.GrossFaretxtbox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossFaretxtbox.Location = New System.Drawing.Point(577, 201)
        Me.GrossFaretxtbox.Name = "GrossFaretxtbox"
        Me.GrossFaretxtbox.Size = New System.Drawing.Size(205, 25)
        Me.GrossFaretxtbox.TabIndex = 13
        '
        'Discounttxtbox
        '
        Me.Discounttxtbox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discounttxtbox.Location = New System.Drawing.Point(577, 256)
        Me.Discounttxtbox.Name = "Discounttxtbox"
        Me.Discounttxtbox.Size = New System.Drawing.Size(205, 25)
        Me.Discounttxtbox.TabIndex = 14
        '
        'Netfaretxtbox
        '
        Me.Netfaretxtbox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Netfaretxtbox.Location = New System.Drawing.Point(577, 326)
        Me.Netfaretxtbox.Name = "Netfaretxtbox"
        Me.Netfaretxtbox.Size = New System.Drawing.Size(205, 25)
        Me.Netfaretxtbox.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Dagupan City", "Urdaneta City", "Rosales", "Paniqui", "Moncada", "Tarlac City", "Concepcion", "Capas", "Bamban", "Mabalacat City", "Angeles"})
        Me.ComboBox1.Location = New System.Drawing.Point(155, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(234, 26)
        Me.ComboBox1.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Dagupan City", "Urdaneta City", "Rosales", "Paniqui", "Moncada", "Tarlac City", "Concepcion", "Capas", "Bamban", "Mabalacat City", "Angeles"})
        Me.ComboBox2.Location = New System.Drawing.Point(155, 207)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(234, 26)
        Me.ComboBox2.TabIndex = 17
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"No discount", "Government Employee(10%)", "Student(15%)", "Senior Citizen(20%)", "Children(50%)"})
        Me.ComboBox3.Location = New System.Drawing.Point(155, 321)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(234, 26)
        Me.ComboBox3.TabIndex = 18
        '
        'Clearbtn
        '
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Clearbtn.Image = Global.Transportation.My.Resources.Resources.LRT__1_
        Me.Clearbtn.Location = New System.Drawing.Point(54, 411)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(75, 28)
        Me.Clearbtn.TabIndex = 19
        Me.Clearbtn.Text = "CLEAR"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'Proceedbtn
        '
        Me.Proceedbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proceedbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Proceedbtn.Image = Global.Transportation.My.Resources.Resources.LRT__1_
        Me.Proceedbtn.Location = New System.Drawing.Point(699, 411)
        Me.Proceedbtn.Name = "Proceedbtn"
        Me.Proceedbtn.Size = New System.Drawing.Size(83, 28)
        Me.Proceedbtn.TabIndex = 20
        Me.Proceedbtn.Text = "PROCEED"
        Me.Proceedbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Transportation.My.Resources.Resources.LRT__1_
        Me.ClientSize = New System.Drawing.Size(816, 463)
        Me.Controls.Add(Me.Proceedbtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Netfaretxtbox)
        Me.Controls.Add(Me.Discounttxtbox)
        Me.Controls.Add(Me.GrossFaretxtbox)
        Me.Controls.Add(Me.Destinationtxtbox)
        Me.Controls.Add(Me.Origintxtbox)
        Me.Controls.Add(Me.NetFarelbl)
        Me.Controls.Add(Me.Discountlbl2)
        Me.Controls.Add(Me.GrossFarelbl)
        Me.Controls.Add(Me.Destinationlbl)
        Me.Controls.Add(Me.originlbl)
        Me.Controls.Add(Me.Discountlbl)
        Me.Controls.Add(Me.Tolbl)
        Me.Controls.Add(Me.Fromlbl)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fromlbl As Label
    Friend WithEvents Tolbl As Label
    Friend WithEvents Discountlbl As Label
    Friend WithEvents originlbl As Label
    Friend WithEvents Destinationlbl As Label
    Friend WithEvents GrossFarelbl As Label
    Friend WithEvents Discountlbl2 As Label
    Friend WithEvents NetFarelbl As Label
    Friend WithEvents Origintxtbox As TextBox
    Friend WithEvents Destinationtxtbox As TextBox
    Friend WithEvents GrossFaretxtbox As TextBox
    Friend WithEvents Discounttxtbox As TextBox
    Friend WithEvents Netfaretxtbox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Proceedbtn As Button
End Class
