Imports GaytriGeneralStore.GaytriGeneral.DB
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
'
Module ModVersion

    Public M_PCs As Integer = 1
    Public M_Users As Integer = 1
    Public pcWise As String = "Yes"
    Public userWise As String = "No"

    Dim M_ValidUpto As Date
    Public M_NewSettingFound As Boolean = False
    Public M_LoyaltyEnabled As Boolean = False
    Public M_RefferalEnabled As Boolean = False
    Public M_ProductionOrderEnabled As Boolean = False 'D : \PROJECTS\BhavikaGit17\TailoringERP\TailoringERP\ClassFiles\ModVersion.vb
    Dim obj As New DBManager
    Dim sql_query As String

    'if update customer this variable set false
    Public M_MyPc As Boolean = True
    'Public M_MyPc As Boolean = False

    Public M_HDSNumber As String '= "20246G446307"
    Public M_MacIP As String '= "50-65-F3-1B-E7-7A"
    Public M_IPAddress As String '= "192.168.5.205"
    Public dsLedgerMaster As New Data.DataSet
    Public dsMiscMaster As New Data.DataSet
    Public dsItemMaster As New Data.DataSet
    Public dsTailoringItems As New Data.DataSet
    Public dsUISettings As New Data.DataSet
    Public dsVoucherMaster As New Data.DataSet
    Public dsUserRights As New Data.DataSet
    Public dsPrintLayout As New Data.DataSet
    Public dsCuttingFormula As New Data.DataSet
    Public dsTSubItems As New Data.DataSet
    Public dsTaxStructureMaster As New Data.DataSet
    Public dsSettings As New Data.DataSet

    Public dvSettings As DataView


    Public Sub loadVoucherMaster()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Vouchers...")

        dsVoucherMaster.Clear()
        sql_query = "Select * From tbl_VoucherMaster" ' Order By LedgerName
        obj.LoadData(sql_query, dsVoucherMaster)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadCuttingFormula()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Cutting Formula...")

        dsCuttingFormula.Clear()
        sql_query = "Select * From tbl_CuttingFormula" ' Order By LedgerName
        obj.LoadData(sql_query, dsCuttingFormula)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadLedgerMaster()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Ledger Data...")

        dsLedgerMaster.Clear()
        sql_query = "Select * From View_LedgerMaster_Gaytari" ' Order By LedgerName
        obj.LoadData(sql_query, dsLedgerMaster)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadMiscMaster()
        SplashScreenManager.CloseForm(False)
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Misc Data...")

        dsMiscMaster.Clear()
        sql_query = "Select * From tbl_MiscMaster" ' Order By MiscType, MiscName
        obj.LoadData(sql_query, dsMiscMaster)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadItemMaster()
        SplashScreenManager.CloseForm(False)
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Item Data...")

        dsItemMaster.Clear()
        sql_query = "Select Cast(0 as bit) As YN, * From tbl_TItemMaster Where ItemSubType = 'Sales'" ' Order By Barcode, TItemName"
        obj.LoadData(sql_query, dsItemMaster)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadTailoringItems()
        SplashScreenManager.CloseForm(False)
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Tailoring Items...")

        dsTailoringItems.Clear()
        sql_query = "Select * From View_TailoringItems Where IsActive = 'True' And ItemSubType = 'Tailoring'"
        obj.LoadData(sql_query, dsTailoringItems)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadTSubItems()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Tailoring Sub-Items...")

        dsTSubItems.Clear()
        sql_query = "Select * From tbl_TSubItems "
        obj.LoadData(sql_query, dsTSubItems)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadTaxStructureMaster()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Tax Structure Master...")

        dsTaxStructureMaster.Clear()
        sql_query = "Select * From tbl_TaxStructureMaster "
        obj.LoadData(sql_query, dsTaxStructureMaster)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadSettings()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Settings...")

        dsSettings.Clear()
        sql_query = "Select * From tbl_Settings "
        obj.LoadData(sql_query, dsSettings)

        dvSettings = New DataView(dsSettings.Tables(0))

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadUISettings()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading UiSettings...")

        dsUISettings.Clear()
        sql_query = "Select * From tbl_UISettings"
        obj.LoadData(sql_query, dsUISettings)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadUserRights()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading User Rights...")

        dsUserRights.Clear()
        sql_query = "Select * from View_UserRightsDashboard"
        obj.LoadData(sql_query, dsUserRights)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub loadPrintLayout()
        SplashScreenManager.CloseForm(False)
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Reloading Report Layout...")

        dsPrintLayout.Clear()
        sql_query = "Select * From tbl_PrintLayoutSelection Where IsActive = 'True'"
        obj.LoadData(sql_query, dsPrintLayout)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub CheckCloudVersionDate()
        Dim tmpdate1 As String = ""
        tmpdate1 = dsCRMDetails_Local.Tables(0).Rows(0)("DemoDate")

        M_ValidUpto = tmpdate1
        M_MaxDate = Format(M_ValidUpto, M_PCDTM)

        If DateDiff(DateInterval.Day, Today, M_MaxDate) < 7 Then
            MsgBox("Days Left: " & DateDiff(DateInterval.Day, Today, M_MaxDate) & vbCrLf & " Cloud Validity Expire Soon..", MsgBoxStyle.Information)
        End If

        If DateTime.Now > M_MaxDate Then
            MsgBox("Cloud Validity Expire Please Contect With Software Support Team", MsgBoxStyle.Information)
            End
        End If

    End Sub

    Public Sub setVersionAndDate()
        sql_query = "Select SettingValue from tbl_Settings Where SettingName = 'PC DTM'"
        M_PCDTM = obj.ScalarExecute(sql_query)

        Dim tmpDate As String = ""
        If M_DbName.Contains("dbSTE_Demo") Then 'If M_DbName = "dbSTE_Demo" Then
            sql_query = "Select MiscName From tbl_miscmaster Where misctype = 'V'" 'JWONWOANAJ
            tmpDate = obj.ScalarExecute(sql_query)
        Else
            sql_query = "Select Top 1 * from tbl_CRMDetails order by Id desc"
            obj.LoadData(sql_query, dsCRMDetails_Local)

            tmpDate = dsCRMDetails_Local.Tables(0).Rows(0)("Reason")
            'DemoDate In Store Cloud DiscontinueDate If Use
            If IsDBNull(dsCRMDetails_Local.Tables(0).Rows(0)("DemoDate")) = False Then
                CheckCloudVersionDate()
            End If
        End If

        tmpDate = tmpDate.Replace("J", "1")
        tmpDate = tmpDate.Replace("A", "2")
        tmpDate = tmpDate.Replace("I", "3")
        tmpDate = tmpDate.Replace("S", "4")
        tmpDate = tmpDate.Replace("W", "5")
        tmpDate = tmpDate.Replace("M", "6")
        tmpDate = tmpDate.Replace("N", "7")
        tmpDate = tmpDate.Replace("R", "8")
        tmpDate = tmpDate.Replace("Y", "9")
        tmpDate = tmpDate.Replace("B", "0")
        tmpDate = tmpDate.Replace("G", "/")

        M_ValidUpto = tmpDate
        M_MaxDate = Format(M_ValidUpto, M_PCDTM)

        Select Case M_DbName
            Case "dbSTE_Demo"
                M_HDSNumber = "" '20246G446307
                M_MacIP = "" '5065F31BE77A
                M_IPAddress = "192.168.5.205"
                M_SoftType = "ERP"
                M_PCs = 0
                'M_ValidUpto = "15/05/2021"
                'M_MaxDate = Format(M_ValidUpto, M_PCDTM)
                M_LoyaltyEnabled = True
                M_RefferalEnabled = True
                M_ProductionOrderEnabled = True
                M_NewSettingFound = True
                Exit Select
            Case "dbGaytri_General"
                M_SoftType = "ERP"
                M_PCs = 0
                'M_ValidUpto = "15/05/2021"
                'M_MaxDate = Format(M_ValidUpto, M_PCDTM)
                M_LoyaltyEnabled = True
                M_RefferalEnabled = True
                M_ProductionOrderEnabled = True
                M_NewSettingFound = True
                Exit Select

        End Select
    End Sub

    Public Function getSettingValue(ByVal _SettingName As String) As String
        Dim tmpDT As New DataTable
        dvSettings.RowFilter = " SettingName = '" & _SettingName & "' And CId = " & M_CId
        tmpDT = dvSettings.ToTable

        Return tmpDT.Rows(0)("SettingValue")

        'sql_query = "Select V_Id From tbl_VoucherMaster Where V_Group = '" & V_Group & "'"
        'Return obj.ScalarExecute(sql_query)
    End Function

End Module