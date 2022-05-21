<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopUp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nominal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QR_Billing = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QR_Billing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1080, 119)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(890, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Log Out"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(777, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Top Up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Quantico", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(87, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "iCafe SEA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(645, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Beranda"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Quantico", 9.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(406, 581)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Code:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nominal
        '
        Me.nominal.BackColor = System.Drawing.Color.White
        Me.nominal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nominal.FormattingEnabled = True
        Me.nominal.Items.AddRange(New Object() {"Rp5000,-", "Rp10.000,-", "Rp25.000,-", "Rp50.000,-", "Rp100.000,-"})
        Me.nominal.Location = New System.Drawing.Point(376, 246)
        Me.nominal.Name = "nominal"
        Me.nominal.Size = New System.Drawing.Size(162, 33)
        Me.nominal.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(376, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Pilih Nominal"
        '
        'QR_Billing
        '
        Me.QR_Billing.Location = New System.Drawing.Point(406, 314)
        Me.QR_Billing.Name = "QR_Billing"
        Me.QR_Billing.Size = New System.Drawing.Size(250, 250)
        Me.QR_Billing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.QR_Billing.TabIndex = 11
        Me.QR_Billing.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cocogoose", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(448, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 47)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Top Up"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(544, 240)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 43)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Generate"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 720)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nominal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QR_Billing)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TopUp"
        Me.Text = "TopUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.QR_Billing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nominal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QR_Billing As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
End Class
