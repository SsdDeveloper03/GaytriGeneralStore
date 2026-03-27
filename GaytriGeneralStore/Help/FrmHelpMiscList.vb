Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmHelpMiscList

#Region "Comments"
    'Name : ShivShakti
    'Created By : Manav
    'Form : FrmHelpMiscList
    'Date : 16/02/2026
#End Region

#Region "Declaration"

    Dim ds As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String

#End Region

#Region "Method"

    Public Sub insertMiscMaster(ByVal _MiscType As String, ByVal _MiscName As String)
        sql_query = "Insert into tbl_MiscMaster (MiscType, MiscName, CId, IsActive) values ('" & _MiscType & "','" & _MiscName & "',1,'True')"
        obj.QueryExecute(sql_query)

        MsgBox(_MiscType & " Added Successfully", MsgBoxStyle.Information)
        gridfill()
    End Sub

    Public Sub gridfill()
        Dim _filterCId As String
        If M_ManageCompanyWiseMiscMaster = "Yes" Then
            _filterCId = "And CId = " & M_CId
        End If

        Select Case M_callingForm_MiscHelp
            Case ""
                Exit Select
            Case "FrmLedgerMaster"
                ds.Clear()
                If Trim(txtMiscName.Text) = "" Then
                    sql_query = "Select * from View_MiscMaster where MiscType = 'City' and IsActive = 'True' " & _filterCId & "Order by MiscName"
                Else
                    sql_query = "Select * from View_MiscMaster where MiscType = 'City' and MiscName Like '" & Trim(txtMiscName.Text) & "%' and IsActive = 'True' " & _filterCId & "Order by MiscName"
                End If
                Exit Select
        End Select
    End Sub

#End Region

End Class


'    Public Sub gridfill()
'        Dim _filterCId As String = ""
'        If M_ManageCompanyWiseMiscMaster = "Yes" Then
'            _filterCId = " And CId = " & M_CId
'        End If

'        Select Case M_callingForm_MiscHelp
'            Case ""

