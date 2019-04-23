Imports System.Management

Public Class Hwid
    Shared Function GetCpuId() As String
        Try
            Dim cpuInfo As String = Nothing
            Dim mc As New ManagementClass("win32_processor")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            mc.Dispose()

            For Each mo As ManagementObject In moc
                cpuInfo = mo.Properties("processorID").Value.ToString()
            Next

            Return Crypt.Sha1(cpuInfo).ToLower()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Shared Function GetSystemSerialNumber() As String
        Try
            Dim cpuInfo As String = Nothing
            Dim mc As New ManagementClass("win32_processor")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            mc.Dispose()

            For Each mo As ManagementObject In moc
                cpuInfo = mo.Properties("processorID").Value.ToString()
            Next

            Return Crypt.Sha1(GetCpuId() & "JUM").ToLower
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'Shared Function GetSystemSerialNumber() As String
    '    Try
    '        Dim wmi As Object = GetObject("WinMgmts:")
    '        Dim serialNumbers As String = String.Empty
    '        Dim motherBoards() As Object = wmi.InstancesOf("Win32_BaseBoard")
    '        For Each board As Object In motherBoards
    '            serialNumbers &= board.SerialNumber
    '        Next board
    '        Return serialNumbers
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function

End Class
