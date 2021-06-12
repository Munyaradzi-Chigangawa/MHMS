<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashier
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Dtime = New System.Windows.Forms.DateTimePicker()
        Me.txtadvance = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtchildren = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtadults = New System.Windows.Forms.TextBox()
        Me.txtdays = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txtroomno = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtcash = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.txtchange = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 399)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Checkout Date"
        '
        'Dtime
        '
        Me.Dtime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtime.Location = New System.Drawing.Point(12, 415)
        Me.Dtime.Name = "Dtime"
        Me.Dtime.Size = New System.Drawing.Size(179, 23)
        Me.Dtime.TabIndex = 67
        Me.Dtime.Value = New Date(2021, 6, 18, 0, 0, 0, 0)
        '
        'txtadvance
        '
        Me.txtadvance.Enabled = False
        Me.txtadvance.Location = New System.Drawing.Point(11, 369)
        Me.txtadvance.Name = "txtadvance"
        Me.txtadvance.Size = New System.Drawing.Size(182, 23)
        Me.txtadvance.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Advance Pay"
        '
        'txtchildren
        '
        Me.txtchildren.Enabled = False
        Me.txtchildren.Location = New System.Drawing.Point(12, 321)
        Me.txtchildren.Name = "txtchildren"
        Me.txtchildren.Size = New System.Drawing.Size(182, 23)
        Me.txtchildren.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 16)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "No Of Children"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "No. Of Adults"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "No Of Days"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Room Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Room Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Room No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Guest Name"
        '
        'txtadults
        '
        Me.txtadults.Enabled = False
        Me.txtadults.Location = New System.Drawing.Point(12, 281)
        Me.txtadults.Name = "txtadults"
        Me.txtadults.Size = New System.Drawing.Size(182, 23)
        Me.txtadults.TabIndex = 53
        '
        'txtdays
        '
        Me.txtdays.Enabled = False
        Me.txtdays.Location = New System.Drawing.Point(12, 237)
        Me.txtdays.Name = "txtdays"
        Me.txtdays.Size = New System.Drawing.Size(182, 23)
        Me.txtdays.TabIndex = 52
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(9, 196)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(182, 23)
        Me.txtdate.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Dtime)
        Me.GroupBox1.Controls.Add(Me.txtadvance)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtchildren)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtadults)
        Me.GroupBox1.Controls.Add(Me.txtdays)
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtrate)
        Me.GroupBox1.Controls.Add(Me.txttype)
        Me.GroupBox1.Controls.Add(Me.txtroomno)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 464)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Check in Date"
        '
        'txtrate
        '
        Me.txtrate.Enabled = False
        Me.txtrate.Location = New System.Drawing.Point(9, 155)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(182, 23)
        Me.txtrate.TabIndex = 50
        '
        'txttype
        '
        Me.txttype.Enabled = False
        Me.txttype.Location = New System.Drawing.Point(9, 115)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(182, 23)
        Me.txttype.TabIndex = 49
        '
        'txtroomno
        '
        Me.txtroomno.Enabled = False
        Me.txtroomno.Location = New System.Drawing.Point(9, 75)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.Size = New System.Drawing.Size(182, 23)
        Me.txtroomno.TabIndex = 48
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(9, 35)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(182, 23)
        Me.txtname.TabIndex = 47
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(267, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(537, 441)
        Me.DataGridView1.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-2, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 25)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "TOTAL"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(20, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(236, 93)
        Me.Panel4.TabIndex = 66
        '
        'txtcash
        '
        Me.txtcash.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcash.Location = New System.Drawing.Point(3, 27)
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(231, 38)
        Me.txtcash.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "CASH:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtcash)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(21, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 74)
        Me.Panel2.TabIndex = 14
        '
        'txtc
        '
        Me.txtc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtc.Location = New System.Drawing.Point(5, 27)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(228, 38)
        Me.txtc.TabIndex = 20
        '
        'txtchange
        '
        Me.txtchange.AutoSize = True
        Me.txtchange.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.Location = New System.Drawing.Point(-2, -2)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(121, 25)
        Me.txtchange.TabIndex = 19
        Me.txtchange.Text = "CHANGE:"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.MenuText
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.txttotal.Location = New System.Drawing.Point(28, 43)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(222, 38)
        Me.txttotal.TabIndex = 66
        '
        'btncheckout
        '
        Me.btncheckout.Location = New System.Drawing.Point(21, 300)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(239, 68)
        Me.btncheckout.TabIndex = 18
        Me.btncheckout.Text = "Checkout"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(239, 62)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtc)
        Me.Panel3.Controls.Add(Me.txtchange)
        Me.Panel3.Location = New System.Drawing.Point(21, 211)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 77)
        Me.Panel3.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txttotal)
        Me.Panel1.Controls.Add(Me.btncheckout)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(810, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 450)
        Me.Panel1.TabIndex = 66
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Location = New System.Drawing.Point(-5, -1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1149, 117)
        Me.Panel5.TabIndex = 99
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(393, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(363, 77)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "MIDRAND"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(393, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(362, 33)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Hotel Management System"
        '
        'cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 629)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cashier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Dtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtadvance As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtchildren As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtadults As System.Windows.Forms.TextBox
    Friend WithEvents txtdays As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents txtroomno As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtcash As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtc As System.Windows.Forms.TextBox
    Friend WithEvents txtchange As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btncheckout As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
