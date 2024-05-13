Public Class Form1

    Function checkPalindrome(text As String) As Boolean
        Dim startIndex As Integer = 0
        Dim endIndex As Integer = text.Length - 1

        While startIndex < endIndex
            If text(startIndex) <> text(endIndex) Then
                Return False
            End If
            startIndex += 1
            endIndex -= 1
        End While

        Return True
    End Function

    Function RemoveSpecialChars(text As String) As String
        Dim newString As String = ""
        For Each cha As Char In text
            If Char.IsLetterOrDigit(cha) Then
                newString &= cha
            End If
        Next
        Return newString
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim text As String = TextBox1.Text.ToLower()
        Dim processedText = RemoveSpecialChars(text)

        Dim isPalindrome As Boolean = checkPalindrome(processedText)

        If isPalindrome Then
            Label1.ForeColor = Color.LightGreen
            Label1.BackColor = Color.DarkGreen
            Label1.Text = "The string is a palindrome."
        Else
            Label1.ForeColor = Color.LightPink
            Label1.BackColor = Color.DarkRed
            Label1.Text = "The string is not a palindrome."
        End If
    End Sub
End Class
