Imports System.Text.RegularExpressions

Public Class TextBomber
    Private Function IsPhoneNumberValid(ByVal Number As String) As Boolean

        Dim PhoneValid As Boolean
        Dim PhoneNumber As String = "^[1-9]\d{2}[1-9]\d{2}\d{4}$"
        Dim ChekPhone As New Regex(PhoneNumber)
        If Not String.IsNullOrEmpty(Number) Then

            PhoneValid = ChekPhone.IsMatch(Number)
        Else
            PhoneValid = False

        End If

        Return PhoneValid
    End Function

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not IsPhoneNumberValid(txtPhoneNumber.Text) Then
            MessageBox.Show("Please enter a valid Phone Number!")
            Return
        End If


    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
    End Sub
End Class
