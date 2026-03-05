Imports GaytriGeneralStore.GaytriGeneral.DB

Public Class FrmRunQuery

#Region "Declaration"
    Dim obj As New DBManager
#End Region

#Region "Events"
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Try
            obj.QueryExecute(txtQuery.Text)
            MsgBox("Done", MsgBoxStyle.Information)
            txtQuery.Focus()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

#End Region

End Class