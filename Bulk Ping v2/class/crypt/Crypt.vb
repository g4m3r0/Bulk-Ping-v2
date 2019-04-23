Imports System.Security.Cryptography
Imports System.Text

Public Class Crypt
    Shared ReadOnly passphrase As String = "58hKfu2s"

    Public Shared Function Sha1(text As String) As String
        Dim sha As New SHA1CryptoServiceProvider
        Dim data As Byte()
        Dim result As Byte()
        Dim res As String = Nothing
        Dim tmp As String = Nothing

        data = Encoding.ASCII.GetBytes(text)
        result = sha.ComputeHash(data)
        sha.Dispose()

        For i = 0 To result.Length - 1
            tmp = Hex(result(i))
            If Len(tmp) = 1 Then tmp = "0" & tmp
            res += tmp
        Next

        Return res
    End Function

    Public Shared Function EncryptString(message As String) As String
        Try
            Dim results As Byte()
            Dim utf8 As New System.Text.UTF8Encoding()
            Dim hashProvider As New MD5CryptoServiceProvider()
            Dim tdesKey As Byte() = hashProvider.ComputeHash(utf8.GetBytes(passphrase))
            Dim tdesAlgorithm As New TripleDESCryptoServiceProvider()
            tdesAlgorithm.Key = tdesKey
            tdesAlgorithm.Mode = CipherMode.ECB
            tdesAlgorithm.Padding = PaddingMode.PKCS7
            Dim dataToEncrypt As Byte() = utf8.GetBytes(message)
            Try
                Dim encryptor As ICryptoTransform = tdesAlgorithm.CreateEncryptor()
                results = encryptor.TransformFinalBlock(dataToEncrypt, 0, dataToEncrypt.Length)
            Finally
                tdesAlgorithm.Dispose()
                hashProvider.Dispose()
            End Try
            Return Convert.ToBase64String(results)
        Catch ex As Exception
            Return "FALSE"
        End Try
    End Function

    Public Shared Function DecryptString(message As String) As String
        Try
            Dim results As Byte()
            Dim utf8 As New System.Text.UTF8Encoding()
            Dim hashProvider As New MD5CryptoServiceProvider()
            Dim tdesKey As Byte() = hashProvider.ComputeHash(utf8.GetBytes(passphrase))
            Dim tdesAlgorithm As New TripleDESCryptoServiceProvider()
                tdesAlgorithm.Key = tdesKey
                tdesAlgorithm.Mode = CipherMode.ECB
                tdesAlgorithm.Padding = PaddingMode.PKCS7
                Dim dataToDecrypt As Byte() = Convert.FromBase64String(message)
                Try
                    Dim decryptor As ICryptoTransform = tdesAlgorithm.CreateDecryptor()
                    results = decryptor.TransformFinalBlock(dataToDecrypt, 0, dataToDecrypt.Length)
                Finally
                    tdesAlgorithm.Dispose()
                    hashProvider.Dispose()
                End Try
                Return utf8.GetString(results)

            Catch ex As Exception
                Return "FALSE"
            End Try
        End Function
End Class