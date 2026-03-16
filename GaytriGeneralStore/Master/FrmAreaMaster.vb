Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmAreaMaster

#Region "Comments"
    'Name:Texpert
    'Created By:Manav
    'Form:FrmAreaMaster
    'Date:14/03/2026
#End Region

#Region "Declaration"
    Dim obj As New DBManager
    Dim sql_query As String
    Dim ds As New Data.DataSet
    Dim edit_ins As Integer = -1
    Dim escCount As Integer

#End Region

#Region "Methods"

    Private Sub FrmAreaMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtime()
    End Sub

    Public Sub gridfill()

        ds.Clear()

        sql_query = "Select * from tbl_AreaMaster where IsActive = 1"
        obj.LoadData(sql_query, ds)

        gcData.DataSource = ds.Tables(0)

        gvData.PopulateColumns()

        gvData.OptionsView.ColumnAutoWidth = False
        gvData.BestFitColumns()

        gvData.Columns("AreaName").Caption = "Area Name"
        gvData.Columns("CityName").Caption = "City Name"
        gvData.Columns("StateName").Caption = "State Name"
        gvData.Columns("CountryName").Caption = "Country Name"
        gvData.Columns("Pincode").Caption = "Pincode"
        gvData.Columns("DispSrNo").Caption = "Display Sr No"

        gvData.Columns("Landmark").Visible = False
        gvData.Columns("Latitude").Visible = False
        gvData.Columns("Longitude").Visible = False
        gvData.Columns("CountryCode").Visible = False
        gvData.Columns("StateCode").Visible = False

        RestoreLayout(gvData, "FrmAreaMaster")

    End Sub

    Public Sub filldata()
        If gvData.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        lblAreaId.Text = gvData.GetFocusedRowCellValue("AreaId")
        txtAreaName.Text = gvData.GetFocusedRowCellValue("AreaName")
        cmbCity.Text = gvData.GetFocusedRowCellValue("CityName")
        cmbCountry.Text = gvData.GetFocusedRowCellValue("CountryName")
        cmbState.Text = gvData.GetFocusedRowCellValue("StateName")
        txtSubArea.Text = gvData.GetFocusedRowCellValue("SubAreaName")
        txtDispSrNo.Text = gvData.GetFocusedRowCellValue("DispSrNo")
        txtLandmark.Text = gvData.GetFocusedRowCellValue("Landmark")
        txtPincode.Text = gvData.GetFocusedRowCellValue("Pincode")
        chkActive.Checked = gvData.GetFocusedRowCellValue("IsActive")

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

    Public Sub del()
        sql_query = "Delete From tbl_AreaMaster where AreaId = " & Val(lblAreaId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub Insert()
        obj.Prepare("SP_Insert_AreaMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@Landmark", Dtype.varchar, Trim(txtLandmark.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@SubAreaName", Dtype.varchar, Trim(txtSubArea.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@AreaName", Dtype.varchar, Trim(txtAreaName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@ZoneName", Dtype.varchar, Trim(cmbZone.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@CityName", Dtype.varchar, Trim(cmbCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@Pincode", Dtype.varchar, Trim(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@StateCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@StateName", Dtype.varchar, Trim(cmbState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@CountryCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@CountryName", Dtype.varchar, Trim(cmbCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@Latitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@Longitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@DispSrNo", Dtype.int, If(txtDispSrNo.Text = "", 0, Val(txtDispSrNo.Text)), ParaDirection.Input, True)
        obj.AddCmdParameter("@IsActive", Dtype.Bit, chkActive.Checked, ParaDirection.Input, True)
        obj.AddCmdParameter("@CreatedAt", Dtype.DateTime, DateTime.Now, ParaDirection.Input, True)
        obj.AddCmdParameter("@CreatedBy", Dtype.int, loggedUserId, ParaDirection.Input, True)
        obj.AddCmdParameter("@SysName", Dtype.nvarchar, Environment.MachineName, ParaDirection.Input, True)
        obj.AddCmdParameter("@CreatedFrom", Dtype.varchar, "", ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

    Public Sub edit()
        obj.Prepare("SP_Update_AreaMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@UpLandmark", Dtype.varchar, Trim(txtLandmark.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSubAreaName", Dtype.varchar, Trim(txtSubArea.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpAreaName", Dtype.varchar, Trim(txtAreaName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpZoneName", Dtype.varchar, Trim(cmbZone.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCityName", Dtype.varchar, Trim(cmbCity.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPincode", Dtype.varchar, Trim(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpStateCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpStateName", Dtype.varchar, Trim(cmbState.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCountryCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCountryName", Dtype.varchar, Trim(cmbCountry.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLatitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLongitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpDispSrNo", Dtype.int, If(txtDispSrNo.Text = "", 0, Val(txtDispSrNo.Text)), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIsActive", Dtype.Bit, chkActive.Checked, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpModifiedAt", Dtype.DateTime, DateTime.Now, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpModifiedBy", Dtype.int, loggedUserId, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSysName", Dtype.nvarchar, Environment.MachineName, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpModifiedFrom", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@AreaId", Dtype.int, Val(lblAreaId.Text), ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

#End Region

#Region "Functions"

    Public Function Validation() As Boolean

        If txtAreaName.Text = "" Then
            MsgBox("Please specify an Area Name.", MsgBoxStyle.Information)
            txtAreaName.Focus()
            Return False
        End If

        If txtPincode.Text = "" Then
            MsgBox("Please specify Pincode Number.", MsgBoxStyle.Information)
            txtPincode.Focus()
            Return False
        End If

        If txtSubArea.Text = "" Then
            MsgBox("Please specify Sub Area Name.", MsgBoxStyle.Information)
            txtSubArea.Focus()
            Return False
        End If

        If txtLandmark.Text = "" Then
            MsgBox("Please specify Landmark.", MsgBoxStyle.Information)
            txtLandmark.Focus()
            Return False
        End If

        If cmbCity.SelectedIndex = -1 Then
            MsgBox("Please Select a City.", MsgBoxStyle.Information)
            cmbCity.Focus()
            Return False
        End If

        'If cmbZone.SelectedIndex = -1 Then
        '    MsgBox("Please Select a Zone.", MsgBoxStyle.Information)
        '    cmbZone.Focus()
        '    Return False
        'End If

        Return True

    End Function

#End Region

#Region "Events"

    Public Sub loadtime()

        ComboFill(cmbCity, "Select MiscId,MiscName from tbl_MiscMaster where Misctype = 'CITY'")
        ComboFill(cmbState, "Select MiscId,MiscName from tbl_MiscMaster where Misctype = 'STATE'")
        ComboFill(cmbCountry, "Select MiscId,MiscName from tbl_MiscMaster where Misctype = 'COUNTRY'")

        gridfill()

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

        gcData.Enabled = True
        grpAreaInfo.Enabled = False

    End Sub

    Public Sub AddClickTime()
        btnAdd.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        gcData.Enabled = False
        grpAreaInfo.Enabled = True

        edit_ins = 1
        txtAreaName.Focus()
    End Sub

    Public Sub EditClickTime()

        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        edit_ins = 0
        gcData.Enabled = False
        grpAreaInfo.Enabled = True

        filldata()
    End Sub

    Public Sub DeleteClickTime()

        btnAdd.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = True

        del()

        gcData.Enabled = True
        grpAreaInfo.Enabled = False

    End Sub

    Public Sub SaveClickTime()
        If edit_ins = 1 Then
            Insert()
        Else
            edit()
        End If

        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        gcData.Enabled = True
        grpAreaInfo.Enabled = False


    End Sub

    Public Sub CancelClickTime()
        clearfields()

        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        gcData.Enabled = True
        grpAreaInfo.Enabled = False

    End Sub

    Public Sub ExitClickTime()
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

    Public Sub clearfields()

        txtAreaName.Clear()
        txtDispSrNo.Clear()
        txtLandmark.Clear()
        txtLatitude.Clear()
        txtLongitude.Clear()
        txtPincode.Clear()
        txtSubArea.Clear()

        cmbCity.SelectedIndex = -1
        cmbState.SelectedIndex = -1
        cmbCountry.SelectedIndex = -1
        cmbZone.SelectedIndex = -1

    End Sub

    Public Sub RefreshClickTime()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True

        clearfields()
        gridfill()

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
        SaveLayout(gvData, "FrmAreaMaster", Me)
    End Sub

    Private Sub gvData_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(gcData, e.Location)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddClickTime()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditClickTime()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteClickTime()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Validation() = False Then
            Exit Sub
        End If

        SaveClickTime()
        RefreshClickTime()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CancelClickTime()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ExitClickTime()
    End Sub

    Private Sub gvData_Click(sender As Object, e As EventArgs) Handles gvData.Click

        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length <= 0 Then
            Exit Sub
        End If

        filldata()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick

        Dim selectedRows() As Integer = gvData.GetSelectedRows

        If selectedRows.Length <= 0 Then
            Exit Sub
        End If

        filldata()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False

        'If checkRightsToEdit("AREA MASTER") = False Then
        '    MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        EditClickTime()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshclicktime()
    End Sub

    Private Sub FrmAreaMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.F2
                If btnAdd.Enabled = True Then btnAdd.PerformClick()

            Case Keys.F3
                If btnEdit.Enabled = True Then btnEdit.PerformClick()

            Case Keys.F5
                If btnRefresh.Enabled = True Then btnRefresh.PerformClick()

            Case Keys.F6
                If btnSave.Enabled = True Then btnSave.PerformClick()

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

#End Region

End Class