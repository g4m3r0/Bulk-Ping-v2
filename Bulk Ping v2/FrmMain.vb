Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports Amib.Threading
Imports BrightIdeasSoftware
Imports NLog
Imports Telerik.WinControls.UI

Public Class FrmMain
    Public MajorPool As New SmartThreadPool
    Public MinorPool As New SmartThreadPool

    Public Property Shutdown As Boolean

    Public Property SafeScheduleRefreshLinks As List(Of LinkObj) = New List(Of LinkObj)

    Dim exitManager As FrmExit = New FrmExit
    Private logger As Logger = LogManager.GetCurrentClassLogger()

    Public CalculateCount As Integer = 0

    Private Event FireCalculateStatus()

    Private xys As String = "Bulk Ping v2 Lite"

#Region "Form"

#Region "Delegates"
    Delegate Sub AddToFolvProxyDelegate(list As List(Of ProxyObj))
    Private Sub AddToFolvProxy(list As List(Of ProxyObj))
        Try
            If folvProxy.InvokeRequired Then
                Dim d As New AddToFolvProxyDelegate(AddressOf AddToFolvProxy)
                folvProxy.Invoke(d, list)
            Else
                SyncLock Lock.ProxyList
                    folvProxy.AddObjects(list)
                End SyncLock
            End If

            Proxy.SetProxies(GetAllObjectsFromFolvProxy)

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

    Delegate Sub AddToFolvLinkDelegate(list As List(Of LinkObj))
    Private Sub AddToFolvLink(list As List(Of LinkObj))
        Try
            If folvLink.InvokeRequired Then
                Dim d As New AddToFolvLinkDelegate(AddressOf AddToFolvLink)
                folvLink.Invoke(d, list)
            Else
                SyncLock Lock.LinkList
                    folvLink.AddObjects(list)
                End SyncLock
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

    Delegate Function GetAllObjectsFromFolvLinkDelegate() As List(Of LinkObj)
    Public Function GetAllObjectsFromFolvLink() As List(Of LinkObj)
        Dim linkObjects As New List(Of LinkObj)

        Try
            If Me.folvLink.InvokeRequired Then
                Dim d As New GetAllObjectsFromFolvLinkDelegate(AddressOf GetAllObjectsFromFolvLink)
                folvLink.Invoke(d)
            Else
                SyncLock Lock.LinkList
                    linkObjects = folvLink.Objects.Cast(Of LinkObj)().ToList()
                End SyncLock
                Return linkObjects
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return linkObjects
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Delegate Function GetTickedObjectsFromFolvLinkDelegate() As List(Of LinkObj)
    Public Function GetTickedObjectsFromFolvLink() As List(Of LinkObj)
        Dim linkObjects As New List(Of LinkObj)

        Try
            If Me.folvLink.InvokeRequired Then
                Dim d As New GetTickedObjectsFromFolvLinkDelegate(AddressOf GetTickedObjectsFromFolvLink)
                folvLink.Invoke(d)
            Else
                SyncLock Lock.LinkList
                    linkObjects = folvLink.CheckedObjects.Cast(Of LinkObj)().ToList()
                End SyncLock
                Return linkObjects
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return linkObjects
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths


    Delegate Function GetAllObjectsFromFolvProxyDelegate() As List(Of ProxyObj)
    Public Function GetAllObjectsFromFolvProxy() As List(Of ProxyObj)
        Dim proxyObjects As New List(Of ProxyObj)

        Try
            If Me.folvProxy.InvokeRequired Then
                Dim d As New GetAllObjectsFromFolvProxyDelegate(AddressOf GetAllObjectsFromFolvProxy)
                folvProxy.Invoke(d)
            Else
                SyncLock Lock.ProxyList
                    proxyObjects = folvProxy.Objects.Cast(Of ProxyObj)().ToList()
                End SyncLock
                Return proxyObjects
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return proxyObjects
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Private Delegate Sub SetRadLabelTxtInvoker(ByVal text As String, ByVal lbl As RadLabel)
    Private Sub SetRadLabelTxt(ByVal text As String, ByVal lbl As RadLabel)
        If lbl.InvokeRequired Then
            lbl.Invoke(New SetRadLabelTxtInvoker(AddressOf SetRadLabelTxt), text, lbl)
        Else
            lbl.Text = text
        End If
    End Sub
