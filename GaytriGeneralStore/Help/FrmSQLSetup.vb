Imports System.Data.Sql
Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class FrmSQLSetup

#Region "Comments"
    'Name:Tailoring
    'Created By:Smit
    'Form:FrmSQLSetup
    'Date:28/08/2025
#End Region

#Region "Declaration"
    Dim sql_Query As String
    Dim ds As New Data.DataSet
#End Region

#Region "Method"

    Public Sub InstallSQLExpress(ByVal tmpfilename As String)
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = Application.StartupPath & "\SQL\" & tmpfilename
        processInfo.UseShellExecute = True
        processInfo.Verb = "runas" ' Run as Administrator
        processInfo.WindowStyle = ProcessWindowStyle.Normal

        Try
            Process.Start(processInfo)
            'MessageBox.Show("SQL Server installation completed successfully.", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SendKeys.Send("+{TAB}")
        Catch ex As Exception
            MessageBox.Show("SQL Server installation Failed." & vbCrLf & ex.Message, "Installation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Function CheckIntance() As Boolean

        SplashScreenManager.CloseForm(False)
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Check SQL Express ...")
        Try
            Dim SQLIntance As String = "SUNRISE"
            Dim instances As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()

            For Each row As DataRow In instances.Rows
                Dim instanceName As String = row("InstanceName").ToString()

                If UCase(instanceName) = UCase(SQLIntance) Then
                    Return True
                    Exit For
                End If
            Next
            Return False
            SplashScreenManager.CloseForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Function

    Public Function IsDbExists() As Boolean
        Dim connectionString As String = "Server=.\SUNRISE;Database=dbSTE_Demo;User Id=sa;Password=SunriseDb@2025;"
        Dim tableName As String = "Tbl_UserMaster"

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tableName AND TABLE_TYPE = 'BASE TABLE'"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@tableName", tableName)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Check Table", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function IsSSMSExists() As Boolean
        Try
            Dim ssmsShortcutPath As String = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft SQL Server Tools 19\SQL Server Management Studio 19.lnk"
            Return IO.File.Exists(ssmsShortcutPath)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Check Table", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region

#Region "Event"
    '============= SQL Express (2008, 2019) =======================
    Private Sub btnInstallSqlServer_Click(sender As Object, e As EventArgs) Handles btnInstallSqlServer2008.Click
        InstallSQLExpress("Install_SQLEXPR2008.bat")
    End Sub

    Private Sub btnSInstallSqlServer_Click(sender As Object, e As EventArgs) Handles btnInstallSqlServer2019.Click
        InstallSQLExpress("Install_SQLEXPR2019.bat")
    End Sub

    Private Sub btnRTest1_Click(sender As Object, e As EventArgs) Handles btnRTest1.Click
        If CheckIntance() = True Then
            MessageBox.Show("SQL Server installation completed successfully.", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("SQL Server installation Failed.", "Installation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    '==============================================================

    '======================== Create Demo Database ===================
    Private Sub btnCreateDB_Click(sender As Object, e As EventArgs) Handles btnCreateDB.Click
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = Application.StartupPath & "\SQL\Tailoring_db.bat"
        processInfo.UseShellExecute = True
        processInfo.Verb = "runas" ' Run as Administrator
        processInfo.WindowStyle = ProcessWindowStyle.Normal

        Try
            Process.Start(processInfo)
            'MessageBox.Show("SQL Server Demo database created successfully.", "Database Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SendKeys.Send("+{TAB}")
        Catch ex As Exception
            MessageBox.Show("SQL Server create database Failed." & vbCrLf & ex.Message, "Database Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnRTest2_Click(sender As Object, e As EventArgs) Handles btnRTest2.Click
        If IsDbExists() = True Then
            MessageBox.Show("SQL Server Demo database created successfully.", "Database Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("SQL Server create database Failed.", "Database Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    '==============================================================

    '====================== SQL Management Studio 2019 ============================
    Private Sub btnRSSMS_Click(sender As Object, e As EventArgs) Handles btnRSSMS.Click
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = Application.StartupPath & "\SQL\Install_SSMS2019.bat"
        processInfo.UseShellExecute = True
        processInfo.Verb = "runas" ' Run as Administrator
        processInfo.WindowStyle = ProcessWindowStyle.Normal

        Try
            Process.Start(processInfo)
            'MessageBox.Show("SQL Management studio installed successfully", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SendKeys.Send("+{TAB}")
        Catch ex As Exception
            MessageBox.Show("SQL Management studio not installed", "Installation Failed" & vbCrLf & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnRTest3_Click(sender As Object, e As EventArgs) Handles btnRTest3.Click
        If IsSSMSExists() = True Then
            MessageBox.Show("SQL Management studio installed successfully", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("SQL Management studio not installed", "Installation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    '==============================================================

    Private Sub btnRCompleted_Click(sender As Object, e As EventArgs) Handles btnRCompleted.Click
        MessageBox.Show("SQL Setup successfully" & vbCrLf & "UserName: DEMO" & vbCrLf & "Password: DEMO", "Installation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FrmLogin.Show()
        FrmLogin.txtUserName.Text = "DEMO"
        FrmLogin.txtPwd.Text = "DEMO"
        FrmLogin.txtPwd.Focus()
        Me.Close()
    End Sub

    Private Sub Rbtn2008_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn2008.CheckedChanged
        If Rbtn2008.Checked = True Then
            btnInstallSqlServer2008.Enabled = True
            btnInstallSqlServer2019.Enabled = False
        Else
            btnInstallSqlServer2008.Enabled = False
            btnInstallSqlServer2019.Enabled = True
        End If
    End Sub

#End Region
End Class