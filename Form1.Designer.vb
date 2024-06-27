<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        اصلیToolStripMenuItem = New ToolStripMenuItem()
        خروجToolStripMenuItem = New ToolStripMenuItem()
        btnCloseApplication = New ToolStripMenuItem()
        تنظیماتToolStripMenuItem = New ToolStripMenuItem()
        btnPrinters = New ToolStripMenuItem()
        دربارهToolStripMenuItem = New ToolStripMenuItem()
        دربارهبرنامهToolStripMenuItem = New ToolStripMenuItem()
        NotifyIcon1 = New NotifyIcon(components)
        StatusStrip1 = New StatusStrip()
        statusLabel = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.Items.AddRange(New ToolStripItem() {اصلیToolStripMenuItem, تنظیماتToolStripMenuItem, دربارهToolStripMenuItem})
        MenuStrip1.Name = "MenuStrip1"
        ' 
        ' اصلیToolStripMenuItem
        ' 
        resources.ApplyResources(اصلیToolStripMenuItem, "اصلیToolStripMenuItem")
        اصلیToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {خروجToolStripMenuItem, btnCloseApplication})
        اصلیToolStripMenuItem.Name = "اصلیToolStripMenuItem"
        ' 
        ' خروجToolStripMenuItem
        ' 
        resources.ApplyResources(خروجToolStripMenuItem, "خروجToolStripMenuItem")
        خروجToolStripMenuItem.Name = "خروجToolStripMenuItem"
        ' 
        ' btnCloseApplication
        ' 
        resources.ApplyResources(btnCloseApplication, "btnCloseApplication")
        btnCloseApplication.Name = "btnCloseApplication"
        ' 
        ' تنظیماتToolStripMenuItem
        ' 
        resources.ApplyResources(تنظیماتToolStripMenuItem, "تنظیماتToolStripMenuItem")
        تنظیماتToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {btnPrinters})
        تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem"
        ' 
        ' btnPrinters
        ' 
        resources.ApplyResources(btnPrinters, "btnPrinters")
        btnPrinters.Name = "btnPrinters"
        ' 
        ' دربارهToolStripMenuItem
        ' 
        resources.ApplyResources(دربارهToolStripMenuItem, "دربارهToolStripMenuItem")
        دربارهToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {دربارهبرنامهToolStripMenuItem})
        دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem"
        ' 
        ' دربارهبرنامهToolStripMenuItem
        ' 
        resources.ApplyResources(دربارهبرنامهToolStripMenuItem, "دربارهبرنامهToolStripMenuItem")
        دربارهبرنامهToolStripMenuItem.Name = "دربارهبرنامهToolStripMenuItem"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        resources.ApplyResources(NotifyIcon1, "NotifyIcon1")
        ' 
        ' StatusStrip1
        ' 
        resources.ApplyResources(StatusStrip1, "StatusStrip1")
        StatusStrip1.Items.AddRange(New ToolStripItem() {statusLabel, ToolStripStatusLabel1})
        StatusStrip1.Name = "StatusStrip1"
        ' 
        ' statusLabel
        ' 
        resources.ApplyResources(statusLabel, "statusLabel")
        statusLabel.Name = "statusLabel"
        ' 
        ' ToolStripStatusLabel1
        ' 
        resources.ApplyResources(ToolStripStatusLabel1, "ToolStripStatusLabel1")
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents اصلیToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents خروجToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCloseApplication As ToolStripMenuItem
    Friend WithEvents تنظیماتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPrinters As ToolStripMenuItem
    Friend WithEvents دربارهToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents دربارهبرنامهToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel

End Class
