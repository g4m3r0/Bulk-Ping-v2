Public Class IndexObj
    Implements IEquatable(Of IndexObj)

    Public Property Link As LinkObj

    Public Property Timeout As Integer
    Public Property Useragent As String

    Public Property PingBacklink As Boolean
    Public Property UseProxy As Boolean
    Public Property ProxyObject As ProxyObj

    Public Function Equals1(other As IndexObj) As Boolean _
    Implements IEquatable(Of IndexObj).Equals

        ' Check whether the compared object is null.
        If other Is Nothing Then Return False

        ' Check whether the compared object references the same data.
        If Me Is other Then Return True

        ' Check whether the products' properties are equal.
        Return Link.Equals(other.Link)
    End Function

    Public Overrides Function GetHashCode() As Integer

        ' Get the hash code for the Name field if it is not null.
        Dim hashProductName = Link.GetHashCode()

        ' Get the hash code for the Code field.

        ' Calculate the hash code for the product.
        Return hashProductName ' Xor hashProductCode
    End Function
End Class
