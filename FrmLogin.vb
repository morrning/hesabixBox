Imports System.Text.Json.Nodes
Imports System.Threading

Public Class FrmLogin
    Dim api As New ApiInterface

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.token.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        statusLabel.Text = "در حال ارسال درخواست"
        My.Settings.token = TextBox1.Text.Trim.ToString
        Dim result As JsonObject = api.login(TextBox1.Text.Trim.ToString)
        If result.Count = 0 Then
            TextBox1.Text = ""
            statusLabel.Text = ""
            MsgBox("توکن وارد شده صحیح نیست", MsgBoxStyle.OkOnly, "حسابیکس")
        Else
            My.Settings.token = TextBox1.Text.Trim.ToString
            My.Forms.Form1.MenuStrip1.Enabled = True
            Dim thread As New Thread(
              Sub()
                  Me.api.syncPersons()
              End Sub
            )
            thread.Start()
            Form1.isLogin = True
            Me.Close()
        End If
    End Sub
End Class