'                Exit Select
'            Case "frmDirectChallanEntryNational_Origin", "frmDateWiseRate_Origin", "frmLR_Entry_Aasim_Origin", "frmLR_Entry_Vikas_Origin", "frmDateWiseRate_Destination" ', "frmDirectChallanEntryHired_Origin"
'                ds.Clear()
'                'If Trim(txtMiscName.Text) = "" Then
'                '    sql_query = "Select * from View_MiscMaster Where MiscType = 'From/To' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                'Else
'                '    sql_query = "select * from View_MiscMaster Where MiscType = 'From/To' And MiscName Like '" & Trim(txtMiscName.Text) & "%' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                'End If
'                If Trim(txtMiscName.Text) = "" Then
'                    sql_query = "select MiscName As MiscName from tbl_MiscMaster where MiscType In ('City','From/To')" _
'                      & " Union  " _
'                      & " select City As MiscName from tbl_LedgerMaster  " _
'                      & " Order By MiscName "
'                Else
'                    sql_query = "select MiscName As MiscName from tbl_MiscMaster where MiscType In ('City','From/To') And MiscName Like '" & Trim(txtMiscName.Text) & "%'" _
'                      & " Union  " _
'                      & " select City As MiscName from tbl_LedgerMaster Where City Like '" & Trim(txtMiscName.Text) & "%'  " _
'                      & " Order By MiscName "
'                End If
'                Me.Text = "Help Origin Selection"
'                Exit Select
'            Case "frmDirectChallanEntryNational_Destination", "frmLR_Entry_Aasim_Destination", "frmLR_Entry_Vikas_Destination" ', "frmDirectChallanEntryHired_Destination"
'                ds.Clear()
'                If Trim(txtMiscName.Text) = "" Then
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'From/To' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                Else
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'From/To' And MiscName Like '" & Trim(txtMiscName.Text) & "%' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                End If
'                Me.Text = "Help Destination Selection"
'                Exit Select
'            Case "frmDateWiseRate_UOM", "frmLR_Entry_Unit_Aasim", "frmLR_Entry_Unit"
'                ds.Clear()
'                If Trim(txtMiscName.Text) = "" Then
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'Unit' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                Else
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'Unit' And MiscName Like '" & Trim(txtMiscName.Text) & "%' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                End If
'                Me.Text = "Help Unit Selection"
'                Exit Select
'            Case "frmDateWiseRate_ItemName", "frmLR_Entry_ItemDetail_Aasim", "frmLR_Entry_ItemDetail"
'                ds.Clear()
'                sql_query = "select Distinct ItemName As MiscName, 0 As MiscType from tbl_LRItems where ItemName Like '" & Trim(txtMiscName.Text) & "%' Order By ItemName"
'                Me.Text = "Help Item Selection"
'                Exit Select
'            Case "Branch_CITYHelp", "City_CITYHelp", "CITYHelp", "Customer_CITYHelp", "Transporter_CITYHelp", "Driver_CITYHelp", "VENDOR_CITYHelp", "BusinessProfile_CITYHelp", "Worker_CITYHelp"
'                ds.Clear()
'                If Trim(txtMiscName.Text) = "" Then
'                    sql_query = "select * from View_MiscMaster Where MiscType In ('City', 'From/To') And IsActive = 'True' " & _filterCId & " order by MiscName"
'                Else
'                    sql_query = "select * from View_MiscMaster Where MiscType In ('City', 'From/To') And MiscName Like '" & Trim(txtMiscName.Text) & "%' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                End If
'                Me.Text = "Help City Selection"
'                Exit Select
'            Case "Branch_STATEHelp", "City_STATEHelp", "STATEHelp", "Customer_STATEHelp", "Transporter_STATEHelp", "Driver_STATEHelp", "VENDOR_STATEHelp", "BusinessProfile_StateHelp", "Worker_STATEHelp"
'                ds.Clear()
'                If Trim(txtMiscName.Text) = "" Then
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'State' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                Else
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'State' And MiscName Like '%" & Trim(txtMiscName.Text) & "%' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                End If
'                Me.Text = "Help State Selection"
'                Exit Select
'            Case "Branch_COUNTRYHelp", "City_COUNTRYHelp", "COUNTRYHelp", "Customer_COUNTRYHelp", "Transporter_COUNTRYHelp", "Driver_COUNTRYHelp", "VENDOR_COUNTRYHelp", "BusinessProfile_COUNTRYHelp", "Worker_COUNTRYHelp"
'                ds.Clear()
'                If Trim(txtMiscName.Text) = "" Then
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'Country' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                Else
'                    sql_query = "select * from View_MiscMaster Where MiscType = 'Country' And MiscName Like '" & Trim(txtMiscName.Text) & "%' And IsActive = 'True' " & _filterCId & " order by MiscName"
'                End If
'                Me.Text = "Help Country Selection"
'                Exit Select
'        End Select

'        obj.LoadData(sql_query, ds)
'        grdData.DataSource = ds.Tables(0).DefaultView

