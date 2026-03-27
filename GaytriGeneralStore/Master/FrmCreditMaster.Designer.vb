<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreditMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreditMaster))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbCreditEntry = New System.Windows.Forms.GroupBox()
        Me.txtDueDays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCreditLimit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lkpCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.lblLedgerId = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblCustomerSearch = New System.Windows.Forms.Label()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbCreditEntry.SuspendLayout()
        CType(Me.lkpCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.RenameColumnToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.RenameColumnToolStripMenuItem.Text = "Rename Column"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
        '
        'SaveLayoutToolStripMenuItem
        '
        Me.SaveLayoutToolStripMenuItem.Name = "SaveLayoutToolStripMenuItem"
        Me.SaveLayoutToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.SaveLayoutToolStripMenuItem.Text = "Save Layout"
        '
        'gbCreditEntry
        '
        Me.gbCreditEntry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCreditEntry.Controls.Add(Me.txtDueDays)
        Me.gbCreditEntry.Controls.Add(Me.Label2)
        Me.gbCreditEntry.Controls.Add(Me.txtCreditLimit)
        Me.gbCreditEntry.Controls.Add(Me.Label1)
        Me.gbCreditEntry.Controls.Add(Me.lkpCustomer)
        Me.gbCreditEntry.Controls.Add(Me.lblCustomerName)
        Me.gbCreditEntry.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCreditEntry.Location = New System.Drawing.Point(8, 0)
        Me.gbCreditEntry.Name = "gbCreditEntry"
        Me.gbCreditEntry.Size = New System.Drawing.Size(1406, 137)
        Me.gbCreditEntry.TabIndex = 5
        Me.gbCreditEntry.TabStop = False
        Me.gbCreditEntry.Text = "Credit Entry"
        '
        'txtDueDays
        '
        Me.txtDueDays.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDays.Location = New System.Drawing.Point(172, 100)
        Me.txtDueDays.Name = "txtDueDays"
        Me.txtDueDays.Size = New System.Drawing.Size(167, 32)
        Me.txtDueDays.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Due Days"
        '
        'txtCreditLimit
        '
        Me.txtCreditLimit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditLimit.Location = New System.Drawing.Point(172, 63)
        Me.txtCreditLimit.Name = "txtCreditLimit"
        Me.txtCreditLimit.Size = New System.Drawing.Size(167, 32)
        Me.txtCreditLimit.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Credit Limit"
        '
        'lkpCustomer
        '
        Me.lkpCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lkpCustomer.Location = New System.Drawing.Point(172, 25)
        Me.lkpCustomer.Name = "lkpCustomer"
        Me.lkpCustomer.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpCustomer.Properties.Appearance.Options.UseFont = True
        Me.lkpCustomer.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lkpCustomer.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.lkpCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCustomer.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.lkpCustomer.Properties.NullText = ""
        Me.lkpCustomer.Size = New System.Drawing.Size(415, 32)
        Me.lkpCustomer.TabIndex = 10
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(21, 29)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(145, 24)
        Me.lblCustomerName.TabIndex = 9
        Me.lblCustomerName.Text = "Customer Name"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Calibri", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(1302, 654)
        Me.btnRefresh.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnRefresh.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(112, 39)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Re&fresh"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Calibri", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ImageOptions.Image = CType(resources.GetObject("btnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(527, 654)
        Me.btnExit.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.btnExit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 39)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Cl&ose"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(423, 654)
        Me.btnCancel.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 39)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Calibri", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(319, 654)
        Me.btnDelete.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 39)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "&Delete"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Calibri", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(217, 654)
        Me.btnSave.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 39)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Save"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Calibri", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(114, 654)
        Me.btnEdit.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnEdit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.btnEdit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 39)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "&Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Calibri", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(11, 654)
        Me.btnAdd.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.btnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.btnAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 39)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&New"
        '
        'lblLedgerId
        '
        Me.lblLedgerId.AutoSize = True
        Me.lblLedgerId.Location = New System.Drawing.Point(981, 155)
        Me.lblLedgerId.Name = "lblLedgerId"
        Me.lblLedgerId.Size = New System.Drawing.Size(78, 17)
        Me.lblLedgerId.TabIndex = 18
        Me.lblLedgerId.Text = "lblLedgerId"
        Me.lblLedgerId.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(806, 657)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(317, 29)
        Me.txtSearch.TabIndex = 19
        '
        'lblCustomerSearch
        '
        Me.lblCustomerSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCustomerSearch.AutoSize = True
        Me.lblCustomerSearch.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerSearch.Location = New System.Drawing.Point(634, 660)
        Me.lblCustomerSearch.Name = "lblCustomerSearch"
        Me.lblCustomerSearch.Size = New System.Drawing.Size(162, 23)
        Me.lblCustomerSearch.TabIndex = 20
        Me.lblCustomerSearch.Text = "Customer Name"
        '
        'gcData
        '
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcData.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gcData.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcData.Location = New System.Drawing.Point(8, 144)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(1406, 487)
        Me.gcData.TabIndex = 21
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.Row.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.Row.Options.UseFont = True
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsBehavior.Editable = False
        Me.gvData.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.RowHeight = 26
        '
        'FrmCreditMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 703)
        Me.Controls.Add(Me.lblCustomerSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblLedgerId)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gbCreditEntry)
        Me.Controls.Add(Me.gcData)
        Me.Name = "FrmCreditMaster"
        Me.Text = "Credit Master"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbCreditEntry.ResumeLayout(False)
        Me.gbCreditEntry.PerformLayout()
        CType(Me.lkpCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCreditEntry As GroupBox
    Friend WithEvents txtDueDays As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCreditLimit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lkpCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLedgerId As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblCustomerSearch As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RenameColumnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
End Class
