Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmMDIMain

#Region "Comments"

#End Region

#Region "Declaration"
    Dim obj As New DBManager
    Dim sql_query As String
    Dim _cmbFinYrIndx, _CmbCNameIndx As Integer
    Dim panelVisible As Boolean = False
    Dim cntInterval As Integer = 0
    Dim dvMiscMaster As DataView
#End Region

#Region "Method"

    Public Sub New()
        InitializeComponent()
        Me.IsMdiContainer = True
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


    Public Sub setBGIMG()
        If M_BgImg <> "Default" And dvMiscMaster IsNot Nothing Then
            Try
                '=========
                dvMiscMaster.RowFilter = "MiscType = 'BGIMG' And CId = " & M_CId

                Dim tmpDT As New DataTable
                tmpDT = dvMiscMaster.ToTable
                '=========

                'Panel1.BackgroundImage = Image.FromFile(obj.ScalarExecute("Select MiscName From Tbl_MiscMaster Where MiscType = 'BGIMG'"))

                Panel1.BackgroundImage = Image.FromFile(tmpDT.Rows(0)("MiscName"))

                Select Case M_BackgroundImageLayout
                    Case "Center"
                        Panel1.BackgroundImageLayout = ImageLayout.Center
                        Exit Select
                    Case "Stretch"
                        Panel1.BackgroundImageLayout = ImageLayout.Stretch
                        Exit Select
                    Case "Tile"
                        Panel1.BackgroundImageLayout = ImageLayout.Tile
                        Exit Select
                    Case "Zoom"
                        Panel1.BackgroundImageLayout = ImageLayout.Zoom
                        Exit Select
                    Case "None"
                        Panel1.BackgroundImageLayout = ImageLayout.None
                        Exit Select
                End Select
            Catch ex As Exception
                obj.LogError(ex.Message, ex.StackTrace)
                MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End If
    End Sub

    Public Sub loadFinYrMaster()
        M_dsFinYr.Clear()
        obj.LoadData("Select * From tbl_FinancialYearMaster Where DeptName = 'ACCOUNTS' And FinYrFrom <= '" & Format(Date.Now, "MM/dd/yyyy") & "' Order By DispOrder", M_dsFinYr)
    End Sub

    Private Sub FrmMDIMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dr As DialogResult
        dr = MsgBox("Sure To Exit ?", MsgBoxStyle.YesNo, "Sunrise Billing & Accounting Software")
        If dr = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmMDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'commit
        Me.WindowState = FormWindowState.Maximized
        loadFinYrMaster()

        If M_UserWiseCompanies = "" Then
            'EXISTING
            sql_query = "Select SettingValue From tbl_Settings Where SettingName = 'User Wise Company (True / False)'"
            If obj.ScalarExecute(sql_query) = "True" Then
                ComboFill(cmbCName, "Select CId, CName From Tbl_CompanyMaster Where CId In (Select CId From Tbl_UserMaster Where UserId = " & loggedUserId & ") Order By CName")
            Else
                ComboFill(cmbCName, "Select CId, CName From Tbl_CompanyMaster Order By CName")
            End If
        Else
            'UPDATED
            ComboFill(cmbCName, "Select CId, CName From Tbl_CompanyMaster Where CId In (" & M_UserWiseCompanies & ") Order By CName")
        End If


        ComboFill(cmbFinYr, "Select FinYrId, YrText From tbl_FinancialYearMaster Where DeptName = 'ACCOUNTS' And FinYrFrom <= '" & Format(Date.Now, "MM/dd/yyyy") & "' Order By DispOrder")

        cmbCName.SelectedIndex = 0
        cmbFinYr.SelectedIndex = 0

        If Val(M_LessDaysForFromYear) <> 0 Then
            M_YrStart = CDate(M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")).AddDays(M_LessDaysForFromYear)
        Else
            M_YrStart = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")
        End If
        M_YrEnd = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrTo")

        M_loadCompanyMaster()
        M_loadGloabalParameters(cmbCName.SelectedIndex)
        M_LoadSettings()
        loadLedgerMaster()
        loadUserRights()
        setBGIMG()

    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As System.Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        Panel1.Visible = False
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As System.Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            Panel1.Visible = True
        End If
    End Sub

    Private Sub BusinessProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusinessProfileToolStripMenuItem.Click
        FrmBusinessProfile.MdiParent = Me
        FrmBusinessProfile.Show()
        FrmBusinessProfile.Activate()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        FrmCustomerMaster.MdiParent = Me
        FrmCustomerMaster.Show()
        FrmCustomerMaster.Activate()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        FrmEmployeeMaster.MdiParent = Me
        FrmEmployeeMaster.Show()
        FrmEmployeeMaster.Activate()
    End Sub

    Private Sub BillingEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingEntryToolStripMenuItem.Click

    End Sub

    Private Sub PaymentCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentCollectionToolStripMenuItem.Click
        FrmPaymentCollection.MdiParent = Me
        FrmPaymentCollection.Show()
        FrmPaymentCollection.Activate()
    End Sub

    '
    'Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
    '    For Each child As Form In Me.MdiChildren
    '        If TypeOf child Is FrmCustomerMaster Then
    '            child.Activate()
    '            Return
    '        End If
    '    Next

    '    Dim frm As New FrmCustomerMaster()
    '    frm.MdiParent = Me
    '    frm.Show()
    'End Sub

#End Region

#Region "Financial Year Combo Box Events"

    Private Sub cmbFinYr_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFinYr.Enter, cmbCName.Enter
        _cmbFinYrIndx = cmbFinYr.SelectedIndex
        _CmbCNameIndx = cmbCName.SelectedIndex
        sender.DroppedDown = True
    End Sub

    Private Sub cmbFinYr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFinYr.SelectedIndexChanged, cmbCName.SelectedIndexChanged
        Try
            If Me.MdiChildren.Length = 0 Then
                If Val(M_LessDaysForFromYear) <> 0 Then
                    M_YrStart = CDate(M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")).AddDays(M_LessDaysForFromYear)
                Else
                    M_YrStart = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")
                End If

                'M_YrStart = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")
                M_YrEnd = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrTo")
                M_YrStartWH = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom_WH")
                M_Yr = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("YrSuffix")

                M_YrEndWH = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrTo_WH")

                M_StockYrId = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("StockYrId")
                M_StockYrStart = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("StockYrFrom")
                M_FinYrIndx = cmbFinYr.SelectedIndex

                M_loadGloabalParameters(cmbCName.SelectedIndex)
                M_LoadSettings()
                M_FYId = cmbFinYr.SelectedValue

                setBGIMG()
            Else
                Dim dr As DialogResult
                dr = MsgBox("Sure To Close forms ?", MsgBoxStyle.YesNo)
                If dr = Windows.Forms.DialogResult.Yes Then
                    For Each aform As Form In Me.MdiChildren
                        aform.Close()
                    Next

                    If Val(M_LessDaysForFromYear) <> 0 Then
                        M_YrStart = CDate(M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")).AddDays(M_LessDaysForFromYear)
                    Else
                        M_YrStart = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")
                    End If

                    'M_YrStart = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom")
                    M_YrEnd = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrTo")
                    M_YrStartWH = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrFrom_WH")
                    M_Yr = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("YrSuffix")

                    M_YrEndWH = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("FinYrTo_WH")

                    M_StockYrId = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("StockYrId")
                    M_StockYrStart = M_dsFinYr.Tables(0).Rows(cmbFinYr.SelectedIndex)("StockYrFrom")
                    M_FinYrIndx = cmbFinYr.SelectedIndex

                    M_loadGloabalParameters(cmbCName.SelectedIndex)
                    M_LoadSettings()
                    M_FYId = cmbFinYr.SelectedValue

                    setBGIMG()
                Else
                    cmbFinYr.SelectedIndex = _cmbFinYrIndx
                    cmbCName.SelectedIndex = _CmbCNameIndx

                    M_FinYrIndx = cmbFinYr.SelectedIndex
                    MsgBox("Please close opened forms !!", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If panelVisible = True Then
            panelVisible = False
            Panel1.Hide()
        Else
            Panel1.Show()
            panelVisible = True
        End If
    End Sub

    Private Sub OutstandingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutstandingReportToolStripMenuItem.Click
        FrmOutstandingReport.MdiParent = Me
        FrmOutstandingReport.Show()
        FrmOutstandingReport.Activate()
    End Sub

    Private Sub DAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAreaToolStripMenuItem.Click
        FrmAreaMaster.MdiParent = Me
        FrmAreaMaster.Show()
        FrmAreaMaster.Activate()
    End Sub

    Private Sub EMiscMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMiscMasterToolStripMenuItem.Click
        FrmMiscMaster.MdiParent = Me
        FrmMiscMaster.Show()
        FrmMiscMaster.Activate()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        FrmSettings.MdiParent = Me
        FrmSettings.Show()
        FrmSettings.Activate()
    End Sub

    Private Sub QuickSalesEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickSalesEntryToolStripMenuItem.Click
        FrmBillingEntry.MdiParent = Me
        FrmBillingEntry.Show()
        FrmBillingEntry.Activate()
    End Sub

    Private Sub GEmployeeMappingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GEmployeeMappingToolStripMenuItem.Click
        FrmEmployeeMapping.MdiParent = Me
        FrmEmployeeMapping.Show()
        FrmEmployeeMapping.Activate()
    End Sub

    Private Sub FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FCreditMasterToolStripMenuItem.Click

    End Sub

    Private Sub cmbFinYr_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbFinYr.Validating, cmbCName.Validating
        If sender.SelectedIndex = -1 Then
            Exit Sub
        End If
    End Sub

#End Region
End Class