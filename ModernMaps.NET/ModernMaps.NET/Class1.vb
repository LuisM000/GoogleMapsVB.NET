Imports System.IO
Imports System.Net
Imports System.Xml

Public Class GoogleMaps

    Public Function CodificacionGeo(Optional ByVal calle As String = "", Optional ByVal poblacion As String = "", Optional ByVal provincia As String = "", Optional ByVal comunidad As String = "", Optional ByVal pais As String = "")
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


    Public Function CodigoPostal(Optional ByVal calle As String = "", Optional ByVal poblacion As String = "", Optional ByVal provincia As String = "", Optional ByVal comunidad As String = "", Optional ByVal pais As String = "")
        Dim direccion As String
        Dim cp As String = "0"
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
                If reader.Name = "address_component" Then
                    reader.Read()
                    reader.Read()
                    If IsNumeric(reader.Value) Then
                        cp = reader.Value
                        Exit While
                    End If
                End If
            End If
        End While
        If cp = "0" Or cp.Length <> 5 Then
            cp = "Código postal no encontrado"
        End If
        Return cp
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

    Public Function ObtenerURLlatlongMaps(ByVal latitud As String, ByVal longitud As String)
        Dim urlMaps As String
        urlMaps = "http://maps.google.es/maps?q=" + CStr(latitud) + "%2C" + CStr(longitud) + "&output=embed"
        Return urlMaps
    End Function


    Public Function CodificacionGeoInv(ByVal latitud As String, ByVal longitud As String)
        Dim direccion As String
        Dim datos As String
        datos = "Dirección no encontrada"
        direccion = "http://maps.googleapis.com/maps/api/geocode/xml?latlng=" + CStr(latitud) + "," + CStr(longitud) + "&sensor=false"
        Dim reader As XmlTextReader = New XmlTextReader(direccion)
        Dim type As XmlNodeType
        reader.WhitespaceHandling = WhitespaceHandling.Significant
        While reader.Read
            type = reader.NodeType
            If type = XmlNodeType.Element Then

                Select Case reader.Name
                    Case "type"
                        reader.Read()
                        If reader.Value = "street_address" Then
                            reader.Read()
                            reader.Read()
                            If reader.Name = "formatted_address" Then
                                reader.Read()
                                datos = "Dirección postal: " + reader.Value
                                Exit While
                            End If
                        End If

                        If reader.Value = "route" Then
                            reader.Read()
                            reader.Read()
                            If reader.Name = "formatted_address" Then
                                reader.Read()
                                datos = "Ruta: " + reader.Value
                                Exit While
                            End If
                        End If
                        If reader.Value = "intersection" Then
                            reader.Read()
                            reader.Read()
                            If reader.Name = "formatted_address" Then
                                reader.Read()
                                datos = "Intersección: " + reader.Value
                                Exit While
                            End If
                        End If
                    Case "formatted_address"
                        reader.Read()
                        datos = "Dirección: " + reader.Value
                        Exit While

                End Select
            End If
        End While
        Return datos
    End Function

    Public Function ImagenStreetViewLatiLong(ByVal latitud As Double, ByVal longitud As Double, Optional ByVal WidthImagen As Integer = 400, Optional ByVal HeightImagen As Integer = 400, Optional ByVal GradosHorizontales As Integer = -1, Optional ByVal GradosVerticales As Integer = -1, Optional ByVal zoom As Integer = 120)
        Dim direccion As String
        direccion = "http://maps.googleapis.com/maps/api/streetview?size=400x400&location=66.960654,-2.201815&heading=90&fov=120&pitch=0&&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        latitud = CStr(latitud)
        longitud = CStr(longitud)
        WidthImagen = CStr(WidthImagen)
        HeightImagen = CStr(HeightImagen)
        zoom = CStr(zoom)
        GradosHorizontales = CStr(GradosHorizontales)
        GradosVerticales = CStr(GradosVerticales)
        If GradosHorizontales <> -1 And GradosVerticales <> -1 Then
            direccion = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & latitud & "," & longitud & "&heading=" & GradosHorizontales & "&fov=" & zoom & "&pitch=" & GradosVerticales & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        If GradosHorizontales = "-1" And GradosVerticales <> -1 Then
            direccion = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & latitud & "," & longitud & "&fov=" & zoom & "&pitch=" & GradosVerticales & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        If GradosHorizontales <> "-1" And GradosVerticales = -1 Then
            direccion = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & latitud & "," & longitud & "&heading=" & GradosHorizontales & "&fov=" & zoom & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        If GradosHorizontales = "-1" And GradosVerticales = -1 Then
            direccion = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & latitud & "," & longitud & "&fov=" & zoom & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        Return direccion
    End Function
    Public Function ImagenStreetViewDireccion(ByVal direccion As String, Optional ByVal WidthImagen As Integer = 400, Optional ByVal HeightImagen As Integer = 400, Optional ByVal GradosHorizontales As Integer = -1, Optional ByVal GradosVerticales As Integer = -1, Optional ByVal zoom As Integer = 120)
        Dim URL = "http://maps.googleapis.com/maps/api/streetview?size=400x400&location=66.960654,-2.201815&heading=90&fov=120&pitch=0&&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        WidthImagen = CStr(WidthImagen)
        HeightImagen = CStr(HeightImagen)
        zoom = CStr(zoom)
        GradosHorizontales = CStr(GradosHorizontales)
        GradosVerticales = CStr(GradosVerticales)
        If GradosHorizontales <> -1 And GradosVerticales <> -1 Then
            URL = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & direccion & "&heading=" & GradosHorizontales & "&fov=" & zoom & "&pitch=" & GradosVerticales & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        If GradosHorizontales = "-1" And GradosVerticales <> -1 Then
            URL = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & direccion & "&fov=" & zoom & "&pitch=" & GradosVerticales & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        If GradosHorizontales <> "-1" And GradosVerticales = -1 Then
            URL = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & direccion & "&heading=" & GradosHorizontales & "&fov=" & zoom & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        If GradosHorizontales = "-1" And GradosVerticales = -1 Then
            URL = "http://maps.googleapis.com/maps/api/streetview?size=" & WidthImagen & "x" & HeightImagen & "&location=" & direccion & "&fov=" & zoom & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        Return URL
    End Function

    Public Function GooglePlaces(ByVal latitud As Double, ByVal longitud As Double, ByVal radioMetros As Integer, Optional ByVal tipoLocal As String = "sin tipo", Optional ByVal nombrePlace As String = "sin nombre")
        Dim URL = "https://maps.googleapis.com/maps/api/place/search/xml?location=-33.8670522,151.1957362&radius=500&types=food&name=harbour&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"

        If tipoLocal <> "sin tipo" And nombrePlace <> "sin nombre" Then
            URL = "https://maps.googleapis.com/maps/api/place/search/xml?location=" & latitud & "," & longitud & "&radius=" & radioMetros & "&types=" & tipoLocal & "&name=" & nombrePlace & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If

        If tipoLocal = "sin tipo" And nombrePlace = "sin nombre" Then
            URL = "https://maps.googleapis.com/maps/api/place/search/xml?location=" & latitud & "," & longitud & "&radius=" & radioMetros & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If

        If tipoLocal = "sin tipo" And nombrePlace <> "sin nombre" Then
            URL = "https://maps.googleapis.com/maps/api/place/search/xml?location=" & latitud & "," & longitud & "&radius=" & radioMetros & "&name=" & nombrePlace & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If
        If tipoLocal <> "sin tipo" And nombrePlace = "sin nombre" Then
            URL = "https://maps.googleapis.com/maps/api/place/search/xml?location=" & latitud & "," & longitud & "&radius=" & radioMetros & "&types=" & tipoLocal & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        End If

        Dim datos(1000) As String
        Dim contador As Integer = 0
        Dim reader As XmlTextReader = New XmlTextReader(URL)
        Dim type As XmlNodeType
        reader.WhitespaceHandling = WhitespaceHandling.Significant
        While reader.Read
            type = reader.NodeType
            If type = XmlNodeType.Element Then

                Select Case reader.Name
                    Case "name"
                        reader.Read()
                        datos(contador) = "name"
                        contador += 1
                        datos(contador) = reader.Value
                        contador += 1

                    Case "lat"
                        reader.Read()
                        datos(contador) = "lat"
                        contador += 1
                        datos(contador) = reader.Value
                        contador += 1
                       
                    Case "lng"
                        reader.Read()
                        datos(contador) = "lng"
                        contador += 1
                        datos(contador) = reader.Value
                        contador += 1
                      
                    Case "rating"
                        reader.Read()
                        datos(contador) = "rating"
                        contador += 1
                        datos(contador) = reader.Value
                        contador += 1
                       
                    Case "icon"
                        reader.Read()
                        datos(contador) = "icon"
                        contador += 1
                        datos(contador) = reader.Value
                        contador += 1
                      

                End Select
            End If
        End While
        contadorPlaces = contador
        Return datos
    End Function

















    Function cargarrecursoweb(ByVal enlace As String)
        Dim BItmapOriginal As New Bitmap("imagenes/black/cancel.png")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(enlace)
            Dim response As System.Net.WebResponse = request.GetResponse()
            Dim responseStream As System.IO.Stream = response.GetResponseStream()
            Dim bmp As New Bitmap(responseStream)
            Return bmp

        Catch
            Return BItmapOriginal

        End Try
    End Function
End Class
