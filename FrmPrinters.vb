Public Class FrmPrinters
    Private Sub FrmPrinters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim InstalledPrinters As String

        ' Find all printers installed
        For Each InstalledPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.ComboBox1.Items.Add(InstalledPrinters)
            Me.ComboBox2.Items.Add(InstalledPrinters)
            Me.cobSell.Items.Add(InstalledPrinters)
        Next InstalledPrinters
        Me.ComboBox1.Items.Add("Off")
        Me.ComboBox1.Text = "Off"
        Me.ComboBox2.Items.Add("Off")
        Me.ComboBox2.Text = "Off"
        Me.cobSell.Items.Add("Off")
        Me.cobSell.Text = "Off"

        ' Set the combo to the first printer in the list
        Me.ComboBox1.SelectedItem = My.Settings.printerFastSellInvoice
        Me.ComboBox2.SelectedItem = My.Settings.printerFastSellCashdeskInvoice
        Me.ComboBox2.SelectedItem = My.Settings.printerSell
        Me.TxtToken.Text = My.Settings.printerToken
        Me.txtArco.Text = My.Settings.AcrobatPath
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.printerFastSellInvoice = ComboBox1.SelectedItem.ToString
        My.Settings.printerFastSellCashdeskInvoice = ComboBox2.SelectedItem.ToString
        My.Settings.printerSell = cobSell.SelectedItem.ToString
        My.Settings.printerToken = TxtToken.Text.ToString
        My.Settings.AcrobatPath = txtArco.Text.ToString
        My.Settings.Save()
        MsgBox("تنظیمات ذخیره شد", MsgBoxStyle.OkOnly, "حسابیکس")

    End Sub


    Private Sub txtArco_Click(sender As Object, e As EventArgs) Handles txtArco.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtArco.Text = OpenFileDialog1.FileName.ToString
    End Sub
End Class