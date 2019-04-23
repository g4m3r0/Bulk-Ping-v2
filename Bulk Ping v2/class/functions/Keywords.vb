Public Class Keywords
    Public Shared Keywords As String() = Nothing

    Public Shared Function GetRnd() As String
        Dim rnd As New Random

        Return Keywords(rnd.Next(0, Keywords.Count - 1))
    End Function

    Public Shared Function GetAll() As String()
        Return Keywords
    End Function

    Public Shared Sub SetAll(ByVal sArray As String())
        Keywords = sArray
    End Sub

    Public Shared Function IsEmpty() As Boolean
        If Keywords Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
