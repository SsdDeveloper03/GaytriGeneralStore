Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraSplashScreen

Public Class FrmHelpConpath

#Region "Comments"
    'Name:TailoringERP
    'Created By:smit
    'Form:FrmHelpConpath
    'Date:11/12/2024
#End Region

#Region "Declaration"
    Dim sql_query As String
    Dim ds As New Data.DataSet
    Dim edit_ins As Integer = -1
    Dim ConnString As String

#End Region

#Region "Method"

    Public Sub LoadInstance()
        Try
            cmbServerName.Items.Clear()
            Dim instances As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()

            For Each row As DataRow In instances.Rows
                Dim serverName As String = row("ServerName").ToString()
                Dim instanceName As String = row("InstanceName").ToString()

                If String.IsNullOrEmpty(instanceName) Then
                    cmbServerName.Items.Add(serverName)
                Else
                    cmbServerName.Items.Add(serverName & "\" & instanceName)
                End If
            Next

            If cmbServerName.Items.Count > 0 Then
                For Each item As String In cmbServerName.Items
                    If item.Contains("SUNRISE") Then
                        cmbServerName.SelectedItem = item
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading SQL Server instances: " & ex.Message)
        End Try
    End Sub

    Public Function IsWindowsAuth(connString) As Boolean
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Return True
            End Using
        Catch ex As SqlException
            Return False
        End Try
    End Function


    Public Function LoadData(ByVal sqlquery As String, ByVal dt As DataSet) As DataSet
        Dim servername As String = Trim(cmbServerName.Text)
        Dim dbname As String = "Master"
        Dim UserName As String = Trim(txtUsername.Text)
        Dim Pwd As String = Trim(txtUserPwd.Text)

        If cmbAuthType.SelectedIndex = 0 Then
            ConnString = "Data Source=" & Trim(cmbServerName.Text) & ";Initial catalog =" & dbname & ";Integrated Security=True"
        Else
            ConnString = "Data Source=" & servername & ";Initial catalog =" & dbname & ";User ID=" & UserName & ";Pwd=" & Pwd & ""
        End If
        Dim conpath = New SqlConnection(ConnString)
        Dim cmd As New SqlCommand()
        cmd.Connection = conpath
        cmd.CommandText = sqlquery
        cmd.CommandType = CommandType.Text
        Dim da = New SqlDataAdapter(cmd)

        Try
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Please Check ServerName Database Not Find", MessageBoxIcon.Information)
            cmbdbname.DataSource = Nothing
            cmbServerName.Focus()
            cmbServerName.DroppedDown = True
        End Try
    End Function

#End Region

#Region "Event"

    Private Sub FrmHelpConpath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenManager.CloseForm(False)
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormDescription("Load Instance Name")
        LoadInstance() 'Load Instance Name(Local/Network)
        cmbAuthType.SelectedIndex = 1
        txtUsername.Text = "sa"
        txtUserPwd.Text = pwd
        cmbdbname_Click(Nothing, Nothing) 'Get Instance DatabaseName
        btnConnect.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmbAuthType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbAuthType.Validating
        If cmbAuthType.SelectedIndex = 0 Then
            txtUsername.ReadOnly = True
            txtUserPwd.ReadOnly = True
        Else
            txtUsername.ReadOnly = False
            txtUserPwd.ReadOnly = False
        End If
    End Sub

    Private Sub cmbdbname_Click(sender As Object, e As EventArgs) Handles cmbdbname.Click
        Dim dscmb = New DataSet()
        sql_query = "Select name As dbname from sys.databases where name not in ('master','model','msdb','tempdb')"
        LoadData(sql_query, dscmb)
        If dscmb.Tables.Count > 0 Then
            cmbdbname.DataSource = dscmb.Tables(0).DefaultView
            cmbdbname.ValueMember = dscmb.Tables(0).Columns(0).ToString
            cmbdbname.DisplayMember = dscmb.Tables(0).Columns(0).ToString
        End If

        If cmbdbname.Items.Count > 0 Then 'DeafultSelect Demo Database
            For Each item As DataRowView In cmbdbname.Items
                If item(0).ToString().ToUpper().Contains("DEMO") Then
                    cmbdbname.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If cmbServerName.Text = "" Then
            MsgBox("Please Select Server Name", MsgBoxStyle.Information)
            Exit Sub
        End If

        If cmbAuthType.SelectedIndex = 1 Then
            If txtUsername.Text = "" Then
                MsgBox("Please Enter Server UserName", MsgBoxStyle.Information)
                txtUsername.Focus()
                Exit Sub
            End If
            If txtUserPwd.Text = "" Then
                MsgBox("Please Enter Server UserPassword", MsgBoxStyle.Information)
                txtUserPwd.Focus()
                Exit Sub
            End If
        End If

        If Trim(cmbdbname.Text) = "" Then
            MsgBox("Please Select DBName", MsgBoxStyle.Information)
            cmbdbname.Focus()
            Exit Sub
        End If

        If cmbAuthType.SelectedIndex = 0 Then
            ConnString = "Data Source=" & Trim(cmbServerName.Text) & ";Initial catalog =" & Trim(cmbdbname.Text) & ";Integrated Security=True"
        Else
            ConnString = "Data Source=" & Trim(cmbServerName.Text) & ";Initial catalog =" & Trim(cmbdbname.Text) & ";User ID=" & Trim(txtUsername.Text)
        End If

        If cmbAuthType.SelectedIndex = 0 Then ' Check If Windows Connection
            If IsWindowsAuth(ConnString) = False Then
                MsgBox("Connection Fail Windows Authentication", MessageBoxIcon.Information)
                cmbAuthType.Focus()
                Exit Sub
            End If
        End If

        If File.Exists(Application.StartupPath & "\conpath.ini") = False Then
            File.Create(Application.StartupPath & "\conpath.ini").Dispose()
        End If

        Dim Line As List(Of String) = File.ReadAllLines(Application.StartupPath & "\conpath.ini").ToList()
        If Line.Count > 0 Then
            Line(0) = ConnString
        Else
            Line.Add(ConnString)
        End If
        File.WriteAllLines(Application.StartupPath & "\conpath.ini", Line)

        If File.Exists(Application.StartupPath & "\Db.ini") = False Then
            File.Create(Application.StartupPath & "\Db.ini").Dispose()
        End If

        Dim dbfile As List(Of String) = File.ReadAllLines(Application.StartupPath & "\Db.ini").ToList()
        If dbfile.Count > 0 Then
            dbfile(0) = Trim(cmbdbname.Text)
        Else
            dbfile.Add(Trim(cmbdbname.Text))
        End If
        M_DbName = Trim(cmbdbname.Text)

        File.WriteAllLines(Application.StartupPath & "\Db.ini", dbfile)

        MsgBox("Conpath Updated SucessFully", MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub cmbServerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbServerName.SelectedValueChanged
        cmbdbname.DataSource = Nothing
    End Sub

#End Region

End Class