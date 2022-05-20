Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports System.Configuration

Public Class Helper
    Public Shared client As New HttpClient
    Public Shared Function RandomString()
        Dim r As New Random()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        For i As Integer = 1 To 10
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Public Shared Function HttpRequestPost(url As String, data As Object)
        Try
            Dim response As HttpResponseMessage = client.PostAsync(ConfigurationManager.AppSettings("BaseUrl") + url, New StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")).Result
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            Return JsonConvert.DeserializeAnonymousType(
            response.Content.ReadAsStringAsync().Result,
            New With {
                Key .status = 0,
                Key .message = Nothing,
                Key .data = Nothing
        })
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Shared Function HttpRequestGet(url As String)
        Try
            Dim response As HttpResponseMessage = client.GetAsync(ConfigurationManager.AppSettings("BaseUrl") + url).Result
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Return JsonConvert.DeserializeAnonymousType(
            response.Content.ReadAsStringAsync().Result,
            New With {
                Key .status = 0,
                Key .message = Nothing,
                Key .data = Nothing
        })
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Class
