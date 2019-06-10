Public Class Customer_Details

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        'customer name
        If txtCustomerName.Text = "" Then
            MessageBox.Show("You Must Fill Customer Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'house number
        If txtHouseNumber.Text = "" Then
            MessageBox.Show("You Must Enter House Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'street name
        If txtStreetName.Text = "" Then
            MessageBox.Show("You Must Enter Your Street Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'town/city
        If txtTownCity.Text = "" Then
            MessageBox.Show("You Must Enter Town/City Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If IsNumeric(txtTownCity.Text) Then
            MessageBox.Show("Town/City Name Must Be In Characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'post code
        If txtPostCode.Text = "" Then
            MessageBox.Show("Post Code Field Can't be Blank,You Must Enter Post Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim SpaceFound As Boolean
        SpaceFound = Space_check(txtPostCode.Text)
        If SpaceFound Then
            MessageBox.Show("Space Is Not Allowed In Post Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not IsNumeric(txtPostCode.Text) Then
            MessageBox.Show("Post Code Must Be In Digits, Charrecters Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtPostCode.TextLength < 4 Then
            MessageBox.Show("Post Code Can't Be Less Than 4 Digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtPostCode.TextLength > 4 Then
            MessageBox.Show("Post Code Can't Be More Than 4 Digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtCreditCardNumber.Text = "" Then
            MessageBox.Show("Credit Card Number Must Be Entered, This Field Can't Be Blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'atm card number
        If txtCreditCardNumber.TextLength < 16 Then
            MessageBox.Show("Credit Card Number Can't Be Less Than 16 Digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtCreditCardNumber.TextLength > 16 Then
            MessageBox.Show("Credit Card Number Can't Be More Than    16 Digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        MessageBox.Show("Customer Name:-  " & "   " & txtCustomerName.Text & vbCrLf & "House Number:-  " & "     " & txtHouseNumber.Text & vbCrLf & "Street Name:-  " & "         " & txtStreetName.Text & vbCrLf & "Town\City:-  " & "            " & txtTownCity.Text & vbCrLf & "PostCode:-  " & "             " & txtPostCode.Text & vbCrLf & vbCrLf & "Thanks For Your personal Information & Your Successful Purchase.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        txtCustomerName.Text = String.Empty
        txtHouseNumber.Text = String.Empty
        txtStreetName.Text = String.Empty
        txtTownCity.Text = String.Empty
        txtPostCode.Text = String.Empty
        txtCreditCardNumber.Text = String.Empty
        Me.Close()
    End Sub

    Private Sub txtCustomerName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerName.KeyPress
        Dim customerName As String = "1234567890"
        If customerName.IndexOf(e.KeyChar) <> -1 Then
            MessageBox.Show("Digits Is Not Allowed In Customer Name, Please Enter Only Alphabetic Values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
        Dim customername1 As String = "!@#$%^&*<>~+"
        If customername1.IndexOf(e.KeyChar) <> -1 Then
            MessageBox.Show("Customer Name Can't Contain Any Special Character, Please Enter Only Alphabetic Values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub
    Private Sub txtCreditCardNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCreditCardNumber.KeyPress
        Dim Space As String = " "
        If Space.IndexOf(e.KeyChar) <> -1 Then
            MessageBox.Show("Space Is Not Allowed In card Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
            Exit Sub
        End If

        Dim dot As String = "."
        If dot.IndexOf(e.KeyChar) <> -1 Then
            MessageBox.Show("Dot Is Not Allowed In card Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
            Exit Sub
        End If

        Dim character As String = "1234567890"
        If Not character.IndexOf(e.KeyChar) <> -1 Then
            MessageBox.Show("Character Is Not allowed in Card Number. Please, Enter Numeric Values In Credit Card Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitcd.Click
        Me.Close()
    End Sub
End Class