Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sum As Integer

        For i As Integer = 1 To 100

            If i = 80 Then
                Exit For
            End If

            sum = sum + i
        Next

        Answer.Text = sum

    End Sub

End Class