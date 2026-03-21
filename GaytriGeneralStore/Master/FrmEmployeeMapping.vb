'Imports DevExpress.XtraGrid.Views.Grid
'Imports GaytriGeneralStore.GaytriGeneral.DB

'Public Class FrmEmployeeMapping
'#Region "Comments"

'#End Region

'#Region "Declaration"
'    Dim obj As New DBManager
'    Dim sql_query As String
'    Dim ds As New Data.DataSet


'#End Region

'#Region "Methods"

'    Public Sub ComboFill(ByVal cmb As ComboBox, ByVal sql As String)
'        Dim dsCmb As New Data.DataSet
'        dsCmb.Clear()
'        sql_query = sql
'        obj.LoadData(sql_query, dsCmb)
'        cmb.DataSource = dsCmb.Tables(0).DefaultView
'        cmb.ValueMember = dsCmb.Tables(0).Columns(0).ToString
'        cmb.DisplayMember = dsCmb.Tables(0).Columns(1).ToString
'        dsCmb.Dispose()
'    End Sub

'    Public Sub GridFill_AssignedCustomer()
'        Dim dsAssignCustomer As Data.DataSet

'    End Sub

'    Public Sub GridFill_Customer()

'        Dim dsCusotmer As New Data.DataSet
'        Dim searchFilter As String = ""

'        If Trim(txtSearch.Text) <> "" Then
'            searchFilter = " AND LedgerName LIKE '%" & Trim(txtSearch.Text) & "%' "
'        End If

'        sql_query = "SELECT LedgerId, LedgerName FROM tbl_LedgerMaster WHERE G_Id = 11 AND CId = " & M_CId & "" & searchFilter &
'                    "AND LedgerId NOT IN (SELECT CustomerId FROM tbl_EmpWiseCustomerAndArea WHERE EmpId = " & cmbEmployee.SelectedValue & "AND CustomerId IS NOT NULL)ORDER BY LedgerName"

'        obj.LoadData(sql_query, dsCusotmer)

'        gcCustomers.DataSource = dsCusotmer.Tables(0)
'        gvCustomers.ClearSelection()
'        gvCustomers.OptionsSelection.MultiSelect = True
'        gvCustomers.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
'        gvCustomers.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True
'        gvCustomers.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True
'        gvCustomers.OptionsSelection.EnableAppearanceFocusedCell = False
'        gvCustomers.OptionsBehavior.Editable = False
'        gvCustomers.OptionsView.ShowGroupPanel = False

'    End Sub

'#End Region

'#Region "Functions"

'#End Region

'#Region "Events"

'    Private Sub FrmEmployeeMapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        loadtime()
'    End Sub

'    Public Sub loadtime()
'        ComboFill(cmbEmployee, "Select LedgerId, LedgerName from tbl_LedgerMaster where G_Id = 30")
'        ComboFill(cmbArea, "Select AreaId, AreaName from tbl_AreaMaster")
'        'ComboFill(cmbCustomer, "Select LedgerId, LedgerName from tbl_LedgerMaster Where G_Id = 11")
'        cmbEmployee.Focus()
'    End Sub


'    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
'        GridFill_Customer()
'    End Sub

'    Private Sub cmbEmployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEmployee.KeyPress, cmbArea.KeyPress
'        If e.KeyChar = Chr(13) Then
'            SendKeys.Send("{Tab}")
'        End If
'    End Sub

'#End Region

'End Class


Imports DevExpress.XtraGrid.Views.Grid
Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmEmployeeMapping

#Region "Declaration"

    Dim obj As New DBManager
    Dim sql_query As String
    Dim escCount As Integer
#End Region

