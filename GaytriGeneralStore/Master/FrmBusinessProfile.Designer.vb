<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBusinessProfile
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.lblCompanyId = New System.Windows.Forms.Label()
        Me.gbMainDetail = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtUserPwd = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserPwd = New System.Windows.Forms.Label()
        Me.txtFacebook = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtInstagram = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnUpdatePmtQR = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPaymentQR1 = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMobileNo1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMobileNo2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImgPath1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIFSCCode = New System.Windows.Forms.TextBox()
        Me.txtBranchCode = New System.Windows.Forms.TextBox()
        Me.txtBankAcNo = New System.Windows.Forms.TextBox()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTC5 = New System.Windows.Forms.TextBox()
        Me.txtTC4 = New System.Windows.Forms.TextBox()
        Me.txtTC3 = New System.Windows.Forms.TextBox()
        Me.txtTC2 = New System.Windows.Forms.TextBox()
        Me.txtTC1 = New System.Windows.Forms.TextBox()
        Me.txtGSTNo = New System.Windows.Forms.TextBox()
        Me.lblGSTNo = New System.Windows.Forms.Label()
        Me.txtPANNo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtAuthDesig = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtECCNo = New System.Windows.Forms.TextBox()
        Me.txtAuthSign = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEMailId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompanyCode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pbPaymentQR1 = New System.Windows.Forms.PictureBox()
        Me.pbImg1 = New System.Windows.Forms.PictureBox()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMainDetail.SuspendLayout()
        CType(Me.pbPaymentQR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Location = New System.Drawing.Point(8, 496)
        Me.grdData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.RowHeadersWidth = 21
        Me.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdData.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(1381, 186)
        Me.grdData.TabIndex = 9
        '
        'lblCompanyId
        '
        Me.lblCompanyId.AutoSize = True
        Me.lblCompanyId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyId.ForeColor = System.Drawing.Color.Black
        Me.lblCompanyId.Location = New System.Drawing.Point(445, 558)
        Me.lblCompanyId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyId.Name = "lblCompanyId"
        Me.lblCompanyId.Size = New System.Drawing.Size(88, 17)
        Me.lblCompanyId.TabIndex = 73
        Me.lblCompanyId.Text = "CompanyId"
        Me.lblCompanyId.Visible = False
        '
        'gbMainDetail
        '
        Me.gbMainDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMainDetail.Controls.Add(Me.Label27)
        Me.gbMainDetail.Controls.Add(Me.txtUserPwd)
        Me.gbMainDetail.Controls.Add(Me.txtUserName)
        Me.gbMainDetail.Controls.Add(Me.lblUsername)
        Me.gbMainDetail.Controls.Add(Me.lblUserPwd)
        Me.gbMainDetail.Controls.Add(Me.txtFacebook)
        Me.gbMainDetail.Controls.Add(Me.Label23)
        Me.gbMainDetail.Controls.Add(Me.txtInstagram)
        Me.gbMainDetail.Controls.Add(Me.Label24)
        Me.gbMainDetail.Controls.Add(Me.btnUpdatePmtQR)
        Me.gbMainDetail.Controls.Add(Me.Label21)
        Me.gbMainDetail.Controls.Add(Me.txtPaymentQR1)
        Me.gbMainDetail.Controls.Add(Me.pbPaymentQR1)
        Me.gbMainDetail.Controls.Add(Me.txtWebsite)
        Me.gbMainDetail.Controls.Add(Me.Label20)
        Me.gbMainDetail.Controls.Add(Me.txtMobileNo1)
        Me.gbMainDetail.Controls.Add(Me.Label17)
        Me.gbMainDetail.Controls.Add(Me.txtMobileNo2)
        Me.gbMainDetail.Controls.Add(Me.Label19)
        Me.gbMainDetail.Controls.Add(Me.btnSaveImage)
        Me.gbMainDetail.Controls.Add(Me.Label4)
        Me.gbMainDetail.Controls.Add(Me.txtImgPath1)
        Me.gbMainDetail.Controls.Add(Me.pbImg1)
        Me.gbMainDetail.Controls.Add(Me.Label18)
        Me.gbMainDetail.Controls.Add(Me.Label16)
        Me.gbMainDetail.Controls.Add(Me.Label15)
        Me.gbMainDetail.Controls.Add(Me.Label12)
        Me.gbMainDetail.Controls.Add(Me.txtIFSCCode)
        Me.gbMainDetail.Controls.Add(Me.txtBranchCode)
        Me.gbMainDetail.Controls.Add(Me.txtBankAcNo)
        Me.gbMainDetail.Controls.Add(Me.txtBankName)
        Me.gbMainDetail.Controls.Add(Me.Label9)
        Me.gbMainDetail.Controls.Add(Me.txtTC5)
        Me.gbMainDetail.Controls.Add(Me.txtTC4)
        Me.gbMainDetail.Controls.Add(Me.txtTC3)
        Me.gbMainDetail.Controls.Add(Me.txtTC2)
        Me.gbMainDetail.Controls.Add(Me.txtTC1)
        Me.gbMainDetail.Controls.Add(Me.txtGSTNo)
        Me.gbMainDetail.Controls.Add(Me.lblGSTNo)
        Me.gbMainDetail.Controls.Add(Me.txtPANNo)
        Me.gbMainDetail.Controls.Add(Me.Label22)
        Me.gbMainDetail.Controls.Add(Me.Label53)
        Me.gbMainDetail.Controls.Add(Me.txtAuthDesig)
        Me.gbMainDetail.Controls.Add(Me.Label51)
        Me.gbMainDetail.Controls.Add(Me.txtECCNo)
        Me.gbMainDetail.Controls.Add(Me.txtAuthSign)
        Me.gbMainDetail.Controls.Add(Me.Label49)
        Me.gbMainDetail.Controls.Add(Me.lblCode)
        Me.gbMainDetail.Controls.Add(Me.txtFax)
        Me.gbMainDetail.Controls.Add(Me.Label13)
        Me.gbMainDetail.Controls.Add(Me.txtEMailId)
        Me.gbMainDetail.Controls.Add(Me.Label11)
        Me.gbMainDetail.Controls.Add(Me.txtPhone)
        Me.gbMainDetail.Controls.Add(Me.Label10)
        Me.gbMainDetail.Controls.Add(Me.txtPincode)
        Me.gbMainDetail.Controls.Add(Me.Label8)
        Me.gbMainDetail.Controls.Add(Me.txtCountry)
        Me.gbMainDetail.Controls.Add(Me.Label7)
        Me.gbMainDetail.Controls.Add(Me.txtState)
        Me.gbMainDetail.Controls.Add(Me.Label6)
        Me.gbMainDetail.Controls.Add(Me.txtCity)
        Me.gbMainDetail.Controls.Add(Me.Label5)
        Me.gbMainDetail.Controls.Add(Me.txtAdd2)
        Me.gbMainDetail.Controls.Add(Me.Label1)
        Me.gbMainDetail.Controls.Add(Me.txtAdd1)
        Me.gbMainDetail.Controls.Add(Me.Label3)
        Me.gbMainDetail.Controls.Add(Me.txtCompanyName)
        Me.gbMainDetail.Controls.Add(Me.Label2)
        Me.gbMainDetail.Controls.Add(Me.txtCompanyCode)
        Me.gbMainDetail.Controls.Add(Me.Label14)
        Me.gbMainDetail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMainDetail.Location = New System.Drawing.Point(12, 7)
        Me.gbMainDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbMainDetail.Name = "gbMainDetail"
        Me.gbMainDetail.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbMainDetail.Size = New System.Drawing.Size(1377, 481)
        Me.gbMainDetail.TabIndex = 1
        Me.gbMainDetail.TabStop = False
        Me.gbMainDetail.Text = "Business Details"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label27.Location = New System.Drawing.Point(861, 399)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(0, 17)
        Me.Label27.TabIndex = 279
        '
        'txtUserPwd
        '
        Me.txtUserPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserPwd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPwd.Location = New System.Drawing.Point(1040, 161)
        Me.txtUserPwd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserPwd.MaxLength = 15
        Me.txtUserPwd.Name = "txtUserPwd"
        Me.txtUserPwd.Size = New System.Drawing.Size(157, 24)
        Me.txtUserPwd.TabIndex = 278
        Me.txtUserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUserPwd.UseSystemPasswordChar = True
        Me.txtUserPwd.Visible = False
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(741, 161)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.MaxLength = 50
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(179, 24)
        Me.txtUserName.TabIndex = 277
        Me.txtUserName.Visible = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(623, 166)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(86, 17)
        Me.lblUsername.TabIndex = 276
        Me.lblUsername.Text = "UserName"
        Me.lblUsername.Visible = False
        '
        'lblUserPwd
        '
        Me.lblUserPwd.AutoSize = True
        Me.lblUserPwd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUserPwd.Location = New System.Drawing.Point(951, 166)
        Me.lblUserPwd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserPwd.Name = "lblUserPwd"
        Me.lblUserPwd.Size = New System.Drawing.Size(77, 17)
        Me.lblUserPwd.TabIndex = 275
        Me.lblUserPwd.Text = "UserPwd"
        Me.lblUserPwd.Visible = False
        '
        'txtFacebook
        '
        Me.txtFacebook.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacebook.Location = New System.Drawing.Point(115, 226)
        Me.txtFacebook.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFacebook.MaxLength = 50
        Me.txtFacebook.Name = "txtFacebook"
        Me.txtFacebook.Size = New System.Drawing.Size(185, 24)
        Me.txtFacebook.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(12, 231)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 17)
        Me.Label23.TabIndex = 272
        Me.Label23.Text = "Facebook"
        '
        'txtInstagram
        '
        Me.txtInstagram.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstagram.Location = New System.Drawing.Point(419, 226)
        Me.txtInstagram.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInstagram.MaxLength = 50
        Me.txtInstagram.Name = "txtInstagram"
        Me.txtInstagram.Size = New System.Drawing.Size(185, 24)
        Me.txtInstagram.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(315, 231)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 17)
        Me.Label24.TabIndex = 271
        Me.Label24.Text = "Instagram"
        '
        'btnUpdatePmtQR
        '
        Me.btnUpdatePmtQR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePmtQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdatePmtQR.Location = New System.Drawing.Point(1039, 418)
        Me.btnUpdatePmtQR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdatePmtQR.Name = "btnUpdatePmtQR"
        Me.btnUpdatePmtQR.Size = New System.Drawing.Size(160, 49)
        Me.btnUpdatePmtQR.TabIndex = 33
        Me.btnUpdatePmtQR.Text = "Update Pmt QR"
        Me.btnUpdatePmtQR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdatePmtQR.UseVisualStyleBackColor = True
        Me.btnUpdatePmtQR.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(1205, 274)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 17)
        Me.Label21.TabIndex = 268
        Me.Label21.Text = "Browse Pmt QR"
        '
        'txtPaymentQR1
        '
        Me.txtPaymentQR1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtPaymentQR1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentQR1.Location = New System.Drawing.Point(1211, 299)
        Me.txtPaymentQR1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPaymentQR1.MaxLength = 500
        Me.txtPaymentQR1.Name = "txtPaymentQR1"
        Me.txtPaymentQR1.ReadOnly = True
        Me.txtPaymentQR1.Size = New System.Drawing.Size(159, 24)
        Me.txtPaymentQR1.TabIndex = 32
        '
        'txtWebsite
        '
        Me.txtWebsite.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebsite.Location = New System.Drawing.Point(419, 262)
        Me.txtWebsite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWebsite.MaxLength = 50
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(185, 24)
        Me.txtWebsite.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(333, 267)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 17)
        Me.Label20.TabIndex = 264
        Me.Label20.Text = "Website"
        '
        'txtMobileNo1
        '
        Me.txtMobileNo1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo1.Location = New System.Drawing.Point(115, 193)
        Me.txtMobileNo1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMobileNo1.MaxLength = 30
        Me.txtMobileNo1.Name = "txtMobileNo1"
        Me.txtMobileNo1.Size = New System.Drawing.Size(185, 24)
        Me.txtMobileNo1.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(12, 198)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 17)
        Me.Label17.TabIndex = 262
        Me.Label17.Text = "MobileNo1"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo2.Location = New System.Drawing.Point(419, 193)
        Me.txtMobileNo2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMobileNo2.MaxLength = 30
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(185, 24)
        Me.txtMobileNo2.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(315, 198)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 17)
        Me.Label19.TabIndex = 261
        Me.Label19.Text = "MobileNo2"
        '
        'btnSaveImage
        '
        Me.btnSaveImage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveImage.Location = New System.Drawing.Point(1207, 213)
        Me.btnSaveImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(160, 49)
        Me.btnSaveImage.TabIndex = 31
        Me.btnSaveImage.Text = "Update Logo"
        Me.btnSaveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveImage.UseVisualStyleBackColor = True
        Me.btnSaveImage.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1203, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "Browse Logo"
        '
        'txtImgPath1
        '
        Me.txtImgPath1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtImgPath1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgPath1.Location = New System.Drawing.Point(1207, 39)
        Me.txtImgPath1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImgPath1.MaxLength = 500
        Me.txtImgPath1.Name = "txtImgPath1"
        Me.txtImgPath1.ReadOnly = True
        Me.txtImgPath1.Size = New System.Drawing.Size(159, 24)
        Me.txtImgPath1.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(937, 133)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 17)
        Me.Label18.TabIndex = 196
        Me.Label18.Text = "IFSC Code"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(623, 133)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 17)
        Me.Label16.TabIndex = 195
        Me.Label16.Text = "Branch Code"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(623, 100)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 17)
        Me.Label15.TabIndex = 194
        Me.Label15.Text = "Account No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(623, 66)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 17)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "Bank Name"
        '
        'txtIFSCCode
        '
        Me.txtIFSCCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIFSCCode.Location = New System.Drawing.Point(1040, 128)
        Me.txtIFSCCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIFSCCode.MaxLength = 50
        Me.txtIFSCCode.Name = "txtIFSCCode"
        Me.txtIFSCCode.Size = New System.Drawing.Size(157, 24)
        Me.txtIFSCCode.TabIndex = 24
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(741, 128)
        Me.txtBranchCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBranchCode.MaxLength = 50
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(179, 24)
        Me.txtBranchCode.TabIndex = 23
        '
        'txtBankAcNo
        '
        Me.txtBankAcNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankAcNo.Location = New System.Drawing.Point(741, 95)
        Me.txtBankAcNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBankAcNo.MaxLength = 50
        Me.txtBankAcNo.Name = "txtBankAcNo"
        Me.txtBankAcNo.Size = New System.Drawing.Size(456, 24)
        Me.txtBankAcNo.TabIndex = 22
        '
        'txtBankName
        '
        Me.txtBankName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(741, 62)
        Me.txtBankName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBankName.MaxLength = 50
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(456, 24)
        Me.txtBankName.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(612, 191)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(587, 27)
        Me.Label9.TabIndex = 188
        Me.Label9.Text = "Terms"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTC5
        '
        Me.txtTC5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC5.Location = New System.Drawing.Point(612, 359)
        Me.txtTC5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTC5.MaxLength = 500
        Me.txtTC5.Multiline = True
        Me.txtTC5.Name = "txtTC5"
        Me.txtTC5.Size = New System.Drawing.Size(585, 25)
        Me.txtTC5.TabIndex = 29
        '
        'txtTC4
        '
        Me.txtTC4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC4.Location = New System.Drawing.Point(612, 327)
        Me.txtTC4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTC4.MaxLength = 500
        Me.txtTC4.Multiline = True
        Me.txtTC4.Name = "txtTC4"
        Me.txtTC4.Size = New System.Drawing.Size(585, 25)
        Me.txtTC4.TabIndex = 28
        '
        'txtTC3
        '
        Me.txtTC3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC3.Location = New System.Drawing.Point(612, 294)
        Me.txtTC3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTC3.MaxLength = 500
        Me.txtTC3.Multiline = True
        Me.txtTC3.Name = "txtTC3"
        Me.txtTC3.Size = New System.Drawing.Size(585, 25)
        Me.txtTC3.TabIndex = 27
        '
        'txtTC2
        '
        Me.txtTC2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC2.Location = New System.Drawing.Point(612, 261)
        Me.txtTC2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTC2.MaxLength = 500
        Me.txtTC2.Multiline = True
        Me.txtTC2.Name = "txtTC2"
        Me.txtTC2.Size = New System.Drawing.Size(585, 25)
        Me.txtTC2.TabIndex = 26
        '
        'txtTC1
        '
        Me.txtTC1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC1.Location = New System.Drawing.Point(612, 228)
        Me.txtTC1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTC1.MaxLength = 500
        Me.txtTC1.Multiline = True
        Me.txtTC1.Name = "txtTC1"
        Me.txtTC1.Size = New System.Drawing.Size(585, 25)
        Me.txtTC1.TabIndex = 25
        '
        'txtGSTNo
        '
        Me.txtGSTNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSTNo.Location = New System.Drawing.Point(419, 359)
        Me.txtGSTNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGSTNo.MaxLength = 30
        Me.txtGSTNo.Name = "txtGSTNo"
        Me.txtGSTNo.Size = New System.Drawing.Size(185, 24)
        Me.txtGSTNo.TabIndex = 17
        '
        'lblGSTNo
        '
        Me.lblGSTNo.AutoSize = True
        Me.lblGSTNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSTNo.ForeColor = System.Drawing.Color.Black
        Me.lblGSTNo.Location = New System.Drawing.Point(335, 366)
        Me.lblGSTNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGSTNo.Name = "lblGSTNo"
        Me.lblGSTNo.Size = New System.Drawing.Size(70, 17)
        Me.lblGSTNo.TabIndex = 181
        Me.lblGSTNo.Text = "GST No."
        '
        'txtPANNo
        '
        Me.txtPANNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPANNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPANNo.Location = New System.Drawing.Point(419, 327)
        Me.txtPANNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPANNo.MaxLength = 30
        Me.txtPANNo.Name = "txtPANNo"
        Me.txtPANNo.Size = New System.Drawing.Size(184, 24)
        Me.txtPANNo.TabIndex = 15
        Me.txtPANNo.Tag = "COUNTRY"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(333, 332)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 17)
        Me.Label22.TabIndex = 173
        Me.Label22.Text = "PAN No."
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label53.Location = New System.Drawing.Point(12, 430)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(65, 17)
        Me.Label53.TabIndex = 157
        Me.Label53.Text = "Design."
        '
        'txtAuthDesig
        '
        Me.txtAuthDesig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAuthDesig.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtAuthDesig.Location = New System.Drawing.Point(115, 425)
        Me.txtAuthDesig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAuthDesig.MaxLength = 30
        Me.txtAuthDesig.Name = "txtAuthDesig"
        Me.txtAuthDesig.Size = New System.Drawing.Size(185, 24)
        Me.txtAuthDesig.TabIndex = 19
        Me.txtAuthDesig.Tag = ""
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label51.Location = New System.Drawing.Point(337, 430)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(64, 17)
        Me.Label51.TabIndex = 155
        Me.Label51.Text = "Tagline"
        '
        'txtECCNo
        '
        Me.txtECCNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtECCNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtECCNo.Location = New System.Drawing.Point(419, 425)
        Me.txtECCNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtECCNo.MaxLength = 50
        Me.txtECCNo.Name = "txtECCNo"
        Me.txtECCNo.Size = New System.Drawing.Size(185, 24)
        Me.txtECCNo.TabIndex = 20
        Me.txtECCNo.Tag = ""
        '
        'txtAuthSign
        '
        Me.txtAuthSign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAuthSign.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtAuthSign.Location = New System.Drawing.Point(115, 393)
        Me.txtAuthSign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAuthSign.MaxLength = 50
        Me.txtAuthSign.Name = "txtAuthSign"
        Me.txtAuthSign.Size = New System.Drawing.Size(489, 24)
        Me.txtAuthSign.TabIndex = 18
        Me.txtAuthSign.Tag = ""
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label49.Location = New System.Drawing.Point(12, 398)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(94, 17)
        Me.Label49.TabIndex = 153
        Me.Label49.Text = "Auth. Sign."
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Black
        Me.lblCode.Location = New System.Drawing.Point(152, 32)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(48, 17)
        Me.lblCode.TabIndex = 141
        Me.lblCode.Text = "Code"
        Me.lblCode.Visible = False
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(115, 359)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFax.MaxLength = 30
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(185, 24)
        Me.txtFax.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(12, 366)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 17)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Fax No."
        '
        'txtEMailId
        '
        Me.txtEMailId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEMailId.Location = New System.Drawing.Point(115, 260)
        Me.txtEMailId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEMailId.MaxLength = 100
        Me.txtEMailId.Name = "txtEMailId"
        Me.txtEMailId.Size = New System.Drawing.Size(185, 24)
        Me.txtEMailId.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 265)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "E-Mail"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(115, 161)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone.MaxLength = 30
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(185, 24)
        Me.txtPhone.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 166)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Ph. No."
        '
        'txtPincode
        '
        Me.txtPincode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPincode.Location = New System.Drawing.Point(419, 161)
        Me.txtPincode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPincode.MaxLength = 30
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(185, 24)
        Me.txtPincode.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(333, 166)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Pincode"
        '
        'txtCountry
        '
        Me.txtCountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(115, 327)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCountry.MaxLength = 30
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(185, 24)
        Me.txtCountry.TabIndex = 14
        Me.txtCountry.Tag = "COUNTRY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 332)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Country"
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtState.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(419, 294)
        Me.txtState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtState.MaxLength = 30
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(184, 24)
        Me.txtState.TabIndex = 13
        Me.txtState.Tag = "State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(356, 299)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "State"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(115, 294)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCity.MaxLength = 30
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(185, 24)
        Me.txtCity.TabIndex = 12
        Me.txtCity.Tag = "CITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 299)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "City"
        '
        'txtAdd2
        '
        Me.txtAdd2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd2.Location = New System.Drawing.Point(115, 128)
        Me.txtAdd2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAdd2.MaxLength = 100
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(489, 24)
        Me.txtAdd2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Add2"
        '
        'txtAdd1
        '
        Me.txtAdd1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd1.Location = New System.Drawing.Point(115, 95)
        Me.txtAdd1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAdd1.MaxLength = 100
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(489, 24)
        Me.txtAdd1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Add1"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(115, 62)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCompanyName.MaxLength = 150
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(489, 24)
        Me.txtCompanyName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Name"
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyCode.Location = New System.Drawing.Point(115, 28)
        Me.txtCompanyCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCompanyCode.MaxLength = 10
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.Size = New System.Drawing.Size(185, 24)
        Me.txtCompanyCode.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 32)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 17)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Code"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(469, 704)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Cl&ose"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(365, 704)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(264, 704)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 36)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Location = New System.Drawing.Point(173, 704)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.btnEdit.Location = New System.Drawing.Point(92, 704)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(76, 36)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(11, 704)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 36)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Visible = False
        '
        'pbPaymentQR1
        '
        Me.pbPaymentQR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPaymentQR1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pbPaymentQR1.Location = New System.Drawing.Point(1211, 332)
        Me.pbPaymentQR1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbPaymentQR1.Name = "pbPaymentQR1"
        Me.pbPaymentQR1.Size = New System.Drawing.Size(159, 135)
        Me.pbPaymentQR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPaymentQR1.TabIndex = 267
        Me.pbPaymentQR1.TabStop = False
        '
        'pbImg1
        '
        Me.pbImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImg1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pbImg1.Location = New System.Drawing.Point(1207, 71)
        Me.pbImg1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbImg1.Name = "pbImg1"
        Me.pbImg1.Size = New System.Drawing.Size(159, 135)
        Me.pbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImg1.TabIndex = 257
        Me.pbImg1.TabStop = False
        '
        'FrmBusinessProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 745)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblCompanyId)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.gbMainDetail)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusinessProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Business Profile"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMainDetail.ResumeLayout(False)
        Me.gbMainDetail.PerformLayout()
        CType(Me.pbPaymentQR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents lblCompanyId As System.Windows.Forms.Label
    Friend WithEvents gbMainDetail As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtEMailId As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPincode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyCode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtAuthDesig As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtECCNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthSign As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtPANNo As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtGSTNo As System.Windows.Forms.TextBox
    Friend WithEvents lblGSTNo As System.Windows.Forms.Label
    Friend WithEvents txtTC5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTC4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTC3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIFSCCode As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents txtBankAcNo As System.Windows.Forms.TextBox
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImgPath1 As System.Windows.Forms.TextBox
    Friend WithEvents pbImg1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMobileNo1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMobileNo2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnUpdatePmtQR As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPaymentQR1 As TextBox
    Friend WithEvents pbPaymentQR1 As PictureBox
    Friend WithEvents txtFacebook As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtInstagram As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblUserPwd As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtUserPwd As TextBox
End Class
