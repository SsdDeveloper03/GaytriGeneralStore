Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmAreaMaster

#Region "Comments"

#End Region

#Region "Declaration"
    Dim obj As DBManager
    Dim sql_query As String
    Dim ds As Data.DataSet
    Dim edit_ins As Integer = -1

#End Region

#Region "Methods"

    Private Sub FrmAreaMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtime()
    End Sub

    Public Sub gridfill()
        sql_query = "Select AreaName, CityName, StateName, CountryName, DispSrNo, * from tbl_AreaMaster where IsActive = 'True'"
        obj.LoadData(sql_query, ds)

        gcArea.DataSource = ds.Tables(0).DefaultView
        gvArea.OptionsView.ColumnAutoWidth = False
        gvArea.BestFitColumns()

        gvArea.Columns("AreaName").Caption = "Area Name"
        gvArea.Columns("CityName").Caption = "City Name"
        gvArea.Columns("StateName").Caption = "State Name"
        gvArea.Columns("CountryName").Caption = "Country Name"
        gvArea.Columns("Pincode").Caption = "Pincode"
        gvArea.Columns("DispSrNo").Caption = "Display Sr No"

        gvArea.Columns("Landmark").Visible = False
        gvArea.Columns("Latitude").Visible = False
        gvArea.Columns("Longitude").Visible = False
        gvArea.Columns("Zone").Visible = False
        gvArea.Columns("CountryCode").Visible = False
        gvArea.Columns("StateCode").Visible = False
        gvArea.Columns("CreatedAt").Visible = False
        gvArea.Columns("ModuifiedAt").Visible = False
        gvArea.Columns("CreatedBy").Visible = False
        gvArea.Columns("SysName").Visible = False
        gvArea.Columns("CreatedFrom").Visible = False
        gvArea.Columns("ModuifiedFrom").Visible = False

        RestoreLayout(gvArea, "FrmAreaMaster")
    End Sub

    Public Sub filldata()
        If gvArea.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        lblAreaId.Text = gvArea.GetFocusedRowCellValue("AreaId")
        txtAreaName.Text = gvArea.GetFocusedRowCellValue("AreaName")
        cmbCity.Text = gvArea.GetFocusedRowCellValue("CityName")
        cmbCountry.Text = gvArea.GetFocusedRowCellValue("CountryName")
        cmbState.Text = gvArea.GetFocusedRowCellValue("StateName")
        cmbZone.Text = gvArea.GetFocusedRowCellValue("ZoneName")
        txtDispSrNo.Text = gvArea.GetFocusedRowCellValue("DispSrNo")
        txtLandmark.Text = gvArea.GetFocusedRowCellValue("Landmark")
        txtPincode.Text = gvArea.GetFocusedRowCellValue("Pincode")
        txtSubArea.Text = gvArea.GetFocusedRowCellValue("SubArea")
        chkActive.Checked = gvArea.GetFocusedRowCellValue("IsActive")

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
        obj.AddCmdParameter("@AreaName", Dtype.varchar, Val(txtAreaName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@Landmark", Dtype.varchar, Val(txtLandmark.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@SubAreaName", Dtype.varchar, Val(txtSubArea.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@ZoneName", Dtype.varchar, cmbZone.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@CityName", Dtype.varchar, cmbCity.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@Pincode", Dtype.varchar, Val(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@StateCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@StateName", Dtype.varchar, cmbState.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@CountryCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@CountryName", Dtype.varchar, cmbCountry.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@Latitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@Longitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@DispSrNo", Dtype.int, Val(txtDispSrNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@IsActive", Dtype.Bit, Val(chkActive.Checked), ParaDirection.Input, True)
        obj.AddCmdParameter("@CreatedAt", Dtype.DateTime, DateTime.Now, ParaDirection.Input, True)
        obj.AddCmdParameter("@CreatedBy", Dtype.int, loggedUserId, ParaDirection.Input, True)
        obj.AddCmdParameter("@CreatedFrom", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@SysName", Dtype.nvarchar, Environment.MachineName, ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

    Public Sub edit()
        obj.Prepare("SP_Update_AreaMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@AreaName", Dtype.varchar, Val(txtAreaName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@Landmark", Dtype.varchar, Val(txtLandmark.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@SubAreaName", Dtype.varchar, Val(txtSubArea.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@ZoneName", Dtype.varchar, cmbZone.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@CityName", Dtype.varchar, cmbCity.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@Pincode", Dtype.varchar, Val(txtPincode.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@StateCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@StateName", Dtype.varchar, cmbState.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@CountryCode", Dtype.varchar, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@CountryName", Dtype.varchar, cmbCountry.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@Latitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@Longitude", Dtype.float, DBNull.Value, ParaDirection.Input, True)
        obj.AddCmdParameter("@DispSrNo", Dtype.int, Val(txtDispSrNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@IsActive", Dtype.Bit, Val(chkActive.Checked), ParaDirection.Input, True)
        obj.AddCmdParameter("@ModifiedAt", Dtype.DateTime, DateTime.Now, ParaDirection.Input, True)
        obj.AddCmdParameter("@ModifiedBy", Dtype.int, loggedUserId, ParaDirection.Input, True)
        obj.AddCmdParameter("@ModifiedFrom", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@SysName", Dtype.nvarchar, Environment.MachineName, ParaDirection.Input, True)
        obj.ExecuteCommand()
    End Sub

#End Region

#Region "Functions"

    Public Function Validation()
        If txtAreaName.Text = "" Then
            MsgBox("Please specify An Area Name.")
        End If

        If txtPincode.Text = "" Then
            MsgBox("Please specify Pincode Number.")
        End If

        If txtSubArea.Text = "" Then
            MsgBox("Please specify Sub Area Name.")
        End If

        If txtLandmark.Text = "" Then
            MsgBox("Please specify Landmark.")
        End If

        If cmbCity.SelectedIndex = -1 Then
            MsgBox("Please Select a City.")
        End If

        If cmbZone.SelectedIndex = -1 Then
            MsgBox("Please Select a Zone.")
        End If

    End Function

#End Region

#Region "Events"

    Public Sub loadtime()

        ComboFill(cmbCity, "Select Data1 from tbl_MiscMaster where Misctype = 'City'")
        ComboFill(cmbState, "Select Data1 from tbl_MiscMaster where Misctype = 'State'")
        ComboFill(cmbCountry, "Select Data1 from tbl_MiscMaster where Misctype = 'Country'")

        gridfill()

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False

        gcArea.Enabled = True
        grpAreaInfo.Enabled = False

    End Sub

    Public Sub AddClickTime()
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        gcArea.Enabled = False
        grpAreaInfo.Enabled = True


        txtAreaName.Focus()
    End Sub

    Public Sub EditClickTime()

        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        gcArea.Enabled = False
        grpAreaInfo.Enabled = True

        filldata()
    End Sub

    Public Sub DeleteClickTime()

        btnAdd.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = True

        del()

        gcArea.Enabled = True
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

        gcArea.Enabled = True
        grpAreaInfo.Enabled = False

    End Sub

    Public Sub CancelClickTime()
        clearfields()

        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        gcArea.Enabled = True
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

    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
        gvArea.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvArea.FocusedColumn.FieldName)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog

        If sfd.ShowDialog() = DialogResult.OK Then
            gvArea.ExportToXlsx(sfd.FileName & ".xlsx")
        End If
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        SaveLayout(gvArea, "FrmAreaMaster", Me)
    End Sub

    Private Sub gvArea_MouseDown(sender As Object, e As MouseEventArgs) Handles gvArea.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(gcArea, e.Location)
        End If
    End Sub

#End Region

End Class