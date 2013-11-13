Public Class Decrypt7

    Public Function Decrypt(Encrypted As String) As String
        Dim XIdx As Integer
        Dim Xlat() As Object = {&H64, &H73, &H66, &H64, &H3B, &H6B, &H66, &H6F, &H41, &H2C, &H2E, &H69, &H79, &H65, &H77, &H72, &H6B, &H6C, &H64, &H4A, &H4B, &H44, &H48, &H53, &H55, &H42, &H73, &H67, &H76, &H63, &H61, &H36, &H39, &H38, &H33, &H34, &H6E, &H63, &H78, &H76, &H39, &H38, &H37, &H33, &H32, &H35, &H34, &H6B, &H3B, &H66, &H67, &H38, &H37}

        Encrypted = Trim(Encrypted)
        Decrypt = vbNullString

        If Encrypted.Length > 2 Then
            XIdx = Val(Strings.Left(Encrypted, 2))
            Encrypted = Strings.Right(Encrypted, Len(Encrypted) - 2)
            Do
                Decrypt = Decrypt & Chr(Val("&H" & Strings.Left(Encrypted, 2)) Xor Xlat(XIdx))
                If Len(Encrypted) >= 2 Then
                    XIdx = XIdx + 1
                    Encrypted = Strings.Right(Encrypted, Len(Encrypted) - 2)
                    If XIdx >= Xlat.Length Then
                        XIdx = 0
                    End If
                End If
            Loop Until (Len(Encrypted) < 2)
        End If

    End Function

    Private Sub Start1_Click(sender As Object, e As EventArgs) Handles Start1.Click
        TextBox2.Text = Decrypt(CryptBox1.Text)
    End Sub

End Class