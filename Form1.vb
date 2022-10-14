Public Class Form1
    Dim user As String
    Dim Pass As String

    Private Sub Textemail_TextChanged(sender As Object, e As EventArgs) Handles Textemail.TextChanged
        user = Textemail.Text

    End Sub

    Private Sub TextPass_TextChanged(sender As Object, e As EventArgs) Handles TextPass.TextChanged
        Pass = TextPass.Text
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If InStr(1, user, "rodrigomelgar@hotmail.com") = 0 Then
            MessageBox.Show("Por favor ingrese un correo válido", "ERROR")
        ElseIf InStr(1, Pass, "Senati22") = 0 Then
            MessageBox.Show("Contraseña invalida")
        ElseIf InStr(1, Pass, "Senati22") = 1 Then
            MessageBox.Show("Bienvenido Honorable Usuario")

        End If
    End Sub
End Class
