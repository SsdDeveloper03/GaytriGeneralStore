'Imports DevExpress.XtraGrid.Columns
'Imports GaytriGeneralStore.GaytriGeneral.DB

'Public Class FrmCreditMaster

'#Region "Comments"
'    'Name:GayatryGeneral
'    'Created By:Manav
'    'Form:FrmCreditMaster
'    'Date:23/03/2026
'#End Region

'#Region "Declaration"

'    Dim obj As New DBManager
'    Dim sql_query As String
'    Dim ds As New Data.DataSet
'    Dim edit_ins As Integer = 1
'    Dim dvMiscMaster As DataView
'    Dim dtMisc As New DataTable

'#End Region

'#Region "Methods"

'    Private Sub FrmCreditMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        loadtime()
'        dvMiscMaster = New DataView(dsMiscMaster.Tables(0))
'        dtpF_From.Value = M_YrStart
'        dtpF_To.Value = M_YrEnd
'    End Sub

'    Public Sub Insert()
'        sql_query = "UPDATE tbl_LedgerMaster SET CreditLimit = " & Val(txtCreditLimit.Text) & ", DueDays = " & Val(txtDueDays) & ", DueDate = " & dtpDueDaysDate.Value & " WHERE LedgerId = " & Val(lkpCustomer.SelectedText)
'        obj.LoadData(sql_query, ds)
'    End Sub

'    Public Sub Edit()
'        sql_query = "UPDATE tbl_LedgerMaster SET CreditLimit = " & Val(txtCreditLimit.Text) & ", DueDays = " & Val(txtDueDays) & ", DueDate = " & dtpDueDaysDate.Value & " WHERE LedgerId = " & Val(lblLedgerId.Text)
'        obj.LoadData(sql_query, ds)
'    End Sub

'    Public Sub DeleteData()
'        If lblLedgerId.Text.Trim() = "" Then
'            MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
'            Exit Sub
'        End If
'        If MsgBox("Are you sure you want to delete this Credit Limit?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = DialogResult.No Then
'            Exit Sub
'        End If

'        sql_query = "UPDATE tbl_LedgerMaster SET CreditLimit = 0, DueDays = 0, DueDate = " & Today.Date & " WHERE LedgerId = " & Val(lblLedgerId.Text)
'    End Sub

'    Public Sub ComboFillCustomer(ByVal sql As String)
'        Dim dsCustomer As New DataSet
'        obj.LoadData(sql, dsCustomer)

'        With lkpCustomer.Properties
'            .DataSource = dsCustomer.Tables(0)
'            .ValueMember = "LedgerId"
'            .DisplayMember = "LedgerName"
'            .PopulateColumns()
'            .Columns("LedgerName").Width = 350
'            .Columns("CreditLimit").Width = 120
'            .Columns("DueDays").Width = 120
'            .Columns("DueDate").Width = 120

'            .PopupWidth = 700

'            .Columns("LedgerId").Visible = False
'        End With
'    End Sub

'    Private Sub FillData(rowHandle As Integer)

'        If rowHandle < 0 Then Exit Sub

'        lblLedgerId.Text = gvData.GetRowCellValue(rowHandle, "LedgerId").ToString()
'        txtCreditLimit.Text = gvData.GetRowCellValue(rowHandle, "CreditLimit").ToString()
'        txtDueDays.Text = gvData.GetRowCellValue(rowHandle, "DueDays").ToString()
'        lkpCustomer.EditValue = gvData.GetRowCellValue(rowHandle, "LedgerId")

'        Dim DueDate = gvData.GetRowCellValue(rowHandle, "DueDate")
'        If DueDate IsNot DBNull.Value Then
'            dtpDueDaysDate.Value = CDate(DueDate)
'            dtpDueDaysDate.Checked = True
'        Else
'            dtpDueDaysDate.Checked = False
'        End If
'    End Sub

'#End Region

'#Region "Events"

'    Public Sub loadtime()
'        ComboFillCustomer("SELECT LedgerId, LedgerName, CreditLimit, DueDays, Duedate FROM tbl_LedgerMaster WHERE G_Id = 11 ORDER BY LedgerName")
'        gridfill()

'        btnAdd.Enabled = True
'        btnEdit.Enabled = False
'        btnSave.Enabled = False
'        btnDelete.Enabled = False
'        btnCancel.Enabled = True
'        btnExit.Enabled = True

'        gcData.Enabled = True
'        gbCreditEntry.Enabled = False
'    End Sub

'    Public Sub gridfill()
'        ds.Clear()
'        sql_query = "SELECT LedgerId, LedgerName, CreditLimit, DueDays, DueDate FROM tbl_LedgerMaster Where G_Id = 11 order by LedgerName"
'        obj.LoadData(sql_query, ds)

'        gcData.DataSource = ds.Tables(0)

