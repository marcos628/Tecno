Public Class VerificarU
    Dim cliente As String
    Dim administrador As String
    Dim secretario As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "cliente" Then
            Usuario.ShowDialog()

        ElseIf TextBox1.Text = "administrador" Then
            Administrador_1.ShowDialog()

        ElseIf TextBox1.Text = "secretario" Then
            Secretario_0.ShowDialog()
        End If
    End Sub
End Class