'        Select Case M_callingForm_MiscHelp
'            Case "frmDirectChallanEntryNational_Origin", "frmDirectChallanEntryNational_Destination", "frmLR_Entry_Aasim_Destination", "frmLR_Entry_Aasim_Origin", "frmLR_Entry_Vikas_Destination", "frmLR_Entry_Vikas_Origin" ',"frmDateWiseRate_Destination", "frmDateWiseRate_Origin", "frmDirectChallanEntryHired_Destination" ', "frmDirectChallanEntryHired_Origin"
'                grdData.Columns("MiscType").Visible = False
'                grdData.Columns("MiscName").Width = 300
'                grdData.Columns("MiscName").HeaderText = "Location"
'                grdData.Columns("CId").Visible = False
'                grdData.Columns("IsActive").Visible = False
'                Exit Select
'            Case "frmDateWiseRate_ItemName", "frmLR_Entry_ItemDetail_Aasim", "frmLR_Entry_ItemDetail"
'                grdData.Columns("MiscType").Visible = False
'                grdData.Columns("MiscName").Width = 300
'                grdData.Columns("MiscName").HeaderText = "Item Name"
'                Exit Select
'            Case "frmDateWiseRate_UOM", "frmLR_Entry_Unit_Aasim", "frmLR_Entry_Unit"
'                grdData.Columns("MiscType").Visible = False
'                grdData.Columns("MiscName").Width = 300
'                grdData.Columns("MiscName").HeaderText = "Unit"
'                grdData.Columns("CId").Visible = False
'                grdData.Columns("IsActive").Visible = False
'                Exit Select
'            Case "Branch_CITYHelp", "City_CITYHelp", "CITYHelp", "Customer_CITYHelp", "Transporter_CITYHelp", "Driver_CITYHelp", "VENDOR_CITYHelp", "BusinessProfile_CITYHelp", "Worker_CITYHelp"
'                grdData.Columns("MiscType").Visible = False
'                grdData.Columns("MiscName").Width = 300
'                grdData.Columns("MiscName").HeaderText = "City"
'                grdData.Columns("CId").Visible = False
'                grdData.Columns("IsActive").Visible = False
'                Exit Select
'            Case "Branch_STATEHelp", "City_STATEHelp", "STATEHelp", "Customer_STATEHelp", "Transporter_STATEHelp", "Driver_STATEHelp", "VENDOR_STATEHelp", "BusinessProfile_StateHelp", "Worker_STATEHelp"
'                grdData.Columns("MiscType").Visible = False
'                grdData.Columns("MiscName").Width = 300
'                grdData.Columns("MiscName").HeaderText = "State"
'                grdData.Columns("CId").Visible = False
'                grdData.Columns("IsActive").Visible = False
'                Exit Select
'            Case "Branch_COUNTRYHelp", "City_COUNTRYHelp", "COUNTRYHelp", "Customer_COUNTRYHelp", "Transporter_COUNTRYHelp", "Driver_COUNTRYHelp", "VENDOR_COUNTRYHelp", "BusinessProfile_COUNTRYHelp", "Worker_COUNTRYHelp"
'                grdData.Columns("MiscType").Visible = False
'                grdData.Columns("MiscName").Width = 300
'                grdData.Columns("MiscName").HeaderText = "Country"
'                grdData.Columns("CId").Visible = False
'                grdData.Columns("IsActive").Visible = False
'                Exit Select
'        End Select

'        lblRecords.Text = "Records: " & grdData.Rows.Count
'    End Sub

'    Public Sub setValue()
'        Select Case grdData.SelectedRows.Count
'            Case 1
'                Select Case M_callingForm_MiscHelp
'                    Case "frmLR_Entry_ItemDetail_Aasim"
'                        FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("ItemName").Value = grdData.CurrentRow.Cells("miscname").Value
'                        FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("Qty").Selected = True
'                        Me.Close()
'                        Exit Select
'                    Case "frmLR_Entry_Unit_Aasim"
'                        FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("Unit").Value = grdData.CurrentRow.Cells("miscname").Value
'                        FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("RefLRNo").Selected = True
'                        Me.Close()
'                        Exit Select
'                    Case "frmLR_Entry_Aasim_Destination"
'                        FrmLR_Entry_Aasim.txtDestination.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmDateWiseRate_Origin"
'                        FrmDateWiseRate.grdData.CurrentRow.Cells("Origin").Value = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmDateWiseRate_Destination"
'                        FrmDateWiseRate.grdData.CurrentRow.Cells("Destination").Value = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmDateWiseRate_UOM"
'                        FrmDateWiseRate.grdData.CurrentRow.Cells("UOM").Value = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmDateWiseRate_ItemName"
'                        FrmDateWiseRate.grdData.CurrentRow.Cells("ItemName").Value = grdData.CurrentRow.Cells("MiscName").Value
'                        FrmDateWiseRate.grdData.CurrentRow.Cells("Origin").Selected = True
'                        Me.Close()
'                        Exit Select
'                    Case "frmLR_Entry_Aasim_Origin"
'                        FrmLR_Entry_Aasim.txtOrigin.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmDirectChallanEntryNational_Origin"
'                        FrmDirectChallanEntry_National.txtOrigin.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    'Case "frmDirectChallanEntryHired_Origin"
'                    '    FrmDirectChallanEntry_Hired.txtOrigin.Text = grdData.CurrentRow.Cells("MiscName").Value
'                    '    Me.Close()
'                    '    Exit Select
'                    Case "frmLR_Entry_Vikas_Origin"
'                        FrmLR_Entry_Vikas.txtOrigin.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmDirectChallanEntryNational_Destination"
'                        FrmDirectChallanEntry_National.txtDestination.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmLR_Entry_Vikas_Destination"
'                        FrmLR_Entry_Vikas.txtDestination.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "frmLR_Entry_Unit"
'                        FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("Unit").Value = grdData.CurrentRow.Cells("miscname").Value
'                        FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("ActualWeight").Selected = True
'                        Me.Close()
'                        Exit Select
'                    Case "frmLR_Entry_ItemDetail"
'                        FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("ItemName").Value = grdData.CurrentRow.Cells("miscname").Value
'                        FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("Qty").Selected = True
'                        Me.Close()
'                        Exit Select
'                    Case "BusinessProfile_CITYHelp"
'                        FrmBusinessProfile.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "CITYHelp"
'                        FrmLedgerMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "BusinessProfile_StateHelp"
'                        FrmBusinessProfile.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "STATEHelp"
'                        FrmLedgerMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "BusinessProfile_COUNTRYHelp"
'                        FrmBusinessProfile.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "COUNTRYHelp"
'                        FrmLedgerMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "City_CITYHelp"
'                        FrmCityMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Branch_CITYHelp"
'                        FrmBranchMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Customer_CITYHelp"
'                        FrmCustomerMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "City_STATEHelp"
'                        FrmCityMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Branch_STATEHelp"
'                        FrmBranchMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Customer_STATEHelp"
'                        FrmCustomerMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "City_COUNTRYHelp"
'                        FrmCityMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Branch_COUNTRYHelp"
'                        FrmBranchMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Customer_COUNTRYHelp"
'                        FrmCustomerMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Worker_CITYHelp"
'                        FrmWorkerMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Worker_STATEHelp"
'                        FrmWorkerMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Worker_COUNTRYHelp"
'                        FrmWorkerMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "VENDOR_CITYHelp"
'                        FrmVendorMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "VENDOR_STATEHelp"
'                        FrmVendorMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "VENDOR_COUNTRYHelp"
'                        FrmVendorMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select