'        gvData.OptionsView.ColumnAutoWidth = False
'        gvData.BestFitMaxRowCount = -1
'        gvData.BestFitColumns()

'        gvData.Columns("LedgerId").Visible = False
'        gvData.Columns("LedgerName").Caption = "Customer Name"
'        gvData.Columns("CreditLimit").Caption = "Credit Amount"
'        gvData.Columns("DueDays").Caption = "Due Days"
'        gvData.Columns("DueDate").Caption = "Due Date"


'        gvData.Columns("LedgerName").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
'        gvData.Columns("LedgerName").SummaryItem.DisplayFormat = "{0}"

'        gvData.Columns("LedgerName").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
'        RestoreLayout(gvData, "frmSalesOrder")
'    End Sub

'    Private Sub lkpCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lkpCustomer.KeyPress, txtCreditLimit.KeyPress, txtDueDays.KeyPress, dtpDueDaysDate.KeyPress
'        If e.KeyChar = Chr(13) Then
'            If Trim(sender.Text) = "" Then
'                sender.Text = "0"
'            End If
'            SendKeys.Send("{Tab}")
'        End If
'    End Sub

'    Private Sub ClearFieldsNewState()
'        edit_ins = -1

'        gbCreditEntry.Enabled = False
'        gcData.Enabled = True

'        btnAdd.Enabled = True
'        btnEdit.Enabled = False
'        btnSave.Enabled = False
'        btnDelete.Enabled = False
'        btnCancel.Enabled = True
'        btnExit.Enabled = True

'        lblLedgerId.Text = ""
'        txtCreditLimit.Clear()
'        txtDueDays.Clear()
'        dtpDueDaysDate.Checked = False
'        lkpCustomer.EditValue = Nothing

'    End Sub

'    Private Sub AddClickTime()
'        gbCreditEntry.Enabled = True
'        gcData.Enabled = False

'        btnAdd.Enabled = False
'        btnEdit.Enabled = False
'        btnSave.Enabled = True
'        btnDelete.Enabled = False
'        btnCancel.Enabled = True
'        btnExit.Enabled = True

'        edit_ins = 1

'        lkpCustomer.Focus()
'        lkpCustomer.ShowPopup()
'    End Sub

'    Private Sub EditClickTime()
'        gbCreditEntry.Enabled = True
'        gcData.Enabled = False

'        btnAdd.Enabled = False
'        btnEdit.Enabled = False
'        btnSave.Enabled = True
'        btnDelete.Enabled = False
'        btnCancel.Enabled = True
'        btnExit.Enabled = True

'        edit_ins = 0
'        lkpCustomer.Focus()
'        lkpCustomer.ShowPopup()
'    End Sub

'    Private Sub CancleClickTime()
'        gbCreditEntry.Enabled = False
'        gcData.Enabled = True

'        btnAdd.Enabled = True
'        btnCancel.Enabled = True
'        btnExit.Enabled = True
'        btnEdit.Enabled = False
'        btnDelete.Enabled = False
'        btnRefresh.Enabled = True
'        btnSave.Enabled = False

'        ClearFieldsNewState()
'        ClearSearch()
'        btnAdd.Focus()

'    End Sub

'    Private Sub SaveClickTime()
'        btnAdd.Enabled = False
'        btnCancel.Enabled = True
'        btnExit.Enabled = True
'        btnEdit.Enabled = False
'        btnDelete.Enabled = False
'        btnRefresh.Enabled = True
'        btnSave.Enabled = True

'        ClearFieldsNewState()
'        gridfill()
'    End Sub

'    Private Sub DeleteClickTime()
'        gridfill()
'        btnAdd.Enabled = False
'        btnEdit.Enabled = False
'        btnDelete.Enabled = True
'        btnExit.Enabled = True
'        btnSave.Enabled = False
'        btnCancel.Enabled = True

'        DeleteData()
'    End Sub

'    Private Sub RefreshClickTime()
'        ClearSearch()
'        gridfill()
'    End Sub

'    Private Sub ClearSearch()
'        txtSearch.Clear()
'    End Sub

'    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
'        AddClickTime()
'    End Sub

'    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
'        EditClickTime()
'    End Sub

'    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
'        If edit_ins = 1 Then
'            Insert()
'        Else
'            Edit()
'        End If
'        ClearFieldsNewState()
'        gridfill()
'        SaveClickTime()
'    End Sub

'    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
'        'If checkRightsToDelete("SALES ORDER") = False Then
'        '    MsgBox("Unable To Delete Record", MsgBoxStyle.Information)
'        '    Exit Sub
'        'End If
'        DeleteClickTime()
'    End Sub

'    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'        CancleClickTime()
'    End Sub

'    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
'        If edit_ins = -1 Then
'            Me.Close()
'        Else
'            If MsgBox("Sure To Exit Without Saving Data ?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
'                Me.Close()
'            End If
'        End If
'    End Sub

