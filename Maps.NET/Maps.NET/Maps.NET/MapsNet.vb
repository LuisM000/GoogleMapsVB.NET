Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath

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

    Public Function ObtenerIp() 'Obtiene IP gracias a un servicio web
        'Creamos dirección 
        Dim url As String = "http://automation.whatismyip.com/n09230945.asp"
        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            Dim res As HttpWebResponse = req.GetResponse()
            Dim stream As Stream = res.GetResponseStream()
            Dim sr As StreamReader = New StreamReader(stream)
            Return (sr.ReadToEnd())
        Catch
        End Try
        Return "0.0.0.0"

    End Function

    Public Function localizarIp() 'Localiza la Ip gracias a un servicio Web
        Dim ip As String
        ip = Me.ObtenerIp
        Dim url As String = "http://smart-ip.net/geoip-xml/" & ip & "/auto?lang=en"
        Dim datosretorno(5) As String
        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim ExPais, Exciudad, Exregion, Exdlat, Exlong As String
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            'Creamos los paths
            ExPais = "geoip/countryName"
            Exciudad = "geoip/city"
            Exregion = "geoip/region"
            Exdlat = "geoip/latitude"
            Exlong = "geoip/longitude"

            'Recorremos el xml
            NodeIter = nav.Select(ExPais)
            While (NodeIter.MoveNext())
                datosretorno(0) = NodeIter.Current.Value
            End While
            NodeIter = nav.Select(Exciudad)
            While (NodeIter.MoveNext())
                datosretorno(1) = NodeIter.Current.Value
            End While
            NodeIter = nav.Select(Exregion)
            While (NodeIter.MoveNext())
                datosretorno(2) = NodeIter.Current.Value
            End While
            NodeIter = nav.Select(Exdlat)
            While (NodeIter.MoveNext())
                datosretorno(3) = NodeIter.Current.Value
            End While
            NodeIter = nav.Select(Exlong)
            While (NodeIter.MoveNext())
                datosretorno(4) = NodeIter.Current.Value
            End While
            responseStream.Close()
        Catch
        End Try
        datosretorno(5) = ip
        Return datosretorno
    End Function


    Public Function CodificacionGeografica(ByRef direccion As String, Optional ByRef regionBusqueda As String = "es") 'busca latitud/longitud a partir de dirección

        'Creamos la url con los datso
        Dim url = "http://maps.googleapis.com/maps/api/geocode/xml?address=" & direccion & "&sensor=false" & "&region=" & regionBusqueda
        Dim LatLong As New ArrayList()

        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            Dim ExLatitud, ExLongitud, ExdatosDireccion As String

            'Creamos los paths
            ExLatitud = "GeocodeResponse/result/geometry/location/lat"
            ExLongitud = "GeocodeResponse/result/geometry/location/lng"
            ExdatosDireccion = "GeocodeResponse/result/formatted_address"
            'Recorremos el xml
            NodeIter = nav.Select(ExLatitud)
            While (NodeIter.MoveNext())
                LatLong.Add(NodeIter.Current.Value)
                Exit While
            End While

            NodeIter = nav.Select(ExLongitud)
            While (NodeIter.MoveNext())
                LatLong.Add(NodeIter.Current.Value)
                Exit While
            End While

            NodeIter = nav.Select(ExdatosDireccion)
            While (NodeIter.MoveNext())
                LatLong.Add(NodeIter.Current.Value)
                'Exit While
            End While
            responseStream.Close()
        Catch
        End Try
        Return LatLong
    End Function

    Public Function CodificacionGeograficaInversa(ByRef latitud As Double, ByRef longitud As Double, Optional ByRef regionBusqueda As String = "es") 'busca latitud/longitud a partir de dirección

        'Creamos la url con los datso
        Dim url = "http://maps.googleapis.com/maps/api/geocode/xml?latlng=" & latitud & "," & longitud & "&sensor=false" & "&region=" & regionBusqueda
        Dim direcc As New ArrayList()

        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            Dim ExDireccion As String

            'Creamos los paths
            ExDireccion = "GeocodeResponse/result/formatted_address"
           
            'Recorremos el xml
            NodeIter = nav.Select(ExDireccion)
            While (NodeIter.MoveNext())
                direcc.Add(NodeIter.Current.Value)
            End While

            responseStream.Close()
        Catch
        End Try
        Return direcc
    End Function

    Public Function PlacesLatLong(ByRef latitud As Double, ByRef longitud As Double, Optional ByRef radio As Integer = 3000, Optional tipoLocal As ArrayList = Nothing, Optional NombreEstablecimiento As String = "", Optional idioma As String = "es") 'busca un place desde lat/long
        'Creamos las variables desde las opcionales

        'Variable local
        Dim local As String = "&types="
        Dim separador As String = "|"
        If tipoLocal IsNot Nothing Then
            For Each item As Object In tipoLocal
                local = local & item & separador
            Next
        Else
            local = ""
        End If

        'Variable nombre del establecimiento
        If NombreEstablecimiento <> "" Then
            NombreEstablecimiento = "&name=" & NombreEstablecimiento
        End If

        'Variable radio
        Dim radioB As String
        radioB = "&radius=" & radio

        'Variable idioma
        idioma = "&language=" & idioma

        'Creamos la url con los datso
        Dim url = "https://maps.googleapis.com/maps/api/place/search/xml?location=" & latitud & "," & longitud & local & NombreEstablecimiento & radioB & idioma & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        Dim datos As New ArrayList()
        Dim auxiliar(0) As String
        auxiliar(0) = "sin datos"

        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            Dim ExNombre, EXdireccion, Exlati, Exlong, Exicon As String

            'Creamos los paths
            ExNombre = "PlaceSearchResponse/result/name"
            EXdireccion = "PlaceSearchResponse/result/vicinity"
            Exlati = "PlaceSearchResponse/result/geometry/location/lat"
            Exlong = "PlaceSearchResponse/result/geometry/location/lng"
            Exicon = "PlaceSearchResponse/result/icon"

            'Recorremos el xml
            NodeIter = nav.Select(ExNombre)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(EXdireccion)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exlati)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exlong)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exicon)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
            End While
            ReDim auxiliar(datos.Count - 1)
            Dim tamaño = CInt(datos.Count / 5)
            Dim contador As Integer = 0
            For i = 0 To tamaño - 1
                auxiliar(contador) = datos(i)
                auxiliar(contador + 1) = datos(i + tamaño)
                auxiliar(contador + 2) = datos(i + tamaño + tamaño)
                auxiliar(contador + 3) = datos(i + tamaño + tamaño + tamaño)
                auxiliar(contador + 4) = datos(i + tamaño + tamaño + tamaño + tamaño)
                contador += 5
            Next
            responseStream.Close()
        Catch
        End Try
        If auxiliar.Count < 5 Then
            ReDim auxiliar(4)
            auxiliar(0) = "Sin datos"
            auxiliar(1) = "Sin datos"
            auxiliar(2) = "Sin datos"
            auxiliar(3) = "Sin datos"
            auxiliar(4) = "Sin datos"
        End If

        Return auxiliar
    End Function
End Class
