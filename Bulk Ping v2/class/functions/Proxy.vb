Public Class Proxy
    Private Shared allProxies As List(Of ProxyObj) = New List(Of ProxyObj)
    Private Shared RmvProxies As List(Of ProxyObj) = New List(Of ProxyObj)

    Public Shared Sub SetProxies(proxyList As List(Of ProxyObj))
        SyncLock Lock.ProxyList
            allProxies.Clear()
            allProxies.AddRange(proxyList)
        End SyncLock
    End Sub

    Public Shared Function GetProxies() As List(Of ProxyObj)
        Return allProxies
    End Function


    Public Shared Function GetRemoveProxies() As List(Of ProxyObj)
        Return RmvProxies
    End Function

    Public Shared Sub ClearRemoveProxies()
        RmvProxies.Clear()
    End Sub

    Public Shared Function GetRandom() As ProxyObj
        Dim rnd As New Random
        Dim prx As ProxyObj

        '   Dim dGetAllProxies As New FrmMain.GetAllObjectsFromFolvProxyDelegate(AddressOf FrmMain.GetAllObjectsFromFolvProxy)
        ' allProxies = CType(FrmMain.folvProxy.Invoke(dGetAllProxies), List(Of ProxyObj))

        '  SyncLock Lock.ProxyList
        'prx = allProxies(rnd.Next(0, allProxies.Count - 1))
        ' End SyncLock

        prx = allProxies(rnd.Next(0, allProxies.Count - 1)) 'get random proxy

        If prx.downCount >= 5 Then
            SetDown(prx) 'Delete proxy from list
            prx = allProxies(rnd.Next(0, allProxies.Count - 1)) 'get random proxy
        End If

        Return prx 'return random proxy
    End Function

    Public Shared Sub SetDown(dProxy As ProxyObj)
        dProxy.downCount += 1

        If dProxy.downCount = 5 Then
            'Put it on delete list
            SyncLock Lock.ProxyList
                RmvProxies.Add(dProxy)
                allProxies.Remove(dProxy)
            End SyncLock
        End If
    End Sub


    Public Shared Sub ResetDown(dProxy As ProxyObj)
        dProxy.downCount = 0
    End Sub


    Public Shared Function GetDownProxies() As List(Of ProxyObj)
        SyncLock Lock.ProxyList
            Return RmvProxies
        End SyncLock
    End Function

    Public Shared Function ClearDownProxies() As Boolean
        SyncLock Lock.ProxyList
            RmvProxies.Clear()
        End SyncLock

        Return True
    End Function
End Class