#Region "Methods"

    Public Function GetValue(ByVal cmb As DevExpress.XtraEditors.LookUpEdit) As Integer
        Try
            If cmb.EditValue Is Nothing Then Return 0
            Return Val(cmb.EditValue)
        Catch
            Return 0
        End Try
    End Function

    Public Sub LookupFill(ByVal cmb As DevExpress.XtraEditors.LookUpEdit, ByVal sql As String)

        Dim ds As New DataSet
        obj.LoadData(sql, ds)

        cmb.Properties.DataSource = ds.Tables(0)
        cmb.Properties.ValueMember = ds.Tables(0).Columns(0).ToString
        cmb.Properties.DisplayMember = ds.Tables(0).Columns(1).ToString
        cmb.Properties.PopulateColumns()

        cmb.Properties.Columns(0).Visible = False

    End Sub

    Public Sub GridFill_AssignedArea()

        If GetValue(cmbEmployee) = 0 Then Exit Sub

        Dim ds As New DataSet

        sql_query = "SELECT DISTINCT A.AreaId, A.AreaName 
                 FROM tbl_EmpWiseCustomerAndArea EA
                 INNER JOIN tbl_AreaMaster A ON EA.AreaId = A.AreaId
                 WHERE EA.EmpId = " & GetValue(cmbEmployee) & "
                 AND EA.CId = " & M_CId

        obj.LoadData(sql_query, ds)

        lstAssignedAreas.DataSource = ds.Tables(0)
        lstAssignedAreas.DisplayMember = "AreaName"
        lstAssignedAreas.ValueMember = "AreaId"

    End Sub

    Public Sub GridFill_AssignedCustomer()

        If GetValue(cmbEmployee) = 0 Then Exit Sub

        Dim ds As New DataSet

        sql_query = "SELECT EA.Id, EA.CustomerId, L.LedgerName AS CustomerName, A.AreaName, E.LedgerName AS EmployeeName FROM tbl_EmpWiseCustomerAndArea EA
             INNER JOIN tbl_LedgerMaster L ON EA.CustomerId = L.LedgerId
             INNER JOIN tbl_AreaMaster A ON EA.AreaId = A.AreaId
             INNER JOIN tbl_LedgerMaster E ON EA.EmpId = E.LedgerId WHERE EA.EmpId = " & GetValue(cmbEmployee) & " AND EA.CustomerId IS NOT NULL AND EA.CId = " & M_CId

        obj.LoadData(sql_query, ds)

        gcAssignedCustomers.DataSource = ds.Tables(0)

    End Sub

    Public Sub GridFill_Customer()

        If GetValue(cmbEmployee) = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim searchFilter As String = ""

        If Trim(txtSearch.Text) <> "" Then
            searchFilter = " AND LedgerName LIKE '%" & Trim(txtSearch.Text) & "%' "
        End If

        'sql_query = "SELECT LedgerId, LedgerName FROM tbl_LedgerMaster WHERE G_Id = 11 AND CId = " & M_CId & " " & searchFilter & "
        '             AND LedgerId NOT IN (SELECT CustomerId FROM tbl_EmpWiseCustomerAndArea WHERE CustomerId IS In tbl_EmpWiseCustomerAndArea)ORDER BY LedgerName"
        sql_query = "SELECT LedgerId, LedgerName, MobileNo FROM tbl_LedgerMaster WHERE G_Id = 11 AND CId = " & M_CId & " " & searchFilter & "
             AND LedgerId NOT IN (SELECT CustomerId FROM tbl_EmpWiseCustomerAndArea WHERE CustomerId IS NOT NULL) ORDER BY LedgerName"

        obj.LoadData(sql_query, ds)

        gcCustomers.DataSource = ds.Tables(0)
        gvCustomers.Columns("LedgerId").Visible = False
        gvCustomers.ClearSelection()
        gvCustomers.OptionsSelection.MultiSelect = True
        gvCustomers.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect

    End Sub

    '================ ASSIGN =================
    Public Sub Assign()

        Dim selectedRows() As Integer = gvCustomers.GetSelectedRows()

        If selectedRows.Length = 0 Then
            MsgBox("Please Select Any Customer", MsgBoxStyle.Information)
            Exit Sub
        End If

        For Each rowHandle In selectedRows

            Dim row = gvCustomers.GetDataRow(rowHandle)
            If row Is Nothing Then Continue For

            Dim custId = Val(row("LedgerId"))
            Dim empId = GetValue(cmbEmployee)
            Dim areaId = GetValue(cmbArea)

            sql_query = "INSERT INTO tbl_EmpWiseCustomerAndArea
                         (EmpId, CustomerId, AreaId, Sys_Name, Sys_Time, CurrUsr, CId)
                         VALUES (" & empId & "," & custId & "," & areaId & ",
                         '" & My.Computer.Name & "',GETDATE(),'" & loggedUser & "'," & M_CId & ")"

            obj.QueryExecute(sql_query)

            sql_query = "UPDATE tbl_LedgerMaster SET 
                         FaxNo = " & areaId & ",
                         AcContactNo = " & empId & ",
                         AcContactPerson = " & empId & "
                         WHERE LedgerId = " & custId

            obj.QueryExecute(sql_query)

        Next

    End Sub

    '================ DELETE =================
    'Public Sub DeleteMapping()

    '    Dim selectedRows() As Integer = gvAssignedCustomers.GetSelectedRows()

    '    If selectedRows.Length = 0 Then
    '        MsgBox("Select Assigned Customer")
    '        Exit Sub
    '    End If

    '    For Each rowHandle In selectedRows

    '        Dim row = gvAssignedCustomers.GetDataRow(rowHandle)
    '        If row Is Nothing Then Continue For

    '        Dim id = Val(row("Id"))
    '        Dim custId = Val(row("CustomerId"))

    '        'DELETE
    '        sql_query = "DELETE FROM tbl_EmpWiseCustomerAndArea WHERE Id = " & id
    '        obj.QueryExecute(sql_query)

    '        'CLEAR LEDGER
    '        sql_query = "UPDATE tbl_LedgerMaster SET 
    '                     FaxNo = '',
    '                     AcContactNo = '',
    '                     AcContactPerson = ''
    '                     WHERE LedgerId = " & custId

    '        obj.QueryExecute(sql_query)

    '    Next

    'End Sub

