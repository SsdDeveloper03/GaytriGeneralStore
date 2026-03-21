Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmCustomerMaster

    Public OpenFromBilling As Boolean = False
    Public NewLedgerId As Integer = 0
#Region "Comments"
    'Name:Gaytri
    'Created By:Smit
    'Form:FrmCustomerMaster
    'Date:07/03/2026
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
    Dim escCount As Integer


#End Region

#Region "Method"

    Public Sub formatGrid()
        gvData.Columns("LedgerId").Visible = False
        gvData.Columns("Code").Caption = "Disp SrNo"
        gvData.Columns("LedgerCode").Caption = "Ledger Code"
        gvData.Columns("LedgerName").Caption = "Customer Name"
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
        gvData.Columns("TranSMS").Caption = "Sales Person"
        gvData.Columns("PromoSMS").Caption = "Collection Person"
        'gvData.Columns("StateCode").Visible = False
        gvData.Columns("CId").Visible = False
        gvData.Columns("IsActive").Visible = False
    End Sub

    Public Sub gridfill(ByVal _Refresh As Boolean)
        Dim _filter As String = ""

        ds.Clear()

        If cmbF_Area.Text <> "ALL" And cmbF_Area.Text <> "" Then
            _filter = " And AcContactPerson = '" & Trim(cmbF_Area.SelectedValue) & "'"
        End If

        'sql_query = "Select " & topRows & " * From  View_LedgerMaster" _
        '    & " Where G_Id = 11 And (LedgerName Like N'" & Trim(txtSearch.Text) & "%' OR MobileNo Like N'%" & Trim(txtSearch.Text) & "%')  " & _filter & " Order By Code Desc"

        'obj.LoadData(sql_query, ds)
        'gcData.DataSource = ds.Tables(0).DefaultView
        If _Refresh = True Then
            loadLedgerMaster()
            dv = New DataView(dsLedgerMaster.Tables(0))
            dv.RowFilter = "G_Id = 11 And (LedgerName Like '" & Trim(txtSearch.Text) & "%' OR MobileNo Like '%" & Trim(txtSearch.Text) & "%') " & _filter
            dt = dv.ToTable()
        Else
            dv.RowFilter = "G_Id = 11 And (LedgerName Like '" & Trim(txtSearch.Text) & "%' OR MobileNo Like '%" & Trim(txtSearch.Text) & "%') " & _filter
            dt = dv.ToTable()
        End If

        gcData.DataSource = dt.DefaultView

        gvData.OptionsView.ColumnAutoWidth = False
        gvData.BestFitColumns()
        formatGrid()

        RestoreLayout(gvData, "FrmCustomerMaster")
        lblTotalRecords.Text = "📋 " & gvData.RowCount & " Records"

        'If checkRightsToLoad("HIDE CUSTOMER CONTACT NO") = True Then
        '    gvData.Columns("MobileNo").Visible = False
        '    gvData.Columns("PhoneNo").Visible = False
        'End If

        'If checkRightsToLoad("HIDE CUSTOMER ADDRESS") = True Then
        '    gvData.Columns("Address1").Visible = False
        '    gvData.Columns("Address2").Visible = False
        'End If
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

    Public Sub ComboFill_Search(ByVal cmb As ComboBox, ByVal sql As String)
        Dim dsCmb As New Data.DataSet
        dsCmb.Clear()
        sql_query = sql
        obj.LoadData(sql_query, dsCmb)
        'cmb.DataSource = dsCmb.Tables(0).DefaultView
        cmb.Items.Add("ALL")
        For i As Integer = 0 To dsCmb.Tables(0).Rows.Count - 1
            cmb.Items.Add(dsCmb.Tables(0).Rows(i)(1))
        Next
        dsCmb.Dispose()
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
        obj.AddCmdParameter("@InsCode", Dtype.int, Trim(txtDisplaySrNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsLedgerCode", Dtype.varchar, Trim(txtLedgerCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsLedgerName", Dtype.nvarchar, Trim(txtLedgerName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsG_Id", Dtype.int, 11, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAddress1", Dtype.nvarchar, Trim(txtAdd1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAddress2", Dtype.nvarchar, Trim(txtAdd2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCity", Dtype.nvarchar, Trim(cmbCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPinCode", Dtype.varchar, Trim(txtPinCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsState", Dtype.nvarchar, Trim(cmbState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCountry", Dtype.nvarchar, Trim(cmbCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPhoneNo", Dtype.varchar, Trim(txtPhone.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMobileNo", Dtype.varchar, Trim(txtMobile.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsFaxNo", Dtype.varchar, Val(cmbArea.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsEMail", Dtype.varchar, Trim(txtEMailId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCustType", Dtype.nvarchar, cmbCustType.Text, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMobileNo2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBeneficiaryName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankAcType", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankAcNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsIFSCCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMICRCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBankAddress", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAcContactPerson", Dtype.nvarchar, Val(cmbCollectionPerson.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAcContactNo", Dtype.varchar, Val(cmbSalesPerson.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAcEmailId", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTranSMS", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPromoSMS", Dtype.varchar, Val(txtDueDays.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsGSTNo", Dtype.varchar, Trim(txtGSTNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPANNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTaxation", Dtype.varchar, cmbTaxation.Text, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSys_Name", Dtype.varchar, My.Computer.Name, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSys_Time", Dtype.DateTime, Date.Now.ToString(M_DTMforSP & " HH:mm:ss tt"), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCurrUsr", Dtype.nvarchar, loggedUser, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsIsActive", Dtype.Bit, "True", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCountryCode", Dtype.varchar, "+91", ParaDirection.Input, True)
        obj.ExecuteCommand()

        If Val(txtOpBal.Text) <> 0 Then
            sql_query = "Select IsNull(Max(LedgerId),0) From tbl_LedgerMaster Where LedgerCode = '" & Trim(txtLedgerCode.Text) & "'"
            setOpeningBalance(obj.ScalarExecute(sql_query))
        End If

        sql_query = "Select IsNull(Max(LedgerId),0) From tbl_LedgerMaster Where LedgerCode = '" & Trim(txtLedgerCode.Text) & "'"
        lblLedgerId.Text = obj.ScalarExecute(sql_query)
    End Sub

    Public Sub insertMiscMaster(ByVal _MiscType As String, ByVal _MiscName As String)
        sql_query = "Insert into tbl_MiscMaster (MiscType, MiscName, CId, IsActive) values ('" & _MiscType & "','" & _MiscName & "',1,'True')"
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub edit() 'Company Id is not Updated
        obj.Prepare("SP_UpdateLedgerMaster", SpType.StoredProcedure) 'SP_UpdateLedgerMaster_CustMast
        obj.AddCmdParameter("@UpCode", Dtype.int, Val(txtDisplaySrNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerCode", Dtype.varchar, Trim(txtLedgerCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerName", Dtype.nvarchar, Trim(txtLedgerName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpG_Id", Dtype.int, 11, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAddress1", Dtype.nvarchar, Trim(txtAdd1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAddress2", Dtype.nvarchar, Trim(txtAdd2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCity", Dtype.nvarchar, Trim(cmbCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPinCode", Dtype.varchar, Trim(txtPinCode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpState", Dtype.nvarchar, Trim(cmbState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCountry", Dtype.nvarchar, Trim(cmbCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPhoneNo", Dtype.varchar, Trim(txtPhone.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo", Dtype.varchar, Trim(txtMobile.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpFaxNo", Dtype.varchar, Val(cmbArea.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpEMail", Dtype.varchar, Trim(txtEMailId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCustType", Dtype.nvarchar, cmbCustType.Text, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBeneficiaryName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAcType", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAcNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIFSCCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMICRCode", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankName", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBankAddress", Dtype.nvarchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAcContactPerson", Dtype.nvarchar, Val(cmbCollectionPerson.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAcContactNo", Dtype.varchar, Val(cmbSalesPerson.SelectedValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAcEmailId", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTranSMS", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPromoSMS", Dtype.varchar, Val(txtDueDays.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpGSTNo", Dtype.varchar, Trim(txtGSTNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPANNo", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTaxation", Dtype.varchar, cmbTaxation.Text, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIsActive", Dtype.Bit, "True", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerId", Dtype.int, Val(lblLedgerId.Text), ParaDirection.Input, True)
        obj.ExecuteCommand()

        setOpeningBalance(Val(lblLedgerId.Text))

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

    Public Sub del()
        sql_query = "delete from tbl_LedgerMaster where LedgerId=" & Val(lblLedgerId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub loadTime()
        '_LedgerCodeInitial = "C"


        'cmbF_CustType.SelectedIndex = 0
        'cmbDrCr.SelectedIndex = 0

        ComboFill(cmbCustType, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('CustType') Order By MiscId")
        ComboFill(cmbArea, "Select AreaId, AreaName From tbl_AreaMaster Order By AreaName")
        ComboFill_City(cmbCity, "Select AreaId, CityName, PinCode From tbl_AreaMaster Order By AreaName")
        ComboFill(cmbState, "Select AreaId, StateName From tbl_AreaMaster Order By AreaName")
        ComboFill(cmbCountry, "Select AreaId, CountryName From tbl_AreaMaster Order By AreaName")
        ComboFill(cmbSalesPerson, "Select LedgerId, LedgerName From tbl_LedgerMaster Where CId = " & M_CId & " And G_Id = 30 Order By LedgerName")
        ComboFill(cmbCollectionPerson, "Select LedgerId, LedgerName From tbl_LedgerMaster Where CId = " & M_CId & " And G_Id = 30 Order By LedgerName")
        ComboFill_Search(cmbF_Area, "Select AreaId, AreaName From tbl_AreaMaster Order By AreaName")

        gridfill(False)

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnsave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        'btnExit.Enabled = True
        gcData.Enabled = True
        gbMaindetail.Enabled = False
    End Sub

    Public Sub addClickTime()
        gbMaindetail.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnsave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        'btnExit.Enabled = True

        getLedgerCode()
        txtLedgerName.Focus()

        cmbCountry.Text = M_CCountry
        cmbState.Text = M_CState
        setTaxation()

        edit_ins = 1
    End Sub

    Public Sub editClickTime()
        gbMaindetail.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnsave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        'btnExit.Enabled = True

        edit_ins = 0
        oldLedgerCode = Trim(txtLedgerCode.Text)
        txtLedgerName.Focus()
    End Sub

    Public Sub saveClickTime()
        gridfill(True)
        gbMaindetail.Enabled = False
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnsave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        'btnExit.Enabled = True
        btnAdd.Focus()
        clearclicktime()

        edit_ins = -1
    End Sub

    Public Sub clearclicktime()
        txtLedgerCode.Clear()
        txtLedgerName.Clear()
        txtDisplaySrNo.Clear()
        txtAdd1.Clear()
        txtAdd2.Clear()
        txtPinCode.Clear()
        txtGSTNo.Clear()
        txtPhone.Clear()
        txtMobile.Clear()
        txtDueDays.Text = 0
        txtEMailId.Clear()

        cmbCustType.Text = "-"
        cmbArea.SelectedIndex = -1
        cmbCity.SelectedIndex = -1
        cmbState.SelectedIndex = -1
        cmbTaxation.Text = "-"
        cmbSalesPerson.SelectedIndex = -1
        cmbCollectionPerson.SelectedIndex = -1
        cmbDrCr.Text = ""
        txtOpBal.Clear()
    End Sub

    Public Sub deleteClickTime()
        gridfill(True)
        gbMaindetail.Enabled = False
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnsave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        'btnExit.Enabled = True
        btnAdd.Focus()


        txtLedgerCode.Clear()
        txtLedgerName.Clear()
        txtDisplaySrNo.Clear()
        cmbArea.Text = ""
        txtAdd1.Clear()
        txtAdd2.Clear()
        cmbCity.Text = ""
        txtPinCode.Clear()
        cmbState.Text = ""
        txtGSTNo.Clear()
        cmbTaxation.SelectedIndex = 0
        cmbArea.Text = ""
        txtPhone.Clear()
        txtMobile.Clear()
        cmbCountry.Text = ""
        txtEMailId.Clear()

        txtDueDays.Text = 0
        cmbTaxation.Text = ""
        cmbSalesPerson.Text = ""
        cmbCollectionPerson.Text = ""
        cmbDrCr.Text = ""
        txtOpBal.Clear()

        edit_ins = -1
    End Sub

    Public Sub cancelClickTime()
        gbMaindetail.Enabled = False
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnAdd.Focus()
        btnEdit.Enabled = False
        btnsave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
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

    Public Sub fillData()
        If gvData.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        lblLedgerId.Text = gvData.GetFocusedRowCellValue("LedgerId")
        txtDisplaySrNo.Text = gvData.GetFocusedRowCellValue("Code")
        txtLedgerCode.Text = gvData.GetFocusedRowCellValue("LedgerCode")
        txtLedgerName.Text = gvData.GetFocusedRowCellValue("LedgerName")
        txtAdd1.Text = gvData.GetFocusedRowCellValue("Address1")
        txtAdd2.Text = gvData.GetFocusedRowCellValue("Address2")
        cmbCity.Text = gvData.GetFocusedRowCellValue("City")
        txtPinCode.Text = gvData.GetFocusedRowCellValue("PinCode")
        cmbState.Text = gvData.GetFocusedRowCellValue("State")
        txtGSTNo.Text = gvData.GetFocusedRowCellValue("GSTNo")
        cmbCountry.Text = gvData.GetFocusedRowCellValue("Country")
        cmbTaxation.Text = gvData.GetFocusedRowCellValue("Taxation")
        txtPhone.Text = gvData.GetFocusedRowCellValue("PhoneNo")
        txtMobile.Text = gvData.GetFocusedRowCellValue("MobileNo")
        cmbArea.SelectedValue = gvData.GetFocusedRowCellValue("FaxNo")
        cmbSalesPerson.SelectedValue = gvData.GetFocusedRowCellValue("AcContactNo")
        cmbCollectionPerson.SelectedValue = Val(gvData.GetFocusedRowCellValue("AcContactPerson"))

        Dim _YrTo As String = "_" & M_dsFinYr.Tables(0).Rows(M_FinYrIndx)("YrSuffix")
        sql_query = "Select DrOpening + CrOpening From tbl_LedgerOpeningBalance" & _YrTo & " Where LedgerId = " & Val(lblLedgerId.Text)
        txtOpBal.Text = obj.ScalarExecute(sql_query)

        sql_query = "Select DrCr From tbl_LedgerOpeningBalance" & _YrTo & " Where LedgerId = " & Val(lblLedgerId.Text)
        cmbDrCr.Text = obj.ScalarExecute(sql_query)
    End Sub

    Public Sub getLedgerCode()
        sql_query = "Select ISNULL(MAX(Code), 0) + 1 From Tbl_LedgerMaster Where G_Id = 11 And CId = " & M_CId
        txtDisplaySrNo.Text = obj.ScalarExecute(sql_query) ' Where G_Id Not In (6,11,30)
        sql_query = "Select ISNULL(MAX(TRY_CAST(LedgerCode AS INT)), 0) + 1 From Tbl_LedgerMaster Where G_Id = 11 And CId = " & M_CId
        Dim tmpLedgercode As String = obj.ScalarExecute(sql_query)
        'txtLedgerCode.Text = _LedgerCodeInitial & StrDup(5 - Trim(tmpLedgercode).Length, "0") & Trim(tmpLedgercode)
        txtLedgerCode.Text = tmpLedgercode
    End Sub

    Public Sub setTaxation()
        If UCase(M_CState) = UCase(cmbState.Text) Then
            cmbTaxation.Text = "SGST+CGST"
        Else
            cmbTaxation.Text = "IGST"
        End If
    End Sub

#End Region

#Region "function"

    Public Function checkLedgerCode() As Boolean
        'If M_AllwDupLcode = "Yes" Then
        '    Return False
        'End If

        If edit_ins = 1 Then
            existLedgerCode = obj.ScalarExecute("select LedgerCode from tbl_LedgerMaster where LedgerCode='" & Trim(txtLedgerCode.Text) & "' And G_Id = 11 And CId = " & M_CId)
            If Trim(txtLedgerCode.Text) = existLedgerCode Then
                Return True
            Else
                Return False
            End If
        Else
            existLedgerCode = obj.ScalarExecute("select LedgerCode from tbl_LedgerMaster where LedgerId <>" & Val(lblLedgerId.Text) & " And G_Id = 11 And LedgerCode='" & Trim(txtLedgerCode.Text) & "' And CId = " & M_CId)
            If Trim(txtLedgerCode.Text) = existLedgerCode Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

#End Region

#Region "Events"

    Private Sub FrmLedgerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
        If UCase(M_ValidateMobileNoLength) = "YES" Then
            txtMobile.MaxLength = Val(M_MobileNoLength)
        End If

        If M_GenerateCustomerNumberSaveTime = "Yes" Then
            txtLedgerCode.ReadOnly = True
            txtLedgerCode.TabStop = False
        End If
        dv = New DataView(dsLedgerMaster.Tables(0))

        Select Case M_TaxCalculation
            Case "GST"
                lblGSTNo.Text = "GST No."
                cmbTaxation.Items.Add("-")
                cmbTaxation.Items.Add("SGST+CGST")
                cmbTaxation.Items.Add("IGST")
                Exit Select
            Case "VAT"
                lblGSTNo.Text = "VAT No."
                cmbTaxation.Items.Add("-")
                cmbTaxation.Items.Add("VAT")
                Exit Select
            Case Else
                lblGSTNo.Text = "GST No."
                cmbTaxation.Items.Add("-")
                cmbTaxation.Items.Add("SGST+CGST")
                cmbTaxation.Items.Add("IGST")
                Exit Select
        End Select

        Select Case M_LedgerMasterF2
            Case True
                loadTime()
                addClickTime()
                Exit Select
            Case False
                loadTime()
                Exit Select
        End Select

        txtLedgerName.CharacterCasing = CharacterCasing.Upper
        txtAdd1.CharacterCasing = CharacterCasing.Upper
        txtAdd2.CharacterCasing = CharacterCasing.Upper

        cmbCountry.Text = "INDIA"
        cmbCity.SelectedIndex = -1
        cmbCollectionPerson.SelectedIndex = -1
        cmbState.SelectedIndex = -1
        'cmbF_Area.Text = "ALL"

        btnAdd.Focus()
        LoadCustomerAutoComplete()

        If OpenFromBilling = True Then
            addClickTime()
            txtLedgerName.Focus()
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'If checkRightsToAdd("CUSTOMER MASTER") = False Then
        '    MsgBox("Unable To Add New Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If M_IsDemoSetup = True Then'====
        '    sql_query = "Select Count(*) From Tbl_LedgerMaster"
        '    If M_LedgerLimit < obj.ScalarExecute(sql_query) Then
        '        MsgBox("Unable to Add Ledger Entry" & vbCrLf & "Please Contact Software Developer to Exceed Limit", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If       
        'End If

        addClickTime()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'If checkRightsToEdit("CUSTOMER MASTER") = False Then
        '    MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        editClickTime()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If Trim(txtLedgerCode.Text) = "" Then
            MsgBox("Please Specify Ledger Code", MsgBoxStyle.Information)
            txtLedgerCode.Focus()
            Exit Sub
        End If
        If Trim(txtLedgerName.Text) = "" Then
            MsgBox("Please Specify Ledger Name", MsgBoxStyle.Information)
            txtLedgerName.Focus()
            Exit Sub
        End If

        If checkLedgerCode() = True Then
            MsgBox("Ledger Code Already Exists, Please Specify Another One", MsgBoxStyle.Critical)
            txtLedgerCode.Focus()
            Exit Sub
        End If

        If Trim(txtMobile.Text) <> "" And Trim(txtMobile.Text.Length) <> M_MobileNoLength Then
            MsgBox("Please Specify Correct Mobile Number (10 Digits Required)", MsgBoxStyle.Information)
            Exit Sub
        End If

        If IsCustomerExists() Then
            MsgBox("Customer already exists! Please enter a different name.", MsgBoxStyle.Exclamation)
            txtLedgerName.Focus()
            Exit Sub
        End If

        'If Val(txtOpBal.Text) <> 0 Then
        '    If cmbDrCr.SelectedIndex = -1 Or Trim(cmbDrCr.Text) = "" Then
        '        MsgBox("Please Select DrCr", MsgBoxStyle.Information)
        '        cmbDrCr.Focus()
        '        Exit Sub
        '    End If
        'End If


        If edit_ins = 1 Then
            insert()
            'Select Case M_LedgerMasterF2
            '    Case True
            '        Select Case M_CallingFormLedgerCreation
            '            Case "Invoice_Customer"
            '                sql_query = "Select Max(LedgerId) From Tbl_LedgerMaster Where LedgerCode = '" & txtLedgerCode.Text & "'"
            '                FrmInvoiceMaster_21.cmbLedger.EditValue = obj.ScalarExecute(sql_query)
            '                FrmInvoiceMaster_21.cmbLedger.Text = txtLedgerName.Text
            '                Exit Select
            '        End Select

            '        edit_ins = -1
            '        exitClickTime()
            '        Exit Sub
            '        Exit Select
            'End Select

            NewLedgerId = obj.ScalarExecute("Select Max(LedgerId) From Tbl_LedgerMaster Where CId = " & M_CId)

            'Close form only if opened from Billing Entry
            If OpenFromBilling = True Then
                Me.Close()
                Exit Sub
            End If
        Else
            edit()
        End If

        saveClickTime()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkRightsToDelete("CUSTOMER MASTER") = False Then
            MsgBox("Unable To Delete Record", MsgBoxStyle.Information)
            Exit Sub
        End If

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        cancelClickTime()
    End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    '    exitClickTime()
    'End Sub

#End Region

#Region "Navigation"

    Private Sub txtLedgerCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLedgerCode.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True

            If Trim(txtLedgerCode.Text) = "" Then Exit Sub

            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtLedgerName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdd1.KeyPress, txtAdd2.KeyPress, txtPinCode.KeyPress, txtEMailId.KeyPress, cmbDrCr.KeyPress, cmbCity.KeyPress, cmbCustType.KeyPress, cmbF_Area.KeyPress, cmbState.KeyPress, cmbCountry.KeyPress, txtLedgerName.KeyPress

        If e.KeyChar = Chr(13) Then
            e.Handled = True
            Me.SelectNextControl(CType(sender, Control), True, True, True, True)
        End If

    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress, txtPhone.KeyPress, txtDueDays.KeyPress

        If UCase(M_AllowMultiCountryMobileSeries) = "NO" Then

            If e.KeyChar = Chr(13) Then
                e.Handled = True
                Me.SelectNextControl(CType(sender, Control), True, True, True, True)
                Exit Sub
            End If

            If e.KeyChar = Chr(8) Then Exit Sub

            If checkNumber(Asc(e.KeyChar)) = False Then
                e.KeyChar = Chr(0)
            End If

        End If

    End Sub

    Private Sub cmbCity_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDrCr.Enter, cmbCity.Enter, cmbCustType.Enter, cmbF_Area.Enter, cmbState.Enter, cmbCountry.Enter
        sender.DroppedDown = True
        If sender.SelectedIndex = -1 And sender.Items.Count > 0 Then
            sender.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtOpBal_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpBal.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(sender.Text) = "" Then
                sender.Text = "0"
            End If
            SendKeys.Send("{Tab}")
        End If

        'If e.KeyChar = Chr(8) Then
        '    Exit Sub
        'End If
        'If Not sender.Text.Contains(".") Then
        '    point = False
        'End If
        'If e.KeyChar = Chr(46) And point = False Then
        '    point = True
        '    Exit Sub
        'End If
        'If checkNumber(Asc(e.KeyChar)) = False Then
        '    e.KeyChar = Chr(0)
        'End If
    End Sub

#End Region

#Region "Other"

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim ds_Excel As New Data.DataSet
        ds_Excel.Clear()
        obj.LoadData_Excel("SELECT * FROM [Sheet1$]", ds_Excel, "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & OpenFileDialog1.FileName & "; Extended Properties=""Excel 8.0; HDR=Yes; IMEX=1""")

        Dim newRecords As Integer = 0
        Dim upRecords As Integer = 0

        For i As Integer = 1 To ds_Excel.Tables(0).Rows.Count - 1
            For j As Integer = 0 To ds_Excel.Tables(0).Columns.Count - 1
                If IsDBNull(ds_Excel.Tables(0).Rows(i)(j)) Then
                    ds_Excel.Tables(0).Rows(i)(j) = ""
                End If
            Next
        Next

        For i As Integer = 0 To ds_Excel.Tables(0).Rows.Count - 1
            Select Case ds_Excel.Tables(0).Rows(i)(0) 'ItemId
                Case 0 'Insert
                    obj.Prepare("SP_InsertLedgerMaster_0507", SpType.StoredProcedure)
                    obj.AddCmdParameter("@InsCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(1), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsLedgerCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(2), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsLedgerName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(3), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsG_Id", Dtype.int, ds_Excel.Tables(0).Rows(i)(4), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsAddress1", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(6), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsAddress2", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(7), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsCity", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(8), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsPinCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(9), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsState", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(10), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsCountry", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(11), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsPhoneNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(12), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsMobileNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(13), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsFaxNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(14), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsEMail", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(15), ParaDirection.Input, True)
                    If ds_Excel.Tables(0).Rows(i)(16) = "" Then
                        obj.AddCmdParameter("@InsBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
                    Else
                        obj.AddCmdParameter("@InsBirthDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(16), ParaDirection.Input, True)
                    End If
                    If ds_Excel.Tables(0).Rows(i)(17) = "" Then
                        obj.AddCmdParameter("@InsAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
                    Else
                        obj.AddCmdParameter("@InsAnniDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(17), ParaDirection.Input, True)
                    End If

                    obj.AddCmdParameter("@InsCustType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(18), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsMobileNo2", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(19), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsBeneficiaryName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(20), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsBankAcType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(21), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsBankAcNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(22), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsIFSCCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(23), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsMICRCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(24), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsBankName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(25), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsBankAddress", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(26), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsAcContactPerson", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(27), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsAcContactNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(28), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsAcEmailId", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(29), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsTranSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(30), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsPromoSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(31), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsGSTNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(32), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsPANNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(33), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsTaxation", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(34), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsStateCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(35), ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsCId", Dtype.int, M_CId, ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsBrokerId", Dtype.int, 0, ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsRefId1", Dtype.int, 0, ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsRefId2", Dtype.int, 0, ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsIsActive", Dtype.Bit, True, ParaDirection.Input, True)
                    obj.AddCmdParameter("@InsCountryCode", Dtype.varchar, "+91", ParaDirection.Input, True)
                    obj.ExecuteCommand()

                    newRecords = newRecords + 1
                    Exit Select
                Case Is > 0 'Update
                    obj.Prepare("SP_UpdateLedgerMaster_0507", SpType.StoredProcedure) 'SP_UpdateLedgerMaster_CustMast
                    obj.AddCmdParameter("@UpCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(1), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpLedgerCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(2), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpLedgerName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(3), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpG_Id", Dtype.int, ds_Excel.Tables(0).Rows(i)(4), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpAddress1", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(6), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpAddress2", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(7), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpCity", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(8), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpPinCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(9), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpState", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(10), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpCountry", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(11), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpPhoneNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(12), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpMobileNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(13), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpFaxNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(14), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpEMail", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(15), ParaDirection.Input, True)
                    If ds_Excel.Tables(0).Rows(i)(16) = "" Then
                        obj.AddCmdParameter("@UpBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
                    Else
                        obj.AddCmdParameter("@UpBirthDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(16), ParaDirection.Input, True)
                    End If
                    If ds_Excel.Tables(0).Rows(i)(17) = "" Then
                        obj.AddCmdParameter("@UpAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
                    Else
                        obj.AddCmdParameter("@UpAnniDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(17), ParaDirection.Input, True)
                    End If

                    obj.AddCmdParameter("@UpCustType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(18), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpMobileNo2", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(19), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpBeneficiaryName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(20), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpBankAcType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(21), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpBankAcNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(22), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpIFSCCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(23), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpMICRCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(24), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpBankName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(25), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpBankAddress", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(26), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpAcContactPerson", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(27), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpAcContactNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(28), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpAcEmailId", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(29), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpTranSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(30), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpPromoSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(31), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpGSTNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(32), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpPANNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(33), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpTaxation", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(34), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpStateCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(35), ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpBrokerId", Dtype.int, 0, ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpRefId1", Dtype.int, 0, ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpRefId2", Dtype.int, 0, ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpIsActive", Dtype.Bit, True, ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpCountryCode", Dtype.varchar, "+91", ParaDirection.Input, True)
                    obj.AddCmdParameter("@UpLedgerId", Dtype.int, ds_Excel.Tables(0).Rows(i)(0), ParaDirection.Input, True)
                    obj.ExecuteCommand()

                    upRecords = upRecords + 1
                    Exit Select
            End Select
        Next

        MsgBox("Data Processed Successfully" & vbCrLf & "New Records: " & newRecords & vbCrLf & "Updated Records: " & upRecords, MsgBoxStyle.Information)

    End Sub

    Private Sub txtState_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbState.Validating
        setTaxation()
    End Sub

    Private Sub FrmCustomerMaster_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub gvData_Click(sender As Object, e As EventArgs) Handles gvData.Click
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length < 0 Then
            Exit Sub
        End If
        fillData()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnsave.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length < 0 Then
            Exit Sub
        End If
        fillData()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnsave.Enabled = False
        btnAdd.Enabled = False

        If checkRightsToEdit("CUSTOMER MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()
    End Sub

    Private Sub gvData_KeyUp(sender As Object, e As KeyEventArgs) Handles gvData.KeyUp
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length < 0 Then
            Exit Sub
        End If
        fillData()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnsave.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
        Dx_RenameColumn(gvData)
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvData, "FrmCustomerMaster", Me)
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        cmbF_Area.Text = "ALL"
    End Sub

    Private Sub btnAddArea_Click(sender As Object, e As EventArgs)
        Dim misctype As String = UCase(cmbArea.Text)

        If M_checkMiscMaster("Area", UCase(cmbArea.Text)) = False Then
            insertMiscMaster("Area", UCase(cmbArea.Text))
            'ComboFill(cmbArea, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Area') Order By MiscName")
            ComboFill(cmbArea, "Select AreaId , AreaName From tbl_AreaMaster Order By MiscName")
            cmbArea.Text = misctype
            MsgBox(misctype & " Added Successfully", MsgBoxStyle.Information)
        Else
            MsgBox(misctype & " Already Exist", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtAdd2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAdd2.Validating
        cmbArea.Focus()
    End Sub

    Private Sub cmbSalesPerson_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        btnsave.Focus()
    End Sub

    Private Sub txtDueDays_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDueDays.Validating
        txtGSTNo.Focus()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        gridfill(True)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        gridfill(True)
    End Sub

    Private Sub cmbF_Area_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbF_Area.SelectedValueChanged
        gridfill(True)
    End Sub

    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbArea.SelectedIndex > 0 Then
            cmbCity.SelectedValue = cmbArea.SelectedValue
            cmbState.SelectedValue = cmbArea.SelectedValue
            cmbCountry.SelectedValue = cmbArea.SelectedValue
            txtPinCode.Text = dsCmbCity.Tables(0).Select("AreaId=" & cmbArea.SelectedValue)(0)("Pincode").ToString()
        End If
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dx_ExportToExcel(gvData)
    End Sub

    Private Sub FrmCustomerMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.F2
                If btnAdd.Enabled = True Then btnAdd.PerformClick()

            Case Keys.F3
                If btnEdit.Enabled = True Then btnEdit.PerformClick()

            Case Keys.F5
                If btnRefresh.Enabled = True Then btnRefresh.PerformClick()

            Case Keys.F6
                If btnsave.Enabled = True Then btnsave.PerformClick()

            Case Keys.F7
                If btnDelete.Enabled = True Then btnDelete.PerformClick()

            Case Keys.F8
                If btnCancel.Enabled = True Then btnCancel.PerformClick()

            Case Keys.Escape

                escCount += 1

                If escCount = 1 Then
                    MsgBox("Press ESC again to close", MsgBoxStyle.Information)
                ElseIf escCount = 2 Then
                    Me.Close()
                End If

        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        txtAdd1.Focus()
    End Sub

    Public Sub LoadCustomerAutoComplete()
        Dim dsLedger As New DataSet

        sql_query = "SELECT LedgerName FROM tbl_LedgerMaster WHERE G_Id = 11 AND CId = " & M_CId
        obj.LoadData(sql_query, dsLedger)

        Dim collection As New AutoCompleteStringCollection()

        For Each row As DataRow In dt.Rows
            collection.Add(row("LedgerName").ToString())
        Next

        txtLedgerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtLedgerName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtLedgerName.AutoCompleteCustomSource = collection
    End Sub

    Public Function IsCustomerExists() As Boolean
        Dim result As Object

        If edit_ins = 1 Then
            ' Insert mode
            sql_query = "SELECT COUNT(*) FROM tbl_LedgerMaster 
                     WHERE LedgerName = '" & Trim(txtLedgerName.Text) & "' 
                     AND G_Id = 11 AND CId = " & M_CId
        Else
            ' Edit mode → ignore same record
            sql_query = "SELECT COUNT(*) FROM tbl_LedgerMaster 
                     WHERE LedgerName = '" & Trim(txtLedgerName.Text) & "' 
                     AND LedgerId <> " & Val(lblLedgerId.Text) & "
                     AND G_Id = 11 AND CId = " & M_CId
        End If

        result = obj.ScalarExecute(sql_query)

        Return Val(result) > 0
    End Function

#End Region

End Class