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

    Public Sub ComboFill_Employee(ByVal sql As String)
        Dim dsEmployee As New DataSet
        obj.LoadData(sql, dsEmployee)

        With cmbEmployee.Properties
            .DataSource = dsEmployee.Tables(0)
            .ValueMember = "LedgerId"
            .DisplayMember = "LedgerName"
            .PopulateColumns()
            .Columns("LedgerName").Width = 350
            .Columns("MobileNo").Width = 120
            .Columns("Address1").Width = 150

            .PopupWidth = 700

            .Columns("LedgerId").Visible = False
        End With
    End Sub

    Public Sub ComboFill_Area(ByVal sql As String)
        Dim dsArea As New DataSet
        obj.LoadData(sql, dsArea)

        With cmbArea.Properties
            .DataSource = dsArea.Tables(0)
            .ValueMember = "AreaId"
            .DisplayMember = "AreaName"
            .PopulateColumns()
            .Columns("AreaName").Width = 350
            .Columns("CityName").Width = 120
            .Columns("StateName").Width = 120
            .Columns("CountryName").Width = 120

            .PopupWidth = 700

            .Columns("AreaId").Visible = False
        End With
    End Sub

    Public Sub GridFill_AssignedArea()

        If GetValue(cmbEmployee) = 0 Then Exit Sub

        Dim ds As New DataSet

        sql_query = "SELECT DISTINCT A.AreaId, A.AreaName FROM tbl_EmpWiseCustomerAndArea EA INNER JOIN tbl_AreaMaster A ON EA.AreaId = A.AreaId WHERE EA.EmpId = " & GetValue(cmbEmployee) & " AND EA.CId = " & M_CId

        obj.LoadData(sql_query, ds)

        lstAssignedAreas.DataSource = ds.Tables(0)
        lstAssignedAreas.DisplayMember = "AreaName"
        lstAssignedAreas.ValueMember = "AreaId"

    End Sub

    Public Sub GridFill_AssignedCustomer()

        If GetValue(cmbEmployee) = 0 Then Exit Sub

        Dim ds As New DataSet

        sql_query = "SELECT EA.Id, EA.CustomerId, L.LedgerName AS CustomerName, A.AreaName, E.LedgerName AS EmployeeName 
                 FROM tbl_EmpWiseCustomerAndArea EA
                 INNER JOIN tbl_LedgerMaster L ON EA.CustomerId = L.LedgerId
                 INNER JOIN tbl_AreaMaster A ON EA.AreaId = A.AreaId
                 INNER JOIN tbl_LedgerMaster E ON EA.EmpId = E.LedgerId 
                 WHERE EA.EmpId = " & GetValue(cmbEmployee) & "
                 AND EA.CustomerId IS NOT NULL 
                 AND EA.CId = " & M_CId

        obj.LoadData(sql_query, ds)

        Dim dv As DataView = ds.Tables(0).DefaultView

        If Trim(txtSearchCustomer.Text) <> "" Then
            dv.RowFilter = "CustomerName LIKE '%" & Trim(txtSearchCustomer.Text) & "%' 
                        OR AreaName LIKE '%" & Trim(txtSearchCustomer.Text) & "%'
                        OR EmployeeName LIKE '%" & Trim(txtSearchCustomer.Text) & "%'"
        End If

        gcAssignedCustomers.DataSource = dv

    End Sub

    Public Sub GridFill_Customer()

        If GetValue(cmbEmployee) = 0 Then Exit Sub

        Dim ds As New DataSet
        Dim searchFilter As String = ""

        If Trim(txtSearch.Text) <> "" Then
            searchFilter = " AND LedgerName LIKE '%" & Trim(txtSearch.Text) & "%' 
                             Or MobileNo LIKE '%" & Trim(txtSearch.Text) & "%'"
        End If

        sql_query = "SELECT LedgerId, LedgerName, MobileNo FROM tbl_LedgerMaster WHERE G_Id = 11 AND CId = " & M_CId & " " & searchFilter & "
             AND LedgerId NOT IN (SELECT CustomerId FROM tbl_EmpWiseCustomerAndArea WHERE CustomerId IS NOT NULL) ORDER BY LedgerName"

        obj.LoadData(sql_query, ds)

        gcCustomers.DataSource = ds.Tables(0)
        gvCustomers.Columns("LedgerId").Visible = False
        gvCustomers.ClearSelection()
        gvCustomers.OptionsSelection.MultiSelect = True
        gvCustomers.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect

    End Sub

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

            sql_query = "INSERT INTO tbl_EmpWiseCustomerAndArea (EmpId, CustomerId, AreaId, Sys_Name, Sys_Time, CurrUsr, CId) VALUES (" & empId & "," & custId & "," & areaId & ", '" & My.Computer.Name & "',GETDATE(),'" & loggedUser & "'," & M_CId & ")"

            obj.QueryExecute(sql_query)

            sql_query = "UPDATE tbl_LedgerMaster SET FaxNo = " & areaId & ", AcContactNo = " & empId & ", AcContactPerson = " & empId & " WHERE LedgerId = " & custId

            obj.QueryExecute(sql_query)

        Next

    End Sub

#End Region

#Region "Events"

    Private Sub FrmEmployeeMapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        loadtime()
    End Sub

    Public Sub loadtime()

        ComboFill_Employee("SELECT LedgerId,LedgerName, Address1,MobileNo FROM tbl_LedgerMaster WHERE G_Id = 30 AND CId = " & M_CId)
        ComboFill_Area("SELECT AreaId, AreaName ,CityName,StateName,CountryName FROM tbl_AreaMaster")

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
        gvCustomers.Focus()
        gvCustomers.FocusedRowHandle = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Assign()

        MsgBox("Customer And Area Assign Successfully", MsgBoxStyle.Information)

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
                DeleteData()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub
    Public Sub DeleteData()
        Dim row As DataRow = gvAssignedCustomers.GetFocusedDataRow()

        If row Is Nothing Then Exit Sub

        Dim id As Integer = Val(row("Id"))
        Dim custId As Integer = Val(row("CustomerId"))

        If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub

        sql_query = "DELETE FROM tbl_EmpWiseCustomerAndArea WHERE Id = " & id & " AND EmpId = " & GetValue(cmbEmployee) & " AND CId = " & M_CId

        obj.QueryExecute(sql_query)

        sql_query = "UPDATE tbl_LedgerMaster SET FaxNo = '', AcContactNo = '', AcContactPerson = '' WHERE LedgerId = " & custId & " AND CId = " & M_CId

        obj.QueryExecute(sql_query)

        MsgBox("Deleted Assigned Customer Successfully", MsgBoxStyle.Information)

        GridFill_Customer()
        GridFill_AssignedArea()
        GridFill_AssignedCustomer()
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

    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        GridFill_AssignedCustomer()
    End Sub

    Private Sub cmbArea_Leave(sender As Object, e As EventArgs) Handles cmbArea.Leave
        btnLoad.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteData()
    End Sub

#End Region

End Class