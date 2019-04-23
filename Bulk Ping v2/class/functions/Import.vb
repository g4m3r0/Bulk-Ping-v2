Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports NLog

Public Class Import
    Private logger As Logger = LogManager.GetCurrentClassLogger()
#Region "Link"
    Public Function ValidateUrl(url As String) As Boolean
        Dim pattern As String
        pattern = "http(s)?://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?"
        If Regex.IsMatch(url, pattern) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LinkFromFile(importPath As String) As List(Of LinkObj)

        Dim tempPath = importPath
        Dim linkList As String() = File.ReadAllLines(tempPath)
        Dim links = New List(Of LinkObj)()

        Dim link As String
        Dim successful As Integer
        Dim succsessfulBacklinks As String
        Dim status As String
        Dim bcolor As Integer
        Dim time As Date = My.Computer.Clock.LocalTime

        If tempPath.Contains(".db") Then
            For Each item As String In linkList
                Try
                    Dim splitData As String()
                    splitData = Regex.Split(item, ";s;")

                    successful = CInt(splitData(0))
                    succsessfulBacklinks = CInt(splitData(1))
                    link = splitData(2)
                    status = splitData(3)
                    bcolor = CInt(splitData(4))

                    With links
                        .Add(New LinkObj() _
                                        With {.Link = link, .Successful = successful, .SuccessfulBacklinks = succsessfulBacklinks,
                                        .Update = status,
                                        .Backcolor = Color.FromArgb(bcolor)})
                    End With

                Catch ex As Exception
                    logger.Error(ex.ToString)
                End Try

            Next
        Else

            For Each item In linkList
                Try
                    link = item.TrimStart(CChar(vbLf))



                    If link = Nothing Then
                    Else

                        If link.StartsWith("http://") = False And link.StartsWith("https://") = False Then
                            link = "http://" & link
                        End If

                        If ValidateUrl(link) Then
                            With links
                                .Add(New LinkObj() _
                                        With {
                                        .Link = link,
                                        .Successful = 0,
                                        .SuccessfulBacklinks = 0,
                                        .Update = "Added " & time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")),
                                        .Backcolor = Color.SkyBlue})
                            End With
                        End If

                    End If

                Catch ex As Exception
                    logger.Error(ex.ToString)
                End Try
            Next
        End If

        Return links
    End Function

    Public Function LinkFromClipboard(linkList As String) As List(Of LinkObj)
        Dim links = New List(Of LinkObj)
        Dim time As Date = My.Computer.Clock.LocalTime
        Dim link As String

        For Each item As String In linkList.Split(CChar(vbNewLine))
            If Not item = Nothing Then
                Try
                    link = item.TrimStart(CChar(vbLf))

                    If link = Nothing Then
                    Else

                        If link.StartsWith("http://") = False And link.StartsWith("https://") = False Then
                            link = "http://" & link
                        End If

                        If ValidateUrl(link) Then
                            With links
                                .Add(New LinkObj() _
                                            With {
                                            .Link = link,
                                            .Successful = 0,
                                            .SuccessfulBacklinks = 0,
                                            .Update = "Added " & time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")),
                                            .Backcolor = Color.SkyBlue})
                            End With
                        End If
                    End If
                Catch ex As Exception
                    logger.Error(ex.ToString)
                End Try
            End If
        Next

        Return links
    End Function


#End Region

#Region "Proxy"

    Public Function ProxyFromFile(importPath As String) As List(Of ProxyObj)
        Dim proxies As List(Of ProxyObj) = New List(Of ProxyObj)
        Try
            Dim tempPath = importPath
            Dim proxyList As String() = File.ReadAllLines(tempPath)

            Dim proxy As String
            Dim port As Integer
            Dim host As String
            Dim status As String
            Dim bcolor As Integer
            Dim downCount As Integer

            Dim time As Date = My.Computer.Clock.LocalTime
            Dim proxycount = 0

            If tempPath.Contains(".db") Then
                For Each item As String In proxyList
                    Try
                        With item
                            proxy = .Split(CChar(";"))(0)
                            host = proxy.Split(CChar(":"))(0)
                            port = CInt(proxy.Split(CChar(":"))(1))
                            status = .Split(CChar(";"))(1)
                            bcolor = CInt(.Split(CChar(";"))(2))
                            downCount = CInt(.Split(CChar(";"))(3))
                        End With

                        With proxies
                            .Add(New ProxyObj() _
                                    With {.Host = host, .Port = port, .Status = status,
                                    .Backcolor = Color.FromArgb(bcolor), .downCount = downCount})
                        End With

                    Catch ex As Exception
                        logger.Error(ex.ToString)
                    End Try

                Next
            Else

                For Each item In proxyList
                    Try
                        proxy = item.Split(CChar(":"))(0).TrimStart(CChar(vbLf))
                        port = CInt(item.Split(CChar(":"))(1))

                        If Not proxy = Nothing And Not port = Nothing Then

                            With proxies
                                .Add(New ProxyObj() _
                                        With {.Host = proxy, .Port = port,
                                        .Status = "Added " &
                                        time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")),
                                        .Backcolor = Color.SkyBlue, .downCount = 0})
                            End With

                        End If

                    Catch ex As Exception
                        logger.Error(ex.ToString)
                    End Try
                Next
            End If

            Return proxies

        Catch ex As Exception
            logger.Error(ex.ToString)
            Return proxies
        End Try
    End Function

    Public Function ProxyFromClipboard(proxyList As String) As List(Of ProxyObj)
        Dim proxy As String
        Dim port As String
        Dim proxies = New List(Of ProxyObj)
        Dim time As Date = My.Computer.Clock.LocalTime

        For Each item As String In proxyList.Split(CChar(vbNewLine))

            item.Replace(vbLf, "") 'Fix the sting

            If Not item = Nothing Then
                Try
                    proxy = item.Split(CChar(":"))(0).TrimStart(CChar(vbLf))
                    port = item.Split(CChar(":"))(1)

                    If proxy = Nothing And port = Nothing Or proxy = vbLf Or proxy = vbCrLf Then
                    Else

                        proxy = item.Split(CChar(":"))(0).TrimStart(CChar(vbLf))
                        port = CInt(item.Split(CChar(":"))(1))

                        If Not proxy = Nothing And Not port = Nothing Then

                            With proxies
                                .Add(New ProxyObj() _
                                        With {.Host = proxy, .Port = port,
                                        .Status = "Added " &
                                        time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")),
                                        .Backcolor = Color.SkyBlue, .downCount = 0})
                            End With

                        End If
                    End If
                Catch ex As Exception
                    logger.Error(ex.ToString)
                End Try
            End If
        Next

        Return proxies
    End Function

#End Region


End Class
