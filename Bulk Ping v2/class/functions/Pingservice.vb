Public Class Pingservice

    Private Shared Property Services As String() = Nothing

    Public Shared Function GetRnd() As String
        Dim rnd As New Random

        Return Services(rnd.Next(0, Services.Count - 1))
    End Function

    Public Shared Function GetAll() As String()
        Return Services
    End Function

    Public Shared Sub SetAll(ByVal sArray As String())
        Services = sArray
    End Sub

    Public Shared Function IsEmpty() As Boolean
        If Services Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function SetDefault() As Boolean
        Services = Nothing
        Services =
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
http://api.moreover.com/RPC2".Split(vbNewLine)

        Return True
    End Function

End Class
