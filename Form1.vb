Imports System.Net.Http
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim api As New ApiInterface
    Public isLogin As Boolean = False
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Hide()
            NotifyIcon1.ShowBalloonTip(100)
        End If
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Enabled = False
        Dim FrmLogin As New FrmLogin
        FrmLogin.StartPosition = FormStartPosition.CenterScreen
        FrmLogin.MdiParent = Me
        FrmLogin.Show()

    End Sub

    Private Sub btnCloseApplication_Click(sender As Object, e As EventArgs) Handles btnCloseApplication.Click
        Application.Exit()
    End Sub

    Private Sub btnPrinters_Click(sender As Object, e As EventArgs) Handles btnPrinters.Click
        Dim frm As New FrmPrinters
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub دربارهبرنامهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دربارهبرنامهToolStripMenuItem.Click
        Dim frm As New FrmAboutHesabix
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim file As String = api.getLastPrint()
        Dim SPrinter As String
        Dim res() As String = file.Split(",")
        Dim canPrint As Boolean = False
        If file <> "" Then
            If (res(0) = "fastSellInvoice" And My.Settings.printerFastSellInvoice <> "Off") Then
                SPrinter = My.Settings.printerFastSellInvoice
                canPrint = True
            ElseIf res(0) = "fastSellCashdesk" And My.Settings.printerFastSellCashdeskInvoice <> "Off" Then
                SPrinter = My.Settings.printerFastSellCashdeskInvoice
                canPrint = True
            ElseIf res(0) = "sell" And My.Settings.printerSell <> "Off" Then
                SPrinter = My.Settings.printerSell
                canPrint = True
            End If

            If canPrint Then
                api.downloadFile(res(1), res(0))
                Dim pathToExecutable As String = My.Settings.AcrobatPath
                Dim sReport = Application.StartupPath + res(0) + ".pdf"
                Dim starter As New ProcessStartInfo(pathToExecutable, "/t """ + sReport + """ """ + SPrinter + """")
                starter.WindowStyle = ProcessWindowStyle.Hidden
                Dim Process As New Process()
                Process.StartInfo = starter
                Process.Start()
                Process.WaitForExit(10000)
                Process.Kill()
                Process.Close()
            End If
        End If
    End Sub

    Private Sub خروجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles خروجToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
