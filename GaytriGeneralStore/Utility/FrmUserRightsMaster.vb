Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmUserRightsMaster

#Region "Comments"
    'Name:Gayatry General
    'Created By:Manav
    'Form:FrmUserRightsMaster
    'Date:05/02/2026
#End Region

#Region "Declaration"
    Private dt1 As DataTable
    Dim ds As New Data.DataSet
    Dim dsUser As New Data.DataSet
    Dim dsUser1 As New Data.DataSet
    Dim dsRights As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String
#End Region


#Region "Method"

    Public Sub gridFill()
        ds.Clear()
        dt1 = New DataTable
        dt1.Columns.Add("FormViewId")
        dt1.Columns.Add("FormViewName")
        dt1.Columns.Add("FormView")
        dt1.Columns.Add("MenuName")
        dt1.Columns.Add("IsActive")
        dt1.Columns.Add("AllowAccess")
        dt1.Columns.Add("NewRecord")
        dt1.Columns.Add("ModifyRecord")
        dt1.Columns.Add("DeleteRecord")
        dt1.Columns.Add("AllowPrevYearTran")

        gcData.DataSource = dt1

        sql_query = "Select FormViewId, FormViewName, FormView, MenuName, IsActive, AllowAccess, NewRecord, ModifyRecord, DeleteRecord,AllowPrevYearTran From View_UserRightsMaster" _
            & " Where IsActive = 'True' And UserId = " & gvUsers.GetFocusedRowCellValue("UserId") & "" _
            & " Order By MenuName, MenuSrNo"

        obj.LoadData(sql_query, ds)
        gcData.DataSource = ds.Tables(0).DefaultView
    End Sub

    Public Sub gridFill_UserList()
        dsUser.Clear()

        dt1 = New DataTable
        dt1.Columns.Add("UserId")
        dt1.Columns.Add("UserName")
        dt1.Columns.Add("UserPwd")
        dt1.Columns.Add("DeptId")

        gcUsers.DataSource = dt1
        gvUsers.Columns("UserId").Visible = False
        gvUsers.Columns("UserPwd").Visible = False
        gvUsers.Columns("DeptId").Visible = False

        If loggedUser = "DEMO" Then
            sql_query = "Select * From tbl_UserMaster Order By UserName"
        Else
            sql_query = "Select * From tbl_UserMaster Where DeptId In (SELECT DeptId From Tbl_DeptMaster Where DeptName Not In('MIS')) Order By UserName"
        End If

        obj.LoadData(sql_query, dsUser)

        For i As Integer = 0 To dsUser.Tables(0).Rows.Count - 1
            Dim dr As DataRow = dt1.NewRow
            dr(0) = dsUser.Tables(0).Rows(i)("UserId")
            dr(1) = dsUser.Tables(0).Rows(i)("UserName")
            dr(2) = dsUser.Tables(0).Rows(i)("UserPwd")
            dr(3) = dsUser.Tables(0).Rows(i)("DeptId")

            dt1.Rows.Add(dr)
            gcUsers.DataSource = dt1
        Next
    End Sub

    Public Sub gridFill_UserList1()
        dsUser1.Clear()

        dt1 = New DataTable
        dt1.Columns.Add("UserId1")
        dt1.Columns.Add("UserName1")
        dt1.Columns.Add("UserPwd1")
        dt1.Columns.Add("DeptId1")

        grdData1.DataSource = dt1
        grdUserList1.Columns("UserId1").Visible = False
        grdUserList1.Columns("UserPwd1").Visible = False
        grdUserList1.Columns("DeptId1").Visible = False

        If loggedUser = "DEMO" Then
            sql_query = "Select * From tbl_UserMaster Where UserName Not In('" & gvUsers.GetFocusedRowCellValue("UserName") & "') Order By UserName"
        Else
            sql_query = "Select * From tbl_UserMaster Where UserName Not In('ADMIN','" & gvUsers.GetFocusedRowCellValue("UserName") & "') And DeptId In (SELECT DeptId From Tbl_DeptMaster Where DeptName Not In('MIS')) Order By UserName"
        End If

        obj.LoadData(sql_query, dsUser1)

        For i As Integer = 0 To dsUser1.Tables(0).Rows.Count - 1
            Dim dr As DataRow = dt1.NewRow
            dr(0) = dsUser1.Tables(0).Rows(i)("UserId")
            dr(1) = dsUser1.Tables(0).Rows(i)("UserName")
            dr(2) = dsUser1.Tables(0).Rows(i)("UserPwd")
            dr(3) = dsUser1.Tables(0).Rows(i)("DeptId")

            dt1.Rows.Add(dr)
            grdData1.DataSource = dt1
        Next
    End Sub

    Public Sub gridRowSelectionTime()
        For i As Integer = 0 To gvData.RowCount - 1
            If gvData.IsRowSelected(i) Then
                dsRights.Clear()
                sql_query = "Select * From tbl_UserRightsMaster Where UserId = " & Val(gvUsers.GetRowCellValue(i, "UserId")) _
                    & " And FormViewId = " & Val(gvData.GetFocusedRowCellValue("FormViewId"))
                obj.LoadData(sql_query, dsRights)
            End If
        Next
    End Sub

    Public Sub insert(ByVal i As Integer)
        sql_query = "Insert Into tbl_UserRightsMaster(UserId, FormViewId, AllowAccess, NewRecord, ModifyRecord, DeleteRecord, AllowPrevYearTran)" _
            & " Values(" & gvUsers.GetRowCellValue(i, "UserId") & ", " & gvData.GetRowCellValue(i, "FormViewId") & "," _
            & " '" & gvData.GetRowCellValue(i, "AllowAccess") & "', '" & gvData.GetRowCellValue(i, "NewRecord") & "'," _
            & " '" & gvData.GetRowCellValue(i, "ModifyRecord") & "', '" & gvData.GetRowCellValue(i, "DeleteRecord") & "'," _
            & " '" & gvData.GetRowCellValue(i, "AllowPrevYearTran") & "')"
        obj.QueryExecute(sql_query)
    End Sub

    Public Sub edit(ByVal i As Integer)
        sql_query = "Update tbl_UserRightsMaster Set AllowAccess = '" & gvData.GetRowCellValue(i, "AllowAccess") & "'" _
            & " , NewRecord = '" & gvData.GetRowCellValue(i, "NewRecord") & "'" _
            & " , ModifyRecord = '" & gvData.GetRowCellValue(i, "ModifyRecord") & "'" _
            & " , DeleteRecord  = '" & gvData.GetRowCellValue(i, "DeleteRecord") & "'" _
            & " , AllowPrevYearTran = '" & gvData.GetRowCellValue(i, "AllowPrevYearTran") & "'" _
            & " Where UserId = " & gvUsers.GetFocusedRowCellValue("UserId") & " And FormViewId = " & gvData.GetRowCellValue(i, "FormViewId")
        obj.QueryExecute(sql_query)
    End Sub