#End Region


    Public Sub New()
        InitializeComponent()

        FrmMainLoader()
    End Sub

    Private Sub FrmMainLoader()

        Stats.StopOperation = False 'Sets threadstopper to false
        Shutdown = False 'Sets closing boolean to false

        CreateColumn()

        Dim imp As New Import
        Dim iProxy As New ImportInfo
        Dim iLink As New ImportInfo

        iProxy.ImportPath = Application.StartupPath & "\data\proxy.db"
        iLink.ImportPath = Application.StartupPath & "\data\link.db"

        Try
            Settings.Load.All(Me) 'Load all settings from file, byref Me
            lCurMaxThreads.Text = "(Current max. Threads " & MajorPool.MaxThreads.ToString & ")"
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        If Version.CurrentId = Version.SoftwareLiteId Then
            MajorPool.MaxThreads = 10
            lCurMaxThreads.Text = "(Current max. Threads " & MajorPool.MaxThreads.ToString & ")"
            txtThreadsValue.Text = "10"
            Me.Text = xys 'Defines lite name
            Me.cbSettingsEnableProxies.Enabled = False
            Me.cbSettingsEnableProxies.Checked = False
            Me.RadMenuItemPingSendBacklinks.Enabled = False
        End If
        Me.cbSettingsEnableProxies.Enabled = True
        Me.RadMenuItemPingSendBacklinks.Enabled = True

        If Version.Vertified Then
        Else
            Me.Hide()
            Me.Enabled = False
            Application.Exit()
        End If

        Try
            If File.Exists(Application.StartupPath & "\data\proxy.db") Then
                MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf AddProxyFromFileThread), iProxy)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        Try
            If File.Exists(Application.StartupPath & "\data\link.db") Then
                MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf AddLinkFromFileThread), iLink)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        Try
            If File.Exists(Application.StartupPath & "\data\index_default.txt") Then
                Configs.IndexList = File.ReadAllLines(Application.StartupPath & "\data\index_default.txt")
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        Try
            If File.Exists(Application.StartupPath & "\data\keywords.db") Then
                TxtKeywords.Text = File.ReadAllText(Application.StartupPath & "\data\keywords.db")
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        Try
            If File.Exists(Application.StartupPath & "\data\services.db") Then
                TxtPingservices.Text = File.ReadAllText(Application.StartupPath & "\data\services.db")
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        If File.Exists(Application.StartupPath & "\data\useragent.txt") Then
            Useragent.Add(File.ReadAllLines(Application.StartupPath & "\data\useragent.txt"))
        End If

        Pingservice.SetAll(TxtPingservices.Text.Split(vbNewLine))
        BtnPingservicesSaveChanges.Enabled = False

        Keywords.SetAll(TxtKeywords.Text.Split(vbNewLine))
        BtnKeywordsSaveChanges.Enabled = False

        TimerRefreshStatus.Start()
        TimerProxyHandler.Start()
        If Configs.ParseProxiesFromFile Then
            TimerParseProxies.Start()
        End If

        RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
    End Sub

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' MessageBox.Show("This program is still under development with limited functionality." & vbNewLine & "Please report bugs and improvements to us.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub FrmMainUnloader()
        'Create new ExportInfo
        Dim eInfo As New ExportInfo

        'Try to shutdown all threads
        Shutdown = True

        'Stops all timers
        TimerRefreshObjects.Stop()
        TimerRefreshStatus.Stop()

        'Import all objects to eInfo
        Try
            If folvProxy.GetItemCount > 0 Then
                eInfo.ProxyObjects = GetAllObjectsFromFolvProxy()
            Else
                eInfo.ProxyObjects = New List(Of ProxyObj)
            End If

            If folvLink.GetItemCount > 0 Then
                eInfo.LinkObjects = GetAllObjectsFromFolvLink()
            Else
                eInfo.LinkObjects = New List(Of LinkObj)
            End If

            If Not TxtKeywords.Text = Nothing Then
                eInfo.Keywords = TxtKeywords.Text
            End If

            If Not TxtPingservices.Text = Nothing Then
                eInfo.PingServices = TxtPingservices.Text
            End If

            'Save all settings to xml file
            Try
                Settings.Save.All(Me) 'Save all settings to file, byref me
            Catch ex As Exception
                MsgBox(ex.ToString)
                logger.Error(ex.ToString)
            End Try

            'Hide main form
            Me.Hide()

            'Shows exithandler, byval exitInfo
            exitManager.ExitHandler(eInfo)
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = False
        FrmMainUnloader()
    End Sub

    Private Sub CreateColumn()
        Try
            Dim colProxyList(2) As OLVColumn 'Setting up columns for folv

            colProxyList(0) = New OLVColumn("Status", "Status")
            colProxyList(0).Width() = 250
            colProxyList(0).ToolTipText = "Shows if proxy Is working Or Not."

            colProxyList(1) = New OLVColumn("Host", "Host")
            colProxyList(1).Width() = 120
            colProxyList(1).ToolTipText = "Shows Proxy IPv4-Adress."

            colProxyList(2) = New OLVColumn("Port", "Port")
            colProxyList(2).Width() = 50
            colProxyList(2).ToolTipText = "Shows proxy Port."

            For i = 0 To colProxyList.Length - 1
                folvProxy.Columns.Add(colProxyList(i))
            Next

            Dim colLinkList(3) As OLVColumn

            colLinkList(0) = New OLVColumn("Url", "Link")
            colLinkList(0).Width() = 400
            colLinkList(0).ToolTipText = "Shows the url."

            colLinkList(1) = New OLVColumn("Successful Pings", "Successful")
            colLinkList(1).Width() = 100
            colLinkList(1).ToolTipText = "Shows the number of successful pings."

            colLinkList(2) = New OLVColumn("Successful Backlinks", "SuccessfulBacklinks")
            colLinkList(2).Width() = 130
            colLinkList(2).ToolTipText = "Shows the number of successful backlinks."

            colLinkList(3) = New OLVColumn("Last update", "Update")
            colLinkList(3).Width() = 170
            colLinkList(3).ToolTipText = "Shows the last update."
            colLinkList(3).FillsFreeSpace = True

            For i = 0 To colLinkList.Length - 1
                folvLink.Columns.Add(colLinkList(i))
            Next

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

#End Region

