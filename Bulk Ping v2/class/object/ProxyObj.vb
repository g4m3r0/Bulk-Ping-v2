Public Class ProxyObj
    Implements IEquatable(Of ProxyObj)

    Private _host As String
    Public Property Host() As String
        Get
            Return _host
        End Get
        Set(ByVal value As String)
            _host = value
        End Set
    End Property

    Private _port As Integer
    Public Property Port() As Integer
        Get
            Return _port
        End Get
        Set(ByVal value As Integer)
            _port = value
        End Set
    End Property

    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Private _Backcolor As Color
    Public Property Backcolor() As Color
        Get
            Return _Backcolor
        End Get
        Set(ByVal value As Color)
            _Backcolor = value
        End Set
    End Property

    Private _downCount As Integer
    Public Property downCount() As Integer
        Get
            Return _downCount
        End Get
        Set(ByVal value As Integer)
            _downCount = value
        End Set
    End Property

    Public Function Equals1(ByVal other As ProxyObj) As Boolean _
Implements IEquatable(Of ProxyObj).Equals

        ' Check whether the compared object is null.
        If other Is Nothing Then Return False

        ' Check whether the compared object references the same data.
        If Me Is other Then Return True

        ' Check whether the products' properties are equal.
        Return Host.Equals(other.Host) AndAlso downCount.Equals(other.downCount)
    End Function

    Public Overrides Function GetHashCode() As Integer

        ' Get the hash code for the Name field if it is not null.
        Dim hashProductName = Host.GetHashCode()

        ' Get the hash code for the Code field.
        Dim hashProductCode = downCount.GetHashCode()

        ' Calculate the hash code for the product.
        Return hashProductName Xor hashProductCode
    End Function
End Class