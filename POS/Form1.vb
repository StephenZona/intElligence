Public Class Form1
    Dim op As String
    Dim firstnum As Double
    Dim secondnum As Double
    Dim ans As Double

    Dim Nigerian_Naira As Double = 302.96
    Dim US_Dollar As Double = 1.52
    Dim Kenyan_Shilling As Double = 156.21
    Dim Canadian_Dollar As Double = 2.03


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim British_Pounds As Double = CDbl(txtConvert.Text)
        lblConvert.Text = CStr(CuConverter(British_Pounds))

        If cmbCurrency.Text = "Nigeria" Then
            lblConvert.Text = "NGN" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "USA" Then
            lblConvert.Text = "$" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Canada" Then
            lblConvert.Text = "C$" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Kenya" Then
            lblConvert.Text = "KES" & " " & Val(lblConvert.Text)
        End If

    End Sub

    Function CuConverter(ByVal money As Double) As Double
        

        If cmbCurrency.Text = "Nigeria" Then
            Return Math.Round(Nigerian_Naira * money, 2)
        ElseIf cmbCurrency.Text = "USA" Then
            Return Math.Round(US_Dollar * money, 2)
        ElseIf cmbCurrency.Text = "Kenya" Then
            Return Math.Round(Kenyan_Shilling * money, 2)
        ElseIf cmbCurrency.Text = "Canada" Then
            Return Math.Round(Canadian_Dollar * money, 2)


        End If
    End Function

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        btnCC.Visible = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConvert.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConvert.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCurrency.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDisplay.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lblDisplay.Text.Length > 0 Then
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        secondnum = lblDisplay.Text
        If op = "+" Then
            ans = firstnum + secondnum
            lblDisplay.Text = ans
            lblShowCal.Text = ""
        ElseIf op = "-" Then
            ans = firstnum - secondnum
            lblDisplay.Text = ans
            lblShowCal.Text = ""
        ElseIf op = "/" Then
            ans = firstnum / secondnum
            lblDisplay.Text = ans
            lblShowCal.Text = ""
        ElseIf op = "*" Then
            ans = firstnum * secondnum
            lblDisplay.Text = ans
            lblShowCal.Text = ""

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lblDisplay.Text = "0"
        lblShowCal.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot.Click
        If InStr(lblDisplay.Text, ".") = 0 Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub OpenCurrencyConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenCurrencyConverterToolStripMenuItem.Click
        btnCC.Visible = False
    End Sub

    Private Sub CloseCurrencyConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseCurrencyConverterToolStripMenuItem.Click
        btnCC.Visible = True
    End Sub

    Private Sub btnCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCC.Click
        btnCC.Visible = False
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click, Button8.Click, Button6.Click, Button5.Click, Button2.Click, Button14.Click, Button13.Click, Button12.Click, Button10.Click, Button18.Click
        Dim b As Button = sender
        If lblDisplay.Text = "0" Then
            lblDisplay.Text = b.Text
        Else
            lblDisplay.Text = lblDisplay.Text + b.Text
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POSDataSet1.POS' table. You can move, or remove it, as needed.
        Me.POSTableAdapter.Fill(Me.POSDataSet1.POS)
        Customer_NameTextBox.Text = ""
        Customer_PhoneTextBox.Text = ""
        txtRef_No.Text = ""

        Order_Sub_TotalTextBox.Text = ""
        TaxTextBox.Text = ""
        TotalTextBox.Text = ""

        Order_DateTextBox.Text = ""
        Order_TimeTextBox.Text = ""


        cmbCurrency.Text = "Choose one..."
        cmbCurrency.Items.Add("USA")
        cmbCurrency.Items.Add("Nigeria")
        cmbCurrency.Items.Add("Canada")
        cmbCurrency.Items.Add("Kenya")


        Sub_Total1TextBox.Text = "0"
        Unit_Price1TextBox.Text = "$12.00"
        Qty1TextBox.Text = "0"
        Sub_Total2TextBox.Text = "0"
        Unit_Price2TextBox.Text = "$14.00"
        Qty2TextBox.Text = "0"
        Sub_Total3TextBox.Text = "0"
        Unit_Price3TextBox.Text = "0"
        Qty3TextBox.Text = "0"

    End Sub

    Private Sub arithmetic_fxn(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click, btnPlus.Click, btnMultiply.Click, btnDivide.Click
        Dim ops As Button = sender
        firstnum = lblDisplay.Text
        lblShowCal.Text = lblDisplay.Text
        lblDisplay.Text = ""
        op = ops.Text
        lblShowCal.Text = lblShowCal.Text + " " + op
    End Sub

    Private Sub lblDisplay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDisplay.TextChanged
        If lblDisplay.Text = "" Then
            lblDisplay.Text = "0"
        End If
    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub POSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.POSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.POSDataSet1)

    End Sub

    Private Sub TotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalTextBox.TextChanged

    End Sub

    Private Sub POSDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles POSDataGridView.CellContentClick

    End Sub

    Private Sub Customer_PhoneLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Sub_Total2TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sub_Total2TextBox.TextChanged

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim iTax As Double
        txtRef_No.Text = (Rnd() * 32000)
        Order_DateTextBox.Text = Today
        Order_TimeTextBox.Text = TimeOfDay
        iTax = 17.5

        Sub_Total1TextBox.Text = Unit_Price1TextBox.Text * Qty1TextBox.Text
        Sub_Total2TextBox.Text = Unit_Price2TextBox.Text * Qty2TextBox.Text
        Sub_Total3TextBox.Text = Unit_Price3TextBox.Text * Qty3TextBox.Text

        Order_Sub_TotalTextBox.Text = Val(Sub_Total1TextBox.Text) + Val(Sub_Total2TextBox.Text) + Val(Sub_Total3TextBox.Text)
        TaxTextBox.Text = (Order_Sub_TotalTextBox.Text * iTax) / 100
        TotalTextBox.Text = Val(TaxTextBox.Text) + Val(Order_Sub_TotalTextBox.Text)

        Unit_Price1TextBox.Text = FormatCurrency(Unit_Price1TextBox.Text)
        Unit_Price2TextBox.Text = FormatCurrency(Unit_Price2TextBox.Text)
        Unit_Price3TextBox.Text = FormatCurrency(Unit_Price3TextBox.Text)

        Sub_Total1TextBox.Text = FormatCurrency(Unit_Price1TextBox.Text * Qty1TextBox.Text)
        Sub_Total2TextBox.Text = FormatCurrency(Unit_Price2TextBox.Text * Qty2TextBox.Text)
        Sub_Total3TextBox.Text = FormatCurrency(Unit_Price3TextBox.Text * Qty3TextBox.Text)

        Order_Sub_TotalTextBox.Text = FormatCurrency(Order_Sub_TotalTextBox.Text)
        TaxTextBox.Text = FormatCurrency(TaxTextBox.Text)
        TotalTextBox.Text = FormatCurrency(TotalTextBox.Text)
    End Sub

    Private Sub Sub_Total1TextBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sub_Total1TextBox.MouseHover
        'Sub_Total1TextBox.Text = ""
        'Sub_Total2TextBox.Text = ""

    End Sub

    Private Sub Sub_Total1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sub_Total1TextBox.TextChanged

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txtAmtPaid.Text = ""
        txtChange.Text = ""
        Customer_NameTextBox.Text = ""
        txtRef_No.Text = ""
        Customer_PhoneTextBox.Text = ""
        Order_DateTextBox.Text = ""
        Order_TimeTextBox.Text = ""
        Order_Sub_TotalTextBox.Text = ""
        TaxTextBox.Text = ""
        TotalTextBox.Text = ""
        txtReceipt.Text = ""

        Qty1TextBox.Text = "0"
        Qty2TextBox.Text = "0"
        Qty3TextBox.Text = "0"

        Unit_Price1TextBox.Text = "$12.00"
        Unit_Price2TextBox.Text = "$14.00"
        Unit_Price3TextBox.Text = "0"

        Sub_Total1TextBox.Text = "0"
        Sub_Total2TextBox.Text = "0"
        Sub_Total3TextBox.Text = "0"




    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
        Me.Validate()
        Me.POSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.POSDataSet1)
        'Unit_Price1TextBox.Text = "$12.00"
            'Unit_Price2TextBox.Text = "$14.00"
        Catch ex As Exception
            ' MsgBox("ex.message")
        End Try
    End Sub

    Private Sub Button16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        ' Try


        txtChange.Text = txtAmtPaid.Text - TotalTextBox.Text
        Order_TimeTextBox.Text = TimeOfDay
        Order_DateTextBox.Text = Today
        If Customer_NameTextBox.Text = "" Or Customer_PhoneTextBox.Text = "" Or txtAmtPaid.Text = "" Then
            MsgBox("Enter full details", MsgBoxStyle.Critical, "Error")
        Else
            TabControl1.SelectedTab = TabPage2
            txtReceipt.Text = ("                                 ONLINE POINT OF SALE" + vbNewLine & "======================================================" + vbNewLine + vbNewLine & "Name:" & Customer_NameTextBox.Text + "           " & "Phone No:" & Customer_PhoneTextBox.Text + "          " & "Ref No:" & txtRef_No.Text + vbNewLine + vbNewLine & "Order Date:" & Order_DateTextBox.Text + vbNewLine + vbNewLine + "Order Time:" & Order_TimeTextBox.Text + vbNewLine + vbNewLine + "Item Type" + "              " & "Qty" + "           " + "Unit Price" + "           " + "Sub Total" + vbNewLine + "White Wine:" + "           " + Qty1TextBox.Text + "              " + Unit_Price1TextBox.Text + "                  " + Sub_Total1TextBox.Text + vbNewLine + "Red    Wine:" + "           " + Qty2TextBox.Text + "              " + Unit_Price2TextBox.Text + "                  " + Sub_Total2TextBox.Text + vbNewLine + "Other  Wine:" + "           " + Qty3TextBox.Text + "              " + Unit_Price3TextBox.Text + "                  " + Sub_Total3TextBox.Text + vbNewLine + vbNewLine + "Order Sub Total:        " & Order_Sub_TotalTextBox.Text + vbNewLine + "Tax On Order:            " & TaxTextBox.Text + vbNewLine + "Net Total:                   " & TotalTextBox.Text + vbNewLine + vbNewLine + "Amt Paid:" & txtAmtPaid.Text + vbNewLine + "Change:" & txtChange.Text + vbNewLine + "Teller Name:  $t1pH" + vbNewLine + "======================================================" + vbNewLine + vbNewLine + "                                 THANK YOU, CALL AGAIN!!!")

        End If
        ' Catch ex As Exception
        '   MsgBox("ex.message")
        'End Try


    End Sub

    Private Sub Qty1TextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Qty1TextBox.MouseDown
        Qty1TextBox.Text = ""
    End Sub

    Private Sub Qty1TextBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qty1TextBox.MouseHover
        'Qty1TextBox.Text = ""
    End Sub

    Private Sub Qty1TextBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qty1TextBox.MouseLeave
        'Qty1TextBox.Text = "0"
    End Sub

    Private Sub Qty1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty1TextBox.TextChanged

    End Sub

    Private Sub Qty2TextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Qty2TextBox.MouseDown
        Qty2TextBox.Text = ""
    End Sub

    Private Sub Qty2TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty2TextBox.TextChanged

    End Sub

    Private Sub Qty3TextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Qty3TextBox.MouseDown
        Qty3TextBox.Text = ""
    End Sub

    Private Sub Qty3TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qty3TextBox.TextChanged

    End Sub

    Private Sub Unit_Price1TextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Unit_Price1TextBox.MouseDown
        Unit_Price1TextBox.Text = ""
    End Sub

    Private Sub Unit_Price1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unit_Price1TextBox.TextChanged

    End Sub

    Private Sub Unit_Price2TextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Unit_Price2TextBox.MouseDown
        Unit_Price2TextBox.Text = ""
    End Sub

    Private Sub Unit_Price2TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unit_Price2TextBox.TextChanged

    End Sub

    Private Sub Unit_Price3TextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Unit_Price3TextBox.MouseDown
        Unit_Price3TextBox.Text = ""
    End Sub

    Private Sub Unit_Price3TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unit_Price3TextBox.TextChanged

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        POSBindingSource.AddNew()
        txtAmtPaid.Text = ""
        txtChange.Text = ""
        Unit_Price1TextBox.Text = "$12.00"
        Unit_Price2TextBox.Text = "$14.00"
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        POSBindingSource.MoveNext()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        POSBindingSource.MovePrevious()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TaxTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxTextBox.TextChanged

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        POSBindingSource.MoveNext()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        POSBindingSource.MovePrevious()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        POSBindingSource.RemoveCurrent()
    End Sub

    Private Sub Sub_Total3TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sub_Total3TextBox.TextChanged

    End Sub

    Private Sub Order_Sub_TotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Order_Sub_TotalTextBox.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TaxLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Unit_Price1Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Order_TimeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Order_Sub_TotalLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TotalLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class
