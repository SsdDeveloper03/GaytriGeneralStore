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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusinessProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.BillingEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentAdjustToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'BillingEntryToolStripMenuItem
        '
        Me.BillingEntryToolStripMenuItem.Name = "BillingEntryToolStripMenuItem"
        Me.BillingEntryToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.BillingEntryToolStripMenuItem.Text = "Billing Entry"
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
        'PaymentAdjustToolStripMenuItem
        '
        Me.PaymentAdjustToolStripMenuItem.Name = "PaymentAdjustToolStripMenuItem"
        Me.PaymentAdjustToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.PaymentAdjustToolStripMenuItem.Text = "Payment Adjust"
        '
        'PaymentCollectionToolStripMenuItem
        '
        Me.PaymentCollectionToolStripMenuItem.Name = "PaymentCollectionToolStripMenuItem"
        Me.PaymentCollectionToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.PaymentCollectionToolStripMenuItem.Text = "Payment Collection"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1289, 635)
        Me.Panel1.TabIndex = 1
        '
        'FrmMDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 671)
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
End Class