'                    Case "Transporter_CITYHelp"
'                        FrmTransporterMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Transporter_STATEHelp"
'                        FrmTransporterMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Transporter_COUNTRYHelp"
'                        FrmTransporterMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Driver_COUNTRYHelp"
'                        FrmDriverMaster.txtCountry.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Driver_STATEHelp"
'                        FrmDriverMaster.txtState.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                    Case "Driver_CITYHelp"
'                        FrmDriverMaster.txtCity.Text = grdData.CurrentRow.Cells("MiscName").Value
'                        Me.Close()
'                        Exit Select
'                End Select
'                Exit Select
'        End Select
'    End Sub

'    Public Sub setValue1()
'        Select Case M_callingForm_MiscHelp
'            Case "frmLR_Entry_ItemDetail_Aasim"
'                FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("ItemName").Value = Trim(txtMiscName.Text)
'                FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("Qty").Selected = True
'                Exit Select
'            Case "frmLR_Entry_Unit_Aasim"
'                FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("Unit").Value = Trim(txtMiscName.Text)
'                FrmLR_Entry_Aasim.grdLRItems.CurrentRow.Cells("RefLRNo").Selected = True
'                Exit Select
'            Case "frmLR_Entry_Aasim_Destination"
'                FrmLR_Entry_Aasim.txtDestination.Text = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmLR_Entry_Aasim_Origin"
'                FrmLR_Entry_Aasim.txtOrigin.Text = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmDateWiseRate_Origin"
'                FrmDateWiseRate.grdData.CurrentRow.Cells("Origin").Value = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmDateWiseRate_Destination"
'                FrmDateWiseRate.grdData.CurrentRow.Cells("Destination").Value = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmDateWiseRate_UOM"
'                FrmDateWiseRate.grdData.CurrentRow.Cells("UOM").Value = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmDateWiseRate_ItemName"
'                FrmDateWiseRate.grdData.CurrentRow.Cells("ItemName").Value = Trim(txtMiscName.Text)
'                FrmDateWiseRate.grdData.CurrentRow.Cells("Origin").Selected = True
'                Exit Select
'            Case "frmLR_Entry_Unit"
'                FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("Unit").Value = Trim(txtMiscName.Text)
'                FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("ActualWeight").Selected = True
'                Exit Select
'            Case "frmLR_Entry_ItemDetail"
'                FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("ItemName").Value = Trim(txtMiscName.Text)
'                FrmLR_Entry_Vikas.grdLRItems.CurrentRow.Cells("Qty").Selected = True
'                Exit Select
'            Case "frmDirectChallanEntryNational_Origin"
'                FrmDirectChallanEntry_National.txtOrigin.Text = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmLR_Entry_Vikas_Origin"
'                FrmLR_Entry_Vikas.txtOrigin.Text = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmDirectChallanEntryNational_Destination"
'                FrmDirectChallanEntry_National.txtDestination.Text = Trim(txtMiscName.Text)
'                Exit Select
'            Case "frmLR_Entry_Vikas_Destination"
'                FrmLR_Entry_Vikas.txtDestination.Text = Trim(txtMiscName.Text)
'                Exit Select
'            Case "BusinessProfile_CITYHelp"
'                FrmBusinessProfile.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "CITYHelp"
'                FrmLedgerMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "BusinessProfile_StateHelp"
'                FrmBusinessProfile.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "STATEHelp"
'                FrmLedgerMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "BusinessProfile_COUNTRYHelp"
'                FrmBusinessProfile.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "COUNTRYHelp"
'                FrmLedgerMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "City_CITYHelp"
'                FrmCityMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Branch_CITYHelp"
'                FrmBranchMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Customer_CITYHelp"
'                FrmCustomerMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "City_STATEHelp"
'                FrmCityMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Branch_STATEHelp"
'                FrmBranchMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Customer_STATEHelp"
'                FrmCustomerMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "City_COUNTRYHelp"
'                FrmCityMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Branch_COUNTRYHelp"
'                FrmBranchMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Customer_COUNTRYHelp"
'                FrmCustomerMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Worker_CITYHelp"
'                FrmWorkerMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Worker_STATEHelp"
'                FrmWorkerMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Worker_COUNTRYHelp"
'                FrmWorkerMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "VENDOR_CITYHelp"
'                FrmVendorMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "VENDOR_STATEHelp"
'                FrmVendorMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "VENDOR_COUNTRYHelp"
'                FrmVendorMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select

