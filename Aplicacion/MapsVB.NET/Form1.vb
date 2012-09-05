Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim datos As String
        datos = "http://maps.google.es/maps?q=" + txtCalle.Text + " " + txtNumero.Text + " " + txtCP.Text + " " + txtCiudad.Text + " " + txtPais.Text + "&output=embed"
        Dim direccion As New Uri(datos)
        WebBrowser1.Url = direccion
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim datos As String
        datos = "http://maps.google.es/maps?q=" + txtLat.Text + "%2C" + txtlong.Text + "&output=embed"
        Dim direccion As New Uri(datos)
        WebBrowser1.Url = direccion

    End Sub
End Class
