Imports System.Text.Json.Nodes
Imports Microsoft.VisualBasic.Devices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FrmInvoice
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FrmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim jArray As JArray = JsonConvert.DeserializeObject(Of JArray)(My.Settings.persons)
    End Sub
End Class