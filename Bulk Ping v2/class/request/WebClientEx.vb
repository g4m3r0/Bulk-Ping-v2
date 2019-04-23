Imports System.Net

Namespace request
    Public Class WebClientEx
        Inherits WebClient
        ' Timeout in milliseconds
        Public Property Timeout As Integer

        ''' <summary>
        ''' Sets default timeout
        ''' </summary>
        Public Sub New()
            MyBase.New()
            Timeout = 10000
        End Sub

        ''' <summary>
        ''' Sets custom timeout
        ''' </summary>
        ''' <param name="timeout">Timeout in milliseconds</param>
        Public Sub New(timeout As Integer)
            MyBase.New()
            Me.Timeout = timeout
        End Sub

        ''' <summary>
        ''' Overriding base method to set timeout
        ''' </summary>
        ''' <param name="address">Server Url</param>
        ''' <returns>A WebRequest with a timeout assigned</returns>
        Protected Overrides Function GetWebRequest(address As Uri) As WebRequest
            Dim wr As WebRequest = MyBase.GetWebRequest(address)
            wr.Timeout = Timeout
            Return wr
        End Function
    End Class
End Namespace