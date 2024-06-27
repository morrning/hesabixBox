<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        StatusStrip1 = New StatusStrip()
        statusLabel = New ToolStripStatusLabel()
        GroupBox1 = New GroupBox()
        StatusStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(3, 19)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.PlaceholderText = "توکن را وارد کنید"
        TextBox1.Size = New Size(337, 23)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(94, 65)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 26)
        Button1.TabIndex = 2
        Button1.Text = "ورود به حساب کاربری"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(260, 65)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 26)
        Button2.TabIndex = 3
        Button2.Text = "خروج"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {statusLabel})
        StatusStrip1.Location = New Point(0, 107)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(343, 22)
        StatusStrip1.TabIndex = 6
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' statusLabel
        ' 
        statusLabel.Name = "statusLabel"
        statusLabel.Size = New Size(0, 17)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(343, 59)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "توکن ورود"
        ' 
        ' FrmLogin
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        CancelButton = Button2
        ClientSize = New Size(343, 129)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(StatusStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmLogin"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "ورود به حسابیکس باکس"
        TopMost = True
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
End Class
