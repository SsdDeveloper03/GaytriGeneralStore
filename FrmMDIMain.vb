Public Class FrmMDIMain
    Private Sub FrmMDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserRights()
        loadLedgerMaster()
        loadMiscMaster()
        loadItemMaster()
        loadTailoringItems()
        loadUISettings()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As System.Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        Panel1.Visible = False
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As System.Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            Panel1.Visible = True
        End If
    End Sub

    Private Sub FrmMDIMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dr As DialogResult
        'dr = MsgBox("Sure To Exit ?", MsgBoxStyle.YesNo, M_TitleBarText)
        dr = MsgBox("Sure To Exit ?", MsgBoxStyle.YesNo, "Sunrise Billing & Accounting Software")
        If dr = Windows.Forms.DialogResult.Yes Then
            'Update_Audit_Session()
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class
