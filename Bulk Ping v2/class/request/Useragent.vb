Public Class Useragent
    Protected Shared Useragents As New List(Of String)

    Public Shared Function Add(agents As String()) As Boolean
        Useragents.AddRange(agents)
        Return True
    End Function

    Public Shared Function GetRandom() As String
        If Useragents.Count = 0 Then
            Return "WordPress 3.0.1"
        Else
            Dim rnd As New Random
            Return Useragents(rnd.Next(0, Useragents.Count))
        End If
    End Function
End Class
