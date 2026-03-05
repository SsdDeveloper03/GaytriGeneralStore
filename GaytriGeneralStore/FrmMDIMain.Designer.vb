<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMDIMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMDIMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusinessProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentAdjustToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbFinYr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.MasterToolStripMenuItem, Me.EntryToolStripMenuItem, Me.ViewToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.UtilityToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1291, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusinessProfileToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'BusinessProfileToolStripMenuItem
        '
        Me.BusinessProfileToolStripMenuItem.Name = "BusinessProfileToolStripMenuItem"
        Me.BusinessProfileToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.BusinessProfileToolStripMenuItem.Text = "Business Profile"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'EntryToolStripMenuItem
        '
        Me.EntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingEntryToolStripMenuItem, Me.PaymentCollectionToolStripMenuItem})
        Me.EntryToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold)
        Me.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem"
        Me.EntryToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.EntryToolStripMenuItem.Text = "Entry"
        '
        'BillingEntryToolStripMenuItem
        '
        Me.BillingEntryToolStripMenuItem.Name = "BillingEntryToolStripMenuItem"
        Me.BillingEntryToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.BillingEntryToolStripMenuItem.Text = "Billing Entry"
        '
        'PaymentCollectionToolStripMenuItem
        '
        Me.PaymentCollectionToolStripMenuItem.Name = "PaymentCollectionToolStripMenuItem"
        Me.PaymentCollectionToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.PaymentCollectionToolStripMenuItem.Text = "Payment Collection"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentAdjustToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold)
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'PaymentAdjustToolStripMenuItem
        '
        Me.PaymentAdjustToolStripMenuItem.Name = "PaymentAdjustToolStripMenuItem"
        Me.PaymentAdjustToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.PaymentAdjustToolStripMenuItem.Text = "Payment Adjust"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold)
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1289, 635)
        Me.Panel1.TabIndex = 1
        '
        'cmbFinYr
        '
        Me.cmbFinYr.FormattingEnabled = True
        Me.cmbFinYr.Location = New System.Drawing.Point(1157, 2)
        Me.cmbFinYr.Name = "cmbFinYr"
        Me.cmbFinYr.Size = New System.Drawing.Size(121, 24)
        Me.cmbFinYr.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1100, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fin. Yr"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(783, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Company Name"
        '
        'cmbCompany
        '
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(896, 2)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(198, 24)
        Me.cmbCompany.TabIndex = 4
        '
        'FrmMDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 671)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCompany)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFinYr)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMDIMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMDIMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusinessProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentAdjustToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFinYr As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCompany As ComboBox
End Class