#Region "Top Buttons"

    Private Sub BtnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        Dim p As Point = PointToScreen(btnPing.Location)
        cmBtnPing.Show(p.X, p.Y + 50)
    End Sub

    Private Sub BtnImportLinks_Click(sender As Object, e As EventArgs) Handles btnImportLinks.Click
        Dim p As Point = PointToScreen(btnImportLinks.Location)
        cmBtnImport.Show(p.X, p.Y + 50)
    End Sub

    Private Sub BtnExportLinks_Click(sender As Object, e As EventArgs) Handles btnExportLinks.Click
        Dim p As Point = PointToScreen(btnExportLinks.Location)
        cmBtnExport.Show(p.X, p.Y + 50)
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim p As Point = PointToScreen(btnRemove.Location)
        cmBtnRemove.Show(p.X, p.Y + 50)
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'No context menu
        Stats.StopOperation = True
        MessageBox.Show("Shutting down all threads, please wait a moment.", "Stopping...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "Context Menu"

#Region "Ping"
    Private Sub RadMenuItemPingSendAll_Click(sender As Object, e As EventArgs) Handles RadMenuItemPingSendAll.Click
        Stats.StopOperation = False
        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf QueryPing), "All")
    End Sub

    Private Sub RadMenuItemPingSendChecked_Click(sender As Object, e As EventArgs) Handles RadMenuItemPingSendTicked.Click
        Stats.StopOperation = False
        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf QueryPing), "Ticked")
    End Sub

    Private Sub RadMenuItemPingSendNew_Click(sender As Object, e As EventArgs) Handles RadMenuItemPingSendNew.Click
        Stats.StopOperation = False
        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf QueryPing), "New")
    End Sub

    Private Function QueryPing(ByVal mode As String) As Boolean
        Try
            Dim dGetAllLinks As New GetAllObjectsFromFolvLinkDelegate(AddressOf GetAllObjectsFromFolvLink)
            Dim dGetAllProxies As New GetAllObjectsFromFolvProxyDelegate(AddressOf GetAllObjectsFromFolvProxy)
            Dim dGetTickedLinks As New GetAllObjectsFromFolvLinkDelegate(AddressOf GetTickedObjectsFromFolvLink)

            Dim pServices As String() = Nothing
            Dim pKeyword As String = Nothing
            Dim timeout As Integer
            Dim useProxy As Boolean

            '  Dim rnd As New Random

            Dim allLinks As List(Of LinkObj) = New List(Of LinkObj)
            Dim tickedLinks As List(Of LinkObj) = New List(Of LinkObj)
            Dim newLinks As List(Of LinkObj) = New List(Of LinkObj)
            Dim allProxies As List(Of ProxyObj) = New List(Of ProxyObj)
            Dim workitems As Integer = 0

            If Pingservice.IsEmpty() Then
                MessageBox.Show("You don't have any pingservice. Please add at least one and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                pServices = Pingservice.GetAll()
            End If

            If Keywords.IsEmpty() Then
                MessageBox.Show("You don't have any keyword. Please add at least one and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                pKeyword = Keywords.GetRnd()
            End If

            If Interlocked.Read(Configs.Timeout) = Nothing Then
                MessageBox.Show("You don't have set any timeout. Please set it and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                timeout = Interlocked.Read(Configs.Timeout)
            End If

            If Interlocked.Read(Configs.EnableProxies) = True Then
                allProxies = CType(folvProxy.Invoke(dGetAllProxies), List(Of ProxyObj))

                If allProxies.Count = 0 Then
                    MessageBox.Show("You don't have any proxy in your list. Please add one first and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

                Proxy.SetProxies(allProxies) 'Send all proxies to proxy class
                useProxy = Interlocked.Read(Configs.EnableProxies)
            End If

            Select Case True

                Case mode = "All"
                    allLinks = CType(folvLink.Invoke(dGetAllLinks), List(Of LinkObj))

                    For Each lnk As LinkObj In allLinks
                        Dim pingObj As New PingObj
                        pingObj.BlogName = pKeyword
                        pingObj.PingServices = pServices
                        pingObj.Timeout = timeout
                        pingObj.UseProxy = useProxy

                        If pingObj.UseProxy Then
                            pingObj.ProxyObject = Nothing
                        End If

                        pingObj.LinkObject = lnk

                        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf SendPing), pingObj)
                        'workitems += 1
                    Next

                Case mode = "Ticked"
                    tickedLinks = CType(folvLink.Invoke(dGetTickedLinks), List(Of LinkObj))

                    For Each lnk As LinkObj In tickedLinks
                        Dim pingObj As New PingObj
                        pingObj.BlogName = pKeyword
                        pingObj.PingServices = pServices
                        pingObj.Timeout = timeout
                        pingObj.UseProxy = useProxy

                        If pingObj.UseProxy Then
                            pingObj.ProxyObject = Nothing
                        End If

                        pingObj.LinkObject = lnk

                        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf SendPing), pingObj)
                        'workitems += 1
                    Next

                Case mode = "New"
                    allLinks = CType(folvLink.Invoke(dGetAllLinks), List(Of LinkObj))

                    For Each lnk As LinkObj In allLinks
                        If lnk.Backcolor.ToArgb = Color.Blue.ToArgb Then
                            Dim pingObj As New PingObj
                            pingObj.BlogName = pKeyword
                            pingObj.PingServices = pServices
                            pingObj.Timeout = timeout
                            pingObj.UseProxy = useProxy

                            If pingObj.UseProxy Then
                                pingObj.ProxyObject = Nothing
                            End If
                            pingObj.LinkObject = lnk

                            MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf SendPing), pingObj)
                            'workitems += 1
                        End If
                    Next

            End Select

            Return True
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return False
        End Try
    End Function

    Private Function SendPing(pingObj As PingObj) As String

        If Stats.StopOperation Then
            Return Nothing
        End If

        Try
            Dim time As Date = My.Computer.Clock.LocalTime

            If Version.CurrentId = Version.SoftwareId And Version.Vertified = True Then
                For Each pService As String In pingObj.PingServices
                    Dim ping As New Pinger.PingRequestor
                    pingObj.PingService = pService.TrimStart(CChar(vbLf))

                    If pingObj.UseProxy Then
                        pingObj.ProxyObject = Proxy.GetRandom()

                        If ping.PingRequest(pingObj) = True Then
                            Proxy.ResetDown(pingObj.ProxyObject)
                        Else
                            Proxy.SetDown(pingObj.ProxyObject)
                        End If
                    Else
                        ping.PingRequest(pingObj)
                    End If

                    If Stats.StopOperation Then
                        Exit For
                    End If

                Next
            Else
                Dim count As Integer = 0

                For Each pService As String In pingObj.PingServices
                    If count >= 10 Then
                        Exit For
                    Else
                        count += 1
                    End If

                    Dim ping As New Pinger.PingRequestor

                    pingObj.PingService = pService.TrimStart(CChar(vbLf))
                    ping.PingRequest(pingObj)

                    If Stats.StopOperation Then
                        Exit For
                    End If
                Next
            End If

            Return True
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return False
        End Try
    End Function

    Public Function ScheduleRefreshObject(ByVal link As LinkObj)
        SyncLock Lock.Refresh
            SafeScheduleRefreshLinks.Add(link)
        End SyncLock
    End Function

