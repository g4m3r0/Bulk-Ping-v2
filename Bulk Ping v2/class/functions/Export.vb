Imports System.Text
Imports NLog

Public Class Export
    Private logger As Logger = LogManager.GetCurrentClassLogger()
#Region "Link"

    Public Function LinkAll(exp As ExportInfo) As Boolean

        Dim export As ExportInfo = CType(exp, ExportInfo)

        Dim exportPath As String = export.ExportPath
        Dim linkObjects As List(Of LinkObj) = export.LinkObjects

        Dim links As New StringBuilder


        Try
            If exportPath.Contains(".db") Then
                For Each linkObject As LinkObj In linkObjects
                    links.AppendLine(linkObject.Successful.ToString & ";s;" & linkObject.SuccessfulBacklinks.ToString & ";s;" & linkObject.Link.ToString & ";s;" & linkObject.Update.ToString & ";s;" & CStr(linkObject.Backcolor.ToArgb))
                Next
            Else
                For Each linkObject As LinkObj In linkObjects
                    links.AppendLine(linkObject.Link)
                Next
            End If

            My.Computer.FileSystem.WriteAllText(exportPath, links.ToString, False)

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        Return Nothing
    End Function

    Public Function LinkAllCsv(exp As ExportInfo) As Object
        Dim export As ExportInfo = CType(exp, ExportInfo)

        Dim exportPath As String = export.ExportPath
        Dim linkObjects As List(Of LinkObj) = export.LinkObjects

        Dim links As New StringBuilder

        Try

            Dim splitchar As String = InputBox("Please enter the split char. Exel US default "","" Exel EU default "";""", "Splitchar", ",")

            links.AppendLine("""" & "Link" & """" & splitchar & """" & "Successful Pings" & """" & splitchar & """" & "Successful Backlinks" & """" & splitchar & """" & "Last Update" & """")

            For Each linkObject As LinkObj In linkObjects
                links.AppendLine("""" & linkObject.Link & """" & splitchar & """" & linkObject.Successful.ToString & """" & splitchar & """" & linkObject.SuccessfulBacklinks.ToString & """" & splitchar & """" & linkObject.Update & """")
            Next

            My.Computer.FileSystem.WriteAllText(exportPath, links.ToString, False)

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        Return Nothing
    End Function
#End Region


#Region "Proxy"
    Public Function ProxyAll(exp As ExportInfo) As Boolean

        Dim export As ExportInfo = CType(exp, ExportInfo)

        Dim exportPath As String = export.ExportPath
        Dim proxyObjects As List(Of ProxyObj) = export.ProxyObjects

        Dim proxies As New StringBuilder


        Try
            If exportPath.Contains(".db") Then
                For Each proxyObject As ProxyObj In proxyObjects
                    proxies.AppendLine(proxyObject.Host.ToString & ":" & proxyObject.Port.ToString & ";" & proxyObject.Status.ToString & ";" & CStr(proxyObject.Backcolor.ToArgb) & ";" & CStr(proxyObject.downCount))
                Next
            Else
                For Each proxyObject As ProxyObj In proxyObjects
                    proxies.AppendLine(proxyObject.Host.ToString & ":" & proxyObject.Port.ToString)
                Next
            End If

            My.Computer.FileSystem.WriteAllText(exportPath, proxies.ToString, False)

        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try

        Return Nothing
    End Function

#End Region

End Class
