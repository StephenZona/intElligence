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
        Me.components = New System.ComponentModel.Container()
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Customer_PhoneLabel As System.Windows.Forms.Label
        Dim _Order_DateLabel As System.Windows.Forms.Label
        Dim Order_TimeLabel As System.Windows.Forms.Label
        Dim Qty1Label As System.Windows.Forms.Label
        Dim Unit_Price1Label As System.Windows.Forms.Label
        Dim Sub_Total1Label As System.Windows.Forms.Label
        Dim Sub_Total2Label As System.Windows.Forms.Label
        Dim Order_Sub_TotalLabel As System.Windows.Forms.Label
        Dim TaxLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtRef_No = New System.Windows.Forms.TextBox()
        Me.POSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POSDataSet1 = New POS.POSDataSet1()
        Me.Order_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DateTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.lblPOS = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtAmtPaid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Order_Sub_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblShowCal = New System.Windows.Forms.Label()
        Me.btnCC = New System.Windows.Forms.Button()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.txtConvert = New System.Windows.Forms.TextBox()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCurrencyConverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseCurrencyConverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtReceipt = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.POSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Sub_Total3TextBox = New System.Windows.Forms.TextBox()
        Me.Sub_Total2TextBox = New System.Windows.Forms.TextBox()
        Me.Sub_Total1TextBox = New System.Windows.Forms.TextBox()
        Me.Unit_Price3TextBox = New System.Windows.Forms.TextBox()
        Me.Unit_Price2TextBox = New System.Windows.Forms.TextBox()
        Me.Unit_Price1TextBox = New System.Windows.Forms.TextBox()
        Me.Qty3TextBox = New System.Windows.Forms.TextBox()
        Me.Qty2TextBox = New System.Windows.Forms.TextBox()
        Me.Qty1TextBox = New System.Windows.Forms.TextBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.POSTableAdapter = New POS.POSDataSet1TableAdapters.POSTableAdapter()
        Me.TableAdapterManager = New POS.POSDataSet1TableAdapters.TableAdapterManager()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Customer_PhoneLabel = New System.Windows.Forms.Label()
        _Order_DateLabel = New System.Windows.Forms.Label()
        Order_TimeLabel = New System.Windows.Forms.Label()
        Qty1Label = New System.Windows.Forms.Label()
        Unit_Price1Label = New System.Windows.Forms.Label()
        Sub_Total1Label = New System.Windows.Forms.Label()
        Sub_Total2Label = New System.Windows.Forms.Label()
        Order_Sub_TotalLabel = New System.Windows.Forms.Label()
        TaxLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.POSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.POSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.BackColor = System.Drawing.Color.Transparent
        Customer_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel.ForeColor = System.Drawing.Color.White
        Customer_NameLabel.Location = New System.Drawing.Point(15, 101)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(166, 24)
        Customer_NameLabel.TabIndex = 1
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Customer_PhoneLabel
        '
        Customer_PhoneLabel.AutoSize = True
        Customer_PhoneLabel.BackColor = System.Drawing.Color.Transparent
        Customer_PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_PhoneLabel.ForeColor = System.Drawing.Color.White
        Customer_PhoneLabel.Location = New System.Drawing.Point(6, 168)
        Customer_PhoneLabel.Name = "Customer_PhoneLabel"
        Customer_PhoneLabel.Size = New System.Drawing.Size(172, 24)
        Customer_PhoneLabel.TabIndex = 3
        Customer_PhoneLabel.Text = "Customer Phone:"
        AddHandler Customer_PhoneLabel.Click, AddressOf Me.Customer_PhoneLabel_Click
        '
        '_Order_DateLabel
        '
        _Order_DateLabel.AutoSize = True
        _Order_DateLabel.BackColor = System.Drawing.Color.Transparent
        _Order_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _Order_DateLabel.ForeColor = System.Drawing.Color.White
        _Order_DateLabel.Location = New System.Drawing.Point(349, 104)
        _Order_DateLabel.Name = "_Order_DateLabel"
        _Order_DateLabel.Size = New System.Drawing.Size(58, 24)
        _Order_DateLabel.TabIndex = 5
        _Order_DateLabel.Text = "Date:"
        '
        'Order_TimeLabel
        '
        Order_TimeLabel.AutoSize = True
        Order_TimeLabel.BackColor = System.Drawing.Color.Transparent
        Order_TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_TimeLabel.ForeColor = System.Drawing.Color.White
        Order_TimeLabel.Location = New System.Drawing.Point(349, 169)
        Order_TimeLabel.Name = "Order_TimeLabel"
        Order_TimeLabel.Size = New System.Drawing.Size(63, 24)
        Order_TimeLabel.TabIndex = 7
        Order_TimeLabel.Text = "Time:"
        AddHandler Order_TimeLabel.Click, AddressOf Me.Order_TimeLabel_Click
        '
        'Qty1Label
        '
        Qty1Label.AutoSize = True
        Qty1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Qty1Label.Location = New System.Drawing.Point(194, 53)
        Qty1Label.Name = "Qty1Label"
        Qty1Label.Size = New System.Drawing.Size(35, 16)
        Qty1Label.TabIndex = 7
        Qty1Label.Text = "Qty:"
        '
        'Unit_Price1Label
        '
        Unit_Price1Label.AutoSize = True
        Unit_Price1Label.BackColor = System.Drawing.Color.Transparent
        Unit_Price1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_Price1Label.ForeColor = System.Drawing.Color.White
        Unit_Price1Label.Location = New System.Drawing.Point(332, 53)
        Unit_Price1Label.Name = "Unit_Price1Label"
        Unit_Price1Label.Size = New System.Drawing.Size(79, 16)
        Unit_Price1Label.TabIndex = 13
        Unit_Price1Label.Text = "Unit Price:"
        AddHandler Unit_Price1Label.Click, AddressOf Me.Unit_Price1Label_Click
        '
        'Sub_Total1Label
        '
        Sub_Total1Label.AutoSize = True
        Sub_Total1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sub_Total1Label.Location = New System.Drawing.Point(476, 53)
        Sub_Total1Label.Name = "Sub_Total1Label"
        Sub_Total1Label.Size = New System.Drawing.Size(79, 16)
        Sub_Total1Label.TabIndex = 19
        Sub_Total1Label.Text = "Sub Total:"
        '
        'Sub_Total2Label
        '
        Sub_Total2Label.AutoSize = True
        Sub_Total2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sub_Total2Label.Location = New System.Drawing.Point(377, 140)
        Sub_Total2Label.Name = "Sub_Total2Label"
        Sub_Total2Label.Size = New System.Drawing.Size(0, 16)
        Sub_Total2Label.TabIndex = 21
        '
        'Order_Sub_TotalLabel
        '
        Order_Sub_TotalLabel.AutoSize = True
        Order_Sub_TotalLabel.BackColor = System.Drawing.Color.Transparent
        Order_Sub_TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_Sub_TotalLabel.ForeColor = System.Drawing.Color.White
        Order_Sub_TotalLabel.Location = New System.Drawing.Point(16, 46)
        Order_Sub_TotalLabel.Name = "Order_Sub_TotalLabel"
        Order_Sub_TotalLabel.Size = New System.Drawing.Size(165, 24)
        Order_Sub_TotalLabel.TabIndex = 0
        Order_Sub_TotalLabel.Text = "Order Sub Total:"
        AddHandler Order_Sub_TotalLabel.Click, AddressOf Me.Order_Sub_TotalLabel_Click
        '
        'TaxLabel
        '
        TaxLabel.AutoSize = True
        TaxLabel.BackColor = System.Drawing.Color.Transparent
        TaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TaxLabel.ForeColor = System.Drawing.Color.White
        TaxLabel.Location = New System.Drawing.Point(127, 108)
        TaxLabel.Name = "TaxLabel"
        TaxLabel.Size = New System.Drawing.Size(51, 24)
        TaxLabel.TabIndex = 2
        TaxLabel.Text = "Tax:"
        AddHandler TaxLabel.Click, AddressOf Me.TaxLabel_Click
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.BackColor = System.Drawing.Color.Transparent
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.ForeColor = System.Drawing.Color.White
        TotalLabel.Location = New System.Drawing.Point(119, 180)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(62, 24)
        TotalLabel.TabIndex = 4
        TotalLabel.Text = "Total:"
        AddHandler TotalLabel.Click, AddressOf Me.TotalLabel_Click
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(61, 104)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 16)
        Label1.TabIndex = 25
        Label1.Text = "White Wine"
        AddHandler Label1.Click, AddressOf Me.Label1_Click_1
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(64, 170)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(76, 16)
        Label3.TabIndex = 26
        Label3.Text = "Red Wine"
        AddHandler Label3.Click, AddressOf Me.Label3_Click_1
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(64, 225)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(84, 16)
        Label4.TabIndex = 27
        Label4.Text = "Other Wine"
        AddHandler Label4.Click, AddressOf Me.Label4_Click
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(6, 232)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(80, 24)
        Label5.TabIndex = 9
        Label5.Text = "Ref No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Button24)
        Me.GroupBox1.Controls.Add(Me.Button23)
        Me.GroupBox1.Controls.Add(Me.Button22)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtRef_No)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Order_TimeLabel)
        Me.GroupBox1.Controls.Add(Me.Order_TimeTextBox)
        Me.GroupBox1.Controls.Add(_Order_DateLabel)
        Me.GroupBox1.Controls.Add(Me.Order_DateTextBox)
        Me.GroupBox1.Controls.Add(Customer_PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.Customer_PhoneTextBox)
        Me.GroupBox1.Controls.Add(Customer_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Customer_NameTextBox)
        Me.GroupBox1.Controls.Add(Me.lblPOS)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 350)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(165, 298)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(137, 45)
        Me.Button24.TabIndex = 14
        Me.Button24.Text = "Delete"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(323, 299)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(137, 45)
        Me.Button23.TabIndex = 13
        Me.Button23.Text = "View Prev"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(479, 299)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(137, 45)
        Me.Button22.TabIndex = 12
        Me.Button22.Text = "View Next"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 299)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 45)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "add new"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtRef_No
        '
        Me.txtRef_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Customer_Phone", True))
        Me.txtRef_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRef_No.Location = New System.Drawing.Point(187, 229)
        Me.txtRef_No.Name = "txtRef_No"
        Me.txtRef_No.Size = New System.Drawing.Size(156, 29)
        Me.txtRef_No.TabIndex = 10
        '
        'POSBindingSource
        '
        Me.POSBindingSource.DataMember = "POS"
        Me.POSBindingSource.DataSource = Me.POSDataSet1
        '
        'POSDataSet1
        '
        Me.POSDataSet1.DataSetName = "POSDataSet1"
        Me.POSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_TimeTextBox
        '
        Me.Order_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Order_Time", True))
        Me.Order_TimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_TimeTextBox.Location = New System.Drawing.Point(479, 165)
        Me.Order_TimeTextBox.Name = "Order_TimeTextBox"
        Me.Order_TimeTextBox.Size = New System.Drawing.Size(137, 29)
        Me.Order_TimeTextBox.TabIndex = 8
        '
        'Order_DateTextBox
        '
        Me.Order_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, " Order_Date", True))
        Me.Order_DateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_DateTextBox.Location = New System.Drawing.Point(479, 99)
        Me.Order_DateTextBox.Name = "Order_DateTextBox"
        Me.Order_DateTextBox.Size = New System.Drawing.Size(137, 29)
        Me.Order_DateTextBox.TabIndex = 6
        '
        'Customer_PhoneTextBox
        '
        Me.Customer_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Customer_Phone", True))
        Me.Customer_PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_PhoneTextBox.Location = New System.Drawing.Point(187, 163)
        Me.Customer_PhoneTextBox.Name = "Customer_PhoneTextBox"
        Me.Customer_PhoneTextBox.Size = New System.Drawing.Size(156, 29)
        Me.Customer_PhoneTextBox.TabIndex = 4
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(187, 98)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(156, 29)
        Me.Customer_NameTextBox.TabIndex = 2
        '
        'lblPOS
        '
        Me.lblPOS.BackColor = System.Drawing.Color.Transparent
        Me.lblPOS.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOS.ForeColor = System.Drawing.Color.White
        Me.lblPOS.Location = New System.Drawing.Point(52, 11)
        Me.lblPOS.Name = "lblPOS"
        Me.lblPOS.Size = New System.Drawing.Size(517, 58)
        Me.lblPOS.TabIndex = 0
        Me.lblPOS.Text = "WELCOME TO $t1pH ENTERPRISE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     enjoy....."
        Me.lblPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 369)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox7.BackgroundImage = CType(resources.GetObject("GroupBox7.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox7.Controls.Add(Me.txtChange)
        Me.GroupBox7.Controls.Add(Me.txtAmtPaid)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(TotalLabel)
        Me.GroupBox7.Controls.Add(Me.TotalTextBox)
        Me.GroupBox7.Controls.Add(TaxLabel)
        Me.GroupBox7.Controls.Add(Me.TaxTextBox)
        Me.GroupBox7.Controls.Add(Order_Sub_TotalLabel)
        Me.GroupBox7.Controls.Add(Me.Order_Sub_TotalTextBox)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(0, -1)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(632, 370)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(405, 307)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(135, 29)
        Me.txtChange.TabIndex = 8
        '
        'txtAmtPaid
        '
        Me.txtAmtPaid.Location = New System.Drawing.Point(405, 247)
        Me.txtAmtPaid.Name = "txtAmtPaid"
        Me.txtAmtPaid.Size = New System.Drawing.Size(135, 29)
        Me.txtAmtPaid.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(106, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Change"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(88, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Amt Paid"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Total", True))
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(405, 175)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(135, 29)
        Me.TotalTextBox.TabIndex = 5
        '
        'TaxTextBox
        '
        Me.TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Tax", True))
        Me.TaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxTextBox.Location = New System.Drawing.Point(405, 105)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.Size = New System.Drawing.Size(135, 29)
        Me.TaxTextBox.TabIndex = 3
        '
        'Order_Sub_TotalTextBox
        '
        Me.Order_Sub_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Order_Sub_Total", True))
        Me.Order_Sub_TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_Sub_TotalTextBox.Location = New System.Drawing.Point(405, 41)
        Me.Order_Sub_TotalTextBox.Name = "Order_Sub_TotalTextBox"
        Me.Order_Sub_TotalTextBox.Size = New System.Drawing.Size(135, 29)
        Me.Order_Sub_TotalTextBox.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(637, 351)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(619, 370)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblShowCal)
        Me.TabPage1.Controls.Add(Me.btnCC)
        Me.TabPage1.Controls.Add(Me.lblConvert)
        Me.TabPage1.Controls.Add(Me.txtConvert)
        Me.TabPage1.Controls.Add(Me.cmbCurrency)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button18)
        Me.TabPage1.Controls.Add(Me.btnDot)
        Me.TabPage1.Controls.Add(Me.btnPlus)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.btnMultiply)
        Me.TabPage1.Controls.Add(Me.Button14)
        Me.TabPage1.Controls.Add(Me.btnDivide)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.Button13)
        Me.TabPage1.Controls.Add(Me.btnMinus)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button20)
        Me.TabPage1.Controls.Add(Me.Button19)
        Me.TabPage1.Controls.Add(Me.btnEquals)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.lblDisplay)
        Me.TabPage1.Controls.Add(Me.MenuStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calculator"
        '
        'lblShowCal
        '
        Me.lblShowCal.AutoSize = True
        Me.lblShowCal.Location = New System.Drawing.Point(6, 46)
        Me.lblShowCal.Name = "lblShowCal"
        Me.lblShowCal.Size = New System.Drawing.Size(0, 13)
        Me.lblShowCal.TabIndex = 28
        '
        'btnCC
        '
        Me.btnCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCC.Location = New System.Drawing.Point(344, 38)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(188, 286)
        Me.btnCC.TabIndex = 27
        Me.btnCC.Text = "Currency" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Converter"
        Me.btnCC.UseVisualStyleBackColor = True
        '
        'lblConvert
        '
        Me.lblConvert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConvert.Location = New System.Drawing.Point(344, 180)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(181, 53)
        Me.lblConvert.TabIndex = 25
        Me.lblConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtConvert
        '
        Me.txtConvert.Location = New System.Drawing.Point(344, 144)
        Me.txtConvert.Name = "txtConvert"
        Me.txtConvert.Size = New System.Drawing.Size(181, 20)
        Me.txtConvert.TabIndex = 24
        '
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(344, 99)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(181, 21)
        Me.cmbCurrency.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 39)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Currency Converter"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(4, 286)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(52, 38)
        Me.Button18.TabIndex = 9
        Me.Button18.Text = "0"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(62, 286)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(57, 38)
        Me.btnDot.TabIndex = 14
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(172, 110)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(52, 38)
        Me.btnPlus.TabIndex = 15
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(109, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 38)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "C"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(172, 242)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(52, 38)
        Me.btnMultiply.TabIndex = 13
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(116, 242)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(50, 38)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "3"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(172, 198)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(52, 38)
        Me.btnDivide.TabIndex = 19
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(116, 198)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 38)
        Me.Button10.TabIndex = 20
        Me.Button10.Text = "6"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(60, 242)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(50, 38)
        Me.Button13.TabIndex = 17
        Me.Button13.Text = "2"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(172, 154)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(52, 38)
        Me.btnMinus.TabIndex = 18
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(60, 198)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 38)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "5"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(4, 242)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(50, 38)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "1"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(116, 154)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 38)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "9"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(4, 198)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 38)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "4"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(60, 154)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 38)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "8"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(344, 274)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(90, 41)
        Me.Button20.TabIndex = 10
        Me.Button20.Text = "Convert"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(440, 274)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(85, 41)
        Me.Button19.TabIndex = 10
        Me.Button19.Text = "Close"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(125, 286)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(99, 38)
        Me.btnEquals.TabIndex = 10
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 38)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "7"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = " Del"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(2, 38)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(220, 69)
        Me.lblDisplay.TabIndex = 2
        Me.lblDisplay.Text = "0"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenCurrencyConverterToolStripMenuItem, Me.CloseCurrencyConverterToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenCurrencyConverterToolStripMenuItem
        '
        Me.OpenCurrencyConverterToolStripMenuItem.Name = "OpenCurrencyConverterToolStripMenuItem"
        Me.OpenCurrencyConverterToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.OpenCurrencyConverterToolStripMenuItem.Text = "OpenCurrencyConverter"
        '
        'CloseCurrencyConverterToolStripMenuItem
        '
        Me.CloseCurrencyConverterToolStripMenuItem.Name = "CloseCurrencyConverterToolStripMenuItem"
        Me.CloseCurrencyConverterToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CloseCurrencyConverterToolStripMenuItem.Text = "CloseCurrencyConverter"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txtReceipt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(612, 344)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receipt"
        '
        'txtReceipt
        '
        Me.txtReceipt.AutoSize = True
        Me.txtReceipt.Location = New System.Drawing.Point(38, 5)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(0, 13)
        Me.txtReceipt.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.BackgroundImage = Global.POS.My.Resources.Resources.Screenshot__123_
        Me.TabPage3.Controls.Add(Me.POSDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(612, 344)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sales"
        '
        'POSDataGridView
        '
        Me.POSDataGridView.AutoGenerateColumns = False
        Me.POSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.POSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.POSDataGridView.DataSource = Me.POSBindingSource
        Me.POSDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.POSDataGridView.Name = "POSDataGridView"
        Me.POSDataGridView.Size = New System.Drawing.Size(612, 327)
        Me.POSDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer_Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Phone"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer_Phone"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = " Order_Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = " Order_Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Order_Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Order_Time"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Qty1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Qty2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Qty2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Qty3"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Unit_Price1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unit_Price1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Unit_Price2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Unit_Price2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Unit_Price3"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unit_Price3"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Sub_Total1"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sub_Total1"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Sub_Total2"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Sub_Total2"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Sub_Total3"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Sub_Total3"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Order_Sub_Total"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Order_Sub_Total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Tax"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tax"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImage = Global.POS.My.Resources.Resources.Screenshot__123_
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox4.Controls.Add(Label4)
        Me.GroupBox4.Controls.Add(Label3)
        Me.GroupBox4.Controls.Add(Label1)
        Me.GroupBox4.Controls.Add(Me.Sub_Total3TextBox)
        Me.GroupBox4.Controls.Add(Sub_Total2Label)
        Me.GroupBox4.Controls.Add(Me.Sub_Total2TextBox)
        Me.GroupBox4.Controls.Add(Sub_Total1Label)
        Me.GroupBox4.Controls.Add(Me.Sub_Total1TextBox)
        Me.GroupBox4.Controls.Add(Me.Unit_Price3TextBox)
        Me.GroupBox4.Controls.Add(Me.Unit_Price2TextBox)
        Me.GroupBox4.Controls.Add(Unit_Price1Label)
        Me.GroupBox4.Controls.Add(Me.Unit_Price1TextBox)
        Me.GroupBox4.Controls.Add(Me.Qty3TextBox)
        Me.GroupBox4.Controls.Add(Me.Qty2TextBox)
        Me.GroupBox4.Controls.Add(Qty1Label)
        Me.GroupBox4.Controls.Add(Me.Qty1TextBox)
        Me.GroupBox4.Controls.Add(Me.Button21)
        Me.GroupBox4.Controls.Add(Me.Button17)
        Me.GroupBox4.Controls.Add(Me.Button16)
        Me.GroupBox4.Controls.Add(Me.Button15)
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.btnTotal)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(637, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(619, 350)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'Sub_Total3TextBox
        '
        Me.Sub_Total3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Sub_Total3", True))
        Me.Sub_Total3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Total3TextBox.Location = New System.Drawing.Point(479, 219)
        Me.Sub_Total3TextBox.Name = "Sub_Total3TextBox"
        Me.Sub_Total3TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Sub_Total3TextBox.TabIndex = 24
        '
        'Sub_Total2TextBox
        '
        Me.Sub_Total2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Sub_Total2", True))
        Me.Sub_Total2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Total2TextBox.Location = New System.Drawing.Point(479, 164)
        Me.Sub_Total2TextBox.Name = "Sub_Total2TextBox"
        Me.Sub_Total2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Sub_Total2TextBox.TabIndex = 22
        '
        'Sub_Total1TextBox
        '
        Me.Sub_Total1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Sub_Total1", True))
        Me.Sub_Total1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Total1TextBox.Location = New System.Drawing.Point(479, 98)
        Me.Sub_Total1TextBox.Name = "Sub_Total1TextBox"
        Me.Sub_Total1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Sub_Total1TextBox.TabIndex = 20
        '
        'Unit_Price3TextBox
        '
        Me.Unit_Price3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Unit_Price3", True))
        Me.Unit_Price3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_Price3TextBox.Location = New System.Drawing.Point(335, 219)
        Me.Unit_Price3TextBox.Name = "Unit_Price3TextBox"
        Me.Unit_Price3TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Unit_Price3TextBox.TabIndex = 18
        '
        'Unit_Price2TextBox
        '
        Me.Unit_Price2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Unit_Price2", True))
        Me.Unit_Price2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_Price2TextBox.Location = New System.Drawing.Point(335, 164)
        Me.Unit_Price2TextBox.Name = "Unit_Price2TextBox"
        Me.Unit_Price2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Unit_Price2TextBox.TabIndex = 16
        '
        'Unit_Price1TextBox
        '
        Me.Unit_Price1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Unit_Price1", True))
        Me.Unit_Price1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_Price1TextBox.Location = New System.Drawing.Point(335, 98)
        Me.Unit_Price1TextBox.Name = "Unit_Price1TextBox"
        Me.Unit_Price1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Unit_Price1TextBox.TabIndex = 14
        '
        'Qty3TextBox
        '
        Me.Qty3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Qty3", True))
        Me.Qty3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty3TextBox.Location = New System.Drawing.Point(163, 219)
        Me.Qty3TextBox.Name = "Qty3TextBox"
        Me.Qty3TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Qty3TextBox.TabIndex = 12
        '
        'Qty2TextBox
        '
        Me.Qty2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Qty2", True))
        Me.Qty2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty2TextBox.Location = New System.Drawing.Point(163, 164)
        Me.Qty2TextBox.Name = "Qty2TextBox"
        Me.Qty2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Qty2TextBox.TabIndex = 10
        '
        'Qty1TextBox
        '
        Me.Qty1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Qty1", True))
        Me.Qty1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty1TextBox.Location = New System.Drawing.Point(163, 98)
        Me.Qty1TextBox.Name = "Qty1TextBox"
        Me.Qty1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Qty1TextBox.TabIndex = 8
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Black
        Me.Button21.Location = New System.Drawing.Point(507, 299)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(106, 45)
        Me.Button21.TabIndex = 0
        Me.Button21.Text = "Add To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Basket"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.Black
        Me.Button17.Location = New System.Drawing.Point(437, 299)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(64, 45)
        Me.Button17.TabIndex = 0
        Me.Button17.Text = "Sales"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Location = New System.Drawing.Point(348, 299)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(83, 45)
        Me.Button16.TabIndex = 0
        Me.Button16.Text = "Receipt"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(235, 299)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(107, 45)
        Me.Button15.TabIndex = 0
        Me.Button15.Text = "Calculator"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(163, 299)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(66, 45)
        Me.Button11.TabIndex = 0
        Me.Button11.Text = "Save"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(83, 299)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(74, 45)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Reset"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.Color.Black
        Me.btnTotal.Location = New System.Drawing.Point(6, 299)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(68, 45)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'POSTableAdapter
        '
        Me.POSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.POSTableAdapter = Me.POSTableAdapter
        Me.TableAdapterManager.UpdateOrder = POS.POSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.POS.My.Resources.Resources.Screenshot__123_
        Me.ClientSize = New System.Drawing.Size(1255, 724)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.POSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.POSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblConvert As System.Windows.Forms.Label
    Friend WithEvents txtConvert As System.Windows.Forms.TextBox
    Friend WithEvents cmbCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents btnDot As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnCC As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenCurrencyConverterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseCurrencyConverterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblShowCal As System.Windows.Forms.Label
    Friend WithEvents lblPOS As System.Windows.Forms.Label
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents POSDataSet1 As POS.POSDataSet1
    Friend WithEvents POSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents POSTableAdapter As POS.POSDataSet1TableAdapters.POSTableAdapter
    Friend WithEvents TableAdapterManager As POS.POSDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents POSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Order_TimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Order_DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub_Total3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub_Total2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub_Total1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_Price3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_Price2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_Price1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qty3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qty2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qty1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Order_Sub_TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtRef_No As System.Windows.Forms.TextBox
    Friend WithEvents txtReceipt As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtAmtPaid As System.Windows.Forms.TextBox

End Class