'            Case "Transporter_CITYHelp"
'                FrmTransporterMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Transporter_STATEHelp"
'                FrmTransporterMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Transporter_COUNTRYHelp"
'                FrmTransporterMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Driver_COUNTRYHelp"
'                FrmDriverMaster.txtCountry.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Driver_STATEHelp"
'                FrmDriverMaster.txtState.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'            Case "Driver_CITYHelp"
'                FrmDriverMaster.txtCity.Text = Trim(txtMiscName.Text)
'                Me.Close()
'                Exit Select
'        End Select
'        Me.Close()
'    End Sub

'#End Region

'    Private Sub FrmHelpMiscList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        txtMiscName.Text = M_SearchText
'        txtMiscName.Select(txtMiscName.Text.Length, 0)
'        M_SearchText = ""

'        gridfill()
'    End Sub

'    Private Sub txtMiscName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiscName.TextChanged
'        gridfill()
'    End Sub

'    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
'        If grdData.Rows.Count > 0 Then
'            grdData.Rows(0).Selected = True
'            setValue()
'        Else
'            If Trim(txtMiscName.Text) = "" Then
'                MsgBox("Please Specify " & M_callingForm_MiscHelp, MsgBoxStyle.Information)
'                Exit Sub
'            End If

'            Select Case M_callingForm_MiscHelp
'                Case "frmLR_Entry_Unit_Aasim", "frmDateWiseRate_UOM", "frmLR_Entry_Unit", "frmDateWiseRate_UOM"
'                    insertMiscMaster("Unit", Trim(txtMiscName.Text))
'                    Exit Select
'                Case "frmDirectChallanEntryNational_Origin"
'                    insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                    Exit Select
'                Case "frmLR_Entry_Vikas_Origin", "frmLR_Entry_Aasim_Origin", "frmDateWiseRate_Origin"
'                    insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                    Exit Select
'                Case "frmDirectChallanEntryNational_Destination"
'                    insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                    Exit Select
'                Case "frmLR_Entry_Vikas_Destination", "frmLR_Entry_Aasim_Destination", "frmDateWiseRate_Destination"
'                    insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                    Exit Select
'                Case "Branch_CITYHelp", "City_CITYHelp", "CITYHelp", "Customer_CITYHelp", "Transporter_CITYHelp", "Driver_CITYHelp", "VENDOR_CITYHelp", "BusinessProfile_CITYHelp", "Worker_CITYHelp"
'                    insertMiscMaster("CITY", Trim(txtMiscName.Text))
'                    Exit Select
'                Case "Branch_STATEHelp", "City_STATEHelp", "STATEHelp", "Customer_STATEHelp", "Transporter_STATEHelp", "Driver_STATEHelp", "VENDOR_STATEHelp", "BusinessProfile_StateHelp", "Worker_STATEHelp"
'                    insertMiscMaster("STATE", Trim(txtMiscName.Text))
'                    Exit Select
'                Case "Branch_COUNTRYHelp", "City_COUNTRYHelp", "COUNTRYHelp", "Customer_COUNTRYHelp", "Transporter_COUNTRYHelp", "Driver_COUNTRYHelp", "VENDOR_COUNTRYHelp", "BusinessProfile_COUNTRYHelp", "Worker_COUNTRYHelp"
'                    insertMiscMaster("COUNTRY", Trim(txtMiscName.Text))
'                    Exit Select
'            End Select
'            setValue1()
'        End If
'    End Sub

