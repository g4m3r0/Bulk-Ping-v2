Imports NLog
Public Class FrmExit
    'Private stateInfo As New TaskInfo
    Private logger As Logger = LogManager.GetCurrentClassLogger()

    Private Sub FrmExit_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Public Sub ExitHandler(ByVal eInfo As ExportInfo)
        Me.Show()

        pbConnection.Value1 = 10
        Delay(3)

        Try
            pbConnection.Value1 = 30
            SaveObjects(eInfo)
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

    Private Sub SaveObjects(ByVal eInfo As ExportInfo)
        Dim exportClass As New Export

        Try
            If eInfo.ProxyObjects.Count >= 0 Then
                eInfo.ExportPath = Application.StartupPath & "\data\proxy.db"
                exportClass.ProxyAll(eInfo)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
        pbConnection.Value1 = 10
        Delay(1)

        Try
            If eInfo.LinkObjects.Count >= 0 Then
                eInfo.ExportPath = Application.StartupPath & "\data\link.db"
                exportClass.LinkAll(eInfo)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
        pbConnection.Value1 = 30
        Delay(1)

        Try
            If eInfo.Keywords.Count >= 0 Then
                eInfo.ExportPath = Application.StartupPath & "\data\keywords.db"
                My.Computer.FileSystem.WriteAllText(eInfo.ExportPath, eInfo.Keywords, False)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        pbConnection.Value1 = 60
        Delay(1)

        Try
            If eInfo.PingServices.Count >= 0 Then
                eInfo.ExportPath = Application.StartupPath & "\data\services.db"
                My.Computer.FileSystem.WriteAllText(eInfo.ExportPath, eInfo.PingServices, False)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        pbConnection.Value1 = 80
        pbConnection.Text = "Closing application... Please wait!"
        Delay(2)
        pbConnection.Value1 = 100

        Unloader()
    End Sub

    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub

    Private Sub BtnForceExit_Click(sender As Object, e As EventArgs) Handles btnForceExit.Click
        Application.Exit()
    End Sub

    Private Sub Unloader()
        Application.Exit()
    End Sub
End Class