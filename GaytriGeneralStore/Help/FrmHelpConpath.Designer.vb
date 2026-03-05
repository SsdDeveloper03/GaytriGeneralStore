<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHelpConpath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelpConpath))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbAuthType = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtUserPwd = New System.Windows.Forms.TextBox()
        Me.cmbdbname = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConnect = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbServerName = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please Enter Following Detail To Connect Your Database"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 29)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Authentication"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Login id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Database"
        '
        'cmbAuthType
        '
        Me.cmbAuthType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbAuthType.FormattingEnabled = True
        Me.cmbAuthType.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        Me.cmbAuthType.Location = New System.Drawing.Point(103, 65)
        Me.cmbAuthType.Name = "cmbAuthType"
        Me.cmbAuthType.Size = New System.Drawing.Size(293, 24)
        Me.cmbAuthType.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtUsername.Location = New System.Drawing.Point(103, 96)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(293, 22)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.TabStop = False
        '
        'txtUserPwd
        '
        Me.txtUserPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtUserPwd.Location = New System.Drawing.Point(103, 125)
        Me.txtUserPwd.Name = "txtUserPwd"
        Me.txtUserPwd.Size = New System.Drawing.Size(293, 22)
        Me.txtUserPwd.TabIndex = 3
        Me.txtUserPwd.TabStop = False
        Me.txtUserPwd.UseSystemPasswordChar = True
        '
        'cmbdbname
        '
        Me.cmbdbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbdbname.FormattingEnabled = True
        Me.cmbdbname.Location = New System.Drawing.Point(103, 153)
        Me.cmbdbname.Name = "cmbdbname"
        Me.cmbdbname.Size = New System.Drawing.Size(196, 24)
        Me.cmbdbname.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Appearance.Options.UseForeColor = True
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(220, 182)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 31)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'btnConnect
        '
        Me.btnConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConnect.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Appearance.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnConnect.Appearance.Options.UseFont = True
        Me.btnConnect.Appearance.Options.UseForeColor = True
        Me.btnConnect.AppearancePressed.Image = CType(resources.GetObject("btnConnect.AppearancePressed.Image"), System.Drawing.Image)
        Me.btnConnect.AppearancePressed.Options.UseImage = True
        Me.btnConnect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnConnect.ImageOptions.Image = CType(resources.GetObject("btnConnect.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConnect.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnConnect.Location = New System.Drawing.Point(103, 183)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(80, 30)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "&Connect"
        '
        'cmbServerName
        '
        Me.cmbServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbServerName.FormattingEnabled = True
        Me.cmbServerName.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        Me.cmbServerName.Location = New System.Drawing.Point(103, 37)
        Me.cmbServerName.Name = "cmbServerName"
        Me.cmbServerName.Size = New System.Drawing.Size(293, 24)
        Me.cmbServerName.TabIndex = 0
        '
        'FrmHelpConpath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(423, 222)
        Me.Controls.Add(Me.cmbServerName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cmbdbname)
        Me.Controls.Add(Me.txtUserPwd)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.cmbAuthType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmHelpConpath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Connection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbAuthType As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtUserPwd As TextBox
    Friend WithEvents cmbdbname As ComboBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConnect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbServerName As ComboBox
End Class
