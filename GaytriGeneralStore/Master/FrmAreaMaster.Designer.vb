'Imports DevExpress.XtraGrid
'Imports DevExpress.XtraGrid.Views.Grid

'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
'Partial Class FrmAreaMaster
'    Inherits System.Windows.Forms.Form

'    Private components As System.ComponentModel.IContainer
'    Private lblHeader As Label
'    Private lblAreaName As Label
'    Private lblLandmark As Label
'    Private txtLandmark As TextBox
'    Private lblSubArea As Label
'    Private txtSubArea As TextBox
'    Private lblCity As Label
'    Private cmbCity As ComboBox
'    Private lblZone As Label
'    Private cmbZone As ComboBox
'    Private lblPincode As Label
'    Private txtPincode As TextBox
'    Private chkActive As CheckBox
'    Private lblListHeader As Label
'    Private gcArea As GridControl
'    Private gvArea As GridView
'    Private btnAdd As Button
'    Private btnEdit As Button
'    Private btnDelete As Button
'    Private btnSave As Button
'    Private btnCancel As Button
'    Private btnClose As Button
'    Private grpAreaInfo As GroupBox
'    Private txtAreaName As TextBox

'    <System.Diagnostics.DebuggerStepThrough()>
'    Private Sub InitializeComponent()
'        Me.lblHeader = New System.Windows.Forms.Label()
'        Me.grpAreaInfo = New System.Windows.Forms.GroupBox()
'        Me.lblAreaName = New System.Windows.Forms.Label()
'        Me.txtAreaName = New System.Windows.Forms.TextBox()
'        Me.lblLandmark = New System.Windows.Forms.Label()
'        Me.txtLandmark = New System.Windows.Forms.TextBox()
'        Me.lblSubArea = New System.Windows.Forms.Label()
'        Me.txtSubArea = New System.Windows.Forms.TextBox()
'        Me.lblCity = New System.Windows.Forms.Label()
'        Me.cmbCity = New System.Windows.Forms.ComboBox()
'        Me.lblZone = New System.Windows.Forms.Label()
'        Me.cmbZone = New System.Windows.Forms.ComboBox()
'        Me.lblPincode = New System.Windows.Forms.Label()
'        Me.txtPincode = New System.Windows.Forms.TextBox()
'        Me.chkActive = New System.Windows.Forms.CheckBox()
'        Me.lblListHeader = New System.Windows.Forms.Label()
'        Me.gcArea = New DevExpress.XtraGrid.GridControl()
'        Me.gvArea = New DevExpress.XtraGrid.Views.Grid.GridView()
'        Me.btnAdd = New System.Windows.Forms.Button()
'        Me.btnEdit = New System.Windows.Forms.Button()
'        Me.btnDelete = New System.Windows.Forms.Button()
'        Me.btnSave = New System.Windows.Forms.Button()
'        Me.btnCancel = New System.Windows.Forms.Button()
'        Me.btnClose = New System.Windows.Forms.Button()
'        Me.grpAreaInfo.SuspendLayout()
'        CType(Me.gcArea, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.gvArea, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'lblHeader
'        '
'        Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
'        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
'        Me.lblHeader.ForeColor = System.Drawing.Color.White
'        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
'        Me.lblHeader.Name = "lblHeader"
'        Me.lblHeader.Size = New System.Drawing.Size(1200, 40)
'        Me.lblHeader.TabIndex = 0
'        Me.lblHeader.Text = "AREA ENTRY"
'        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
'        '
'        'grpAreaInfo
'        '
'        Me.grpAreaInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.grpAreaInfo.Controls.Add(Me.lblAreaName)
'        Me.grpAreaInfo.Controls.Add(Me.txtAreaName)
'        Me.grpAreaInfo.Controls.Add(Me.lblLandmark)
'        Me.grpAreaInfo.Controls.Add(Me.txtLandmark)
'        Me.grpAreaInfo.Controls.Add(Me.lblSubArea)
'        Me.grpAreaInfo.Controls.Add(Me.txtSubArea)
'        Me.grpAreaInfo.Controls.Add(Me.lblCity)
'        Me.grpAreaInfo.Controls.Add(Me.cmbCity)
'        Me.grpAreaInfo.Controls.Add(Me.lblZone)
'        Me.grpAreaInfo.Controls.Add(Me.cmbZone)
'        Me.grpAreaInfo.Controls.Add(Me.lblPincode)
'        Me.grpAreaInfo.Controls.Add(Me.txtPincode)
'        Me.grpAreaInfo.Controls.Add(Me.chkActive)
'        Me.grpAreaInfo.Location = New System.Drawing.Point(10, 50)
'        Me.grpAreaInfo.Name = "grpAreaInfo"
'        Me.grpAreaInfo.Size = New System.Drawing.Size(1180, 120)
'        Me.grpAreaInfo.TabIndex = 1
'        Me.grpAreaInfo.TabStop = False
'        Me.grpAreaInfo.Text = "Area Information"
'        '
'        'lblAreaName
'        '
'        Me.lblAreaName.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblAreaName.Location = New System.Drawing.Point(20, 30)
'        Me.lblAreaName.Name = "lblAreaName"
'        Me.lblAreaName.Size = New System.Drawing.Size(87, 23)
'        Me.lblAreaName.TabIndex = 0
'        Me.lblAreaName.Text = "Area Name"
'        '
'        'txtAreaName
'        '
'        Me.txtAreaName.Location = New System.Drawing.Point(120, 28)
'        Me.txtAreaName.Name = "txtAreaName"
'        Me.txtAreaName.Size = New System.Drawing.Size(200, 22)
'        Me.txtAreaName.TabIndex = 1
'        '
'        'lblLandmark
'        '
'        Me.lblLandmark.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblLandmark.Location = New System.Drawing.Point(350, 30)
'        Me.lblLandmark.Name = "lblLandmark"
'        Me.lblLandmark.Size = New System.Drawing.Size(100, 23)
'        Me.lblLandmark.TabIndex = 2
'        Me.lblLandmark.Text = "Landmark"
'        '
'        'txtLandmark
'        '
'        Me.txtLandmark.Location = New System.Drawing.Point(456, 28)
'        Me.txtLandmark.Name = "txtLandmark"
'        Me.txtLandmark.Size = New System.Drawing.Size(200, 22)
'        Me.txtLandmark.TabIndex = 3
'        '
'        'lblSubArea
'        '
'        Me.lblSubArea.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblSubArea.Location = New System.Drawing.Point(680, 30)
'        Me.lblSubArea.Name = "lblSubArea"
'        Me.lblSubArea.Size = New System.Drawing.Size(81, 23)
'        Me.lblSubArea.TabIndex = 4
'        Me.lblSubArea.Text = "Sub Area"
'        '
'        'txtSubArea
'        '
'        Me.txtSubArea.Location = New System.Drawing.Point(786, 28)
'        Me.txtSubArea.Name = "txtSubArea"
'        Me.txtSubArea.Size = New System.Drawing.Size(200, 22)
'        Me.txtSubArea.TabIndex = 5
'        '
'        'lblCity
'        '
'        Me.lblCity.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblCity.Location = New System.Drawing.Point(20, 70)
'        Me.lblCity.Name = "lblCity"
'        Me.lblCity.Size = New System.Drawing.Size(87, 23)
'        Me.lblCity.TabIndex = 6
'        Me.lblCity.Text = "City"
'        '
'        'cmbCity
'        '
'        Me.cmbCity.Location = New System.Drawing.Point(120, 68)
'        Me.cmbCity.Name = "cmbCity"
'        Me.cmbCity.Size = New System.Drawing.Size(200, 24)
'        Me.cmbCity.TabIndex = 7
'        '
'        'lblZone
'        '
'        Me.lblZone.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblZone.Location = New System.Drawing.Point(350, 70)
'        Me.lblZone.Name = "lblZone"
'        Me.lblZone.Size = New System.Drawing.Size(100, 23)
'        Me.lblZone.TabIndex = 8
'        Me.lblZone.Text = "Zone"
'        '
'        'cmbZone
'        '
'        Me.cmbZone.Location = New System.Drawing.Point(456, 68)
'        Me.cmbZone.Name = "cmbZone"
'        Me.cmbZone.Size = New System.Drawing.Size(200, 24)
'        Me.cmbZone.TabIndex = 9
'        '
'        'lblPincode
'        '
'        Me.lblPincode.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.lblPincode.Location = New System.Drawing.Point(680, 70)
'        Me.lblPincode.Name = "lblPincode"
'        Me.lblPincode.Size = New System.Drawing.Size(81, 23)
'        Me.lblPincode.TabIndex = 10
'        Me.lblPincode.Text = "Pincode"
'        '
'        'txtPincode
'        '
'        Me.txtPincode.Location = New System.Drawing.Point(786, 68)
'        Me.txtPincode.Name = "txtPincode"
'        Me.txtPincode.Size = New System.Drawing.Size(200, 22)
'        Me.txtPincode.TabIndex = 11
'        '
'        'chkActive
'        '
'        Me.chkActive.Checked = True
'        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
'        Me.chkActive.Location = New System.Drawing.Point(1000, 30)
'        Me.chkActive.Name = "chkActive"
'        Me.chkActive.Size = New System.Drawing.Size(104, 24)
'        Me.chkActive.TabIndex = 12
'        Me.chkActive.Text = "Active"
'        '
'        'lblListHeader
'        '
'        Me.lblListHeader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.lblListHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
'        Me.lblListHeader.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
'        Me.lblListHeader.ForeColor = System.Drawing.Color.White
'        Me.lblListHeader.Location = New System.Drawing.Point(10, 180)
'        Me.lblListHeader.Name = "lblListHeader"
'        Me.lblListHeader.Size = New System.Drawing.Size(1180, 30)
'        Me.lblListHeader.TabIndex = 2
'        Me.lblListHeader.Text = "AREA LIST"
'        '
'        'gcArea
'        '
'        Me.gcArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.gcArea.Location = New System.Drawing.Point(10, 210)
'        Me.gcArea.MainView = Me.gvArea
'        Me.gcArea.Name = "gcArea"
'        Me.gcArea.Size = New System.Drawing.Size(1180, 350)
'        Me.gcArea.TabIndex = 3
'        Me.gcArea.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArea})
'        '
'        'gvArea
'        '
'        Me.gvArea.GridControl = Me.gcArea
'        Me.gvArea.Name = "gvArea"
'        Me.gvArea.OptionsView.EnableAppearanceEvenRow = True
'        Me.gvArea.OptionsView.ShowAutoFilterRow = True
'        Me.gvArea.OptionsView.ShowGroupPanel = False
'        '
'        'btnAdd
'        '
'        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.btnAdd.BackColor = System.Drawing.Color.SeaGreen
'        Me.btnAdd.ForeColor = System.Drawing.Color.White
'        Me.btnAdd.Location = New System.Drawing.Point(350, 580)
'        Me.btnAdd.Name = "btnAdd"
'        Me.btnAdd.Size = New System.Drawing.Size(90, 35)
'        Me.btnAdd.TabIndex = 4
'        Me.btnAdd.Text = "ADD"
'        Me.btnAdd.UseVisualStyleBackColor = False
'        '
'        'btnEdit
'        '
'        Me.btnEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.btnEdit.BackColor = System.Drawing.Color.DodgerBlue
'        Me.btnEdit.ForeColor = System.Drawing.Color.White
'        Me.btnEdit.Location = New System.Drawing.Point(450, 580)
'        Me.btnEdit.Name = "btnEdit"
'        Me.btnEdit.Size = New System.Drawing.Size(90, 35)
'        Me.btnEdit.TabIndex = 5
'        Me.btnEdit.Text = "EDIT"
'        Me.btnEdit.UseVisualStyleBackColor = False
'        '
'        'btnDelete
'        '
'        Me.btnDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
'        Me.btnDelete.ForeColor = System.Drawing.Color.White
'        Me.btnDelete.Location = New System.Drawing.Point(550, 580)
'        Me.btnDelete.Name = "btnDelete"
'        Me.btnDelete.Size = New System.Drawing.Size(90, 35)
'        Me.btnDelete.TabIndex = 6
'        Me.btnDelete.Text = "DELETE"
'        Me.btnDelete.UseVisualStyleBackColor = False
'        '
'        'btnSave
'        '
'        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
'        Me.btnSave.ForeColor = System.Drawing.Color.White
'        Me.btnSave.Location = New System.Drawing.Point(650, 580)
'        Me.btnSave.Name = "btnSave"
'        Me.btnSave.Size = New System.Drawing.Size(90, 35)
'        Me.btnSave.TabIndex = 7
'        Me.btnSave.Text = "SAVE"
'        Me.btnSave.UseVisualStyleBackColor = False
'        '
'        'btnCancel
'        '
'        Me.btnCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.btnCancel.BackColor = System.Drawing.Color.DarkOrange
'        Me.btnCancel.ForeColor = System.Drawing.Color.White
'        Me.btnCancel.Location = New System.Drawing.Point(750, 580)
'        Me.btnCancel.Name = "btnCancel"
'        Me.btnCancel.Size = New System.Drawing.Size(90, 35)
'        Me.btnCancel.TabIndex = 8
'        Me.btnCancel.Text = "CANCEL"
'        Me.btnCancel.UseVisualStyleBackColor = False
'        '
'        'btnClose
'        '
'        Me.btnClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'            Or System.Windows.Forms.AnchorStyles.Left) _
'            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.btnClose.BackColor = System.Drawing.Color.Gray
'        Me.btnClose.ForeColor = System.Drawing.Color.White
'        Me.btnClose.Location = New System.Drawing.Point(850, 580)
'        Me.btnClose.Name = "btnClose"
'        Me.btnClose.Size = New System.Drawing.Size(90, 35)
'        Me.btnClose.TabIndex = 9
'        Me.btnClose.Text = "CLOSE"
'        Me.btnClose.UseVisualStyleBackColor = False
'        '
'        'FrmAreaMaster
'        '
'        Me.ClientSize = New System.Drawing.Size(1200, 640)
'        Me.Controls.Add(Me.lblHeader)
'        Me.Controls.Add(Me.grpAreaInfo)
'        Me.Controls.Add(Me.lblListHeader)
'        Me.Controls.Add(Me.gcArea)
'        Me.Controls.Add(Me.btnAdd)
'        Me.Controls.Add(Me.btnEdit)
'        Me.Controls.Add(Me.btnDelete)
'        Me.Controls.Add(Me.btnSave)
'        Me.Controls.Add(Me.btnCancel)
'        Me.Controls.Add(Me.btnClose)
'        Me.Name = "FrmAreaMaster"
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'        Me.Text = "Area Master"
'        Me.grpAreaInfo.ResumeLayout(False)
'        Me.grpAreaInfo.PerformLayout()
'        CType(Me.gcArea, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.gvArea, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)

