Public Class PingObj
    Implements IEquatable(Of PingObj)

    Public Property LinkObject As LinkObj

    Public Property BlogName As String
    Public Property PingService As String
    Public Property PingServices As String()
    Public Property Verbosity As Boolean

    Public Property Timeout As Integer
    Public Property Useragent As String


    Public Property UseProxy As Boolean
    Public Property ProxyObject As ProxyObj

    Public Function Equals1(other As PingObj) As Boolean _
    Implements IEquatable(Of PingObj).Equals

        ' Check whether the compared object is null.
        If other Is Nothing Then Return False

        ' Check whether the compared object references the same data.
        If Me Is other Then Return True

        ' Check whether the products' properties are equal.
        Return LinkObject.Equals(other.LinkObject) AndAlso PingService.Equals(other.PingService)
    End Function

    Public Overrides Function GetHashCode() As Integer

        ' Get the hash code for the Name field if it is not null.
        Dim hashProductName = LinkObject.GetHashCode()

        ' Get the hash code for the Code field.
        Dim hashProductCode = PingService.GetHashCode()

        ' Calculate the hash code for the product.
        Return hashProductName Xor hashProductCode
    End Function
End Class