#End Region

#Region "Events"

    Private Sub FrmUserRightsMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gridFill_UserList()
        gridFill()
    End Sub

    Private Sub grdFormViewMaster_Click(sender As System.Object, e As System.EventArgs) Handles gvData.Click
        gridRowSelectionTime()
    End Sub

    Private Sub grdFormViewMaster_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvData.KeyUp
        gridRowSelectionTime()
    End Sub

    Private Sub grdUserList_Click(sender As System.Object, e As System.EventArgs) Handles gvUsers.Click
        gridFill()
    End Sub

    Private Sub grdUserList_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvUsers.KeyDown
        If Control.ModifierKeys = Keys.Control Then
            Select Case e.KeyCode
                Case Keys.C
                    grdData1.Enabled = True
                    gridFill_UserList1()
                    lblUserId.Text = gvUsers.GetFocusedRowCellValue("UserId")
                    lblUserName.Text = gvUsers.GetFocusedRowCellValue("UserName")
                    Exit Select
            End Select

        End If
    End Sub

    Private Sub grdUserList1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdUserList1.KeyDown
        If Control.ModifierKeys = Keys.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    If lblUserName.Text <> gvUsers.GetFocusedRowCellValue("UserName") Then
                        MsgBox("Selected User {" & gvUsers.GetFocusedRowCellValue("UserName") & "} Is Different Then Copy From User {" & lblUserName.Text & "}", MsgBoxStyle.Critical)
                        Exit Sub
                    End If

                    Dim dr As DialogResult
                    dr = MsgBox("Sure To Assing User Right of {" & lblUserName.Text & "} To Selected Users", MsgBoxStyle.YesNo)
                    If dr = Windows.Forms.DialogResult.Yes Then
                        Dim cnt As Integer
                        For i As Integer = 0 To grdUserList1.RowCount - 1
                            If grdUserList1.IsRowSelected(i) Then
                                Dim a As Integer = grdUserList1.GetFocusedRowCellValue("UserId1")
                                sql_query = "Delete From tbl_UserRightsMaster Where UserId = " & grdUserList1.GetFocusedRowCellValue("UserId1")
                                obj.QueryExecute(sql_query)

                                sql_query = "Insert Into tbl_UserRightsMaster " _
                                    & "Select " & grdUserList1.GetRowCellValue(i, "UserId1") & ", FormViewId, AllowAccess, NewRecord, ModifyRecord, DeleteRecord, AllowPrevYearTran From tbl_UserRightsMaster Where UserId = " & Val(lblUserId.Text)
                                obj.QueryExecute(sql_query)
                                cnt = cnt + 1
                            End If
                        Next
                        MsgBox("Rights Assigned To " & cnt & " User(s)", MsgBoxStyle.Information)
                    End If
                    Exit Select
            End Select
        End If
        If e.KeyCode = Keys.Escape Then
            grdUserList1.Columns.Clear()
            grdData1.Enabled = False

            lblUserId.Text = ""
            lblUserName.Text = ""
        End If
    End Sub

    Private Sub grdUserList_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvUsers.KeyUp
        gridRowSelectionTime()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        For i As Integer = 0 To gvData.RowCount - 1
            If gvData.IsRowSelected(i) = True Then
                If Val(gvData.GetRowCellValue(i, "FormViewId")) > 0 Then
                    edit(i)
                Else
                    insert(i)
                End If
            End If
        Next
        MsgBox("Rights Modified Successfully", MsgBoxStyle.Information)
        M_loadUserRights()
        gridFill()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CheckAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAllToolStripMenuItem.Click
        For i As Integer = 0 To gvData.RowCount - 1
            gvData.SetRowCellValue(i, gvData.FocusedColumn, True)
        Next
    End Sub

    Private Sub UncheckALlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UncheckALlToolStripMenuItem.Click
        For i As Integer = 0 To gvData.RowCount - 1
            gvData.SetRowCellValue(i, gvData.FocusedColumn, False)
        Next
    End Sub

    Private Sub RenameFieldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFieldToolStripMenuItem.Click
        Dx_RenameColumn(gvData)
    End Sub

#End Region

End Class