'    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
'        RefreshClickTime()
'    End Sub

'    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
'        gvData.Columns("LedgerName").FilterInfo = New ColumnFilterInfo("[LedgerName] LIKE '%" & txtSearch.Text & "%'")
'    End Sub

'    Private Sub gcData_Click(sender As Object, e As EventArgs) Handles gcData.Click
'        If gvData.FocusedRowHandle < 0 Then Exit Sub

'        FillData(gvData.FocusedRowHandle)

'        btnEdit.Enabled = True
'        btnDelete.Enabled = True
'        btnAdd.Enabled = False
'    End Sub

'    Private Sub gcData_DoubleClick(sender As Object, e As EventArgs) Handles gcData.DoubleClick
'        If gvData.FocusedRowHandle < 0 Then Exit Sub
'        FillData(gvData.FocusedRowHandle)
'        EditClickTime()
'    End Sub

'    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
'        gvData.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvData.FocusedColumn.FieldName)
'    End Sub

'    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
'        Dim sfd As New SaveFileDialog

'        If sfd.ShowDialog() = DialogResult.OK Then
'            gvData.ExportToXlsx(sfd.FileName & ".xlsx")
'        End If
'    End Sub

'    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
'        SaveLayout(gvData, "FrmCreditMaster", Me)
'    End Sub

'    Private Sub lkpCustomer_DoubleClick(sender As Object, e As EventArgs) Handles lkpCustomer.DoubleClick
'        M_callingForm_LedgerHelp = "FrmCustomermaster"
'        Dim frm As New FrmCustomerMaster()
'        frm.ShowDialog()
'    End Sub

'    Private Sub gcData_MouseDown(sender As Object, e As MouseEventArgs) Handles gcData.MouseDown
'        If e.Button = MouseButtons.Right Then
'            ContextMenuStrip1.Show(gcData, e.Location)
'        End If
'    End Sub

'#End Region

'#Region "Functions"

'#End Region

'End Class


Imports DevExpress.XtraGrid.Columns
Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmCreditMaster

#Region "Comments"
    'Name:GayatryGeneral
    'Created By:Manav
    'Form:FrmCreditMaster
    'Date:23/03/2026
#End Region

#Region "Declaration"

    Dim obj As New DBManager
    Dim sql_query As String
    Dim ds As New Data.DataSet
    Dim edit_ins As Integer = 1

#End Region