'    Private Sub grdParaList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
'        setValue()
'    End Sub

'    Private Sub grdParaList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
'        If e.KeyCode = Keys.Enter Then
'            setValue()
'        End If
'    End Sub

'    Private Sub txtMiscName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiscName.KeyPress
'        If e.KeyChar = Chr(13) Then
'            Select Case grdData.Rows.Count
'                Case 1
'                    grdData.Focus()
'                    grdData.Rows(0).Selected = True
'                    setValue()
'                    Exit Select
'                Case Is > 0
'                    grdData.Focus()
'                    Exit Select
'                Case 0
'                    setValue1()
'                    Exit Select
'            End Select
'        End If
'    End Sub

'    Private Sub txtMiscName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMiscName.KeyDown
'        Select Case e.KeyCode
'            Case Keys.F2
'                If Trim(txtMiscName.Text) = "" Then
'                    MsgBox("Please Specify " & M_callingForm_MiscHelp, MsgBoxStyle.Information)
'                    Exit Sub
'                End If

'                Select Case M_callingForm_MiscHelp
'                    Case "frmDirectChallanEntryHired__Origin"
'                        insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                        Exit Select
'                    Case "frmLR_Entry_Vikas_Origin", "frmLR_Entry_Aasim_Origin", "frmDateWiseRate_Origin"
'                        insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                        Exit Select
'                    Case "frmDirectChallanEntryNational_Destination" '"frmDirectChallanEntryHired_Destination", 
'                        insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                        Exit Select
'                    Case "frmLR_Entry_Vikas_Destination", "frmLR_Entry_Aasim_Destination", "frmDateWiseRate_Destination"
'                        insertMiscMaster("From/To", Trim(txtMiscName.Text))
'                        Exit Select
'                    Case "Branch_CITYHelp", "City_CITYHelp", "CITYHelp", "Customer_CITYHelp", "Transporter_CITYHelp", "Driver_CITYHelp", "VENDOR_CITYHelp", "BusinessProfile_CITYHelp", "Worker_CITYHelp"
'                        insertMiscMaster("CITY", Trim(txtMiscName.Text))
'                        Exit Select
'                    Case "Branch_STATEHelp", "City_STATEHelp", "STATEHelp", "Customer_STATEHelp", "Transporter_STATEHelp", "Driver_STATEHelp", "VENDOR_STATEHelp", "BusinessProfile_StateHelp", "Worker_STATEHelp"
'                        insertMiscMaster("STATE", Trim(txtMiscName.Text))
'                        Exit Select
'                    Case "Branch_COUNTRYHelp", "City_COUNTRYHelp", "COUNTRYHelp", "Customer_COUNTRYHelp", "Transporter_COUNTRYHelp", "Driver_COUNTRYHelp", "VENDOR_COUNTRYHelp", "BusinessProfile_COUNTRYHelp", "Worker_COUNTRYHelp"
'                        insertMiscMaster("COUNTRY", Trim(txtMiscName.Text))
'                        Exit Select
'                End Select
'            Case Keys.Down
'                grdData.Focus()
'                Exit Select
'        End Select
'    End Sub

'    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
'        Me.Close()
'    End Sub

'    Private Sub FrmHelpMiscList_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
'        Me.Dispose()
'    End Sub
'End Class