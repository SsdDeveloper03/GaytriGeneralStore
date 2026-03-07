<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBillingEntry
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
        Me.pnlPagination = New System.Windows.Forms.Panel()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.pnlBillingInfo = New System.Windows.Forms.Panel()
        Me.grpBillingInfo = New System.Windows.Forms.GroupBox()
        Me.tlpBillingLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.grpBillInfo = New System.Windows.Forms.GroupBox()
        Me.tlpBillInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSeries = New System.Windows.Forms.Label()
        Me.cmbSeries = New System.Windows.Forms.ComboBox()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.lblBillDate = New System.Windows.Forms.Label()
        Me.lblBillNumber = New System.Windows.Forms.Label()
        Me.txtBillNumber = New System.Windows.Forms.TextBox()
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.tlpCustomerDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblAdd1 = New System.Windows.Forms.Label()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.lblAdd2 = New System.Windows.Forms.Label()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.lblPincode = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.lblAreaCity = New System.Windows.Forms.Label()
        Me.txtAreaCity = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.grpCustomerSelect = New System.Windows.Forms.GroupBox()
        Me.tlpCustomerSelect = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCustomerCode = New System.Windows.Forms.Label()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.lblCollectionPerson = New System.Windows.Forms.Label()
        Me.cmbCollectionPerson = New System.Windows.Forms.ComboBox()
        Me.grpAmountDetails = New System.Windows.Forms.GroupBox()
        Me.tlpAmountDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBillAmount = New System.Windows.Forms.Label()
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.lblReceivedAmount = New System.Windows.Forms.Label()
        Me.txtReceivedAmount = New System.Windows.Forms.TextBox()
        Me.lblSalesDueDate = New System.Windows.Forms.Label()
        Me.dtpSalesDueDate = New System.Windows.Forms.DateTimePicker()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnlPagination.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlBillingInfo.SuspendLayout()
        Me.grpBillingInfo.SuspendLayout()
        Me.tlpBillingLayout.SuspendLayout()
        Me.grpBillInfo.SuspendLayout()
        Me.tlpBillInfo.SuspendLayout()
        Me.grpCustomerDetails.SuspendLayout()
        Me.tlpCustomerDetails.SuspendLayout()
        Me.grpCustomerSelect.SuspendLayout()
        Me.tlpCustomerSelect.SuspendLayout()
        Me.grpAmountDetails.SuspendLayout()
        Me.tlpAmountDetails.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPagination
        '
        Me.pnlPagination.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlPagination.Controls.Add(Me.btn_Refresh)
        Me.pnlPagination.Controls.Add(Me.btn_Close)
        Me.pnlPagination.Controls.Add(Me.btn_Cancel)
        Me.pnlPagination.Controls.Add(Me.btn_save)
        Me.pnlPagination.Controls.Add(Me.btn_Delete)
        Me.pnlPagination.Controls.Add(Me.btn_Add)
        Me.pnlPagination.Controls.Add(Me.btn_Edit)
        Me.pnlPagination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPagination.Location = New System.Drawing.Point(6, 626)
        Me.pnlPagination.Name = "pnlPagination"
        Me.pnlPagination.Size = New System.Drawing.Size(1413, 47)
        Me.pnlPagination.TabIndex = 4
        '
        'btn_Refresh
        '
        Me.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Refresh.FlatAppearance.BorderSize = 0
        Me.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Refresh.ForeColor = System.Drawing.Color.White
        Me.btn_Refresh.Location = New System.Drawing.Point(1004, 10)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(112, 35)
        Me.btn_Refresh.TabIndex = 6
        Me.btn_Refresh.Text = "🔄 REFRESH"
        Me.btn_Refresh.UseVisualStyleBackColor = False
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Close.ForeColor = System.Drawing.Color.White
        Me.btn_Close.Location = New System.Drawing.Point(908, 10)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(90, 35)
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "🚪 CLOSE"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(810, 10)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 35)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "✘ CANCEL"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(717, 10)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(87, 35)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "💾 SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.FlatAppearance.BorderSize = 0
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Delete.ForeColor = System.Drawing.Color.White
        Me.btn_Delete.Location = New System.Drawing.Point(615, 10)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(98, 35)
        Me.btn_Delete.TabIndex = 2
        Me.btn_Delete.Text = "🗑️ DELETE"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add.FlatAppearance.BorderSize = 0
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Add.ForeColor = System.Drawing.Color.White
        Me.btn_Add.Location = New System.Drawing.Point(407, 10)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(85, 35)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "➕ ADD"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Edit.ForeColor = System.Drawing.Color.White
        Me.btn_Edit.Location = New System.Drawing.Point(498, 10)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(111, 35)
        Me.btn_Edit.TabIndex = 1
        Me.btn_Edit.Text = "✏️ EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(6, 319)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(1413, 34)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "💰 BILL MASTER"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.lblFrom)
        Me.pnlSearch.Controls.Add(Me.dtpFrom)
        Me.pnlSearch.Controls.Add(Me.lblTo)
        Me.pnlSearch.Controls.Add(Me.dtpTo)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSearch.Location = New System.Drawing.Point(6, 275)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1413, 41)
        Me.pnlSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(10, 12)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(99, 15)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "🔍 Quick Search:"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(116, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(391, 23)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(920, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "🔍GO"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(520, 12)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(39, 15)
        Me.lblFrom.TabIndex = 3
        Me.lblFrom.Text = "From:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(570, 9)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(100, 23)
        Me.dtpFrom.TabIndex = 4
        Me.dtpFrom.Value = New Date(2026, 3, 1, 0, 0, 0, 0)
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTo.Location = New System.Drawing.Point(690, 12)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 15)
        Me.lblTo.TabIndex = 5
        Me.lblTo.Text = "To:"
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(720, 9)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(100, 23)
        Me.dtpTo.TabIndex = 6
        Me.dtpTo.Value = New Date(2026, 3, 31, 0, 0, 0, 0)
        '
        'pnlBillingInfo
        '
        Me.pnlBillingInfo.BackColor = System.Drawing.Color.White
        Me.pnlBillingInfo.Controls.Add(Me.grpBillingInfo)
        Me.pnlBillingInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBillingInfo.Location = New System.Drawing.Point(6, 6)
        Me.pnlBillingInfo.Name = "pnlBillingInfo"
        Me.pnlBillingInfo.Size = New System.Drawing.Size(1413, 263)
        Me.pnlBillingInfo.TabIndex = 0
        '
        'grpBillingInfo
        '
        Me.grpBillingInfo.BackColor = System.Drawing.Color.White
        Me.grpBillingInfo.Controls.Add(Me.tlpBillingLayout)
        Me.grpBillingInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBillingInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpBillingInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grpBillingInfo.Location = New System.Drawing.Point(0, 0)
        Me.grpBillingInfo.Name = "grpBillingInfo"
        Me.grpBillingInfo.Size = New System.Drawing.Size(1413, 263)
        Me.grpBillingInfo.TabIndex = 0
        Me.grpBillingInfo.TabStop = False
        Me.grpBillingInfo.Text = "💰 BILLING INFORMATION"
        '
        'tlpBillingLayout
        '
        Me.tlpBillingLayout.ColumnCount = 2
        Me.tlpBillingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.92182!))
        Me.tlpBillingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.07818!))
        Me.tlpBillingLayout.Controls.Add(Me.grpBillInfo, 0, 0)
        Me.tlpBillingLayout.Controls.Add(Me.grpCustomerDetails, 1, 0)
        Me.tlpBillingLayout.Controls.Add(Me.grpCustomerSelect, 0, 1)
        Me.tlpBillingLayout.Controls.Add(Me.grpAmountDetails, 1, 1)
        Me.tlpBillingLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBillingLayout.Location = New System.Drawing.Point(3, 21)
        Me.tlpBillingLayout.Name = "tlpBillingLayout"
        Me.tlpBillingLayout.RowCount = 2
        Me.tlpBillingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.91667!))
        Me.tlpBillingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.08333!))
        Me.tlpBillingLayout.Size = New System.Drawing.Size(1407, 239)
        Me.tlpBillingLayout.TabIndex = 0
        '
        'grpBillInfo
        '
        Me.grpBillInfo.Controls.Add(Me.tlpBillInfo)
        Me.grpBillInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBillInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpBillInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grpBillInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpBillInfo.Name = "grpBillInfo"
        Me.grpBillInfo.Size = New System.Drawing.Size(415, 132)
        Me.grpBillInfo.TabIndex = 0
        Me.grpBillInfo.TabStop = False
        Me.grpBillInfo.Text = "📋 BILL INFORMATION"
        '
        'tlpBillInfo
        '
        Me.tlpBillInfo.ColumnCount = 4
        Me.tlpBillInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.tlpBillInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.tlpBillInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.tlpBillInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317.0!))
        Me.tlpBillInfo.Controls.Add(Me.lblSeries, 0, 0)
        Me.tlpBillInfo.Controls.Add(Me.cmbSeries, 1, 0)
        Me.tlpBillInfo.Controls.Add(Me.lblBillNo, 2, 0)
        Me.tlpBillInfo.Controls.Add(Me.txtBillNo, 3, 0)
        Me.tlpBillInfo.Controls.Add(Me.lblBillDate, 0, 1)
        Me.tlpBillInfo.Controls.Add(Me.lblBillNumber, 2, 1)
        Me.tlpBillInfo.Controls.Add(Me.txtBillNumber, 3, 1)
        Me.tlpBillInfo.Controls.Add(Me.dtpBillDate, 1, 1)
        Me.tlpBillInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBillInfo.Location = New System.Drawing.Point(3, 19)
        Me.tlpBillInfo.Name = "tlpBillInfo"
        Me.tlpBillInfo.RowCount = 2
        Me.tlpBillInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpBillInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpBillInfo.Size = New System.Drawing.Size(409, 110)
        Me.tlpBillInfo.TabIndex = 0
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSeries.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblSeries.Location = New System.Drawing.Point(3, 0)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(72, 30)
        Me.lblSeries.TabIndex = 0
        Me.lblSeries.Text = "Series *"
        Me.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSeries
        '
        Me.cmbSeries.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeries.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbSeries.FormattingEnabled = True
        Me.cmbSeries.Items.AddRange(New Object() {"Select Series", "SERIES A", "SERIES B", "SERIES C"})
        Me.cmbSeries.Location = New System.Drawing.Point(81, 3)
        Me.cmbSeries.Name = "cmbSeries"
        Me.cmbSeries.Size = New System.Drawing.Size(100, 23)
        Me.cmbSeries.TabIndex = 1
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBillNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblBillNo.Location = New System.Drawing.Point(187, 0)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(97, 30)
        Me.lblBillNo.TabIndex = 2
        Me.lblBillNo.Text = "Bill No"
        Me.lblBillNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBillNo
        '
        Me.txtBillNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillNo.Location = New System.Drawing.Point(290, 3)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.ReadOnly = True
        Me.txtBillNo.Size = New System.Drawing.Size(50, 23)
        Me.txtBillNo.TabIndex = 3
        Me.txtBillNo.Text = "1"
        Me.txtBillNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBillDate
        '
        Me.lblBillDate.AutoSize = True
        Me.lblBillDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBillDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblBillDate.Location = New System.Drawing.Point(3, 30)
        Me.lblBillDate.Name = "lblBillDate"
        Me.lblBillDate.Size = New System.Drawing.Size(62, 80)
        Me.lblBillDate.TabIndex = 4
        Me.lblBillDate.Text = "Bill Date *"
        Me.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBillNumber
        '
        Me.lblBillNumber.AutoSize = True
        Me.lblBillNumber.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBillNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblBillNumber.Location = New System.Drawing.Point(187, 30)
        Me.lblBillNumber.Name = "lblBillNumber"
        Me.lblBillNumber.Size = New System.Drawing.Size(97, 15)
        Me.lblBillNumber.TabIndex = 6
        Me.lblBillNumber.Text = "Bill Number"
        Me.lblBillNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBillNumber
        '
        Me.txtBillNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtBillNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillNumber.Location = New System.Drawing.Point(290, 33)
        Me.txtBillNumber.Name = "txtBillNumber"
        Me.txtBillNumber.ReadOnly = True
        Me.txtBillNumber.Size = New System.Drawing.Size(111, 23)
        Me.txtBillNumber.TabIndex = 7
        Me.txtBillNumber.Text = "A252600001"
        Me.txtBillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpBillDate
        '
        Me.dtpBillDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBillDate.Location = New System.Drawing.Point(81, 33)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpBillDate.TabIndex = 5
        Me.dtpBillDate.Value = New Date(2026, 2, 28, 0, 0, 0, 0)
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.Controls.Add(Me.tlpCustomerDetails)
        Me.grpCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grpCustomerDetails.Location = New System.Drawing.Point(424, 3)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(980, 128)
        Me.grpCustomerDetails.TabIndex = 2
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "👤 CUSTOMER DETAILS"
        '
        'tlpCustomerDetails
        '
        Me.tlpCustomerDetails.ColumnCount = 4
        Me.tlpCustomerDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpCustomerDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpCustomerDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpCustomerDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 614.0!))
        Me.tlpCustomerDetails.Controls.Add(Me.lblName, 0, 0)
        Me.tlpCustomerDetails.Controls.Add(Me.txtName, 1, 0)
        Me.tlpCustomerDetails.Controls.Add(Me.lblMobile, 2, 0)
        Me.tlpCustomerDetails.Controls.Add(Me.lblAdd1, 0, 1)
        Me.tlpCustomerDetails.Controls.Add(Me.txtAdd1, 1, 1)
        Me.tlpCustomerDetails.Controls.Add(Me.lblAdd2, 2, 1)
        Me.tlpCustomerDetails.Controls.Add(Me.txtAdd2, 3, 1)
        Me.tlpCustomerDetails.Controls.Add(Me.lblPincode, 0, 2)
        Me.tlpCustomerDetails.Controls.Add(Me.txtPincode, 1, 2)
        Me.tlpCustomerDetails.Controls.Add(Me.lblAreaCity, 2, 2)
        Me.tlpCustomerDetails.Controls.Add(Me.txtAreaCity, 3, 2)
        Me.tlpCustomerDetails.Controls.Add(Me.lblState, 0, 3)
        Me.tlpCustomerDetails.Controls.Add(Me.txtState, 1, 3)
        Me.tlpCustomerDetails.Controls.Add(Me.lblCountry, 2, 3)
        Me.tlpCustomerDetails.Controls.Add(Me.txtCountry, 3, 3)
        Me.tlpCustomerDetails.Controls.Add(Me.txtMobile, 3, 0)
        Me.tlpCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCustomerDetails.Location = New System.Drawing.Point(3, 19)
        Me.tlpCustomerDetails.Name = "tlpCustomerDetails"
        Me.tlpCustomerDetails.RowCount = 4
        Me.tlpCustomerDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpCustomerDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpCustomerDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpCustomerDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpCustomerDetails.Size = New System.Drawing.Size(974, 106)
        Me.tlpCustomerDetails.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(3, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtName.Location = New System.Drawing.Point(83, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(194, 22)
        Me.txtName.TabIndex = 1
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMobile.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblMobile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblMobile.Location = New System.Drawing.Point(283, 0)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(74, 25)
        Me.lblMobile.TabIndex = 2
        Me.lblMobile.Text = "Mobile No:"
        Me.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdd1
        '
        Me.lblAdd1.AutoSize = True
        Me.lblAdd1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAdd1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdd1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblAdd1.Location = New System.Drawing.Point(3, 25)
        Me.lblAdd1.Name = "lblAdd1"
        Me.lblAdd1.Size = New System.Drawing.Size(74, 25)
        Me.lblAdd1.TabIndex = 4
        Me.lblAdd1.Text = "Add1:"
        Me.lblAdd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdd1
        '
        Me.txtAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdd1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdd1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtAdd1.Location = New System.Drawing.Point(83, 28)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(194, 22)
        Me.txtAdd1.TabIndex = 5
        '
        'lblAdd2
        '
        Me.lblAdd2.AutoSize = True
        Me.lblAdd2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAdd2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdd2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblAdd2.Location = New System.Drawing.Point(283, 25)
        Me.lblAdd2.Name = "lblAdd2"
        Me.lblAdd2.Size = New System.Drawing.Size(74, 25)
        Me.lblAdd2.TabIndex = 6
        Me.lblAdd2.Text = "Add2:"
        Me.lblAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdd2
        '
        Me.txtAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdd2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtAdd2.Location = New System.Drawing.Point(363, 28)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(223, 22)
        Me.txtAdd2.TabIndex = 7
        '
        'lblPincode
        '
        Me.lblPincode.AutoSize = True
        Me.lblPincode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPincode.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPincode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPincode.Location = New System.Drawing.Point(3, 50)
        Me.lblPincode.Name = "lblPincode"
        Me.lblPincode.Size = New System.Drawing.Size(74, 25)
        Me.lblPincode.TabIndex = 8
        Me.lblPincode.Text = "Pincode:"
        Me.lblPincode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPincode
        '
        Me.txtPincode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPincode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPincode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtPincode.Location = New System.Drawing.Point(83, 53)
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(194, 22)
        Me.txtPincode.TabIndex = 9
        '
        'lblAreaCity
        '
        Me.lblAreaCity.AutoSize = True
        Me.lblAreaCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAreaCity.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAreaCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblAreaCity.Location = New System.Drawing.Point(283, 50)
        Me.lblAreaCity.Name = "lblAreaCity"
        Me.lblAreaCity.Size = New System.Drawing.Size(74, 25)
        Me.lblAreaCity.TabIndex = 10
        Me.lblAreaCity.Text = "Area/City:"
        Me.lblAreaCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAreaCity
        '
        Me.txtAreaCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAreaCity.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtAreaCity.Location = New System.Drawing.Point(363, 53)
        Me.txtAreaCity.Name = "txtAreaCity"
        Me.txtAreaCity.Size = New System.Drawing.Size(306, 22)
        Me.txtAreaCity.TabIndex = 11
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblState.Location = New System.Drawing.Point(3, 75)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(74, 31)
        Me.lblState.TabIndex = 12
        Me.lblState.Text = "State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtState.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtState.Location = New System.Drawing.Point(83, 78)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(194, 22)
        Me.txtState.TabIndex = 13
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCountry.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblCountry.Location = New System.Drawing.Point(283, 75)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(74, 31)
        Me.lblCountry.TabIndex = 14
        Me.lblCountry.Text = "Country:"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCountry
        '
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtCountry.Location = New System.Drawing.Point(363, 78)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(207, 22)
        Me.txtCountry.TabIndex = 15
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtMobile.Location = New System.Drawing.Point(363, 3)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(170, 22)
        Me.txtMobile.TabIndex = 3
        '
        'grpCustomerSelect
        '
        Me.grpCustomerSelect.Controls.Add(Me.tlpCustomerSelect)
        Me.grpCustomerSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCustomerSelect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpCustomerSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grpCustomerSelect.Location = New System.Drawing.Point(3, 141)
        Me.grpCustomerSelect.Name = "grpCustomerSelect"
        Me.grpCustomerSelect.Size = New System.Drawing.Size(415, 95)
        Me.grpCustomerSelect.TabIndex = 1
        Me.grpCustomerSelect.TabStop = False
        Me.grpCustomerSelect.Text = "👤 CUSTOMER SELECTION"
        '
        'tlpCustomerSelect
        '
        Me.tlpCustomerSelect.ColumnCount = 2
        Me.tlpCustomerSelect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpCustomerSelect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269.0!))
        Me.tlpCustomerSelect.Controls.Add(Me.lblCustomerCode, 0, 0)
        Me.tlpCustomerSelect.Controls.Add(Me.txtCustomerCode, 1, 0)
        Me.tlpCustomerSelect.Controls.Add(Me.lblCollectionPerson, 0, 1)
        Me.tlpCustomerSelect.Controls.Add(Me.cmbCollectionPerson, 1, 1)
        Me.tlpCustomerSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCustomerSelect.Location = New System.Drawing.Point(3, 19)
        Me.tlpCustomerSelect.Name = "tlpCustomerSelect"
        Me.tlpCustomerSelect.RowCount = 2
        Me.tlpCustomerSelect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCustomerSelect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpCustomerSelect.Size = New System.Drawing.Size(409, 73)
        Me.tlpCustomerSelect.TabIndex = 0
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.AutoSize = True
        Me.lblCustomerCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCustomerCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblCustomerCode.Location = New System.Drawing.Point(3, 0)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(134, 30)
        Me.lblCustomerCode.TabIndex = 0
        Me.lblCustomerCode.Text = "Customer Code:"
        Me.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomerCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomerCode.Location = New System.Drawing.Point(143, 3)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.Size = New System.Drawing.Size(263, 23)
        Me.txtCustomerCode.TabIndex = 1
        '
        'lblCollectionPerson
        '
        Me.lblCollectionPerson.AutoSize = True
        Me.lblCollectionPerson.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCollectionPerson.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCollectionPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblCollectionPerson.Location = New System.Drawing.Point(3, 30)
        Me.lblCollectionPerson.Name = "lblCollectionPerson"
        Me.lblCollectionPerson.Size = New System.Drawing.Size(134, 15)
        Me.lblCollectionPerson.TabIndex = 2
        Me.lblCollectionPerson.Text = "Collection Person:"
        Me.lblCollectionPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCollectionPerson
        '
        Me.cmbCollectionPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCollectionPerson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbCollectionPerson.FormattingEnabled = True
        Me.cmbCollectionPerson.Items.AddRange(New Object() {"-", "John Doe", "Jane Smith", "Mike Johnson", "Sarah Williams"})
        Me.cmbCollectionPerson.Location = New System.Drawing.Point(143, 33)
        Me.cmbCollectionPerson.Name = "cmbCollectionPerson"
        Me.cmbCollectionPerson.Size = New System.Drawing.Size(263, 23)
        Me.cmbCollectionPerson.TabIndex = 3
        '
        'grpAmountDetails
        '
        Me.grpAmountDetails.Controls.Add(Me.tlpAmountDetails)
        Me.grpAmountDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpAmountDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpAmountDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.grpAmountDetails.Location = New System.Drawing.Point(424, 141)
        Me.grpAmountDetails.Name = "grpAmountDetails"
        Me.grpAmountDetails.Size = New System.Drawing.Size(980, 95)
        Me.grpAmountDetails.TabIndex = 3
        Me.grpAmountDetails.TabStop = False
        Me.grpAmountDetails.Text = "💰 AMOUNT DETAILS"
        '
        'tlpAmountDetails
        '
        Me.tlpAmountDetails.ColumnCount = 4
        Me.tlpAmountDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tlpAmountDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.tlpAmountDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tlpAmountDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 626.0!))
        Me.tlpAmountDetails.Controls.Add(Me.lblBillAmount, 0, 0)
        Me.tlpAmountDetails.Controls.Add(Me.txtBillAmount, 1, 0)
        Me.tlpAmountDetails.Controls.Add(Me.lblReceivedAmount, 2, 0)
        Me.tlpAmountDetails.Controls.Add(Me.txtReceivedAmount, 3, 0)
        Me.tlpAmountDetails.Controls.Add(Me.lblSalesDueDate, 0, 1)
        Me.tlpAmountDetails.Controls.Add(Me.dtpSalesDueDate, 1, 1)
        Me.tlpAmountDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAmountDetails.Location = New System.Drawing.Point(3, 19)
        Me.tlpAmountDetails.Name = "tlpAmountDetails"
        Me.tlpAmountDetails.RowCount = 2
        Me.tlpAmountDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpAmountDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlpAmountDetails.Size = New System.Drawing.Size(974, 73)
        Me.tlpAmountDetails.TabIndex = 0
        '
        'lblBillAmount
        '
        Me.lblBillAmount.AutoSize = True
        Me.lblBillAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBillAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblBillAmount.Location = New System.Drawing.Point(3, 0)
        Me.lblBillAmount.Name = "lblBillAmount"
        Me.lblBillAmount.Size = New System.Drawing.Size(118, 32)
        Me.lblBillAmount.TabIndex = 0
        Me.lblBillAmount.Text = "Bill Amount"
        Me.lblBillAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBillAmount
        '
        Me.txtBillAmount.BackColor = System.Drawing.Color.White
        Me.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBillAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBillAmount.Location = New System.Drawing.Point(127, 3)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(103, 23)
        Me.txtBillAmount.TabIndex = 1
        Me.txtBillAmount.Text = "0.00"
        Me.txtBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblReceivedAmount
        '
        Me.lblReceivedAmount.AutoSize = True
        Me.lblReceivedAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReceivedAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReceivedAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblReceivedAmount.Location = New System.Drawing.Point(236, 0)
        Me.lblReceivedAmount.Name = "lblReceivedAmount"
        Me.lblReceivedAmount.Size = New System.Drawing.Size(109, 32)
        Me.lblReceivedAmount.TabIndex = 2
        Me.lblReceivedAmount.Text = "Received Amt"
        Me.lblReceivedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReceivedAmount
        '
        Me.txtReceivedAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtReceivedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceivedAmount.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtReceivedAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReceivedAmount.Location = New System.Drawing.Point(351, 3)
        Me.txtReceivedAmount.Name = "txtReceivedAmount"
        Me.txtReceivedAmount.ReadOnly = True
        Me.txtReceivedAmount.Size = New System.Drawing.Size(109, 23)
        Me.txtReceivedAmount.TabIndex = 3
        Me.txtReceivedAmount.Text = "0.00"
        Me.txtReceivedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSalesDueDate
        '
        Me.lblSalesDueDate.AutoSize = True
        Me.lblSalesDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalesDueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblSalesDueDate.Location = New System.Drawing.Point(3, 32)
        Me.lblSalesDueDate.Name = "lblSalesDueDate"
        Me.lblSalesDueDate.Size = New System.Drawing.Size(91, 15)
        Me.lblSalesDueDate.TabIndex = 4
        Me.lblSalesDueDate.Text = "Sales Due Date"
        '
        'dtpSalesDueDate
        '
        Me.dtpSalesDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpSalesDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSalesDueDate.Location = New System.Drawing.Point(127, 35)
        Me.dtpSalesDueDate.Name = "dtpSalesDueDate"
        Me.dtpSalesDueDate.Size = New System.Drawing.Size(103, 23)
        Me.dtpSalesDueDate.TabIndex = 5
        Me.dtpSalesDueDate.Value = New Date(2026, 3, 28, 0, 0, 0, 0)
        '
        'tlpMain
        '
        Me.tlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.pnlBillingInfo, 0, 0)
        Me.tlpMain.Controls.Add(Me.pnlSearch, 0, 1)
        Me.tlpMain.Controls.Add(Me.lblTitle, 0, 2)
        Me.tlpMain.Controls.Add(Me.pnlPagination, 0, 4)
        Me.tlpMain.Controls.Add(Me.gcData, 0, 3)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(5, 5)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tlpMain.RowCount = 6
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 269.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1425, 688)
        Me.tlpMain.TabIndex = 0
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Location = New System.Drawing.Point(6, 356)
        Me.gcData.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(1413, 264)
        Me.gcData.TabIndex = 5
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.Options.UseFont = True
        Me.gvData.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.gvData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.FocusedRow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gvData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvData.Appearance.FocusedRow.Options.UseFont = True
        Me.gvData.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gvData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gvData.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gvData.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gvData.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gvData.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.gvData.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gvData.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gvData.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvData.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gvData.Appearance.OddRow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.Options.UseFont = True
        Me.gvData.Appearance.OddRow.Options.UseForeColor = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.gvData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.SelectedRow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gvData.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvData.Appearance.SelectedRow.Options.UseFont = True
        Me.gvData.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gvData.ColumnPanelRowHeight = 10
        Me.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsBehavior.Editable = False
        Me.gvData.OptionsBehavior.ReadOnly = True
        Me.gvData.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'FrmBillingEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1435, 698)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FrmBillingEntry"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "💰 Billing Management System"
        Me.pnlPagination.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlBillingInfo.ResumeLayout(False)
        Me.grpBillingInfo.ResumeLayout(False)
        Me.tlpBillingLayout.ResumeLayout(False)
        Me.grpBillInfo.ResumeLayout(False)
        Me.tlpBillInfo.ResumeLayout(False)
        Me.tlpBillInfo.PerformLayout()
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.tlpCustomerDetails.ResumeLayout(False)
        Me.tlpCustomerDetails.PerformLayout()
        Me.grpCustomerSelect.ResumeLayout(False)
        Me.tlpCustomerSelect.ResumeLayout(False)
        Me.tlpCustomerSelect.PerformLayout()
        Me.grpAmountDetails.ResumeLayout(False)
        Me.tlpAmountDetails.ResumeLayout(False)
        Me.tlpAmountDetails.PerformLayout()
        Me.tlpMain.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPagination As Panel
    Friend WithEvents btn_Refresh As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents pnlBillingInfo As Panel
    Friend WithEvents grpBillingInfo As GroupBox
    Friend WithEvents tlpBillingLayout As TableLayoutPanel
    Friend WithEvents grpBillInfo As GroupBox
    Friend WithEvents tlpBillInfo As TableLayoutPanel
    Friend WithEvents lblSeries As Label
    Friend WithEvents cmbSeries As ComboBox
    Friend WithEvents lblBillNo As Label
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents lblBillDate As Label
    Friend WithEvents dtpBillDate As DateTimePicker
    Friend WithEvents lblBillNumber As Label
    Friend WithEvents txtBillNumber As TextBox
    Friend WithEvents grpCustomerDetails As GroupBox
    Friend WithEvents tlpCustomerDetails As TableLayoutPanel
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents lblAdd1 As Label
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents lblAdd2 As Label
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents lblPincode As Label
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents lblAreaCity As Label
    Friend WithEvents txtAreaCity As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents grpCustomerSelect As GroupBox
    Friend WithEvents tlpCustomerSelect As TableLayoutPanel
    Friend WithEvents lblCustomerCode As Label
    Friend WithEvents txtCustomerCode As TextBox
    Friend WithEvents lblCollectionPerson As Label
    Friend WithEvents cmbCollectionPerson As ComboBox
    Friend WithEvents grpAmountDetails As GroupBox
    Friend WithEvents tlpAmountDetails As TableLayoutPanel
    Friend WithEvents lblBillAmount As Label
    Friend WithEvents txtBillAmount As TextBox
    Friend WithEvents lblReceivedAmount As Label
    Friend WithEvents txtReceivedAmount As TextBox
    Friend WithEvents lblSalesDueDate As Label
    Friend WithEvents dtpSalesDueDate As DateTimePicker
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
End Class