#End Region

#Region "Backlink"
    Private Sub RadMenuItemPingSendBacklinksAll_Click(sender As Object, e As EventArgs) Handles RadMenuItemPingSendBacklinksAll.Click
        Stats.StopOperation = False
        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf QueryIndex), "All")
    End Sub

    Private Sub RadMenuItemPingSendBacklinksChecked_Click(sender As Object, e As EventArgs) Handles RadMenuItemPingSendBacklinksTicked.Click
        Stats.StopOperation = False
        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf QueryIndex), "Ticked")
    End Sub

    Private Sub RadMenuItemPingSendBacklinksNew_Click(sender As Object, e As EventArgs) Handles RadMenuItemPingSendBacklinksNew.Click
        Stats.StopOperation = False
        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf QueryIndex), "New")
    End Sub

    Private Function QueryIndex(ByVal mode As String) As Boolean
        Try
            Dim dGetAllLinks As New GetAllObjectsFromFolvLinkDelegate(AddressOf GetAllObjectsFromFolvLink)
            Dim dGetAllProxies As New GetAllObjectsFromFolvProxyDelegate(AddressOf GetAllObjectsFromFolvProxy)
            Dim dGetTickedLinks As New GetAllObjectsFromFolvLinkDelegate(AddressOf GetTickedObjectsFromFolvLink)

            Dim pServices As String() = Nothing
            Dim pKeyword As String = Nothing
            Dim timeout As Integer
            Dim useProxy As Boolean

            '  Dim rnd As New Random

            Dim allLinks As List(Of LinkObj) = New List(Of LinkObj)
            Dim tickedLinks As List(Of LinkObj) = New List(Of LinkObj)
            Dim newLinks As List(Of LinkObj) = New List(Of LinkObj)
            Dim allProxies As List(Of ProxyObj) = New List(Of ProxyObj)
            Dim workitems As Integer = 0

            If Pingservice.IsEmpty() Then
                MessageBox.Show("You don't have any pingservice. Please add at least one and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            ElseIf cbPingBacklinks.Enabled = True Then
                pServices = Pingservice.GetAll()
            End If

            If Keywords.IsEmpty() Then
                MessageBox.Show("You don't have any keyword. Please add at least one and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            ElseIf cbPingBacklinks.Enabled = True Then
                pKeyword = Keywords.GetRnd()
            End If

            If Configs.IndexList.Count = 0 Then
                MessageBox.Show("Your index list is empty. Please verify your installation!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            ElseIf cbPingBacklinks.Enabled = True Then
                pKeyword = Keywords.GetRnd()
            End If

            If Interlocked.Read(Configs.Timeout) = Nothing Then
                MessageBox.Show("You don't have set any timeout. Please set it and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                timeout = Interlocked.Read(Configs.Timeout)
            End If

            If Interlocked.Read(Configs.EnableProxies) = True Then
                allProxies = CType(folvProxy.Invoke(dGetAllProxies), List(Of ProxyObj))

                If allProxies.Count = 0 Then
                    MessageBox.Show("You don't have any proxy in your list. Please add one first and restart the ping process.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

                Proxy.SetProxies(allProxies) 'Send all proxies to proxy class
                useProxy = Interlocked.Read(Configs.EnableProxies)
            End If

            Select Case True

                Case mode = "All"
                    allLinks = CType(folvLink.Invoke(dGetAllLinks), List(Of LinkObj))

                    For Each lnk As LinkObj In allLinks
                        Dim indexObj As New IndexObj

                        indexObj.Link = lnk
                        indexObj.Timeout = timeout
                        indexObj.UseProxy = useProxy

                        If useProxy Then
                            indexObj.ProxyObject = Nothing 'Use a proxy
                        Else
                            indexObj.ProxyObject = Nothing
                        End If

                        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf SendIndex), indexObj)
                    Next

                Case mode = "Ticked"
                    tickedLinks = CType(folvLink.Invoke(dGetTickedLinks), List(Of LinkObj))

                    For Each lnk As LinkObj In allLinks
                        Dim indexObj As New IndexObj

                        indexObj.Link = lnk
                        indexObj.Timeout = timeout
                        indexObj.UseProxy = useProxy

                        If useProxy Then
                            indexObj.ProxyObject = Nothing 'Use a proxy
                        Else
                            indexObj.ProxyObject = Nothing
                        End If

                        MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf SendIndex), indexObj)
                    Next

                Case mode = "New"
                    allLinks = CType(folvLink.Invoke(dGetAllLinks), List(Of LinkObj))

                    For Each lnk As LinkObj In allLinks
                        If lnk.Backcolor.ToArgb = Color.Blue.ToArgb Then
                            Dim indexObj As New IndexObj

                            indexObj.Link = lnk
                            indexObj.Timeout = timeout
                            indexObj.UseProxy = useProxy

                            If useProxy Then
                                indexObj.ProxyObject = Nothing 'Use a proxy
                            Else
                                indexObj.ProxyObject = Nothing
                            End If

                            MajorPool.QueueWorkItem(New WorkItemCallback(AddressOf SendIndex), indexObj)
                        End If
                    Next

            End Select

            Return True
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return False
        End Try
    End Function

    Private Function SendIndex(indexObj As IndexObj) As String

        If Stats.StopOperation Then
            Return Nothing
        End If

        Try
            Dim time As Date = My.Computer.Clock.LocalTime
            Dim result As String = Nothing

            If Version.CurrentId = Version.SoftwareId And Version.Vertified = True Then
                Dim index As New Backlink

                For Each link As String In Configs.IndexList
                    result = index.BacklinkRequest(link, indexObj.Link.Link, indexObj.UseProxy, indexObj.ProxyObject, indexObj.Timeout, False, indexObj.PingBacklink)

                    If result = "URL" Or result = "REDIRECT ONLY" Then
                        'Backlink created
                        indexObj.Link.SuccessfulBacklinks += 1
                        If indexObj.PingBacklink Then 'Check if user wants to ping successful backlinks

                            For i As Integer = 0 To 5 Step 1
                                Dim ping As New Pinger.PingRequestor
                                Dim pService As String = Pingservice.GetRnd()
                                Dim pKeyword As String = Keywords.GetRnd()

                                Dim pingObj As New PingObj

                                Dim linkObj As New LinkObj
                                linkObj.Link = link
                                pingObj.LinkObject = linkObj

                                pingObj.BlogName = pKeyword
                                pingObj.PingService = pService
                                pingObj.Timeout = indexObj.Timeout
                                pingObj.UseProxy = indexObj.UseProxy

                                If pingObj.UseProxy Then
                                    'Send Request using proxy
                                    pingObj.ProxyObject = Nothing
                                Else
                                    'Send Rquest without proxy
                                    pingObj.ProxyObject = Nothing
                                End If

                                If ping.PingRequest(pingObj) = "[Success]" Then 'Send ping request
                                    indexObj.Link.Successful += 1
                                End If
                            Next

                        End If
                    Else
                        'Error
                    End If

                Next
            End If

            Return True
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return False
        End Try
    End Function

#End Region

#Region "Import"

    Private Function ImportGetPathDialog() As String
        Dim importPath As String = Nothing
        Try
            Using ofdProxy As New OpenFileDialog With {.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*", .Multiselect = False, .Title = "Open a text file..."}
                If ofdProxy.ShowDialog = 1 Then
                    importPath = ofdProxy.FileName
                End If

                ofdProxy.Dispose()
            End Using

            Return importPath
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return importPath
        End Try
    End Function

    Private Sub RadMenuItemImportLinkFile_Click(sender As Object, e As EventArgs) Handles RadMenuItemImportLinkFile.Click
        Dim imp As New ImportInfo
        imp.ImportPath = ImportGetPathDialog()

        If imp.ImportPath = Nothing Then
            MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf AddLinkFromFileThread), imp)
        End If
    End Sub

    Private Function AddLinkFromFileThread(import As ImportInfo) As Object
        Dim classImport As New Import
        AddToFolvLink(classImport.LinkFromFile(import.ImportPath))

        RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
        Return True
    End Function

    Private Sub RadMenuItemImportLinkClipboard_Click(sender As Object, e As EventArgs) Handles RadMenuItemImportLinkClipboard.Click
        Dim imp As New ImportInfo

        Try
            If Clipboard.GetText <> Nothing Then
                imp.Links = Clipboard.GetText.ToString
            End If

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf AddLinkFromClipboardThread), imp)
    End Sub

    Private Function AddLinkFromClipboardThread(import As Object) As Object
        Dim imp As ImportInfo = CType(import, ImportInfo)

        Dim classImport As New Import
        AddToFolvLink(classImport.LinkFromClipboard(imp.Links))

        RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
        Return True
    End Function

    Private Sub RadMenuItemImportProxiesFile_Click(sender As Object, e As EventArgs) Handles RadMenuItemImportProxiesFile.Click
        Dim imp As New ImportInfo
        imp.ImportPath = ImportGetPathDialog()

        If imp.ImportPath = Nothing Then
            MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf AddProxyFromFileThread), imp)
        End If
    End Sub

    Private Function AddProxyFromFileThread(import As Object) As Object
        Dim imp As ImportInfo = CType(import, ImportInfo)
        Dim classImport As New Import

        Dim allProxies As List(Of ProxyObj) = New List(Of ProxyObj)
        Dim addProxies As List(Of ProxyObj) = New List(Of ProxyObj)
        Dim dupProxies As List(Of ProxyObj) = New List(Of ProxyObj)
        Dim newProxies As List(Of ProxyObj) = New List(Of ProxyObj)

        Try
            Dim dGetProxy As New GetAllObjectsFromFolvProxyDelegate(AddressOf GetAllObjectsFromFolvProxy)
            allProxies = (CType(folvProxy.Invoke(dGetProxy), List(Of ProxyObj)))

        addProxies = classImport.ProxyFromFile(imp.ImportPath)

        dupProxies = allProxies.Intersect(addProxies).ToList() 'Output duplicates of both lists
        newProxies = addProxies.Except(dupProxies).ToList() 'Remove Output duplicates from List


        AddToFolvProxy(newProxies)


        RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
            Return True

        Catch ex As Exception
            logger.Error(ex.ToString)
            Return False
        End Try
    End Function

    Private Sub RadMenuItemImportProxyClipboard_Click(sender As Object, e As EventArgs) Handles RadMenuItemImportProxyClipboard.Click
        Dim imp As New ImportInfo

        Try
            If Clipboard.GetText <> Nothing Then
                imp.Proxies = Clipboard.GetText.ToString
            End If

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf AddProxyFromClipboardThread), imp)
    End Sub

    Private Function AddProxyFromClipboardThread(import As Object) As Object
        Dim imp As ImportInfo = CType(import, ImportInfo)

        Dim classImport As New Import
        AddToFolvProxy(classImport.ProxyFromClipboard(imp.Proxies))

        RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
        Return True
    End Function
