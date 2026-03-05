<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSQLSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSQLSetup))
        Me.Rbtn2019 = New System.Windows.Forms.RadioButton()
        Me.Rbtn2008 = New System.Windows.Forms.RadioButton()
        Me.btnInstallSqlServer2019 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRCompleted = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRTest3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRTest2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRTest1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRSSMS = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreateDB = New DevExpress.XtraEditors.SimpleButton()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.btnInstallSqlServer2008 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'Rbtn2019
        '
        Me.Rbtn2019.AutoSize = True
        Me.Rbtn2019.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn2019.Location = New System.Drawing.Point(118, 9)
        Me.Rbtn2019.Name = "Rbtn2019"
        Me.Rbtn2019.Size = New System.Drawing.Size(98, 19)
        Me.Rbtn2019.TabIndex = 36
        Me.Rbtn2019.Text = "2019-Express"
        Me.Rbtn2019.UseVisualStyleBackColor = True
        '
        'Rbtn2008
        '
        Me.Rbtn2008.AutoSize = True
        Me.Rbtn2008.Checked = True
        Me.Rbtn2008.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn2008.Location = New System.Drawing.Point(14, 9)
        Me.Rbtn2008.Name = "Rbtn2008"
        Me.Rbtn2008.Size = New System.Drawing.Size(98, 19)
        Me.Rbtn2008.TabIndex = 35
        Me.Rbtn2008.TabStop = True
        Me.Rbtn2008.Text = "2008-Express"
        Me.Rbtn2008.UseVisualStyleBackColor = True
        '
        'btnInstallSqlServer2019
        '
        Me.btnInstallSqlServer2019.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnInstallSqlServer2019.Appearance.Options.UseFont = True
        Me.btnInstallSqlServer2019.ImageOptions.Image = CType(resources.GetObject("btnInstallSqlServer2019.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInstallSqlServer2019.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInstallSqlServer2019.Location = New System.Drawing.Point(222, 34)
        Me.btnInstallSqlServer2019.Name = "btnInstallSqlServer2019"
        Me.btnInstallSqlServer2019.Size = New System.Drawing.Size(203, 43)
        Me.btnInstallSqlServer2019.TabIndex = 34
        Me.btnInstallSqlServer2019.Text = "1. SQL Express 2019"
        '
        'btnRCompleted
        '
        Me.btnRCompleted.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCompleted.Appearance.Options.UseFont = True
        Me.btnRCompleted.ImageOptions.Image = CType(resources.GetObject("btnRCompleted.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRCompleted.Location = New System.Drawing.Point(356, 239)
        Me.btnRCompleted.Name = "btnRCompleted"
        Me.btnRCompleted.Size = New System.Drawing.Size(162, 40)
        Me.btnRCompleted.TabIndex = 30
        Me.btnRCompleted.Text = "&Setup Completed"
        '
        'btnRTest3
        '
        Me.btnRTest3.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnRTest3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRTest3.Appearance.Options.UseFont = True
        Me.btnRTest3.Appearance.Options.UseForeColor = True
        Me.btnRTest3.ImageOptions.Image = CType(resources.GetObject("btnRTest3.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRTest3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRTest3.Location = New System.Drawing.Point(432, 179)
        Me.btnRTest3.Name = "btnRTest3"
        Me.btnRTest3.Size = New System.Drawing.Size(86, 43)
        Me.btnRTest3.TabIndex = 29
        Me.btnRTest3.Text = "TEST"
        '
        'btnRTest2
        '
        Me.btnRTest2.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnRTest2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRTest2.Appearance.Options.UseFont = True
        Me.btnRTest2.Appearance.Options.UseForeColor = True
        Me.btnRTest2.ImageOptions.Image = CType(resources.GetObject("btnRTest2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRTest2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRTest2.Location = New System.Drawing.Point(432, 107)
        Me.btnRTest2.Name = "btnRTest2"
        Me.btnRTest2.Size = New System.Drawing.Size(86, 43)
        Me.btnRTest2.TabIndex = 27
        Me.btnRTest2.Text = "TEST"
        '
        'btnRTest1
        '
        Me.btnRTest1.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnRTest1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRTest1.Appearance.Options.UseFont = True
        Me.btnRTest1.Appearance.Options.UseForeColor = True
        Me.btnRTest1.Appearance.Options.UseImage = True
        Me.btnRTest1.ImageOptions.Image = CType(resources.GetObject("btnRTest1.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRTest1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRTest1.Location = New System.Drawing.Point(432, 34)
        Me.btnRTest1.Name = "btnRTest1"
        Me.btnRTest1.Size = New System.Drawing.Size(86, 43)
        Me.btnRTest1.TabIndex = 25
        Me.btnRTest1.Text = "TEST"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(14, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(337, 14)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Note:- Wait 5 to 10 mins for Install ssms, then all SETUP complete."
        '
        'btnRSSMS
        '
        Me.btnRSSMS.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnRSSMS.Appearance.Options.UseFont = True
        Me.btnRSSMS.ImageOptions.Image = CType(resources.GetObject("btnRSSMS.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRSSMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRSSMS.Location = New System.Drawing.Point(14, 179)
        Me.btnRSSMS.Name = "btnRSSMS"
        Me.btnRSSMS.Size = New System.Drawing.Size(411, 43)
        Me.btnRSSMS.TabIndex = 28
        Me.btnRSSMS.Text = "3. Install SQL Management Studio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 14)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Note:- Wait 2 mins for DB creation, then go to next STEP: 3"
        '
        'btnCreateDB
        '
        Me.btnCreateDB.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCreateDB.Appearance.Options.UseFont = True
        Me.btnCreateDB.ImageOptions.Image = CType(resources.GetObject("btnCreateDB.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCreateDB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCreateDB.Location = New System.Drawing.Point(14, 107)
        Me.btnCreateDB.Name = "btnCreateDB"
        Me.btnCreateDB.Size = New System.Drawing.Size(411, 43)
        Me.btnCreateDB.TabIndex = 26
        Me.btnCreateDB.Text = "2. Create Demo Database"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblmsg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblmsg.Location = New System.Drawing.Point(14, 80)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(314, 14)
        Me.lblmsg.TabIndex = 31
        Me.lblmsg.Text = "Note:- Wait 3 mins for Install SQL Exp, then go to next STEP: 2"
        '
        'btnInstallSqlServer2008
        '
        Me.btnInstallSqlServer2008.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnInstallSqlServer2008.Appearance.Options.UseFont = True
        Me.btnInstallSqlServer2008.ImageOptions.Image = CType(resources.GetObject("btnInstallSqlServer2008.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInstallSqlServer2008.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInstallSqlServer2008.Location = New System.Drawing.Point(14, 34)
        Me.btnInstallSqlServer2008.Name = "btnInstallSqlServer2008"
        Me.btnInstallSqlServer2008.Size = New System.Drawing.Size(203, 43)
        Me.btnInstallSqlServer2008.TabIndex = 24
        Me.btnInstallSqlServer2008.Text = "1. SQL Express 2008"
        '
        'FrmSQLSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 289)
        Me.Controls.Add(Me.Rbtn2019)
        Me.Controls.Add(Me.Rbtn2008)
        Me.Controls.Add(Me.btnInstallSqlServer2019)
        Me.Controls.Add(Me.btnRCompleted)
        Me.Controls.Add(Me.btnRTest3)
        Me.Controls.Add(Me.btnRTest2)
        Me.Controls.Add(Me.btnRTest1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRSSMS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateDB)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.btnInstallSqlServer2008)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSQLSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Installtion Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rbtn2019 As RadioButton
    Friend WithEvents Rbtn2008 As RadioButton
    Friend WithEvents btnInstallSqlServer2019 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRCompleted As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRTest3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRTest2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRTest1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRSSMS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateDB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblmsg As Label
    Friend WithEvents btnInstallSqlServer2008 As DevExpress.XtraEditors.SimpleButton
End Class
