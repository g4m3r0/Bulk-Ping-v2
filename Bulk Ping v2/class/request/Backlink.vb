Imports System.Net
Imports Bulk_Ping_v2.request
Imports System.Web
Imports NLog

Public Class Backlink
    Private Shared logger As Logger = LogManager.GetCurrentClassLogger()

    Public Function BacklinkRequest(ByVal BacklinkUrl As String, ByVal Url As String, Optional useProxy As Boolean = False, Optional prxObj As ProxyObj = Nothing, Optional timeout As Integer = 10000, Optional debugMode As Boolean = False, Optional pingBacklink As Boolean = False) As String

        Try
            Dim serverResponse As String = ""
            Dim result As String = ""

            Using wClient As New WebClientEx
                wClient.Headers.Add(HttpRequestHeader.UserAgent, Useragent.GetRandom)
                wClient.Timeout = timeout

                If useProxy Then
                    'Send Request using proxy
                    Dim prx As New WebProxy(prxObj.Host, prxObj.Port)
                    wClient.Proxy = prx
                Else
                    'Send Rquest without proxy
                    wClient.Proxy = Nothing
                End If

                BacklinkUrl = BacklinkUrl.Replace("yoursite.com", Url.Replace("http://", "").Replace("https://", "")) 'Replace platern with url

                serverResponse = wClient.DownloadString(BacklinkUrl)
                wClient.Dispose()
            End Using

            If serverResponse.Contains(Url) Or serverResponse.Contains(WebUtility.UrlEncode(Url)) Then
                result = "URL"
            Else
                result = "REDIRECT ONLY"
            End If

            Return result
        Catch ex As Exception
            If debugMode Then
                logger.Error(ex.ToString) 'Track error if debugmode is on
            End If

            Return "ERROR"
        End Try
    End Function


End Class
