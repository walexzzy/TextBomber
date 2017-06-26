
'Copyright(C) <2017>  <GhostSyndic@protonmail.com>

'This program Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with this program.  If Not, see < http: //www.gnu.org/licenses/>.

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
