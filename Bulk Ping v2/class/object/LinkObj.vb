Public Class LinkObj
    Implements IEquatable(Of LinkObj)

    Private _Successful As Integer
    Public Property Successful() As Integer
        Get
            Return _Successful
        End Get
        Set(ByVal value As Integer)
            _Successful = value
        End Set
    End Property

    Private _SuccessfulBacklinks As Integer
    Public Property SuccessfulBacklinks() As Integer
        Get
            Return _SuccessfulBacklinks
        End Get
        Set(ByVal value As Integer)
            _SuccessfulBacklinks = value
        End Set
    End Property

    Private _Link As String
    Public Property Link() As String
        Get
            Return _Link
        End Get
        Set(ByVal value As String)
            _Link = value
        End Set
    End Property

    Private _Update As String
    Public Property Update() As String
        Get
            Return _Update
        End Get
        Set(ByVal value As String)
            _Update = value
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

    Public Function Equals1(ByVal other As LinkObj) As Boolean _
    Implements IEquatable(Of LinkObj).Equals

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
        ' Dim hashProductCode = Port.GetHashCode()

        ' Calculate the hash code for the product.
        Return hashProductName 'Xor hashProductCode
    End Function
End Class