#End Region

#Region "Events"

    Private Sub FrmEmployeeMapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        loadtime()
    End Sub

    Public Sub loadtime()

        LookupFill(cmbEmployee, "SELECT LedgerId,(LedgerName + ' | ' + ISNULL(Address1,'') + ' | ' + ISNULL(MobileNo,'')) FROM tbl_LedgerMaster WHERE G_Id = 30 AND CId = " & M_CId)
        LookupFill(cmbArea, "SELECT AreaId,(AreaName + ' | ' + ISNULL(CityName,'') + ' | ' + ISNULL(StateName,'') + ' | ' + ISNULL(CountryName,'')) FROM tbl_AreaMaster")

        gvAssignedCustomers.OptionsBehavior.Editable = False
        gvAssignedCustomers.OptionsSelection.EnableAppearanceFocusedCell = False
        gvAssignedCustomers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        gvAssignedCustomers.OptionsSelection.MultiSelect = False

        gvCustomers.OptionsSelection.MultiSelect = True
        gvCustomers.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
        gvCustomers.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True

        cmbEmployee.Properties.Appearance.Font = New Font("Calibri", 16, FontStyle.Regular)
        cmbEmployee.Properties.Appearance.Options.UseFont = True
        cmbEmployee.Properties.AutoHeight = False
        cmbEmployee.Height = 32
        cmbEmployee.Width = 350
        cmbEmployee.Properties.AppearanceDropDown.Font = New Font("Calibri", 15)
        cmbEmployee.Properties.AppearanceDropDown.Options.UseFont = True
        cmbEmployee.Properties.PopupWidth = 500

        cmbArea.Properties.Appearance.Font = New Font("Calibri", 12, FontStyle.Regular)
        cmbArea.Properties.Appearance.Options.UseFont = True
        cmbArea.Properties.AutoHeight = False
        cmbArea.Height = 32
        cmbArea.Width = 300
        cmbArea.Properties.AppearanceDropDown.Font = New Font("Calibri", 15)
        cmbArea.Properties.AppearanceDropDown.Options.UseFont = True
        cmbArea.Properties.PopupWidth = 500

        cmbEmployee.Focus()
        cmbEmployee.ShowPopup()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        GridFill_Customer()
        GridFill_AssignedArea()
        GridFill_AssignedCustomer()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Assign()

        MsgBox("Record Saved Successfully")

        GridFill_Customer()
        GridFill_AssignedArea()
        GridFill_AssignedCustomer()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        GridFill_Customer()
    End Sub

    Private Sub gvAssignedCustomers_KeyDown(sender As Object, e As KeyEventArgs) Handles gvAssignedCustomers.KeyDown
        If e.KeyCode = Keys.Delete Then

            Try
                Dim row As DataRow = gvAssignedCustomers.GetFocusedDataRow()

                If row Is Nothing Then Exit Sub

                Dim id As Integer = Val(row("Id"))
                Dim custId As Integer = Val(row("CustomerId"))

                '🔴 Confirm
                If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub

                'DELETE
                sql_query = "DELETE FROM tbl_EmpWiseCustomerAndArea 
                         WHERE Id = " & id & "
                         AND EmpId = " & GetValue(cmbEmployee) & "
                         AND CId = " & M_CId

                obj.QueryExecute(sql_query)

                'CLEAR LEDGER
                sql_query = "UPDATE tbl_LedgerMaster SET 
                         FaxNo = '',
                         AcContactNo = '',
                         AcContactPerson = ''
                         WHERE LedgerId = " & custId & "
                         AND CId = " & M_CId

                obj.QueryExecute(sql_query)

                MsgBox("Deleted Record Successfully", MsgBoxStyle.Information)

                'REFRESH
                GridFill_Customer()
                GridFill_AssignedArea()
                GridFill_AssignedCustomer()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub FrmEmployeeMapping_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()

            Case Keys.F3
                btnLoad.PerformClick()

            Case Keys.F5
                btnDelete.PerformClick()

            Case Keys.Escape

                escCount += 1

                If escCount = 1 Then
                    MsgBox("Press ESC again to close", MsgBoxStyle.Information)
                ElseIf escCount = 2 Then
                    Me.Close()
                End If

        End Select

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If

    End Sub

    Private Sub RenameFieldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFieldToolStripMenuItem.Click
        gvAssignedCustomers.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvAssignedCustomers.FocusedColumn.FieldName)
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvAssignedCustomers, "FrmEmployeeMapping", Me)
    End Sub

#End Region

End Class