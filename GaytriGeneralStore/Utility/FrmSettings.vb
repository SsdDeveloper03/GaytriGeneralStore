Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmSettings

#Region "Comments"
    'Name:Gayatry
    'Created By:Manav
    'Form:FrmSettings
    'Date:13/03/2026
#End Region

#Region "Declaration"

    Dim ds As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String

#End Region

#Region "Methods"

    Public Sub gridfill(moduleName As String)
        grdSettings.Rows.Clear()
        ds.Clear()

        Dim filter As String = ""
        If moduleName <> "" Then
            filter = filter & " And ModuleName = '" & moduleName & "'"
        End If

        sql_query = "Select * From tbl_Settings Where CId = " & M_CId & " And SettingName Like '%" & Trim(txtF_SettingName.Text) & "%' " & filter
        obj.LoadData(sql_query, ds)

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            grdSettings.Rows.Add()
            grdSettings.Rows(i).Cells("SettingId").Value = ds.Tables(0).Rows(i)("SettingId")
            grdSettings.Rows(i).Cells("SettingName").Value = ds.Tables(0).Rows(i)("SettingName")
            grdSettings.Rows(i).Cells("SettingValue").Value = ds.Tables(0).Rows(i)("SettingValue")
            grdSettings.Rows(i).Cells("ModuleName").Value = ds.Tables(0).Rows(i)("ModuleName")
        Next
    End Sub

    Public Sub edit()
        For i As Integer = 0 To grdSettings.Rows.Count - 1
            'sql_query = "Update tbl_Settings Set SettingValue = '" & grdSettings.Rows(i).Cells("SettingValue").Value & "' Where SettingName = '" & grdSettings.Rows(i).Cells("SettingName").Value & "' And SettingId = " & grdSettings.Rows(i).Cells("SettingId").Value
            'obj.QueryExecute(sql_query)

            obj.Prepare("SP_UpdateSettings", SpType.StoredProcedure)
            obj.AddCmdParameter("@UpSettingName", Dtype.varchar, grdSettings.Rows(i).Cells("SettingName").Value, ParaDirection.Input, True)
            obj.AddCmdParameter("@UpSettingValue", Dtype.varchar, Trim(grdSettings.Rows(i).Cells("SettingValue").Value), ParaDirection.Input, True)
            obj.AddCmdParameter("@UpCId", Dtype.varchar, M_CId, ParaDirection.Input, True)
            obj.AddCmdParameter("@UpModuleName", Dtype.varchar, Trim(grdSettings.Rows(i).Cells("ModuleName").Value), ParaDirection.Input, True)
            obj.AddCmdParameter("@UpSettingId", Dtype.varchar, grdSettings.Rows(i).Cells("SettingId").Value, ParaDirection.Input, True)
            obj.ExecuteCommand()
        Next

        M_LoadSettings()

        loadSettings()

        MsgBox("Settings Updated Successfully", MsgBoxStyle.Information)
    End Sub

#End Region

#Region "Events"

    Private Sub FrmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case M_callingForm_SettingHelp
            Case "frmPurchase_Settings"
                gridfill("Purchase")
                Exit Select
            Case "frmSales_Settings"
                gridfill("Sales")
                Exit Select
            Case "frmCreditNote_Settings"
                gridfill("CreditNote")
                Exit Select
            Case Else
                gridfill("")
                Exit Select
        End Select
        M_callingForm_SettingHelp = ""
    End Sub

    Private Sub txtF_SettingName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtF_SettingName.TextChanged
        gridfill("")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        edit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmSettings_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        Select Case grdSettings.CurrentRow.Cells("SettingName").Value
            Case "INPUT CGST", "INPUT SGST", "INPUT IGST", "OUTPUT CGST", "OUTPUT SGST", "OUTPUT IGST"
                sql_query = "Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = '" & grdSettings.CurrentCell.Value & "' And CID = " & M_CId
                grdSettings.CurrentRow.Cells("SettingValue").Value = obj.ScalarExecute(sql_query)
                Exit Select
        End Select


        'sql_query = "update tbl_Settings set SettingValue = (Select LedgerId from Tbl_LedgerMaster Where AcContactPerson = '" & grdSettings.CurrentCell.Value & "' And CID = " & M_CId & ") where SettingName = '" & grdSettings.CurrentCell.Value & "' and CID = " & M_CId

    End Sub

#End Region

End Class