#Region "Methods"

    Private Sub FrmCreditMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtime()
    End Sub

    Public Sub Insert()
        sql_query = "UPDATE tbl_LedgerMaster SET CreditLimit = " & Val(txtCreditLimit.Text) & ", DueDays = " & Val(txtDueDays.Text) & " WHERE LedgerId = " & Val(lkpCustomer.EditValue)
        obj.LoadData(sql_query, ds)
    End Sub

    Public Sub Edit()
        sql_query = "UPDATE tbl_LedgerMaster Set CreditLimit = " & Val(txtCreditLimit.Text) & ", DueDays = " & Val(txtDueDays.Text) & " WHERE LedgerId = " & Val(lblLedgerId.Text)
        obj.LoadData(sql_query, ds)
    End Sub

    Public Sub DeleteData()
        If lblLedgerId.Text.Trim() = "" Then
            MsgBox("Please Select a record To delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you sure you want To delete this Credit Limit?", MsgBoxStyle.YesNo) = DialogResult.No Then Exit Sub

        sql_query = "UPDATE tbl_LedgerMaster Set CreditLimit = 0, DueDays = 0 WHERE LedgerId = " & Val(lblLedgerId.Text)

        obj.LoadData(sql_query, ds)
    End Sub


    Public Sub ComboFillCustomer(ByVal sql As String)
        Dim dsCustomer As New DataSet
        obj.LoadData(sql, dsCustomer)

        If dsCustomer Is Nothing OrElse dsCustomer.Tables.Count = 0 Then
            MsgBox("No customer data found.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        With lkpCustomer.Properties
            .DataSource = dsCustomer.Tables(0)
            .ValueMember = "LedgerId"
            .DisplayMember = "LedgerName"
            .PopulateColumns()

            .Columns("LedgerName").Width = 350
            .Columns("CreditLimit").Width = 120
            .Columns("DueDays").Width = 120
            .AppearanceDropDown.Font = New Font("Calibri", 15)

            .PopupWidth = 700

            .Columns("LedgerId").Visible = False
        End With
    End Sub

    Private Sub FillData(rowHandle As Integer)

        If rowHandle < 0 Then Exit Sub

        lblLedgerId.Text = gvData.GetRowCellValue(rowHandle, "LedgerId").ToString()
        txtCreditLimit.Text = gvData.GetRowCellValue(rowHandle, "CreditLimit").ToString()
        txtDueDays.Text = gvData.GetRowCellValue(rowHandle, "DueDays").ToString()
        lkpCustomer.EditValue = gvData.GetRowCellValue(rowHandle, "LedgerId")


    End Sub

#End Region

#Region "Events"

    Public Sub loadtime()
        ComboFillCustomer("SELECT LedgerId, LedgerName, CreditLimit, DueDays FROM tbl_LedgerMaster WHERE G_Id = 11 ORDER BY LedgerName")
        gridfill()

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

        gcData.Enabled = True
        gbCreditEntry.Enabled = False
    End Sub

    Public Sub gridfill()
        ds.Clear()

        sql_query = "SELECT LedgerId, LedgerName, CreditLimit, DueDays FROM tbl_LedgerMaster WHERE G_Id = 11 ORDER BY LedgerName"
        obj.LoadData(sql_query, ds)

        If ds.Tables.Count = 0 Then Exit Sub

        gcData.DataSource = ds.Tables(0)

        gvData.Columns("LedgerId").Visible = False
        gvData.Columns("LedgerName").Caption = "Customer Name"
        gvData.Columns("CreditLimit").Caption = "Credit Amount"
        gvData.Columns("DueDays").Caption = "Due Days"

    End Sub

    Private Sub txtDueDays_TextChanged(sender As Object, e As EventArgs) Handles txtDueDays.TextChanged
        Try
            If txtDueDays.Text.Trim() = "" Then Exit Sub

            Dim days As Integer = Val(txtDueDays.Text)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddClickTime()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditClickTime()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If edit_ins = 1 Then
            Insert()
        Else
            Edit()
        End If

        SaveClickTime()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteClickTime()
    End Sub

    Private Sub ClearFieldsNewState()
        edit_ins = -1

        gbCreditEntry.Enabled = False
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        lblLedgerId.Text = ""
        txtCreditLimit.Clear()
        txtDueDays.Clear()
        lkpCustomer.EditValue = Nothing

    End Sub

    Private Sub AddClickTime()
        gbCreditEntry.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        edit_ins = 1

        lkpCustomer.Focus()
        lkpCustomer.ShowPopup()
    End Sub

    Private Sub EditClickTime()
        gbCreditEntry.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        edit_ins = 0
        txtCreditLimit.Focus()

    End Sub

    Private Sub CancelClickTime()
        gbCreditEntry.Enabled = False
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnRefresh.Enabled = True
        btnSave.Enabled = False

        ClearFieldsNewState()
        ClearSearch()
        btnAdd.Focus()

    End Sub

    Private Sub SaveClickTime()
        btnAdd.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnRefresh.Enabled = True
        btnSave.Enabled = True

        ClearFieldsNewState()
        gridfill()
    End Sub

    Private Sub DeleteClickTime()
        gridfill()
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = True
        btnExit.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = True

        DeleteData()
    End Sub

    Private Sub RefreshClickTime()
        ClearSearch()
        ClearFields()
        gridfill()

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        btnAdd.Focus()
    End Sub

    Private Sub ClearSearch()
        txtSearch.Clear()
    End Sub

#End Region

#Region "Helpers"

    Private Sub ClearFields()
        txtCreditLimit.Clear()
        txtDueDays.Clear()
        lkpCustomer.EditValue = Nothing
        lblLedgerId.Text = ""
    End Sub

    Private Sub gvData_Click_1(sender As Object, e As EventArgs) Handles gvData.Click
        If gvData.FocusedRowHandle < 0 Then Exit Sub

        FillData(gvData.FocusedRowHandle)

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick
        If gvData.FocusedRowHandle < 0 Then Exit Sub
        FillData(gvData.FocusedRowHandle)
        EditClickTime()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CancelClickTime()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If edit_ins = -1 Then
            Me.Close()
        Else
            If MsgBox("Sure To Exit Without Saving Data ?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshClickTime()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        gvData.Columns("LedgerName").FilterInfo = New ColumnFilterInfo("[LedgerName] LIKE '%" & txtSearch.Text & "%'")
    End Sub

    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
        gvData.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvData.FocusedColumn.FieldName)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog

        If sfd.ShowDialog() = DialogResult.OK Then
            gvData.ExportToXlsx(sfd.FileName & ".xlsx")
        End If
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvData, "FrmCreditMaster", Me)
    End Sub

    Private Sub lkpCustomer_DoubleClick(sender As Object, e As EventArgs) Handles lkpCustomer.DoubleClick
        M_callingForm_LedgerHelp = "FrmCustomermaster"
        Dim frm As New FrmCustomerMaster()
        frm.ShowDialog()
    End Sub

    Private Sub gcData_MouseDown(sender As Object, e As MouseEventArgs) Handles gcData.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(gcData, e.Location)
        End If
    End Sub
#End Region

End Class