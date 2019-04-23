Public Class BacklinkObj
    Implements IEquatable(Of BacklinkObj)

    Private _Filename As String
    Public Property Filename() As String
        Get
            Return _Filename
        End Get
        Set(ByVal value As String)
            _Filename = value
        End Set
    End Property

    Private _Source As String
    Public Property Source() As String
        Get
            Return _Source
        End Get
        Set(ByVal value As String)
            _Source = value
        End Set
    End Property


    Private _Links As Dictionary(Of String, String)
    Public Property Links() As Dictionary(Of String, String)
        Get
            Return _Links
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            _Links = value
        End Set
    End Property

    Public Function Equals1(ByVal other As BacklinkObj) As Boolean _
    Implements IEquatable(Of BacklinkObj).Equals

        ' Check whether the compared object is null.
        If other Is Nothing Then Return False

        ' Check whether the compared object references the same data.
        If Me Is other Then Return True

        ' Check whether the products' properties are equal.
        Return Filename.Equals(other.Filename)
    End Function

    Public Overrides Function GetHashCode() As Integer

        ' Get the hash code for the Name field if it is not null.
        'Dim hashProductName =

        ' Get the hash code for the Code field.
        'Dim hashProductCode = Port.GetHashCode()

        ' Calculate the hash code for the product.
        Return Filename.GetHashCode() 'Xor hashProductCode
    End Function
End Class
