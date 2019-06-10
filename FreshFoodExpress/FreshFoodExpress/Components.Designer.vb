<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcomponents
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
        Me.lblfreshfood = New System.Windows.Forms.Label()
        Me.lbldayofdelivery = New System.Windows.Forms.Label()
        Me.grpessential = New System.Windows.Forms.GroupBox()
        Me.cmbtypeofbox = New System.Windows.Forms.ComboBox()
        Me.cmbtypeofpotatoes = New System.Windows.Forms.ComboBox()
        Me.cmbdayofdelivery = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblboxtype = New System.Windows.Forms.Label()
        Me.grpessentialvegetable = New System.Windows.Forms.GroupBox()
        Me.lstbrootvegetables = New System.Windows.Forms.ListBox()
        Me.lstbgreenleafyvegetables = New System.Windows.Forms.ListBox()
        Me.lblrootvegetables = New System.Windows.Forms.Label()
        Me.lblgreenleafy = New System.Windows.Forms.Label()
        Me.grpoptional = New System.Windows.Forms.GroupBox()
        Me.lblsoftfruits = New System.Windows.Forms.Label()
        Me.lblcorefruits = New System.Windows.Forms.Label()
        Me.chklbsoftfruits = New System.Windows.Forms.CheckedListBox()
        Me.chklbcorefruits = New System.Windows.Forms.CheckedListBox()
        Me.lblsalad = New System.Windows.Forms.Label()
        Me.chklbsaladvegetables = New System.Windows.Forms.CheckedListBox()
        Me.grpdeliveryoption = New System.Windows.Forms.GroupBox()
        Me.rdb4 = New System.Windows.Forms.RadioButton()
        Me.rdb3 = New System.Windows.Forms.RadioButton()
        Me.rdb2 = New System.Windows.Forms.RadioButton()
        Me.rdb1 = New System.Windows.Forms.RadioButton()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnsummary = New System.Windows.Forms.Button()
        Me.grpessential.SuspendLayout()
        Me.grpessentialvegetable.SuspendLayout()
        Me.grpoptional.SuspendLayout()
        Me.grpdeliveryoption.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblfreshfood
        '
        Me.lblfreshfood.BackColor = System.Drawing.Color.LimeGreen
        Me.lblfreshfood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfreshfood.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfreshfood.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblfreshfood.Location = New System.Drawing.Point(294, 9)
        Me.lblfreshfood.Name = "lblfreshfood"
        Me.lblfreshfood.Size = New System.Drawing.Size(364, 62)
        Me.lblfreshfood.TabIndex = 0
        Me.lblfreshfood.Text = "FRESH FOOD EXPRESS"
        Me.lblfreshfood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldayofdelivery
        '
        Me.lbldayofdelivery.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lbldayofdelivery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldayofdelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldayofdelivery.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbldayofdelivery.Location = New System.Drawing.Point(6, 26)
        Me.lbldayofdelivery.Name = "lbldayofdelivery"
        Me.lbldayofdelivery.Size = New System.Drawing.Size(146, 31)
        Me.lbldayofdelivery.TabIndex = 1
        Me.lbldayofdelivery.Text = "Day Of Delivery"
        Me.lbldayofdelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpessential
        '
        Me.grpessential.BackColor = System.Drawing.Color.Transparent
        Me.grpessential.Controls.Add(Me.cmbtypeofbox)
        Me.grpessential.Controls.Add(Me.cmbtypeofpotatoes)
        Me.grpessential.Controls.Add(Me.cmbdayofdelivery)
        Me.grpessential.Controls.Add(Me.Label2)
        Me.grpessential.Controls.Add(Me.lblboxtype)
        Me.grpessential.Controls.Add(Me.lbldayofdelivery)
        Me.grpessential.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpessential.ForeColor = System.Drawing.Color.Red
        Me.grpessential.Location = New System.Drawing.Point(12, 88)
        Me.grpessential.Name = "grpessential"
        Me.grpessential.Size = New System.Drawing.Size(477, 197)
        Me.grpessential.TabIndex = 2
        Me.grpessential.TabStop = False
        Me.grpessential.Text = "ESSENTIAL COMPONENTS"
        '
        'cmbtypeofbox
        '
        Me.cmbtypeofbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtypeofbox.FormattingEnabled = True
        Me.cmbtypeofbox.Location = New System.Drawing.Point(319, 74)
        Me.cmbtypeofbox.Name = "cmbtypeofbox"
        Me.cmbtypeofbox.Size = New System.Drawing.Size(146, 28)
        Me.cmbtypeofbox.TabIndex = 6
        '
        'cmbtypeofpotatoes
        '
        Me.cmbtypeofpotatoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtypeofpotatoes.FormattingEnabled = True
        Me.cmbtypeofpotatoes.Location = New System.Drawing.Point(163, 74)
        Me.cmbtypeofpotatoes.Name = "cmbtypeofpotatoes"
        Me.cmbtypeofpotatoes.Size = New System.Drawing.Size(146, 28)
        Me.cmbtypeofpotatoes.TabIndex = 5
        '
        'cmbdayofdelivery
        '
        Me.cmbdayofdelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdayofdelivery.FormattingEnabled = True
        Me.cmbdayofdelivery.Location = New System.Drawing.Point(6, 74)
        Me.cmbdayofdelivery.Name = "cmbdayofdelivery"
        Me.cmbdayofdelivery.Size = New System.Drawing.Size(146, 28)
        Me.cmbdayofdelivery.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.Location = New System.Drawing.Point(163, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type Of Potatoes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblboxtype
        '
        Me.lblboxtype.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblboxtype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblboxtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblboxtype.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblboxtype.Location = New System.Drawing.Point(319, 26)
        Me.lblboxtype.Name = "lblboxtype"
        Me.lblboxtype.Size = New System.Drawing.Size(146, 31)
        Me.lblboxtype.TabIndex = 2
        Me.lblboxtype.Text = "Type Of Box"
        Me.lblboxtype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpessentialvegetable
        '
        Me.grpessentialvegetable.BackColor = System.Drawing.Color.Transparent
        Me.grpessentialvegetable.Controls.Add(Me.lstbrootvegetables)
        Me.grpessentialvegetable.Controls.Add(Me.lstbgreenleafyvegetables)
        Me.grpessentialvegetable.Controls.Add(Me.lblrootvegetables)
        Me.grpessentialvegetable.Controls.Add(Me.lblgreenleafy)
        Me.grpessentialvegetable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpessentialvegetable.ForeColor = System.Drawing.Color.Red
        Me.grpessentialvegetable.Location = New System.Drawing.Point(505, 88)
        Me.grpessentialvegetable.Name = "grpessentialvegetable"
        Me.grpessentialvegetable.Size = New System.Drawing.Size(452, 197)
        Me.grpessentialvegetable.TabIndex = 3
        Me.grpessentialvegetable.TabStop = False
        Me.grpessentialvegetable.Text = "ESSENTIAL VEGETABLES"
        '
        'lstbrootvegetables
        '
        Me.lstbrootvegetables.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lstbrootvegetables.FormattingEnabled = True
        Me.lstbrootvegetables.ItemHeight = 20
        Me.lstbrootvegetables.Location = New System.Drawing.Point(245, 73)
        Me.lstbrootvegetables.Name = "lstbrootvegetables"
        Me.lstbrootvegetables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbrootvegetables.Size = New System.Drawing.Size(196, 104)
        Me.lstbrootvegetables.TabIndex = 4
        '
        'lstbgreenleafyvegetables
        '
        Me.lstbgreenleafyvegetables.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lstbgreenleafyvegetables.FormattingEnabled = True
        Me.lstbgreenleafyvegetables.ItemHeight = 20
        Me.lstbgreenleafyvegetables.Location = New System.Drawing.Point(16, 74)
        Me.lstbgreenleafyvegetables.Name = "lstbgreenleafyvegetables"
        Me.lstbgreenleafyvegetables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbgreenleafyvegetables.Size = New System.Drawing.Size(196, 104)
        Me.lstbgreenleafyvegetables.TabIndex = 3
        '
        'lblrootvegetables
        '
        Me.lblrootvegetables.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lblrootvegetables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblrootvegetables.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrootvegetables.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblrootvegetables.Location = New System.Drawing.Point(245, 22)
        Me.lblrootvegetables.Name = "lblrootvegetables"
        Me.lblrootvegetables.Size = New System.Drawing.Size(196, 32)
        Me.lblrootvegetables.TabIndex = 2
        Me.lblrootvegetables.Text = "Root Vegetables"
        Me.lblrootvegetables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblgreenleafy
        '
        Me.lblgreenleafy.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.lblgreenleafy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgreenleafy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgreenleafy.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblgreenleafy.Location = New System.Drawing.Point(7, 26)
        Me.lblgreenleafy.Name = "lblgreenleafy"
        Me.lblgreenleafy.Size = New System.Drawing.Size(205, 30)
        Me.lblgreenleafy.TabIndex = 1
        Me.lblgreenleafy.Text = "Green Leafy Vegetables"
        Me.lblgreenleafy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpoptional
        '
        Me.grpoptional.BackColor = System.Drawing.Color.Transparent
        Me.grpoptional.Controls.Add(Me.lblsoftfruits)
        Me.grpoptional.Controls.Add(Me.lblcorefruits)
        Me.grpoptional.Controls.Add(Me.chklbsoftfruits)
        Me.grpoptional.Controls.Add(Me.chklbcorefruits)
        Me.grpoptional.Controls.Add(Me.lblsalad)
        Me.grpoptional.Controls.Add(Me.chklbsaladvegetables)
        Me.grpoptional.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpoptional.ForeColor = System.Drawing.Color.Indigo
        Me.grpoptional.Location = New System.Drawing.Point(12, 347)
        Me.grpoptional.Name = "grpoptional"
        Me.grpoptional.Size = New System.Drawing.Size(587, 215)
        Me.grpoptional.TabIndex = 4
        Me.grpoptional.TabStop = False
        Me.grpoptional.Text = "OPTIONAL ITEMS"
        '
        'lblsoftfruits
        '
        Me.lblsoftfruits.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblsoftfruits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsoftfruits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsoftfruits.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblsoftfruits.Location = New System.Drawing.Point(404, 45)
        Me.lblsoftfruits.Name = "lblsoftfruits"
        Me.lblsoftfruits.Size = New System.Drawing.Size(175, 31)
        Me.lblsoftfruits.TabIndex = 8
        Me.lblsoftfruits.Text = "Soft Fruits"
        Me.lblsoftfruits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcorefruits
        '
        Me.lblcorefruits.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblcorefruits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcorefruits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorefruits.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblcorefruits.Location = New System.Drawing.Point(195, 45)
        Me.lblcorefruits.Name = "lblcorefruits"
        Me.lblcorefruits.Size = New System.Drawing.Size(182, 31)
        Me.lblcorefruits.TabIndex = 7
        Me.lblcorefruits.Text = "Core Fruits"
        Me.lblcorefruits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chklbsoftfruits
        '
        Me.chklbsoftfruits.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.chklbsoftfruits.CheckOnClick = True
        Me.chklbsoftfruits.FormattingEnabled = True
        Me.chklbsoftfruits.Location = New System.Drawing.Point(406, 79)
        Me.chklbsoftfruits.Name = "chklbsoftfruits"
        Me.chklbsoftfruits.Size = New System.Drawing.Size(175, 124)
        Me.chklbsoftfruits.TabIndex = 6
        '
        'chklbcorefruits
        '
        Me.chklbcorefruits.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.chklbcorefruits.CheckOnClick = True
        Me.chklbcorefruits.FormattingEnabled = True
        Me.chklbcorefruits.Location = New System.Drawing.Point(195, 85)
        Me.chklbcorefruits.Name = "chklbcorefruits"
        Me.chklbcorefruits.Size = New System.Drawing.Size(182, 124)
        Me.chklbcorefruits.TabIndex = 5
        '
        'lblsalad
        '
        Me.lblsalad.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblsalad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsalad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalad.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblsalad.Location = New System.Drawing.Point(6, 45)
        Me.lblsalad.Name = "lblsalad"
        Me.lblsalad.Size = New System.Drawing.Size(163, 31)
        Me.lblsalad.TabIndex = 2
        Me.lblsalad.Text = "Salad Vegetables"
        Me.lblsalad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chklbsaladvegetables
        '
        Me.chklbsaladvegetables.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.chklbsaladvegetables.CheckOnClick = True
        Me.chklbsaladvegetables.FormattingEnabled = True
        Me.chklbsaladvegetables.Location = New System.Drawing.Point(6, 85)
        Me.chklbsaladvegetables.Name = "chklbsaladvegetables"
        Me.chklbsaladvegetables.Size = New System.Drawing.Size(163, 124)
        Me.chklbsaladvegetables.TabIndex = 0
        '
        'grpdeliveryoption
        '
        Me.grpdeliveryoption.BackColor = System.Drawing.Color.Transparent
        Me.grpdeliveryoption.Controls.Add(Me.rdb4)
        Me.grpdeliveryoption.Controls.Add(Me.rdb3)
        Me.grpdeliveryoption.Controls.Add(Me.rdb2)
        Me.grpdeliveryoption.Controls.Add(Me.rdb1)
        Me.grpdeliveryoption.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpdeliveryoption.ForeColor = System.Drawing.Color.GreenYellow
        Me.grpdeliveryoption.Location = New System.Drawing.Point(621, 347)
        Me.grpdeliveryoption.Name = "grpdeliveryoption"
        Me.grpdeliveryoption.Size = New System.Drawing.Size(336, 165)
        Me.grpdeliveryoption.TabIndex = 5
        Me.grpdeliveryoption.TabStop = False
        Me.grpdeliveryoption.Text = "Delivery Options"
        '
        'rdb4
        '
        Me.rdb4.AutoSize = True
        Me.rdb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb4.ForeColor = System.Drawing.Color.MintCream
        Me.rdb4.Location = New System.Drawing.Point(15, 130)
        Me.rdb4.Name = "rdb4"
        Me.rdb4.Size = New System.Drawing.Size(302, 22)
        Me.rdb4.TabIndex = 3
        Me.rdb4.TabStop = True
        Me.rdb4.Text = "One-hour lunch time timeslot (£4.95)"
        Me.rdb4.UseVisualStyleBackColor = True
        '
        'rdb3
        '
        Me.rdb3.AutoSize = True
        Me.rdb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb3.ForeColor = System.Drawing.Color.MintCream
        Me.rdb3.Location = New System.Drawing.Point(15, 98)
        Me.rdb3.Name = "rdb3"
        Me.rdb3.Size = New System.Drawing.Size(222, 22)
        Me.rdb3.TabIndex = 2
        Me.rdb3.TabStop = True
        Me.rdb3.Text = "Afternoon timeslot (£1.95)"
        Me.rdb3.UseVisualStyleBackColor = True
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb2.ForeColor = System.Drawing.Color.MintCream
        Me.rdb2.Location = New System.Drawing.Point(15, 66)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(210, 22)
        Me.rdb2.TabIndex = 1
        Me.rdb2.TabStop = True
        Me.rdb2.Text = "Morning timeslot (£1.95)"
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb1.ForeColor = System.Drawing.Color.MintCream
        Me.rdb1.Location = New System.Drawing.Point(15, 33)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(217, 22)
        Me.rdb1.TabIndex = 0
        Me.rdb1.TabStop = True
        Me.rdb1.Text = "7:00 am to 7:00 pm (free)"
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Silver
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Red
        Me.btnexit.Location = New System.Drawing.Point(621, 516)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(161, 46)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnsummary
        '
        Me.btnsummary.BackColor = System.Drawing.Color.ForestGreen
        Me.btnsummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsummary.ForeColor = System.Drawing.Color.Aqua
        Me.btnsummary.Location = New System.Drawing.Point(800, 516)
        Me.btnsummary.Name = "btnsummary"
        Me.btnsummary.Size = New System.Drawing.Size(157, 46)
        Me.btnsummary.TabIndex = 7
        Me.btnsummary.Text = "SUMMARY "
        Me.btnsummary.UseVisualStyleBackColor = False
        '
        'frmcomponents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FreshFoodExpress.My.Resources.Resources.Fresh_Food_Express_pic
        Me.ClientSize = New System.Drawing.Size(967, 574)
        Me.Controls.Add(Me.btnsummary)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.grpdeliveryoption)
        Me.Controls.Add(Me.grpoptional)
        Me.Controls.Add(Me.grpessentialvegetable)
        Me.Controls.Add(Me.grpessential)
        Me.Controls.Add(Me.lblfreshfood)
        Me.MaximizeBox = False
        Me.Name = "frmcomponents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fresh Food Express"
        Me.grpessential.ResumeLayout(False)
        Me.grpessentialvegetable.ResumeLayout(False)
        Me.grpoptional.ResumeLayout(False)
        Me.grpdeliveryoption.ResumeLayout(False)
        Me.grpdeliveryoption.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblfreshfood As System.Windows.Forms.Label
    Friend WithEvents lbldayofdelivery As System.Windows.Forms.Label
    Friend WithEvents grpessential As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblboxtype As System.Windows.Forms.Label
    Friend WithEvents cmbtypeofbox As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtypeofpotatoes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdayofdelivery As System.Windows.Forms.ComboBox
    Friend WithEvents grpessentialvegetable As System.Windows.Forms.GroupBox
    Friend WithEvents lblrootvegetables As System.Windows.Forms.Label
    Friend WithEvents lblgreenleafy As System.Windows.Forms.Label
    Friend WithEvents lstbrootvegetables As System.Windows.Forms.ListBox
    Friend WithEvents lstbgreenleafyvegetables As System.Windows.Forms.ListBox
    Friend WithEvents grpoptional As System.Windows.Forms.GroupBox
    Friend WithEvents lblsalad As System.Windows.Forms.Label
    Friend WithEvents chklbsaladvegetables As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklbsoftfruits As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklbcorefruits As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblsoftfruits As System.Windows.Forms.Label
    Friend WithEvents lblcorefruits As System.Windows.Forms.Label
    Friend WithEvents grpdeliveryoption As System.Windows.Forms.GroupBox
    Friend WithEvents rdb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsummary As System.Windows.Forms.Button

End Class