#End Region

#Region "Export"

    Public Function ExportDialog(ByVal All As Boolean, ByVal CSV As Boolean)

        Dim sfdExport As New SaveFileDialog
        Dim Time As Date = My.Computer.Clock.LocalTime
        Dim expClass As New Export
        Dim expInfo As New ExportInfo

        If CSV Then
            With sfdExport
                .AddExtension = True
                .CheckPathExists = True
                .DefaultExt = "csv"
                .AutoUpgradeEnabled = True
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .OverwritePrompt = True
                .Filter = "*.csv | *.*"
                .FilterIndex = 2
                .FileName = "Links " + Time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
            End With
        Else
            With sfdExport
                .AddExtension = True
                .CheckPathExists = True
                .DefaultExt = "txt"
                .AutoUpgradeEnabled = True
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .OverwritePrompt = True
                .Filter = "*.txt | *.*"
                .FilterIndex = 2
                .FileName = "Links " + Time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
            End With
        End If

        sfdExport.ShowDialog()

        If sfdExport.FileName <> Nothing Then
            expInfo.ExportPath = sfdExport.FileName

            If All Then
                expInfo.LinkObjects = GetAllObjectsFromFolvLink()
            Else
                expInfo.LinkObjects = GetTickedObjectsFromFolvLink()
            End If


            If CSV Then
                MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf expClass.LinkAllCsv), expInfo)
            Else
                MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf expClass.LinkAll), expInfo)
            End If
        End If
    End Function
    Private Sub RadMenuItemExportCSVAll_Click(sender As Object, e As EventArgs) Handles RadMenuItemExportCSVAll.Click
        ExportDialog(True, True)
    End Sub

    Private Sub RadMenuItemExportCSVTicked_Click(sender As Object, e As EventArgs) Handles RadMenuItemExportCSVTicked.Click
        ExportDialog(False, True)
    End Sub

    Private Sub RadMenuItemExportTxtAll_Click(sender As Object, e As EventArgs) Handles RadMenuItemExportTxtAll.Click
        ExportDialog(True, False)
    End Sub

    Private Sub RadMenuItemExportTxtTicked_Click(sender As Object, e As EventArgs) Handles RadMenuItemExportTxtTicked.Click
        ExportDialog(False, False)
    End Sub

    Private Sub RadMenuItemExportBacklinkReport_Click(sender As Object, e As EventArgs) Handles RadMenuItemExportBacklinkReport.Click

    End Sub
