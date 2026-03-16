<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPaymentCollection
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
        Me.grpPaymentCollection = New System.Windows.Forms.GroupBox()
        Me.tabPaymentInfo = New System.Windows.Forms.TabControl()
        Me.tabCollectionInfo = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.dgvCollectionBills = New System.Windows.Forms.DataGridView()
        Me.colBillNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBillAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaidAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDueAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pnlTotalDue = New System.Windows.Forms.Panel()
        Me.lblTotalDueValue = New System.Windows.Forms.Label()
        Me.lblTotalDueText = New System.Windows.Forms.Label()
        Me.tabPaymentDetails = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpPendingContainer = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpOfficeAck = New System.Windows.Forms.GroupBox()
        Me.dgvOfficeAck = New System.Windows.Forms.DataGridView()
        Me.colAckName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAckDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAckAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAckRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpBankRecon = New System.Windows.Forms.GroupBox()
        Me.dgvBankRecon = New System.Windows.Forms.DataGridView()
        Me.colReconDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReconDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReconAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReconParty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlPendingSummary = New System.Windows.Forms.Panel()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblQuickSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.colSNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRefNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAck1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAck2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActions = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFormCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpPaymentCollection.SuspendLayout()
        Me.tabPaymentInfo.SuspendLayout()
        Me.tabCollectionInfo.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvCollectionBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalDue.SuspendLayout()
        Me.tabPaymentDetails.SuspendLayout()
        Me.grpPendingContainer.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpOfficeAck.SuspendLayout()
        CType(Me.dgvOfficeAck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBankRecon.SuspendLayout()
        CType(Me.dgvBankRecon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPaymentCollection
        '
        Me.grpPaymentCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPaymentCollection.BackColor = System.Drawing.Color.White
        Me.grpPaymentCollection.Controls.Add(Me.tabPaymentInfo)
        Me.grpPaymentCollection.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.grpPaymentCollection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grpPaymentCollection.Location = New System.Drawing.Point(12, 12)
        Me.grpPaymentCollection.Name = "grpPaymentCollection"
        Me.grpPaymentCollection.Size = New System.Drawing.Size(1509, 350)
        Me.grpPaymentCollection.TabIndex = 0
        Me.grpPaymentCollection.TabStop = False
        Me.grpPaymentCollection.Text = "💰 PAYMENT COLLECTION"
        '
        'tabPaymentInfo
        '
        Me.tabPaymentInfo.Controls.Add(Me.tabCollectionInfo)
        Me.tabPaymentInfo.Controls.Add(Me.tabPaymentDetails)
        Me.tabPaymentInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPaymentInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tabPaymentInfo.Location = New System.Drawing.Point(3, 35)
        Me.tabPaymentInfo.Name = "tabPaymentInfo"
        Me.tabPaymentInfo.SelectedIndex = 0
        Me.tabPaymentInfo.Size = New System.Drawing.Size(1503, 312)
        Me.tabPaymentInfo.TabIndex = 0
        '
        'tabCollectionInfo
        '
        Me.tabCollectionInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.tabCollectionInfo.Controls.Add(Me.SplitContainer2)
        Me.tabCollectionInfo.Location = New System.Drawing.Point(4, 32)
        Me.tabCollectionInfo.Name = "tabCollectionInfo"
        Me.tabCollectionInfo.Padding = New System.Windows.Forms.Padding(10)
        Me.tabCollectionInfo.Size = New System.Drawing.Size(1495, 276)
        Me.tabCollectionInfo.TabIndex = 0
        Me.tabCollectionInfo.Text = "📋 COLLECTION INFORMATION"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(10, 10)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvCollectionBills)
        Me.SplitContainer2.Panel2.Controls.Add(Me.pnlTotalDue)
        Me.SplitContainer2.Size = New System.Drawing.Size(1475, 256)
        Me.SplitContainer2.SplitterDistance = 120
        Me.SplitContainer2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.814661!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.8686!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.878285!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.57677!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDate, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCustomer, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmployee, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAddress, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmail, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPhone, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAddress, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPhone, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1475, 120)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(13, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(61, 23)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date *"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDate
        '
        Me.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(126, 13)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(175, 30)
        Me.dtpDate.TabIndex = 2
        Me.dtpDate.Value = New Date(2026, 3, 2, 0, 0, 0, 0)
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblCustomer.Location = New System.Drawing.Point(13, 47)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(100, 23)
        Me.lblCustomer.TabIndex = 5
        Me.lblCustomer.Text = "Customer *"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(126, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 30)
        Me.TextBox1.TabIndex = 14
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblEmployee.Location = New System.Drawing.Point(13, 84)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(101, 23)
        Me.lblEmployee.TabIndex = 3
        Me.lblEmployee.Text = "Employee *"
        Me.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(126, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 30)
        Me.TextBox2.TabIndex = 15
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(342, 10)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(79, 23)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(342, 47)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(59, 23)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(342, 84)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(64, 23)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAddress.Location = New System.Drawing.Point(427, 13)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(370, 32)
        Me.txtAddress.TabIndex = 16
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtEmail.Location = New System.Drawing.Point(427, 50)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(370, 32)
        Me.txtEmail.TabIndex = 17
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPhone.Location = New System.Drawing.Point(427, 87)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(206, 32)
        Me.txtPhone.TabIndex = 18
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvCollectionBills
        '
        Me.dgvCollectionBills.AllowUserToAddRows = False
        Me.dgvCollectionBills.AllowUserToDeleteRows = False
        Me.dgvCollectionBills.BackgroundColor = System.Drawing.Color.White
        Me.dgvCollectionBills.ColumnHeadersHeight = 35
        Me.dgvCollectionBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBillNo, Me.colBillDate, Me.colBillAmount, Me.colPaidAmount, Me.colDueAmount, Me.colSelect})
        Me.dgvCollectionBills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCollectionBills.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCollectionBills.Location = New System.Drawing.Point(0, 0)
        Me.dgvCollectionBills.Name = "dgvCollectionBills"
        Me.dgvCollectionBills.RowHeadersVisible = False
        Me.dgvCollectionBills.RowHeadersWidth = 51
        Me.dgvCollectionBills.RowTemplate.Height = 28
        Me.dgvCollectionBills.Size = New System.Drawing.Size(1475, 106)
        Me.dgvCollectionBills.TabIndex = 1
        '
        'colBillNo
        '
        Me.colBillNo.HeaderText = "Bill No"
        Me.colBillNo.MinimumWidth = 6
        Me.colBillNo.Name = "colBillNo"
        Me.colBillNo.Width = 120
        '
        'colBillDate
        '
        Me.colBillDate.HeaderText = "Bill Date"
        Me.colBillDate.MinimumWidth = 6
        Me.colBillDate.Name = "colBillDate"
        '
        'colBillAmount
        '
        Me.colBillAmount.HeaderText = "Bill Amount"
        Me.colBillAmount.MinimumWidth = 6
        Me.colBillAmount.Name = "colBillAmount"
        Me.colBillAmount.Width = 120
        '
        'colPaidAmount
        '
        Me.colPaidAmount.HeaderText = "Paid Amount"
        Me.colPaidAmount.MinimumWidth = 6
        Me.colPaidAmount.Name = "colPaidAmount"
        Me.colPaidAmount.Width = 120
        '
        'colDueAmount
        '
        Me.colDueAmount.HeaderText = "Due Amount"
        Me.colDueAmount.MinimumWidth = 6
        Me.colDueAmount.Name = "colDueAmount"
        Me.colDueAmount.Width = 120
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "Select"
        Me.colSelect.MinimumWidth = 6
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Width = 80
        '
        'pnlTotalDue
        '
        Me.pnlTotalDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalDue.Controls.Add(Me.lblTotalDueValue)
        Me.pnlTotalDue.Controls.Add(Me.lblTotalDueText)
        Me.pnlTotalDue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotalDue.Location = New System.Drawing.Point(0, 106)
        Me.pnlTotalDue.Name = "pnlTotalDue"
        Me.pnlTotalDue.Size = New System.Drawing.Size(1475, 26)
        Me.pnlTotalDue.TabIndex = 2
        '
        'lblTotalDueValue
        '
        Me.lblTotalDueValue.AutoSize = True
        Me.lblTotalDueValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDueValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalDueValue.Location = New System.Drawing.Point(1300, 3)
        Me.lblTotalDueValue.Name = "lblTotalDueValue"
        Me.lblTotalDueValue.Size = New System.Drawing.Size(60, 23)
        Me.lblTotalDueValue.TabIndex = 1
        Me.lblTotalDueValue.Text = "₹ 0.00"
        '
        'lblTotalDueText
        '
        Me.lblTotalDueText.AutoSize = True
        Me.lblTotalDueText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDueText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalDueText.Location = New System.Drawing.Point(1200, 3)
        Me.lblTotalDueText.Name = "lblTotalDueText"
        Me.lblTotalDueText.Size = New System.Drawing.Size(91, 23)
        Me.lblTotalDueText.TabIndex = 0
        Me.lblTotalDueText.Text = "Total Due:"
        '
        'tabPaymentDetails
        '
        Me.tabPaymentDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.tabPaymentDetails.Controls.Add(Me.TableLayoutPanel2)
        Me.tabPaymentDetails.Location = New System.Drawing.Point(4, 32)
        Me.tabPaymentDetails.Name = "tabPaymentDetails"
        Me.tabPaymentDetails.Padding = New System.Windows.Forms.Padding(10)
        Me.tabPaymentDetails.Size = New System.Drawing.Size(1495, 276)
        Me.tabPaymentDetails.TabIndex = 1
        Me.tabPaymentDetails.Text = "💰 PAYMENT DETAILS"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.54039!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.73816!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.66852!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.1922!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(15)
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1475, 256)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'grpPendingContainer
        '
        Me.grpPendingContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPendingContainer.BackColor = System.Drawing.Color.White
        Me.grpPendingContainer.Controls.Add(Me.SplitContainer1)
        Me.grpPendingContainer.Controls.Add(Me.pnlPendingSummary)
        Me.grpPendingContainer.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpPendingContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grpPendingContainer.Location = New System.Drawing.Point(12, 349)
        Me.grpPendingContainer.Name = "grpPendingContainer"
        Me.grpPendingContainer.Size = New System.Drawing.Size(1506, 169)
        Me.grpPendingContainer.TabIndex = 5
        Me.grpPendingContainer.TabStop = False
        Me.grpPendingContainer.Text = "📋 PENDING ITEMS"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpOfficeAck)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpBankRecon)
        Me.SplitContainer1.Size = New System.Drawing.Size(1500, 101)
        Me.SplitContainer1.SplitterDistance = 747
        Me.SplitContainer1.TabIndex = 1
        '
        'grpOfficeAck
        '
        Me.grpOfficeAck.Controls.Add(Me.dgvOfficeAck)
        Me.grpOfficeAck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOfficeAck.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpOfficeAck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpOfficeAck.Location = New System.Drawing.Point(0, 0)
        Me.grpOfficeAck.Name = "grpOfficeAck"
        Me.grpOfficeAck.Size = New System.Drawing.Size(747, 101)
        Me.grpOfficeAck.TabIndex = 0
        Me.grpOfficeAck.TabStop = False
        Me.grpOfficeAck.Text = "Pending Office Acknowledgement"
        '
        'dgvOfficeAck
        '
        Me.dgvOfficeAck.AllowUserToAddRows = False
        Me.dgvOfficeAck.AllowUserToDeleteRows = False
        Me.dgvOfficeAck.BackgroundColor = System.Drawing.Color.White
        Me.dgvOfficeAck.ColumnHeadersHeight = 30
        Me.dgvOfficeAck.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAckName, Me.colAckDate, Me.colAckAmount, Me.colAckRef})
        Me.dgvOfficeAck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOfficeAck.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvOfficeAck.Location = New System.Drawing.Point(3, 26)
        Me.dgvOfficeAck.Name = "dgvOfficeAck"
        Me.dgvOfficeAck.ReadOnly = True
        Me.dgvOfficeAck.RowHeadersVisible = False
        Me.dgvOfficeAck.RowHeadersWidth = 51
        Me.dgvOfficeAck.RowTemplate.Height = 28
        Me.dgvOfficeAck.Size = New System.Drawing.Size(741, 72)
        Me.dgvOfficeAck.TabIndex = 0
        '
        'colAckName
        '
        Me.colAckName.HeaderText = "Name"
        Me.colAckName.MinimumWidth = 6
        Me.colAckName.Name = "colAckName"
        Me.colAckName.ReadOnly = True
        Me.colAckName.Width = 150
        '
        'colAckDate
        '
        Me.colAckDate.HeaderText = "Date"
        Me.colAckDate.MinimumWidth = 6
        Me.colAckDate.Name = "colAckDate"
        Me.colAckDate.ReadOnly = True
        Me.colAckDate.Width = 90
        '
        'colAckAmount
        '
        Me.colAckAmount.HeaderText = "Amount"
        Me.colAckAmount.MinimumWidth = 6
        Me.colAckAmount.Name = "colAckAmount"
        Me.colAckAmount.ReadOnly = True
        Me.colAckAmount.Width = 90
        '
        'colAckRef
        '
        Me.colAckRef.HeaderText = "Ref"
        Me.colAckRef.MinimumWidth = 6
        Me.colAckRef.Name = "colAckRef"
        Me.colAckRef.ReadOnly = True
        Me.colAckRef.Width = 80
        '
        'grpBankRecon
        '
        Me.grpBankRecon.Controls.Add(Me.dgvBankRecon)
        Me.grpBankRecon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBankRecon.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpBankRecon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpBankRecon.Location = New System.Drawing.Point(0, 0)
        Me.grpBankRecon.Name = "grpBankRecon"
        Me.grpBankRecon.Size = New System.Drawing.Size(749, 101)
        Me.grpBankRecon.TabIndex = 1
        Me.grpBankRecon.TabStop = False
        Me.grpBankRecon.Text = "Pending Bank Reconciliation"
        '
        'dgvBankRecon
        '
        Me.dgvBankRecon.AllowUserToAddRows = False
        Me.dgvBankRecon.AllowUserToDeleteRows = False
        Me.dgvBankRecon.BackgroundColor = System.Drawing.Color.White
        Me.dgvBankRecon.ColumnHeadersHeight = 30
        Me.dgvBankRecon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReconDesc, Me.colReconDate, Me.colReconAmount, Me.colReconParty})
        Me.dgvBankRecon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBankRecon.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvBankRecon.Location = New System.Drawing.Point(3, 26)
        Me.dgvBankRecon.Name = "dgvBankRecon"
        Me.dgvBankRecon.ReadOnly = True
        Me.dgvBankRecon.RowHeadersVisible = False
        Me.dgvBankRecon.RowHeadersWidth = 51
        Me.dgvBankRecon.RowTemplate.Height = 28
        Me.dgvBankRecon.Size = New System.Drawing.Size(743, 72)
        Me.dgvBankRecon.TabIndex = 1
        '
        'colReconDesc
        '
        Me.colReconDesc.HeaderText = "Description"
        Me.colReconDesc.MinimumWidth = 6
        Me.colReconDesc.Name = "colReconDesc"
        Me.colReconDesc.ReadOnly = True
        Me.colReconDesc.Width = 150
        '
        'colReconDate
        '
        Me.colReconDate.HeaderText = "Date"
        Me.colReconDate.MinimumWidth = 6
        Me.colReconDate.Name = "colReconDate"
        Me.colReconDate.ReadOnly = True
        Me.colReconDate.Width = 90
        '
        'colReconAmount
        '
        Me.colReconAmount.HeaderText = "Amount"
        Me.colReconAmount.MinimumWidth = 6
        Me.colReconAmount.Name = "colReconAmount"
        Me.colReconAmount.ReadOnly = True
        Me.colReconAmount.Width = 90
        '
        'colReconParty
        '
        Me.colReconParty.HeaderText = "Party"
        Me.colReconParty.MinimumWidth = 6
        Me.colReconParty.Name = "colReconParty"
        Me.colReconParty.ReadOnly = True
        Me.colReconParty.Width = 120
        '
        'pnlPendingSummary
        '
        Me.pnlPendingSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlPendingSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPendingSummary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPendingSummary.Location = New System.Drawing.Point(3, 129)
        Me.pnlPendingSummary.Name = "pnlPendingSummary"
        Me.pnlPendingSummary.Size = New System.Drawing.Size(1500, 37)
        Me.pnlPendingSummary.TabIndex = 0
        '
        'pnlSearch
        '
        Me.pnlSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.lblQuickSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.lblFrom)
        Me.pnlSearch.Controls.Add(Me.dtpFrom)
        Me.pnlSearch.Controls.Add(Me.lblTo)
        Me.pnlSearch.Controls.Add(Me.dtpTo)
        Me.pnlSearch.Controls.Add(Me.btnGo)
        Me.pnlSearch.Location = New System.Drawing.Point(13, 524)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1502, 49)
        Me.pnlSearch.TabIndex = 1
        '
        'lblQuickSearch
        '
        Me.lblQuickSearch.AutoSize = True
        Me.lblQuickSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuickSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblQuickSearch.Location = New System.Drawing.Point(10, 13)
        Me.lblQuickSearch.Name = "lblQuickSearch"
        Me.lblQuickSearch.Size = New System.Drawing.Size(132, 25)
        Me.lblQuickSearch.TabIndex = 0
        Me.lblQuickSearch.Text = "Quick Search:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(148, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(326, 30)
        Me.txtSearch.TabIndex = 1
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(480, 13)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(57, 23)
        Me.lblFrom.TabIndex = 3
        Me.lblFrom.Text = "From:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(538, 10)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(110, 30)
        Me.dtpFrom.TabIndex = 4
        Me.dtpFrom.Value = New Date(2026, 3, 1, 0, 0, 0, 0)
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTo.Location = New System.Drawing.Point(664, 13)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(33, 23)
        Me.lblTo.TabIndex = 5
        Me.lblTo.Text = "To:"
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(702, 10)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(110, 30)
        Me.dtpTo.TabIndex = 6
        Me.dtpTo.Value = New Date(2026, 3, 31, 0, 0, 0, 0)
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGo.FlatAppearance.BorderSize = 0
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(858, 11)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(70, 30)
        Me.btnGo.TabIndex = 7
        Me.btnGo.Text = "🔍 GO"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 579)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(1506, 38)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "💰 PAYMENT MASTER"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.AutoSize = True
        Me.lblTotalRecords.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblTotalRecords.Location = New System.Drawing.Point(1335, 588)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(126, 25)
        Me.lblTotalRecords.TabIndex = 3
        Me.lblTotalRecords.Text = "📋 0 Records"
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayments.BackgroundColor = System.Drawing.Color.White
        Me.dgvPayments.ColumnHeadersHeight = 40
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSNo, Me.colVNo, Me.colDate, Me.colCustomer, Me.colAmount, Me.colAccount, Me.colRefNo, Me.colEmployee, Me.colAck1, Me.colAck2, Me.colActions})
        Me.dgvPayments.EnableHeadersVisualStyles = False
        Me.dgvPayments.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvPayments.Location = New System.Drawing.Point(12, 620)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.RowHeadersWidth = 51
        Me.dgvPayments.RowTemplate.Height = 32
        Me.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayments.Size = New System.Drawing.Size(1509, 130)
        Me.dgvPayments.TabIndex = 4
        '
        'colSNo
        '
        Me.colSNo.HeaderText = "#"
        Me.colSNo.MinimumWidth = 6
        Me.colSNo.Name = "colSNo"
        Me.colSNo.ReadOnly = True
        Me.colSNo.Width = 40
        '
        'colVNo
        '
        Me.colVNo.HeaderText = "V#"
        Me.colVNo.MinimumWidth = 6
        Me.colVNo.Name = "colVNo"
        Me.colVNo.ReadOnly = True
        Me.colVNo.Width = 45
        '
        'colDate
        '
        Me.colDate.HeaderText = "DATE"
        Me.colDate.MinimumWidth = 6
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.Width = 85
        '
        'colCustomer
        '
        Me.colCustomer.HeaderText = "CUSTOMER"
        Me.colCustomer.MinimumWidth = 6
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        Me.colCustomer.Width = 150
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "AMOUNT"
        Me.colAmount.MinimumWidth = 6
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        Me.colAmount.Width = 90
        '
        'colAccount
        '
        Me.colAccount.HeaderText = "ACCOUNT"
        Me.colAccount.MinimumWidth = 6
        Me.colAccount.Name = "colAccount"
        Me.colAccount.ReadOnly = True
        Me.colAccount.Width = 90
        '
        'colRefNo
        '
        Me.colRefNo.HeaderText = "REF NO"
        Me.colRefNo.MinimumWidth = 6
        Me.colRefNo.Name = "colRefNo"
        Me.colRefNo.ReadOnly = True
        Me.colRefNo.Width = 110
        '
        'colEmployee
        '
        Me.colEmployee.HeaderText = "EMPLOYEE"
        Me.colEmployee.MinimumWidth = 6
        Me.colEmployee.Name = "colEmployee"
        Me.colEmployee.ReadOnly = True
        '
        'colAck1
        '
        Me.colAck1.HeaderText = "ACK1"
        Me.colAck1.MinimumWidth = 6
        Me.colAck1.Name = "colAck1"
        Me.colAck1.ReadOnly = True
        Me.colAck1.Width = 60
        '
        'colAck2
        '
        Me.colAck2.HeaderText = "ACK2"
        Me.colAck2.MinimumWidth = 6
        Me.colAck2.Name = "colAck2"
        Me.colAck2.ReadOnly = True
        Me.colAck2.Width = 60
        '
        'colActions
        '
        Me.colActions.HeaderText = "ACTIONS"
        Me.colActions.MinimumWidth = 6
        Me.colActions.Name = "colActions"
        Me.colActions.ReadOnly = True
        Me.colActions.Text = "✔️ View"
        Me.colActions.UseColumnTextForButtonValue = True
        Me.colActions.Width = 80
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.btnFormCancel)
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Controls.Add(Me.btnDelete)
        Me.pnlButtons.Controls.Add(Me.btnEdit)
        Me.pnlButtons.Controls.Add(Me.btnAdd)
        Me.pnlButtons.Location = New System.Drawing.Point(12, 756)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1516, 66)
        Me.pnlButtons.TabIndex = 12
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(998, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(125, 35)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "🔄 REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(882, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "🔒 CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnFormCancel
        '
        Me.btnFormCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFormCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormCancel.FlatAppearance.BorderSize = 0
        Me.btnFormCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFormCancel.ForeColor = System.Drawing.Color.White
        Me.btnFormCancel.Location = New System.Drawing.Point(762, 10)
        Me.btnFormCancel.Name = "btnFormCancel"
        Me.btnFormCancel.Size = New System.Drawing.Size(114, 35)
        Me.btnFormCancel.TabIndex = 4
        Me.btnFormCancel.Text = "❌ CANCEL"
        Me.btnFormCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(668, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 35)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "💾 SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(552, 10)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 35)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "🗑️ DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(456, 10)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 35)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "✏️ EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(350, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 35)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "➕ ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'FrmPaymentCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1533, 828)
        Me.Controls.Add(Me.grpPendingContainer)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.grpPaymentCollection)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FrmPaymentCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "💰 Payment Collection "
        Me.grpPaymentCollection.ResumeLayout(False)
        Me.tabPaymentInfo.ResumeLayout(False)
        Me.tabCollectionInfo.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvCollectionBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalDue.ResumeLayout(False)
        Me.pnlTotalDue.PerformLayout()
        Me.tabPaymentDetails.ResumeLayout(False)
        Me.grpPendingContainer.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpOfficeAck.ResumeLayout(False)
        CType(Me.dgvOfficeAck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBankRecon.ResumeLayout(False)
        CType(Me.dgvBankRecon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPaymentCollection As GroupBox
    Friend WithEvents grpPendingContainer As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpOfficeAck As GroupBox
    Friend WithEvents grpBankRecon As GroupBox
    Friend WithEvents pnlPendingSummary As Panel
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblQuickSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents btnGo As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalRecords As Label
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents colSNo As DataGridViewTextBoxColumn
    Friend WithEvents colVNo As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colAccount As DataGridViewTextBoxColumn
    Friend WithEvents colRefNo As DataGridViewTextBoxColumn
    Friend WithEvents colEmployee As DataGridViewTextBoxColumn
    Friend WithEvents colAck1 As DataGridViewTextBoxColumn
    Friend WithEvents colAck2 As DataGridViewTextBoxColumn
    Friend WithEvents colActions As DataGridViewButtonColumn
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnFormCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvOfficeAck As DataGridView
    Friend WithEvents colAckName As DataGridViewTextBoxColumn
    Friend WithEvents colAckDate As DataGridViewTextBoxColumn
    Friend WithEvents colAckAmount As DataGridViewTextBoxColumn
    Friend WithEvents colAckRef As DataGridViewTextBoxColumn
    Friend WithEvents dgvBankRecon As DataGridView
    Friend WithEvents colReconDesc As DataGridViewTextBoxColumn
    Friend WithEvents colReconDate As DataGridViewTextBoxColumn
    Friend WithEvents colReconAmount As DataGridViewTextBoxColumn
    Friend WithEvents colReconParty As DataGridViewTextBoxColumn
    Friend WithEvents tabPaymentInfo As TabControl
    Friend WithEvents tabCollectionInfo As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblCustomer As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblEmployee As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents dgvCollectionBills As DataGridView
    Friend WithEvents colBillNo As DataGridViewTextBoxColumn
    Friend WithEvents colBillDate As DataGridViewTextBoxColumn
    Friend WithEvents colBillAmount As DataGridViewTextBoxColumn
    Friend WithEvents colPaidAmount As DataGridViewTextBoxColumn
    Friend WithEvents colDueAmount As DataGridViewTextBoxColumn
    Friend WithEvents colSelect As DataGridViewCheckBoxColumn
    Friend WithEvents pnlTotalDue As Panel
    Friend WithEvents lblTotalDueValue As Label
    Friend WithEvents lblTotalDueText As Label
    Friend WithEvents tabPaymentDetails As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class

'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
'Partial Class FrmPaymentCollection
'    Inherits System.Windows.Forms.Form

'    Private components As System.ComponentModel.IContainer

'    <System.Diagnostics.DebuggerNonUserCode()>
'    Protected Overrides Sub Dispose(disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'#Region "Windows Form Designer generated code"

'    <System.Diagnostics.DebuggerStepThrough()>
'    Private Sub InitializeComponent()
'        Me.grpPaymentCollection = New System.Windows.Forms.GroupBox()
'        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
'        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
'        Me.lblDate = New System.Windows.Forms.Label()
'        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
'        Me.lblCustomer = New System.Windows.Forms.Label()
'        Me.TextBox1 = New System.Windows.Forms.TextBox()
'        Me.lblEmployee = New System.Windows.Forms.Label()
'        Me.TextBox2 = New System.Windows.Forms.TextBox()
'        Me.lblAddress = New System.Windows.Forms.Label()
'        Me.txtAddress = New System.Windows.Forms.TextBox()
'        Me.lblEmail = New System.Windows.Forms.Label()
'        Me.txtEmail = New System.Windows.Forms.TextBox()
'        Me.lblPhone = New System.Windows.Forms.Label()
'        Me.txtPhone = New System.Windows.Forms.TextBox()
'        Me.dgvCollectionBills = New System.Windows.Forms.DataGridView()
'        Me.colBillNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.colBillDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.colBillAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.colPaidAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.colDueAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
'        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
'        Me.pnlTotalDue = New System.Windows.Forms.Panel()
'        Me.lblTotalDueText = New System.Windows.Forms.Label()
'        Me.lblTotalDueValue = New System.Windows.Forms.Label()
'        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
'        Me.lblAmount = New System.Windows.Forms.Label()
'        Me.txtAmount = New System.Windows.Forms.TextBox()
'        Me.lblAccount = New System.Windows.Forms.Label()
'        Me.cmbAccount = New System.Windows.Forms.ComboBox()
'        Me.lblReferenceNo = New System.Windows.Forms.Label()
'        Me.txtReferenceNo = New System.Windows.Forms.TextBox()
'        Me.lblNarration = New System.Windows.Forms.Label()
'        Me.txtNarration = New System.Windows.Forms.TextBox()
'        Me.lblAttachment = New System.Windows.Forms.Label()
'        Me.txtAttachment = New System.Windows.Forms.TextBox()
'        Me.btnBrowse = New System.Windows.Forms.Button()
'        Me.grpPaymentCollection.SuspendLayout()
'        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SplitContainer2.Panel1.SuspendLayout()
'        Me.SplitContainer2.Panel2.SuspendLayout()
'        Me.SplitContainer2.SuspendLayout()
'        Me.TableLayoutPanel1.SuspendLayout()
'        CType(Me.dgvCollectionBills, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.pnlTotalDue.SuspendLayout()
'        Me.TableLayoutPanel2.SuspendLayout()
'        Me.SuspendLayout()
'        '
'        'grpPaymentCollection
'        '
'        Me.grpPaymentCollection.Controls.Add(Me.TableLayoutPanel2)
'        Me.grpPaymentCollection.Controls.Add(Me.SplitContainer2)
'        Me.grpPaymentCollection.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
'        Me.grpPaymentCollection.Location = New System.Drawing.Point(10, 10)
'        Me.grpPaymentCollection.Name = "grpPaymentCollection"
'        Me.grpPaymentCollection.Size = New System.Drawing.Size(1460, 300)
'        Me.grpPaymentCollection.TabIndex = 0
'        Me.grpPaymentCollection.TabStop = False
'        Me.grpPaymentCollection.Text = "💰 PAYMENT COLLECTION"
'        '
'        'SplitContainer2
'        '
'        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Top
'        Me.SplitContainer2.Location = New System.Drawing.Point(3, 32)
'        Me.SplitContainer2.Name = "SplitContainer2"
'        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
'        '
'        'SplitContainer2.Panel1
'        '
'        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
'        '
'        'SplitContainer2.Panel2
'        '
'        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvCollectionBills)
'        Me.SplitContainer2.Panel2.Controls.Add(Me.pnlTotalDue)
'        Me.SplitContainer2.Size = New System.Drawing.Size(1454, 200)
'        Me.SplitContainer2.TabIndex = 0
'        '
'        'TableLayoutPanel1
'        '
'        Me.TableLayoutPanel1.ColumnCount = 4
'        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel1.Controls.Add(Me.lblDate, 0, 0)
'        Me.TableLayoutPanel1.Controls.Add(Me.dtpDate, 1, 0)
'        Me.TableLayoutPanel1.Controls.Add(Me.lblCustomer, 0, 1)
'        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 1)
'        Me.TableLayoutPanel1.Controls.Add(Me.lblEmployee, 0, 2)
'        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 2)
'        Me.TableLayoutPanel1.Controls.Add(Me.lblAddress, 2, 0)
'        Me.TableLayoutPanel1.Controls.Add(Me.txtAddress, 3, 0)
'        Me.TableLayoutPanel1.Controls.Add(Me.lblEmail, 2, 1)
'        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 3, 1)
'        Me.TableLayoutPanel1.Controls.Add(Me.lblPhone, 2, 2)
'        Me.TableLayoutPanel1.Controls.Add(Me.txtPhone, 3, 2)
'        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
'        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
'        Me.TableLayoutPanel1.RowCount = 3
'        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1454, 50)
'        Me.TableLayoutPanel1.TabIndex = 0
'        '
'        'lblDate
'        '
'        Me.lblDate.Location = New System.Drawing.Point(3, 0)
'        Me.lblDate.Name = "lblDate"
'        Me.lblDate.Size = New System.Drawing.Size(14, 20)
'        Me.lblDate.TabIndex = 0
'        Me.lblDate.Text = "Date"
'        '
'        'dtpDate
'        '
'        Me.dtpDate.Location = New System.Drawing.Point(23, 3)
'        Me.dtpDate.Name = "dtpDate"
'        Me.dtpDate.Size = New System.Drawing.Size(14, 36)
'        Me.dtpDate.TabIndex = 1
'        '
'        'lblCustomer
'        '
'        Me.lblCustomer.Location = New System.Drawing.Point(3, 20)
'        Me.lblCustomer.Name = "lblCustomer"
'        Me.lblCustomer.Size = New System.Drawing.Size(14, 20)
'        Me.lblCustomer.TabIndex = 2
'        Me.lblCustomer.Text = "Customer"
'        '
'        'TextBox1
'        '
'        Me.TextBox1.Location = New System.Drawing.Point(23, 23)
'        Me.TextBox1.Name = "TextBox1"
'        Me.TextBox1.Size = New System.Drawing.Size(14, 36)
'        Me.TextBox1.TabIndex = 3
'        '
'        'lblEmployee
'        '
'        Me.lblEmployee.Location = New System.Drawing.Point(3, 40)
'        Me.lblEmployee.Name = "lblEmployee"
'        Me.lblEmployee.Size = New System.Drawing.Size(14, 20)
'        Me.lblEmployee.TabIndex = 4
'        Me.lblEmployee.Text = "Employee"
'        '
'        'TextBox2
'        '
'        Me.TextBox2.Location = New System.Drawing.Point(23, 43)
'        Me.TextBox2.Name = "TextBox2"
'        Me.TextBox2.Size = New System.Drawing.Size(14, 36)
'        Me.TextBox2.TabIndex = 5
'        '
'        'lblAddress
'        '
'        Me.lblAddress.Location = New System.Drawing.Point(43, 0)
'        Me.lblAddress.Name = "lblAddress"
'        Me.lblAddress.Size = New System.Drawing.Size(14, 20)
'        Me.lblAddress.TabIndex = 6
'        Me.lblAddress.Text = "Address"
'        '
'        'txtAddress
'        '
'        Me.txtAddress.Location = New System.Drawing.Point(63, 3)
'        Me.txtAddress.Name = "txtAddress"
'        Me.txtAddress.Size = New System.Drawing.Size(100, 36)
'        Me.txtAddress.TabIndex = 7
'        '
'        'lblEmail
'        '
'        Me.lblEmail.Location = New System.Drawing.Point(43, 20)
'        Me.lblEmail.Name = "lblEmail"
'        Me.lblEmail.Size = New System.Drawing.Size(14, 20)
'        Me.lblEmail.TabIndex = 8
'        Me.lblEmail.Text = "Email"
'        '
'        'txtEmail
'        '
'        Me.txtEmail.Location = New System.Drawing.Point(63, 23)
'        Me.txtEmail.Name = "txtEmail"
'        Me.txtEmail.Size = New System.Drawing.Size(100, 36)
'        Me.txtEmail.TabIndex = 9
'        '
'        'lblPhone
'        '
'        Me.lblPhone.Location = New System.Drawing.Point(43, 40)
'        Me.lblPhone.Name = "lblPhone"
'        Me.lblPhone.Size = New System.Drawing.Size(14, 20)
'        Me.lblPhone.TabIndex = 10
'        Me.lblPhone.Text = "Phone"
'        '
'        'txtPhone
'        '
'        Me.txtPhone.Location = New System.Drawing.Point(63, 43)
'        Me.txtPhone.Name = "txtPhone"
'        Me.txtPhone.Size = New System.Drawing.Size(100, 36)
'        Me.txtPhone.TabIndex = 11
'        '
'        'dgvCollectionBills
'        '
'        Me.dgvCollectionBills.BackgroundColor = System.Drawing.Color.White
'        Me.dgvCollectionBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBillNo, Me.colBillDate, Me.colBillAmount, Me.colPaidAmount, Me.colDueAmount, Me.colSelect})
'        Me.dgvCollectionBills.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.dgvCollectionBills.Location = New System.Drawing.Point(0, 0)
'        Me.dgvCollectionBills.Name = "dgvCollectionBills"
'        Me.dgvCollectionBills.RowHeadersVisible = False
'        Me.dgvCollectionBills.Size = New System.Drawing.Size(1454, 121)
'        Me.dgvCollectionBills.TabIndex = 0
'        '
'        'colBillNo
'        '
'        Me.colBillNo.HeaderText = "Bill No"
'        Me.colBillNo.Name = "colBillNo"
'        '
'        'colBillDate
'        '
'        Me.colBillDate.HeaderText = "Bill Date"
'        Me.colBillDate.Name = "colBillDate"
'        '
'        'colBillAmount
'        '
'        Me.colBillAmount.HeaderText = "Bill Amount"
'        Me.colBillAmount.Name = "colBillAmount"
'        '
'        'colPaidAmount
'        '
'        Me.colPaidAmount.HeaderText = "Paid Amount"
'        Me.colPaidAmount.Name = "colPaidAmount"
'        '
'        'colDueAmount
'        '
'        Me.colDueAmount.HeaderText = "Due Amount"
'        Me.colDueAmount.Name = "colDueAmount"
'        '
'        'colSelect
'        '
'        Me.colSelect.HeaderText = "Select"
'        Me.colSelect.Name = "colSelect"
'        '
'        'pnlTotalDue
'        '
'        Me.pnlTotalDue.Controls.Add(Me.lblTotalDueText)
'        Me.pnlTotalDue.Controls.Add(Me.lblTotalDueValue)
'        Me.pnlTotalDue.Dock = System.Windows.Forms.DockStyle.Bottom
'        Me.pnlTotalDue.Location = New System.Drawing.Point(0, 121)
'        Me.pnlTotalDue.Name = "pnlTotalDue"
'        Me.pnlTotalDue.Size = New System.Drawing.Size(1454, 25)
'        Me.pnlTotalDue.TabIndex = 1
'        '
'        'lblTotalDueText
'        '
'        Me.lblTotalDueText.Location = New System.Drawing.Point(1150, 2)
'        Me.lblTotalDueText.Name = "lblTotalDueText"
'        Me.lblTotalDueText.Size = New System.Drawing.Size(100, 23)
'        Me.lblTotalDueText.TabIndex = 0
'        Me.lblTotalDueText.Text = "Total Due:"
'        '
'        'lblTotalDueValue
'        '
'        Me.lblTotalDueValue.ForeColor = System.Drawing.Color.Red
'        Me.lblTotalDueValue.Location = New System.Drawing.Point(1240, 2)
'        Me.lblTotalDueValue.Name = "lblTotalDueValue"
'        Me.lblTotalDueValue.Size = New System.Drawing.Size(100, 23)
'        Me.lblTotalDueValue.TabIndex = 1
'        Me.lblTotalDueValue.Text = "₹ 0.00"
'        '
'        'TableLayoutPanel2
'        '
'        Me.TableLayoutPanel2.ColumnCount = 4
'        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel2.Controls.Add(Me.lblAmount, 0, 0)
'        Me.TableLayoutPanel2.Controls.Add(Me.txtAmount, 1, 0)
'        Me.TableLayoutPanel2.Controls.Add(Me.lblAccount, 2, 0)
'        Me.TableLayoutPanel2.Controls.Add(Me.cmbAccount, 3, 0)
'        Me.TableLayoutPanel2.Controls.Add(Me.lblReferenceNo, 0, 1)
'        Me.TableLayoutPanel2.Controls.Add(Me.txtReferenceNo, 1, 1)
'        Me.TableLayoutPanel2.Controls.Add(Me.lblNarration, 2, 1)
'        Me.TableLayoutPanel2.Controls.Add(Me.txtNarration, 3, 1)
'        Me.TableLayoutPanel2.Controls.Add(Me.lblAttachment, 0, 2)
'        Me.TableLayoutPanel2.Controls.Add(Me.txtAttachment, 1, 2)
'        Me.TableLayoutPanel2.Controls.Add(Me.btnBrowse, 2, 2)
'        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
'        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 197)
'        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
'        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
'        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1454, 100)
'        Me.TableLayoutPanel2.TabIndex = 1
'        '
'        'lblAmount
'        '
'        Me.lblAmount.Location = New System.Drawing.Point(3, 0)
'        Me.lblAmount.Name = "lblAmount"
'        Me.lblAmount.Size = New System.Drawing.Size(14, 20)
'        Me.lblAmount.TabIndex = 0
'        Me.lblAmount.Text = "Amount"
'        '
'        'txtAmount
'        '
'        Me.txtAmount.Location = New System.Drawing.Point(23, 3)
'        Me.txtAmount.Name = "txtAmount"
'        Me.txtAmount.Size = New System.Drawing.Size(14, 36)
'        Me.txtAmount.TabIndex = 1
'        '
'        'lblAccount
'        '
'        Me.lblAccount.Location = New System.Drawing.Point(43, 0)
'        Me.lblAccount.Name = "lblAccount"
'        Me.lblAccount.Size = New System.Drawing.Size(14, 20)
'        Me.lblAccount.TabIndex = 2
'        Me.lblAccount.Text = "Account"
'        '
'        'cmbAccount
'        '
'        Me.cmbAccount.Items.AddRange(New Object() {"CASH", "BANK", "UPI", "CHEQUE"})
'        Me.cmbAccount.Location = New System.Drawing.Point(63, 3)
'        Me.cmbAccount.Name = "cmbAccount"
'        Me.cmbAccount.Size = New System.Drawing.Size(121, 38)
'        Me.cmbAccount.TabIndex = 3
'        '
'        'lblReferenceNo
'        '
'        Me.lblReferenceNo.Location = New System.Drawing.Point(3, 20)
'        Me.lblReferenceNo.Name = "lblReferenceNo"
'        Me.lblReferenceNo.Size = New System.Drawing.Size(14, 20)
'        Me.lblReferenceNo.TabIndex = 4
'        Me.lblReferenceNo.Text = "Reference No"
'        '
'        'txtReferenceNo
'        '
'        Me.txtReferenceNo.Location = New System.Drawing.Point(23, 23)
'        Me.txtReferenceNo.Name = "txtReferenceNo"
'        Me.txtReferenceNo.Size = New System.Drawing.Size(14, 36)
'        Me.txtReferenceNo.TabIndex = 5
'        '
'        'lblNarration
'        '
'        Me.lblNarration.Location = New System.Drawing.Point(43, 20)
'        Me.lblNarration.Name = "lblNarration"
'        Me.lblNarration.Size = New System.Drawing.Size(14, 20)
'        Me.lblNarration.TabIndex = 6
'        Me.lblNarration.Text = "Narration"
'        '
'        'txtNarration
'        '
'        Me.txtNarration.Location = New System.Drawing.Point(63, 23)
'        Me.txtNarration.Name = "txtNarration"
'        Me.txtNarration.Size = New System.Drawing.Size(100, 36)
'        Me.txtNarration.TabIndex = 7
'        '
'        'lblAttachment
'        '
'        Me.lblAttachment.Location = New System.Drawing.Point(3, 40)
'        Me.lblAttachment.Name = "lblAttachment"
'        Me.lblAttachment.Size = New System.Drawing.Size(14, 23)
'        Me.lblAttachment.TabIndex = 8
'        Me.lblAttachment.Text = "Attachment"
'        '
'        'txtAttachment
'        '
'        Me.txtAttachment.Location = New System.Drawing.Point(23, 43)
'        Me.txtAttachment.Name = "txtAttachment"
'        Me.txtAttachment.Size = New System.Drawing.Size(14, 36)
'        Me.txtAttachment.TabIndex = 9
'        '
'        'btnBrowse
'        '
'        Me.btnBrowse.Location = New System.Drawing.Point(43, 43)
'        Me.btnBrowse.Name = "btnBrowse"
'        Me.btnBrowse.Size = New System.Drawing.Size(14, 23)
'        Me.btnBrowse.TabIndex = 10
'        Me.btnBrowse.Text = "Browse..."
'        '
'        'FrmPaymentCollection
'        '
'        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
'        Me.ClientSize = New System.Drawing.Size(1482, 603)
'        Me.Controls.Add(Me.grpPaymentCollection)
'        Me.Name = "FrmPaymentCollection"
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'        Me.Text = "💰 Payment Collection"
'        Me.grpPaymentCollection.ResumeLayout(False)
'        Me.SplitContainer2.Panel1.ResumeLayout(False)
'        Me.SplitContainer2.Panel2.ResumeLayout(False)
'        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.SplitContainer2.ResumeLayout(False)
'        Me.TableLayoutPanel1.ResumeLayout(False)
'        Me.TableLayoutPanel1.PerformLayout()
'        CType(Me.dgvCollectionBills, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.pnlTotalDue.ResumeLayout(False)
'        Me.TableLayoutPanel2.ResumeLayout(False)
'        Me.TableLayoutPanel2.PerformLayout()
'        Me.ResumeLayout(False)

'    End Sub

'#End Region

'    Friend WithEvents grpPaymentCollection As GroupBox
'    Friend WithEvents SplitContainer2 As SplitContainer
'    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
'    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel

'    Friend WithEvents lblDate As Label
'    Friend WithEvents dtpDate As DateTimePicker

'    Friend WithEvents lblCustomer As Label
'    Friend WithEvents TextBox1 As TextBox

'    Friend WithEvents lblEmployee As Label
'    Friend WithEvents TextBox2 As TextBox

'    Friend WithEvents lblAddress As Label
'    Friend WithEvents txtAddress As TextBox

'    Friend WithEvents lblEmail As Label
'    Friend WithEvents txtEmail As TextBox

'    Friend WithEvents lblPhone As Label
'    Friend WithEvents txtPhone As TextBox

'    Friend WithEvents dgvCollectionBills As DataGridView

'    Friend WithEvents colBillNo As DataGridViewTextBoxColumn
'    Friend WithEvents colBillDate As DataGridViewTextBoxColumn
'    Friend WithEvents colBillAmount As DataGridViewTextBoxColumn
'    Friend WithEvents colPaidAmount As DataGridViewTextBoxColumn
'    Friend WithEvents colDueAmount As DataGridViewTextBoxColumn
'    Friend WithEvents colSelect As DataGridViewCheckBoxColumn

'    Friend WithEvents pnlTotalDue As Panel
'    Friend WithEvents lblTotalDueText As Label
'    Friend WithEvents lblTotalDueValue As Label

'    Friend WithEvents lblAmount As Label
'    Friend WithEvents txtAmount As TextBox
'    Friend WithEvents lblAccount As Label
'    Friend WithEvents cmbAccount As ComboBox
'    Friend WithEvents lblReferenceNo As Label
'    Friend WithEvents txtReferenceNo As TextBox
'    Friend WithEvents lblNarration As Label
'    Friend WithEvents txtNarration As TextBox
'    Friend WithEvents lblAttachment As Label
'    Friend WithEvents txtAttachment As TextBox
'    Friend WithEvents btnBrowse As Button

'End Class