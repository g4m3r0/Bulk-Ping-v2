Imports System.IO
Imports System.Net

Public Class FrmUpdate
    Dim iSkip As Integer = 30

    Private Sub FrmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim wc As New WebClient
            txtMessage.Text = wc.DownloadString("https://cdn.gsoftwarelab.com/bulk_ping/changelog").Replace(CChar(vbLf), CChar(vbNewLine))
            Me.Text = "Update Available!"

            TimerSkip.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Process.Start("Updater.exe")
        Me.Close()
    End Sub

    Private Sub BtnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Me.Close()
    End Sub

    Private Sub TimerSkip_Tick(sender As Object, e As EventArgs) Handles TimerSkip.Tick
        iSkip -= 1

        btnSkip.Text = "Skip (" & iSkip.ToString & ")"

        If iSkip <= 0 Then
            Me.Close()
        End If
    End Sub
End Class