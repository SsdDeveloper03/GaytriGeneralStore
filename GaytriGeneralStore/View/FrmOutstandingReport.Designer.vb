'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
'Partial Class FrmOutstandingReport
'    Inherits System.Windows.Forms.Form

'    'Form overrides dispose to clean up the component list.
'    <System.Diagnostics.DebuggerNonUserCode()>
'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    <System.Diagnostics.DebuggerStepThrough()>
'    Private Sub InitializeComponent()
'        Me.lblReportType = New System.Windows.Forms.Label()
'        Me.cmbOutstandingType = New DevExpress.XtraEditors.SearchLookUpEdit()
'        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
'        Me.lblFromDtp = New System.Windows.Forms.Label()
'        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
'        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
'        Me.lblTo = New System.Windows.Forms.Label()
'        Me.btnExport = New System.Windows.Forms.Button()
'        Me.btnPrint = New System.Windows.Forms.Button()
'        Me.btnExit = New System.Windows.Forms.Button()
'        Me.btnRefresh = New System.Windows.Forms.Button()
'        Me.gcData = New DevExpress.XtraGrid.GridControl()
'        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
'        Me.lkpCustomerName = New DevExpress.XtraEditors.SearchLookUpEdit()
'        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
'        Me.lblCutomerName = New System.Windows.Forms.Label()
'        CType(Me.cmbOutstandingType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.lkpCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'lblReportType
'        '
'        Me.lblReportType.AutoSize = True
'        Me.lblReportType.BackColor = System.Drawing.SystemColors.Control
'        Me.lblReportType.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblReportType.Location = New System.Drawing.Point(13, 13)
'        Me.lblReportType.Name = "lblReportType"
'        Me.lblReportType.Size = New System.Drawing.Size(102, 23)
'        Me.lblReportType.TabIndex = 0
'        Me.lblReportType.Text = "Report Type"
'        '
'        'cmbOutstandingType
'        '
'        Me.cmbOutstandingType.EditValue = ""
'        Me.cmbOutstandingType.EnterMoveNextControl = True
'        Me.cmbOutstandingType.Location = New System.Drawing.Point(118, 8)
'        Me.cmbOutstandingType.Margin = New System.Windows.Forms.Padding(4)
'        Me.cmbOutstandingType.Name = "cmbOutstandingType"
'        Me.cmbOutstandingType.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.cmbOutstandingType.Properties.Appearance.Options.UseFont = True
'        Me.cmbOutstandingType.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
'        Me.cmbOutstandingType.Properties.AppearanceDropDown.Options.UseFont = True
'        Me.cmbOutstandingType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
'        Me.cmbOutstandingType.Properties.LookAndFeel.SkinName = "Office 2013"
'        Me.cmbOutstandingType.Properties.LookAndFeel.UseDefaultLookAndFeel = False
'        Me.cmbOutstandingType.Properties.NullText = ""
'        Me.cmbOutstandingType.Properties.PopupFormSize = New System.Drawing.Size(0, 300)
'        Me.cmbOutstandingType.Properties.ValidateOnEnterKey = True
'        Me.cmbOutstandingType.Properties.View = Me.GridView1
'        Me.cmbOutstandingType.Size = New System.Drawing.Size(338, 28)
'        Me.cmbOutstandingType.TabIndex = 1
'        '
'        'GridView1
'        '
'        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
'        Me.GridView1.Name = "GridView1"
'        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
'        Me.GridView1.OptionsView.ShowGroupPanel = False
'        '
'        'lblFromDtp
'        '
'        Me.lblFromDtp.AutoSize = True
'        Me.lblFromDtp.BackColor = System.Drawing.SystemColors.Control
'        Me.lblFromDtp.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblFromDtp.Location = New System.Drawing.Point(463, 12)
'        Me.lblFromDtp.Name = "lblFromDtp"
'        Me.lblFromDtp.Size = New System.Drawing.Size(51, 23)
'        Me.lblFromDtp.TabIndex = 2
'        Me.lblFromDtp.Text = "From"
'        '
'        'dtpFrom
'        '
'        Me.dtpFrom.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
'        Me.dtpFrom.Location = New System.Drawing.Point(520, 8)
'        Me.dtpFrom.Name = "dtpFrom"
'        Me.dtpFrom.Size = New System.Drawing.Size(120, 29)
'        Me.dtpFrom.TabIndex = 3
'        '
'        'dtpTo
'        '
'        Me.dtpTo.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
'        Me.dtpTo.Location = New System.Drawing.Point(679, 8)
'        Me.dtpTo.Name = "dtpTo"
'        Me.dtpTo.Size = New System.Drawing.Size(120, 29)
'        Me.dtpTo.TabIndex = 5
'        '
'        'lblTo
'        '
'        Me.lblTo.AutoSize = True
'        Me.lblTo.BackColor = System.Drawing.SystemColors.Control
'        Me.lblTo.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblTo.Location = New System.Drawing.Point(646, 13)
'        Me.lblTo.Name = "lblTo"
'        Me.lblTo.Size = New System.Drawing.Size(27, 23)
'        Me.lblTo.TabIndex = 4
'        Me.lblTo.Text = "To"
'        '
'        'btnExport
'        '
'        Me.btnExport.BackColor = System.Drawing.Color.Khaki
'        Me.btnExport.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnExport.Location = New System.Drawing.Point(1314, 4)
'        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
'        Me.btnExport.Name = "btnExport"
'        Me.btnExport.Size = New System.Drawing.Size(100, 36)
'        Me.btnExport.TabIndex = 8
'        Me.btnExport.Text = "&Export"
'        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'        Me.btnExport.UseVisualStyleBackColor = False
'        '
'        'btnPrint
'        '
'        Me.btnPrint.BackColor = System.Drawing.Color.PaleGoldenrod
'        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnPrint.Location = New System.Drawing.Point(1422, 4)
'        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
'        Me.btnPrint.Name = "btnPrint"
'        Me.btnPrint.Size = New System.Drawing.Size(105, 36)
'        Me.btnPrint.TabIndex = 9
'        Me.btnPrint.Text = "&Print"
'        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'        Me.btnPrint.UseVisualStyleBackColor = False
'        '
'        'btnExit
'        '
'        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
'        Me.btnExit.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnExit.Location = New System.Drawing.Point(1535, 4)
'        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
'        Me.btnExit.Name = "btnExit"
'        Me.btnExit.Size = New System.Drawing.Size(96, 36)
'        Me.btnExit.TabIndex = 10
'        Me.btnExit.Text = "Cl&ose"
'        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'        Me.btnExit.UseVisualStyleBackColor = False
'        '
'        'btnRefresh
'        '
'        Me.btnRefresh.BackColor = System.Drawing.Color.LawnGreen
'        Me.btnRefresh.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.btnRefresh.Location = New System.Drawing.Point(1201, 4)
'        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
'        Me.btnRefresh.Name = "btnRefresh"
'        Me.btnRefresh.Size = New System.Drawing.Size(105, 36)
'        Me.btnRefresh.TabIndex = 7
'        Me.btnRefresh.Text = "Re&fresh"
'        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'        Me.btnRefresh.UseVisualStyleBackColor = False
'        '
'        'gcData
'        '
'        Me.gcData.Location = New System.Drawing.Point(8, 47)
'        Me.gcData.MainView = Me.gvData
'        Me.gcData.Name = "gcData"
'        Me.gcData.Size = New System.Drawing.Size(1623, 733)
'        Me.gcData.TabIndex = 11
'        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
'        '
'        'gvData
'        '
'        Me.gvData.GridControl = Me.gcData
'        Me.gvData.Name = "gvData"
'        Me.gvData.OptionsView.ShowGroupPanel = False
'        '
'        'lkpCustomerName
'        '
'        Me.lkpCustomerName.EditValue = ""
'        Me.lkpCustomerName.EnterMoveNextControl = True
'        Me.lkpCustomerName.Location = New System.Drawing.Point(946, 8)
'        Me.lkpCustomerName.Margin = New System.Windows.Forms.Padding(4)
'        Me.lkpCustomerName.Name = "lkpCustomerName"
'        Me.lkpCustomerName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lkpCustomerName.Properties.Appearance.Options.UseFont = True
'        Me.lkpCustomerName.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
'        Me.lkpCustomerName.Properties.AppearanceDropDown.Options.UseFont = True
'        Me.lkpCustomerName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
'        Me.lkpCustomerName.Properties.LookAndFeel.SkinName = "Office 2013"
'        Me.lkpCustomerName.Properties.LookAndFeel.UseDefaultLookAndFeel = False
'        Me.lkpCustomerName.Properties.NullText = ""
'        Me.lkpCustomerName.Properties.PopupFormSize = New System.Drawing.Size(0, 300)
'        Me.lkpCustomerName.Properties.ValidateOnEnterKey = True
'        Me.lkpCustomerName.Properties.View = Me.GridView2
'        Me.lkpCustomerName.Size = New System.Drawing.Size(247, 28)
'        Me.lkpCustomerName.TabIndex = 12
'        '
'        'GridView2
'        '
'        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
'        Me.GridView2.Name = "GridView2"
'        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
'        Me.GridView2.OptionsView.ShowGroupPanel = False
'        '
'        'lblCutomerName
'        '
'        Me.lblCutomerName.AutoSize = True
'        Me.lblCutomerName.BackColor = System.Drawing.SystemColors.Control
'        Me.lblCutomerName.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblCutomerName.Location = New System.Drawing.Point(805, 12)
'        Me.lblCutomerName.Name = "lblCutomerName"
'        Me.lblCutomerName.Size = New System.Drawing.Size(134, 23)
'        Me.lblCutomerName.TabIndex = 13
'        Me.lblCutomerName.Text = "Customer Name"
'        '
'        'FrmOutstandingReport
'        '
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.ClientSize = New System.Drawing.Size(1644, 788)
'        Me.Controls.Add(Me.lblCutomerName)
'        Me.Controls.Add(Me.lkpCustomerName)
'        Me.Controls.Add(Me.gcData)
'        Me.Controls.Add(Me.btnExport)
'        Me.Controls.Add(Me.btnPrint)
'        Me.Controls.Add(Me.btnExit)
'        Me.Controls.Add(Me.btnRefresh)
'        Me.Controls.Add(Me.dtpTo)
'        Me.Controls.Add(Me.lblTo)
'        Me.Controls.Add(Me.dtpFrom)
'        Me.Controls.Add(Me.lblFromDtp)
'        Me.Controls.Add(Me.cmbOutstandingType)
'        Me.Controls.Add(Me.lblReportType)
'        Me.Name = "FrmOutstandingReport"
'        Me.Text = "Outstanding Report"
'        CType(Me.cmbOutstandingType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.lkpCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub

