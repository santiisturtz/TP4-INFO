Public Class Form1
    Dim Numero1, Numero2 As Integer

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click

        Numero1 = txtNumeroUno.Text
        Numero2 = txtNumeroDos.Text
        If Numero1 > Numero2 Then
            lblResultado.Text = "Mayor " & Numero1
        Else
            lblResultado.Text = "Mayor " & Numero2
        End If
    End Sub

End Class
