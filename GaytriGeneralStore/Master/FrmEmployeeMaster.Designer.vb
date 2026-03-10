<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmployeeMaster
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpBasicInfo = New System.Windows.Forms.GroupBox()
        Me.pnlInputContainer = New System.Windows.Forms.Panel()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.lblLedgerCode = New System.Windows.Forms.Label()
        Me.txtLedgerCode = New System.Windows.Forms.TextBox()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblGSTNo = New System.Windows.Forms.Label()
        Me.txtGSTNo = New System.Windows.Forms.TextBox()
        Me.grpAddressDetails = New System.Windows.Forms.GroupBox()
        Me.pnlAddressContainer = New System.Windows.Forms.Panel()
        Me.cmbDrCr = New System.Windows.Forms.TextBox()
        Me.txtOpBal = New System.Windows.Forms.TextBox()
        Me.btnAddArea = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblPinCode = New System.Windows.Forms.Label()
        Me.txtPinCode = New System.Windows.Forms.TextBox()
        Me.lblSelectArea = New System.Windows.Forms.Label()
        Me.cmbSelectArea = New System.Windows.Forms.ComboBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.lblCountryDefault = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblLedgerId = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlHeaderRight = New System.Windows.Forms.Panel()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpBasicInfo.SuspendLayout()
        Me.pnlInputContainer.SuspendLayout()
        Me.grpAddressDetails.SuspendLayout()
        Me.pnlAddressContainer.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlHeaderRight.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpBasicInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpAddressDetails)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlButtons)
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(15)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.gcData)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblLedgerId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlHeader)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlSearch)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(15)
        Me.SplitContainer1.Size = New System.Drawing.Size(1690, 750)
        Me.SplitContainer1.SplitterDistance = 585
        Me.SplitContainer1.SplitterIncrement = 10
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'grpBasicInfo
        '
        Me.grpBasicInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grpBasicInfo.Controls.Add(Me.pnlInputContainer)
        Me.grpBasicInfo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBasicInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpBasicInfo.Location = New System.Drawing.Point(15, 15)
        Me.grpBasicInfo.Name = "grpBasicInfo"
        Me.grpBasicInfo.Padding = New System.Windows.Forms.Padding(15)
        Me.grpBasicInfo.Size = New System.Drawing.Size(559, 319)
        Me.grpBasicInfo.TabIndex = 0
        Me.grpBasicInfo.TabStop = False
        Me.grpBasicInfo.Text = "📋 BASIC INFORMATION"
        '
        'pnlInputContainer
        '
        Me.pnlInputContainer.BackColor = System.Drawing.Color.White
        Me.pnlInputContainer.Controls.Add(Me.lblEmployeeName)
        Me.pnlInputContainer.Controls.Add(Me.txtEmployeeName)
        Me.pnlInputContainer.Controls.Add(Me.lblLedgerCode)
        Me.pnlInputContainer.Controls.Add(Me.txtLedgerCode)
        Me.pnlInputContainer.Controls.Add(Me.lblMobileNo)
        Me.pnlInputContainer.Controls.Add(Me.txtMobileNo)
        Me.pnlInputContainer.Controls.Add(Me.lblPhoneNo)
        Me.pnlInputContainer.Controls.Add(Me.txtPhoneNo)
        Me.pnlInputContainer.Controls.Add(Me.lblEmail)
        Me.pnlInputContainer.Controls.Add(Me.txtEmail)
        Me.pnlInputContainer.Controls.Add(Me.lblGSTNo)
        Me.pnlInputContainer.Controls.Add(Me.txtGSTNo)
        Me.pnlInputContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInputContainer.Location = New System.Drawing.Point(15, 40)
        Me.pnlInputContainer.Name = "pnlInputContainer"
        Me.pnlInputContainer.Size = New System.Drawing.Size(529, 264)
        Me.pnlInputContainer.TabIndex = 0
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblEmployeeName.Location = New System.Drawing.Point(15, 75)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(208, 20)
        Me.lblEmployeeName.TabIndex = 0
        Me.lblEmployeeName.Text = "👤 Employee Name *"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BackColor = System.Drawing.Color.White
        Me.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeName.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.txtEmployeeName.Location = New System.Drawing.Point(19, 103)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(444, 28)
        Me.txtEmployeeName.TabIndex = 2
        '
        'lblLedgerCode
        '
        Me.lblLedgerCode.AutoSize = True
        Me.lblLedgerCode.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLedgerCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLedgerCode.Location = New System.Drawing.Point(15, 13)
        Me.lblLedgerCode.Name = "lblLedgerCode"
        Me.lblLedgerCode.Size = New System.Drawing.Size(155, 20)
        Me.lblLedgerCode.TabIndex = 2
        Me.lblLedgerCode.Text = "📊 Ledger Code"
        '
        'txtLedgerCode
        '
        Me.txtLedgerCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtLedgerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLedgerCode.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtLedgerCode.ForeColor = System.Drawing.Color.Green
        Me.txtLedgerCode.Location = New System.Drawing.Point(19, 41)
        Me.txtLedgerCode.Name = "txtLedgerCode"
        Me.txtLedgerCode.Size = New System.Drawing.Size(151, 28)
        Me.txtLedgerCode.TabIndex = 0
        Me.txtLedgerCode.TabStop = False
        Me.txtLedgerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMobileNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMobileNo.Location = New System.Drawing.Point(251, 139)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(150, 20)
        Me.lblMobileNo.TabIndex = 5
        Me.lblMobileNo.Text = "📱 Mobile No *"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BackColor = System.Drawing.Color.White
        Me.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtMobileNo.ForeColor = System.Drawing.Color.Black
        Me.txtMobileNo.Location = New System.Drawing.Point(255, 162)
        Me.txtMobileNo.MaxLength = 10
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(208, 28)
        Me.txtMobileNo.TabIndex = 4
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhoneNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblPhoneNo.Location = New System.Drawing.Point(15, 139)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(128, 20)
        Me.lblPhoneNo.TabIndex = 8
        Me.lblPhoneNo.Text = "📞 Phone No"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.BackColor = System.Drawing.Color.White
        Me.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPhoneNo.ForeColor = System.Drawing.Color.Black
        Me.txtPhoneNo.Location = New System.Drawing.Point(19, 162)
        Me.txtPhoneNo.MaxLength = 10
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(208, 28)
        Me.txtPhoneNo.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(15, 203)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(90, 20)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "✉ Email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(19, 226)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(444, 28)
        Me.txtEmail.TabIndex = 5
        '
        'lblGSTNo
        '
        Me.lblGSTNo.AutoSize = True
        Me.lblGSTNo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGSTNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGSTNo.Location = New System.Drawing.Point(224, 13)
        Me.lblGSTNo.Name = "lblGSTNo"
        Me.lblGSTNo.Size = New System.Drawing.Size(107, 20)
        Me.lblGSTNo.TabIndex = 12
        Me.lblGSTNo.Text = "🏷 GST No"
        '
        'txtGSTNo
        '
        Me.txtGSTNo.BackColor = System.Drawing.Color.White
        Me.txtGSTNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGSTNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGSTNo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtGSTNo.ForeColor = System.Drawing.Color.Black
        Me.txtGSTNo.Location = New System.Drawing.Point(218, 41)
        Me.txtGSTNo.MaxLength = 15
        Me.txtGSTNo.Name = "txtGSTNo"
        Me.txtGSTNo.Size = New System.Drawing.Size(245, 28)
        Me.txtGSTNo.TabIndex = 1
        Me.txtGSTNo.TabStop = False
        '
        'grpAddressDetails
        '
        Me.grpAddressDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grpAddressDetails.Controls.Add(Me.pnlAddressContainer)
        Me.grpAddressDetails.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddressDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpAddressDetails.Location = New System.Drawing.Point(15, 340)
        Me.grpAddressDetails.Name = "grpAddressDetails"
        Me.grpAddressDetails.Padding = New System.Windows.Forms.Padding(15)
        Me.grpAddressDetails.Size = New System.Drawing.Size(559, 291)
        Me.grpAddressDetails.TabIndex = 1
        Me.grpAddressDetails.TabStop = False
        Me.grpAddressDetails.Text = "📍 ADDRESS DETAILS"
        '
        'pnlAddressContainer
        '
        Me.pnlAddressContainer.BackColor = System.Drawing.Color.White
        Me.pnlAddressContainer.Controls.Add(Me.cmbDrCr)
        Me.pnlAddressContainer.Controls.Add(Me.txtOpBal)
        Me.pnlAddressContainer.Controls.Add(Me.btnAddArea)
        Me.pnlAddressContainer.Controls.Add(Me.lblAddress)
        Me.pnlAddressContainer.Controls.Add(Me.txtAddress)
        Me.pnlAddressContainer.Controls.Add(Me.lblPinCode)
        Me.pnlAddressContainer.Controls.Add(Me.txtPinCode)
        Me.pnlAddressContainer.Controls.Add(Me.lblSelectArea)
        Me.pnlAddressContainer.Controls.Add(Me.cmbSelectArea)
        Me.pnlAddressContainer.Controls.Add(Me.lblCountry)
        Me.pnlAddressContainer.Controls.Add(Me.cmbCountry)
        Me.pnlAddressContainer.Controls.Add(Me.lblState)
        Me.pnlAddressContainer.Controls.Add(Me.cmbState)
        Me.pnlAddressContainer.Controls.Add(Me.lblCity)
        Me.pnlAddressContainer.Controls.Add(Me.cmbCity)
        Me.pnlAddressContainer.Controls.Add(Me.lblCountryDefault)
        Me.pnlAddressContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddressContainer.Location = New System.Drawing.Point(15, 40)
        Me.pnlAddressContainer.Name = "pnlAddressContainer"
        Me.pnlAddressContainer.Size = New System.Drawing.Size(529, 236)
        Me.pnlAddressContainer.TabIndex = 0
        '
        'cmbDrCr
        '
        Me.cmbDrCr.BackColor = System.Drawing.Color.White
        Me.cmbDrCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbDrCr.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrCr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbDrCr.Location = New System.Drawing.Point(361, 199)
        Me.cmbDrCr.Name = "cmbDrCr"
        Me.cmbDrCr.Size = New System.Drawing.Size(119, 30)
        Me.cmbDrCr.TabIndex = 18
        Me.cmbDrCr.Visible = False
        '
        'txtOpBal
        '
        Me.txtOpBal.BackColor = System.Drawing.Color.White
        Me.txtOpBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpBal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpBal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOpBal.Location = New System.Drawing.Point(228, 199)
        Me.txtOpBal.Name = "txtOpBal"
        Me.txtOpBal.Size = New System.Drawing.Size(119, 30)
        Me.txtOpBal.TabIndex = 17
        Me.txtOpBal.Visible = False
        '
        'btnAddArea
        '
        Me.btnAddArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddArea.FlatAppearance.BorderSize = 0
        Me.btnAddArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddArea.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddArea.ForeColor = System.Drawing.Color.White
        Me.btnAddArea.Location = New System.Drawing.Point(211, 83)
        Me.btnAddArea.Name = "btnAddArea"
        Me.btnAddArea.Size = New System.Drawing.Size(30, 28)
        Me.btnAddArea.TabIndex = 15
        Me.btnAddArea.TabStop = False
        Me.btnAddArea.Text = "➕"
        Me.btnAddArea.UseVisualStyleBackColor = False
        Me.btnAddArea.Visible = False
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(15, 10)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(99, 18)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "🏠 Address"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(15, 31)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(448, 26)
        Me.txtAddress.TabIndex = 0
        '
        'lblPinCode
        '
        Me.lblPinCode.AutoSize = True
        Me.lblPinCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPinCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPinCode.Location = New System.Drawing.Point(267, 65)
        Me.lblPinCode.Name = "lblPinCode"
        Me.lblPinCode.Size = New System.Drawing.Size(103, 18)
        Me.lblPinCode.TabIndex = 4
        Me.lblPinCode.Text = "📍 Pin Code"
        '
        'txtPinCode
        '
        Me.txtPinCode.BackColor = System.Drawing.Color.White
        Me.txtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPinCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPinCode.ForeColor = System.Drawing.Color.Black
        Me.txtPinCode.Location = New System.Drawing.Point(267, 86)
        Me.txtPinCode.Name = "txtPinCode"
        Me.txtPinCode.Size = New System.Drawing.Size(196, 26)
        Me.txtPinCode.TabIndex = 2
        Me.txtPinCode.TabStop = False
        '
        'lblSelectArea
        '
        Me.lblSelectArea.AutoSize = True
        Me.lblSelectArea.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelectArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblSelectArea.Location = New System.Drawing.Point(12, 65)
        Me.lblSelectArea.Name = "lblSelectArea"
        Me.lblSelectArea.Size = New System.Drawing.Size(126, 18)
        Me.lblSelectArea.TabIndex = 6
        Me.lblSelectArea.Text = "🔽 Select Area"
        '
        'cmbSelectArea
        '
        Me.cmbSelectArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbSelectArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelectArea.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSelectArea.ForeColor = System.Drawing.Color.Black
        Me.cmbSelectArea.FormattingEnabled = True
        Me.cmbSelectArea.Location = New System.Drawing.Point(15, 86)
        Me.cmbSelectArea.Name = "cmbSelectArea"
        Me.cmbSelectArea.Size = New System.Drawing.Size(190, 26)
        Me.cmbSelectArea.TabIndex = 1
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblCountry.Location = New System.Drawing.Point(19, 182)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(97, 18)
        Me.lblCountry.TabIndex = 8
        Me.lblCountry.Text = "🌍 Country"
        '
        'cmbCountry
        '
        Me.cmbCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCountry.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCountry.ForeColor = System.Drawing.Color.Black
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Location = New System.Drawing.Point(15, 203)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(190, 26)
        Me.cmbCountry.TabIndex = 5
        Me.cmbCountry.TabStop = False
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblState.Location = New System.Drawing.Point(264, 120)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(77, 18)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "🏛 State"
        '
        'cmbState
        '
        Me.cmbState.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbState.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbState.ForeColor = System.Drawing.Color.Black
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(264, 138)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(199, 26)
        Me.cmbState.TabIndex = 4
        Me.cmbState.TabStop = False
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCity.Location = New System.Drawing.Point(19, 120)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(64, 18)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "🏙 City"
        '
        'cmbCity
        '
        Me.cmbCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCity.ForeColor = System.Drawing.Color.Black
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(15, 141)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(190, 26)
        Me.cmbCity.TabIndex = 3
        Me.cmbCity.TabStop = False
        '
        'lblCountryDefault
        '
        Me.lblCountryDefault.AutoSize = True
        Me.lblCountryDefault.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountryDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblCountryDefault.Location = New System.Drawing.Point(225, 146)
        Me.lblCountryDefault.Name = "lblCountryDefault"
        Me.lblCountryDefault.Size = New System.Drawing.Size(0, 18)
        Me.lblCountryDefault.TabIndex = 14
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btn_Refresh)
        Me.pnlButtons.Controls.Add(Me.btn_Close)
        Me.pnlButtons.Controls.Add(Me.btn_Cancel)
        Me.pnlButtons.Controls.Add(Me.btn_save)
        Me.pnlButtons.Controls.Add(Me.btn_Delete)
        Me.pnlButtons.Controls.Add(Me.btn_Edit)
        Me.pnlButtons.Controls.Add(Me.btn_Add)
        Me.pnlButtons.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.pnlButtons.Location = New System.Drawing.Point(15, 638)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(559, 100)
        Me.pnlButtons.TabIndex = 2
        '
        'btn_Refresh
        '
        Me.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Refresh.FlatAppearance.BorderSize = 0
        Me.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refresh.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Refresh.ForeColor = System.Drawing.Color.White
        Me.btn_Refresh.Location = New System.Drawing.Point(332, 55)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(130, 32)
        Me.btn_Refresh.TabIndex = 6
        Me.btn_Refresh.Text = "🔄 &REFRESH"
        Me.btn_Refresh.UseVisualStyleBackColor = False
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Close.ForeColor = System.Drawing.Color.White
        Me.btn_Close.Location = New System.Drawing.Point(216, 55)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(110, 32)
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "🚪 CL&OSE"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(91, 55)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(119, 33)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "❌ &CANCEL"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(279, 10)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(122, 35)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "💾 &SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.FlatAppearance.BorderSize = 0
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Delete.ForeColor = System.Drawing.Color.White
        Me.btn_Delete.Location = New System.Drawing.Point(409, 10)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(119, 35)
        Me.btn_Delete.TabIndex = 3
        Me.btn_Delete.Text = "🗑️ &DELETE"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Edit.ForeColor = System.Drawing.Color.White
        Me.btn_Edit.Location = New System.Drawing.Point(150, 10)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(121, 35)
        Me.btn_Edit.TabIndex = 1
        Me.btn_Edit.Text = "✏️ &EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add.FlatAppearance.BorderSize = 0
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Add.ForeColor = System.Drawing.Color.White
        Me.btn_Add.Location = New System.Drawing.Point(24, 10)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(117, 35)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "➕ &ADD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'gcData
        '
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcData.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gcData.Location = New System.Drawing.Point(15, 161)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(1070, 579)
        Me.gcData.TabIndex = 0
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameColumnToolStripMenuItem, Me.ExportToExcelToolStripMenuItem, Me.SaveLayoutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(220, 94)
        '
        'RenameColumnToolStripMenuItem
        '
        Me.RenameColumnToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenameColumnToolStripMenuItem.Name = "RenameColumnToolStripMenuItem"
        Me.RenameColumnToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.RenameColumnToolStripMenuItem.Text = "Rename Column"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
        '
        'SaveLayoutToolStripMenuItem
        '
        Me.SaveLayoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveLayoutToolStripMenuItem.Name = "SaveLayoutToolStripMenuItem"
        Me.SaveLayoutToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.SaveLayoutToolStripMenuItem.Text = "Save Layout"
        '
        'gvData
        '
        Me.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue
        Me.gvData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.FocusedRow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gvData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvData.Appearance.FocusedRow.Options.UseFont = True
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsBehavior.Editable = False
        Me.gvData.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.RowHeight = 27
        '
        'lblLedgerId
        '
        Me.lblLedgerId.AutoSize = True
        Me.lblLedgerId.Location = New System.Drawing.Point(952, 116)
        Me.lblLedgerId.Name = "lblLedgerId"
        Me.lblLedgerId.Size = New System.Drawing.Size(101, 18)
        Me.lblLedgerId.TabIndex = 4
        Me.lblLedgerId.Text = "lblLedgerId"
        Me.lblLedgerId.Visible = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.pnlHeaderRight)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(15, 15)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1070, 64)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(400, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "👤 EMPLOYEE MASTER"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlHeaderRight
        '
        Me.pnlHeaderRight.Controls.Add(Me.lblTotalRecords)
        Me.pnlHeaderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlHeaderRight.Location = New System.Drawing.Point(870, 0)
        Me.pnlHeaderRight.Name = "pnlHeaderRight"
        Me.pnlHeaderRight.Size = New System.Drawing.Size(200, 64)
        Me.pnlHeaderRight.TabIndex = 1
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.AutoSize = True
        Me.lblTotalRecords.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalRecords.Location = New System.Drawing.Point(30, 25)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(165, 25)
        Me.lblTotalRecords.TabIndex = 0
        Me.lblTotalRecords.Text = "📋 Records: 0"
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(15, 95)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(917, 60)
        Me.pnlSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(807, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "🔍 GO"
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(20, 18)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(190, 23)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "🔍 Quick Search:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(213, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(572, 28)
        Me.txtSearch.TabIndex = 0
        '
        'FrmEmployeeMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1690, 750)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmployeeMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "👤 Employee Master Management"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpBasicInfo.ResumeLayout(False)
        Me.pnlInputContainer.ResumeLayout(False)
        Me.pnlInputContainer.PerformLayout()
        Me.grpAddressDetails.ResumeLayout(False)
        Me.pnlAddressContainer.ResumeLayout(False)
        Me.pnlAddressContainer.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeaderRight.ResumeLayout(False)
        Me.pnlHeaderRight.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpBasicInfo As GroupBox
    Friend WithEvents pnlInputContainer As Panel
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents lblLedgerCode As Label
    Friend WithEvents txtLedgerCode As TextBox
    Friend WithEvents lblMobileNo As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblGSTNo As Label
    Friend WithEvents txtGSTNo As TextBox
    Friend WithEvents grpAddressDetails As GroupBox
    Friend WithEvents pnlAddressContainer As Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblPinCode As Label
    Friend WithEvents txtPinCode As TextBox
    Friend WithEvents lblSelectArea As Label
    Friend WithEvents cmbSelectArea As ComboBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents lblState As Label
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents lblCity As Label
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents lblCountryDefault As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btn_Refresh As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlHeaderRight As Panel
    Friend WithEvents lblTotalRecords As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblLedgerId As Label
    Friend WithEvents btnAddArea As Button
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbDrCr As TextBox
    Friend WithEvents txtOpBal As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RenameColumnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveLayoutToolStripMenuItem As ToolStripMenuItem
End Class