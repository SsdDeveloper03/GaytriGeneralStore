Imports System.Data.SqlClient

Public Class FrmSqlStep3

#Region "Comments"
    'Name:Tailoring
    'Created By:Smit
    'Form:FrmSqlStep3 
    'Date:02/07/2025
#End Region

#Region "Declaration"
    Dim sql_Query As String
    Dim ds As New Data.DataSet
#End Region

    Public Function IsSSMSExists() As Boolean
        Try
            Dim ssmsShortcutPath As String = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft SQL Server Tools 19\SQL Server Management Studio 19.lnk"
            Return IO.File.Exists(ssmsShortcutPath)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Check Table", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnCreateDB_Click(sender As Object, e As EventArgs) Handles btnCreateDB.Click
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = Application.StartupPath & "\SQL\Install_SSMS.bat"
        processInfo.UseShellExecute = True
        processInfo.Verb = "runas" ' Run as Administrator
        processInfo.WindowStyle = ProcessWindowStyle.Normal

        Try
            Process.Start(processInfo)
            MsgBox("SQL management studio Install Sucessfully.", MsgBoxStyle.Information, "Success")
            btnNext.Focus()
        Catch ex As Exception
            MsgBox("Failed to create database: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If IsSSMSExists() = False Then
            MsgBox("SQL Management studio not installed", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class