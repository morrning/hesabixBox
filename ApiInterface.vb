Imports System.Net.Http
Imports System.Text
Imports System.Text.Json.Nodes
Imports System.Text.Json.Serialization
Imports Microsoft.VisualBasic.FileIO

Public Class ApiInterface

    Public Function send(requestUri As String) As String
        Dim webClient As New Net.WebClient
        Dim result As String = webClient.DownloadString(My.Settings.apiUrl + requestUri)
        Return result
    End Function

    Public Function login(token As String) As JsonObject
        Dim webClient As New Net.WebClient
        webClient.Headers.Add("api-key", token)
        Try
            Dim result As String = webClient.DownloadString(My.Settings.apiUrl + "/api/user/check/login")
            Dim json As JsonObject = JsonObject.Parse(result)
            Return json
        Catch ex As Exception
            Return New JsonObject
        End Try
    End Function

    Public Function syncPersons() As Boolean
        Dim webClient As New Net.WebClient
        webClient.Headers.Add("api-key", My.Settings.token)
        Try
            Dim result As String = webClient.DownloadString(My.Settings.apiUrl + "/api/person/list")
            My.Settings.persons = result
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getLastPrint() As String
        Dim webClient As New Net.WebClient
        webClient.Headers.Add("api-key", My.Settings.token)
        webClient.Headers.Add("printer-key", My.Settings.printerToken)
        Return webClient.DownloadString(My.Settings.apiUrl + "/api/print/last")

        Try
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function downloadFile(ByVal name As String, ByVal type As String)
        Dim webClient As New Net.WebClient
        webClient.Headers.Add("api-key", My.Settings.token)
        Dim fileName As String = SpecialDirectories.CurrentUserApplicationData.ToString + "\" + type + ".pdf"
        webClient.DownloadFile(My.Settings.apiUrl + "/front/print/" + name, fileName)
        Try

        Catch ex As Exception

        End Try
    End Function
End Class
