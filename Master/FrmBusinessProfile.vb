Imports GaytriGeneralStore.GaytriGeneral.DB
Imports System.IO
Imports System.Management

Public Class FrmBusinessProfile

#Region "Comments"
    'Name:BadasaabFashions
    'Created By:Bhavesh
    'Form:FrmLedgerMaster
    'Date:08/10/2012
#End Region

#Region "Declaration"
    Dim ds As New Data.DataSet
    Dim dsComboGM As New Data.DataSet 'GroupMaster
    Dim obj As New DBManager
    Dim sql_query As String
    Dim edit_ins As Integer = -1
    Dim existCompanyCode As String
    Dim oldCompanyCode As String 'Leddger name Maintained Uniquely
    Dim point As Boolean = False
    Dim _LedgerCodeInitial As String = ""
#End Region

#Region "Method"

    Public Sub formatGrid()
        grdData.Columns("CId").Visible = False
        grdData.Columns("CCode").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdData.Columns("CCode").HeaderText = "Company Code"
        grdData.Columns("CName").HeaderText = "Company Name"
        grdData.Columns("Add1").HeaderText = "Address"
        grdData.Columns("Add2").Visible = False
        'grdData.Columns("City").Visible = False
        grdData.Columns("PinCode").Visible = False
        'grdData.Columns("State").Visible = False
        grdData.Columns("Country").Visible = False
        grdData.Columns("PhNo").Visible = False
        grdData.Columns("FaxNo").Visible = False
        grdData.Columns("EMail").Visible = False
        grdData.Columns("PANNo").Visible = False
        grdData.Columns("ServiceTaxNo").Visible = False
        grdData.Columns("ECCNo").Visible = False
        grdData.Columns("CSTTinNo").Visible = False
        grdData.Columns("GSTTinNo").Visible = False
        grdData.Columns("Invoice").Visible = False
        grdData.Columns("TC1").Visible = False
        grdData.Columns("TC2").Visible = False
        grdData.Columns("TC3").Visible = False
        grdData.Columns("TC4").Visible = False
        grdData.Columns("TC5").Visible = False
        grdData.Columns("TC6").Visible = False
        grdData.Columns("TC7").Visible = False
        grdData.Columns("ForCo").Visible = False
        grdData.Columns("BankName").Visible = False
        grdData.Columns("BankAcNo").Visible = False
        grdData.Columns("BranchCode").Visible = False
        grdData.Columns("IFSCCode").Visible = False
        grdData.Columns("ImagePath").Visible = False
        'grdData.Columns("AuthSign").Visible = False
        'grdData.Columns("AuthDesig").Visible = False

        grdData.AutoResizeColumns()
        grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub gridfill()
        ds.Clear()
        sql_query = "Select * From  View_CompanyMaster Order By CName"
        obj.LoadData(sql_query, ds)
        grdData.DataSource = ds.Tables(0).DefaultView
    End Sub

    Public Sub insert()
        sql_query = "update tbl_LedgerMaster set AcContactPerson = LedgerName where LedgerName in ('INPUT CGST','INPUT IGST','INPUT SGST','OUTPUT CGST','OUTPUT IGST','OUTPUT SGST') and AcContactPerson = ''"
        obj.QueryExecute(sql_query)

        obj.Prepare("SP_InsertCompanyMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsCCode", Dtype.varchar, Trim(txtCompanyCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCName", Dtype.nvarchar, Trim(txtCompanyName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAdd1", Dtype.nvarchar, Trim(txtAdd1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAdd2", Dtype.nvarchar, Trim(txtAdd2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCity", Dtype.nvarchar, Trim(txtCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsState", Dtype.nvarchar, Trim(txtState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPinCode", Dtype.varchar, Trim(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCountry", Dtype.nvarchar, Trim(txtCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPhNo", Dtype.varchar, Trim(txtPhone.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsFaxNo", Dtype.varchar, Trim(txtFax.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsEMail", Dtype.varchar, Trim(txtEMailId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPANNo", Dtype.varchar, Trim(txtPANNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsServiceTaxNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsECCNo", Dtype.varchar, Trim(txtECCNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCSTTinNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsGSTTinNo", Dtype.varchar, Trim(txtGSTNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsInvoice", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankName", Dtype.varchar, Trim(txtBankName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankAcNo", Dtype.varchar, Trim(txtBankAcNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBranchCode", Dtype.varchar, Trim(txtBranchCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsIFSCCode", Dtype.varchar, Trim(txtIFSCCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTC1", Dtype.nvarchar, Trim(txtTC1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTC2", Dtype.nvarchar, Trim(txtTC2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTC3", Dtype.nvarchar, Trim(txtTC3.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTC4", Dtype.nvarchar, Trim(txtTC4.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTC5", Dtype.nvarchar, Trim(txtTC5.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTC6", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTC7", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsForCo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsImagePath", Dtype.varchar, Trim(txtImgPath1.Text), ParaDirection.Input, True)
        'obj.AddCmdParameter("@InsAuthSign", Dtype.varchar, Trim(txtAuthSign.Text), ParaDirection.Input, True)
        'obj.AddCmdParameter("@InsAuthDesig", Dtype.varchar, Trim(txtAuthDesig.Text), ParaDirection.Input, True)

        obj.AddCmdParameter("@InsMobileNo1", Dtype.varchar, Trim(txtMobileNo1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMobileNo2", Dtype.varchar, Trim(txtMobileNo2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsWebsite", Dtype.varchar, Trim(txtWebsite.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsFacebook", Dtype.varchar, Trim(txtFacebook.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsInstagram", Dtype.varchar, Trim(txtInstagram.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsYoutube", Dtype.varchar, Trim(""), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPaymentQR1", Dtype.varchar, Trim(txtPaymentQR1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPaymentQR2", Dtype.varchar, Trim(""), ParaDirection.Input, True)

        obj.ExecuteCommand()

        sql_query = "Select IsNull(Max(CId),0) From tbl_CompanyMaster Where CCode = '" & Trim(txtCompanyCode.Text) & "'"
        lblCompanyId.Text = obj.ScalarExecute(sql_query)
        InsertCustomerImage(Val(lblCompanyId.Text), "CompanyImage")

        InsertPaymentQR(Val(lblCompanyId.Text), "PaymentQR1")

        Dim minCId As Integer
        sql_query = "Select Min(CId) From Tbl_CompanyMaster "
        minCId = obj.ScalarExecute(sql_query)

        sql_query = "Select Max(CId) From Tbl_CompanyMaster Where CName = N'" & Trim(txtCompanyName.Text) & "'"
        lblCompanyId.Text = obj.ScalarExecute(sql_query)

        'Insert User and Rights
        Dim tmpUserId As Integer
        sql_query = "Insert Into tbl_UserMaster (UserName, UserPwd, DeptId, PrintName, CId, Sys_Name, Sys_Time, CurrUsr, LedgerId, Barcode_CIdList, MobileNo, IsOTPRequired, EmailId, IsDemo) " _
            & "Select Top 1  '" & Trim(txtUserName.Text) & "',  '" & Trim(txtUserPwd.Text) & "', DeptId, PrintName, " & lblCompanyId.Text & ", '" & My.Computer.Name & "', '" & Date.Now.ToString("MM/dd/yyyy HH:mm:ss tt") & "', N'" & loggedUser & "', LedgerId, Barcode_CIdList, MobileNo, IsOTPRequired, EmailId, 0 From tbl_UserMaster"
        obj.QueryExecute(sql_query)

        sql_query = "Select Max(UserId) From Tbl_UserMaster Where UserName = N'" & Trim(txtUserName.Text) & "'"
        tmpUserId = obj.ScalarExecute(sql_query)

        sql_query = "Insert Into tbl_UserRightsMaster ( UserId, FormViewId, AllowAccess, NewRecord, ModifyRecord, DeleteRecord) " _
            & " Select " & tmpUserId & ", FormViewId, AllowAccess, NewRecord, ModifyRecord, DeleteRecord From tbl_UserRightsMaster Where UserId = 1"
        obj.QueryExecute(sql_query)

        '==============================
        'Set Default Ledger 
        sql_query = "Update tbl_LedgerMaster Set AcEmailId = 'DefaultLedger', AcContactPerson = LedgerName + ' Ledger Id'  Where LedgerName In ('PURCHASE RETURN','SALES RETURN','SALES','PURCHASE')"
        obj.QueryExecute(sql_query)

        '(Add LedgerName of want default add)
        sql_query = "Update tbl_LedgerMaster Set AcContactPerson = LedgerName Where LedgerName In ('INPUT CGST','INPUT SGST','INPUT IGST', 'OUTPUT CGST','OUTPUT SGST','OUTPUT IGST', 'PROFIT AND LOSS', 'TAILORING')"
        obj.QueryExecute(sql_query)

        'Default Ledger Creation
        sql_query = "Insert Into tbl_LedgerMaster (Code, LedgerCode, LedgerName, G_Id, Address1, Address2, City, PinCode, State, Country, PhoneNo, MobileNo, FaxNo, EMail, BirthDate, AnniDate, CustType, MobileNo2, BeneficiaryName, BankAcType, BankAcNo, IFSCCode, MICRCode, BankName, BankAddress, AcContactPerson, AcContactNo, AcEmailId, TranSMS, PromoSMS, GSTNo, PANNo, Taxation, IsActive, CId) " _
            & "Select Code, LedgerCode, LedgerName, G_Id, Address1, Address2, City, PinCode, State, Country, PhoneNo, MobileNo, FaxNo, EMail, BirthDate, AnniDate, CustType, MobileNo2, BeneficiaryName, BankAcType, BankAcNo, IFSCCode, MICRCode, BankName, BankAddress, AcContactPerson, AcContactNo, AcEmailId, TranSMS, PromoSMS, GSTNo, PANNo, Taxation, IsActive, " & Val(lblCompanyId.Text) & " From tbl_LedgerMaster Where AcEmailId = 'DefaultLedger' And CId = " & minCId 'And G_Id Not In (12,13) 
        obj.QueryExecute(sql_query)

        'Settings Creation
        sql_query = "Insert Into tbl_Settings (SettingName, SettingValue, CId, ModuleName) " _
            & "Select SettingName, SettingValue, " & Val(lblCompanyId.Text) & ", ModuleName From tbl_Settings Where CId = " & minCId
        obj.QueryExecute(sql_query)

        'MiscMaster Creation
        sql_query = "Insert Into tbl_MiscMaster (MiscType, MiscName, Data1, Data2, DispSrNo, CId, IsActive, Data3) " _
            & "Select MiscType, MiscName, Data1, Data2, DispSrNo, " & Val(lblCompanyId.Text) & ", IsActive, Data3 From tbl_MiscMaster Where CId = " & minCId
        obj.QueryExecute(sql_query)

        Dim tmpResult As String
        Dim in_IGST, in_CGST, in_SGST, out_IGST, out_CGST, out_SGST As String

        'Add Voucher  (Payment/Recipt)
        sql_query = "Select LedgerId from Tbl_LedgerMaster Where LedgerName = 'CASH' And G_Id = 13 And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)
        InsertVoucher(tmpResult, "CASH", "CASH")

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where LedgerName = 'GPAY' And G_Id = 12 And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)
        InsertVoucher(tmpResult, "GPAY", "BANK")

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where LedgerName = 'CARD' And G_Id = 12 And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)
        InsertVoucher(tmpResult, "CARD", "BANK")

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where LedgerName = 'PAYTM' And G_Id = 12 And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)
        InsertVoucher(tmpResult, "PAYTM", "BANK")

        '===============
        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'Purchase Ledger Id' And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & tmpResult & "' Where SettingName = 'Purchase Ledger Id' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'Sales Ledger Id' And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & tmpResult & "' Where SettingName = 'Sales Ledger Id' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'Purchase Return Ledger Id' And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & tmpResult & "' Where SettingName = 'Purchase Return Ledger Id' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'Sales Return Ledger Id' And CId = " & Val(lblCompanyId.Text)
        tmpResult = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & tmpResult & "' Where SettingName = 'Sales Return Ledger Id' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'INPUT CGST' And CId = " & Val(lblCompanyId.Text)
        in_CGST = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & in_CGST & "' Where SettingName = 'INPUT CGST' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============
        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'INPUT SGST' And CId = " & Val(lblCompanyId.Text)
        in_SGST = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & in_SGST & "' Where SettingName = 'INPUT SGST' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============
        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'INPUT IGST' And CId = " & Val(lblCompanyId.Text)
        in_IGST = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & in_IGST & "' Where SettingName = 'INPUT IGST' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============
        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'OUTPUT CGST' And CId = " & Val(lblCompanyId.Text)
        out_CGST = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & out_CGST & "' Where SettingName = 'OUTPUT CGST' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============
        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'OUTPUT SGST' And CId = " & Val(lblCompanyId.Text)
        out_SGST = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & out_SGST & "' Where SettingName = 'OUTPUT SGST' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============
        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'OUTPUT IGST' And CId = " & Val(lblCompanyId.Text)
        out_IGST = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & out_IGST & "' Where SettingName = 'OUTPUT IGST' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============

        sql_query = "Update tbl_Settings Set SettingValue = '(" & in_IGST & "," & in_CGST & "," & in_SGST & "," & out_IGST & "," & out_CGST & "," & out_SGST & ")' Where SettingName = 'GST Ledger Id List' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        MsgBox("Company Create Sucessfully" & vbCrLf & " UserName: " & Trim(txtUserName.Text) & vbCrLf & " UserPwd: " & Trim(txtUserPwd.Text), MsgBoxStyle.Information)

        'FrmMDIMain.ComboFill(FrmMDIMain.cmbCName, "Select CId, CName From Tbl_CompanyMaster Order By CId")
    End Sub

    Public Sub InsertVoucher(ByVal tmpLedgerId As Integer, ByVal tmpLedgerName As String, ByVal tmpvouchertype As String)
        Select Case UCase(tmpvouchertype)
            Case "CASH"
                sql_query = "Insert Into tbl_VoucherMaster (V_Name, V_Group, V_ShortName, V_Prefix, V_Header, V_Label, V_DefaultEntry, V_LedgerId) " _
                    & "Values('" & Trim(tmpLedgerName) & " PMT.','Cash Payment','','','','','Cr'," & tmpLedgerId & " )  "
                obj.QueryExecute(sql_query)

                sql_query = "Insert Into tbl_VoucherMaster (V_Name, V_Group, V_ShortName, V_Prefix, V_Header, V_Label, V_DefaultEntry, V_LedgerId) " _
                        & "Values('" & Trim(tmpLedgerName) & " RCPT.','Cash Receipt','','','','','Dr'," & tmpLedgerId & " )  "
                obj.QueryExecute(sql_query)
                Exit Select
            Case "BANK"
                sql_query = "Insert Into tbl_VoucherMaster (V_Name, V_Group, V_ShortName, V_Prefix, V_Header, V_Label, V_DefaultEntry, V_LedgerId) " _
                   & "Values('" & Trim(tmpLedgerName) & " PMT.','Bank Payment','','','','','Cr'," & tmpLedgerId & " )  "
                obj.QueryExecute(sql_query)

                sql_query = "Insert Into tbl_VoucherMaster (V_Name, V_Group, V_ShortName, V_Prefix, V_Header, V_Label, V_DefaultEntry, V_LedgerId) " _
                        & "Values('" & Trim(tmpLedgerName) & " RCPT.','Bank Receipt','','','','','Dr'," & tmpLedgerId & " )  "
                obj.QueryExecute(sql_query)
                Exit Select
        End Select
    End Sub

    Public Sub insertMiscMaster(ByVal _MiscType As String, ByVal _MiscName As String)
        sql_query = "Insert into tbl_MiscMaster (MiscType, MiscName, CId, IsActive) values ('" & _MiscType & "','" & _MiscName & "'," & M_CId & ",'True')"
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub edit() 'Company Id is not Updated
        obj.Prepare("SP_UpdateCompanyMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@UpCCode", Dtype.varchar, Trim(txtCompanyCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCName", Dtype.nvarchar, Trim(txtCompanyName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAdd1", Dtype.nvarchar, Trim(txtAdd1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAdd2", Dtype.nvarchar, Trim(txtAdd2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCity", Dtype.nvarchar, Trim(txtCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpState", Dtype.nvarchar, Trim(txtState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPinCode", Dtype.varchar, Trim(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCountry", Dtype.nvarchar, Trim(txtCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPhNo", Dtype.varchar, Trim(txtPhone.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpFaxNo", Dtype.varchar, Trim(txtFax.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpEMail", Dtype.varchar, Trim(txtEMailId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPANNo", Dtype.varchar, Trim(txtPANNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpServiceTaxNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpECCNo", Dtype.varchar, Trim(txtECCNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCSTTinNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpGSTTinNo", Dtype.varchar, Trim(txtGSTNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpInvoice", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankName", Dtype.varchar, Trim(txtBankName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAcNo", Dtype.varchar, Trim(txtBankAcNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBranchCode", Dtype.varchar, Trim(txtBranchCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIFSCCode", Dtype.varchar, Trim(txtIFSCCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC1", Dtype.nvarchar, Trim(txtTC1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC2", Dtype.nvarchar, Trim(txtTC2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC3", Dtype.nvarchar, Trim(txtTC3.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC4", Dtype.nvarchar, Trim(txtTC4.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC5", Dtype.nvarchar, Trim(txtTC5.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC6", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC7", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpForCo", Dtype.varchar, "", ParaDirection.Input, True)
        'obj.AddCmdParameter("@UpAuthSign", Dtype.varchar, Trim(txtAuthSign.Text), ParaDirection.Input, True)
        'obj.AddCmdParameter("@UpAuthDesig", Dtype.varchar, Trim(txtAuthDesig.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCID", Dtype.varchar, Trim(lblCompanyId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpImagePath", Dtype.varchar, Trim(txtImgPath1.Text), ParaDirection.Input, True)

        obj.AddCmdParameter("@UpMobileNo1", Dtype.varchar, Trim(txtMobileNo1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo2", Dtype.varchar, Trim(txtMobileNo2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpWebsite", Dtype.varchar, Trim(txtWebsite.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpFacebook", Dtype.varchar, Trim(txtFacebook.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpInstagram", Dtype.varchar, Trim(txtInstagram.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpYoutube", Dtype.varchar, Trim(""), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPaymentQR1", Dtype.varchar, Trim(txtPaymentQR1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPaymentQR2", Dtype.varchar, Trim(""), ParaDirection.Input, True)

        obj.ExecuteCommand()
    End Sub

    Public Sub del()
        sql_query = "delete from tbl_CompanyMaster where CId=" & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub loadTime()
        ' _LedgerCodeInitial = "L"

        gridfill()
        formatGrid()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        grdData.Enabled = True
        gbMainDetail.Enabled = False
    End Sub

    Public Sub addClickTime()
        gbMainDetail.Enabled = True
        grdData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        getCompanyCode()
        txtCompanyCode.Focus()
        txtState.Text = M_CState
        lblUsername.Visible = True
        lblUserPwd.Visible = True
        txtUserName.Visible = True
        txtUserPwd.Visible = True
        edit_ins = 1
    End Sub

    Public Sub editClickTime()
        gbMainDetail.Enabled = True
        grdData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        '''LinkLabel1.Visible = True
        btnSaveImage.Visible = True
        btnUpdatePmtQR.Visible = True

        edit_ins = 0
        oldCompanyCode = Trim(txtCompanyCode.Text)
        txtCompanyCode.Focus()
    End Sub

    Public Sub saveClickTime()
        gridfill()
        gbMainDetail.Enabled = False
        grdData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnAdd.Focus()

        txtCompanyCode.Clear()
        txtCompanyName.Clear()
        txtTC1.Clear()
        txtTC2.Clear()
        txtTC3.Clear()
        txtTC4.Clear()
        txtTC5.Clear()
        txtAdd1.Clear()
        txtAdd2.Clear()
        txtCity.Clear()
        txtPincode.Clear()
        txtState.Clear()
        txtGSTNo.Clear()
        txtPANNo.Clear()
        txtCountry.Clear()
        txtEMailId.Clear()
        txtPhone.Clear()
        txtFax.Clear()
        txtAuthSign.Clear()
        txtAuthDesig.Clear()
        txtECCNo.Clear()
        txtBankName.Clear()
        txtBankAcNo.Clear()
        txtIFSCCode.Clear()
        txtBranchCode.Clear()
        txtImgPath1.Clear()
        txtMobileNo1.Clear()
        txtMobileNo2.Clear()
        txtFacebook.Clear()
        txtInstagram.Clear()
        txtPaymentQR1.Clear()
        pbImg1.Image = Nothing
        btnSaveImage.Visible = False
        btnUpdatePmtQR.Visible = False
        edit_ins = -1
    End Sub

    Public Sub deleteClickTime()
        gridfill()
        gbMainDetail.Enabled = False
        grdData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnAdd.Focus()

        txtCompanyCode.Clear()
        txtCompanyName.Clear()
        txtECCNo.Clear()
        txtTC1.Clear()
        txtTC2.Clear()
        txtTC3.Clear()
        txtTC4.Clear()
        txtTC5.Clear()
        txtAdd1.Clear()
        txtAdd2.Clear()
        txtCity.Clear()
        txtPincode.Clear()
        txtEMailId.Clear()
        txtState.Clear()
        txtGSTNo.Clear()
        txtPANNo.Clear()
        txtCountry.Clear()
        txtPhone.Clear()
        txtFax.Clear()
        txtAuthSign.Clear()
        txtAuthDesig.Clear()
        txtBankName.Clear()
        txtBankAcNo.Clear()
        txtIFSCCode.Clear()
        txtBranchCode.Clear()
        txtImgPath1.Clear()
        txtMobileNo1.Clear()
        txtMobileNo2.Clear()
        txtFacebook.Clear()
        txtInstagram.Clear()
        txtPaymentQR1.Clear()
        pbImg1.Image = Nothing
        btnSaveImage.Visible = False
        btnUpdatePmtQR.Visible = False
        edit_ins = -1
    End Sub

    Public Sub cancelClickTime()
        gbMainDetail.Enabled = False
        grdData.Enabled = True

        btnAdd.Enabled = True
        btnAdd.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        btnExit.Enabled = True

        edit_ins = -1

        txtCompanyCode.Clear()
        txtCompanyName.Clear()
        txtAuthDesig.Clear()
        txtAuthSign.Clear()
        txtECCNo.Clear()
        txtTC1.Clear()
        txtTC2.Clear()
        txtTC3.Clear()
        txtTC4.Clear()
        txtTC5.Clear()
        txtAdd1.Clear()
        txtAdd2.Clear()
        txtCity.Clear()
        txtPincode.Clear()
        txtEMailId.Clear()
        txtState.Clear()
        txtGSTNo.Clear()
        txtPANNo.Clear()
        txtCountry.Clear()
        txtPhone.Clear()
        txtFax.Clear()
        txtBankName.Clear()
        txtBankAcNo.Clear()
        txtIFSCCode.Clear()
        txtBranchCode.Clear()
        txtImgPath1.Clear()
        txtMobileNo1.Clear()
        txtMobileNo2.Clear()
        txtFacebook.Clear()
        txtInstagram.Clear()
        txtPaymentQR1.Clear()

        pbImg1.Image = Nothing
        pbPaymentQR1.Image = Nothing
        btnSaveImage.Visible = False
        btnUpdatePmtQR.Visible = False
    End Sub

    Public Sub exitClickTime()
        If edit_ins = -1 Then
            Me.Close()
        Else
            Dim dr As DialogResult
            dr = MsgBox("Sure To Exit Without Saving Data ?", MsgBoxStyle.YesNo)
            If dr = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
        M_LedgerMasterF2 = False
    End Sub

    Public Sub fillData()
        If grdData.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        lblCompanyId.Text = grdData.CurrentRow.Cells("CId").Value
        txtCompanyCode.Text = grdData.CurrentRow.Cells("CCode").Value
        txtCompanyName.Text = grdData.CurrentRow.Cells("CName").Value
        txtAdd1.Text = grdData.CurrentRow.Cells("Add1").Value
        txtAdd2.Text = grdData.CurrentRow.Cells("Add2").Value
        txtCity.Text = grdData.CurrentRow.Cells("City").Value
        txtPincode.Text = grdData.CurrentRow.Cells("PinCode").Value
        txtState.Text = grdData.CurrentRow.Cells("State").Value
        txtCountry.Text = grdData.CurrentRow.Cells("Country").Value
        txtGSTNo.Text = grdData.CurrentRow.Cells("GSTTinNo").Value
        txtPANNo.Text = grdData.CurrentRow.Cells("PANNo").Value
        txtPhone.Text = grdData.CurrentRow.Cells("PhNo").Value
        txtFax.Text = grdData.CurrentRow.Cells("FaxNo").Value
        txtEMailId.Text = grdData.CurrentRow.Cells("Email").Value
        'txtAuthSign.Text = grdData.CurrentRow.Cells("AuthSign").Value
        'txtAuthDesig.Text = grdData.CurrentRow.Cells("AuthDesig").Value
        txtECCNo.Text = grdData.CurrentRow.Cells("ECCNo").Value
        txtTC1.Text = grdData.CurrentRow.Cells("TC1").Value
        txtTC2.Text = grdData.CurrentRow.Cells("TC2").Value
        txtTC3.Text = grdData.CurrentRow.Cells("TC3").Value
        txtTC4.Text = grdData.CurrentRow.Cells("TC4").Value
        txtTC5.Text = grdData.CurrentRow.Cells("TC5").Value
        txtBankName.Text = grdData.CurrentRow.Cells("BankName").Value
        txtBankAcNo.Text = grdData.CurrentRow.Cells("BankAcNo").Value
        txtBranchCode.Text = grdData.CurrentRow.Cells("BranchCode").Value
        txtIFSCCode.Text = grdData.CurrentRow.Cells("IFSCCode").Value
        txtImgPath1.Text = grdData.CurrentRow.Cells("ImagePath").Value
        txtMobileNo1.Text = grdData.CurrentRow.Cells("MobileNo1").Value
        txtMobileNo2.Text = grdData.CurrentRow.Cells("MobileNo2").Value
        txtFacebook.Text = grdData.CurrentRow.Cells("Facebook").Value
        txtInstagram.Text = grdData.CurrentRow.Cells("Instagram").Value
        txtPaymentQR1.Text = grdData.CurrentRow.Cells("PaymentQR1").Value

        Dim tmpds As New Data.DataSet
        sql_query = "Select Id,Image1 from tbl_ImageMaster where MasterId = " & Val(lblCompanyId.Text) & " and ImageType = 'CompanyImage'"
        obj.LoadData(sql_query, tmpds)

        If tmpds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(tmpds.Tables(0).Rows(0)("Image1")) = False Then
                Dim imgByteArray() As Byte
                imgByteArray = CType(tmpds.Tables(0).Rows(0)("Image1"), Byte())
                Dim stream As New MemoryStream(imgByteArray)
                Dim bmp As New Bitmap(stream)
                stream.Close()
                pbImg1.Image = bmp
            Else
                pbImg1.Image = Nothing
            End If
        Else
            pbImg1.Image = Nothing
        End If


        tmpds.Clear()
        sql_query = "Select Id,Image1 from tbl_ImageMaster where MasterId = " & Val(lblCompanyId.Text) & " and ImageType = 'PaymentQR1'"
        obj.LoadData(sql_query, tmpds)

        If tmpds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(tmpds.Tables(0).Rows(0)("Image1")) = False Then
                Dim imgByteArray() As Byte
                imgByteArray = CType(tmpds.Tables(0).Rows(0)("Image1"), Byte())
                Dim stream As New MemoryStream(imgByteArray)
                Dim bmp As New Bitmap(stream)
                stream.Close()
                pbPaymentQR1.Image = bmp
            Else
                pbPaymentQR1.Image = Nothing
            End If
        Else
            pbPaymentQR1.Image = Nothing
        End If

    End Sub

    Public Sub getCompanyCode()
        'lblCode.Text = obj.ScalarExecute("Select IsNull(Max(CID),0) + 1 From Tbl_CompanyMaster)
        'txtCompanyCode.Text = _LedgerCodeInitial & StrDup(5 - Trim(lblCode.Text).Length, "0") & Trim(lblCode.Text)
    End Sub

#End Region

#Region "function"

    Public Function checkCompanyCode() As Boolean
        If M_AllwDupLcode = "Yes" Then
            Return False
        End If

        If edit_ins = 1 Then
            existCompanyCode = obj.ScalarExecute("select CCode from tbl_CompanyMaster where CId = " & M_CId & " And CCode='" & Trim(txtCompanyCode.Text) & "'")
            If Trim(txtCompanyCode.Text) = existCompanyCode Then
                Return True
            Else
                Return False
            End If
        Else
            existCompanyCode = obj.ScalarExecute("select CCode from tbl_CompanyMaster where CId = " & M_CId & " And CId <>" & Val(lblCompanyId.Text) & " and CCode='" & Trim(txtCompanyCode.Text) & "'")
            If Trim(txtCompanyCode.Text) = existCompanyCode Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

#End Region

#Region "Events"

    Private Sub FrmLedgerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case M_LedgerMasterF2
            Case True
                loadTime()
                addClickTime()
                Exit Select
            Case False
                loadTime()
                Exit Select
        End Select

        Dim mos As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
        For Each mo As ManagementObject In mos.Get()
            Dim serial As String = mo("SerialNumber").ToString()
            Select Case Trim(serial)
                Case "20246G446307"
                    btnAdd.Visible = True
                    btnDelete.Visible = True
                    Exit Select
                Case Else
                    btnAdd.Visible = False
                    btnDelete.Visible = False
                    Exit Select
            End Select
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If checkRightsToAdd("COMPANY MASTER") = False Then
            MsgBox("Unable To Add New Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        addClickTime()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If checkRightsToEdit("COMPANY MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(txtCompanyCode.Text) = "" Then
            MsgBox("Please Specify Company Code", MsgBoxStyle.Information)
            txtCompanyCode.Focus()
            Exit Sub
        End If
        If Trim(txtCompanyName.Text) = "" Then
            MsgBox("Please Specify Company Name", MsgBoxStyle.Information)
            txtCompanyName.Focus()
            Exit Sub
        End If
        If checkCompanyCode() = True Then
            MsgBox("Company Code Already Exists, Please Specify Another One", MsgBoxStyle.Critical)
            txtCompanyCode.Focus()
            Exit Sub
        End If

        If edit_ins = 1 Then
            If Trim(txtUserName.Text) = "" Then
                MsgBox("Please Specify User Name", MsgBoxStyle.Information)
                txtUserName.Focus()
                Exit Sub
            End If
            If Trim(txtUserPwd.Text) = "" Then
                MsgBox("Please Specify User Password", MsgBoxStyle.Information)
                txtUserPwd.Focus()
                Exit Sub
            End If

            insert()
        Else
            edit()
        End If

        saveClickTime()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkRightsToDelete("COMPANY MASTER") = False Then
            MsgBox("Unable To Delete Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dr As DialogResult
        dr = MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            del()
            deleteClickTime()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        cancelClickTime()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        exitClickTime()
    End Sub

    Private Sub grdData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellClick
        fillData()
        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub grdData_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyUp
        fillData()
        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub grdData_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        fillData()
        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False

        If checkRightsToEdit("COMPANY MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If
        editClickTime()
    End Sub

#End Region

#Region "Navigation"

    Private Sub txtCompanyCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompanyCode.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(txtCompanyCode.Text) = "" Then
                Exit Sub
            End If
            txtCompanyName.Focus()
        End If
    End Sub

    Private Sub txtCompanyName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompanyName.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(txtCompanyName.Text) = "" Then
                Exit Sub
            End If
            txtAdd1.Focus()
        End If
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress, txtAdd1.KeyPress, txtAdd2.KeyPress, txtCountry.KeyPress, txtPincode.KeyPress, txtPhone.KeyPress, txtFax.KeyPress, txtEMailId.KeyPress, txtGSTNo.KeyPress, txtPANNo.KeyPress, txtMobileNo1.KeyPress, txtMobileNo2.KeyPress, txtWebsite.KeyPress, txtInstagram.KeyPress, txtFacebook.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtState_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtState.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
            M_SearchText = e.KeyChar
            M_callingForm_MiscHelp = "BusinessProfile" & sender.tag & "Help"
            'FrmHelpMiscList.ShowDialog()
        End If
    End Sub

    Private Sub txtF_CompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gridfill()
    End Sub

#Region "City/State/Country Help"

    Private Sub txtState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtState.KeyDown, txtCity.KeyDown, txtCountry.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                M_callingForm_MiscHelp = "BusinessProfile" & sender.tag & "Help"
                'FrmHelpMiscList.ShowDialog()
                Exit Select
            Case Keys.F2
                If Trim(sender.Text) = "" Then
                    MsgBox("Please Specify " & sender.Tag, MsgBoxStyle.Information)
                    Exit Sub
                End If

                If M_checkMiscMaster(sender.Tag, Trim(sender.Text)) = False Then
                    insertMiscMaster(sender.Tag, Trim(sender.Text))
                    MsgBox(sender.Tag & " Added Successfully", MsgBoxStyle.Information)
                Else
                    MsgBox(sender.Tag & " Already Exist", MsgBoxStyle.Information)
                End If
                Exit Select
        End Select
    End Sub

    Private Sub txtState_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtState.DoubleClick, txtCity.DoubleClick, txtCountry.DoubleClick
        M_callingForm_MiscHelp = "BusinessProfile" & sender.tag & "Help"
        'FrmHelpMiscList.ShowDialog()
    End Sub

#End Region



#End Region

    Private Sub txtImgPath1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles txtImgPath1.DoubleClick
        txtImgPath1.Text = M_getImagePath(Me)
        pbImg1.ImageLocation = txtImgPath1.Text
    End Sub

    Private Sub txtPaymentQR1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles txtPaymentQR1.DoubleClick
        txtPaymentQR1.Text = M_getImagePath(Me)
        pbPaymentQR1.ImageLocation = txtPaymentQR1.Text
    End Sub

    Private Sub txtImgPath1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtImgPath1.KeyPress, txtPaymentQR1.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtImgPath1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtImgPath1.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                txtImgPath1.Text = M_getImagePath(Me)
                pbImg1.ImageLocation = txtImgPath1.Text
                Exit Select
            Case Keys.Delete
                Dim dr As DialogResult
                dr = MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo)
                If dr = Windows.Forms.DialogResult.Yes Then
                    pbImg1.Image = Nothing
                    txtImgPath1.Clear()
                    sql_query = "Delete from tbl_ImageMaster where MasterId = " & Val(lblCompanyId.Text) & " And ImageType = 'CompanyImage'"
                    obj.QueryExecute(sql_query)
                    cancelClickTime()
                End If
                Exit Select
        End Select
    End Sub

    Private Sub txtPaymentQR1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaymentQR1.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                txtPaymentQR1.Text = M_getImagePath(Me)
                pbPaymentQR1.ImageLocation = txtPaymentQR1.Text
                Exit Select
            Case Keys.Delete
                Dim dr As DialogResult
                dr = MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo)
                If dr = Windows.Forms.DialogResult.Yes Then
                    pbPaymentQR1.Image = Nothing
                    txtPaymentQR1.Clear()
                    sql_query = "Delete from tbl_ImageMaster where MasterId = " & Val(lblCompanyId.Text) & " And ImageType = 'PaymentQR1'"
                    obj.QueryExecute(sql_query)
                    cancelClickTime()
                End If
                Exit Select
        End Select
    End Sub

    Public Sub InsertCustomerImage(ByVal ledgerId As Integer, _ImageType As String)
        obj.Prepare("SP_InsertImageMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsImageType", Dtype.varchar, _ImageType, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMasterId", Dtype.int, ledgerId, ParaDirection.Input, True)

        If IsNothing(pbImg1.Image) = True Then
            obj.AddCmdParameter("@InsImage1", Dtype.img, DBNull.Value, ParaDirection.Input, True)
        Else
            Dim imgByteArray() As Byte
            Dim stream As New MemoryStream
            Dim bmp As New Bitmap(Trim(txtImgPath1.Text))

            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
            imgByteArray = stream.ToArray()
            stream.Close()
            obj.AddCmdParameter("@InsImage1", Dtype.img, imgByteArray, ParaDirection.Input, True)
        End If

        obj.AddCmdParameter("@InsImage2", Dtype.img, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsImage3", Dtype.img, DBNull.Value, ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

    Public Sub InsertPaymentQR(ByVal ledgerId As Integer, _ImageType As String)
        obj.Prepare("SP_InsertImageMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsImageType", Dtype.varchar, _ImageType, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMasterId", Dtype.int, ledgerId, ParaDirection.Input, True)

        If IsNothing(pbPaymentQR1.Image) = True Then
            obj.AddCmdParameter("@InsImage1", Dtype.img, DBNull.Value, ParaDirection.Input, True)
        Else
            Dim imgByteArray() As Byte
            Dim stream As New MemoryStream
            Dim bmp As New Bitmap(Trim(txtPaymentQR1.Text))

            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
            imgByteArray = stream.ToArray()
            stream.Close()
            obj.AddCmdParameter("@InsImage1", Dtype.img, imgByteArray, ParaDirection.Input, True)
        End If

        obj.AddCmdParameter("@InsImage2", Dtype.img, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsImage3", Dtype.img, DBNull.Value, ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub


    Private Sub btnSaveImage_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveImage.Click
        If Trim(txtImgPath1.Text).Length > 0 Then
            sql_query = "Delete from tbl_ImageMaster where MasterId = " & Val(lblCompanyId.Text) & " And ImageType = 'CompanyImage'"
            obj.QueryExecute(sql_query)
            InsertCustomerImage(Val(lblCompanyId.Text), "CompanyImage")

            obj.QueryExecute("Update tbl_CompanyMaster set ImagePath='" & txtImgPath1.Text & "' where CId=" & lblCompanyId.Text)
            MsgBox("Logo Updated Successfully", MsgBoxStyle.Information)
        Else
            MsgBox("Please Select Image Proper!", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub

    Private Sub btnUpdatePmtQR_Click(sender As Object, e As EventArgs) Handles btnUpdatePmtQR.Click
        If Trim(txtImgPath1.Text).Length > 0 Then
            sql_query = "Delete from tbl_ImageMaster where MasterId = " & Val(lblCompanyId.Text) & " And ImageType = 'PaymentQR1'"
            obj.QueryExecute(sql_query)
            InsertPaymentQR(Val(lblCompanyId.Text), "PaymentQR1")

            obj.QueryExecute("Update tbl_CompanyMaster set PaymentQR1='" & txtPaymentQR1.Text & "' where CId=" & lblCompanyId.Text)
            MsgBox("Payment QR Updated Successfully", MsgBoxStyle.Information)
        Else
            MsgBox("Please Select Image Proper!", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub

    Private Sub grdData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim iCode As String
            iCode = InputBox("Enter Details", "Add Company", "0")
            If UCase(iCode) = "ALLOW" Then
                cancelClickTime()
                addClickTime()
            End If
        End If
    End Sub


End Class