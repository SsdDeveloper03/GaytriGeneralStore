Imports System.Drawing.Printing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmOutstandingReport

#Region "Declare"
    Dim obj As New DBManager
    Dim ds As New DataSet
    Dim sql_query As String

#End Region

#Region "Methods"

    Private Sub GridFill()

        ds.Clear()

        If lkpCustomerName.EditValue Is Nothing Or lkpCustomerName.EditValue = "" Then

            sql_query = "SELECT *, DATEDIFF(DAY, InvoiceDate, GETDATE()) AS DueDays
                     FROM View_Outstanding_Report_Gayatry
                     WHERE (DueAmt > 0 OR DrAmt > 0) AND CAST(InvoiceDate AS DATE) BETWEEN '" &
                     Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' AND '" &
                     Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'
                     ORDER BY LedgerName, InvoiceDate"

        Else

            sql_query = "SELECT *, DATEDIFF(DAY, InvoiceDate, GETDATE()) AS DueDays
                     FROM View_Outstanding_Report_Gayatry 
                     WHERE (DueAmt > 0 OR DrAmt > 0)
                     AND LedgerId = " & Val(lkpCustomerName.EditValue) & "
                     AND CAST(InvoiceDate AS DATE) BETWEEN '" &
                     Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' AND '" &
                     Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'
                     ORDER BY LedgerName, InvoiceDate"

        End If

        obj.LoadData(sql_query, ds)

        If Not ds.Tables(0).Columns.Contains("Balance") Then
            ds.Tables(0).Columns.Add("Balance", GetType(Decimal))
        End If

        If Not ds.Tables(0).Columns.Contains("Aging") Then
            ds.Tables(0).Columns.Add("Aging", GetType(String))
        End If


        Dim runningTotal As Decimal = 0
        Dim prevLedger As Integer = -1

        For Each row As DataRow In ds.Tables(0).Rows

            Dim ledger As Integer = Convert.ToInt32(row("LedgerId"))
            Dim billAmt As Decimal = 0
            Dim receiveAmt As Decimal = 0

            If ledger <> prevLedger Then
                runningTotal = 0
                prevLedger = ledger
            End If

            If row("BillAmt") IsNot DBNull.Value Then
                billAmt = Convert.ToDecimal(row("BillAmt"))
            End If

            If row("DrAmt") IsNot DBNull.Value Then
                receiveAmt = Convert.ToDecimal(row("DrAmt"))
            End If


            runningTotal += billAmt
            runningTotal -= receiveAmt
            row("Balance") = runningTotal


            Dim days As Integer = Convert.ToInt32(row("DueDays"))

            If days <= 30 Then
                row("Aging") = "0-30 Days"

            ElseIf days <= 60 Then
                row("Aging") = "31-60 Days"

            ElseIf days <= 90 Then
                row("Aging") = "61-90 Days"

            Else
                row("Aging") = "90+ Days"
            End If

        Next

        gcData.DataSource = ds.Tables(0)

        RestoreLayout(gvData, "FrmOutstandingReport")

        gvData.OptionsView.ColumnAutoWidth = False
        gvData.OptionsView.EnableAppearanceEvenRow = True
        gvData.OptionsView.ShowAutoFilterRow = True
        gvData.BestFitColumns()

        gvData.Columns("LedgerId").Visible = False
        gvData.Columns("G_Id").Visible = False
        gvData.Columns("CId").Visible = False
        gvData.Columns("AreaId").Visible = False
        gvData.Columns("LedgerCode").Visible = False
        gvData.Columns("CustomerCode").Visible = False
        gvData.Columns("TS_Id").Visible = False
        gvData.Columns("SP1").Visible = False


        gvData.Columns("LedgerName").Caption = "Customer Name"
        gvData.Columns("AreaName").Caption = "Area"
        gvData.Columns("InvoiceNumber").Caption = "Bill No"
        gvData.Columns("InvoiceDate").Caption = "Bill Date"
        gvData.Columns("BillAmt").Caption = "Bill Amount"
        gvData.Columns("ReceivedAmt").Caption = "Received Amount"
        gvData.Columns("DueAmt").Caption = "Due Amount"
        gvData.Columns("Balance").Caption = "Running Balance"
        gvData.Columns("DueDays").Caption = "Days"

        gvData.Columns("V_No").Caption = "Vou. No"
        gvData.Columns("VDate").Caption = "V_Date"
        gvData.Columns("Narration2").Caption = "Note"
        gvData.Columns("DrAmt").Caption = "Vou. Amount"


        gvData.Columns("BillAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("BillAmt").DisplayFormat.FormatString = "N2"

        gvData.Columns("DueAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("DueAmt").DisplayFormat.FormatString = "N2"

        gvData.Columns("Balance").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("Balance").DisplayFormat.FormatString = "N2"

        gvData.Columns("DrAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvData.Columns("DrAmt").DisplayFormat.FormatString = "N2"


        gvData.OptionsView.ShowFooter = True

        gvData.Columns("BillAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gvData.Columns("BillAmt").SummaryItem.DisplayFormat = "Total Bill : {0:N2}"

        gvData.Columns("DrAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gvData.Columns("DrAmt").SummaryItem.DisplayFormat = "Total Receive : {0:N2}"

        gvData.Columns("DueAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gvData.Columns("DueAmt").SummaryItem.DisplayFormat = "Total Due : {0:N2}"


        gvData.ClearGrouping()

        Select Case cmbOutstandingType.EditValue

            Case "Customer Wise Outstanding"

                gvData.Columns("LedgerName").Group()
                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "DueAmt", gvData.Columns("DueAmt"), " {0:N2}")
                gvData.ExpandAllGroups()

            Case "Area Wise Outstanding"

                gvData.Columns("AreaName").Group()
                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "DueAmt", gvData.Columns("DueAmt"), " {0:N2}")
                gvData.ExpandAllGroups()

            Case "Aging Wise Outstanding"

                gvData.Columns("Aging").Group()
                gvData.ExpandAllGroups()

        End Select

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

        GridFill()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GridFill()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim sfd As New SaveFileDialog

        If sfd.ShowDialog() = DialogResult.OK Then
            gvData.ExportToXlsx(sfd.FileName & ".xlsx")
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim title As String = "Outstanding Report"

        Dim dateRange As String = "From: " & dtpFrom.Value.ToString("dd-MM-yyyy") &
                              "  To: " & dtpTo.Value.ToString("dd-MM-yyyy")

        Dim pgHArea As New PageHeaderArea()

        pgHArea.Content.AddRange(New String() {"Gaytri General Store", title, dateRange})

        pgHArea.Font = New Font("Calibri", 12, FontStyle.Bold)

        Dim link As New PrintableComponentLink() With {
        .PrintingSystemBase = New PrintingSystem(),
        .Component = gcData,
        .Landscape = True,
        .PaperKind = PaperKind.A4,
        .Margins = New Margins(50, 50, 50, 50),
        .PageHeaderFooter = New PageHeaderFooter(pgHArea, Nothing)
        }

        link.ShowRibbonPreview(gcData.LookAndFeel)

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
        SaveLayout(gvData, "FrmOutstandingReport", Me)
    End Sub

    Private Sub gcData_MouseDown(sender As Object, e As MouseEventArgs) Handles gcData.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(gcData, e.Location)
        End If
    End Sub

#End Region

End Class

'Imports System.Drawing.Printing
'Imports DevExpress.LookAndFeel
'Imports DevExpress.XtraPrinting
'Imports DevExpress.XtraPrintingLinks
'Imports GaytriGeneralStore.GaytriGeneral.DB

'Public Class FrmOutstandingReport

'#Region "Declare"
'    Dim obj As New DBManager
'    Dim ds As New DataSet
'    Dim sql_query As String
'#End Region

'#Region "Methods"

'    Private Sub GridFill()

'        ds.Clear()

'        If lkpCustomerName.EditValue Is Nothing Or lkpCustomerName.EditValue = "" Then

'            sql_query = "SELECT *, DATEDIFF(DAY, InvoiceDate, GETDATE()) AS DueDays
'                         FROM View_Outstanding_Report_Gayatry
'                         WHERE DueAmt > 0 AND CAST(InvoiceDate AS DATE) BETWEEN '" &
'                         Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' AND '" &
'                         Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'
'                         ORDER BY LedgerName, InvoiceDate"

'        Else

'            sql_query = "SELECT *, DATEDIFF(DAY, InvoiceDate, GETDATE()) AS DueDays
'                         FROM View_Outstanding_Report_Gayatry 
'                         WHERE DueAmt > 0
'                         AND LedgerId = " & Val(lkpCustomerName.EditValue) & " AND CAST(InvoiceDate AS DATE) BETWEEN '" &
'                         Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' AND '" &
'                         Format(dtpTo.Value.Date, "yyyy-MM-dd") & "'
'                         ORDER BY LedgerName, InvoiceDate"

'        End If


'        obj.LoadData(sql_query, ds)

'        If Not ds.Tables(0).Columns.Contains("Balance") Then
'            ds.Tables(0).Columns.Add("Balance", GetType(Decimal))
'        End If

'        If Not ds.Tables(0).Columns.Contains("Aging") Then
'            ds.Tables(0).Columns.Add("Aging", GetType(String))
'        End If

'        Dim runningTotal As Decimal = 0
'        Dim prevLedger As Integer = -1

'        For Each row As DataRow In ds.Tables(0).Rows

'            Dim ledger As Integer = Convert.ToInt32(row("LedgerId"))

'            If ledger <> prevLedger Then
'                runningTotal = 0
'                prevLedger = ledger
'            End If

'            runningTotal += Convert.ToDecimal(row("DueAmt"))
'            row("Balance") = runningTotal

'            Dim days As Integer = Convert.ToInt32(row("DueDays"))

'            If days <= 30 Then
'                row("Aging") = "0-30 Days"

'            ElseIf days <= 60 Then
'                row("Aging") = "31-60 Days"

'            ElseIf days <= 90 Then
'                row("Aging") = "61-90 Days"

'            Else
'                row("Aging") = "90+ Days"
'            End If

'        Next

'        gcData.DataSource = ds.Tables(0)

'        RestoreLayout(gvData, "FrmSalesReport")

'        gvData.OptionsView.ColumnAutoWidth = False
'        gvData.OptionsView.EnableAppearanceEvenRow = True
'        gvData.OptionsView.ShowAutoFilterRow = True
'        gvData.BestFitColumns()


'        gvData.Columns("LedgerId").Visible = False
'        gvData.Columns("G_Id").Visible = False
'        gvData.Columns("CId").Visible = False
'        gvData.Columns("AreaId").Visible = False
'        gvData.Columns("LedgerCode").Visible = False
'        gvData.Columns("CustType").Visible = False
'        gvData.Columns("CustomerCode").Visible = False
'        gvData.Columns("TS_Id").Visible = False
'        gvData.Columns("SP1").Visible = False


'        gvData.Columns("LedgerName").Caption = "Customer Name"
'        gvData.Columns("AreaName").Caption = "Area"
'        gvData.Columns("InvoiceNumber").Caption = "Bill No"
'        gvData.Columns("InvoiceDate").Caption = "Bill Date"
'        gvData.Columns("BillAmt").Caption = "Bill Amount"
'        gvData.Columns("ReceivedAmt").Caption = "Received Amount"
'        gvData.Columns("DueAmt").Caption = "Due Amount"
'        gvData.Columns("Balance").Caption = "Running Balance"
'        gvData.Columns("DueDays").Caption = "Days"
'        gvData.Columns("V_No").Caption = "Vou. No"
'        gvData.Columns("VDate").Caption = "V_Date"
'        gvData.Columns("Narration2").Caption = "Note"
'        gvData.Columns("DrAmt").Caption = "Vou. Amount"



'        gvData.Columns("BillAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
'        gvData.Columns("BillAmt").DisplayFormat.FormatString = "N2"

'        gvData.Columns("DueAmt").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
'        gvData.Columns("DueAmt").DisplayFormat.FormatString = "N2"

'        gvData.Columns("Balance").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
'        gvData.Columns("Balance").DisplayFormat.FormatString = "N2"


'        gvData.OptionsView.ShowFooter = True

'        gvData.Columns("BillAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
'        gvData.Columns("BillAmt").SummaryItem.DisplayFormat = " {0:N2}"

'        gvData.Columns("DueAmt").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
'        gvData.Columns("DueAmt").SummaryItem.DisplayFormat = " {0:N2}"


'        gvData.ClearGrouping()

'        Select Case cmbOutstandingType.EditValue

'            Case "Customer Wise Outstanding"

'                gvData.Columns("LedgerName").Group()
'                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "DueAmt", gvData.Columns("DueAmt"), " {0:N2}")
'                gvData.ExpandAllGroups()


'            Case "Area Wise Outstanding"

'                gvData.Columns("AreaName").Group()
'                gvData.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "DueAmt", gvData.Columns("DueAmt"), " {0:N2}")
'                gvData.ExpandAllGroups()


'            Case "Aging Wise Outstanding"

'                gvData.Columns("Aging").Group()
'                gvData.ExpandAllGroups()

'        End Select

'    End Sub

'#End Region

'#Region "Events"

'    Private Sub gvData_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvData.RowStyle

'        If e.RowHandle < 0 Then Exit Sub

'        Dim days As Integer = 0

'        If gvData.GetRowCellValue(e.RowHandle, "DueDays") IsNot DBNull.Value Then
'            days = Convert.ToInt32(gvData.GetRowCellValue(e.RowHandle, "DueDays"))
'        End If

'        If days > 30 Then
'            e.Appearance.ForeColor = Color.Red
'            e.Appearance.Font = New Font("Segoe UI", 9, FontStyle.Bold)
'        End If

'    End Sub

'    Private Sub FrmOutstandingReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        dtpFrom.Value = M_YrStart
'        dtpTo.Value = M_YrEnd

'        Dim dt As New DataTable
'        dt.Columns.Add("RptType")

'        dt.Rows.Add("Outstanding Detail")
'        dt.Rows.Add("Customer Wise Outstanding")
'        dt.Rows.Add("Area Wise Outstanding")
'        dt.Rows.Add("Aging Wise Outstanding")

'        cmbOutstandingType.Properties.DataSource = dt
'        cmbOutstandingType.Properties.DisplayMember = "RptType"
'        cmbOutstandingType.Properties.ValueMember = "RptType"

'        GridFill()

'    End Sub

'    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
'        GridFill()
'    End Sub

'    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

'        Dim sfd As New SaveFileDialog

'        If sfd.ShowDialog() = DialogResult.OK Then
'            gvData.ExportToXlsx(sfd.FileName & ".xlsx")
'        End If

'    End Sub

'    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

'        Dim title As String = "Outstanding Report"

'        Dim dateRange As String = "From: " & dtpFrom.Value.ToString("dd-MM-yyyy") & "  To: " & dtpTo.Value.ToString("dd-MM-yyyy")


'        Dim pgHArea As New PageHeaderArea()

'        pgHArea.Content.AddRange(New String() {"Gaytri General Store", title, dateRange})

'        pgHArea.Font = New Font("Calibri", 12, FontStyle.Bold)

'        Dim link As New PrintableComponentLink() With {
'        .PrintingSystemBase = New PrintingSystem(),
'        .Component = gcData,
'        .Landscape = True,
'        .PaperKind = PaperKind.A4,
'        .Margins = New Margins(50, 50, 50, 50),
'        .PageHeaderFooter = New PageHeaderFooter(pgHArea, Nothing)
'        }

'        link.ShowRibbonPreview(gcData.LookAndFeel)

'    End Sub

'    Private Sub RenameColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameColumnToolStripMenuItem.Click
'        gvData.FocusedColumn.Caption = InputBox("Column Header Text", "Field Name", gvData.FocusedColumn.FieldName)
'    End Sub

'    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
'        Dim sfd As New SaveFileDialog

'        If sfd.ShowDialog() = DialogResult.OK Then
'            gvData.ExportToXlsx(sfd.FileName & ".xlsx")
'        End If
'    End Sub

'    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
'        SaveLayout(gvData, "FrmOutstandingReport", Me)
'    End Sub

'    Private Sub gcData_MouseDown(sender As Object, e As MouseEventArgs) Handles gcData.MouseDown
'        If e.Button = MouseButtons.Right Then
'            ContextMenuStrip1.Show(gcData, e.Location)
'        End If
'    End Sub

'#End Region

'End Class