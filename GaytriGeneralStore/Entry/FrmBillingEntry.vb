Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmBillingEntry

    'Copy of INVOICE MASTER just need  changes
#Region "Comments"
    'Name:Gayatry
    'Created By:Manav
    'Form:FrmBillingEntry
    'Date:07/03/2026
#End Region

#Region "Declaration"
    Dim ds As New Data.DataSet
    Dim dsComboGM As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String
    Dim edit_ins As Integer = -1
    Dim existBillNo As String
    Dim oldLedgerCode As String
    Dim point As Boolean = False
    Dim _LedgerCodeInitial As String = ""
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim escCount As Integer
#End Region


#Region "Method"

    Public Sub formatGrid()
        gvData.Columns("InvoiceNo").Caption = "invoice No"
        gvData.Columns("InvId").Visible = False
        gvData.Columns("InvoiceNumber").Caption = "Bill Number"
        gvData.Columns("InvoiceDate").Caption = "Bill Date"
        gvData.Columns("LedgerId").Visible = False
        gvData.Columns("WorkDays").Visible = False
        gvData.Columns("DeliveryDate").Visible = False
        gvData.Columns("TrialDate").Visible = False
        gvData.Columns("DiscPer").Visible = False
        gvData.Columns("Discount").Visible = False
        gvData.Columns("SalesAcType").Visible = False
        gvData.Columns("TIRINo").Visible = False
        gvData.Columns("TIRINumber").Visible = False
        gvData.Columns("Creditdays").Visible = False
        gvData.Columns("TS_Id").Visible = False
        gvData.Columns("V_Id").Visible = False
        gvData.Columns("CST_Per").Visible = False
        gvData.Columns("CST_Amt").Visible = False
        gvData.Columns("CST_AddPer").Visible = False
        gvData.Columns("CST_AddAmt").Visible = False
        gvData.Columns("VAT_Per").Visible = False
        gvData.Columns("VAT_Amt").Visible = False
        gvData.Columns("VAT_AddPer").Visible = False
        gvData.Columns("VAT_AddAmt").Visible = False
        gvData.Columns("FreightAmt").Visible = False
        gvData.Columns("AdjustAmt").Visible = False
        gvData.Columns("SalesBillAmt").Visible = False
        gvData.Columns("CId").Visible = False
        gvData.Columns("Sys_Name").Visible = False
        gvData.Columns("Sys_Time").Visible = False
        gvData.Columns("CurrUsr").Visible = False
        gvData.Columns("AcInvoiceNo").Visible = False
        gvData.Columns("AcInvoiceDate").Visible = False
        gvData.Columns("FeedbackDTM").Visible = False
        gvData.Columns("Rating").Visible = False
        gvData.Columns("Feedback").Visible = False
        gvData.Columns("PmtMode").Visible = False
        gvData.Columns("PmtNarration").Visible = False
        gvData.Columns("Remark1").Visible = False
        gvData.Columns("Remark2").Visible = False
        gvData.Columns("Remark3").Visible = False
        gvData.Columns("SP1Per").Visible = False
        gvData.Columns("SP1Amt").Visible = False
        gvData.Columns("SP1Comm").Visible = False
        gvData.Columns("SP2").Visible = False
        gvData.Columns("SP2Per").Visible = False
        gvData.Columns("SP2Amt").Visible = False
        gvData.Columns("SP2Comm").Visible = False
        gvData.Columns("TokenNo").Visible = False
        gvData.Columns("IE_Gst").Visible = False
        gvData.Columns("Measurementby_Id").Visible = False

        gvData.Columns("CNAmt").Visible = False
        gvData.Columns("LedgerName").Caption = "Customer Name"
        gvData.Columns("SP1").Caption = "Collection Person"
        gvData.Columns("TotalAmt").Caption = "Total Amt"
        gvData.Columns("ReceivedAmt").Caption = "Received Amt"
        gvData.Columns("DueAmt").Caption = "Due Amt"
        gvData.Columns("SalesDueDate").Visible = True
        gvData.Columns("OrderFlag").Caption = "Deleted record"
        gvData.Columns("Reference").Caption = "References"
    End Sub

    Public Sub gridfill(ByVal topRows As String)
        Dim _filter As String = ""

        ds.Clear()

        'If cmbF_Area.Text <> "ALL" Then
        '    _filter = " And AcContactPerson = '" & Trim(cmbF_Area.Text) & "'"
        'End If

        sql_query = "Select " & topRows & " * From  View_InvoiceMaster order by InvId desc"

        obj.LoadData(sql_query, ds)
        gcData.DataSource = ds.Tables(0).DefaultView

        gvData.OptionsView.ColumnAutoWidth = False
        gvData.BestFitColumns()
        formatGrid()

        RestoreLayout(gvData, "FrmBillingMaster")
        'lblTotalRecords.Text = "📋 " & gvData.RowCount & " Records"

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

    'Public Sub Fill_Ledger()
    '    Dim dsLedger As New DataSet()
    '    'Select Case UCase(M_CompanyWisePurchase)
    '    '    Case "YES"
    '    '        sql_query = "Select LedgerId, Code, LedgerCode, LedgerName, MobileNo, City, State, Taxation, FaxNo, AcContactPerson From tbl_LedgerMaster Where G_Id In (11) And CId = " & M_CId & " Order By LedgerName"
    '    '        Exit Select
    '    '    Case Else
    '    '        sql_query = "Select LedgerId, Code, LedgerCode, LedgerName, MobileNo, City, State, Taxation, FaxNo, AcContactPerson From tbl_LedgerMaster Where G_Id In (11) Order By LedgerName"
    '    '        Exit Select
    '    'End Select

    '    'obj.LoadData(sql_query, dsLedger)
    '    dv.RowFilter = "G_Id = 11 "
    '    dt = dv.ToTable()

    '    cmbLedger.Properties.DataSource = dt.DefaultView

    '    cmbLedger.Properties.ValueMember = "LedgerId"
    '    cmbLedger.Properties.DisplayMember = "LedgerName"
    '    cmbLedger.Properties.PopulateViewColumns()

    '    'Dim visibleCols() As String = {"Code", "LedgerCode", "LedgerName", "MobileNo", "AreaName", "City", "State", "SP_LedgerName", "CP_LedgerName"}
    '    Dim visibleCols() As String = {"Code", "LedgerCode", "LedgerName", "MobileNo", "AreaName", "City", "State", "SP_LedgerName", "CP_LedgerName", "AcContactPerson"}
    '    For Each col As DevExpress.XtraGrid.Columns.GridColumn In cmbLedger.Properties.View.Columns
    '        If visibleCols.Contains(col.FieldName) Then
    '            col.Visible = True
    '        Else
    '            col.Visible = False
    '        End If
    '    Next
    '    cmbLedger.Properties.View.Columns("Code").Caption = "SrNo"
    '    cmbLedger.Properties.View.Columns("LedgerCode").Caption = "Code"
    '    cmbLedger.Properties.View.Columns("LedgerName").Caption = "customer Name"
    '    cmbLedger.Properties.View.Columns("LedgerName").Width = 350
    '    cmbLedger.Properties.View.Columns("CP_LedgerName").Caption = "CP Name"
    '    cmbLedger.Properties.View.Columns("SP_LedgerName").Caption = "SP Name"

    '    cmbLedger.Properties.View.Columns("AcContactPerson").Visible = False

    '    cmbLedger.Properties.View.BestFitColumns()
    '    cmbLedger.Properties.View.OptionsView.ColumnAutoWidth = True
    '    cmbLedger.Properties.PopupFormWidth = 850
    '    cmbLedger.Properties.View.Appearance.Row.Font = New Font("Segoe UI", 11)
    '    cmbLedger.Properties.View.Appearance.HeaderPanel.Font = New Font("Segoe UI", 11, FontStyle.Bold)
    '    cmbLedger.Properties.View.RowHeight = 28
    'End Sub

    Public Sub fill_ledger()
        Dim dsLedger As New DataSet

        sql_query = "Select LedgerId, Code, LedgerCode, LedgerName, MobileNo, AreaName, City, State, SP_LedgerName, CP_LedgerName, CP_LedgerId, Address1, Address2, Pincode, Country, State From View_LedgerMaster_Gaytari Where G_Id = 11 And CId = " & M_CId & " Order By LedgerName"

        obj.LoadData(sql_query, dsLedger)

        cmbLedger.Properties.DataSource = dsLedger.Tables(0)
        cmbLedger.Properties.ValueMember = "LedgerId"
        cmbLedger.Properties.DisplayMember = "LedgerName"

        cmbLedger.Properties.PopulateViewColumns()

        Dim visibleCols() As String = {"Code", "LedgerCode", "LedgerName", "MobileNo", "AreaName", "City", "State", "SP_LedgerName", "CP_LedgerName"}

        For Each col As DevExpress.XtraGrid.Columns.GridColumn In cmbLedger.Properties.View.Columns
            If visibleCols.Contains(col.FieldName) Then
                col.Visible = True
            Else
                col.Visible = False
            End If
        Next

        cmbLedger.Properties.View.Columns("Code").Caption = "SrNo"
        cmbLedger.Properties.View.Columns("LedgerCode").Caption = "Code"
        cmbLedger.Properties.View.Columns("LedgerName").Caption = "Customer Name"
        cmbLedger.Properties.View.Columns("LedgerName").Width = 350
        cmbLedger.Properties.View.Columns("CP_LedgerName").Caption = "CP Name"
        cmbLedger.Properties.View.Columns("SP_LedgerName").Caption = "SP Name"

        cmbLedger.Properties.PopupFormWidth = 850
        cmbLedger.Properties.View.BestFitColumns()
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
            getBillNo()
        End If

        obj.Prepare("SP_InsertInvoiceMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsInvoiceNo", Dtype.int, Trim(txtBillNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsInvoiceDate", Dtype.DateTime, dtpBillDate.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsLedgerId", Dtype.int, cmbLedger.EditValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsReference", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsWorkDays", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsDeliveryDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTrialDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTotalAmt", Dtype.float, Val(txtBillAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsDiscPer", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsDiscount", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsBillAmt", Dtype.float, Val(txtBillAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsReceivedAmt", Dtype.float, Val(txtReceivedAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsDueAmt", Dtype.float, Val(txtDueAmt.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsRemarks", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSalesAcType", Dtype.varchar, cmbSeries.Text, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsInvoiceNumber", Dtype.varchar, Trim(txtBillNumber.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTIRINo", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTIRINumber", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCreditdays", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSalesDueDate", Dtype.DateTime, dtpSalesDueDate.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsTS_Id", Dtype.int, 7, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsV_Id", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCST_Per", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCST_Amt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCST_AddPer", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCST_AddAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsVAT_Per", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsVAT_Amt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsVAT_AddPer", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsVAT_AddAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsFreightAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsAdjustAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSalesBillAmt", Dtype.float, Val(txtBillAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSys_Name", Dtype.varchar, My.Computer.Name, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsSys_Time", Dtype.DateTime, Date.Now, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCurrUsr", Dtype.varchar, loggedUser, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsOrderFlag", Dtype.varchar, "", ParaDirection.Input, True)
        Dim cp As String = ""

        If cmbCollectionPerson.SelectedValue IsNot Nothing Then
            cp = cmbCollectionPerson.SelectedValue.ToString()
        End If

        obj.AddCmdParameter("@InsSP1", Dtype.nvarchar, cp, ParaDirection.Input, True)

        'obj.AddCmdParameter("@InsSP1", Dtype.nvarchar, cmbCollectionPerson.SelectedValue, ParaDirection.Input, True)
        obj.ExecuteCommand()

        'If Val(txtOpBal.Text) <> 0 Then
        '    sql_query = "Select IsNull(Max(LedgerId),0) From tbl_LedgerMaster Where LedgerCode = '" & Trim(cmbLedger.Text) & "'"
        '    setOpeningBalance(obj.ScalarExecute(sql_query))
        'End If

        'sql_query = "Select IsNull(Max(LedgerId),0) From tbl_LedgerMaster Where LedgerCode = '" & Trim(cmbLedger.Text) & "'"
        'lblLedgerId.Text = obj.ScalarExecute(sql_query)
    End Sub

    Public Sub insertMiscMaster(ByVal _MiscType As String, ByVal _MiscName As String)
        sql_query = "Insert into tbl_MiscMaster (MiscType, MiscName, CId, IsActive) values ('" & _MiscType & "','" & _MiscName & "',1,'True')"
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub edit() 'Company Id is not Updated

        obj.Prepare("SP_UpdateInvoiceMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@UpInvoiceNo", Dtype.int, Val(txtBillNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpInvoiceDate", Dtype.DateTime, dtpBillDate.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerId", Dtype.int, Val(cmbLedger.EditValue), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpReference", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpWorkDays", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpDeliveryDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTrialDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTotalAmt", Dtype.float, Val(txtBillAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpDiscPer", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpDiscount", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBillAmt", Dtype.float, Val(txtBillAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpReceivedAmt", Dtype.float, Val(txtReceivedAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpDueAmt", Dtype.float, Val(txtDueAmt.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpRemarks", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSalesAcType", Dtype.varchar, cmbSeries.Text, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpInvoiceNumber", Dtype.varchar, Trim(txtBillNumber.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTIRINo", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTIRINumber", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCreditdays", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSalesDueDate", Dtype.DateTime, dtpSalesDueDate.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpTS_Id", Dtype.int, 7, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpV_Id", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCST_Per", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCST_Amt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCST_AddPer", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCST_AddAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpVAT_Per", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpVAT_Amt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpVAT_AddPer", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpVAT_AddAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpFreightAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAdjustAmt", Dtype.float, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSalesBillAmt", Dtype.float, Val(txtBillAmount.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpRemark1", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpRemark2", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpRemark3", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpOrderFlag", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpInvId", Dtype.int, Val(lblInvId.Text), ParaDirection.Input, True)
        Dim cp As String = ""

        If cmbCollectionPerson.SelectedValue IsNot Nothing Then
            cp = cmbCollectionPerson.SelectedValue.ToString()
        End If

        obj.AddCmdParameter("@UPSP1", Dtype.nvarchar, cp, ParaDirection.Input, True)
        'obj.AddCmdParameter("@UPSP1", Dtype.nvarchar, cmbCollectionPerson.SelectedValue, ParaDirection.Input, True)
        obj.ExecuteCommand()

        'setOpeningBalance(Val(lblLedgerId.Text))

    End Sub

    'Public Sub setOpeningBalance(ByVal ledgerId As Integer)
    '    Dim _YrTo As String = "_" & M_dsFinYr.Tables(0).Rows(M_FinYrIndx)("YrSuffix")
    '    If edit_ins = 0 Then
    '        sql_query = "Delete from tbl_LedgerOpeningBalance" & _YrTo & " Where LedgerId = " & ledgerId
    '        obj.QueryExecute(sql_query)
    '    End If

    '    Select Case cmbDrCr.Text
    '        Case "Cr"
    '            sql_query = "Insert Into tbl_LedgerOpeningBalance" & _YrTo & " (LedgerId, DrOpening, CrOpening, DrCr, LastYrDr, LastYrCr, Remark) Values(" _
    '                & ledgerId & ",0," & Math.Abs(Val(txtOpBal.Text)) & ",'Cr',0,0,0)"
    '            obj.QueryExecute(sql_query)
    '            Exit Select
    '        Case "Dr"
    '            sql_query = "Insert Into tbl_LedgerOpeningBalance" & _YrTo & " (LedgerId, DrOpening, CrOpening, DrCr, LastYrDr, LastYrCr, Remark) Values(" _
    '                & ledgerId & "," & Math.Abs(Val(txtOpBal.Text)) & ",0,'Dr',0,0,0)"
    '            obj.QueryExecute(sql_query)
    '            Exit Select
    '    End Select
    'End Sub

    Public Sub del()
        sql_query = "update tbl_InvoiceMaster set OrderFlag = 'deleted' where InvId = " & Val(lblInvId.Text)
        'sql_query = "Delete From tbl_InvoiceMaster where InvId = " & Val(lblInvId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub loadTime()
        '_LedgerCodeInitial = "C"


        'cmbF_CustType.SelectedIndex = 0
        'cmbDrCr.SelectedIndex = 0

        ComboFill(cmbSeries, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Prefix') Order By MiscName")
        ComboFill(cmbSuffix, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Suffix') Order By MiscName")
        ComboFill(cmbCollectionPerson, "Select LedgerId , LedgerName From tbl_LedgerMaster Where G_Id = 30 And CId = " & M_CId & " Order By LedgerName")
        'ComboFill(cmbCollectionPerson, "Select LedgerId , LedgerName From tbl_LedgerMaster Where CId = " & M_CId & " and G_Id = 30 Order By LedgerName")

        'ComboFill(cmbCity, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('City') Order By MiscName")
        'ComboFill(cmbState, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('State') Order By MiscName")
        'ComboFill(cmbCountry, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Country') Order By MiscName")
        'ComboFill(cmbSalesPerson, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Sales Person') Order By MiscName")
        'ComboFill(cmbCollectionPerson, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Collection Person') Order By MiscName")
        'ComboFill_Search(cmbF_Area, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Area') Order By MiscName")
        Fill_Ledger()
        gridfill(M_TopRows)

        btn_Add.Enabled = True
        btn_Edit.Enabled = False
        btn_save.Enabled = False
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True
        gcData.Enabled = True
        grpBillingInfo.Enabled = False
    End Sub

    Public Sub addClickTime()
        grpBillingInfo.Enabled = True
        gcData.Enabled = False

        btn_Add.Enabled = False
        btn_Edit.Enabled = False
        btn_save.Enabled = True
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True

        getBillNo()
        cmbSeries.Focus()
        cmbSeries.DroppedDown = True
        edit_ins = 1

        txtDueAmt.Text = txtBillAmount.Text
        txtReceivedAmount.Text = 0
    End Sub

    Public Sub editClickTime()
        grpBillingInfo.Enabled = True
        gcData.Enabled = False

        btn_Add.Enabled = False
        btn_Edit.Enabled = False
        btn_save.Enabled = True
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True

        edit_ins = 0
        oldLedgerCode = Trim(cmbLedger.Text)
        txtBillAmount.Focus()
    End Sub

    Public Sub saveClickTime()
        gridfill(M_TopRows)
        grpBillingInfo.Enabled = False
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
        cmbLedger.Text = ""
        'txtLedgerName.Clear()
        'txtDisplaySrNo.Clear()
        txtAdd1.Clear()
        txtAdd2.Clear()
        txtPincode.Clear()
        'txtGSTNo.Clear()
        'txtPhone.Clear()
        txtMobile.Clear()
        'txtDueDays.Text = 0
        'txtEMailId.Clear()

        cmbCollectionPerson.SelectedIndex = -1
        'txtOpBal.Clear()
    End Sub

    Public Sub deleteClickTime()
        gridfill(M_TopRows)
        grpBillingInfo.Enabled = False
        gcData.Enabled = True

        btn_Add.Enabled = True
        btn_Edit.Enabled = False
        btn_save.Enabled = False
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        'btnExit.Enabled = True
        btn_Add.Focus()


        cmbLedger.Text = ""
        txtBillAmount.Clear()
        txtBillNo.Clear()
        txtBillNumber.Clear()
        txtCountry.Clear()
        txtAdd1.Clear()
        txtAdd2.Clear()
        txtAreaCity.Clear()
        txtState.Clear()
        txtAdd1.Clear()
        txtAdd2.Clear()
        txtPincode.Clear()
        'txtPhone.Clear()
        txtMobile.Clear()
        cmbCollectionPerson.Text = ""
        cmbSeries.Text = ""

        edit_ins = -1
    End Sub

    Public Sub cancelClickTime()
        grpBillingInfo.Enabled = False
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

    Public Sub fillData()
        If gvData.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        lblInvId.Text = gvData.GetFocusedRowCellValue("InvId")
        txtBillNo.Text = gvData.GetFocusedRowCellValue("InvoiceNo")
        cmbLedger.EditValue = gvData.GetFocusedRowCellValue("LedgerId")
        txtBillNumber.Text = gvData.GetFocusedRowCellValue("InvoiceNumber")
        txtAdd1.Text = gvData.GetFocusedRowCellValue("Address1")
        txtAdd2.Text = gvData.GetFocusedRowCellValue("Address2")
        txtAreaCity.Text = gvData.GetFocusedRowCellValue("City")
        txtPincode.Text = gvData.GetFocusedRowCellValue("PinCode")
        txtState.Text = gvData.GetFocusedRowCellValue("State")
        txtCountry.Text = gvData.GetFocusedRowCellValue("Country")
        txtMobile.Text = gvData.GetFocusedRowCellValue("MobileNo")
        cmbCollectionPerson.SelectedValue = gvData.GetFocusedRowCellValue("SP1")

    End Sub

    Public Sub getBillNo()
        'sql_query = "Select IsNull(Max(InvoiceNo),0) + 1 From tbl_InvoiceMaster Where ISNULL(SalesAcType,'') = '" & Trim(cmbSeries.Text) & "' And CId = " & M_CId
        sql_query = "Select IsNull(Max(InvoiceNo),0) + 1 From tbl_InvoiceMaster Where CId = " & M_CId
        txtBillNo.Text = obj.ScalarExecute(sql_query)
    End Sub


#End Region

#Region "function"

    Public Function checkBillNo() As Boolean
        'If M_AllwDupLcode = "Yes" Then
        '    Return False
        'End If

        If edit_ins = 1 Then
            existBillNo = obj.ScalarExecute("select InvoiceNo from Tbl_InvoiceMaster where InvoiceNo ='" & Trim(txtBillNo.Text) & "' And CId = " & M_CId)
            If Trim(txtBillNo.Text) = existBillNo Then
                Return True
            Else
                Return False
            End If
        Else
            existBillNo = obj.ScalarExecute("select InvoiceNo from Tbl_InvoiceMaster where InvId <>" & Val(lblInvId.Text) & " and InvoiceNo ='" & Trim(txtBillNo.Text) & "' And CId = " & M_CId)
            If Trim(txtBillNo.Text) = existBillNo Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

#End Region

#Region "Events"

    Private Sub FrmLedgerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCase(M_ValidateMobileNoLength) = "YES" Then
            txtMobile.MaxLength = Val(M_MobileNoLength)
        End If

        Me.KeyPreview = True

        If M_GenerateCustomerNumberSaveTime = "Yes" Then
            cmbLedger.ReadOnly = True
            cmbLedger.TabStop = False
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
                btn_Add.Focus()
                Exit Select
        End Select

        txtName.CharacterCasing = CharacterCasing.Upper
        txtAdd1.CharacterCasing = CharacterCasing.Upper
        txtAdd2.CharacterCasing = CharacterCasing.Upper

        'cmbCountry.Text = "INDIA"
        'cmbArea.SelectedIndex = -1
        'cmbCity.SelectedIndex = -1
        cmbCollectionPerson.SelectedIndex = -1
        'cmbState.SelectedIndex = -1
        'cmbF_Area.Text = "ALL"

        dtpBillDate.Value = Date.Today

    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        'If checkRightsToAdd("INVOICE MASTER") = False Then
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

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        'If checkRightsToEdit("INVOICE MASTER") = False Then
        '    MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        editClickTime()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Trim(cmbLedger.Text) = "" Then
            MsgBox("Please Specify Ledger Code", MsgBoxStyle.Information)
            cmbLedger.Focus()
            Exit Sub
        End If

        If Trim(txtName.Text) = "" Then
            MsgBox("Please Specify Ledger Name", MsgBoxStyle.Information)
            txtName.Focus()
            Exit Sub
        End If

        If Val(txtBillAmount.Text) <= 0 Then
            MsgBox("Please Specify BillAmt", MsgBoxStyle.Information)
            txtBillAmount.Focus()
            Exit Sub
        End If

        If checkBillNo() = True Then
            MsgBox("Bill no Already Exists, Please Specify Another One", MsgBoxStyle.Critical)
            cmbLedger.Focus()
            Exit Sub
        End If
        If Trim(txtMobile.Text) <> "" And Trim(txtMobile.Text.Length) <> M_MobileNoLength Then
            MsgBox("Please Specify Correct Mobile Number (10 Digits Required)", MsgBoxStyle.Information)
            Exit Sub
        End If
        If checkBillNo() = True Then
            MsgBox("Duplicate BillNo Please Apecify Another", MsgBoxStyle.Critical)
            txtBillNo.Focus()
            Exit Sub
        End If


        If edit_ins = 1 Then
            insert()
        Else
            edit()
        End If

        saveClickTime()
        addClickTime()
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        'sql_query = "Select Count(*) From tbl_VoucherEntryMast Where " & Val(lblInvId.Text) & " In (DrLedgerId, CrLedgerId)"
        'If obj.ScalarExecute(sql_query) > 0 Then
        '    MsgBox("Unable To Delete Ledger, Reference Records Found", MsgBoxStyle.Information)
        '    Exit Sub
        'End If


        Dim dr As DialogResult
        dr = MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            del()
            deleteClickTime()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        cancelClickTime()
    End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    '    exitClickTime()
    'End Sub

#End Region

#Region "Navigation"

    Private Sub cmbLedger_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Trim(cmbLedger.Text) = "" Then
                Exit Sub
            End If
            txtName.Focus()
        End If
    End Sub

    Private Sub cmbCollectionPerson_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.DroppedDown = True
        If sender.SelectedIndex = -1 And sender.Items.Count > 0 Then
            sender.SelectedIndex = 0
        End If
    End Sub

    'Private Sub txtOpBal_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpBal.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        If Trim(sender.Text) = "" Then
    '            sender.Text = "0"
    '        End If
    '        SendKeys.Send("{Tab}")
    '    End If

    '    'If e.KeyChar = Chr(8) Then
    '    '    Exit Sub
    '    'End If
    '    'If Not sender.Text.Contains(".") Then
    '    '    point = False
    '    'End If
    '    'If e.KeyChar = Chr(46) And point = False Then
    '    '    point = True
    '    '    Exit Sub
    '    'End If
    '    'If checkNumber(Asc(e.KeyChar)) = False Then
    '    '    e.KeyChar = Chr(0)
    '    'End If
    'End Sub

#End Region

#Region "Other"

    'Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    '    Dim ds_Excel As New Data.DataSet
    '    ds_Excel.Clear()
    '    obj.LoadData_Excel("SELECT * FROM [Sheet1$]", ds_Excel, "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & OpenFileDialog1.FileName & "; Extended Properties=""Excel 8.0; HDR=Yes; IMEX=1""")

    '    Dim newRecords As Integer = 0
    '    Dim upRecords As Integer = 0

    '    For i As Integer = 1 To ds_Excel.Tables(0).Rows.Count - 1
    '        For j As Integer = 0 To ds_Excel.Tables(0).Columns.Count - 1
    '            If IsDBNull(ds_Excel.Tables(0).Rows(i)(j)) Then
    '                ds_Excel.Tables(0).Rows(i)(j) = ""
    '            End If
    '        Next
    '    Next

    '    For i As Integer = 0 To ds_Excel.Tables(0).Rows.Count - 1
    '        Select Case ds_Excel.Tables(0).Rows(i)(0) 'ItemId
    '            Case 0 'Insert
    '                obj.Prepare("SP_InsertLedgerMaster_0507", SpType.StoredProcedure)
    '                obj.AddCmdParameter("@InsCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(1), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsLedgerCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(2), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsLedgerName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(3), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsG_Id", Dtype.int, ds_Excel.Tables(0).Rows(i)(4), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsAddress1", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(6), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsAddress2", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(7), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsCity", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(8), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsPinCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(9), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsState", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(10), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsCountry", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(11), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsPhoneNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(12), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsMobileNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(13), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsFaxNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(14), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsEMail", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(15), ParaDirection.Input, True)
    '                If ds_Excel.Tables(0).Rows(i)(16) = "" Then
    '                    obj.AddCmdParameter("@InsBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
    '                Else
    '                    obj.AddCmdParameter("@InsBirthDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(16), ParaDirection.Input, True)
    '                End If
    '                If ds_Excel.Tables(0).Rows(i)(17) = "" Then
    '                    obj.AddCmdParameter("@InsAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
    '                Else
    '                    obj.AddCmdParameter("@InsAnniDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(17), ParaDirection.Input, True)
    '                End If

    '                obj.AddCmdParameter("@InsCustType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(18), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsMobileNo2", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(19), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsBeneficiaryName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(20), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsBankAcType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(21), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsBankAcNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(22), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsIFSCCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(23), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsMICRCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(24), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsBankName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(25), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsBankAddress", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(26), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsAcContactPerson", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(27), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsAcContactNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(28), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsAcEmailId", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(29), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsTranSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(30), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsPromoSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(31), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsGSTNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(32), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsPANNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(33), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsTaxation", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(34), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsStateCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(35), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsCId", Dtype.int, M_CId, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsBrokerId", Dtype.int, 0, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsRefId1", Dtype.int, 0, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsRefId2", Dtype.int, 0, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsIsActive", Dtype.Bit, True, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@InsCountryCode", Dtype.varchar, "+91", ParaDirection.Input, True)
    '                obj.ExecuteCommand()

    '                newRecords = newRecords + 1
    '                Exit Select
    '            Case Is > 0 'Update
    '                obj.Prepare("SP_UpdateLedgerMaster_0507", SpType.StoredProcedure) 'SP_UpdateLedgerMaster_CustMast
    '                obj.AddCmdParameter("@UpCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(1), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpLedgerCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(2), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpLedgerName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(3), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpG_Id", Dtype.int, ds_Excel.Tables(0).Rows(i)(4), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpAddress1", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(6), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpAddress2", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(7), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpCity", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(8), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpPinCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(9), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpState", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(10), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpCountry", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(11), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpPhoneNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(12), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpMobileNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(13), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpFaxNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(14), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpEMail", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(15), ParaDirection.Input, True)
    '                If ds_Excel.Tables(0).Rows(i)(16) = "" Then
    '                    obj.AddCmdParameter("@UpBirthDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
    '                Else
    '                    obj.AddCmdParameter("@UpBirthDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(16), ParaDirection.Input, True)
    '                End If
    '                If ds_Excel.Tables(0).Rows(i)(17) = "" Then
    '                    obj.AddCmdParameter("@UpAnniDate", Dtype.DateTime, DBNull.Value, ParaDirection.Input, True)
    '                Else
    '                    obj.AddCmdParameter("@UpAnniDate", Dtype.DateTime, ds_Excel.Tables(0).Rows(i)(17), ParaDirection.Input, True)
    '                End If

    '                obj.AddCmdParameter("@UpCustType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(18), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpMobileNo2", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(19), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpBeneficiaryName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(20), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpBankAcType", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(21), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpBankAcNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(22), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpIFSCCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(23), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpMICRCode", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(24), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpBankName", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(25), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpBankAddress", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(26), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpAcContactPerson", Dtype.nvarchar, ds_Excel.Tables(0).Rows(i)(27), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpAcContactNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(28), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpAcEmailId", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(29), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpTranSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(30), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpPromoSMS", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(31), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpGSTNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(32), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpPANNo", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(33), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpTaxation", Dtype.varchar, ds_Excel.Tables(0).Rows(i)(34), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpStateCode", Dtype.int, ds_Excel.Tables(0).Rows(i)(35), ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpBrokerId", Dtype.int, 0, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpRefId1", Dtype.int, 0, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpRefId2", Dtype.int, 0, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpIsActive", Dtype.Bit, True, ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpCountryCode", Dtype.varchar, "+91", ParaDirection.Input, True)
    '                obj.AddCmdParameter("@UpLedgerId", Dtype.int, ds_Excel.Tables(0).Rows(i)(0), ParaDirection.Input, True)
    '                obj.ExecuteCommand()

    '                upRecords = upRecords + 1
    '                Exit Select
    '        End Select
    '    Next

    '    MsgBox("Data Processed Successfully" & vbCrLf & "New Records: " & newRecords & vbCrLf & "Updated Records: " & upRecords, MsgBoxStyle.Information)

    'End Sub

    Private Sub txtState_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtState.Validating
        'setTaxation()
    End Sub

    Private Sub FrmCustomerMaster_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
        gvData.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvData.FocusedColumn.FieldName)
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvData, "FrmCustomerMaster", Me)
    End Sub

    'Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
    '    txtSearch.Clear()
    'End Sub

    'Private Sub btnAddArea_Click(sender As Object, e As EventArgs) Handles btnAddArea.Click
    '    Dim misctype As String = UCase(cmbArea.Text)

    '    If M_checkMiscMaster("Area", UCase(cmbArea.Text)) = False Then
    '        insertMiscMaster("Area", UCase(cmbArea.Text))
    '        ComboFill(cmbArea, "Select MiscId , MiscName From Tbl_MiscMaster Where CId = " & M_CId & " And MiscType in ('Area') Order By MiscName")
    '        cmbArea.Text = misctype
    '        MsgBox(misctype & " Added Successfully", MsgBoxStyle.Information)
    '    Else
    '        MsgBox(misctype & " Already Exist", MsgBoxStyle.Information)
    '    End If
    'End Sub


    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        gridfill("")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        gridfill("")
    End Sub

    Private Sub cmbLedger_EditValueChanged(sender As Object, e As EventArgs) Handles cmbLedger.EditValueChanged
        FillCustomerDetails()

        'Dim slkp As DevExpress.XtraEditors.SearchLookUpEdit = sender

        'txtName.Text = slkp.Properties.View.GetFocusedRowCellValue("LedgerName")
        'txtPincode.Text = slkp.Properties.View.GetFocusedRowCellValue("Pincode")
        'txtAdd1.Text = slkp.Properties.View.GetFocusedRowCellValue("Address1")
        'txtAdd2.Text = slkp.Properties.View.GetFocusedRowCellValue("Address2")
        'txtMobile.Text = slkp.Properties.View.GetFocusedRowCellValue("MobileNo")
        'txtState.Text = slkp.Properties.View.GetFocusedRowCellValue("State")
        'txtCountry.Text = slkp.Properties.View.GetFocusedRowCellValue("Country")
        'txtAreaCity.Text = slkp.Properties.View.GetFocusedRowCellValue("AreaName") & " - " & slkp.Properties.View.GetFocusedRowCellValue("City")
        'Dim cpId As Object = slkp.Properties.View.GetFocusedRowCellValue("CP_LedgerId")

        'If cpId IsNot Nothing AndAlso Not IsDBNull(cpId) Then
        '    cmbCollectionPerson.SelectedValue = cpId
        'Else
        '    cmbCollectionPerson.SelectedIndex = -1
        'End If

        'cmbCollectionPerson.SelectedValue = slkp.Properties.View.GetFocusedRowCellValue("SP1")
        'cmbCollectionPerson.Focus()
    End Sub

    Private Sub txtBillNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBillNo.Validating
        Select Case UCase(Trim(cmbSeries.Text))
            Case "REGULAR"
                txtBillNumber.Text = txtBillNo.Text
            Case Else
                txtBillNumber.Text = Trim(cmbSeries.Text & txtBillNo.Text & cmbSuffix.Text)
        End Select
    End Sub

    Private Sub cmbSeries_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbSeries.Validating, cmbSuffix.Validating
        If Val(cmbSeries.SelectedIndex) > -1 Then
            getBillNo()
            Select Case UCase(Trim(cmbSeries.Text))
                Case "REGULAR"
                    txtBillNumber.Text = txtBillNo.Text
                Case Else
                    txtBillNumber.Text = Trim(cmbSeries.Text & txtBillNo.Text & cmbSuffix.Text)
            End Select
        End If
    End Sub

    Private Sub txtBillNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtState.KeyPress, dtpSalesDueDate.KeyPress, txtSearch.KeyPress, txtPincode.KeyPress, txtName.KeyPress, txtMobile.KeyPress, txtCountry.KeyPress, txtBillNumber.KeyPress, txtAreaCity.KeyPress, txtAdd2.KeyPress, txtAdd1.KeyPress, dtpBillDate.KeyPress, cmbSuffix.KeyPress, cmbSeries.KeyPress, cmbLedger.KeyPress, cmbCollectionPerson.KeyPress, txtDueAmt.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbSuffix_Enter(sender As Object, e As EventArgs) Handles cmbSuffix.Enter, cmbSeries.Enter, cmbCollectionPerson.Enter
        sender.DroppedDown = True
        If sender.SelectedIndex = -1 And sender.Items.Count > 0 Then
            sender.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbLedger_Enter(sender As Object, e As EventArgs) Handles cmbLedger.Enter
        cmbLedger.ShowPopup()
    End Sub

    Private Sub txtBillAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReceivedAmount.KeyPress, txtDueAmt.KeyPress, txtBillNo.KeyPress, txtBillAmount.KeyPress
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

    Private Sub gvData_Click(sender As Object, e As EventArgs) Handles gvData.Click
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length <= 0 Then
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

        If selectedRows.Length <= 0 Then
            Exit Sub
        End If
        fillData()

        btn_Cancel.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        btn_save.Enabled = False
        btn_Add.Enabled = False

        'If checkRightsToEdit("BILL MASTER") = False Then
        '    MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        editClickTime()
    End Sub

    Private Sub txtBillAmount_TextChanged(sender As Object, e As EventArgs) Handles txtBillAmount.TextChanged
        txtDueAmt.Text = Val(txtBillAmount.Text) - Val(txtReceivedAmount.Text)
    End Sub

    Private Sub dtpSalesDueDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpSalesDueDate.Validating
        btn_save.Focus()
    End Sub

    Private Sub cmbLedger_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbLedger.Properties.ButtonClick
        Dim frm As New FrmCustomerMaster
        frm.OpenFromBilling = True

        frm.ShowDialog()

        If frm.NewLedgerId > 0 Then
            fill_ledger()
            cmbLedger.EditValue = frm.NewLedgerId
            FillCustomerDetails()
        End If
    End Sub

    Private Sub cmbLedger_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbLedger.KeyDown

        If e.KeyCode = Keys.F1 Then
            OpenCustomerMaster()
        End If

    End Sub

    Private Sub OpenCustomerMaster()
        Dim frm As New FrmCustomerMaster
        frm.OpenFromBilling = True
        frm.ShowDialog()

        If frm.NewLedgerId > 0 Then
            fill_ledger()
            cmbLedger.EditValue = frm.NewLedgerId
            cmbLedger.Properties.View.FocusedRowHandle = cmbLedger.Properties.View.LocateByValue("LedgerId", frm.NewLedgerId)
            FillCustomerDetails()
            cmbLedger.Focus()
        End If
    End Sub

    Private Sub cmbLedger_Popup(sender As Object, e As EventArgs) Handles cmbLedger.Popup

        'If e.KeyCode = Keys.F1 Then
        '    OpenCustomerMaster()
        'End If

    End Sub

    Private Sub FrmBillingEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.F2
                If btn_Add.Enabled = True Then btn_Add.PerformClick()

            Case Keys.F3
                If btn_Edit.Enabled = True Then btn_Edit.PerformClick()

            Case Keys.F5
                If btn_Refresh.Enabled = True Then btn_Refresh.PerformClick()

            Case Keys.F6
                If btn_save.Enabled = True Then btn_save.PerformClick()

            Case Keys.F7
                If btn_Delete.Enabled = True Then btn_Delete.PerformClick()

            Case Keys.F8
                If btn_Cancel.Enabled = True Then btn_Cancel.PerformClick()

            Case Keys.Escape

                escCount += 1

                If escCount = 1 Then
                    MsgBox("Press ESC again to close", MsgBoxStyle.Information)
                ElseIf escCount = 2 Then
                    Me.Close()
                End If

        End Select
    End Sub

    Private Sub FillCustomerDetails()

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = cmbLedger.Properties.View

        If view.FocusedRowHandle < 0 Then Exit Sub

        txtName.Text = view.GetFocusedRowCellValue("LedgerName")
        txtPincode.Text = view.GetFocusedRowCellValue("Pincode")
        txtAdd1.Text = view.GetFocusedRowCellValue("Address1")
        txtAdd2.Text = view.GetFocusedRowCellValue("Address2")
        txtMobile.Text = view.GetFocusedRowCellValue("MobileNo")
        txtState.Text = view.GetFocusedRowCellValue("State")
        txtCountry.Text = view.GetFocusedRowCellValue("Country")

        txtAreaCity.Text = view.GetFocusedRowCellValue("AreaName") & " - " & view.GetFocusedRowCellValue("City")

        Dim cpId As Object = view.GetFocusedRowCellValue("CP_LedgerId")

        If cpId IsNot Nothing AndAlso Not IsDBNull(cpId) Then
            cmbCollectionPerson.SelectedValue = cpId
        Else
            cmbCollectionPerson.SelectedIndex = -1
        End If

    End Sub

    'Private Sub cmbLedger_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbLedger.KeyDown

    '    If e.KeyCode = Keys.F2 Then

    '        Dim frm As New FrmCustomerMaster
    '        frm.ShowDialog()

    '        Fill_Ledger()

    '    End If

    'End Sub

    'Private Sub cmbF_Area_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbF_Area.SelectedValueChanged
    '    gridfill("")
    'End Sub

#End Region

End Class