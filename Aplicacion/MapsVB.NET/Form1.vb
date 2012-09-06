Imports System.Xml
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objetoMaps As New GoogleMaps
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLDireccionMaps(txtCalle.Text, txtNumero.Text, txtCP.Text, txtCiudad.Text, txtprovincia.Text, txtcomunidad.Text, txtPais.Text)
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objetoMaps As New GoogleMaps
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLlatlongMaps(CDbl(txtLat.Text), CDbl(txtlong.Text))
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim objetoMaps As New GoogleMaps
        Dim ip As String = objetoMaps.ObtenerIp()
        Dim DatosRetorno(4) As String
        DatosRetorno=objetoMaps.localizarIp(ip)
        objetoMaps.borrarCampos()
        txtPais.Text = DatosRetorno(0)
        txtCiudad.Text = DatosRetorno(1)
        txtcomunidad.Text = DatosRetorno(2)
        txtLat.Text = DatosRetorno(3)
        txtlong.Text = DatosRetorno(4)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim calle, poblacion, provincia, comunidad, pais As String
        calle = txtCalle.Text
        poblacion = txtCiudad.Text
        provincia = txtprovincia.Text
        comunidad = txtcomunidad.Text
        pais = txtPais.Text
        Dim objetoMaps As New GoogleMaps
        Dim latlong(1) As Double
        latlong = objetoMaps.ObternetLatLong(calle, poblacion, provincia, comunidad, pais)
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLlatlongMaps(latlong(0), latlong(1))
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion

    End Sub
End Class
