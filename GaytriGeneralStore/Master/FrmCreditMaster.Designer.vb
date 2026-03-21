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
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.hbCreditEntry = New System.Windows.Forms.GroupBox()
        Me.dtpDueDaysDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDueDays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCreditLimit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lkpCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hbCreditEntry.SuspendLayout()
        CType(Me.lkpCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcData
        '
        Me.gcData.Location = New System.Drawing.Point(13, 377)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(1397, 314)
        Me.gcData.TabIndex = 4
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'hbCreditEntry
        '
        Me.hbCreditEntry.Controls.Add(Me.dtpDueDaysDate)
        Me.hbCreditEntry.Controls.Add(Me.Label3)
        Me.hbCreditEntry.Controls.Add(Me.txtDueDays)
        Me.hbCreditEntry.Controls.Add(Me.Label2)
        Me.hbCreditEntry.Controls.Add(Me.txtCreditLimit)
        Me.hbCreditEntry.Controls.Add(Me.Label1)
        Me.hbCreditEntry.Controls.Add(Me.lkpCustomer)
        Me.hbCreditEntry.Controls.Add(Me.lblCustomerName)
        Me.hbCreditEntry.Location = New System.Drawing.Point(13, 1)
        Me.hbCreditEntry.Name = "hbCreditEntry"
        Me.hbCreditEntry.Size = New System.Drawing.Size(1397, 105)
        Me.hbCreditEntry.TabIndex = 5
        Me.hbCreditEntry.TabStop = False
        Me.hbCreditEntry.Text = "Credit Entry"
        '
        'dtpDueDaysDate
        '
        Me.dtpDueDaysDate.CalendarFont = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDaysDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDaysDate.Location = New System.Drawing.Point(739, 65)
        Me.dtpDueDaysDate.Name = "dtpDueDaysDate"
        Me.dtpDueDaysDate.Size = New System.Drawing.Size(167, 22)
        Me.dtpDueDaysDate.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(599, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Due Days Date"
        '
        'txtDueDays
        '
        Me.txtDueDays.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDays.Location = New System.Drawing.Point(739, 26)
        Me.txtDueDays.Name = "txtDueDays"
        Me.txtDueDays.Size = New System.Drawing.Size(167, 29)
        Me.txtDueDays.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(599, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Due Days"
        '
        'txtCreditLimit
        '
        Me.txtCreditLimit.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditLimit.Location = New System.Drawing.Point(172, 62)
        Me.txtCreditLimit.Name = "txtCreditLimit"
        Me.txtCreditLimit.Size = New System.Drawing.Size(167, 29)
        Me.txtCreditLimit.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Credit Limit"
        '
        'lkpCustomer
        '
        Me.lkpCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lkpCustomer.Location = New System.Drawing.Point(172, 26)
        Me.lkpCustomer.Name = "lkpCustomer"
        Me.lkpCustomer.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpCustomer.Properties.Appearance.Options.UseFont = True
        Me.lkpCustomer.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lkpCustomer.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.lkpCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCustomer.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.lkpCustomer.Properties.NullText = ""
        Me.lkpCustomer.Size = New System.Drawing.Size(415, 28)
        Me.lkpCustomer.TabIndex = 10
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(32, 29)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(134, 23)
        Me.lblCustomerName.TabIndex = 9
        Me.lblCustomerName.Text = "Customer Name"
        '
        'FrmCreditMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 703)
        Me.Controls.Add(Me.hbCreditEntry)
        Me.Controls.Add(Me.gcData)
        Me.Name = "FrmCreditMaster"
        Me.Text = "Credit Master"
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hbCreditEntry.ResumeLayout(False)
        Me.hbCreditEntry.PerformLayout()
        CType(Me.lkpCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents hbCreditEntry As GroupBox
    Friend WithEvents dtpDueDaysDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDueDays As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCreditLimit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lkpCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCustomerName As Label
End Class
