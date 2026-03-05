Imports System.Data.SqlClient

Public Class FrmSqlStep2

#Region "Comments"
    'Name:Tailoring
    'Created By:Smit
    'Form:FrmSqlStep2 
    'Date:02/07/2025
#End Region

#Region "Declaration"
    Dim sql_Query As String
    Dim ds As New Data.DataSet
#End Region

    Public Function IsDbExists() As Boolean
        Dim connectionString As String = "Server=.\SUNRISE;Database=dbSTE_Demo;User Id=sa;Password=Ss.d@2017;"
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

    Private Sub btnCreateDB_Click(sender As Object, e As EventArgs) Handles btnCreateDB.Click
        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = Application.StartupPath & "\SQL\Tailoring_db.bat"
        processInfo.UseShellExecute = True
        processInfo.Verb = "runas" ' Run as Administrator
        processInfo.WindowStyle = ProcessWindowStyle.Normal

        Try
            Process.Start(processInfo)
            MsgBox("Database Created Successfully.", MsgBoxStyle.Information, "Success")
            btnNext.Focus()
        Catch ex As Exception
            MsgBox("Failed to create database: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If IsDbExists() = False Then
            MsgBox("SQL Server demo database is not Create. Please Create it before proceeding to the next step.", MsgBoxStyle.Exclamation)
        End If
        Me.Close()
        FrmSqlStep3.Show()
    End Sub
End Class