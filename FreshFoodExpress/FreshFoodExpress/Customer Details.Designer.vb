<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Details
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.btnExitcd = New System.Windows.Forms.Button()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtCreditCardNumber = New System.Windows.Forms.TextBox()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.lblTownCity = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.lblCreditCardNo = New System.Windows.Forms.Label()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.picbxatmcard = New System.Windows.Forms.PictureBox()
        CType(Me.picbxatmcard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(167, 58)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(258, 20)
        Me.txtCustomerName.TabIndex = 28
        '
        'btnExitcd
        '
        Me.btnExitcd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExitcd.Font = New System.Drawing.Font("Lucida Handwriting", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitcd.Location = New System.Drawing.Point(17, 304)
        Me.btnExitcd.Name = "btnExitcd"
        Me.btnExitcd.Size = New System.Drawing.Size(207, 52)
        Me.btnExitcd.TabIndex = 27
        Me.btnExitcd.Text = "Exit"
        Me.btnExitcd.UseVisualStyleBackColor = True
        '
        'lblCustomerName
        '
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(3, 59)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(142, 19)
        Me.lblCustomerName.TabIndex = 26
        Me.lblCustomerName.Text = "Customer Name"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnConfirm.Font = New System.Drawing.Font("Lucida Calligraphy", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(275, 303)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(228, 53)
        Me.btnConfirm.TabIndex = 25
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtCreditCardNumber
        '
        Me.txtCreditCardNumber.Font = New System.Drawing.Font("Lucida Handwriting", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCardNumber.Location = New System.Drawing.Point(551, 114)
        Me.txtCreditCardNumber.MaxLength = 20
        Me.txtCreditCardNumber.Multiline = True
        Me.txtCreditCardNumber.Name = "txtCreditCardNumber"
        Me.txtCreditCardNumber.Size = New System.Drawing.Size(310, 43)
        Me.txtCreditCardNumber.TabIndex = 24
        '
        'txtStreetName
        '
        Me.txtStreetName.Font = New System.Drawing.Font("Lucida Bright", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetName.Location = New System.Drawing.Point(167, 137)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(258, 20)
        Me.txtStreetName.TabIndex = 23
        '
        'txtTownCity
        '
        Me.txtTownCity.Font = New System.Drawing.Font("Lucida Bright", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTownCity.Location = New System.Drawing.Point(167, 176)
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(258, 20)
        Me.txtTownCity.TabIndex = 22
        '
        'txtPostCode
        '
        Me.txtPostCode.Font = New System.Drawing.Font("Lucida Bright", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostCode.Location = New System.Drawing.Point(167, 220)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(258, 20)
        Me.txtPostCode.TabIndex = 21
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Font = New System.Drawing.Font("Lucida Bright", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNumber.Location = New System.Drawing.Point(167, 96)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(258, 20)
        Me.txtHouseNumber.TabIndex = 20
        '
        'lblStreetName
        '
        Me.lblStreetName.BackColor = System.Drawing.Color.Transparent
        Me.lblStreetName.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetName.Location = New System.Drawing.Point(12, 138)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(111, 19)
        Me.lblStreetName.TabIndex = 19
        Me.lblStreetName.Text = "Street Name"
        '
        'lblTownCity
        '
        Me.lblTownCity.BackColor = System.Drawing.Color.Transparent
        Me.lblTownCity.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTownCity.Location = New System.Drawing.Point(12, 178)
        Me.lblTownCity.Name = "lblTownCity"
        Me.lblTownCity.Size = New System.Drawing.Size(95, 19)
        Me.lblTownCity.TabIndex = 18
        Me.lblTownCity.Text = "Town/City"
        '
        'lblPostCode
        '
        Me.lblPostCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPostCode.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostCode.Location = New System.Drawing.Point(12, 222)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(82, 19)
        Me.lblPostCode.TabIndex = 17
        Me.lblPostCode.Text = "Postcode"
        '
        'lblCreditCardNo
        '
        Me.lblCreditCardNo.BackColor = System.Drawing.Color.CadetBlue
        Me.lblCreditCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCardNo.Location = New System.Drawing.Point(577, 59)
        Me.lblCreditCardNo.Name = "lblCreditCardNo"
        Me.lblCreditCardNo.Size = New System.Drawing.Size(243, 34)
        Me.lblCreditCardNo.TabIndex = 16
        Me.lblCreditCardNo.Text = "Credit Card Number"
        '
        'lblHouseNumber
        '
        Me.lblHouseNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblHouseNumber.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseNumber.Location = New System.Drawing.Point(14, 98)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(131, 19)
        Me.lblHouseNumber.TabIndex = 15
        Me.lblHouseNumber.Text = "House Number"
        '
        'picbxatmcard
        '
        Me.picbxatmcard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbxatmcard.Image = Global.FreshFoodExpress.My.Resources.Resources.ATMCARDPIC
        Me.picbxatmcard.Location = New System.Drawing.Point(529, 253)
        Me.picbxatmcard.Name = "picbxatmcard"
        Me.picbxatmcard.Size = New System.Drawing.Size(332, 103)
        Me.picbxatmcard.TabIndex = 29
        Me.picbxatmcard.TabStop = False
        '
        'Customer_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(888, 368)
        Me.Controls.Add(Me.picbxatmcard)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.btnExitcd)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtCreditCardNumber)
        Me.Controls.Add(Me.txtStreetName)
        Me.Controls.Add(Me.txtTownCity)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.txtHouseNumber)
        Me.Controls.Add(Me.lblStreetName)
        Me.Controls.Add(Me.lblTownCity)
        Me.Controls.Add(Me.lblPostCode)
        Me.Controls.Add(Me.lblCreditCardNo)
        Me.Controls.Add(Me.lblHouseNumber)
        Me.Name = "Customer_Details"
        Me.Text = "Customer Details"
        CType(Me.picbxatmcard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents btnExitcd As System.Windows.Forms.Button
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents txtCreditCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetName As System.Windows.Forms.TextBox
    Friend WithEvents txtTownCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtHouseNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblStreetName As System.Windows.Forms.Label
    Friend WithEvents lblTownCity As System.Windows.Forms.Label
    Friend WithEvents lblPostCode As System.Windows.Forms.Label
    Friend WithEvents lblCreditCardNo As System.Windows.Forms.Label
    Friend WithEvents lblHouseNumber As System.Windows.Forms.Label
    Friend WithEvents picbxatmcard As System.Windows.Forms.PictureBox
End Class
