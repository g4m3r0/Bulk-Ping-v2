Imports Nini.Config
Imports NLog

Namespace Settings
    Public Class Load

        Private Shared logger As Logger = LogManager.GetCurrentClassLogger()

        Public Shared Function All(ByRef frm As FrmMain) As Boolean
            Try
                If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\settings.ini") = False Then
                    logger.Error("No settings found Code1")
                    Return True 'No settings found ending loader
                ElseIf My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\data\settings.ini").Length = 0 Then
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\data\settings.ini")
                    logger.Error("No settings found Code2")
                    Return True 'No settings found ending loader and deleting empty file
                End If

                Dim settings As New IniConfigSource(Application.StartupPath & "\data\settings.ini") 'loading settings file
                If settings.Configs().Count = 0 Then
                    logger.Error("No settings found Code3")
                    Return True 'No settings found ending loader
                Else
                    '--Settings-- load all settings to frmMain reference
                    'General Settings
                    frm.txtThreadsValue.Text = settings.Configs("settings").Get("txtThreadsValue")
                    Configs.Threads = settings.Configs("settings").Get("txtThreadsValue")
                    frm.MajorPool.MaxThreads = settings.Configs("settings").GetInt("txtThreadsValue")
                    frm.txtTimeoutValue.Text = settings.Configs("settings").Get("txtTimeoutValue") / 1000
                    Configs.Timeout = settings.Configs("settings").Get("txtTimeoutValue")

                    frm.cbSaveSettingsOnExit.Checked = settings.Configs("settings").GetBoolean("cbSettingsSaveOnExit")
                    Configs.SaveSettingsOnExit = settings.Configs("settings").GetBoolean("cbSettingsSaveOnExit")
                    frm.cbSettingsSaveProxiesOnExit.Checked = settings.Configs("settings").GetBoolean("cbSettingsSaveProxiesOnExit")
                    Configs.SaveProxiesOnExit = settings.Configs("settings").GetBoolean("cbSettingsSaveProxiesOnExit")
                    frm.cbSettingsSaveLinksOnExit.Checked = settings.Configs("settings").GetBoolean("cbSettingsSaveLinksOnExit")
                    Configs.SaveLinksOnExit = settings.Configs("settings").GetBoolean("cbSettingsSaveLinksOnExit")


                    frm.cbSettingsEnableGridlines.Checked = settings.Configs("settings").GetBoolean("cbSettingsEnableGridlines")
                    Configs.EnableGridlines = settings.Configs("settings").GetBoolean("cbSettingsEnableGridlines")
                    frm.cbSettingsEnableProxies.Checked = settings.Configs("settings").GetBoolean("cbSettingsEnableProxies")
                    Configs.EnableProxies = settings.Configs("settings").GetBoolean("cbSettingsEnableProxies")
                    frm.cbSettingsEnableLogging.Checked = settings.Configs("settings").GetBoolean("cbSettingsEnableLogging")
                    Configs.DebugMode = settings.Configs("settings").GetBoolean("cbSettingsEnableLogging")
                    frm.cbSettingsDeleteDownProxies.Checked = settings.Configs("settings").GetBoolean("cbSettingsDeleteDownProxies")
                    Configs.RemoveDownProxies = settings.Configs("settings").GetBoolean("cbSettingsDeleteDownProxies")

                    frm.txtSettingsParseProxiesMinutes.Text = settings.Configs("settings").Get("txtSettingsParseProxiesMinutes")
                    Configs.ParseProxiesFromFileMin = settings.Configs("settings").GetInt("txtSettingsParseProxiesMinutes")
                    frm.TimerParseProxies.Interval = settings.Configs("settings").GetInt("txtSettingsParseProxiesMinutes") * 60 * 1000
                    frm.txtSettingsParseProxiesPath.Text = settings.Configs("settings").Get("txtSettingsParseProxiesPath")
                    Configs.ParseProxiesFromFilePath = settings.Configs("settings").Get("txtSettingsParseProxiesPath")
                    frm.cbSettingsParseProxies.Checked = settings.Configs("settings").GetBoolean("cbSettingsParseProxies")
                    Configs.ParseProxiesFromFile = settings.Configs("settings").GetBoolean("cbSettingsParseProxies")


                    Return True
                End If
            Catch ex As Exception
                logger.Error(ex.ToString)
                Return True
            End Try
        End Function

    End Class
End Namespace