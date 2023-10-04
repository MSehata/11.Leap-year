Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Function IsLeapYear(year As Integer) As Boolean
        Return (year Mod 4 = 0 And year Mod 100 <> 0) Or (year Mod 400 = 0)
    End Function

    Private Sub btnIsItALeapYear_Click(sender As Object, e As EventArgs) Handles btnIsItALeapYear.Click
        Dim year As Integer
        year = Val(txtEnterAYear.Text)


        If IsLeapYear(year) Then
            MsgBox(" is a leap year.")
        Else
            MsgBox(" is not a leap year.")
        End If


    End Sub
End Class
