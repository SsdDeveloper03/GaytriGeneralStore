Imports System.Data.Sql

Public Class FrmSqlStep1

#Region "Comments"
    'Name:Tailoring
    'Created By:Smit
    'Form:FrmSqlStep1 
    'Date:02/07/2025
#End Region

#Region "Declaration"
    Dim sql_Query As String
    Dim ds As New Data.DataSet
#End Region

    Public Function CheckIntance() As Boolean
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Function

    Private Sub btnInstallSqlServer_Click(sender As Object, e As EventArgs) Handles btnInstallSqlServer.Click
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = Application.StartupPath & "\SQL\Install_SQLEXPR.bat"
        processInfo.UseShellExecute = True
        processInfo.Verb = "runas" ' Run as Administrator
        processInfo.WindowStyle = ProcessWindowStyle.Normal

        Try
            Process.Start(processInfo)
            MsgBox("SQl Express Installed Successfully.", MsgBoxStyle.Information, "Success")
            btnNext.Focus()
        Catch ex As Exception
            MsgBox("Failed to Install SQl Express" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If CheckIntance() = False Then
            MsgBox("SQL Server Express is not installed. Please install it before proceeding to the next step.", MsgBoxStyle.Exclamation)
        End If
        Me.Close()
        FrmSqlStep2.Show()
    End Sub

End Class