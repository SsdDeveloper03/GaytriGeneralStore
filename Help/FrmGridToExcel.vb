Imports DevExpress.XtraCharts
Imports Excel
Imports GaytriGeneralStore.GaytriGeneral.DB
Imports Range = Excel.Range

Public Class FrmGridToExcel

#Region "Comments"
    'Name:TailoringERP
    'Created By:Manav
    'Form:FrmUploadToExcel
    'Date:20/05/2024
#End Region

#Region "Declaration"
    Dim ds As New Data.DataSet
    Dim dsCmb As New Data.DataSet
    Dim obj As New DBManager
    Dim sql_query As String
    Dim edit_ins As Integer = -1
    Dim uploadtype As String
#End Region

#Region "Event"
    Private Sub FrmUploadToExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Filter = "Excel-2007 Files|*.xlsx|Excel-2003 Files|*.xls"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim excelApp As New Application()
        Dim workbook As Workbook = excelApp.Workbooks.Open(OpenFileDialog1.FileName)
        Dim worksheet As Worksheet = workbook.Sheets(1)
        Dim range As Range = worksheet.UsedRange

        grdData.Rows.Clear()
        grdData.Columns.Clear()

        For col As Integer = 1 To range.Columns.Count
            Dim values1 As New List(Of Object)()
            values1.Add(range.Cells(1, col).value)
            If values1(0).ToString = "" Then
                Exit For
                Exit Sub
            End If
            grdData.Columns.Add(values1(0).ToString(), values1(0).ToString())
        Next

        For row As Integer = 2 To range.Rows.Count - 1 + 1
            Dim values As New List(Of Object)()
            Dim isRowEmpty As Boolean = True
            For col As Integer = 1 To range.Columns.Count
                Dim cellValue As Object = Trim(range.Cells(row, col).Value)
                values.Add(cellValue)
                If isRowEmpty = True Then
                    isRowEmpty = True
                End If
                If cellValue IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cellValue.ToString()) Then
                    isRowEmpty = False
                End If
            Next
            If isRowEmpty = False Then
                grdData.Rows.Add(values.ToArray())
            Else
                'grdData.Rows.Add(values.ToArray())
                Exit For
            End If
        Next
        lblTotalRecords.Text = "Total Records : " & Val(grdData.RowCount)
        workbook.Close(False)
        excelApp.Quit()
        OpenFileDialog1.Reset()
    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    Select Case M_GridToExcel
    '        Case "UploadPurchaseData"
    '            FrmPurchase_WfsNew.UploadPurchaseData()
    '            Me.Close()
    '            Exit Select
    '        Case "UploadFabricItem"
    '            FrmSalesItemMaster.UploadItemData()
    '            Me.Close()
    '            Exit Select
    '        Case Else
    '            Exit Select
    '    End Select

    'End Sub

#End Region

End Class