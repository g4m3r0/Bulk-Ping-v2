' iliPing - (C)2010 by ilikenwf, http://www.ilikenwf.com
' * Feel free to use and/or modify this for any purpose...
' * Please pay it forward and share any improvements you make
' * Based on the XML-RPC pinging in C# class from
' * http://mboffin.com/post.aspx?id=1613 modified and broken up

Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports System.Xml.XPath
Imports System.Xml.Serialization
Imports System.Net
Imports NLog

Namespace Pinger
    ''' <summary>
    ''' Sends an XML-RPC ping for the given blog, blog url, and ping service url.
    ''' </summary>
    ''' 

    Public Class PingRequestor
        ' Implements IDisposable
        ' Public Output As String = String.Empty
        Private logger As Logger = LogManager.GetCurrentClassLogger()

        Public Function PingRequest(pingObject As PingObj) As Boolean
            Dim rState As New ResultObj

            Try
                Dim webreqPing As HttpWebRequest = DirectCast(WebRequest.Create(pingObject.PingService), HttpWebRequest)
                webreqPing.UserAgent = "WordPress 3.0.1" 'pingObject.Useragent "WordPress 3.0.1"
                webreqPing.Timeout = 20000 'pingObject.Timeout
                webreqPing.Method = "POST"
                webreqPing.ContentType = "text/xml"

                'Dim ip As String = Nothing
                'Dim port As Integer = Nothing

                'If pingObject.UseProxy Then
                '    ip = pingObject.ProxyObject.Host
                '    port = pingObject.ProxyObject.Port
                '    Dim wProxy As New WebProxy(ip, port)

                '    webreqPing.Proxy = wProxy
                'Else
                '    webreqPing.Proxy = Nothing
                'End If

                ' Get the stream for the web request
                Dim streamPingRequest As Stream = DirectCast(webreqPing.GetRequestStream(), Stream)

                ' Create an XML text writer that writes to the web request's stream
                Dim xmlPing As New XmlTextWriter(streamPingRequest, Encoding.UTF8)

                ' Build the ping, using the BlogName and BlogUrl
                xmlPing.WriteStartDocument()
                xmlPing.WriteStartElement("methodCall")
                xmlPing.WriteElementString("methodName", "weblogUpdates.extendedPing")
                xmlPing.WriteStartElement("params")
                xmlPing.WriteStartElement("param")
                xmlPing.WriteElementString("value", pingObject.BlogName)
                xmlPing.WriteEndElement()
                xmlPing.WriteStartElement("param")
                xmlPing.WriteElementString("value", pingObject.LinkObject.Link)
                'xmlPing.WriteStartElement("param")
                'xmlPing.WriteStartElement("value", pingObject.LinkObject.Link)
                'xmlPing.WriteEndElement()
                'xmlPing.WriteStartElement("param")
                'xmlPing.WriteStartElement("value", "")
                'xmlPing.WriteEndElement()
                xmlPing.WriteEndElement()
                xmlPing.WriteEndElement()
                'xmlPing.WriteEndDocument()

                '  MessageBox.Show(pingObject.LinkObject.Link.ToString)

                ' Close the XML text writer, flusing the XML to the stream
                xmlPing.Close()

                ' Send the request and store the response, then get the response's stream
                Dim webrespPing As HttpWebResponse = DirectCast(webreqPing.GetResponse(), HttpWebResponse)

                Dim streamPingResponse As New StreamReader(webrespPing.GetResponseStream())
                Dim response As New XmlDocument()

                ' Store the result in an XmlDocument for parsing if verbosity is off
                If pingObject.Verbosity = False Then
                    response.LoadXml(streamPingResponse.ReadToEnd())
                Else
                    Return streamPingResponse.ReadToEnd()
                    'Output = streamPingResponse.ReadToEnd()
                End If

                ' Close the response stream and the response itself
                streamPingResponse.Close()
                webrespPing.Close()

                If pingObject.Verbosity = False Then
                    ' Check the response to determine success or failure
                    Dim flerror As XmlElement = DirectCast(response.SelectSingleNode("//boolean"), XmlElement)
                    Select Case flerror.InnerText
                        Case "0"
                            rState.Status = "[Success]"
                            Exit Select
                        Case "false"
                            rState.Status = "[Success]"
                            Exit Select
                        Case Else
                            rState.Status = "[Failure]"
                            Exit Select
                    End Select
                End If

                rState.LinkObject = pingObject.LinkObject
                Result.CalculateResult(rState)

                If rState.Status = "[Success]" Then
                    Return True
                Else
                    Return False
                End If


            Catch ex As Exception
                ' Timeout here is somewhat generic and nonspecific
                rState.Status = "[Timeout]"
                rState.LinkObject = pingObject.LinkObject
                Result.CalculateResult(rState)

                Return False
            End Try
        End Function
    End Class
End Namespace