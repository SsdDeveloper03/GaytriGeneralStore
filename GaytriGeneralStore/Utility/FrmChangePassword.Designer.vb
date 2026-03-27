<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewPwd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfirmPwd = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdateUsername = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfirmUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNewUserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOldUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(415, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Old Password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPassword.Location = New System.Drawing.Point(545, 39)
        Me.txtOldPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOldPassword.MaxLength = 30
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(180, 26)
        Me.txtOldPassword.TabIndex = 4
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(407, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "New Password"
        '
        'txtNewPwd
        '
        Me.txtNewPwd.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNewPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPwd.Location = New System.Drawing.Point(545, 74)
        Me.txtNewPwd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewPwd.MaxLength = 30
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.Size = New System.Drawing.Size(180, 26)
        Me.txtNewPwd.TabIndex = 5
        Me.txtNewPwd.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(383, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Confirm Password"
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.BackColor = System.Drawing.Color.SkyBlue
        Me.txtConfirmPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfirmPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPwd.Location = New System.Drawing.Point(545, 108)
        Me.txtConfirmPwd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmPwd.MaxLength = 30
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.Size = New System.Drawing.Size(180, 26)
        Me.txtConfirmPwd.TabIndex = 6
        Me.txtConfirmPwd.UseSystemPasswordChar = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(545, 143)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(181, 36)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Update Password"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdateUsername
        '
        Me.btnUpdateUsername.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUsername.Location = New System.Drawing.Point(180, 143)
        Me.btnUpdateUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdateUsername.Name = "btnUpdateUsername"
        Me.btnUpdateUsername.Size = New System.Drawing.Size(181, 36)
        Me.btnUpdateUsername.TabIndex = 3
        Me.btnUpdateUsername.Text = "Update Username"
        Me.btnUpdateUsername.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateUsername.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(19, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Confirm Username"
        '
        'txtConfirmUserName
        '
        Me.txtConfirmUserName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtConfirmUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfirmUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmUserName.Location = New System.Drawing.Point(180, 108)
        Me.txtConfirmUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmUserName.MaxLength = 30
        Me.txtConfirmUserName.Name = "txtConfirmUserName"
        Me.txtConfirmUserName.Size = New System.Drawing.Size(180, 26)
        Me.txtConfirmUserName.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(19, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "New Username"
        '
        'txtNewUserName
        '
        Me.txtNewUserName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNewUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUserName.Location = New System.Drawing.Point(180, 74)
        Me.txtNewUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewUserName.MaxLength = 30
        Me.txtNewUserName.Name = "txtNewUserName"
        Me.txtNewUserName.Size = New System.Drawing.Size(180, 26)
        Me.txtNewUserName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(19, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Old Username"
        '
        'txtOldUserName
        '
        Me.txtOldUserName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOldUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldUserName.Location = New System.Drawing.Point(180, 39)
        Me.txtOldUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOldUserName.MaxLength = 30
        Me.txtOldUserName.Name = "txtOldUserName"
        Me.txtOldUserName.Size = New System.Drawing.Size(180, 26)
        Me.txtOldUserName.TabIndex = 0
        '
        'FrmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 220)
        Me.Controls.Add(Me.btnUpdateUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConfirmUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNewUserName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOldUserName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtConfirmPwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOldPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Username / Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdateUsername As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNewUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOldUserName As System.Windows.Forms.TextBox
End Class