'    Friend WithEvents lblReportType As Label
'    Friend WithEvents cmbOutstandingType As DevExpress.XtraEditors.SearchLookUpEdit
'    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
'    Friend WithEvents lblFromDtp As Label
'    Friend WithEvents dtpFrom As DateTimePicker
'    Friend WithEvents dtpTo As DateTimePicker
'    Friend WithEvents lblTo As Label
'    Friend WithEvents btnExport As Button
'    Friend WithEvents btnPrint As Button
'    Friend WithEvents btnExit As Button
'    Friend WithEvents btnRefresh As Button
'    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
'    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
'    Friend WithEvents lkpCustomerName As DevExpress.XtraEditors.SearchLookUpEdit
'    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
'    Friend WithEvents lblCutomerName As Label
'End Class



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOutstandingReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

#Region "Windows Form Designer generated code"

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpFilter = New DevExpress.XtraEditors.GroupControl()
        Me.lblReportType = New System.Windows.Forms.Label()
        Me.cmbOutstandingType = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lkpCustomerName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grpFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilter.SuspendLayout()
        CType(Me.cmbOutstandingType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilter.Appearance.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.Appearance.Options.UseFont = True
        Me.grpFilter.Controls.Add(Me.lblReportType)
        Me.grpFilter.Controls.Add(Me.cmbOutstandingType)
        Me.grpFilter.Controls.Add(Me.lblFrom)
        Me.grpFilter.Controls.Add(Me.dtpFrom)
        Me.grpFilter.Controls.Add(Me.lblTo)
        Me.grpFilter.Controls.Add(Me.dtpTo)
        Me.grpFilter.Controls.Add(Me.lblCustomer)
        Me.grpFilter.Controls.Add(Me.lkpCustomerName)
        Me.grpFilter.Controls.Add(Me.btnRefresh)
        Me.grpFilter.Controls.Add(Me.btnExport)
        Me.grpFilter.Controls.Add(Me.btnPrint)
        Me.grpFilter.Controls.Add(Me.btnExit)
        Me.grpFilter.Location = New System.Drawing.Point(12, 0)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(1576, 73)
        Me.grpFilter.TabIndex = 1
        Me.grpFilter.Text = "Report Filters"
        '
        'lblReportType
        '
        Me.lblReportType.AutoSize = True
        Me.lblReportType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportType.Location = New System.Drawing.Point(19, 35)
        Me.lblReportType.Name = "lblReportType"
        Me.lblReportType.Size = New System.Drawing.Size(111, 24)
        Me.lblReportType.TabIndex = 0
        Me.lblReportType.Text = "Report Type"
        '
        'cmbOutstandingType
        '
        Me.cmbOutstandingType.Location = New System.Drawing.Point(136, 33)
        Me.cmbOutstandingType.Name = "cmbOutstandingType"
        Me.cmbOutstandingType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOutstandingType.Properties.Appearance.Options.UseFont = True
        Me.cmbOutstandingType.Properties.NullText = ""
        Me.cmbOutstandingType.Properties.View = Me.GridView1
        Me.cmbOutstandingType.Size = New System.Drawing.Size(359, 28)
        Me.cmbOutstandingType.TabIndex = 1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(501, 35)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(53, 24)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(560, 32)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(120, 28)
        Me.dtpFrom.TabIndex = 3
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(686, 36)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(29, 24)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(721, 33)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(120, 28)
        Me.dtpTo.TabIndex = 5
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(840, 35)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(91, 24)
        Me.lblCustomer.TabIndex = 6
        Me.lblCustomer.Text = "Customer"
        '
        'lkpCustomerName
        '
        Me.lkpCustomerName.Location = New System.Drawing.Point(937, 34)
        Me.lkpCustomerName.Name = "lkpCustomerName"
        Me.lkpCustomerName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpCustomerName.Properties.Appearance.Options.UseFont = True
        Me.lkpCustomerName.Properties.NullText = ""
        Me.lkpCustomerName.Properties.View = Me.GridView2
        Me.lkpCustomerName.Size = New System.Drawing.Size(250, 28)
        Me.lkpCustomerName.TabIndex = 7
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(1193, 30)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 32)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(1289, 30)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(90, 32)
        Me.btnExport.TabIndex = 9
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(1385, 30)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 32)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1481, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 32)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'gcData
        '
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcData.Location = New System.Drawing.Point(12, 79)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(1576, 709)
        Me.gcData.TabIndex = 0
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.ShowAutoFilterRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameColumnToolStripMenuItem, Me.ExportToExcelToolStripMenuItem, Me.SaveLayoutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(188, 76)
        '
        'RenameColumnToolStripMenuItem
        '
        Me.RenameColumnToolStripMenuItem.Name = "RenameColumnToolStripMenuItem"
        Me.RenameColumnToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.RenameColumnToolStripMenuItem.Text = "Rename Column"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
        '
        'SaveLayoutToolStripMenuItem
        '
        Me.SaveLayoutToolStripMenuItem.Name = "SaveLayoutToolStripMenuItem"
        Me.SaveLayoutToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.SaveLayoutToolStripMenuItem.Text = "Save Layout"
        '
        'FrmOutstandingReport
        '
        Me.ClientSize = New System.Drawing.Size(1600, 800)
        Me.Controls.Add(Me.gcData)
        Me.Controls.Add(Me.grpFilter)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Name = "FrmOutstandingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outstanding Report"
        CType(Me.grpFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.cmbOutstandingType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend WithEvents grpFilter As DevExpress.XtraEditors.GroupControl

    Friend WithEvents lblReportType As Label
    Friend WithEvents cmbOutstandingType As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker

    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker

    Friend WithEvents lblCustomer As Label
    Friend WithEvents lkpCustomerName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button

    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RenameColumnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveLayoutToolStripMenuItem As ToolStripMenuItem
End Class
