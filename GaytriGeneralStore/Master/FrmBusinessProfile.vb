Imports GaytriGeneralStore.GaytriGeneral.DB
Imports System.IO
Imports DevExpress.Utils

Public Class FrmBusinessProfile

#Region "Comments"
    'Name:BadasaabFashions
    'Created By:Manav
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
    Dim oldCompanyCode As String 'Ledger name Maintained Uniquely
    Dim point As Boolean = False
    Dim _LedgerCodeInitial As String = ""
#End Region

#Region "Method"

    Public Sub formatGrid()
        gvData.Columns("CId").Visible = False
        gvData.Columns("CCode").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        gvData.Columns("CCode").Caption = "Company Code"
        gvData.Columns("CName").Caption = "Company Name"
        gvData.Columns("Add1").Caption = "Address"
        gvData.Columns("Add2").Visible = False
        gvData.Columns("Pincode").Visible = False
        gvData.Columns("Country").Visible = False
        gvData.Columns("PhNo").Visible = False
        gvData.Columns("FaxNo").Visible = False
        gvData.Columns("EMail").Visible = False
        gvData.Columns("PANNo").Visible = False
        gvData.Columns("ServiceTaxNo").Visible = False
        gvData.Columns("ECCNo").Visible = False
        gvData.Columns("CSTTinNo").Visible = False
        gvData.Columns("GSTTinNo").Visible = False
        gvData.Columns("Invoice").Visible = False
        gvData.Columns("TC1").Visible = False
        gvData.Columns("TC2").Visible = False
        gvData.Columns("TC3").Visible = False
        gvData.Columns("TC4").Visible = False
        gvData.Columns("TC5").Visible = False
        gvData.Columns("TC6").Visible = False
        gvData.Columns("TC7").Visible = False
        gvData.Columns("ForCo").Visible = False
        gvData.Columns("BankName").Visible = False
        gvData.Columns("BankAcNo").Visible = False
        gvData.Columns("BranchCode").Visible = False
        gvData.Columns("IFSCCode").Visible = False
        gvData.Columns("ImagePath").Visible = False
        gvData.Columns("MobileNo1").Visible = False
        gvData.Columns("MobileNo2").Visible = False
        gvData.Columns("Website").Visible = False
        gvData.Columns("Facebook").Visible = False
        gvData.Columns("Instagram").Visible = False
        gvData.Columns("Youtube").Visible = False
        gvData.Columns("PaymentQR1").Visible = False
        gvData.Columns("PaymentQR2").Visible = False
    End Sub

    Public Sub gridfill()
        ds.Clear()
        sql_query = "Select * From View_CompanyMaster Order By CName"
        obj.LoadData(sql_query, ds)
        gcData.DataSource = ds.Tables(0).DefaultView

        gvData.OptionsView.ColumnAutoWidth = False
        gvData.BestFitColumns()

        gvData.Columns("CName").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        gvData.Columns("CName").SummaryItem.DisplayFormat = "{0}"

        formatGrid()
        RestoreLayout(gvData, "BussinessProfile")
    End Sub

    Public Sub insert()
        obj.Prepare("SP_InsertCompanyMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsCCode", Dtype.varchar, Trim(txtCompanyCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCName", Dtype.varchar, Trim(txtCompanyName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAdd1", Dtype.varchar, Trim(txtAdd1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAdd2", Dtype.varchar, Trim(txtAdd2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCity", Dtype.varchar, Trim(txtCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsState", Dtype.varchar, Trim(txtState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPinCode", Dtype.varchar, Trim(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCountry", Dtype.varchar, Trim(txtCountry.Text), ParaDirection.Input, True)
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
        obj.AddCmdParameter("@InsTC7", Dtype.nvarchar, Trim(txtTC7.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsForCo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsImagePath", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMobileNo1", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMobileNo2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsWebsite", Dtype.varchar, Trim(txtWebsite.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsFacebook", Dtype.varchar, Trim(txtFacebook.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsInstagram", Dtype.varchar, Trim(txtInstagram.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsYoutube", Dtype.varchar, Trim(txtYoutube.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPaymentQR1", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPaymentQR2", Dtype.varchar, "", ParaDirection.Input, True)

        obj.ExecuteCommand()

        sql_query = "Select IsNull(Max(CId),0) From tbl_CompanyMaster Where CCode = '" & Trim(txtCompanyCode.Text) & "'"
        lblCompanyId.Text = obj.ScalarExecute(sql_query)
        'InsertCustomerImage(Val(lblCompanyId.Text))

        Dim minCId As Integer
        sql_query = "Select Min(CId) From Tbl_CompanyMaster "
        minCId = obj.ScalarExecute(sql_query)

        'sql_query = "Select Max(CId) From Tbl_CompanyMaster Where CName = '" & Trim(txtCompanyName.Text) & "'"
        'lblCompanyId.Text = obj.ScalarExecute(sql_query)

        'Default Ledger Creation
        sql_query = "Insert Into tbl_LedgerMaster (Code, LedgerCode, LedgerName, G_Id, Address1, Address2, City, PinCode, State, Country, PhoneNo, MobileNo, FaxNo, EMail, BirthDate, AnniDate, CustType, MobileNo2, BeneficiaryName, BankAcType, BankAcNo, IFSCCode, MICRCode, BankName, BankAddress, AcContactPerson, AcContactNo, AcEmailId, TranSMS, PromoSMS, GSTNo, PANNo, Taxation, CId, IsCompany) " _
            & "Select Code, LedgerCode, LedgerName, G_Id, Address1, Address2, City, PinCode, State, Country, PhoneNo, MobileNo, FaxNo, EMail, BirthDate, AnniDate, CustType, MobileNo2, BeneficiaryName, BankAcType, BankAcNo, IFSCCode, MICRCode, BankName, BankAddress, AcContactPerson, AcContactNo, AcEmailId, TranSMS, PromoSMS, GSTNo, PANNo, Taxation, " & Val(lblCompanyId.Text) & ", IsCompany From tbl_LedgerMaster Where AcEmailId = 'DefaultLedger' And CId = " & minCId
        obj.QueryExecute(sql_query)

        'Settings Creation
        sql_query = "Insert Into tbl_Settings (SettingName, SettingValue, CId) " _
            & "Select SettingName, SettingValue, " & Val(lblCompanyId.Text) & " From tbl_Settings Where CId = " & minCId
        obj.QueryExecute(sql_query)

        'Misc Master Creation
        sql_query = "Insert Into tbl_MiscMaster (MiscType, MiscName, Data1, Data2, DispSrNo, CId, IsActive) " _
            & "Select MiscType, MiscName, Data1, Data2, DispSrNo, " & Val(lblCompanyId.Text) & ", IsActive From tbl_MiscMaster Where CId = " & minCId
        obj.QueryExecute(sql_query)

        'Branch Master Creation
        sql_query = "Insert Into tbl_BranchMaster (CId, BCode, BName, Add1, Add2, City, State, Pincode, Country, PhNo, FaxNo, EMail, PANNo, ServiceTaxNo, ECCNo, CSTTinNo, GSTTinNo, Invoice, TC1, TC2, TC3, TC4, TC5, TC6, TC7, ForCo, BankName, BankAcNo, BranchCode, IFSCCode, ImagePath, AuthSign, AuthDesig, Pwd, CPwd, SMTP, PORT) " _
            & "SELECT " & Val(M_CId) & ", '" & Trim(txtCompanyCode.Text) & "', '" & Trim(txtCompanyName.Text) & "', '" & Trim(txtAdd1.Text) & "', '" & Trim(txtAdd2.Text) & "', '" & Trim(txtCity.Text) & "', '" & Trim(txtState.Text) & "', '" & Trim(txtPincode.Text) & "', '" & Trim(txtCountry.Text) & "', '" & Trim(txtPhone.Text) & "', '" & Trim(txtFax.Text) & "', '" & Trim(txtEMailId.Text) & "', '" & Trim(txtPANNo.Text) & "', '', ECCNo, CSTTinNo, '" & Trim(txtGSTNo.Text) & "', Invoice, TC1, TC2, TC3, TC4, TC5, TC6, TC7, ForCo, BankName, BankAcNo, BranchCode, IFSCCode, ImagePath, AuthSign, AuthDesig, Pwd, CPwd, SMTP, PORT FROM tbl_BranchMaster Where CId = " & minCId
        obj.QueryExecute(sql_query)

        Dim tmpResult As String
        Dim in_IGST, in_CGST, in_SGST, out_IGST, out_CGST, out_SGST As String

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

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'Transport Service Income Id' And CId = " & Val(lblCompanyId.Text)
        Dim tmpTransportServiceIncomeId As Integer = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & tmpTransportServiceIncomeId & "' Where SettingName = 'Transport Service Income Id' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============

        sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = 'Transport Service Expense Id' And CId = " & Val(lblCompanyId.Text)
        Dim tmpTransportServiceExpenseId As Integer = obj.ScalarExecute(sql_query)

        sql_query = "Update tbl_Settings Set SettingValue = '" & tmpTransportServiceExpenseId & "' Where SettingName = 'Transport Service Expense Id' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        '===============

        sql_query = "Update tbl_Settings Set SettingValue = '(" & in_IGST & "," & in_CGST & "," & in_SGST & "," & out_IGST & "," & out_CGST & "," & out_SGST & ")' Where SettingName = 'GST Ledger Id List' And CId = " & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)

        FrmMDIMain.ComboFill(FrmMDIMain.cmbCName, "Select CId, CName From tbl_CompanyMaster Order By CId")
    End Sub

    Public Sub insertMiscMaster(ByVal _MiscType As String, ByVal _MiscName As String)
        sql_query = "Insert into tbl_MiscMaster (MiscType, MiscName, CId, IsActive) values ('" & _MiscType & "','" & _MiscName & "'," & M_CId & ",'True')"
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub edit() 'Company Id is not Updated
        obj.Prepare("SP_UpdateCompanyMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@UpCCode", Dtype.varchar, Trim(txtCompanyCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCName", Dtype.varchar, Trim(txtCompanyName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAdd1", Dtype.varchar, Trim(txtAdd1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAdd2", Dtype.varchar, Trim(txtAdd2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCity", Dtype.varchar, Trim(txtCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpState", Dtype.varchar, Trim(txtState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPinCode", Dtype.varchar, Trim(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCountry", Dtype.varchar, Trim(txtCountry.Text), ParaDirection.Input, True)
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
        obj.AddCmdParameter("@UpTC7", Dtype.nvarchar, Trim(txtTC7.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpForCo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCID", Dtype.varchar, Trim(lblCompanyId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpImagePath", Dtype.varchar, Trim(txtImgPath1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo1", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpWebsite", Dtype.varchar, Trim(txtWebsite.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpFacebook", Dtype.varchar, Trim(txtFacebook.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpInstagram", Dtype.varchar, Trim(txtInstagram.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpYoutube", Dtype.varchar, Trim(txtYoutube.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPaymentQR1", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPaymentQR2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.ExecuteCommand()

        sql_query = "Select Count(*) from tbl_BranchMaster where CId = " & Val(lblCompanyId.Text)
        If obj.ScalarExecute(sql_query) = 0 Then
            insert_Branch()
        Else
            Dim dr As DialogResult
            dr = MsgBox("Sure To Modify Branch Details ?", MsgBoxStyle.YesNo)
            If dr = Windows.Forms.DialogResult.Yes Then
                edit_Branch()
            End If
        End If
    End Sub

    Public Sub insert_Branch()
        Try
            obj.Prepare("SP_InsertBranchMaster", SpType.StoredProcedure)
            obj.AddCmdParameter("@InsCId", Dtype.int, Val(lblCompanyId.Text), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsBCode", Dtype.varchar, txtCompanyCode.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsBName", Dtype.varchar, txtCompanyName.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsAdd1", Dtype.varchar, txtAdd1.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsAdd2", Dtype.varchar, txtAdd2.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsCity", Dtype.varchar, txtCity.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsState", Dtype.varchar, txtState.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsPincode", Dtype.varchar, txtPincode.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsCountry", Dtype.varchar, txtCountry.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsPhNo", Dtype.varchar, txtPhone.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsFaxNo", Dtype.varchar, txtFax.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsEMail", Dtype.varchar, txtEMailId.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsPANNo", Dtype.varchar, txtPANNo.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsServiceTaxNo", Dtype.varchar, "", ParaDirection.Input, True)
            obj.AddCmdParameter("@InsECCNo", Dtype.varchar, txtECCNo.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsCSTTinNo", Dtype.varchar, "", ParaDirection.Input, True)
            obj.AddCmdParameter("@InsGSTTinNo", Dtype.varchar, txtGSTNo.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsInvoice", Dtype.varchar, "", ParaDirection.Input, True)
            obj.AddCmdParameter("@InsBankName", Dtype.varchar, txtBankName.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsBankAcNo", Dtype.varchar, txtBankAcNo.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsBranchCode", Dtype.varchar, txtBranchCode.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsIFSCCode", Dtype.varchar, txtIFSCCode.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsTC1", Dtype.nvarchar, txtTC1.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsTC2", Dtype.nvarchar, txtTC2.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsTC3", Dtype.nvarchar, txtTC3.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsTC4", Dtype.nvarchar, txtTC4.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsTC5", Dtype.nvarchar, txtTC5.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsTC6", Dtype.nvarchar, "", ParaDirection.Input, True)
            obj.AddCmdParameter("@InsTC7", Dtype.nvarchar, txtTC7.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsForCo", Dtype.varchar, "", ParaDirection.Input, True)
            obj.AddCmdParameter("@InsImagePath", Dtype.varchar, txtImgPath1.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsAuthSign", Dtype.varchar, "", ParaDirection.Input, True)
            obj.AddCmdParameter("@InsAuthDesig", Dtype.varchar, "", ParaDirection.Input, True)
            Dim hashedPwd As String = txtPwd.Text.Trim()
            obj.AddCmdParameter("@InsPwd", Dtype.varchar, hashedPwd, ParaDirection.Input, True)
            obj.AddCmdParameter("@InsCPwd", Dtype.varchar, txtCPwd.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsSMTP", Dtype.varchar, txtSMTP.Text.Trim(), ParaDirection.Input, True)
            obj.AddCmdParameter("@InsPort", Dtype.varchar, txtPortNo.Text.Trim(), ParaDirection.Input, True)
            obj.ExecuteCommand()

            MsgBox("Branch Inserted Successfully")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub edit_Branch() 'Company Id is not Updated
        obj.Prepare("SP_UpdateBranchMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@UpCID", Dtype.int, Trim(lblCompanyId.Text), ParaDirection.Input, True) 'M_CId
        obj.AddCmdParameter("@UpBCode", Dtype.varchar, Trim(txtCompanyCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBName", Dtype.varchar, Trim(txtCompanyName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAdd1", Dtype.varchar, Trim(txtAdd1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAdd2", Dtype.varchar, Trim(txtAdd2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCity", Dtype.varchar, Trim(txtCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpState", Dtype.varchar, Trim(txtState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPinCode", Dtype.varchar, Trim(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCountry", Dtype.varchar, Trim(txtCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPhNo", Dtype.varchar, Trim(txtPhone.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpFaxNo", Dtype.varchar, Trim(txtFax.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpEMail", Dtype.varchar, Trim(txtEMailId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPANNo", Dtype.varchar, Trim(txtPANNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpServiceTaxNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpECCNo", Dtype.varchar, Trim(txtECCNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCSTTinNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpGSTTinNo", Dtype.varchar, Trim(txtGSTNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpInvoice", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC1", Dtype.nvarchar, Trim(txtTC1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC2", Dtype.nvarchar, Trim(txtTC2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC3", Dtype.nvarchar, Trim(txtTC3.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC4", Dtype.nvarchar, Trim(txtTC4.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC5", Dtype.nvarchar, Trim(txtTC5.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC6", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTC7", Dtype.nvarchar, Trim(txtTC7.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpForCo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankName", Dtype.varchar, Trim(txtBankName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAcNo", Dtype.varchar, Trim(txtBankAcNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBranchCode", Dtype.varchar, Trim(txtBranchCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIFSCCode", Dtype.varchar, Trim(txtIFSCCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpImagePath", Dtype.varchar, Trim(txtImgPath1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAuthSign", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAuthDesig", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPwd", Dtype.varchar, Trim(txtPwd.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCPwd", Dtype.varchar, Trim(txtCPwd.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSMTP", Dtype.varchar, Trim(txtSMTP.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPort", Dtype.varchar, Trim(txtPortNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBranchId", Dtype.int, Val(lblCompanyId.Text), ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

    Public Sub del()
        sql_query = "delete from tbl_CompanyMaster where CId =" & Val(lblCompanyId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub loadTime()
        gridfill()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        gcData.Enabled = True
        gbMainDetail.Enabled = False

        If M_MyPc = True Then
            btnAdd.Visible = True
            btnDelete.Visible = True
        Else
            btnAdd.Visible = False
            btnDelete.Visible = False
        End If
    End Sub

    Public Sub addClickTime()
        gbMainDetail.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        getCompanyCode()
        txtCompanyCode.Focus()
        txtState.Text = M_CState

        edit_ins = 1
    End Sub

    Public Sub editClickTime()
        gbMainDetail.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        edit_ins = 0
        oldCompanyCode = Trim(txtCompanyCode.Text)
        txtCompanyCode.Focus()
    End Sub

    Public Sub saveClickTime()
        gridfill()
        gbMainDetail.Enabled = False
        gcData.Enabled = True

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
        txtTC7.Clear()
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
        'txtAuthSign.Clear()
        'txtAuthDesig.Clear()
        txtECCNo.Clear()
        txtBankName.Clear()
        txtBankAcNo.Clear()
        txtIFSCCode.Clear()
        txtBranchCode.Clear()
        txtImgPath1.Clear()
        txtPwd.Clear()
        txtCPwd.Clear()
        txtSMTP.Clear()
        txtPortNo.Clear()
        pbImg1.Image = Nothing
        edit_ins = -1
    End Sub

    Public Sub deleteClickTime()
        gridfill()
        gbMainDetail.Enabled = False
        gcData.Enabled = True

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
        txtTC7.Clear()
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
        'txtAuthSign.Clear()
        'txtAuthDesig.Clear()
        txtBankName.Clear()
        txtBankAcNo.Clear()
        txtIFSCCode.Clear()
        txtBranchCode.Clear()
        txtImgPath1.Clear()
        txtPwd.Clear()
        txtCPwd.Clear()
        txtSMTP.Clear()
        txtPortNo.Clear()
        pbImg1.Image = Nothing
        edit_ins = -1
    End Sub

    Public Sub cancelClickTime()
        gbMainDetail.Enabled = False
        gcData.Enabled = True

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
        'txtAuthDesig.Clear()
        'txtAuthSign.Clear()
        txtECCNo.Clear()
        txtTC1.Clear()
        txtTC2.Clear()
        txtTC3.Clear()
        txtTC4.Clear()
        txtTC5.Clear()
        txtTC7.Clear()
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
        txtPwd.Clear()
        txtCPwd.Clear()
        txtSMTP.Clear()
        txtPortNo.Clear()
        pbImg1.Image = Nothing
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
        If gvData.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        lblCompanyId.Text = gvData.GetFocusedRowCellValue("CId")
        txtCompanyCode.Text = gvData.GetFocusedRowCellValue("CCode")
        txtCompanyName.Text = gvData.GetFocusedRowCellValue("CName")
        txtAdd1.Text = gvData.GetFocusedRowCellValue("Add1")
        txtAdd2.Text = gvData.GetFocusedRowCellValue("Add2")
        txtCity.Text = gvData.GetFocusedRowCellValue("City")
        txtPincode.Text = gvData.GetFocusedRowCellValue("Pincode")
        txtState.Text = gvData.GetFocusedRowCellValue("State")
        txtCountry.Text = gvData.GetFocusedRowCellValue("Country")
        txtGSTNo.Text = gvData.GetFocusedRowCellValue("GSTTinNo")
        txtPANNo.Text = gvData.GetFocusedRowCellValue("PANNo")
        txtPhone.Text = gvData.GetFocusedRowCellValue("PhNo")
        txtFax.Text = gvData.GetFocusedRowCellValue("FaxNo")
        txtEMailId.Text = gvData.GetFocusedRowCellValue("EMail")
        'txtAuthSign.Text = gvData.GetFocusedRowCellValue("AuthSign")
        'txtAuthDesig.Text = gvData.GetFocusedRowCellValue("AuthDesig")
        txtECCNo.Text = gvData.GetFocusedRowCellValue("ECCNo")
        txtTC1.Text = gvData.GetFocusedRowCellValue("TC1")
        txtTC2.Text = gvData.GetFocusedRowCellValue("TC2")
        txtTC3.Text = gvData.GetFocusedRowCellValue("TC3")
        txtTC4.Text = gvData.GetFocusedRowCellValue("TC4")
        txtTC5.Text = gvData.GetFocusedRowCellValue("TC5")
        txtTC7.Text = gvData.GetFocusedRowCellValue("TC7")
        txtBankName.Text = gvData.GetFocusedRowCellValue("BankName")
        txtBankAcNo.Text = gvData.GetFocusedRowCellValue("BankAcNo")
        txtBranchCode.Text = gvData.GetFocusedRowCellValue("BranchCode")
        txtIFSCCode.Text = gvData.GetFocusedRowCellValue("IFSCCode")
        txtImgPath1.Text = gvData.GetFocusedRowCellValue("ImagePath")
        txtPwd.Text = gvData.GetFocusedRowCellValue("Pwd")
        txtCPwd.Text = gvData.GetFocusedRowCellValue("CPwd")
        txtSMTP.Text = gvData.GetFocusedRowCellValue("SMTP")
        txtPortNo.Text = gvData.GetFocusedRowCellValue("PORT")
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
        txtCity.CharacterCasing = CharacterCasing.Upper

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

        If txtPwd.Text <> txtCPwd.Text Then
            MsgBox("Password Not Match.", MsgBoxStyle.Critical)
            txtPwd.Focus()
            Exit Sub
        End If

        If edit_ins = 1 Then
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

    Private Sub gvData_Click(sender As System.Object, e As System.EventArgs) Handles gvData.Click
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length = 0 Then
            Exit Sub
        End If
        fillData()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub gvData_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvData.DoubleClick
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length = 0 Then
            Exit Sub
        End If
        fillData()
        M_loadUserRights()
        If FrmMDIMain.cmbFinYr.SelectedIndex <> 0 And checkRightsToAllowPrevYearTran("COMPANY MASTER") = False Then
            MsgBox("Unable To Edit Record in Locked Financial Year", MsgBoxStyle.Information)
            Exit Sub
        End If

        If checkRightsToEdit("COMPANY MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()
    End Sub

    Private Sub gvData_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvData.KeyUp
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length = 0 Then
            Exit Sub
        End If
        fillData()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False
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

    Private Sub txtCity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress, txtAdd1.KeyPress, txtAdd2.KeyPress, txtCountry.KeyPress, txtPincode.KeyPress, txtPhone.KeyPress, txtFax.KeyPress, txtEMailId.KeyPress, txtGSTNo.KeyPress, txtPANNo.KeyPress, txtSMTP.KeyPress, txtPwd.KeyPress, txtPortNo.KeyPress, txtCPwd.KeyPress
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
            M_callingForm_MiscHelp = "BusinessProfile_" & sender.tag & "Help"
            FrmHelpMiscList.ShowDialog()
        End If
    End Sub

    Private Sub txtF_CompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gridfill()
    End Sub

#Region "City/State/Country Help"

    Private Sub txtState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtState.KeyDown, txtCity.KeyDown, txtCountry.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                M_callingForm_MiscHelp = "BusinessProfile_" & sender.tag & "Help"
                FrmHelpMiscList.ShowDialog()
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
        M_callingForm_MiscHelp = "BusinessProfile_" & sender.tag & "Help"
        FrmHelpMiscList.ShowDialog()
    End Sub

#End Region

#End Region

    Private Sub txtImgPath1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles txtImgPath1.DoubleClick
        txtImgPath1.Text = M_getImagePath(Me)
        pbImg1.ImageLocation = txtImgPath1.Text
    End Sub

    Private Sub txtImgPath1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtImgPath1.KeyPress
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

    Public Sub InsertCustomerImage(ByVal ledgerId As Integer)
        obj.Prepare("SP_InsertImageMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsImageType", Dtype.varchar, "CompanyImage", ParaDirection.Input, True)
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

    Private Sub btnSaveImage_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveImage.Click
        If Trim(txtImgPath1.Text).Length > 0 Then
            sql_query = "Delete from tbl_ImageMaster where MasterId = " & Val(lblCompanyId.Text) & " And ImageType = 'CompanyImage'"
            obj.QueryExecute(sql_query)
            InsertCustomerImage(Val(lblCompanyId.Text))

            obj.QueryExecute("Update tbl_CompanyMaster set ImagePath='" & txtImgPath1.Text & "' where CId=" & lblCompanyId.Text)
            MsgBox("Logo Updated Successfully", MsgBoxStyle.Information)
        Else
            MsgBox("Please Select Image Proper!", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub

    Private Sub gvData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvData.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                Dim iCode As String
                iCode = InputBox("Enter Details", "Add Company", "0")
                If UCase(iCode) = "ALLOW" Then
                    cancelClickTime()
                    addClickTime()
                End If
                Exit Select
            Case Keys.F8
                btnAdd.Visible = True
                btnDelete.Visible = True
                Exit Select
            Case Keys.F10
                btnAdd.Visible = False
                btnDelete.Visible = False
                Exit Select
        End Select
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog()
        If sfd.ShowDialog() = DialogResult.OK Then
            gvData.ExportToXls(sfd.FileName & ".xls")
        End If
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvData, "BussinessProfile", Me)
    End Sub

End Class