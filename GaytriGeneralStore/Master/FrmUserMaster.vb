Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmUserMaster

#Region "Comments"
    'Name:ERPSoft
    'Created By: Manav
    'Form: FrmUserMaster
    'Date: 11/10/2014
#End Region

    'Jai Shree Ram

#Region "Declaration"
    Dim ds As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String
    Dim edit_ins As Integer = -1
    Dim existCode As String
    Dim oldCode As String
#End Region

#Region "Function"

    Public Function checkUserName() As Boolean
        If edit_ins = 1 Then
            existCode = obj.ScalarExecute("Select UserName From tbl_UserMaster Where UserName = N'" & Trim(txtUserName.Text) & "'")
            If Trim(txtUserName.Text) = existCode Then
                Return True
            Else
                Return False
            End If
        Else
            existCode = obj.ScalarExecute("Select UserName from tbl_UserMaster Where UserId <> " & Val(lblUserId.Text) & " And UserName = N'" & Trim(txtUserName.Text) & "'")
            If Trim(txtUserName.Text) = existCode Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

#End Region

#Region "Method"

    Public Sub gridFill()
        ds.Clear()
        If cmbF_DeptName.Text = "ALL" Then
            sql_query = "Select * From View_UserMaster Where CId = " & M_CId & " And UserName Like '" & Trim(txtF_UserName.Text) & "%'"
        Else
            sql_query = "Select * From View_UserMaster Where CId = " & M_CId & " And UserName Like '" & Trim(txtF_UserName.Text) & "%' And DeptName = '" & cmbF_DeptName.Text & "'"
        End If

        obj.LoadData(sql_query, ds)
        gcData.DataSource = ds.Tables(0).DefaultView
    End Sub

    Public Sub formatGrid()
        gvData.Columns("UserId").Visible = False
        gvData.Columns("DeptId").Visible = False
        gvData.Columns("UserPwd").Visible = False
        gvData.Columns("CId").Visible = False
        gvData.Columns("LedgerId").Visible = False
        gvData.Columns("Barcode_CIdList").Visible = False
        gvData.Columns("UserName").Caption = "Login"
        gvData.Columns("PrintName").Caption = "User Name"
        gvData.Columns("DeptName").Caption = "Department"
        gvData.Columns("MobileNo").Caption = "Contact No"
        gvData.Columns("IsOTPRequired").Caption = "OTP Required"
        gvData.Columns("EmailId").Caption = "Email-Id"
        'gvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Public Sub fillData()
        If gvData.FocusedRowHandle >= 0 Then
            lblUserId.Text = gvData.GetFocusedRowCellValue("UserId").ToString()
            txtUserName.Text = gvData.GetFocusedRowCellValue("UserName").ToString()
            txtPrintName.Text = gvData.GetFocusedRowCellValue("PrintName").ToString()
            cmbDeptName.SelectedValue = gvData.GetFocusedRowCellValue("DeptId")
            txtUserPwd.Text = gvData.GetFocusedRowCellValue("UserPwd").ToString()
            txtMobileNo.Text = gvData.GetFocusedRowCellValue("MobileNo").ToString()
            txtEmailId.Text = gvData.GetFocusedRowCellValue("EmailId").ToString()
            IsOTPRequired.Checked = Convert.ToBoolean(gvData.GetFocusedRowCellValue("IsOTPRequired"))
        End If
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

    Public Sub ComboFill_Search(ByVal cmb As ComboBox, ByVal sql As String)
        Dim dsCmb As New Data.DataSet
        dsCmb.Clear()
        sql_query = sql
        obj.LoadData(sql_query, dsCmb)
        cmb.Items.Add("ALL")
        Select Case dsCmb.Tables(0).Columns.Count
            Case 1
                For i As Integer = 0 To dsCmb.Tables(0).Rows.Count - 1
                    cmb.Items.Add(dsCmb.Tables(0).Rows(i)(0))
                Next
                Exit Select
            Case 2
                For i As Integer = 0 To dsCmb.Tables(0).Rows.Count - 1
                    cmb.Items.Add(dsCmb.Tables(0).Rows(i)(1))
                Next
                Exit Select
        End Select
        dsCmb.Dispose()
    End Sub

    Public Sub insert()
        obj.Prepare("SP_InsertUserMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@InsUserName", Dtype.varchar, Trim(txtUserName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsUserPwd", Dtype.varchar, Trim(txtUserPwd.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsDeptId", Dtype.int, cmbDeptName.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@InsPrintName", Dtype.varchar, Trim(txtPrintName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@InsCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@Sys_Name", Dtype.nvarchar, My.Computer.Name, ParaDirection.Input, True)
        obj.AddCmdParameter("@Sys_Time", Dtype.DateTime, Date.Now, ParaDirection.Input, True)
        obj.AddCmdParameter("@CurrUsr", Dtype.nvarchar, loggedUser, ParaDirection.Input, True)
        obj.AddCmdParameter("@LedgerId", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@Barcode_CIdList", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@MobileNo", Dtype.varchar, Trim(txtMobileNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@IsOTPRequired", Dtype.Bit, IsOTPRequired.Checked, ParaDirection.Input, True)
        obj.AddCmdParameter("@EmailId", Dtype.varchar, Trim(txtEmailId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@IsDemo", Dtype.Bit, True, ParaDirection.Input, True)
        obj.ExecuteCommand()

        MessageBox.Show("User Inserted Successfully")

        Dim tmpUserId As Integer
        sql_query = "select Max(UserId) from Tbl_UserMaster Where UserName = N'" & Trim(txtUserName.Text) & "'"
        tmpUserId = obj.ScalarExecute(sql_query)

        Dim tmpds As New Data.DataSet
        sql_query = "Select * from tbl_FormViewMaster"
        obj.LoadData(sql_query, tmpds)

        For i As Integer = 0 To tmpds.Tables(0).Rows.Count - 1
            sql_query = "Insert Into tbl_UserRightsMaster (UserId, FormViewId, AllowAccess, NewRecord, ModifyRecord, DeleteRecord) " _
                & " Values(" & tmpUserId & ", " & tmpds.Tables(0).Rows(i)("FormViewId") & ",'False','False','False','False')"
            obj.QueryExecute(sql_query)
        Next
    End Sub

    Public Sub edit()
        obj.Prepare("SP_UpdateUserMaster", SpType.StoredProcedure)
        obj.AddCmdParameter("@UpUserName", Dtype.varchar, Trim(txtUserName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpUserPwd", Dtype.varchar, Trim(txtUserPwd.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpDeptId", Dtype.int, cmbDeptName.SelectedValue, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpPrintName", Dtype.varchar, Trim(txtPrintName.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCId", Dtype.int, M_CId, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSys_Name", Dtype.nvarchar, My.Computer.Name, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpSys_Time", Dtype.DateTime, Date.Now, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpCurrUsr", Dtype.nvarchar, loggedUser, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpLedgerId", Dtype.int, 0, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpBarcode_CIdList", Dtype.varchar, "", ParaDirection.Input, True)
        obj.AddCmdParameter("@UpMobileNo", Dtype.varchar, Trim(txtMobileNo.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIsOTPRequired", Dtype.Bit, IsOTPRequired.Checked, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpEmailId", Dtype.varchar, Trim(txtEmailId.Text), ParaDirection.Input, True)
        obj.AddCmdParameter("@UpIsDemo", Dtype.Bit, True, ParaDirection.Input, True)
        obj.AddCmdParameter("@UpUserId", Dtype.int, Trim(lblUserId.Text), ParaDirection.Input, True)
        obj.ExecuteCommand()

        MessageBox.Show("User Updated Successfully")
    End Sub

    Public Sub del()
        sql_query = "Delete From Tbl_UserMaster Where UserId = " & Val(lblUserId.Text)
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub loadTime()
        ComboFill(cmbDeptName, "Select DeptId, DeptName From Tbl_DeptMaster Order By DeptName")
        ComboFill_Search(cmbF_DeptName, "Select DeptId, DeptName From Tbl_DeptMaster Order By DeptName")
        'ComboFill(cmbDefaultWorker, "Select LedgerId, LedgerName From tbl_LedgerMaster where G_Id in(30,40) Order By LedgerName")

        cmbF_DeptName.SelectedIndex = 0

        gridFill()
        formatGrid()

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        gcData.Enabled = True
        pnlMainDetail.Enabled = False
    End Sub

    Public Sub addClickTime()
        pnlMainDetail.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True

        edit_ins = 1
    End Sub

    Public Sub editClickTime()
        pnlMainDetail.Enabled = True
        gcData.Enabled = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        edit_ins = 0

        oldCode = Trim(txtUserName.Text)
    End Sub

    Public Sub clearFields_NewState()
        pnlMainDetail.Enabled = False
        gcData.Enabled = True

        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnExit.Enabled = True
        btnAdd.Focus()

        txtUserName.Clear()
        txtUserPwd.Clear()
        txtPrintName.Clear()
        txtMobileNo.Clear()
        txtEmailId.Clear()
        IsOTPRequired.Checked = False
        edit_ins = -1
    End Sub

    Public Sub saveClickTime()
        gridFill()
        clearFields_NewState()
    End Sub

    Public Sub deleteClickTime()
        gridFill()
        clearFields_NewState()
    End Sub

    Public Sub cancelClickTime()
        clearFields_NewState()
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

    Private Sub FrmUserMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadTime()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If checkRightsToAdd("USER MASTER") = False Then
            MsgBox("Unable To Add New Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        addClickTime()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If checkRightsToEdit("USER MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(txtUserName.Text) = "" Then
            txtUserName.Focus()
            MsgBox("Please Specify User Name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If cmbDeptName.SelectedIndex = -1 Or Trim(cmbDeptName.Text) = "" Then
            MsgBox("Please Select Department", MsgBoxStyle.Information)
            cmbDeptName.Focus()
            Exit Sub
        End If

        If Trim(txtUserPwd.Text) = "" Then
            txtUserName.Focus()
            MsgBox("Please Specify User Password", MsgBoxStyle.Information)
            Exit Sub
        End If

        If checkUserName() = True Then
            MsgBox("User Name Already Exists", MsgBoxStyle.Critical)
            txtUserName.Focus()
            Exit Sub
        End If

        'If cmbDefaultWorker.SelectedIndex = -1 Then
        '    MsgBox("Please Select Default Worker", MsgBoxStyle.Critical)
        '    cmbDefaultWorker.Focus()
        '    Exit Sub
        'End If

        If edit_ins = 1 Then
            insert()
        Else
            edit()
        End If

        saveClickTime()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkRightsToDelete("USER MASTER") = False Then
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        cancelClickTime()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        exitClickTime()
    End Sub

    Private Sub txtF_UserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtF_UserName.TextChanged
        gridFill()
    End Sub

    Private Sub cmbF_DeptName_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbF_DeptName.Validating
        gridFill()
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserPwd.KeyPress, txtUserName.KeyPress, txtPrintName.KeyPress, txtF_UserName.KeyPress, cmbF_DeptName.KeyPress, cmbDeptName.KeyPress, txtMobileNo.KeyPress, txtEmailId.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbDeptName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbF_DeptName.Enter, cmbDeptName.Enter
        If sender.Items.Count > 0 And sender.SelectedIndex = -1 Then
            sender.SelectedIndex = 0
        End If
        sender.DroppedDown = True
    End Sub

    Private Sub gvData_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvData.RowClick

        If e.RowHandle < 0 Then Exit Sub

        fillData()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False

    End Sub

    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick

        If gvData.FocusedRowHandle < 0 Then Exit Sub

        fillData()

        If checkRightsToEdit("USER MASTER") = False Then
            MsgBox("Unable To Edit Record", MsgBoxStyle.Information)
            Exit Sub
        End If

        editClickTime()

    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged

        If gvData.FocusedRowHandle < 0 Then Exit Sub

        fillData()

        btnCancel.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False

    End Sub

#End Region

End Class