#End Region

#Region "Remove"
    Private Sub RadMenuItemRemoveLinkAll_Click(sender As Object, e As EventArgs) Handles RadMenuItemRemoveLinkAll.Click
        If MessageBox.Show("Are you sure to remove all links?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            folvLink.ClearObjects() 'Remove all objects from list
            folvLink.Update()
            RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
        End If
    End Sub

    Private Sub RadMenuItemRemoveLinkTicked_Click(sender As Object, e As EventArgs) Handles RadMenuItemRemoveLinkTicked.Click
        If MessageBox.Show("Are you sure to remove all ticked links?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            folvLink.RemoveObjects(folvLink.CheckedObjects) 'Remove ticked objects from list
            folvLink.Update()
            RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
        End If
    End Sub

    Private Sub RadMenuItemRemoveProxyAll_Click(sender As Object, e As EventArgs) Handles RadMenuItemRemoveProxyAll.Click
        If MessageBox.Show("Are you sure to remove all proxies?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            folvProxy.ClearObjects() 'Remove all objects from list
            folvProxy.Update()
            RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
        End If
    End Sub

    Private Sub RadMenuItemRemoveProxyTicked_Click(sender As Object, e As EventArgs) Handles RadMenuItemRemoveProxyTicked.Click
        If MessageBox.Show("Are you sure to remove all ticked proxies?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            folvProxy.RemoveObjects(folvProxy.CheckedObjects) 'Remove ticked objects from list
            folvProxy.Update()
            RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
        End If
    End Sub
#End Region

#End Region

#Region "Settings"

    Private Sub TxtThreadsValue_TextChanged(sender As Object, e As EventArgs) Handles txtThreadsValue.TextChanged
        Try
            Dim test As Integer = CInt(txtThreadsValue.Text)

            If MajorPool.MaxThreads = CInt(txtThreadsValue.Text) Then
                btnApplyThreads.Visible = False
            Else
                btnApplyThreads.Visible = True
            End If

            lCurMaxThreads.Text = "(Current max. Threads " & MajorPool.MaxThreads.ToString & ")"
        Catch ex As Exception
            txtThreadsValue.Text = "10"
            MessageBox.Show("Only numeric values allowed!", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub TxtTimeoutValue_TextChanged(sender As Object, e As EventArgs) Handles txtTimeoutValue.TextChanged
        Try
            Dim test As Integer = CInt(txtThreadsValue.Text)
            Configs.Timeout = CInt(txtTimeoutValue.Text) * 1000
        Catch ex As Exception
            txtThreadsValue.Text = "20"
            Configs.Timeout = 20000
            MessageBox.Show("Only numeric values allowed!", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BtnApplyThreads_Click(sender As Object, e As EventArgs) Handles btnApplyThreads.Click
        Try
            If Version.CurrentId = Version.SoftwareLiteId Then
                If CInt(txtThreadsValue.Text) > 10 Then
                    MajorPool.MaxThreads = 10
                    txtThreadsValue.Text = "10"
                    btnApplyThreads.Visible = False
                Else
                    MajorPool.MaxThreads = CInt(txtThreadsValue.Text)
                    btnApplyThreads.Visible = False
                End If
            Else
                MajorPool.MaxThreads = CInt(txtThreadsValue.Text)
                btnApplyThreads.Visible = False
            End If

            lCurMaxThreads.Text = "(Current max. Threads " & MajorPool.MaxThreads.ToString & ")"
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

    Private Sub CbSaveSettingsOnExitToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSaveSettingsOnExit.ToggleStateChanged
        If cbSaveSettingsOnExit.Checked = True Then
            Configs.SaveSettingsOnExit = True
        Else
            Configs.SaveSettingsOnExit = False
        End If
    End Sub

    Private Sub CbSettingsSaveLinksOnExitToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSettingsSaveLinksOnExit.ToggleStateChanged
        If cbSettingsSaveLinksOnExit.Checked = True Then
            Configs.SaveLinksOnExit = True
        Else
            Configs.SaveLinksOnExit = False
        End If
    End Sub

    Private Sub CbSettingsSaveProxiesOnExit_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSettingsSaveProxiesOnExit.ToggleStateChanged
        If cbSettingsSaveProxiesOnExit.Checked = True Then
            Configs.SaveProxiesOnExit = True
        Else
            Configs.SaveProxiesOnExit = False
        End If
    End Sub

    Private Sub CbSettingsEnableProxies_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSettingsEnableProxies.ToggleStateChanged
        If cbSettingsEnableProxies.Checked = True Then
            Configs.EnableProxies = True

            If CInt(txtTimeoutValue.Text) < 19 Then
                MessageBox.Show("If you use public proxy servers you should increase the timeout value. 20 seconds is a good value.", "Do you use public proxies?")
            End If
        Else
            Configs.EnableProxies = False
        End If
    End Sub

    Private Sub CbSettingsDeleteDownProxies_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSettingsDeleteDownProxies.ToggleStateChanged
        If cbSettingsDeleteDownProxies.Checked = True Then
            Configs.RemoveDownProxies = True
        Else
            Configs.RemoveDownProxies = False
        End If
    End Sub

    Private Sub CbSettingsEnableGridlines_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSettingsEnableGridlines.ToggleStateChanged
        If cbSettingsEnableGridlines.Checked = True Then
            folvLink.GridLines = True
            folvProxy.GridLines = True
            Configs.EnableGridlines = True
        Else
            folvLink.GridLines = False
            folvProxy.GridLines = False
            Configs.EnableGridlines = False
        End If
    End Sub

    Private Sub CbSettingsEnableLogging_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSettingsEnableLogging.ToggleStateChanged
        If cbSettingsEnableLogging.Checked = True Then
            Configs.DebugMode = True
        Else
            Configs.DebugMode = False
        End If
    End Sub

    Private Sub CbSettingsParseProxies_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbSettingsParseProxies.ToggleStateChanged
        If cbSettingsParseProxies.Checked Then
            If txtSettingsParseProxiesPath.Text = Nothing Then
                MessageBox.Show("Browse a path first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TimerParseProxies.Stop()
                cbSettingsParseProxies.Checked = False
            End If
            TimerParseProxies.Start()
            Configs.ParseProxiesFromFile = True
        Else
            TimerParseProxies.Stop()
            Configs.ParseProxiesFromFile = False
        End If
    End Sub

    Private Sub TxtSettingsParseProxiesMinutes_TextChanged(sender As Object, e As EventArgs) Handles txtSettingsParseProxiesMinutes.TextChanged
        Try
            Dim test As Integer = CInt(txtSettingsParseProxiesMinutes.Text)

            TimerParseProxies.Interval = CInt(txtSettingsParseProxiesMinutes.Text) * 60 * 1000
            Configs.ParseProxiesFromFileMin = txtSettingsParseProxiesMinutes.Text
        Catch ex As Exception
            txtSettingsParseProxiesMinutes.Text = "60"
            Configs.ParseProxiesFromFileMin = 60
            TimerParseProxies.Interval = 60 * 60 * 1000
            MessageBox.Show("Only numeric values allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSettingsParseProxiesBrowse_Click(sender As Object, e As EventArgs) Handles btnSettingsParseProxiesBrowse.Click
        Dim openPath As String = Nothing
        Try
            Using ofd As New OpenFileDialog With {.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*", .Title = "Open a text file to parse..."}
                If ofd.ShowDialog = 1 Then
                    openPath = ofd.FileName
                End If
                ofd.Dispose()
            End Using

            txtSettingsParseProxiesPath.Text = openPath
            Configs.ParseProxiesFromFilePath = openPath
        Catch ex As Exception
            MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtSettingsParseProxiesPath.Text = ""
            Configs.ParseProxiesFromFilePath = ""
            logger.Error(ex.ToString)
        End Try
    End Sub

    Private Sub BtnActivatePro_Click(sender As Object, e As EventArgs)
        My.Settings.License = Nothing
        My.Settings.Lite = False
        My.Settings.Save()

        MessageBox.Show("Please save your work and restart Proxy Buddy.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnBuyProVersion_Click(sender As Object, e As EventArgs)
        Process.Start("http://shop.gsoftwarelab.com")
    End Sub


    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start(Application.StartupPath & "\Manual.pdf")
        Catch ex As Exception
            MessageBox.Show("Manual not found. Please verify your installation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnReportBug_Click(sender As Object, e As EventArgs) Handles btnReportBug.Click
        Process.Start("https://gsoftwarelab.com/contact/")
    End Sub

    Private Sub BtnGetProVersion_Click(sender As Object, e As EventArgs) Handles btnGetProVersion.Click
        Process.Start("https://shop.gsoftwarelab.com")
    End Sub

    Private Sub BtnActivateProVersion_Click(sender As Object, e As EventArgs) Handles btnActivateProVersion.Click
        Dim result As DialogResult

        result = MessageBox.Show("Do you really want to change your license code?", "Change License", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = vbYes Then
            My.Settings.License = Nothing
            My.Settings.Lite = False
            My.Settings.Save()

            MessageBox.Show("Please save your work and restart Bulk Ping.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnUpdateAvailable_Click(sender As Object, e As EventArgs) Handles btnUpdateAvailable.Click
        FrmUpdate.Show()
    End Sub

    Private Sub BtnChangelog_Click(sender As Object, e As EventArgs) Handles btnChangelog.Click
        FrmChangelog.Show()
    End Sub

#End Region

#Region "ListView"

#End Region

#Region "Timers"
    Private Sub TimerRefreshObjects_Tick(sender As Object, e As EventArgs) Handles TimerRefreshObjects.Tick
        SyncLock Lock.Refresh
            folvLink.RefreshObjects(SafeScheduleRefreshLinks)
            SafeScheduleRefreshLinks.Clear()
        End SyncLock
    End Sub

    Private Sub TimerRefreshStatus_Tick(sender As Object, e As EventArgs) Handles TimerRefreshStatus.Tick
        Try
            Dim lPingMin As Long
            Dim lBacklinkMin As Long

            lPingMin = Math.Round(Interlocked.Read(Stats.SentPingMin) * (Interlocked.Read(calculateCount)), 0)
            lBacklinkMin = Math.Round(Interlocked.Read(Stats.SentBanklinkMin) * (Interlocked.Read(calculateCount)), 0)

            SetRadLabelTxt("Sent Pings: " & Interlocked.Read(Stats.SentPing) & " (" & CStr(lPingMin) & " /min)" & "      Successful: " & CStr(Interlocked.Read(Stats.SuccessfulPing)), lTopSentPings)
            SetRadLabelTxt("Sent Backlinks: " & Interlocked.Read(Stats.SentBanklink) & " (" & CStr(lBacklinkMin) & " /min)", lTopSentBacklinks)


            If Interlocked.Read(calculateCount) = 0 Then
                Interlocked.Exchange(calculateCount, 6)
                Interlocked.Exchange(Stats.SentPingMin, 0)
                Interlocked.Exchange(Stats.SentBanklinkMin, 0)
            Else
                Interlocked.Decrement(calculateCount)
            End If

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        RaiseEvent FireCalculateStatus()
    End Sub

    Private Function RefreshStatus() As Boolean Handles Me.FireCalculateStatus
        Try
            SetRadLabelTxt("Total Proxies: " & folvProxy.GetItemCount.ToString, lTopTotalProxies)
            SetRadLabelTxt("Total Links: " & folvLink.GetItemCount.ToString, lTopTotalLinks)
            SetRadLabelTxt("Running Thread(s): " & MajorPool.ActiveThreads.ToString, lTopRunningThreads)
            Return True
        Catch ex As Exception
            logger.Error(ex.ToString)
            Return False
        End Try
    End Function

    Private Sub TimerProxyHandler_Tick(sender As Object, e As EventArgs) Handles TimerProxyHandler.Tick
        If folvProxy.GetItemCount > 0 Then
            Dim dGetAllProxies As New GetAllObjectsFromFolvProxyDelegate(AddressOf GetAllObjectsFromFolvProxy)
            Dim allProxies As List(Of ProxyObj) = New List(Of ProxyObj)
            SyncLock Lock.ProxyList
                allProxies = CType(folvProxy.Invoke(dGetAllProxies), List(Of ProxyObj))
            End SyncLock

            If Configs.RemoveDownProxies = True Then
                If Proxy.GetDownProxies.Count = 0 Then
                    'Do nothing
                Else
                    folvProxy.RemoveObjects(Proxy.GetDownProxies)
                    Proxy.ClearDownProxies()
                    RaiseEvent FireCalculateStatus() 'Fire event to recalculate stats
                End If

                'If Proxy.GetProxies.Count = allProxies.Count Then
                '    Do nothing
                'Else
                '    Proxy.SetProxies(allProxies)
                'End If
            End If

        End If
    End Sub

    Private Sub TimerParseProxies_Tick(sender As Object, e As EventArgs) Handles TimerParseProxies.Tick
        If Configs.ParseProxiesFromFile = True Then
            Try
                Dim iproxy As New ImportInfo

                iproxy.ImportPath = Configs.ParseProxiesFromFilePath

                MinorPool.QueueWorkItem(New WorkItemCallback(AddressOf AddProxyFromFileThread), iproxy)
            Catch ex As Exception
                logger.Error(ex.ToString)
            End Try

        End If
    End Sub




#End Region

#Region "PingServices"
    Private Sub TxtPingservices_TextChanged(sender As Object, e As EventArgs) Handles TxtPingservices.TextChanged
        BtnPingservicesSaveChanges.Enabled = True
    End Sub

    Private Sub BtnPingservicesLoadDefault_Click(sender As Object, e As EventArgs) Handles BtnPingservicesLoadDefault.Click
        Pingservice.SetDefault()
        TxtPingservices.Text =
        "http://rpc.pingomatic.com/
http://rpc.twingly.com/
http://rpc.weblogs.com/RPC2
http://rpc.technorati.com/rpc/ping
http://rpc.blogrolling.com/pinger/
http://ping.feedburner.com
http://ping.syndic8.com/xmlrpc.php
http://ping.weblogalot.com/rpc.php
http://blogsearch.google.com/ping/RPC2
http://bing.com/webmaster/ping.aspx
http://xping.pubsub.com/ping
http://www.feedsubmitter.com
http://api.feedster.com/ping
http://api.moreover.com/RPC2"

        BtnPingservicesSaveChanges.Enabled = False
    End Sub

    Private Sub BtnPingservicesSaveChanges_Click(sender As Object, e As EventArgs) Handles BtnPingservicesSaveChanges.Click
        Pingservice.SetAll(TxtPingservices.Text.Split(vbNewLine))

        BtnPingservicesSaveChanges.Enabled = False
    End Sub
#End Region

#Region "Keywords"
    Private Sub TxtKeyword_TextChanged(sender As Object, e As EventArgs)
        BtnKeywordsSaveChanges.Enabled = True
    End Sub

    Private Sub BtnKeywordsLoadDefault_Click(sender As Object, e As EventArgs) Handles BtnKeywordsLoadDefault.Click
        TxtKeywords.Text = "Keyword1
Keyword2
Keyword3
Keyword4"

        Keywords.SetAll(TxtKeywords.Text.Split(vbNewLine))
        BtnKeywordsSaveChanges.Enabled = False
    End Sub

    Private Sub BtnKeywordsSaveChanges_Click(sender As Object, e As EventArgs) Handles BtnKeywordsSaveChanges.Click
        Keywords.SetAll(TxtKeywords.Text.Split(vbNewLine))

        BtnKeywordsSaveChanges.Enabled = False
    End Sub

#End Region
End Class
