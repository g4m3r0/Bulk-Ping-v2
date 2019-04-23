Imports System.IO
Imports System.Net
Imports NLog

Public Class FrmChangelog
    Private logger As Logger = LogManager.GetCurrentClassLogger()
    Private Sub PbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        Process.Start("http://gsoftwarelab.com")
    End Sub

    Private Sub FrmChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim wc As New WebClient
            txtChangelog.Text = wc.DownloadString("http://cdn.gsoftwarelab.com/bulk_ping/changelog").Replace(CChar(vbLf), CChar(vbNewLine))

            txtChangelog.Text = File.ReadAllText(Application.StartupPath + "\Data\Changelog.txt")
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub
End Class