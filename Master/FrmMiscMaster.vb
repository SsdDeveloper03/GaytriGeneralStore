Imports GaytriGeneralStore.GaytriGeneral.DB
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Columns

Public Class FrmMiscmaster_DX

#Region "Comments"
    'Name:Texpert
    'Created By:Manav
    'Form:FrmMiscMaster
    'Date:12/12/2020
#End Region

#Region "Declaration"
    Dim ds As New Data.DataSet
    Dim dsMisc As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String
    Dim edit_ins As Integer = -1
    Dim existCode As String
    Dim oldCode As String
#End Region

#Region "Function"

    Public Function checkCode() As Boolean
        If M_CompanyWiseMiscMaster = "Yes" Then
            If edit_ins = 1 Then
                existCode = obj.ScalarExecute("select MiscName from tbl_MiscMaster where CId = " & M_CId & " And MiscName = '" & Trim(txtMiscName.Text) & "' And MiscType = '" & gvData.GetFocusedRowCellValue("MiscName") & "'")
                If Trim(txtMiscName.Text) = existCode Then
                    Return True
                Else
                    Return False
                End If
            Else
                existCode = obj.ScalarExecute("select MiscName from tbl_MiscMaster where CId = " & M_CId & " And MiscId <> " & Val(lblMiscId.Text) & " and MiscName = '" & Trim(txtMiscName.Text) & "' And MiscType = '" & gvData.GetFocusedRowCellValue("MiscName") & "'")
                If Trim(txtMiscName.Text) = existCode Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            If edit_ins = 1 Then
                existCode = obj.ScalarExecute("select MiscName from tbl_MiscMaster where MiscName = '" & Trim(txtMiscName.Text) & "' And MiscType = '" & gvData.GetFocusedRowCellValue("MiscName") & "'")
                If Trim(txtMiscName.Text) = existCode Then
                    Return True
                Else
                    Return False
                End If
            Else
                existCode = obj.ScalarExecute("select MiscName from tbl_MiscMaster where MiscId <> " & Val(lblMiscId.Text) & " and MiscName = '" & Trim(txtMiscName.Text) & "' And MiscType = '" & gvData.GetFocusedRowCellValue("MiscName") & "'")
                If Trim(txtMiscName.Text) = existCode Then
                    Return True
                Else
                    Return False
                End If
            End If
        End If
    End Function

#End Region

