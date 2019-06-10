Public Class frmcomponents

    ''Stock Potatoes for all days
    Dim stock_potato_monday() As Integer = {0, 15, 15, 15, 15}
    Dim stock_potato_tuesday() As Integer = {0, 15, 15, 15, 15}
    Dim stock_potato_wednesday() As Integer = {0, 15, 15, 15, 15}
    Dim stock_potato_thursday() As Integer = {0, 15, 15, 15, 15}
    Dim stock_potato_friday() As Integer = {0, 15, 15, 15, 15}
    Dim stock_potato_saturday() As Integer = {0, 15, 15, 15, 15}

    ''Stock Boxes for all days
    Dim stock_box_monday() As Integer = {0, 20, 20, 20}
    Dim stock_box_tuesday() As Integer = {0, 20, 20, 20}
    Dim stock_box_wednesday() As Integer = {0, 20, 20, 20}
    Dim stock_box_thursday() As Integer = {0, 20, 20, 20}
    Dim stock_box_friday() As Integer = {0, 20, 20, 20}
    Dim stock_box_saturday() As Integer = {0, 20, 20, 20}

    '' Green leafy vegetable stocks
    Dim stock_greenleafy_monday() As Integer = {25, 25, 25}
    Dim stock_greenleafy_tuesday() As Integer = {25, 25, 25}
    Dim stock_greenleafy_wednesday() As Integer = {25, 25, 25}
    Dim stock_greenleafy_thursday() As Integer = {25, 25, 25}
    Dim stock_greenleafy_friday() As Integer = {25, 25, 25}
    Dim stock_greenleafy_saturday() As Integer = {25, 25, 25}

    ''Root vegetable stocks
    Dim stock_rootvegetable_monday() As Integer = {15, 16, 22, 32}
    Dim stock_rootvegetable_tuesday() As Integer = {15, 16, 22, 32}
    Dim stock_rootvegetable_wednesday() As Integer = {15, 16, 22, 32}
    Dim stock_rootvegetable_thursday() As Integer = {15, 16, 22, 32}
    Dim stock_rootvegetable_friday() As Integer = {15, 16, 22, 32}
    Dim stock_rootvegetable_saturday() As Integer = {15, 16, 22, 32}

    ''All Prices
    Dim Price_Potatoes() As Single = {0, 10, 9.5, 15.75, 13}
    Dim Price_Box() As Single = {0, 6.96, 11.95, 15.95}
    Dim Price_Greenleafy() As Single = {5, 15, 20}
    Dim Price_Root() As Single = {5, 15, 20, 20}
    Dim Price_dlvoptn() As Single = {0, 1.95, 1.95, 4.95}
    Dim Price_Salad() As Single = {10, 8, 15}
    Dim Price_Core() As Single = {50, 50}
    Dim Price_Soft() As Single = {20, 25, 40, 45}


    Private Sub frmcomponents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbdayofdelivery.Items.Add("Please Select")
        cmbdayofdelivery.Items.Add("Monday")
        cmbdayofdelivery.Items.Add("Tuesday")
        cmbdayofdelivery.Items.Add("Wednesday")
        cmbdayofdelivery.Items.Add("Thursday")
        cmbdayofdelivery.Items.Add("Friday")
        cmbdayofdelivery.Items.Add("Saturday")
        cmbdayofdelivery.SelectedIndex = 0

        cmbtypeofpotatoes.Items.Add("Please Select")
        cmbtypeofpotatoes.Items.Add("Maris Piper")
        cmbtypeofpotatoes.Items.Add("Shetland Black")
        cmbtypeofpotatoes.Items.Add("King Edward")
        cmbtypeofpotatoes.Items.Add("Yukon Gold")
        cmbtypeofpotatoes.SelectedIndex = 0

        cmbtypeofbox.Items.Add("Please Select")
        cmbtypeofbox.Items.Add("Small (£6.95)")
        cmbtypeofbox.Items.Add("Medium (£11.95)")
        cmbtypeofbox.Items.Add("Large(£15.95)")
        cmbtypeofbox.SelectedIndex = 0

        lstbgreenleafyvegetables.Items.Add("Spinach")
        lstbgreenleafyvegetables.Items.Add("Rocket")
        lstbgreenleafyvegetables.Items.Add("Iceberg Lettuce")

        lstbrootvegetables.Items.Add("Onion")
        lstbrootvegetables.Items.Add("Parsnip")
        lstbrootvegetables.Items.Add("Turnip")
        lstbrootvegetables.Items.Add("Carrot")

        chklbsaladvegetables.Items.Add("Cumumber")
        chklbsaladvegetables.Items.Add("Tomatoes")
        chklbsaladvegetables.Items.Add("Radish")

        chklbcorefruits.Items.Add("Apples")
        chklbcorefruits.Items.Add("Pears")

        chklbsoftfruits.Items.Add("Peaches")
        chklbsoftfruits.Items.Add("Pulmns")
        chklbsoftfruits.Items.Add("Raspberries")
        chklbsoftfruits.Items.Add("Blackberries")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsummary.Click
        Dim strdayofdelivery, strpotatotype, strboxtype, strgreenleafyvegetables, strrootvegetables, AllComponents As String

        Dim PricePotato, PriceBox, PriceGreenleafy, PriceRoot, PriceDelivery, PriceOptional, PriceTotal As Single

        'day of delivery
        If cmbdayofdelivery.SelectedIndex = 0 Then
            MessageBox.Show("You Must Select One Day of Delivery", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            strdayofdelivery = "=======>You Choose " & cmbdayofdelivery.SelectedItem & " As Day Of Delivery <=======" & vbCrLf
        End If

        'type of potatoes
        If cmbtypeofpotatoes.SelectedIndex = 0 Then
            MessageBox.Show("You Must Select A Potato Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            PricePotato = Price_Potatoes(cmbtypeofpotatoes.SelectedIndex)
            strpotatotype = "Potato Type...........>> " & cmbtypeofpotatoes.SelectedItem & "................ Price: £" & PricePotato
        End If

        'type of box
        If cmbtypeofbox.SelectedIndex = 0 Then
            MessageBox.Show("You Must Select A Box Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            PriceBox = Price_Box(cmbtypeofbox.SelectedIndex)
            strboxtype = "Box Type.........................>> " & cmbtypeofbox.SelectedItem
        End If

        'greenleafy vegitable
        If lstbgreenleafyvegetables.SelectedIndex < 0 Then
            MessageBox.Show("Please Select One Or More Greenleafy Vegetables", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            PriceGreenleafy = Price_Greenleafy(lstbgreenleafyvegetables.SelectedIndex)
            For Each x In lstbgreenleafyvegetables.SelectedItems
                strgreenleafyvegetables += x & "........ Price: £" & PriceGreenleafy & ", "
            Next

        End If

        'root vegetables
        If lstbrootvegetables.SelectedIndex < 0 Then
            MessageBox.Show("Plese Select One Or More Root Vegetables", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            PriceRoot = Price_Root(lstbrootvegetables.SelectedIndex)
            For Each x In lstbrootvegetables.SelectedItems
                strrootvegetables += x & "........ Price: £" & PriceRoot & ", "
            Next
        End If

        'delivery option
        If rdb1.Checked = False And rdb2.Checked = False And rdb3.Checked = False And rdb4.Checked = False Then
            MessageBox.Show("You Must Select One Delivery Option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim deliveryoption As String
        Dim pricedelivary As Single

        If rdb1.Checked = True Then
            pricedelivary = Price_dlvoptn(0)

            deliveryoption = "7:00 am to 7:00 pm ........(Free)"
        End If
        If rdb2.Checked = True Then
            pricedelivary = Price_dlvoptn(1)

            deliveryoption = "Morning timeslot ........ (£1.95)"
        End If
        If rdb3.Checked = True Then
            pricedelivary = Price_dlvoptn(2)

            deliveryoption = "Afternoon timeslot ........(£1.95)"
        End If
        If rdb4.Checked = True Then
            pricedelivary = Price_dlvoptn(3)

            deliveryoption = "One hour lunch time timeslot ........(£4.95)"
        End If

        '''''optional items
        Dim stroptional, opts, optc, optsf As String
        Dim pricesalad, pricecore, pricesoft As Single

        'Salad Vegetables
        If chklbsaladvegetables.SelectedIndex > -1 Then
            pricesalad = Price_Salad(chklbsaladvegetables.SelectedIndex)

            For Each x In chklbsaladvegetables.CheckedItems
                opts += x & ".... Price: £" & pricesalad & ", "
            Next
        End If

        'Core fruits
        If chklbcorefruits.SelectedIndex > -1 Then
            pricecore = Price_Core(chklbcorefruits.SelectedIndex)
            For Each x In chklbcorefruits.CheckedItems
                optc += x & ".... Price: £" & pricecore & ", "
            Next
        End If

        'Soft fruits
        If chklbsoftfruits.SelectedIndex > -1 Then
            pricesoft = Price_Soft(chklbsoftfruits.SelectedIndex)
            For Each x In chklbsoftfruits.CheckedItems
                optsf += x & ".... Price: £" & pricesoft & ", "
            Next
        End If


        stroptional = "Optional....>> " & opts & optc & optsf
        PriceOptional = pricesalad + pricecore + pricesoft


        Dim opt, opt1, opt2, opt3 As Integer
        opt1 = chklbsaladvegetables.CheckedItems.Count
        opt2 = chklbcorefruits.CheckedItems.Count
        opt3 = chklbsoftfruits.CheckedItems.Count
        opt = opt1 + opt2 + opt3
        'small box
        If cmbtypeofbox.SelectedIndex = 1 Then
            If opt > 1 Then
                MessageBox.Show("For Small Box You May Choose Only One Optional Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        'medium box
        If cmbtypeofbox.SelectedIndex = 2 Then
            If opt > 3 Then
                MessageBox.Show("For Medium Box You May A Maximum Of Three Optional Items", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        'large box
        If cmbtypeofbox.SelectedIndex = 3 Then
            If opt > 6 Then
                MessageBox.Show("For Large Box You May Choose A Maximum Of Six Optional Items", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If


        '''''checking potato stock
        'monday
        If cmbdayofdelivery.SelectedIndex = 1 Then
            For p As Integer = 1 To 4
                If Convert.ToString(cmbtypeofpotatoes.Items(p)) = cmbtypeofpotatoes.SelectedItem Then
                    If stock_potato_monday(cmbtypeofpotatoes.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofpotatoes.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_potato_monday(cmbtypeofpotatoes.SelectedIndex) = stock_potato_monday(cmbtypeofpotatoes.SelectedIndex) - 1
                End If
            Next
        End If
        'tuesday
        If cmbdayofdelivery.SelectedIndex = 2 Then
            For p As Integer = 1 To 4
                If Convert.ToString(cmbtypeofpotatoes.Items(p)) = cmbtypeofpotatoes.SelectedItem Then
                    If stock_potato_tuesday(cmbtypeofpotatoes.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofpotatoes.SelectedItem & " Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_potato_tuesday(cmbtypeofpotatoes.SelectedIndex) = stock_potato_tuesday(cmbtypeofpotatoes.SelectedIndex) - 1
                End If
            Next
        End If
        'wednesday
        If cmbdayofdelivery.SelectedIndex = 3 Then
            For p As Integer = 1 To 4
                If Convert.ToString(cmbtypeofpotatoes.Items(p)) = cmbtypeofpotatoes.SelectedItem Then
                    If stock_potato_wednesday(cmbtypeofpotatoes.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofpotatoes.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_potato_wednesday(cmbtypeofpotatoes.SelectedIndex) = stock_potato_wednesday(cmbtypeofpotatoes.SelectedIndex) - 1
                End If
            Next
        End If
        'thursday
        If cmbdayofdelivery.SelectedIndex = 4 Then
            For p As Integer = 1 To 4
                If Convert.ToString(cmbtypeofpotatoes.Items(p)) = cmbtypeofpotatoes.SelectedItem Then
                    If stock_potato_thursday(cmbtypeofpotatoes.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofpotatoes.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_potato_thursday(cmbtypeofpotatoes.SelectedIndex) = stock_potato_thursday(cmbtypeofpotatoes.SelectedIndex) - 1
                End If
            Next
        End If
        'friday
        If cmbdayofdelivery.SelectedIndex = 5 Then
            For p As Integer = 1 To 4
                If Convert.ToString(cmbtypeofpotatoes.Items(p)) = cmbtypeofpotatoes.SelectedItem Then
                    If stock_potato_friday(cmbtypeofpotatoes.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofpotatoes.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_potato_friday(cmbtypeofpotatoes.SelectedIndex) = stock_potato_friday(cmbtypeofpotatoes.SelectedIndex) - 1
                End If
            Next
        End If
        'saturday
        If cmbdayofdelivery.SelectedIndex = 6 Then
            For p As Integer = 1 To 4
                If Convert.ToString(cmbtypeofpotatoes.Items(p)) = cmbtypeofpotatoes.SelectedItem Then
                    If stock_potato_saturday(cmbtypeofpotatoes.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofpotatoes.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_potato_saturday(cmbtypeofpotatoes.SelectedIndex) = stock_potato_saturday(cmbtypeofpotatoes.SelectedIndex) - 1
                End If
            Next
        End If

        ''''''''check box stock
        'monday
        If cmbdayofdelivery.SelectedIndex = 1 Then
            For b As Integer = 1 To 3
                If Convert.ToString(cmbtypeofbox.Items(b)) = cmbtypeofbox.SelectedItem Then
                    If stock_box_monday(cmbtypeofbox.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofbox.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_box_monday(cmbtypeofbox.SelectedIndex) = stock_box_monday(cmbtypeofbox.SelectedIndex) - 1
                End If
            Next
        End If
        'tuesday
        If cmbdayofdelivery.SelectedIndex = 2 Then
            For b As Integer = 1 To 3
                If Convert.ToString(cmbtypeofbox.Items(b)) = cmbtypeofbox.SelectedItem Then
                    If stock_box_tuesday(cmbtypeofbox.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofbox.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_box_tuesday(cmbtypeofbox.SelectedIndex) = stock_box_tuesday(cmbtypeofbox.SelectedIndex) - 1
                End If
            Next
        End If
        'wednesday
        If cmbdayofdelivery.SelectedIndex = 3 Then
            For b As Integer = 1 To 3
                If Convert.ToString(cmbtypeofbox.Items(b)) = cmbtypeofbox.SelectedItem Then
                    If stock_box_wednesday(cmbtypeofbox.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofbox.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_box_wednesday(cmbtypeofbox.SelectedIndex) = stock_box_wednesday(cmbtypeofbox.SelectedIndex) - 1
                End If
            Next
        End If
        'thursday
        If cmbdayofdelivery.SelectedIndex = 4 Then
            For b As Integer = 1 To 3
                If Convert.ToString(cmbtypeofbox.Items(b)) = cmbtypeofbox.SelectedItem Then
                    If stock_box_thursday(cmbtypeofbox.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofbox.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_box_thursday(cmbtypeofbox.SelectedIndex) = stock_box_thursday(cmbtypeofbox.SelectedIndex) - 1
                End If
            Next
        End If
        'friday
        If cmbdayofdelivery.SelectedIndex = 5 Then
            For b As Integer = 1 To 3
                If Convert.ToString(cmbtypeofbox.Items(b)) = cmbtypeofbox.SelectedItem Then
                    If stock_box_friday(cmbtypeofbox.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofbox.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_box_friday(cmbtypeofbox.SelectedIndex) = stock_box_friday(cmbtypeofbox.SelectedIndex) - 1
                End If
            Next
        End If
        'saturday
        If cmbdayofdelivery.SelectedIndex = 6 Then
            For b As Integer = 1 To 3
                If Convert.ToString(cmbtypeofbox.Items(b)) = cmbtypeofbox.SelectedItem Then
                    If stock_box_saturday(cmbtypeofbox.SelectedIndex) < 1 Then
                        MessageBox.Show(cmbtypeofbox.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_box_saturday(cmbtypeofbox.SelectedIndex) = stock_box_saturday(cmbtypeofbox.SelectedIndex) - 1
                End If
            Next
        End If

        ''''''''''''''''''check greenleafy vegetables stock
        'monday
        If cmbdayofdelivery.SelectedIndex = 1 Then
            For gv As Integer = 0 To 2
                If Convert.ToString(lstbgreenleafyvegetables.Items(gv)) = lstbgreenleafyvegetables.SelectedItem Then
                    If stock_greenleafy_monday(lstbgreenleafyvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Green Leafy Vegetable:- " & lstbgreenleafyvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_greenleafy_monday(lstbgreenleafyvegetables.SelectedIndex) = stock_greenleafy_monday(lstbgreenleafyvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'tuesday
        If cmbdayofdelivery.SelectedIndex = 2 Then
            For gv As Integer = 0 To 2
                If Convert.ToString(lstbgreenleafyvegetables.Items(gv)) = lstbgreenleafyvegetables.SelectedItem Then
                    If stock_greenleafy_tuesday(lstbgreenleafyvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Green Leafy Vegetable:- " & lstbgreenleafyvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_greenleafy_tuesday(lstbgreenleafyvegetables.SelectedIndex) = stock_greenleafy_tuesday(lstbgreenleafyvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'wednesday
        If cmbdayofdelivery.SelectedIndex = 3 Then
            For gv As Integer = 0 To 2
                If Convert.ToString(lstbgreenleafyvegetables.Items(gv)) = lstbgreenleafyvegetables.SelectedItem Then
                    If stock_greenleafy_wednesday(lstbgreenleafyvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Green Leafy Vegetable:- " & lstbgreenleafyvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_greenleafy_wednesday(lstbgreenleafyvegetables.SelectedIndex) = stock_greenleafy_wednesday(lstbgreenleafyvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'thursday
        If cmbdayofdelivery.SelectedIndex = 4 Then
            For gv As Integer = 0 To 2
                If Convert.ToString(lstbgreenleafyvegetables.Items(gv)) = lstbgreenleafyvegetables.SelectedItem Then
                    If stock_greenleafy_thursday(lstbgreenleafyvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Green Leafy Vegetable:- " & lstbgreenleafyvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_greenleafy_thursday(lstbgreenleafyvegetables.SelectedIndex) = stock_greenleafy_thursday(lstbgreenleafyvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'friday
        If cmbdayofdelivery.SelectedIndex = 5 Then
            For gv As Integer = 0 To 2
                If Convert.ToString(lstbgreenleafyvegetables.Items(gv)) = lstbgreenleafyvegetables.SelectedItem Then
                    If stock_greenleafy_friday(lstbgreenleafyvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Green Leafy Vegetable:- " & lstbgreenleafyvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_greenleafy_friday(lstbgreenleafyvegetables.SelectedIndex) = stock_greenleafy_friday(lstbgreenleafyvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'saturday
        If cmbdayofdelivery.SelectedIndex = 6 Then
            For gv As Integer = 0 To 2
                If Convert.ToString(lstbgreenleafyvegetables.Items(gv)) = lstbgreenleafyvegetables.SelectedItem Then
                    If stock_greenleafy_saturday(lstbgreenleafyvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Green Leafy Vegetable:- " & lstbgreenleafyvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_greenleafy_saturday(lstbgreenleafyvegetables.SelectedIndex) = stock_greenleafy_saturday(lstbgreenleafyvegetables.SelectedIndex) - 1
                End If
            Next
        End If

        '''''''''''''check rootvegetables stock
        'monday
        If cmbdayofdelivery.SelectedIndex = 1 Then
            For rv As Integer = 0 To 3
                If Convert.ToString(lstbrootvegetables.Items(rv)) = lstbrootvegetables.SelectedItem Then
                    If stock_rootvegetable_monday(lstbrootvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Root Vegetable:- " & lstbrootvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_rootvegetable_monday(lstbrootvegetables.SelectedIndex) = stock_rootvegetable_monday(lstbrootvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'tuesday
        If cmbdayofdelivery.SelectedIndex = 2 Then
            For rv As Integer = 0 To 3
                If Convert.ToString(lstbrootvegetables.Items(rv)) = lstbrootvegetables.SelectedItem Then
                    If stock_rootvegetable_tuesday(lstbrootvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Root Vegetable:- " & lstbrootvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_rootvegetable_tuesday(lstbrootvegetables.SelectedIndex) = stock_rootvegetable_tuesday(lstbrootvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'wednesday
        If cmbdayofdelivery.SelectedIndex = 3 Then
            For rv As Integer = 0 To 3
                If Convert.ToString(lstbrootvegetables.Items(rv)) = lstbrootvegetables.SelectedItem Then
                    If stock_rootvegetable_wednesday(lstbrootvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Root Vegetable:- " & lstbrootvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_rootvegetable_wednesday(lstbrootvegetables.SelectedIndex) = stock_rootvegetable_wednesday(lstbrootvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'thursday
        If cmbdayofdelivery.SelectedIndex = 4 Then
            For rv As Integer = 0 To 3
                If Convert.ToString(lstbrootvegetables.Items(rv)) = lstbrootvegetables.SelectedItem Then
                    If stock_rootvegetable_thursday(lstbrootvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Root Vegetable:- " & lstbrootvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_rootvegetable_thursday(lstbrootvegetables.SelectedIndex) = stock_rootvegetable_thursday(lstbrootvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'friday
        If cmbdayofdelivery.SelectedIndex = 5 Then
            For rv As Integer = 0 To 3
                If Convert.ToString(lstbrootvegetables.Items(rv)) = lstbrootvegetables.SelectedItem Then
                    If stock_rootvegetable_friday(lstbrootvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Root Vegetable:- " & lstbrootvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_rootvegetable_friday(lstbrootvegetables.SelectedIndex) = stock_rootvegetable_friday(lstbrootvegetables.SelectedIndex) - 1
                End If
            Next
        End If
        'saturday
        If cmbdayofdelivery.SelectedIndex = 6 Then
            For rv As Integer = 0 To 3
                If Convert.ToString(lstbrootvegetables.Items(rv)) = lstbrootvegetables.SelectedItem Then
                    If stock_rootvegetable_saturday(lstbrootvegetables.SelectedIndex) < 1 Then
                        MessageBox.Show("Root Vegetable:- " & lstbrootvegetables.SelectedItem & "  Is Not Available On This " & cmbdayofdelivery.SelectedItem, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    stock_rootvegetable_saturday(lstbrootvegetables.SelectedIndex) = stock_rootvegetable_saturday(lstbrootvegetables.SelectedIndex) - 1
                End If
            Next
        End If

        ''''''''''Summary without Optional items
        If chklbsaladvegetables.SelectedIndex < 1 And chklbcorefruits.SelectedIndex < 1 And chklbsoftfruits.SelectedIndex < 1 Then
            PriceTotal = PricePotato + PriceBox + PriceDelivery + PriceGreenleafy + PriceRoot
            AllComponents = strdayofdelivery & vbCrLf & strpotatotype & vbCrLf & strboxtype & vbCrLf & "Green Leafy vegetable :  " & strgreenleafyvegetables & vbCrLf & "Root Vegetable: " & strrootvegetables & vbCrLf & deliveryoption & vbCrLf & "You Didn't Select Any Optional Item " & vbCrLf & vbCrLf & "Total price:........................................................= £" & PriceTotal & vbCrLf & vbCrLf & "Do You Like To Order?"
            Dim Summary1 As DialogResult = MessageBox.Show(AllComponents, "Summary Of Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Summary1 = DialogResult.Yes Then
                MessageBox.Show("Thank You For Ordaring")
                Customer_Details.Show()
            Else
                MessageBox.Show(">>>>>>>>>>>>>>Your Order Is Cancelled Successfully<<<<<<<<<<<<" & vbCrLf & vbCrLf & vbCrLf & "<<<<<<<<<<<<<<< Thanks For Visit  >>>>>>>>>>>")
            End If


            ''''''''Summary with optional items
        Else

            PriceTotal = PricePotato + PriceBox + PriceDelivery + PriceGreenleafy + PriceRoot + PriceOptional
            AllComponents = strdayofdelivery & vbCrLf & strpotatotype & vbCrLf & strboxtype & vbCrLf & "Green Leafy vegetable :  " & strgreenleafyvegetables & vbCrLf & "Root Vegetable: " & strrootvegetables & vbCrLf & deliveryoption & vbCrLf & stroptional & vbCrLf & vbCrLf & "Total price:........................................................= £" & PriceTotal & vbCrLf & vbCrLf & "Do You Like To Order?"

            Dim summary As DialogResult = MessageBox.Show(AllComponents, "Summary Of Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If summary = DialogResult.Yes Then

                MessageBox.Show("Thank You For Ordaring")
                Customer_Details.Show()
            Else
                MessageBox.Show(">>>>>>>>>>>>>>Your Order Is Cancelled Successfully<<<<<<<<<<<<" & vbCrLf & vbCrLf & vbCrLf & "<<<<<<<<<<<<<<< Thanks For Visit  >>>>>>>>>>>")
            End If

        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
End Class
