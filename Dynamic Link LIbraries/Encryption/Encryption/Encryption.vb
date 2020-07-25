Imports System.Security.Cryptography
Imports System.Management
Imports System.IO
Imports System.Text

Public Class Crypt

#Region "Declaration"

    ' TripleDESCryptoSrviceProvider for cipher enryption
    Private TripleDes As New TripleDESCryptoServiceProvider

    ' Key for Cipher Encryption
    Private EncryptionKey As String

    ' Shift for Caesar Encryption
    Private CaesarShift As Long

    ' Encrytion types for encryption
    Public Enum EncryptionType As Integer
        Cipher = 0
        Caesar = 1
        Hex = 2
        CaesarCipher = 3
        CipherCaesar = 4
        CipherHex = 5
        HexCipher = 6
        HexCaesar = 7
        CipherHexCaesar = 8
        HexCipherCaesar = 9
        CaesarCipherHex = 10
        HexCaesarCipher = 11
        MD5Hash = 12
        'CipherCaesarHex = 5
        'CaesarHexCipher = 7
    End Enum
#End Region

#Region "Initial Procedures"

    Sub New(
            Optional ByVal Key As String = Nothing,
            Optional ByVal Shift As Long = 0)

        UpdateKeyShift(Key, Shift)
    End Sub

    ' Updating Key Shift anythime 
    Public Sub UpdateKeyShift(
           Optional ByVal Key As String = "",
           Optional ByVal Shift As Long = 0)

        ' Initializing the crypto provider
        TripleDes.Key = TruncateHash(Key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)

        ' Setting key and Shift
        EncryptionKey = CStr(Key)
        If Shift > -30 Or Shift >= 65535 Then CaesarShift = CLng(Val(Shift)) Else CaesarShift = 0
    End Sub
#End Region