#Region "Method"

    Public Sub gridFill()
        ds.Clear()
        sql_query = "select MiscName from tbl_MiscMaster Where MiscType = 'Group Master' And CId = " & M_CId & " Order By MiscName"

        obj.LoadData(sql_query, ds)
        gcData.DataSource = ds.Tables(0).DefaultView

        gvData.Columns("MiscName").Caption = "Data Type"
        gvData.OptionsView.ColumnAutoWidth = True
        gvData.BestFitColumns()

        gvData.Columns("MiscName").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        gvData.Columns("MiscName").SummaryItem.DisplayFormat = "Records: {0}"
    End Sub

    Public Sub gridFill_Misc()
        loadMiscMaster()

        'dsMisc.Clear()
        'sql_query = "Select * From Tbl_MiscMaster Where MiscType = N'" & gvData.GetFocusedRowCellValue("MiscName") & "' And CId = " & M_CId & " Order By DispSrNo"

        'obj.LoadData(sql_query, dsMisc)
        'gcMisc.DataSource = dsMisc.Tables(0).DefaultView

        gcMisc.DataSource = dsMiscMaster.Tables(0).DefaultView

        RestoreLayout(gvMisc, "MiscMaster")

        gvMisc.Columns("CId").FilterInfo = New ColumnFilterInfo(M_CId)
        gvMisc.Columns("MiscType").FilterInfo = New ColumnFilterInfo(gvData.GetFocusedRowCellValue("MiscName"))

        'gvMisc.Columns("MiscId").Visible = False
        'gvMisc.Columns("MiscName").Caption = "Name"
        'gvMisc.Columns("MiscType").Visible = False
        'gvMisc.Columns("Data1").Caption = "Data1"
        'gvMisc.Columns("Data2").Caption = "Data2"
        'gvMisc.Columns("Data3").Caption = "Data3"
        'gvMisc.Columns("DispSrNo").Caption = "Display Sr.No."
        'gvMisc.Columns("IsActive").Visible = False
        'gvMisc.Columns("CId").Visible = False

        gvMisc.OptionsView.ColumnAutoWidth = False
        gvMisc.BestFitColumns()

        gvMisc.Columns("MiscName").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        gvMisc.Columns("MiscName").SummaryItem.DisplayFormat = "Records: {0}"
    End Sub

    Public Sub fillData()
        lblMiscId.Text = gvMisc.GetFocusedRowCellValue("MiscId")
        txtMiscName.Text = gvMisc.GetFocusedRowCellValue("MiscName")
        txtData1.Text = gvMisc.GetFocusedRowCellValue("Data1")
        txtData2.Text = gvMisc.GetFocusedRowCellValue("Data2")
        txtData3.Text = IIf(IsDBNull(gvMisc.GetFocusedRowCellValue("Data3")), "", gvMisc.GetFocusedRowCellValue("Data3"))
        txtDispSrNo.Text = gvMisc.GetFocusedRowCellValue("DispSrNo")
        chkIsActive.Checked = gvMisc.GetFocusedRowCellValue("IsActive")
    End Sub

    Public Sub insert()
        'obj.Prepare("SP_InsertMiscMaster", SpType.StoredProcedure)
        obj.Prepare("SP_InsertMiscMaster_281123", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsMiscType", Dtype.nvarchar, Trim(lblMiscType.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsMiscName", Dtype.nvarchar, Trim(txtMiscName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsData1", Dtype.nvarchar, Trim(txtData1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsData2", Dtype.nvarchar, Trim(txtData2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsData3", Dtype.nvarchar, Trim(txtData3.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsDispSrNo", Dtype.int, Val(txtDispSrNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsIsActive", Dtype.Bit, chkIsActive.Checked, ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

    Public Sub edit()
        'obj.Prepare("SP_UpdateMiscMaster", SpType.StoredProcedure)
        obj.Prepare("SP_UpdateMiscMaster_281123", SpType.StoredProcedure)
        obj.AddCmdParameter("@UpMiscType", Dtype.nvarchar, Trim(lblMiscType.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMiscName", Dtype.nvarchar, Trim(txtMiscName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpData1", Dtype.nvarchar, Trim(txtData1.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpData2", Dtype.nvarchar, Trim(txtData2.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpData3", Dtype.nvarchar, Trim(txtData3.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpDispSrNo", Dtype.int, Val(txtDispSrNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIsActive", Dtype.Bit, chkIsActive.Checked, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMiscId", Dtype.int, Val(lblMiscId.Text), ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

    Public Sub del()
        sql_query = "Delete From Tbl_MiscMaster Where MiscId = " & Val(lblMiscId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub loadTime()
        gridFill()

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        gcMisc.Enabled = True
        gcData.Enabled = True
        btnAdd.Focus()

        gbInfo.Enabled = False
    End Sub

    Public Sub addClickTime()
        gbInfo.Enabled = True
        gcMisc.Enabled = False
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        edit_ins = 1
    End Sub

    Public Sub clearTextboxs()
        txtMiscName.Clear()
        txtData1.Clear()
        txtData2.Clear()
        txtData3.Clear()
        txtDispSrNo.Clear()
    End Sub

    Public Sub editClickTime()
        gbInfo.Enabled = True
        gcMisc.Enabled = False
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        edit_ins = 0
        oldCode = Trim(txtMiscName.Text)
        txtMiscName.Focus()
    End Sub

    Public Sub saveClickTime()
        gridFill_Misc()

        gbInfo.Enabled = False
        gcMisc.Enabled = True
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnAdd.Focus()

        clearTextboxs()

        edit_ins = -1
    End Sub

    Public Sub deleteClickTime()
        gridFill_Misc()
        gbInfo.Enabled = False
        gcMisc.Enabled = True
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnAdd.Focus()

        clearTextboxs()

        edit_ins = -1
    End Sub

    Public Sub cancelClickTime()
        gridFill_Misc()
        gbInfo.Enabled = False
        gcMisc.Enabled = True
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnAdd.Focus()

        clearTextboxs()

        edit_ins = -1
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
    End Sub

#End Region

#Region "Events"

    Private Sub FrmMiscmaster_DX_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gridFill()

        Select Case M_CallingFormMiscMaster
            Case "FrmTailoringItem"
                gvData.Columns("MiscName").FilterInfo = New ColumnFilterInfo("[MiscName] = " & "'HSN Code'")
                If gvData.RowCount = 1 Then
                    gvMisc.FocusedRowHandle = 0
                    gvData_Click(Nothing, Nothing)
                    Label5.Text = "TaxPer %"
                    btnAdd_Click(Nothing, Nothing)
                Else
                    Me.Close()
                End If
                Exit Select
        End Select
    End Sub

    Private Sub gvData_Click(sender As System.Object, e As System.EventArgs) Handles gvData.Click
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length = 0 Then
            Exit Sub
        End If
        gridFill_Misc()
        gbInfo.Text = gvData.GetFocusedRowCellValue("MiscName") & " Information"
        lblMiscType.Text = gvData.GetFocusedRowCellValue("MiscName")

        If gvData.GetFocusedRowCellValue("MiscName").Contains("SMS") Or gvData.GetFocusedRowCellValue("MiscName").Contains("WhatsApp") Then
            'lblContent.Visible = True
            'lblField.Visible = True

            lblContent.Text = "Business Name" & vbCrLf & "Customer Name" & vbCrLf & "Order No." & vbCrLf & "Bill Amt" & vbCrLf & "Received Amt" & vbCrLf & "Due Amt" & vbCrLf & "Delivery Date" & vbCrLf & "Trial Date"
            lblField.Text = "{CName}" & vbCrLf & "{LedgerName}" & vbCrLf & "{InvoiceNo}" & vbCrLf & "{BillAmt}" & vbCrLf & "{ReceivedAmt}" & vbCrLf & "{DueAmt}" & vbCrLf & "{DeliveryDate}" & vbCrLf & "{TrialDate}"
        Else
            'lblContent.Visible = False
            'lblField.Visible = False

            lblContent.Text = ""
            lblField.Text = ""

            Select Case gvData.GetFocusedRowCellValue("MiscName")
                Case "BARCODE FORMULA"
                    lblContent.Text = "Item Type" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & "" & vbCrLf & ""
                    lblField.Text = "{ItemType}" & vbCrLf & "{ItemCategory}" & vbCrLf & "{MfgName}" & vbCrLf & "{ItemSize}" & vbCrLf & "{ItemColor}" & vbCrLf & "{}" & vbCrLf & "{}" & vbCrLf & "{}" & vbCrLf & "{}" & vbCrLf & "{}" & vbCrLf & "{}" & vbCrLf & "{}"
                    Exit Select
                Case "ITEM NAME FORMULA"
                    lblContent.Text = "Item Type" & vbCrLf & "Item Category" & vbCrLf & "Mfg Name" & vbCrLf & "Item Size" & vbCrLf & "Item Color" & vbCrLf & "Design No" & vbCrLf & "Catalog Name" & vbCrLf & "Sub Category" & vbCrLf & "Supplier"
                    lblField.Text = "{ItemType}" & vbCrLf & "{ItemCategory}" & vbCrLf & "{MfgName}" & vbCrLf & "{ItemSize}" & vbCrLf & "{ItemColor}" & vbCrLf & "{DesignNo}" & vbCrLf & "{Catalog}" & vbCrLf & "{ItemSubCategory}" & vbCrLf & "{SupplierName}"
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub gvData_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvData.KeyUp
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length = 0 Then
            Exit Sub
        End If
        gridFill_Misc()

        gbInfo.Text = gvData.GetFocusedRowCellValue("MiscName") & " Information"
        lblMiscType.Text = gvData.GetFocusedRowCellValue("MiscName")
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If checkRightsToAdd("MISC. MASTER") = False Then
            MsgBox("Unable To Add New Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        If gvData.FocusedRowHandle < 0 Then
            MessageBox.Show("Please Select Proper Record", "Misc Master", MessageBoxButtons.OK)
            'gvData.Focus()
            Exit Sub
        End If

        addClickTime()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If checkRightsToEdit("MISC. MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Trim(txtMiscName.Text) = "" Then
            MsgBox("Please Specify Misc. Name", MsgBoxStyle.Information)
            txtMiscName.Focus()
            Exit Sub
        End If

        If checkCode() = True Then
            MsgBox("Misc. Name Already Exist", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If edit_ins = 1 Then
            insert()
        Else
            edit()
        End If
        saveClickTime()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If checkRightsToDelete("MISC. MASTER") = False Then
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

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        cancelClickTime()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        exitClickTime()
    End Sub

    Private Sub gvMisc_Click(sender As System.Object, e As System.EventArgs) Handles gvMisc.Click
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

    Private Sub gvMisc_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvMisc.DoubleClick
        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length = 0 Then
            Exit Sub
        End If
        fillData()

        If checkRightsToEdit("MISC. MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()
    End Sub

    Private Sub gvMisc_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvMisc.KeyUp
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

    Private Sub txtMiscName_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiscName.KeyPress, txtDispSrNo.KeyPress, txtData2.KeyPress, txtData1.KeyPress, txtData3.KeyPress, chkIsActive.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        gridFill()
        gridFill_Misc()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog

        If sfd.ShowDialog() = DialogResult.OK Then
            gvData.ExportToXlsx(sfd.FileName & ".xlsx")
        End If
    End Sub

    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
        gvData.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvData.FocusedColumn.FieldName)
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvData, "MiscMaster", Me)
    End Sub

#End Region

End Class