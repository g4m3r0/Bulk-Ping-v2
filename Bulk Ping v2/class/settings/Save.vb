Imports System.IO
Imports Nini.Config
Imports NLog

Namespace Settings
    Public Class Save
        Private Shared logger As Logger = LogManager.GetCurrentClassLogger()

        Public Shared Function All(ByRef frm As FrmMain) As Boolean
            Try
                If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\settings.ini") = False Then
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data\settings.ini", "", False)
                End If

                Dim settings As New IniConfigSource(Application.StartupPath & "\data\settings.ini")

                If settings.Configs().Count = 0 Then
                    Dim newConfig As IConfig
                    newConfig = settings.AddConfig("settings")
                End If

                '--Settings--
                'General Settings
                settings.Configs("settings").Set("txtThreadsValue", Configs.Threads)
                settings.Configs("settings").Set("txtTimeoutValue", Configs.Timeout)

                settings.Configs("settings").Set("cbSettingsSaveOnExit", Configs.SaveSettingsOnExit)
                settings.Configs("settings").Set("cbSettingsSaveProxiesOnExit", Configs.SaveProxiesOnExit)
                settings.Configs("settings").Set("cbSettingsSaveLinksOnExit", Configs.SaveLinksOnExit)

                settings.Configs("settings").Set("cbSettingsEnableGridlines", Configs.EnableGridlines)
                settings.Configs("settings").Set("cbSettingsEnableProxies", Configs.EnableProxies)
                settings.Configs("settings").Set("cbSettingsEnableLogging", Configs.DebugMode)
                settings.Configs("settings").Set("cbSettingsDeleteDownProxies", Configs.RemoveDownProxies)

                settings.Configs("settings").Set("cbSettingsParseProxies", Configs.ParseProxiesFromFile)
                settings.Configs("settings").Set("txtSettingsParseProxiesMinutes", Configs.ParseProxiesFromFileMin)
                settings.Configs("settings").Set("txtSettingsParseProxiesPath", Configs.ParseProxiesFromFilePath)

                settings.Save(Application.StartupPath & "\data\settings.ini")
                Return True
            Catch ex As Exception
                logger.Error(ex.ToString)
                Return True
            End Try
        End Function
    End Class
End Namespace