'    End Sub

'End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAreaMaster
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpAreaInfo = New System.Windows.Forms.GroupBox()
        Me.lblAreaName = New System.Windows.Forms.Label()
        Me.txtAreaName = New System.Windows.Forms.TextBox()
        Me.lblSubArea = New System.Windows.Forms.Label()
        Me.txtSubArea = New System.Windows.Forms.TextBox()
        Me.lblLandmark = New System.Windows.Forms.Label()
        Me.txtLandmark = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.cmbZone = New System.Windows.Forms.ComboBox()
        Me.lblPincode = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.txtLatitude = New System.Windows.Forms.TextBox()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.txtLongitude = New System.Windows.Forms.TextBox()
        Me.lblDispSrNo = New System.Windows.Forms.Label()
        Me.txtDispSrNo = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.gcArea = New DevExpress.XtraGrid.GridControl()
        Me.gvArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblAreaId = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpAreaInfo.SuspendLayout()
        CType(Me.gcArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1200, 40)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "AREA MASTER"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAreaInfo
        '
        Me.grpAreaInfo.Controls.Add(Me.lblAreaName)
        Me.grpAreaInfo.Controls.Add(Me.txtAreaName)
        Me.grpAreaInfo.Controls.Add(Me.lblSubArea)
        Me.grpAreaInfo.Controls.Add(Me.txtSubArea)
        Me.grpAreaInfo.Controls.Add(Me.lblLandmark)
        Me.grpAreaInfo.Controls.Add(Me.txtLandmark)
        Me.grpAreaInfo.Controls.Add(Me.lblCity)
        Me.grpAreaInfo.Controls.Add(Me.cmbCity)
        Me.grpAreaInfo.Controls.Add(Me.lblZone)
        Me.grpAreaInfo.Controls.Add(Me.cmbZone)
        Me.grpAreaInfo.Controls.Add(Me.lblPincode)
        Me.grpAreaInfo.Controls.Add(Me.txtPincode)
        Me.grpAreaInfo.Controls.Add(Me.lblState)
        Me.grpAreaInfo.Controls.Add(Me.cmbState)
        Me.grpAreaInfo.Controls.Add(Me.lblCountry)
        Me.grpAreaInfo.Controls.Add(Me.cmbCountry)
        Me.grpAreaInfo.Controls.Add(Me.lblLatitude)
        Me.grpAreaInfo.Controls.Add(Me.txtLatitude)
        Me.grpAreaInfo.Controls.Add(Me.lblLongitude)
        Me.grpAreaInfo.Controls.Add(Me.txtLongitude)
        Me.grpAreaInfo.Controls.Add(Me.lblDispSrNo)
        Me.grpAreaInfo.Controls.Add(Me.txtDispSrNo)
        Me.grpAreaInfo.Controls.Add(Me.chkActive)
        Me.grpAreaInfo.Location = New System.Drawing.Point(10, 50)
        Me.grpAreaInfo.Name = "grpAreaInfo"
        Me.grpAreaInfo.Size = New System.Drawing.Size(1180, 160)
        Me.grpAreaInfo.TabIndex = 1
        Me.grpAreaInfo.TabStop = False
        '
        'lblAreaName
        '
        Me.lblAreaName.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaName.Location = New System.Drawing.Point(20, 30)
        Me.lblAreaName.Name = "lblAreaName"
        Me.lblAreaName.Size = New System.Drawing.Size(58, 23)
        Me.lblAreaName.TabIndex = 0
        Me.lblAreaName.Text = "Area Name"
        '
        'txtAreaName
        '
        Me.txtAreaName.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaName.Location = New System.Drawing.Point(84, 30)
        Me.txtAreaName.Name = "txtAreaName"
        Me.txtAreaName.Size = New System.Drawing.Size(200, 29)
        Me.txtAreaName.TabIndex = 0
        '
        'lblSubArea
        '
        Me.lblSubArea.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubArea.Location = New System.Drawing.Point(336, 30)
        Me.lblSubArea.Name = "lblSubArea"
        Me.lblSubArea.Size = New System.Drawing.Size(83, 23)
        Me.lblSubArea.TabIndex = 2
        Me.lblSubArea.Text = "Sub Area"
        '
        'txtSubArea
        '
        Me.txtSubArea.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubArea.Location = New System.Drawing.Point(430, 28)
        Me.txtSubArea.Name = "txtSubArea"
        Me.txtSubArea.Size = New System.Drawing.Size(200, 29)
        Me.txtSubArea.TabIndex = 1
        '
        'lblLandmark
        '
        Me.lblLandmark.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLandmark.Location = New System.Drawing.Point(671, 30)
        Me.lblLandmark.Name = "lblLandmark"
        Me.lblLandmark.Size = New System.Drawing.Size(74, 23)
        Me.lblLandmark.TabIndex = 4
        Me.lblLandmark.Text = "Landmark"
        '
        'txtLandmark
        '
        Me.txtLandmark.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLandmark.Location = New System.Drawing.Point(760, 28)
        Me.txtLandmark.Name = "txtLandmark"
        Me.txtLandmark.Size = New System.Drawing.Size(200, 29)
        Me.txtLandmark.TabIndex = 2
        '
        'lblCity
        '
        Me.lblCity.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(20, 70)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(58, 23)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "City"
        '
        'cmbCity
        '
        Me.cmbCity.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.Location = New System.Drawing.Point(84, 69)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(200, 30)
        Me.cmbCity.TabIndex = 3
        '
        'lblZone
        '
        Me.lblZone.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.Location = New System.Drawing.Point(336, 70)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(83, 23)
        Me.lblZone.TabIndex = 8
        Me.lblZone.Text = "Zone"
        '
        'cmbZone
        '
        Me.cmbZone.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbZone.Location = New System.Drawing.Point(430, 68)
        Me.cmbZone.Name = "cmbZone"
        Me.cmbZone.Size = New System.Drawing.Size(200, 30)
        Me.cmbZone.TabIndex = 4
        '
        'lblPincode
        '
        Me.lblPincode.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPincode.Location = New System.Drawing.Point(671, 70)
        Me.lblPincode.Name = "lblPincode"
        Me.lblPincode.Size = New System.Drawing.Size(74, 23)
        Me.lblPincode.TabIndex = 10
        Me.lblPincode.Text = "Pincode"
        '
        'txtPincode
        '
        Me.txtPincode.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPincode.Location = New System.Drawing.Point(760, 69)
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(90, 29)
        Me.txtPincode.TabIndex = 7
        '
        'lblState
        '
        Me.lblState.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(20, 110)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(58, 23)
        Me.lblState.TabIndex = 12
        Me.lblState.Text = "State"
        '
        'cmbState
        '
        Me.cmbState.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.Location = New System.Drawing.Point(84, 109)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(200, 30)
        Me.cmbState.TabIndex = 5
        '
        'lblCountry
        '
        Me.lblCountry.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(336, 110)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(83, 23)
        Me.lblCountry.TabIndex = 14
        Me.lblCountry.Text = "Country"
        '
        'cmbCountry
        '
        Me.cmbCountry.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.Location = New System.Drawing.Point(430, 108)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(200, 30)
        Me.cmbCountry.TabIndex = 6
        '
        'lblLatitude
        '
        Me.lblLatitude.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatitude.Location = New System.Drawing.Point(671, 110)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(74, 23)
        Me.lblLatitude.TabIndex = 16
        Me.lblLatitude.Text = "Latitude"
        Me.lblLatitude.Visible = False
        '
        'txtLatitude
        '
        Me.txtLatitude.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatitude.Location = New System.Drawing.Point(760, 108)
        Me.txtLatitude.Name = "txtLatitude"
        Me.txtLatitude.Size = New System.Drawing.Size(90, 29)
        Me.txtLatitude.TabIndex = 10
        Me.txtLatitude.Visible = False
        '
        'lblLongitude
        '
        Me.lblLongitude.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitude.Location = New System.Drawing.Point(860, 110)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(74, 23)
        Me.lblLongitude.TabIndex = 18
        Me.lblLongitude.Text = "Longitude"
        Me.lblLongitude.Visible = False
        '
        'txtLongitude
        '
        Me.txtLongitude.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitude.Location = New System.Drawing.Point(940, 108)
        Me.txtLongitude.Name = "txtLongitude"
        Me.txtLongitude.Size = New System.Drawing.Size(90, 29)
        Me.txtLongitude.TabIndex = 11
        Me.txtLongitude.Visible = False
        '
        'lblDispSrNo
        '
        Me.lblDispSrNo.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispSrNo.Location = New System.Drawing.Point(860, 69)
        Me.lblDispSrNo.Name = "lblDispSrNo"
        Me.lblDispSrNo.Size = New System.Drawing.Size(89, 23)
        Me.lblDispSrNo.TabIndex = 20
        Me.lblDispSrNo.Text = "Display Sr No"
        '
        'txtDispSrNo
        '
        Me.txtDispSrNo.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispSrNo.Location = New System.Drawing.Point(960, 68)
        Me.txtDispSrNo.Name = "txtDispSrNo"
        Me.txtDispSrNo.Size = New System.Drawing.Size(70, 29)
        Me.txtDispSrNo.TabIndex = 8
        '
        'chkActive
        '
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Location = New System.Drawing.Point(1000, 30)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(104, 24)
        Me.chkActive.TabIndex = 9
        Me.chkActive.Text = "Active"
        '
        'gcArea
        '
        Me.gcArea.Location = New System.Drawing.Point(10, 220)
        Me.gcArea.MainView = Me.gvArea
        Me.gcArea.Name = "gcArea"
        Me.gcArea.Size = New System.Drawing.Size(1180, 337)
        Me.gcArea.TabIndex = 7
        Me.gcArea.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArea})
        '
        'gvArea
        '
        Me.gvArea.GridControl = Me.gcArea
        Me.gvArea.Name = "gvArea"
        Me.gvArea.OptionsView.EnableAppearanceEvenRow = True
        Me.gvArea.OptionsView.ShowAutoFilterRow = True
        Me.gvArea.OptionsView.ShowGroupPanel = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(325, 563)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 47)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEdit.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(424, 563)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 47)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(523, 563)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 47)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(622, 563)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 47)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(721, 563)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 47)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Cornsilk
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(820, 563)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 47)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "CL&OSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblAreaId
        '
        Me.lblAreaId.AutoSize = True
        Me.lblAreaId.Location = New System.Drawing.Point(665, 225)
        Me.lblAreaId.Name = "lblAreaId"
        Me.lblAreaId.Size = New System.Drawing.Size(53, 17)
        Me.lblAreaId.TabIndex = 9
        Me.lblAreaId.Text = "Area Id"
        Me.lblAreaId.Visible = False
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
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'SaveLayoutToolStripMenuItem
        '
        Me.SaveLayoutToolStripMenuItem.Name = "SaveLayoutToolStripMenuItem"
        Me.SaveLayoutToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.SaveLayoutToolStripMenuItem.Text = "Save Layout"
        '
        'FrmAreaMaster
        '
        Me.ClientSize = New System.Drawing.Size(1200, 620)
        Me.Controls.Add(Me.lblAreaId)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpAreaInfo)
        Me.Controls.Add(Me.gcArea)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "FrmAreaMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Master"
        Me.grpAreaInfo.ResumeLayout(False)
        Me.grpAreaInfo.PerformLayout()
        CType(Me.gcArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    '================ DECLARE CONTROLS =================

    Friend WithEvents lblHeader As Label
    Friend WithEvents grpAreaInfo As GroupBox

    Friend WithEvents lblAreaName As Label
    Friend WithEvents txtAreaName As TextBox

    Friend WithEvents lblSubArea As Label
    Friend WithEvents txtSubArea As TextBox

    Friend WithEvents lblLandmark As Label
    Friend WithEvents txtLandmark As TextBox

    Friend WithEvents lblZone As Label
    Friend WithEvents cmbZone As ComboBox

    Friend WithEvents lblCity As Label
    Friend WithEvents cmbCity As ComboBox

    Friend WithEvents lblPincode As Label
    Friend WithEvents txtPincode As TextBox

    Friend WithEvents lblState As Label
    Friend WithEvents cmbState As ComboBox

    Friend WithEvents lblCountry As Label
    Friend WithEvents cmbCountry As ComboBox

    Friend WithEvents lblLatitude As Label
    Friend WithEvents txtLatitude As TextBox

    Friend WithEvents lblLongitude As Label
    Friend WithEvents txtLongitude As TextBox

    Friend WithEvents lblDispSrNo As Label
    Friend WithEvents txtDispSrNo As TextBox

    Friend WithEvents chkActive As CheckBox

    Friend WithEvents gcArea As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvArea As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblAreaId As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RenameColumnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveLayoutToolStripMenuItem As ToolStripMenuItem
End Class