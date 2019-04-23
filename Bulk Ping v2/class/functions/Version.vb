Imports System.Net
Imports Bulk_Ping_v2.request
Imports NLog

Public Class Version

    Public Shared Property LicenseKey As String
    Public Shared Property Vertified As Boolean
    Public Shared Property CurrentVersion As String
    Public Shared Property CurrentId As String
    Private Shared logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared ReadOnly Property SoftwareVersion As String
        Get
            Return "2.0.0.0"
        End Get
    End Property


    Public Shared ReadOnly Property SoftwareId As String
        Get
            Return "3"
        End Get
    End Property

    Public Shared ReadOnly Property SoftwareLiteId As String
        Get
            Return "2"
        End Get
    End Property

    Public Shared Function Check() As Boolean

        Try
            Using wClient As New WebClientEx
                wClient.Headers.Add(HttpRequestHeader.UserAgent, "Bulk Ping " & SoftwareVersion)
                wClient.Timeout = 30000
                CurrentVersion = (wClient.DownloadString("https://cdn.gsoftwarelab.com/bulk_ping/version"))
            End Using

            If CurrentVersion = SoftwareVersion Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            logger.Error(ex.ToString)
            MessageBox.Show("Can't reach update server. Please try again later. If this error doesn't seems to be temporary please contact us.", "Server down", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function
End Class