#Region "Cipher Encryption"

    Private Function TruncateHash(
       ByVal key As String,
       ByVal length As Integer) As Byte()

        ' Creating hash translator
        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key. 
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash. 
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Private Function CipherEncrypt(
           ByVal plaintext As String) As String

        ' Converting the plaintext string to a byte array. 
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Creating the stream. 
        Dim ms As New System.IO.MemoryStream

        ' Creating the encoder to write to the stream. 
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Using the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Converting the encrypted stream to a printable string. 
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Private Function CipherDecrypt(
           ByVal ciphertext As String) As String

        ' Converting the encrypted text string to a byte array. 
        Dim encryptedBytes() As Byte = Convert.FromBase64String(ciphertext)

        ' Creating the stream. 
        Dim ms As New System.IO.MemoryStream
        Try
            ' Creating the decoder to write to the stream. 
            Dim decStream As New CryptoStream(ms,
                TripleDes.CreateDecryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Using the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()
        Catch ex As Exception
            MsgBox("Incorrect Key", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

        ' Converting the plaintext stream to a string. 
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function

#End Region

#Region "HexEncoding"

    Private Function HexEncode(
           ByVal plaintext As String) As String

        Dim intLength As Integer = plaintext.Length
        Dim HexString As New StringBuilder(intLength * 2)

        ' Converting the strnig into a byte array
        Dim TextBytes() As Byte = System.Text.Encoding.ASCII.GetBytes(plaintext)

        '  Return null if nothing there
        If IsNothing(plaintext) Then Return ""

        Try
            'Converting to Hex from bytes
            For intCount As Integer = 0 To TextBytes.Length - 1
                HexString.AppendFormat("{0:X2}", TextBytes(intCount))
            Next
        Catch ex As Exception
            Return Nothing
        End Try

        'Converting to string
        Return HexString.ToString()
    End Function

    Private Function HexDecode(
           ByVal EncodedText As String) As String

        Dim intLength As Integer = EncodedText.Length
        Dim DecodedText As New StringBuilder(CType(intLength / 2, Integer))

        '  Return null if nothing there
        If IsNothing(EncodedText) Then Return Nothing

        Try
            '  Converting back from Hex to string
            For intCount As Integer = 0 To EncodedText.Length - 1 Step 2
                DecodedText.Append(Convert.ToChar(Byte.Parse(EncodedText.Substring(intCount, 2), Globalization.NumberStyles.HexNumber)))
            Next
        Catch ex As Exception
            Return Nothing
        End Try

        '  Converting to string
        Return DecodedText.ToString()
    End Function

#End Region

#Region "CaesarCipher"

    Private Function Evaluate(
            ByVal Value As Long) As Integer
        On Error GoTo ErrorHandler

        ' Evaluate the ASCII code
        ' This is for nothing
        Value = CLng(Value)
        Select Case Value
            Case Is < 0
                'Value = 0 - Value
        End Select

        'Error handler for ASCII value
ErrorHandler:
        If Value <= -32768 Or Value >= 65535 Then
            Value = 0
        End If
        Return Value
    End Function

    Private Function CaesarEncrypt(
            ByVal plaintext As String) As String

        On Error Resume Next
        Dim strCaesarText As New StringBuilder
        Dim AsciiText() As String = {}
        If IsNothing(plaintext) Then Return Nothing

        '  Caesar cipher using Caesar shift
        For i As Integer = 0 To plaintext.Length - 1

            ' ReDim the array
            ReDim Preserve AsciiText(i)

            ' Storing the ASCII codes for the characters into the array
            AsciiText(i) = AscW(plaintext.Substring(i, 1))

            ' Shifting the characters
            AsciiText(i) = Evaluate(AsciiText(i) + Evaluate(CaesarShift))

            ' Writing the characters into strCaeserText (StringBuilder)
            strCaesarText.Append(CChar(ChrW(AsciiText(i))))
        Next

        ' Converting to string
        Return strCaesarText.ToString
    End Function

    Private Function CaesarDecrypt(
            ByVal EncryptedText As String) As String

        On Error Resume Next
        Dim strCaesarText As New StringBuilder
        Dim AsciiText() As String = {}
        If IsNothing(EncryptedText) Then Return Nothing

        ' Decrypting Caesar cipher using shift
        For i As Integer = 0 To EncryptedText.Length - 1

            ' ReDim the array
            ReDim Preserve AsciiText(i)

            ' Storing the ASCII codes for the characters into the array
            AsciiText(i) = AscW(EncryptedText.Substring(i, 1))

            ' Shifting characters back to its original version
            AsciiText(i) = Evaluate(AsciiText(i) - Evaluate(CaesarShift))

            ' Writing into strCaeserText (StringBuilder)
            strCaesarText.Append(CChar(ChrW(AsciiText(i))))
        Next

        ' Converting to string
        Return strCaesarText.ToString()
    End Function

#End Region

#Region "MD5 Hash"

    Public Function MD5Encrypt(ByVal plainText As String) As String

        ' Creating MD5 Hash Provider, byte of string and empty Hash
        Dim objMD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim TextBytes() As Byte
        Dim Hash() As Byte

        ' Converting the string to bytes (using UTF8 encoding for unicode characters)
        TextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)

        ' Hash contents of this byte array
        Hash = objMD5.ComputeHash(TextBytes)

        ' Clear memory and MD5 Servise Provider
        objMD5.Clear()

        ' Return Hash
        Return ByteArrayToHexString(Hash)

    End Function

    Private Function ByteArrayToHexString(ByVal arrInput() As Byte) As String

        ' Creating stringbuilder to store hash
        Dim strOutput As New System.Text.StringBuilder(arrInput.Length)

        ' Converting hash to hex string
        For i As Integer = 0 To arrInput.Length - 1
            strOutput.Append(arrInput(i).ToString("X2"))
        Next

        ' Returning ToLower
        Return strOutput.ToString().ToLower

    End Function

#End Region

#Region "Main Function"
    Public Function Encrypt(
           ByVal plaintext As String,
           Optional ByVal Type As EncryptionType = EncryptionType.Cipher) As String

        If IsNothing(plaintext) Then Return Nothing
        Try
            Select Case Type
                Case EncryptionType.Caesar
                    Return CaesarEncrypt(plaintext)
                Case EncryptionType.Cipher
                    Return CipherEncrypt(plaintext)
                Case EncryptionType.Hex
                    Return HexEncode(plaintext)
                Case EncryptionType.CaesarCipher
                    Return CipherEncrypt(CaesarEncrypt(plaintext))
                Case EncryptionType.CipherCaesar
                    Return CaesarEncrypt(CipherEncrypt(plaintext))
                Case EncryptionType.CipherHex
                    Return HexEncode(CipherEncrypt(plaintext))
                Case EncryptionType.HexCaesar
                    Return CaesarEncrypt(HexEncode(plaintext))
                Case EncryptionType.HexCipher
                    Return CipherEncrypt(HexEncode(plaintext))
                Case EncryptionType.CaesarCipherHex
                    Return HexEncode(CipherEncrypt(CaesarEncrypt(plaintext)))
                Case EncryptionType.CipherHexCaesar
                    Return CaesarEncrypt(HexEncode(CipherEncrypt(plaintext)))
                Case EncryptionType.HexCaesarCipher
                    Return CipherEncrypt(CaesarEncrypt(HexEncode(plaintext)))
                Case EncryptionType.HexCipherCaesar
                    Return CaesarEncrypt(CipherEncrypt(HexEncode(plaintext)))
                Case EncryptionType.MD5Hash
                    Return MD5Encrypt(plaintext)
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Decrypt(
           ByVal ciphertext As String,
           Optional ByVal Type As EncryptionType = EncryptionType.Cipher) As String

        If IsNothing(ciphertext) Then Return Nothing
        Try
            Select Case Type
                Case EncryptionType.Caesar
                    Return CaesarDecrypt(ciphertext)
                Case EncryptionType.Cipher
                    Return CipherDecrypt(ciphertext)
                Case EncryptionType.Hex
                    Return HexDecode(ciphertext)
                Case EncryptionType.CaesarCipher
                    Return CaesarDecrypt(CipherDecrypt(ciphertext))
                Case EncryptionType.CipherCaesar
                    Return CipherDecrypt(CaesarDecrypt(ciphertext))
                Case EncryptionType.CipherHex
                    Return CipherDecrypt(HexDecode(ciphertext))
                Case EncryptionType.HexCaesar
                    Return HexDecode(CaesarDecrypt(ciphertext))
                Case EncryptionType.HexCipher
                    Return HexDecode(CipherDecrypt(ciphertext))
                Case EncryptionType.CaesarCipherHex
                    Return CaesarDecrypt(CipherDecrypt(HexDecode(ciphertext)))
                Case EncryptionType.CipherHexCaesar
                    Return CipherDecrypt(HexDecode(CaesarDecrypt(ciphertext)))
                Case EncryptionType.HexCaesarCipher
                    Return HexDecode(CaesarDecrypt(CipherDecrypt(ciphertext)))
                Case EncryptionType.HexCipherCaesar
                    Return HexDecode(CipherDecrypt(CaesarDecrypt(ciphertext)))
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region


End Class
