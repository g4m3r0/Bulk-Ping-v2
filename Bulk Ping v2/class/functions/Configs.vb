Public Class Configs

    Public Shared Property StopOperation As Boolean = False

    Public Shared Property Threads As Integer = 25
    Public Shared Property Timeout As Integer = 20000


    Public Shared Property SaveSettingsOnExit As Boolean
    Public Shared Property SaveLinksOnExit As Boolean
    Public Shared Property SaveProxiesOnExit As Boolean

    Public Shared Property EnableGridlines As Boolean = False
    Public Shared Property EnableProxies As Boolean = False
    Public Shared Property DebugMode As Boolean = False
    Public Shared Property RemoveDownProxies As Boolean = False

    Public Shared Property ParseProxiesFromFile As Boolean = False
    Public Shared Property ParseProxiesFromFileMin As Integer = 60
    Public Shared Property ParseProxiesFromFilePath As String = ""

    Public Shared Property IndexList As String()

End Class
