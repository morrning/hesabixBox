<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoice
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
        cobPerson = New ComboBox()
        ComboBox2 = New ComboBox()
        DataGridView1 = New DataGridView()
        index = New DataGridViewTextBoxColumn()
        commodity = New DataGridViewTextBoxColumn()
        count = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        priceAll = New DataGridViewTextBoxColumn()
        btnSave = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cobPerson
        ' 
        cobPerson.FormattingEnabled = True
        cobPerson.Location = New Point(12, 34)
        cobPerson.Name = "cobPerson"
        cobPerson.Size = New Size(228, 23)
        cobPerson.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(246, 34)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(228, 23)
        ComboBox2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {index, commodity, count, price, priceAll})
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(607, 269)
        DataGridView1.TabIndex = 2
        ' 
        ' index
        ' 
        index.HeaderText = "ردیف"
        index.Name = "index"
        index.ReadOnly = True
        ' 
        ' commodity
        ' 
        commodity.HeaderText = "کالا"
        commodity.Name = "commodity"
        ' 
        ' count
        ' 
        count.HeaderText = "تعداد | مقدار"
        count.Name = "count"
        ' 
        ' price
        ' 
        price.HeaderText = "قیمت واحد"
        price.Name = "price"
        ' 
        ' priceAll
        ' 
        priceAll.HeaderText = "قیمت کل"
        priceAll.Name = "priceAll"
        priceAll.ReadOnly = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(480, 33)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 3
        btnSave.Text = "ثبت"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' FrmInvoice
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(607, 341)
        Controls.Add(btnSave)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox2)
        Controls.Add(cobPerson)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmInvoice"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "فاکتور فروش"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cobPerson As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents index As DataGridViewTextBoxColumn
    Friend WithEvents commodity As DataGridViewTextBoxColumn
    Friend WithEvents count As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents priceAll As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
End Class
