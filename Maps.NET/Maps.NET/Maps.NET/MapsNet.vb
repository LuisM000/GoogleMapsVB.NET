Imports System.Net
Imports System.IO
Imports System.Xml

Public Class MapsNet

    Public Function ObtenerURLdesdeDireccion(ByRef direccion As String)
        Dim urlMaps As String 'Creamos variable para almacenar la url
        urlMaps = "http://maps.google.es/maps?q=" & direccion & "&output=embed" 'Concatenamos la dirección con la dirección del mapa
        Return urlMaps
    End Function
    Public Function ObtenerURLdesdelatlong(ByRef latitud As Double, ByRef longitud As Double)
        Dim urlMaps As String 'Creamos variable para almacenar la url
        urlMaps = "http://maps.google.es/maps?q=" + CStr(latitud) + "%2C" + CStr(longitud) + "&output=embed" 'Concatenamos la lat/long con la dirección del mapa
        Return urlMaps
    End Function

    Public Function ObtenerIp()
        Try
            Dim req As HttpWebRequest = WebRequest.Create("http://automation.whatismyip.com/n09230945.asp")
            req.Timeout = 3000
            Dim res As HttpWebResponse = req.GetResponse()
            Dim stream As Stream = res.GetResponseStream()
            Dim sr As StreamReader = New StreamReader(stream)
            Return (sr.ReadToEnd())
        Catch
            Return "0.0.0.0"
        End Try
    End Function

    Public Function localizarIp()
        Dim ip As String
        ip = Me.ObtenerIp
        Dim datosRetorno(5) As String
        Dim reader As XmlTextReader = New XmlTextReader("http://smart-ip.net/geoip-xml/" & ip & "/auto?lang=en")
        Dim type As XmlNodeType
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
        If datosRetorno(0) = "" Then datosRetorno(0) = "Datos no encontrados"
        If datosRetorno(1) = "" Then datosRetorno(1) = "Datos no encontrados"
        If datosRetorno(2) = "" Then datosRetorno(2) = "Datos no encontrados"
        If datosRetorno(3) = "" Then datosRetorno(3) = "Datos no encontrados"
        If datosRetorno(4) = "" Then datosRetorno(4) = "Datos no encontrados"
        datosRetorno(5) = CStr(ip)

        Return datosRetorno
    End Function
End Class
