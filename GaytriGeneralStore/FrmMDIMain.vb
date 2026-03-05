Public Class FrmMDIMain


    Public Sub New()
        InitializeComponent()
        Me.IsMdiContainer = True
    End Sub



    Private Sub FrmMDIMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dr As DialogResult
        dr = MsgBox("Sure To Exit ?", MsgBoxStyle.YesNo, "Sunrise Billing & Accounting Software")
        If dr = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub



    Private Sub FrmMDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

    End Sub

    'Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
    '    For Each child As Form In Me.MdiChildren
    '        If TypeOf child Is FrmCustomerMaster Then
    '            child.Activate()
    '            Return
    '        End If
    '    Next

    '    Dim frm As New FrmCustomerMaster()
    '    frm.MdiParent = Me
    '    frm.Show()
    'End Sub
End Class