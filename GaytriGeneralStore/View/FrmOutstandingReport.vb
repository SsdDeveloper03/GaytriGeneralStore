Imports System.Drawing.Printing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraSplashScreen
Imports GaytriGeneralStore.GaytriGeneral.DB
Imports Stimulsoft.Report

Public Class FrmOutstandingReport

#Region "Comments"
    'Name: Gayatry
    'Created By: Manav
    'Form: FrmOutstandingReport
    'Date: 12/12/2020
#End Region

#Region "Declare"
    Dim obj As New DBManager
    Dim ds As New DataSet
    Dim sql_query As String
#End Region

#Region "Methods"

    Private Sub GridFill()
        SplashScreenManager.ShowForm(GetType(WaitForm1))

        ds.Clear()
        Dim fromDate As String = Format(dtpFrom.Value.Date, "yyyy-MM-dd")
        Dim toDate As String = Format(dtpTo.Value.Date, "yyyy-MM-dd")

        sql_query = "SELECT * FROM View_Outstanding_Report_Gayatry 
            WHERE (ISNULL(DueAmt,0) > 0 OR ISNULL(DrAmt,0) > 0)
            AND CAST(InvoiceDate AS DATE) BETWEEN '" & fromDate & "' AND '" & toDate & "' "

        If Val(lkpCustomerName.EditValue) > 0 Then
            sql_query &= " AND LedgerId = " & Val(lkpCustomerName.EditValue)
        ElseIf Val(lkpArea.EditValue) > 0 Then
            sql_query &= " AND AreaId = " & Val(lkpArea.EditValue)
        End If

        sql_query &= " ORDER BY LedgerName, InvoiceDate"

        obj.LoadData(sql_query, ds)

        If Not ds.Tables(0).Columns.Contains("Balance") Then
            ds.Tables(0).Columns.Add("Balance", GetType(Decimal))
        End If
        If Not ds.Tables(0).Columns.Contains("Aging") Then
            ds.Tables(0).Columns.Add("Aging", GetType(String))
        End If
        If Not ds.Tables(0).Columns.Contains("DueDays") Then
            ds.Tables(0).Columns.Add("DueDays", GetType(Integer))
        End If

        Dim runningTotal As Decimal = 0
        Dim prevLedger As Integer = -1
        For Each row As DataRow In ds.Tables(0).Rows
            Dim ledger As Integer = Convert.ToInt32(row("LedgerId"))
            If ledger <> prevLedger Then
                runningTotal = 0
                prevLedger = ledger
            End If

            Dim billAmt As Decimal = If(IsDBNull(row("BillAmt")), 0, Convert.ToDecimal(row("BillAmt")))
            Dim receiveAmt As Decimal = If(IsDBNull(row("DrAmt")), 0, Convert.ToDecimal(row("DrAmt")))

            runningTotal += billAmt
            runningTotal -= receiveAmt
            row("Balance") = runningTotal

            Dim days As Integer = 0
            If Not IsDBNull(row("InvoiceDate")) Then
                Dim invDate As Date = Convert.ToDateTime(row("InvoiceDate"))
                days = DateDiff(DateInterval.Day, invDate.Date, Date.Now.Date)
            End If
            row("DueDays") = days

            Select Case days
                Case <= 30 : row("Aging") = "0-30 Days"
                Case <= 60 : row("Aging") = "31-60 Days"
                Case <= 90 : row("Aging") = "61-90 Days"
                Case Else : row("Aging") = "90+ Days"
            End Select
        Next

        gcData.DataSource = ds.Tables(0)
        RestoreLayout(gvData, "FrmOutstandingReport")

        ' Set column visibility and formatting
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
            col.OptionsColumn.AllowEdit = False
        Next

        gvData.OptionsView.ColumnAutoWidth = False
        gvData.OptionsView.EnableAppearanceEvenRow = True
        gvData.OptionsView.ShowAutoFilterRow = True
        gvData.BestFitColumns()

        ' Hide columns
        Dim hiddenCols As String() = {"LedgerId", "G_Id", "CId", "AreaId", "LedgerCode", "CustomerCode", "TS_Id", "SP1"}
        For Each colName In hiddenCols
            If gvData.Columns(colName) IsNot Nothing Then gvData.Columns(colName).Visible = False
        Next

        ' Captions
        gvData.Columns("DueDays").Caption = "Due Days"
        gvData.Columns("LedgerName").Caption = "Customer Name"
        gvData.Columns("AreaName").Caption = "Area"
        gvData.Columns("InvoiceNumber").Caption = "Bill No"
        gvData.Columns("InvoiceDate").Caption = "Bill Date"
        gvData.Columns("BillAmt").Caption = "Bill Amount"
        gvData.Columns("ReceivedAmt").Caption = "Received Amount"
        gvData.Columns("DueAmt").Caption = "Due Amount"
        gvData.Columns("Balance").Caption = "Running Balance"
        gvData.Columns("V_No").Caption = "Vou. No"
        gvData.Columns("VDate").Caption = "V_Date"
        gvData.Columns("Narration2").Caption = "Note"
        gvData.Columns("DrAmt").Caption = "Vou. Amount"

        ' Numeric formatting
        gvData.Columns("BillAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("BillAmt").DisplayFormat.FormatString = "N2"
        gvData.Columns("DueAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("DueAmt").DisplayFormat.FormatString = "N2"
        gvData.Columns("Balance").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("Balance").DisplayFormat.FormatString = "N2"
        gvData.Columns("DrAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("DrAmt").DisplayFormat.FormatString = "N2"

        ' Footers
        gvData.OptionsView.ShowFooter = True
        gvData.Columns("BillAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gvData.Columns("BillAmt").SummaryItem.DisplayFormat = "Total Bill : {0:N2}"
        gvData.Columns("DrAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gvData.Columns("DrAmt").SummaryItem.DisplayFormat = "Total Receive : {0:N2}"
        gvData.Columns("DueAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gvData.Columns("DueAmt").SummaryItem.DisplayFormat = "Total Due : {0:N2}"

        ' Grouping based on selected type
        gvData.ClearGrouping()
        Select Case cmbOutstandingType.EditValue
            Case "Customer Wise Outstanding"
                gvData.Columns("LedgerName").Group()
                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "DueAmt", gvData.Columns("DueAmt"), " {0:N2}")
                gvData.ExpandAllGroups()

            Case "Area Wise Outstanding"
                gvData.Columns("AreaName").GroupIndex = 0
                gvData.Columns("LedgerName").GroupIndex = 1
                gvData.Columns("InvoiceDate").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "BillAmt", gvData.Columns("BillAmt"), "Bill : {0:N2}")
                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "DrAmt", gvData.Columns("DrAmt"), "Receive : {0:N2}")
                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Balance", gvData.Columns("Balance"), "Balance : {0:N2}")
                gvData.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
                gvData.ExpandAllGroups()

            Case "Aging Wise Outstanding"
                gvData.Columns("Aging").Group()
                gvData.ExpandAllGroups()
        End Select

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub ComboFill_Customer(ByVal sql As String)
        Dim dsEmployee As New DataSet
        obj.LoadData(sql, dsEmployee)
        With lkpCustomerName.Properties
            .DataSource = dsEmployee.Tables(0)
            .ValueMember = "LedgerId"
            .DisplayMember = "LedgerName"
            .PopulateColumns()
            .Columns("LedgerName").Width = 350
            .Columns("MobileNo").Width = 120
            .PopupWidth = 700
            .Columns("LedgerId").Visible = False
        End With
    End Sub

    Public Sub ComboFill_Area(ByVal sql As String)
        Dim dsArea As New DataSet
        obj.LoadData(sql, dsArea)
        With lkpArea.Properties
            .DataSource = dsArea.Tables(0)
            .ValueMember = "AreaId"
            .DisplayMember = "AreaName"
            .PopulateColumns()
            .Columns("AreaName").Width = 350
            .PopupWidth = 700
            .Columns("AreaId").Visible = False
        End With
    End Sub

    Private Sub PreviewPrintableComponent(ByVal component As IPrintable, ByVal lookAndFeel As UserLookAndFeel, ByVal reportTitle As String)
        Dim pgHArea As New PageHeaderArea()
        pgHArea.Content.AddRange(New String() {M_CName, reportTitle, "From: " & dtpFrom.Value.ToString("dd-MM-yyyy") & "  To: " & dtpTo.Value.ToString("dd-MM-yyyy")})
        pgHArea.Font = New Font("Calibri", 12, FontStyle.Bold)

        Dim link As New PrintableComponentLink() With {
            .PrintingSystemBase = New PrintingSystem(),
            .Component = component,
            .Landscape = True,
            .PaperKind = PaperKind.A4,
            .Margins = New Margins(50, 50, 50, 50),
            .PageHeaderFooter = New PageHeaderFooter(pgHArea, Nothing)
        }
        link.ShowRibbonPreview(lookAndFeel)
    End Sub

    Public Sub prepareOutstandingDetail(ByVal _Filter As String, ByVal print As Boolean, ByVal rightClickCall As Boolean, ByVal tmpInvoiceCopyName As String)
        Dim stiRptV As New StiReport()
        stiRptV.Load(Strings.Left(Application.StartupPath, Len(Application.StartupPath) - 9) & "\Report\" & tmpInvoiceCopyName)
        stiRptV.Compile()

        For Each item As Stimulsoft.Report.Dictionary.StiSqlDatabase In stiRptV.CompiledReport.Dictionary.Databases
            item.ConnectionString = M_Stumul_ConnectionString
        Next

        ' Set report parameters
        stiRptV.Item("CName") = M_CName
        stiRptV.Item("CId") = " CId = " & M_CId
        stiRptV.Item("Fromdate") = dtpFrom.Value
        stiRptV.Item("Todate") = dtpTo.Value

        Select Case cmbOutstandingType.EditValue
            Case ""
                stiRptV.Item("Filter") = " '' = " & _Filter
            Case "Area Wise Outstanding"
                stiRptV.Item("Filter") = " AreaId = " & _Filter
            Case "Customer Wise Outstanding"
                stiRptV.Item("Filter") = " LedgerId = " & _Filter
        End Select

        stiRptV.Render(False)
        stiRptV.Dictionary.Synchronize()

        Dim frmRpt As New FrmReportViewer_Stimul("", Nothing, "", print)
        frmRpt.StiViwerControl.Report = stiRptV
        frmRpt.StiViwerControl.Refresh()
        frmRpt.MdiParent = FrmMDIMain

        If print Then
            stiRptV.Print(True)
        Else
            frmRpt.Show()
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub gvData_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvData.RowStyle
        If e.RowHandle < 0 Then Exit Sub
        Dim days As Integer = 0
        If gvData.GetRowCellValue(e.RowHandle, "DueDays") IsNot DBNull.Value Then
            days = Convert.ToInt32(gvData.GetRowCellValue(e.RowHandle, "DueDays"))
        End If
        If days > 30 Then
            e.Appearance.ForeColor = Color.Red
            e.Appearance.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        End If
    End Sub

    Private Sub FrmOutstandingReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = M_YrStart
        dtpTo.Value = M_YrEnd

        Dim dt As New DataTable
        dt.Columns.Add("RptType")
        dt.Rows.Add("Outstanding Detail")
        dt.Rows.Add("Customer Wise Outstanding")
        dt.Rows.Add("Area Wise Outstanding")
        dt.Rows.Add("Aging Wise Outstanding")

        cmbOutstandingType.Properties.DataSource = dt
        cmbOutstandingType.Properties.DisplayMember = "RptType"
        cmbOutstandingType.Properties.ValueMember = "RptType"

        ComboFill_Customer("Select LedgerId, LedgerName, MobileNo from tbl_LedgerMaster where G_Id = 11 Order by LedgerName")
        ComboFill_Area("Select AreaId, AreaName from tbl_AreaMaster Order by AreaName")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GridFill()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        MultiFileExportToExcel()
    End Sub

    Public Sub MultiFileExportToExcel()
        Using saveDialog = New SaveFileDialog()
            saveDialog.Filter = "Excel (.xlsx)|*.xlsx"
            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim printingSystem = New PrintingSystemBase()
                Dim compositeLink = New CompositeLinkBase()
                compositeLink.PrintingSystemBase = printingSystem

                Dim link1 = New PrintableComponentLinkBase()
                link1.Component = gcData
                compositeLink.Links.Add(link1)

                Dim options = New XlsxExportOptions()
                options.ExportMode = XlsxExportMode.SingleFilePageByPage
                compositeLink.CreatePageForEachLink()
                compositeLink.ExportToXlsx(saveDialog.FileName, options)
            End If
        End Using
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If gvData.SelectedRowsCount = 1 Then
            ' Generate detailed report for the selected row (Customer or Area)
            Dim selectedRow = gvData.GetFocusedRow()
            Dim filterValue As String = ""
            Dim reportFile As String = "Outstanding_Report.mrt"

            Select Case cmbOutstandingType.EditValue
                Case "Customer Wise Outstanding"
                    filterValue = selectedRow("LedgerId").ToString()
                Case "Area Wise Outstanding"
                    filterValue = selectedRow("AreaId").ToString()
                Case Else
                    filterValue = selectedRow("LedgerId").ToString()  ' fallback
            End Select

            prepareOutstandingDetail(filterValue, False, False, reportFile)
        Else
            ' Show grid preview
            Dim title As String = "Outstanding Report - " & cmbOutstandingType.EditValue
            PreviewPrintableComponent(gcData, gcData.LookAndFeel, title)
        End If
    End Sub

    ' Context Menu Handlers
    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
        gvData.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvData.FocusedColumn.FieldName)
    End Sub

    'Private Sub GroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem.Click
    '    gvData.Columns(gvData.FocusedColumn.FieldName).Group()
    '    gvData.ExpandAllGroups()
    'End Sub

    'Private Sub UngroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UngroupToolStripMenuItem.Click
    '    gvData.Columns(gvData.FocusedColumn.FieldName).UnGroup()
    'End Sub

    'Private Sub SumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumToolStripMenuItem.Click
    '    gvData.Columns(gvData.FocusedColumn.FieldName).Summary.Add(DevExpress.Data.SummaryItemType.Sum, gvData.FocusedColumn.FieldName, "{0}")
    'End Sub

    'Private Sub CountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountToolStripMenuItem.Click
    '    gvData.Columns(gvData.FocusedColumn.FieldName).Summary.Add(DevExpress.Data.SummaryItemType.Count, gvData.FocusedColumn.FieldName, "{0}")
    'End Sub

    'Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
    '    gvData.Columns(gvData.FocusedColumn.FieldName).Summary.Remove(gvData.Columns(gvData.FocusedColumn.FieldName).SummaryItem)
    'End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        Dim fileName As String = "FrmOutstandingReport"
        If M_UserWiseInvoicePrefix = "YES" Then
            fileName &= loggedUser & ".xml"
        Else
            fileName &= ".xml"
        End If
        If IO.File.Exists(Application.StartupPath & "\" & fileName) Then
            IO.File.Delete(Application.StartupPath & "\" & fileName)
        End If
        SaveLayout(gvData, fileName, Me)
        MessageBox.Show("Layout Saved", "Outstanding Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        MultiFileExportToExcel()
    End Sub

    Private Sub gcData_MouseDown(sender As Object, e As MouseEventArgs) Handles gcData.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(gcData, e.Location)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

End Class