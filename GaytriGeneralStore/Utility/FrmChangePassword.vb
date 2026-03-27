Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmChangePassword

#Region "Declaration"
    Dim obj As New DBManager
    Dim sql_Query As String
    Dim ds As New Data.DataSet
#End Region

#Region "function"

    Public Function getOldPassword() As String
        sql_Query = "select userpwd from tbl_UserMaster where userName = N'" & loggedUser & "'"
        Return obj.ScalarExecute(sql_Query)
    End Function

#End Region

#Region "Method"

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtConfirmPwd.Text <> txtNewPwd.Text Then
            MsgBox("Password Mismatch", MsgBoxStyle.Critical)
            txtConfirmPwd.Clear()
            txtNewPwd.Clear()
            txtNewPwd.Focus()
            Exit Sub
        End If
        If txtOldPassword.Text <> getOldPassword() Then
            MsgBox("Password Mismatch", MsgBoxStyle.Critical)
            Me.Close()
            'FrmLogin.Show()
        End If
        If txtOldPassword.Text = getOldPassword() Then
            sql_Query = "update tbl_UserMaster set userpwd=N'" & txtConfirmPwd.Text & "' Where UserName = N'" & loggedUser & "'"
            obj.QueryExecute(sql_Query)
            MsgBox("Password Changed Successfully", MsgBoxStyle.Information)
            Me.Close()
            'FrmLogin.Show()
        End If
    End Sub

    Private Sub btnUpdateUsername_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateUsername.Click
        If txtConfirmUserName.Text <> txtNewUserName.Text Then
            MsgBox("Username Mismatch", MsgBoxStyle.Critical)
            txtConfirmUserName.Clear()
            txtNewUserName.Clear()
            txtNewUserName.Focus()
            Exit Sub
        End If
        If txtOldUserName.Text <> loggedUser Then
            MsgBox("Username Mismatch", MsgBoxStyle.Critical)
            Me.Close()
            'FrmLogin.Show()
        End If
        If txtOldUserName.Text = loggedUser Then
            sql_Query = "update tbl_UserMaster set UserName=N'" & txtConfirmUserName.Text & "' Where UserName = N'" & loggedUser & "'"
            obj.QueryExecute(sql_Query)
            MsgBox("Username Changed Successfully", MsgBoxStyle.Information)
            loggedUser = txtNewUserName.Text
            Me.Close()
            'FrmLogin.Show()
        End If
    End Sub

    Private Sub txtConfirmPwd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOldPassword.KeyPress, txtNewPwd.KeyPress, txtConfirmPwd.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
        'If Asc(e.KeyChar) > 32 And Asc(e.KeyChar) < 127 Then
        '    If Not ((Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
        '        e.KeyChar = Chr(0)
        '        Beep()
        '    End If
        'End If
    End Sub

    Private Sub txtOldPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOldPassword.GotFocus, txtNewPwd.GotFocus, txtConfirmPwd.GotFocus, txtOldUserName.GotFocus, txtNewUserName.GotFocus, txtConfirmUserName.GotFocus
        sender.BackColor = Color.Khaki
    End Sub

    Private Sub txtOldPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOldPassword.LostFocus, txtNewPwd.LostFocus, txtConfirmPwd.LostFocus, txtOldUserName.LostFocus, txtNewUserName.LostFocus, txtConfirmUserName.LostFocus
        sender.BackColor = Color.SkyBlue
    End Sub

    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region



End Class