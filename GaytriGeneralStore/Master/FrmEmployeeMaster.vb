Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmEmployeeMaster

#Region "Comments"
    'Name:Gaytri
    'Created By:Manav
    'Form:FrmEmployeeMaster
    'Date:09/03/2026
#End Region

#Region "Declaration"
    Dim ds As New Data.DataSet
    Dim dsComboGM As New Data.DataSet
    Dim dsCmbCity As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String
    Dim edit_ins As Integer = -1
    Dim existLedgerCode As String
    Dim oldLedgerCode As String
    Dim point As Boolean = False
    Dim _LedgerCodeInitial As String = ""
    Dim dv As New DataView
    Dim dt As New DataTable
#End Region

#Region "Methods"

    Public Sub GridFill(ByVal _refresh As Boolean)
        Dim _filter As String = ""
        ds.Clear()
        'sql_query = "Select * From  View_LedgerMaster" _
        '    & " Where G_Id = 30 And (LedgerName Like N'" & Trim(txtSearch.Text) & "%' OR MobileNo Like N'%" & Trim(txtSearch.Text) & "%')  " & _filter & " Order By Code Desc"

        'obj.LoadData(sql_query, ds)
        'gcData.DataSource = ds.Tables(0).DefaultView
        If _refresh = True Then
            loadLedgerMaster()
            dv = New DataView(dsLedgerMaster.Tables(0))
            dv.RowFilter = "G_Id = 30 And (LedgerName Like '" & Trim(txtSearch.Text) & "%' OR MobileNo Like '%" & Trim(txtSearch.Text) & "%') " & _filter
            dt = dv.ToTable()
        Else
            dv.RowFilter = "G_Id = 30 And (LedgerName Like '" & Trim(txtSearch.Text) & "%' OR MobileNo Like '%" & Trim(txtSearch.Text) & "%') " & _filter
            dt = dv.ToTable()
        End If

        gcData.DataSource = dt.DefaultView

        gvData.OptionsView.ColumnAutoWidth = False
        gvData.BestFitColumns()

        formatGrid()

        RestoreLayout(gvData, "EmployeeMaster")
        lblTotalRecords.Text = "📋 " & gvData.RowCount & " Records"

    End Sub

    Public Sub ComboFill(ByVal cmb As ComboBox, ByVal sql As String)
        Dim dsCmb As New Data.DataSet
        dsCmb.Clear()
        sql_query = sql
        obj.LoadData(sql_query, dsCmb)
        cmb.DataSource = dsCmb.Tables(0).DefaultView
        cmb.ValueMember = dsCmb.Tables(0).Columns(0).ToString
        cmb.DisplayMember = dsCmb.Tables(0).Columns(1).ToString
        dsCmb.Dispose()
    End Sub

    Public Sub ComboFill_City(ByVal cmb As ComboBox, ByVal sql As String)
        dsCmbCity.Clear()
        sql_query = sql
        obj.LoadData(sql_query, dsCmbCity)
        cmb.DataSource = dsCmbCity.Tables(0).DefaultView
        cmb.ValueMember = dsCmbCity.Tables(0).Columns(0).ToString
        cmb.DisplayMember = dsCmbCity.Tables(0).Columns(1).ToString
        dsCmbCity.Dispose()
    End Sub

    Public Sub setOpeningBalance(ByVal ledgerId As Integer)
        Dim _YrTo As String = "_" & M_dsFinYr.Tables(0).Rows(M_FinYrIndx)("YrSuffix")
        If edit_ins = 0 Then
            sql_query = "Delete from tbl_LedgerOpeningBalance" & _YrTo & " Where LedgerId = " & ledgerId
            obj.QueryExecute(sql_query)
        End If

        Select Case cmbDrCr.Text
            Case "Cr"
                sql_query = "Insert Into tbl_LedgerOpeningBalance" & _YrTo & " (LedgerId, DrOpening, CrOpening, DrCr, LastYrDr, LastYrCr, Remark) Values(" _
                    & ledgerId & ",0," & Math.Abs(Val(txtOpBal.Text)) & ",'Cr',0,0,0)"
                obj.QueryExecute(sql_query)
                Exit Select
            Case "Dr"
                sql_query = "Insert Into tbl_LedgerOpeningBalance" & _YrTo & " (LedgerId, DrOpening, CrOpening, DrCr, LastYrDr, LastYrCr, Remark) Values(" _
                    & ledgerId & "," & Math.Abs(Val(txtOpBal.Text)) & ",0,'Dr',0,0,0)"
                obj.QueryExecute(sql_query)
                Exit Select
        End Select
    End Sub

    Public Sub insert()
        If M_GenerateCustomerNumberSaveTime = "Yes" Then
            getLedgerCode()
        End If

        If checkLedgerCode() = True Then
            MsgBox("Same Customer Number Found, Get New Number", MsgBoxStyle.Critical)
            getLedgerCode()
        End If

        obj.Prepare("SP_InsertLedgerMaster_0507", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsCode", Dtype.int, Trim(txtLedgerCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsLedgerCode", Dtype.varchar, Trim(txtLedgerCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsLedgerName", Dtype.nvarchar, Trim(txtEmployeeName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsG_Id", Dtype.int, 30, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAddress1", Dtype.nvarchar, Trim(txtAddress.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAddress2", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCity", Dtype.nvarchar, Trim(cmbCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPinCode", Dtype.varchar, Trim(txtPinCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsState", Dtype.nvarchar, Trim(cmbState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCountry", Dtype.nvarchar, Trim(cmbCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPhoneNo", Dtype.varchar, Trim(txtPhoneNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMobileNo", Dtype.varchar, Trim(txtMobileNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsFaxNo", Dtype.varchar, Val(cmbSelectArea.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsEMail", Dtype.varchar, Trim(txtEmail.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCustType", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMobileNo2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBeneficiaryName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankAcType", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankAcNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsIFSCCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMICRCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankAddress", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAcContactPerson", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAcContactNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAcEmailId", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTranSMS", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPromoSMS", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsGSTNo", Dtype.varchar, Trim(txtGSTNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPANNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTaxation", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSys_Name", Dtype.varchar, My.Computer.Name, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSys_Time", Dtype.DateTime, Date.Now.ToString(M_DTMforSP & " HH:mm:ss tt"), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCurrUsr", Dtype.nvarchar, loggedUser, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsIsActive", Dtype.Bit, "True", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCountryCode", Dtype.varchar, "+91", ParaDirection.Input, True)
        obj.ExecuteCommand()

        'If Val(txtOpBal.Text) <> 0 Then
        '    sql_query = "Select IsNull(Max(LedgerId),0) From tbl_LedgerMaster Where LedgerCode = '" & Trim(txtLedgerCode.Text) & "'"
        '    setOpeningBalance(obj.ScalarExecute(sql_query))
        'End If

        sql_query = "Select IsNull(Max(LedgerId),0) From tbl_LedgerMaster Where LedgerCode = '" & Trim(txtLedgerCode.Text) & "'"
        lblLedgerId.Text = obj.ScalarExecute(sql_query)
    End Sub

    Public Sub edit() 'Company Id is not Updated
        obj.Prepare("SP_UpdateLedgerMaster", SpType.StoredProcedure) 'SP_UpdateLedgerMaster_CustMast
        obj.AddCmdParameter("@UpCode", Dtype.int, Val(txtLedgerCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerCode", Dtype.varchar, Trim(txtLedgerCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerName", Dtype.nvarchar, Trim(txtEmployeeName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpG_Id", Dtype.int, 30, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAddress1", Dtype.nvarchar, Trim(txtAddress.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAddress2", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCity", Dtype.nvarchar, Trim(cmbCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPinCode", Dtype.varchar, Trim(txtPinCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpState", Dtype.nvarchar, Trim(cmbState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCountry", Dtype.nvarchar, Trim(cmbCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPhoneNo", Dtype.varchar, Trim(txtPhoneNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo", Dtype.varchar, Trim(txtMobileNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpFaxNo", Dtype.varchar, Val(cmbSelectArea.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpEMail", Dtype.varchar, Trim(txtEmail.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCustType", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBeneficiaryName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAcType", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAcNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIFSCCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMICRCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAddress", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAcContactPerson", Dtype.nvarchar, Val(cmbSelectArea.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAcContactNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAcEmailId", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTranSMS", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPromoSMS", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpGSTNo", Dtype.varchar, Trim(txtGSTNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPANNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTaxation", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIsActive", Dtype.Bit, "True", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerId", Dtype.int, Val(lblLedgerId.Text), ParaDirection.Input, True)
        obj.ExecuteCommand()

        setOpeningBalance(Val(lblLedgerId.Text))

    End Sub

    Public Sub formatGrid()
        gvData.Columns("LedgerId").Visible = False
        gvData.Columns("Code").Caption = "Code"
        gvData.Columns("LedgerCode").Caption = "Ledger Code"
        gvData.Columns("LedgerName").Caption = "Employee Name"
        gvData.Columns("G_Id").Visible = False
        gvData.Columns("G_Name").Caption = "Group Name"
        gvData.Columns("GSTNo").Caption = "GST No"
        gvData.Columns("PinCode").Visible = False
        gvData.Columns("Country").Visible = False
        gvData.Columns("PhoneNo").Visible = False
        gvData.Columns("FaxNo").Visible = False
        gvData.Columns("EMail").Visible = False
        gvData.Columns("BirthDate").Visible = False
        gvData.Columns("AnniDate").Visible = False
        gvData.Columns("CustType").Visible = False
        gvData.Columns("BeneficiaryName").Visible = False
        gvData.Columns("BankAcType").Visible = False
        gvData.Columns("BankAcNo").Visible = False
        gvData.Columns("IFSCCode").Visible = False
        gvData.Columns("MICRCode").Visible = False
        gvData.Columns("BankName").Visible = False
        gvData.Columns("BankAddress").Visible = False
        gvData.Columns("AcContactPerson").Caption = "Area"
        gvData.Columns("AcContactNo").Visible = False
        gvData.Columns("AcEmailId").Visible = False
        gvData.Columns("TranSMS").Caption = False
        gvData.Columns("PromoSMS").Caption = False
        'gvData.Columns("StateCode").Visible = False
        gvData.Columns("CId").Visible = False
        gvData.Columns("IsActive").Visible = False
    End Sub

    Public Sub getLedgerCode()
        'sql_query = "Select IsNull(Max(Code),0) + 1 From Tbl_LedgerMaster Where G_Id = 30 And CId = " & M_CId
        'txtLedgerCode.Text = obj.ScalarExecute(sql_query) ' Where G_Id Not In (6,11,30)
        sql_query = "Select IsNull(Max(CAST(LedgerCode As Int)),0) + 1 From Tbl_LedgerMaster Where G_Id = 30 And CId = " & M_CId
        Dim tmpLedgercode As String = obj.ScalarExecute(sql_query)
        'txtLedgerCode.Text = _LedgerCodeInitial & StrDup(5 - Trim(tmpLedgercode).Length, "0") & Trim(tmpLedgercode)
        txtLedgerCode.Text = Trim(tmpLedgercode)
    End Sub

    Public Sub del()
        sql_query = "delete from tbl_LedgerMaster where LedgerId=" & Val(lblLedgerId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Private Sub FrmLedgerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCase(M_ValidateMobileNoLength) = "YES" Then
            txtMobileNo.MaxLength = Val(M_MobileNoLength)
        End If

        If M_GenerateCustomerNumberSaveTime = "Yes" Then
            txtLedgerCode.ReadOnly = True
            txtLedgerCode.TabStop = False
        End If

        dv = New DataView(dsLedgerMaster.Tables(0))

        'Select Case M_TaxCalculation
        '    Case "GST"
        '        lblGSTNo.Text = "GST No."
        '        cmbTaxation.Items.Add("-")
        '        cmbTaxation.Items.Add("SGST+CGST")
        '        cmbTaxation.Items.Add("IGST")
        '        Exit Select
        '    Case "VAT"
        '        lblGSTNo.Text = "VAT No."
        '        cmbTaxation.Items.Add("-")
        '        cmbTaxation.Items.Add("VAT")
        '        Exit Select
        '    Case Else
        '        lblGSTNo.Text = "GST No."
        '        cmbTaxation.Items.Add("-")
        '        cmbTaxation.Items.Add("SGST+CGST")
        '        cmbTaxation.Items.Add("IGST")
        '        Exit Select
        'End Select

        Select Case M_LedgerMasterF2
            Case True
                loadTime()
                addClickTime()
                Exit Select
            Case False
                loadTime()
                Exit Select
        End Select

        txtEmployeeName.CharacterCasing = CharacterCasing.Upper
        txtAddress.CharacterCasing = CharacterCasing.Upper
        'txtAdd2.CharacterCasing = CharacterCasing.Upper

        cmbCountry.Text = "INDIA"
        cmbSelectArea.SelectedIndex = -1
        cmbCity.SelectedIndex = -1
        'cmbCollectionPerson.SelectedIndex = -1
        cmbState.SelectedIndex = -1
        'cmbF_Area.Text = "ALL"

        btn_Add.Focus()
    End Sub

    Public Sub loadTime()
        '_LedgerCodeInitial = "C"


        'cmbF_CustType.SelectedIndex = 0
        'cmbDrCr.SelectedIndex = 0

        'ComboFill(cmbCustType, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Customer Type') Order By MiscName")
        ComboFill_City(cmbCity, "Select AreaId, CityName, PinCode From tbl_AreaMaster  Order By AreaName")
        ComboFill(cmbState, "Select AreaId, StateName From tbl_AreaMaster Order By AreaName")
        ComboFill(cmbCountry, "Select AreaId, CountryName From tbl_AreaMaster  Order By AreaName")
        ComboFill(cmbSelectArea, "Select AreaId, AreaName From tbl_AreaMaster Order By AreaName")

        GridFill(False)

        btn_Add.Enabled = True
        btn_Edit.Enabled = False
        btn_save.Enabled = False
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True
        gcData.Enabled = True
        grpBasicInfo.Enabled = False
        grpAddressDetails.Enabled = False
    End Sub

    Public Sub fillData()
        If gvData.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        lblLedgerId.Text = gvData.GetFocusedRowCellValue("LedgerId")
        txtLedgerCode.Text = gvData.GetFocusedRowCellValue("Code")
        txtLedgerCode.Text = gvData.GetFocusedRowCellValue("LedgerCode")
        txtEmployeeName.Text = gvData.GetFocusedRowCellValue("LedgerName")
        txtAddress.Text = gvData.GetFocusedRowCellValue("Address1")
        'txtAdd2.Text = gvData.GetFocusedRowCellValue("Address2")
        cmbCity.Text = gvData.GetFocusedRowCellValue("City")
        txtPinCode.Text = gvData.GetFocusedRowCellValue("PinCode")
        txtEmail.Text = gvData.GetFocusedRowCellValue("EMail")
        cmbState.Text = gvData.GetFocusedRowCellValue("State")
        txtGSTNo.Text = gvData.GetFocusedRowCellValue("GSTNo")
        cmbCountry.Text = gvData.GetFocusedRowCellValue("Country")
        'cmbTaxation.Text = gvData.GetFocusedRowCellValue("Taxation")
        txtPhoneNo.Text = gvData.GetFocusedRowCellValue("PhoneNo")
        txtMobileNo.Text = gvData.GetFocusedRowCellValue("MobileNo")
        cmbSelectArea.SelectedValue = Val(gvData.GetFocusedRowCellValue("FaxNo"))
        'cmbSalesPerson.Text = gvData.GetFocusedRowCellValue("TranSMS")
        'cmbCollectionPerson.Text = gvData.GetFocusedRowCellValue("PromoSMS")

        Dim _YrTo As String = "_" & M_dsFinYr.Tables(0).Rows(M_FinYrIndx)("YrSuffix")
        sql_query = "Select DrOpening + CrOpening From tbl_LedgerOpeningBalance" & _YrTo & " Where LedgerId = " & Val(lblLedgerId.Text)
        txtOpBal.Text = obj.ScalarExecute(sql_query)

        sql_query = "Select DrCr From tbl_LedgerOpeningBalance" & _YrTo & " Where LedgerId = " & Val(lblLedgerId.Text)
        cmbDrCr.Text = obj.ScalarExecute(sql_query)
    End Sub

    'Public Sub setTaxation()
    '    If UCase(M_CState) = UCase(cmbState.Text) Then
    '        cmbTaxation.Text = "SGST+CGST"
    '    Else
    '        cmbTaxation.Text = "IGST"
    '    End If
    'End Sub
#End Region

#Region "Functions"
    Public Function checkLedgerCode() As Boolean
        'If M_AllwDupLcode = "Yes" Then
        '    Return False
        'End If

        If edit_ins = 1 Then
            existLedgerCode = obj.ScalarExecute("select LedgerCode from tbl_LedgerMaster where LedgerCode='" & Trim(txtLedgerCode.Text) & "' And G_Id = 30 And CId = " & M_CId)
            If Trim(txtLedgerCode.Text) = existLedgerCode Then
                Return True
            Else
                Return False
            End If
        Else
            existLedgerCode = obj.ScalarExecute("select LedgerCode from tbl_LedgerMaster where LedgerId <>" & Val(lblLedgerId.Text) & "  And G_Id = 30 and LedgerCode='" & Trim(txtLedgerCode.Text) & "' And CId = " & M_CId)
            If Trim(txtLedgerCode.Text) = existLedgerCode Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
#End Region

    Private Sub gvData_Click(sender As Object, e As EventArgs) Handles gvData.Click
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length < 0 Then
            Exit Sub
        End If
        fillData()

        btn_Cancel.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        btn_save.Enabled = False
        btn_Add.Enabled = False
    End Sub

    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length < 0 Then
            Exit Sub
        End If
        fillData()

        btn_Cancel.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        btn_save.Enabled = False
        btn_Add.Enabled = False

        If checkRightsToEdit("CUSTOMER MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        'If checkRightsToAdd("EMPLOYEE MASTER") = False Then
        '    MsgBox("Unable To Add New Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        addClickTime()
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        'If checkRightsToEdit("EMPLOYEE MASTER") = False Then
        '    MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        editClickTime()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Trim(txtLedgerCode.Text) = "" Then
            MsgBox("Please Specify Ledger Code", MsgBoxStyle.Information)
            txtLedgerCode.Focus()
            Exit Sub
        End If
        If Trim(txtEmployeeName.Text) = "" Then
            MsgBox("Please Specify Ledger Name", MsgBoxStyle.Information)
            txtEmployeeName.Focus()
            Exit Sub
        End If

        If checkLedgerCode() = True Then
            MsgBox("Ledger Code Already Exists, Please Specify Another One", MsgBoxStyle.Critical)
            txtLedgerCode.Focus()
            Exit Sub
        End If
        If Trim(txtMobileNo.Text) <> "" And Trim(txtMobileNo.Text.Length) <> M_MobileNoLength Then
            MsgBox("Please Specify Correct Mobile Number (10 Digits Required)", MsgBoxStyle.Information)
            Exit Sub
        End If

        If edit_ins = 1 Then
            insert()
        Else
            edit()
        End If

        saveClickTime()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        'If checkRightsToDelete("EMPLOYEE MASTER") = False Then
        '    MsgBox("Unable To Delete Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        sql_query = "Select Count(*) From tbl_VoucherEntryMast Where " & Val(lblLedgerId.Text) & " In (DrLedgerId, CrLedgerId)"
        If obj.ScalarExecute(sql_query) > 0 Then
            MsgBox("Unable To Delete Ledger, Reference Records Found", MsgBoxStyle.Information)
            Exit Sub
        End If

        sql_query = "Select Count(*) From tbl_SalesMaster Where LedgerId = " & Val(lblLedgerId.Text)
        If obj.ScalarExecute(sql_query) > 0 Then
            MsgBox("Unable To Delete Item, Reference Records Found", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dr As DialogResult
        dr = MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            del()
            deleteClickTime()
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        cancelClickTime()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        GridFill(True)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        GridFill(True)
    End Sub

    Private Sub btnAddArea_Click(sender As Object, e As EventArgs) Handles btnAddArea.Click
        Dim Area As String = UCase(cmbSelectArea.Text)

        If M_checkMiscMaster("Area", UCase(cmbSelectArea.Text)) = False Then
            insertAreaMaster("Area", UCase(cmbSelectArea.Text))
            'ComboFill(cmbArea, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Area') Order By MiscName")
            ComboFill(cmbSelectArea, "Select AreaId , AreaName From tbl_AreaMaster Order By AreaName")
            cmbSelectArea.Text = Area
            MsgBox(Area & " Added Successfully", MsgBoxStyle.Information)
        Else
            MsgBox(Area & " Already Exist", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub insertAreaMaster(ByVal AreaId As String, ByVal AreaName As String)
        sql_query = "Insert into tbl_AreaMaster (AreaId, AreaName, IsActive) values ('" & AreaId & "','" & AreaName & "','True')"
        obj.QueryExecute(sql_query)
    End Sub

#Region "Events"
    Public Sub addClickTime()
        grpBasicInfo.Enabled = True
        grpAddressDetails.Enabled = True
        gcData.Enabled = False

        btn_Add.Enabled = False
        btn_Edit.Enabled = False
        btn_save.Enabled = True
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True

        getLedgerCode()
        txtEmployeeName.Focus()


        cmbCountry.Text = M_CCountry
        cmbState.Text = M_CState
        'setTaxation()

        edit_ins = 1
    End Sub

    Public Sub editClickTime()
        grpBasicInfo.Enabled = True
        grpAddressDetails.Enabled = True
        gcData.Enabled = False

        btn_Add.Enabled = False
        btn_Edit.Enabled = False
        btn_save.Enabled = True
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True

        edit_ins = 0
        oldLedgerCode = Trim(txtLedgerCode.Text)
        txtEmployeeName.Focus()
    End Sub

    Public Sub saveClickTime()
        GridFill(True)
        grpBasicInfo.Enabled = False
        grpAddressDetails.Enabled = False
        gcData.Enabled = True

        btn_Add.Enabled = True
        btn_Edit.Enabled = False
        btn_save.Enabled = False
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True
        btn_Add.Focus()
        clearclicktime()

        edit_ins = -1
    End Sub

    Public Sub clearclicktime()
        txtLedgerCode.Clear()
        txtEmployeeName.Clear()
        txtLedgerCode.Clear()
        txtAddress.Clear()
        'txtAdd2.Clear()
        txtPinCode.Clear()
        txtGSTNo.Clear()
        txtPhoneNo.Clear()
        txtMobileNo.Clear()
        'txtDueDays.Text = 0
        txtEmail.Clear()

        'cmbCustType.Text = "-"
        cmbSelectArea.SelectedIndex = -1
        cmbCity.SelectedIndex = -1
        cmbState.SelectedIndex = -1
        'cmbTaxation.Text = "-"
        'cmbSalesPerson.SelectedIndex = -1
        'cmbCollectionPerson.SelectedIndex = -1
        'cmbDrCr.Text = ""
        'txtOpBal.Clear()
    End Sub

    Public Sub deleteClickTime()
        GridFill(True)
        grpBasicInfo.Enabled = False
        grpAddressDetails.Enabled = False
        gcData.Enabled = True

        btn_Add.Enabled = True
        btn_Edit.Enabled = False
        btn_save.Enabled = False
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True
        btn_Add.Focus()


        txtLedgerCode.Clear()
        txtEmployeeName.Clear()
        txtLedgerCode.Clear()
        cmbSelectArea.Text = ""
        txtAddress.Clear()
        'txtAdd2.Clear()
        cmbCity.Text = ""
        txtPinCode.Clear()
        cmbState.Text = ""
        txtGSTNo.Clear()
        'cmbTaxation.SelectedIndex = 0
        cmbSelectArea.Text = ""
        txtPhoneNo.Clear()
        txtMobileNo.Clear()
        cmbCountry.Text = ""
        txtEmail.Clear()

        'txtDueDays.Text = 0
        'cmbTaxation.Text = ""
        'cmbSalesPerson.Text = ""
        'cmbCollectionPerson.Text = ""
        'cmbDrCr.Text = ""
        'txtOpBal.Clear()

        edit_ins = -1
    End Sub

    Public Sub cancelClickTime()
        grpBasicInfo.Enabled = False
        grpAddressDetails.Enabled = False
        gcData.Enabled = True

        btn_Add.Enabled = True
        btn_Add.Focus()
        btn_Edit.Enabled = False
        btn_save.Enabled = False
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = False
        'btnExit.Enabled = True

        edit_ins = -1
        clearclicktime()
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

    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        gvData.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvData.FocusedColumn.FieldName)
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SaveLayout(gvData, "FrmEmployeeMaster", Me)
    End Sub

    Private Sub cmbSelectArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectArea.SelectedIndexChanged
        If cmbSelectArea.SelectedIndex > 0 And cmbSelectArea.Items.Count > 0 Then
            cmbCity.SelectedValue = cmbSelectArea.SelectedValue
            cmbState.SelectedValue = cmbSelectArea.SelectedValue
            cmbCountry.SelectedValue = cmbSelectArea.SelectedValue
            txtPinCode.Text = Trim(dsCmbCity.Tables(0).Select("AreaId=" & cmbSelectArea.SelectedValue)(0)("Pincode").ToString())
        End If
    End Sub

    Private Sub RenameColumnToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
        Dx_RenameColumn(gvData)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dx_ExportToExcel(gvData)
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvData, "EmployeeMaster", Me)
    End Sub

    Private Sub txtPhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPinCode.KeyPress, txtPhoneNo.KeyPress, txtMobileNo.KeyPress, txtLedgerCode.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
        If e.KeyChar = Chr(8) Then
            Exit Sub
        End If
        If checkNumber(Asc(e.KeyChar)) = False Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress, txtGSTNo.KeyPress, txtEmployeeName.KeyPress, txtEmail.KeyPress, txtAddress.KeyPress, cmbState.KeyPress, cmbSelectArea.KeyPress, cmbCountry.KeyPress, cmbCity.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbSelectArea_Enter(sender As Object, e As EventArgs) Handles cmbState.Enter, cmbSelectArea.Enter, cmbCountry.Enter, cmbCity.Enter
        sender.DroppedDown = True
        If sender.SelectedIndex = -1 And sender.Items.Count > 0 Then
            sender.SelectedIndex = 0
        End If
    End Sub

#End Region

End Class