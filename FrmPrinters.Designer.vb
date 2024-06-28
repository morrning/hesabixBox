<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrinters
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
        btnSave = New Button()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        TxtToken = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        txtArco = New TextBox()
        cobSell = New ComboBox()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(141, 250)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(102, 23)
        btnSave.TabIndex = 1
        btnSave.Text = "ذخیره تنظیمات"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 15)
        Label1.TabIndex = 2
        Label1.Text = "فیش صورت حساب"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 166)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(231, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 210)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(231, 23)
        ComboBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 15)
        Label2.TabIndex = 4
        Label2.Text = "فیش وصول صندوق"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 6
        Label3.Text = "توکن پرینتر ابری"
        ' 
        ' TxtToken
        ' 
        TxtToken.Location = New Point(12, 33)
        TxtToken.Name = "TxtToken"
        TxtToken.Size = New Size(229, 23)
        TxtToken.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 15)
        Label4.TabIndex = 8
        Label4.Text = "محل فایل Acrobat Reader"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 10
        Label5.Text = "فاکتور فروش"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "Acrobat.exe"
        OpenFileDialog1.Title = "انتخاب برنامه آکروبات ریدر"
        ' 
        ' txtArco
        ' 
        txtArco.Location = New Point(12, 77)
        txtArco.Name = "txtArco"
        txtArco.Size = New Size(228, 23)
        txtArco.TabIndex = 12
        ' 
        ' cobSell
        ' 
        cobSell.DropDownStyle = ComboBoxStyle.DropDownList
        cobSell.FormattingEnabled = True
        cobSell.Location = New Point(12, 122)
        cobSell.Name = "cobSell"
        cobSell.Size = New Size(231, 23)
        cobSell.TabIndex = 13
        ' 
        ' FrmPrinters
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(252, 286)
        Controls.Add(cobSell)
        Controls.Add(txtArco)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TxtToken)
        Controls.Add(Label3)
        Controls.Add(ComboBox2)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmPrinters"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        Text = "تنظیمات چاپگرها"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtToken As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtArco As TextBox
    Friend WithEvents cobSell As ComboBox
End Class
