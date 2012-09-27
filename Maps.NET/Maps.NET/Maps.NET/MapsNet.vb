Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath

Public Class MapsNet

    Public Function ObtenerURLdesdeDireccion(ByVal direccion As String)
        Dim urlMaps As String 'Creamos variable para almacenar la url
        urlMaps = "http://maps.google.es/maps?q=" & direccion & "&output=embed" 'Concatenamos la dirección con la dirección del mapa
        Return urlMaps
    End Function
    Public Function ObtenerURLdesdelatlong(ByVal latitud As Double, ByVal longitud As Double)
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


    Public Function CodificacionGeografica(ByVal direccion As String, Optional ByVal regionBusqueda As String = "es") 'busca latitud/longitud a partir de dirección

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

    Public Function CodificacionGeograficaInversa(ByVal latitud As Double, ByVal longitud As Double, Optional ByVal regionBusqueda As String = "es") 'busca latitud/longitud a partir de dirección

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

    Public Function PlacesLatLong(ByVal latitud As Double, ByVal longitud As Double, Optional ByVal radio As Integer = 3000, Optional tipoLocal As ArrayList = Nothing, Optional NombreEstablecimiento As String = "", Optional idioma As String = "es") 'busca un place desde lat/long
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

            Dim ExNombre, EXdireccion, Exlati, Exlong, Exicon, Exref As String

            'Creamos los paths
            ExNombre = "PlaceSearchResponse/result/name"
            EXdireccion = "PlaceSearchResponse/result/vicinity"
            Exlati = "PlaceSearchResponse/result/geometry/location/lat"
            Exlong = "PlaceSearchResponse/result/geometry/location/lng"
            Exicon = "PlaceSearchResponse/result/icon"
            Exref = "PlaceSearchResponse/result/reference"


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

            NodeIter = nav.Select(Exref)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
            End While

            ReDim auxiliar(datos.Count - 1)
            Dim tamaño = CInt(datos.Count / 6)
            Dim contador As Integer = 0
            For i = 0 To tamaño - 1
                auxiliar(contador) = datos(i)
                auxiliar(contador + 1) = datos(i + tamaño)
                auxiliar(contador + 2) = datos(i + tamaño + tamaño)
                auxiliar(contador + 3) = datos(i + tamaño + tamaño + tamaño)
                auxiliar(contador + 4) = datos(i + tamaño + tamaño + tamaño + tamaño)
                auxiliar(contador + 5) = datos(i + tamaño + tamaño + tamaño + tamaño + tamaño)
                contador += 6
            Next
            responseStream.Close()
        Catch
        End Try
        If auxiliar.Count < 6 Then
            ReDim auxiliar(5)
            auxiliar(0) = "Sin datos"
            auxiliar(1) = "Sin datos"
            auxiliar(2) = "Sin datos"
            auxiliar(3) = "Sin datos"
            auxiliar(4) = "Sin datos"
            auxiliar(5) = "Sin datos"
        End If
        Return auxiliar
    End Function

    Public Function DetallesLugar(ByVal ParametroDetalles As String) 'Enviamos los detalles del lugar

        'Creamos la url con los datso
        Dim url = "https://maps.googleapis.com/maps/api/place/details/xml?reference=" & ParametroDetalles & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        Dim datos As New ArrayList()


        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            Dim ExNombre, EXdireccion, ExTelefono, ExAdress, ExURLGoogle, Exrating, EXicon, ExURL As String
            Dim nombre, direccion, telefono, adress, urlgoogle, rating, icon, WEbsite As Boolean
            nombre = False : direccion = False : telefono = False : adress = False : urlgoogle = False : rating = False : icon = False : WEbsite = False
            'Creamos los paths
            ExNombre = "PlaceDetailsResponse/result/name"
            EXdireccion = "PlaceDetailsResponse/result/vicinity"
            ExTelefono = "PlaceDetailsResponse/result/formatted_phone_number"
            ExAdress = "PlaceDetailsResponse/result/formatted_address"
            ExURLGoogle = "PlaceDetailsResponse/result/url"
            Exrating = "PlaceDetailsResponse/result/rating"
            EXicon = "PlaceDetailsResponse/result/icon"
            ExURL = "PlaceDetailsResponse/result/website"



            'Recorremos el xml
            NodeIter = nav.Select(ExNombre)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                nombre = True
            End While
            If nombre = False Then
                datos.Add("Sin nombre")
            End If

            NodeIter = nav.Select(EXdireccion)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                direccion = True
            End While
            If direccion = False Then
                datos.Add("Sin dirección")
            End If

            NodeIter = nav.Select(ExTelefono)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                telefono = True
            End While
            If telefono = False Then
                datos.Add("Sin teléfono")
            End If

            NodeIter = nav.Select(ExAdress)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                adress = True
            End While
            If adress = False Then
                datos.Add("Sin dirección")
            End If

            NodeIter = nav.Select(ExURLGoogle)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                urlgoogle = True
            End While
            If urlgoogle = False Then
                datos.Add("Sin página google")
            End If

            NodeIter = nav.Select(Exrating)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                rating = True
            End While
            If rating = False Then
                datos.Add("Sin puntuaciones")
            End If

            NodeIter = nav.Select(EXicon)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                icon = True
            End While
            If icon = False Then
                datos.Add("Sin icono")
            End If

            NodeIter = nav.Select(ExURL)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                WEbsite = True
            End While
            If WEbsite = False Then
                datos.Add("Sin página web")
            End If

            responseStream.Close()
        Catch
        End Try
        Return datos
    End Function



    Public Function DetallesRestaurante(ByVal ParametroDetalles As String) 'Enviamos los detalles del lugar

        'Creamos la url con los datso
        Dim url = "https://maps.googleapis.com/maps/api/place/details/xml?reference=" & ParametroDetalles & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8&language=es"
        Dim datos As New ArrayList()



        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            Dim ExNombre, EXdireccion, ExTelefono, ExAdress, ExURLGoogle, Exrating, EXicon, ExURL As String
            Dim nombre, direccion, telefono, adress, urlgoogle, rating, icon, WEbsite As Boolean
            nombre = False : direccion = False : telefono = False : adress = False : urlgoogle = False : rating = False : icon = False : WEbsite = False
            'Creamos los paths
            ExNombre = "PlaceDetailsResponse/result/name"
            EXdireccion = "PlaceDetailsResponse/result/vicinity"
            ExTelefono = "PlaceDetailsResponse/result/formatted_phone_number"
            ExAdress = "PlaceDetailsResponse/result/formatted_address"
            ExURLGoogle = "PlaceDetailsResponse/result/url"
            Exrating = "PlaceDetailsResponse/result/rating"
            EXicon = "PlaceDetailsResponse/result/icon"
            ExURL = "PlaceDetailsResponse/result/website"



            'Recorremos el xml
            NodeIter = nav.Select(ExNombre)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                nombre = True
            End While
            If nombre = False Then
                datos.Add("Sin nombre")
            End If

            NodeIter = nav.Select(EXdireccion)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                direccion = True
            End While
            If direccion = False Then
                datos.Add("Sin dirección")
            End If

            NodeIter = nav.Select(ExTelefono)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                telefono = True
            End While
            If telefono = False Then
                datos.Add("Sin teléfono")
            End If

            NodeIter = nav.Select(ExAdress)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                adress = True
            End While
            If adress = False Then
                datos.Add("Sin dirección")
            End If

            NodeIter = nav.Select(ExURLGoogle)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                urlgoogle = True
            End While
            If urlgoogle = False Then
                datos.Add("Sin página google")
            End If

            NodeIter = nav.Select(Exrating)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                rating = True
            End While
            If rating = False Then
                datos.Add("Sin puntuaciones")
            End If

            NodeIter = nav.Select(EXicon)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                icon = True
            End While
            If icon = False Then
                datos.Add("Sin icono")
            End If

            NodeIter = nav.Select(ExURL)
            While (NodeIter.MoveNext())
                datos.Add(NodeIter.Current.Value)
                WEbsite = True
            End While
            If WEbsite = False Then
                datos.Add("Sin página web")
            End If



            'todas ellas están como variables globales :(
            Dim EXtime, EXautor, Extexto, EXurlautor As String
            'Borramos los datos anteriores
            time.Clear()
            autor.Clear()
            URLautor.Clear()
            textoReview.Clear()

            'Creamos los paths
            EXtime = "PlaceDetailsResponse/result/review/time"
            EXautor = "PlaceDetailsResponse/result/review/author_name"
            Extexto = "PlaceDetailsResponse/result/review/text"
            EXurlautor = "PlaceDetailsResponse/result/review/author_url"

            NodeIter = nav.Select(EXtime)
            While (NodeIter.MoveNext())
                time.Add(NodeIter.Current.Value)
                icon = True
            End While

            NodeIter = nav.Select(EXautor)
            While (NodeIter.MoveNext())
                autor.Add(NodeIter.Current.Value)
                icon = True
            End While

            NodeIter = nav.Select(Extexto)
            While (NodeIter.MoveNext())
                textoReview.Add(NodeIter.Current.Value)
                icon = True
            End While

            NodeIter = nav.Select(EXurlautor)
            While (NodeIter.MoveNext())
                URLautor.Add(NodeIter.Current.Value)
                icon = True
            End While



            responseStream.Close()
        Catch
        End Try
        Return datos
    End Function


    Public Function Autocompletado(ByVal input As String, ByVal latitud As Double, ByVal longitud As Double, ByVal radio As Integer, ByVal NumeroCaracteres As Integer, Optional ByVal idioma As String = "es") 'Autocompletado

        'Creamos variable input
        input = input.Replace(" ", "+")
        input = "input=" & input

        'Creamos variable localicación
        Dim localizacion = "&location=" & latitud & "," & longitud

        'Creamos variable radio
        Dim radioAux As String
        radioAux = "&radius=" & radio

        'Número de caracteres
        Dim numeroCaracAux
        numeroCaracAux = "&offset=" & NumeroCaracteres

        'Creamos la url con los datos
        Dim url = "https://maps.googleapis.com/maps/api/place/autocomplete/xml?" & input & numeroCaracAux & localizacion & radioAux & "&types=establishment&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
        Dim establecimiento As New ArrayList()

        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 3000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            Dim ExEstablecimiento As String

            'Creamos los paths
            ExEstablecimiento = "AutocompletionResponse/prediction/term/value"

            'Recorremos el xml
            NodeIter = nav.Select(ExEstablecimiento)
            While (NodeIter.MoveNext())
                establecimiento.Add(NodeIter.Current.Value)
            End While

            responseStream.Close()
        Catch
        End Try
        Return establecimiento
    End Function




    Public Function Rutas(ByVal DireccionOrigen As String, ByVal DireccionDestino As String, Optional TipoTransporte As Integer = 0, Optional ByVal Hitos As ArrayList = Nothing, Optional ByVal optimizar As Boolean = False, Optional ByVal peajes As Integer = 0, Optional ByVal region As String = "es", Optional ByVal idioma As String = "es")

        'Tipo de transporte
        Dim transporte As String = TipoTransporte
        Select Case TipoTransporte
            Case 0
                transporte = "&mode=driving"
            Case 1
                transporte = "&mode=walking"
            Case 2
                transporte = "&mode=bicycling"
            Case Else
                transporte = "&mode=driving"
        End Select

        'Dirección origen
        DireccionOrigen = DireccionOrigen.Replace(" ", "+")
        DireccionOrigen = "&origin=" & DireccionOrigen

        'Dirección destino
        DireccionDestino = DireccionDestino.Replace(" ", "+")
        DireccionDestino = "&destination=" & DireccionDestino

        'Hitos
        Dim todosHitos As String = "&waypoints="
        If optimizar = True Then
            todosHitos = "&waypoints=optimize:true|"
        Else
            todosHitos = "&waypoints="
        End If

        Dim separador As String = "|"
        If Hitos IsNot Nothing Then
            For Each item As Object In Hitos
                todosHitos = todosHitos & item & separador
            Next
        Else
            todosHitos = ""
        End If


        'Peajes
        Dim peajesFin As String = ""
        Select Case peajes
            Case 0  'No evitamos peajes
                peajesFin = ""
            Case 1 'evitar los peajes de carretera y de puentes.
                peajesFin = "&avoid=tolls"
            Case 2 'evitar las autopistas y las autovías
                peajesFin = "&avoid=highways"
            Case Else

        End Select


        'Region
        region = "&region=" & region

        'Idioma
        idioma = "&language=" & idioma

        'Creamos la url con los datos
        Dim url = "https://maps.googleapis.com/maps/api/directions/xml?" & DireccionOrigen & DireccionDestino & todosHitos & transporte & peajesFin & region & idioma & "&sensor=false"
        Dim DatosRuta As New ArrayList()
        Dim auxiliar(0) As String
        auxiliar(0) = "sin datos"

        Dim req As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest)
        req.Timeout = 5000
        Try
            'Preparamos el archivo xml
            Dim res As System.Net.WebResponse = req.GetResponse()
            Dim responseStream As Stream = res.GetResponseStream()
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(responseStream)
            Dim nav = docNav.CreateNavigator

            Dim Exruta, Extiempo, Exdistancia, Exindicaciones, Exlatitud, Exlongitud, Excopyrights, ExordenRuta As String

            'Creamos los paths
            Exlatitud = "DirectionsResponse/route/leg/step/start_location/lat"
            Exlongitud = "DirectionsResponse/route/leg/step/start_location/lng"
            Extiempo = "DirectionsResponse/route/leg/step/duration/text"
            Exdistancia = "DirectionsResponse/route/leg/step/distance/text"
            Exindicaciones = "DirectionsResponse/route/leg/step/html_instructions"
            Exruta = "DirectionsResponse/route/summary" 'Lo asignamos a variables globales
            Excopyrights = "DirectionsResponse/route/copyrights" 'Lo asignamos a variables globales
            ExordenRuta = "DirectionsResponse/route/waypoint_index" 'Lo asignamos a variables globales

            'borramos las variables globales
            copyRuta.Clear()
            ordenRuta.Clear()
            rutaID.Clear()


            'Recorremos el xml
           
            NodeIter = nav.Select(Exlatitud)
            While (NodeIter.MoveNext())
                DatosRuta.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exlongitud)
            While (NodeIter.MoveNext())
                DatosRuta.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Extiempo)
            While (NodeIter.MoveNext())
                DatosRuta.Add(NodeIter.Current.Value)
            End While


            NodeIter = nav.Select(Exdistancia)
            While (NodeIter.MoveNext())
                DatosRuta.Add(NodeIter.Current.Value)
            End While


            NodeIter = nav.Select(Exindicaciones)
            While (NodeIter.MoveNext())
                DatosRuta.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Excopyrights)
            While (NodeIter.MoveNext())
                copyRuta.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(ExordenRuta)
            While (NodeIter.MoveNext())
                ordenRuta.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exruta)
            While (NodeIter.MoveNext())
                rutaID.Add(NodeIter.Current.Value)
            End While

            ReDim auxiliar(DatosRuta.Count - 1)
            Dim tamaño = CInt(DatosRuta.Count / 5)
            Dim contador As Integer = 0
            For i = 0 To tamaño - 1
                auxiliar(contador) = DatosRuta(i)
                auxiliar(contador + 1) = DatosRuta(i + tamaño)
                auxiliar(contador + 2) = DatosRuta(i + tamaño + tamaño)
                auxiliar(contador + 3) = DatosRuta(i + tamaño + tamaño + tamaño)
                auxiliar(contador + 4) = DatosRuta(i + tamaño + tamaño + tamaño + tamaño)
                contador += 5
            Next


            responseStream.Close()
        Catch
        End Try

       
        Return auxiliar
    End Function







    Public Function DiasRestantes(ByVal FechaUnix As String)  'Cálculo días restantes con respecto a hoy
        Dim Diferencia(1) As String

        Try
            Dim Tim1 As Date = Now
            Dim Tim2 As Date = Me.UnixToTime(FechaUnix)
            If DateDiff(DateInterval.Year, Tim2, Tim1) > 0 Then
                Diferencia(0) = DateDiff(DateInterval.Year, Tim2, Tim1)
                Diferencia(1) = "años"
            ElseIf DateDiff(DateInterval.Month, Tim2, Tim1) > 0 Then
                Diferencia(0) = DateDiff(DateInterval.Month, Tim2, Tim1)
                Diferencia(1) = "meses"
            Else
                Diferencia(0) = DateDiff(DateInterval.Day, Tim2, Tim1)
                Diferencia(1) = "días"
            End If
        Catch
        End Try
        Return Diferencia

    End Function



    Public Function UnixToTime(ByVal strUnixTime As String) As Date  'Tiempo Unix a fecha
        UnixToTime = DateAdd(DateInterval.Second, Val(strUnixTime), #1/1/1970#)
        If UnixToTime.IsDaylightSavingTime = True Then
            UnixToTime = DateAdd(DateInterval.Hour, 1, UnixToTime)
        End If
        Return UnixToTime
    End Function
    Function TimeToUnix(ByVal dteDate As Date) As String   'Fecha a tiempo Unix
        If dteDate.IsDaylightSavingTime = True Then
            dteDate = DateAdd(DateInterval.Hour, -1, dteDate)
        End If
        TimeToUnix = DateDiff(DateInterval.Second, #1/1/1970#, dteDate)
        Return TimeToUnix
    End Function
End Class
