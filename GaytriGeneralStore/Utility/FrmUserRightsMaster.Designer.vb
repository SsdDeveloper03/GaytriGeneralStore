<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserRightsMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.grdData1 = New DevExpress.XtraGrid.GridControl()
        Me.grdUserList1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcUsers = New DevExpress.XtraGrid.GridControl()
        Me.gvUsers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UncheckALlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FormViewId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FormViewName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FormView = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MenuName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AllowAccess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NewRecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ModifyRecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DeleteRecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AllowPrevYearTran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.RenameFieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grdData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUserList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(8, 732)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(88, 17)
        Me.lblUserName.TabIndex = 10
        Me.lblUserName.Text = "User Name"
        Me.lblUserName.Visible = False
        '
        'grdData1
        '
        Me.grdData1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdData1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdData1.Location = New System.Drawing.Point(12, 407)
        Me.grdData1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdData1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdData1.MainView = Me.grdUserList1
        Me.grdData1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdData1.Name = "grdData1"
        Me.grdData1.Size = New System.Drawing.Size(371, 310)
        Me.grdData1.TabIndex = 77
        Me.grdData1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdUserList1})
        '
        'grdUserList1
        '
        Me.grdUserList1.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.grdUserList1.Appearance.FooterPanel.Options.UseFont = True
        Me.grdUserList1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.grdUserList1.Appearance.HeaderPanel.Options.UseFont = True
        Me.grdUserList1.Appearance.Row.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.grdUserList1.Appearance.Row.Options.UseFont = True
        Me.grdUserList1.GridControl = Me.grdData1
        Me.grdUserList1.Name = "grdUserList1"
        Me.grdUserList1.OptionsBehavior.Editable = False
        Me.grdUserList1.OptionsSelection.MultiSelect = True
        Me.grdUserList1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdUserList1.OptionsView.ShowAutoFilterRow = True
        Me.grdUserList1.OptionsView.ShowFooter = True
        Me.grdUserList1.OptionsView.ShowGroupPanel = False
        '
        'gcUsers
        '
        Me.gcUsers.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gcUsers.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode2.RelationName = "Level1"
        Me.gcUsers.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gcUsers.Location = New System.Drawing.Point(12, 15)
        Me.gcUsers.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcUsers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcUsers.MainView = Me.gvUsers
        Me.gcUsers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gcUsers.Name = "gcUsers"
        Me.gcUsers.Size = New System.Drawing.Size(371, 350)
        Me.gcUsers.TabIndex = 10
        Me.gcUsers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUsers})
        '
        'gvUsers
        '
        Me.gvUsers.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvUsers.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvUsers.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvUsers.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvUsers.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvUsers.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvUsers.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvUsers.Appearance.FooterPanel.Options.UseFont = True
        Me.gvUsers.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvUsers.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvUsers.Appearance.Row.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvUsers.Appearance.Row.Options.UseFont = True
        Me.gvUsers.GridControl = Me.gcUsers
        Me.gvUsers.GroupPanelText = "All Department "
        Me.gvUsers.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "")})
        Me.gvUsers.Name = "gvUsers"
        Me.gvUsers.OptionsBehavior.Editable = False
        Me.gvUsers.OptionsCustomization.AllowGroup = False
        Me.gvUsers.OptionsMenu.EnableFooterMenu = False
        Me.gvUsers.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.gvUsers.OptionsView.ShowAutoFilterRow = True
        Me.gvUsers.OptionsView.ShowFooter = True
        Me.gvUsers.OptionsView.ShowGroupPanel = False
        '
        'gcData
        '
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcData.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gcData.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gcData.Location = New System.Drawing.Point(391, 15)
        Me.gcData.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.gcData.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcData.MainView = Me.gvData
        Me.gcData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(919, 703)
        Me.gcData.TabIndex = 78
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckAllToolStripMenuItem, Me.UncheckALlToolStripMenuItem, Me.RenameFieldToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(227, 128)
        '
        'CheckAllToolStripMenuItem
        '
        Me.CheckAllToolStripMenuItem.Name = "CheckAllToolStripMenuItem"
        Me.CheckAllToolStripMenuItem.Size = New System.Drawing.Size(200, 32)
        Me.CheckAllToolStripMenuItem.Text = "Check All"
        '
        'UncheckALlToolStripMenuItem
        '
        Me.UncheckALlToolStripMenuItem.Name = "UncheckALlToolStripMenuItem"
        Me.UncheckALlToolStripMenuItem.Size = New System.Drawing.Size(200, 32)
        Me.UncheckALlToolStripMenuItem.Text = "Uncheck All"
        '
        'gvData
        '
        Me.gvData.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvData.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvData.Appearance.FooterPanel.Options.UseFont = True
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FormViewId, Me.FormViewName, Me.FormView, Me.MenuName, Me.IsActive, Me.AllowAccess, Me.NewRecord, Me.ModifyRecord, Me.DeleteRecord, Me.AllowPrevYearTran})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsSelection.MultiSelect = True
        Me.gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvData.OptionsView.ShowAutoFilterRow = True
        Me.gvData.OptionsView.ShowFooter = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'FormViewId
        '
        Me.FormViewId.Caption = "FormViewId"
        Me.FormViewId.FieldName = "FormViewId"
        Me.FormViewId.Name = "FormViewId"
        Me.FormViewId.OptionsColumn.ReadOnly = True
        '
        'FormViewName
        '
        Me.FormViewName.Caption = "Form/View Name"
        Me.FormViewName.FieldName = "FormViewName"
        Me.FormViewName.Name = "FormViewName"
        Me.FormViewName.OptionsColumn.AllowEdit = False
        Me.FormViewName.OptionsColumn.AllowFocus = False
        Me.FormViewName.OptionsColumn.ReadOnly = True
        Me.FormViewName.Visible = True
        Me.FormViewName.VisibleIndex = 1
        Me.FormViewName.Width = 170
        '
        'FormView
        '
        Me.FormView.Caption = "Form/View"
        Me.FormView.FieldName = "FormView"
        Me.FormView.Name = "FormView"
        Me.FormView.OptionsColumn.AllowEdit = False
        Me.FormView.OptionsColumn.AllowFocus = False
        Me.FormView.OptionsColumn.ReadOnly = True
        '
        'MenuName
        '
        Me.MenuName.Caption = "MenuName"
        Me.MenuName.FieldName = "MenuName"
        Me.MenuName.Name = "MenuName"
        Me.MenuName.OptionsColumn.AllowEdit = False
        Me.MenuName.OptionsColumn.AllowFocus = False
        Me.MenuName.OptionsColumn.ReadOnly = True
        Me.MenuName.Visible = True
        Me.MenuName.VisibleIndex = 2
        Me.MenuName.Width = 113
        '
        'IsActive
        '
        Me.IsActive.Caption = "IsActive"
        Me.IsActive.FieldName = "IsActive"
        Me.IsActive.Name = "IsActive"
        Me.IsActive.OptionsColumn.AllowEdit = False
        Me.IsActive.OptionsColumn.AllowFocus = False
        Me.IsActive.OptionsColumn.ReadOnly = True
        '
        'AllowAccess
        '
        Me.AllowAccess.Caption = "Allow"
        Me.AllowAccess.FieldName = "AllowAccess"
        Me.AllowAccess.Name = "AllowAccess"
        Me.AllowAccess.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.AllowAccess.Visible = True
        Me.AllowAccess.VisibleIndex = 3
        Me.AllowAccess.Width = 56
        '
        'NewRecord
        '
        Me.NewRecord.Caption = "New"
        Me.NewRecord.FieldName = "NewRecord"
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.NewRecord.Visible = True
        Me.NewRecord.VisibleIndex = 4
        Me.NewRecord.Width = 56
        '
        'ModifyRecord
        '
        Me.ModifyRecord.Caption = "Modify"
        Me.ModifyRecord.FieldName = "ModifyRecord"
        Me.ModifyRecord.Name = "ModifyRecord"
        Me.ModifyRecord.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.ModifyRecord.Visible = True
        Me.ModifyRecord.VisibleIndex = 5
        Me.ModifyRecord.Width = 56
        '
        'DeleteRecord
        '
        Me.DeleteRecord.Caption = "Delete"
        Me.DeleteRecord.FieldName = "DeleteRecord"
        Me.DeleteRecord.Name = "DeleteRecord"
        Me.DeleteRecord.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.DeleteRecord.Visible = True
        Me.DeleteRecord.VisibleIndex = 6
        Me.DeleteRecord.Width = 56
        '
        'AllowPrevYearTran
        '
        Me.AllowPrevYearTran.Caption = "AllowPrevYearTran"
        Me.AllowPrevYearTran.FieldName = "AllowPrevYearTran"
        Me.AllowPrevYearTran.Name = "AllowPrevYearTran"
        Me.AllowPrevYearTran.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.AllowPrevYearTran.Visible = True
        Me.AllowPrevYearTran.VisibleIndex = 7
        Me.AllowPrevYearTran.Width = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 384)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Copy Rights of :"
        '
        'lblUserId
        '
        Me.lblUserId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(387, 737)
        Me.lblUserId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(55, 17)
        Me.lblUserId.TabIndex = 80
        Me.lblUserId.Text = "UserId"
        Me.lblUserId.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnExit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(1229, 725)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 31)
        Me.btnExit.TabIndex = 82
        Me.btnExit.Text = "Cl&ose"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(1141, 725)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 31)
        Me.btnSave.TabIndex = 81
        Me.btnSave.Text = "&Save"
        '
        'RenameFieldToolStripMenuItem
        '
        Me.RenameFieldToolStripMenuItem.Name = "RenameFieldToolStripMenuItem"
        Me.RenameFieldToolStripMenuItem.Size = New System.Drawing.Size(226, 32)
        Me.RenameFieldToolStripMenuItem.Text = "Rename Column"
        '
        'FrmUserRightsMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 764)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.grdData1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gcData)
        Me.Controls.Add(Me.gcUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmUserRightsMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Rights Master"
        CType(Me.grdData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUserList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents gcUsers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUsers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdData1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdUserList1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUserId As System.Windows.Forms.Label
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FormViewId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FormViewName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FormView As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AllowAccess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NewRecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModifyRecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DeleteRecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AllowPrevYearTran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CheckAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UncheckALlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameFieldToolStripMenuItem As ToolStripMenuItem
End Class
