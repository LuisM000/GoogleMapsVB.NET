Imports System.Xml
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim datos As String
        datos = "http://maps.google.es/maps?q=" + txtCalle.Text + " " + txtNumero.Text + " " + txtCP.Text + " " + txtCiudad.Text + " " + txtprovincia.Text + " " + txtcomunidad.Text + " " + txtPais.Text + "&output=embed"
        Dim direccion As New Uri(datos)
        WebBrowser1.Url = direccion
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim datos As String
        datos = "http://maps.google.es/maps?q=" + txtLat.Text + "%2C" + txtlong.Text + "&output=embed"
        Dim direccion As New Uri(datos)
        WebBrowser1.Url = direccion

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim objetoMaps As New GoogleMaps
        Dim ip As String = objetoMaps.ObtenerIp()
        Dim reader As XmlTextReader = New XmlTextReader("http://smart-ip.net/geoip-xml/" & ip & "/auto?lang=en")
        Dim type As XmlNodeType
        Dim mcountryName As String = "Datos no encontrados"
        Dim mcity As String = "Datos no encontrados"
        Dim mregion As String = "Datos no encontrados"
        Dim mlongitude As String = "Datos no encontrados"
        Dim mlatitude As String = "Datos no encontrados"

        reader.WhitespaceHandling = WhitespaceHandling.Significant

        While reader.Read
            type = reader.NodeType
            If type = XmlNodeType.Element Then

                Select Case reader.Name
                    Case "countryName"
                        reader.Read()
                        mcountryName = reader.Value
                    Case "city"
                        reader.Read()
                        mcity = reader.Value
                    Case "region"
                        reader.Read()
                        mregion = reader.Value
                    Case "latitude"
                        reader.Read()
                        mlatitude = reader.Value
                    Case "longitude"
                        reader.Read()
                        mlongitude = reader.Value
                End Select
            End If
        End While
        objetoMaps.borrarCampos()
        txtPais.Text = mcountryName
        txtCiudad.Text = mcity
        txtcomunidad.Text = mregion
        txtLat.Text = mlatitude
        txtlong.Text = mlongitude

    End Sub
End Class
