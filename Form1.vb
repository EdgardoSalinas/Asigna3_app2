Public Class Form1
    Public Function concatear(ByVal nombre As String, ByVal apellido As String) As String
        Return nombre + apellido
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wnombre, wapellido, wresultado As String
        wnombre = txt_nombre.Text
        wapellido = txt_apellido.Text
        wresultado = concatear(wnombre, wapellido)
        txtresultado.Text = wresultado
    End Sub
End Class
