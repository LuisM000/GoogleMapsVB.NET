Imports System.IO
Imports System.Net
Imports System.Xml

Public Class GoogleMaps

    Public Function ObternetLatLong(Optional ByVal calle As String = "", Optional ByVal poblacion As String = "", Optional ByVal provincia As String = "", Optional ByVal comunidad As String = "", Optional ByVal pais As String = "")
        Dim direccion As String
        Dim LatLong(1) As Double
        LatLong(0) = 0
        LatLong(1) = 0
        If calle <> "" Then calle = calle.Replace(" ", "+")
        If poblacion <> "" Then poblacion = poblacion.Replace(" ", "+")
        If provincia <> "" Then provincia = provincia.Replace(" ", "+")
        If comunidad <> "" Then comunidad = comunidad.Replace(" ", "+")
        If pais <> "" Then pais.Replace(" ", "+")
        direccion = calle + ",+" + poblacion + ",+" + provincia + ",+" + comunidad + ",+" + pais
        direccion = "http://maps.googleapis.com/maps/api/geocode/xml?address=" + direccion + "+CA&sensor=false"
        Dim reader As XmlTextReader = New XmlTextReader(direccion)
        Dim type As XmlNodeType
        reader.WhitespaceHandling = WhitespaceHandling.Significant
        While reader.Read
            type = reader.NodeType
            If type = XmlNodeType.Element Then

                Select Case reader.Name
                    Case "lat"
                        reader.Read()
                        LatLong(0) = reader.Value
                    Case "lng"
                        reader.Read()
                        LatLong(1) = reader.Value
                        If LatLong(0) <> 0 And LatLong(1) <> 0 Then
                            Exit While
                        End If
                End Select
            End If
        End While
        Return LatLong
    End Function

    'Public Sub borrarCampos()
    '    Form1.txtCalle.Text = ""
    '    Form1.txtCiudad.Text = ""
    '    Form1.txtcomunidad.Text = ""
    '    Form1.txtCP.Text = ""
    '    Form1.txtLat.Text = ""
    '    Form1.txtlong.Text = ""
    '    Form1.txtNumero.Text = ""
    '    Form1.txtPais.Text = ""
    '    Form1.txtprovincia.Text = ""
    'End Sub

    Public Function ObtenerIp()
        Dim req As HttpWebRequest = WebRequest.Create("http://automation.whatismyip.com/n09230945.asp")
        Dim res As HttpWebResponse = req.GetResponse()
        Dim stream As Stream = res.GetResponseStream()
        Dim sr As StreamReader = New StreamReader(stream)
        Return (sr.ReadToEnd())
    End Function
    Public Function localizarIp(ByVal ip As String)
        Dim datosRetorno(4) As String

        Dim reader As XmlTextReader = New XmlTextReader("http://smart-ip.net/geoip-xml/" & ip & "/auto?lang=en")
        Dim type As XmlNodeType
        datosRetorno(0) = "Datos no encontrados"
        datosRetorno(1) = "Datos no encontrados"
        datosRetorno(2) = "Datos no encontrados"
        datosRetorno(3) = "Datos no encontrados"
        datosRetorno(4) = "Datos no encontrados"

        reader.WhitespaceHandling = WhitespaceHandling.Significant

        While reader.Read
            type = reader.NodeType
            If type = XmlNodeType.Element Then

                Select Case reader.Name
                    Case "countryName"
                        reader.Read()
                        datosRetorno(0) = reader.Value
                    Case "city"
                        reader.Read()
                        datosRetorno(1) = reader.Value
                    Case "region"
                        reader.Read()
                        datosRetorno(2) = reader.Value
                    Case "latitude"
                        reader.Read()
                        datosRetorno(3) = reader.Value
                    Case "longitude"
                        reader.Read()
                        datosRetorno(4) = reader.Value
                End Select
            End If
        End While
        Return datosRetorno
    End Function
    Public Function ObtenerURLDireccionMaps(Optional ByVal calle As String = "", Optional ByVal numero As String = "", Optional ByVal CodigoPostal As String = "", Optional ByVal poblacion As String = "", Optional ByVal provincia As String = "", Optional ByVal comunidad As String = "", Optional ByVal pais As String = "")
        Dim urlMaps As String
        urlMaps = "http://maps.google.es/maps?q=" + calle + " " + numero + " " + CodigoPostal + " " + poblacion + " " + provincia + " " + comunidad + " " + pais + "&output=embed"
        Return urlMaps
    End Function

    Public Function ObtenerURLlatlongMaps(ByVal latitud As Double, ByVal longitud As Double)
        Dim urlMaps As String
        urlMaps = "http://maps.google.es/maps?q=" + CStr(latitud) + "%2C" + CStr(longitud) + "&output=embed"
        Return urlMaps
    End Function


End Class
