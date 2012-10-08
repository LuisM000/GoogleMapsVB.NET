Public Class MapasRutaPasoaPaso

  Dim polilineasMapa As ArrayList
    Dim indicacionesMapa As ArrayList
    Dim modo As String = "carreteras"
    Dim contador As Integer = 0

    Sub New(ByVal datosPolilinea As ArrayList, ByVal Indicaciones As ArrayList)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        polilineasMapa = datosPolilinea
        indicacionesMapa = Indicaciones
    End Sub

    Sub cargarMapageneral()
        Dim url2 = "http://maps.google.com/maps/api/staticmap?&size=250x180&format=png&maptype=roadmap&language=es&path=color:0xFF0000|weight:6|enc:"
        Select Case modo
            Case "carreteras"
                url2 = url2 & polilineasMapa(polilineasMapa.Count - 1) & "&style=feature:road.local%7Celement:geometry%7Chue:0x00ff00%7Csaturation:100&style=feature:landscape%7Celement:geometry%7Clightness:-100&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
            Case "normal"
                url2 = url2 & polilineasMapa(polilineasMapa.Count - 1) & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
            Case "carreteras2"
                url2 = url2 & polilineasMapa(polilineasMapa.Count - 1) & "&style=feature:road.highway%7Celement:geometry%7Chue:0xff0022%7Csaturation:60%7Clightness:-20&style=feature:road.arterial%7Celement:geometry%7Chue:0x2200ff%7Clightness:-40:visibility:simplified%7Csaturation:30&style=feature:road.local%7Chue:0xf6ff00%7Csaturation:60%7Cgamma:0.7%7Cvisibility:simplified&style=feature:water%7Celement:geometry%7Csaturation:40%7Clightness:40&style=road.highway%7Celement:labels%7Cvisibility:on%7Csaturation:98&style=feature:administrative.locality%7Celement:labels%7Chue:0x0022ff%7Csaturation:50%7Clightness:-10%7Cgamma:0.9&style=feature:transit.line%7Celement:geometry%7Chue:0xff0000%7Cvisibility:on%7Clightness:-70&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
            Case Else
                url2 = url2 & polilineasMapa(polilineasMapa.Count - 1) & "&sensor=false"
        End Select
        Dim urlF2 As New Uri(url2)
        WebBrowser2.Url = urlF2
        seguimientodepeticiones(url2)
    End Sub

    Sub siguienteMapa()
        Try
            Dim url1 = "http://maps.google.com/maps/api/staticmap?&size=620x350&format=png&maptype=roadmap&language=es&path=color:0xFF0000|weight:6|enc:"
            Select Case modo
                Case "carreteras"
                    url1 = url1 & polilineasMapa(contador) & "&style=feature:road.local%7Celement:geometry%7Chue:0x00ff00%7Csaturation:100&style=feature:landscape%7Celement:geometry%7Clightness:-100&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
                Case "normal"
                    url1 = url1 & polilineasMapa(contador) & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
                Case "carreteras2"
                    url1 = url1 & polilineasMapa(contador) & "&style=feature:road.highway%7Celement:geometry%7Chue:0xff0022%7Csaturation:60%7Clightness:-20&style=feature:road.arterial%7Celement:geometry%7Chue:0x2200ff%7Clightness:-40:visibility:simplified%7Csaturation:30&style=feature:road.local%7Chue:0xf6ff00%7Csaturation:60%7Cgamma:0.7%7Cvisibility:simplified&style=feature:water%7Celement:geometry%7Csaturation:40%7Clightness:40&style=road.highway%7Celement:labels%7Cvisibility:on%7Csaturation:98&style=feature:administrative.locality%7Celement:labels%7Chue:0x0022ff%7Csaturation:50%7Clightness:-10%7Cgamma:0.9&style=feature:transit.line%7Celement:geometry%7Chue:0xff0000%7Cvisibility:on%7Clightness:-70&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
                Case Else
                    url1 = url1 & polilineasMapa(contador) & "&sensor=false"
            End Select
            Dim urlF As New Uri(url1)
            WebBrowser1.Url = urlF
            seguimientodepeticiones(url1)
            Label4.Text = indicacionesMapa(contador)
        Catch
            Label4.Text = "FIN DE LA RUTA. PULSE SIGUIENTE PARA VOLVER A VISUALIZARLA"
            contador = -1
        End Try

    End Sub

    Private Sub MapasRutaPasoaPaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 0
        WebBrowser1.ScrollBarsEnabled = False
        WebBrowser2.ScrollBarsEnabled = False
        cargarMapageneral()
        siguienteMapa()

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        contador += 1
        siguienteMapa()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador -= 1
        siguienteMapa()
    End Sub




    Sub seguimientodepeticiones(ByVal url1 As String)
        If url1.Length >= 2048 Then 'Máximo permitido URL
            numeroInstancia += 1
            URLseguimiento.Add(numeroInstancia)
            URLseguimiento.Add(Now.ToString)
            URLseguimiento.Add("PERDIDO")
            URLseguimiento.Add("Petición de mapa para ruta")
            URLseguimiento.Add(url1)
            URLseguimiento.Add("Superado el límite de 2048 caracteres")
        Else
            numeroInstancia += 1
            URLseguimiento.Add(numeroInstancia)
            URLseguimiento.Add(Now.ToString)
            URLseguimiento.Add("OK")
            URLseguimiento.Add("Petición de mapa para ruta")
            URLseguimiento.Add(url1)
            URLseguimiento.Add("sin excepción")
        End If
        'Añadimos para llevar referencia peticiones
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MapasRutaPasoaPaso_Load(sender, e)
    End Sub

   
    Private Sub ModoCarreteraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoCarreteraToolStripMenuItem.Click
        modo = "carreteras"
        siguienteMapa()
        cargarMapageneral()
    End Sub

    Private Sub ModoCarretera2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoCarretera2ToolStripMenuItem.Click
        modo = "carreteras2"
        siguienteMapa()
        cargarMapageneral()
    End Sub

    Private Sub ModoNormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoNormalToolStripMenuItem.Click
        modo = "normal"
        siguienteMapa()
        cargarMapageneral()
    End Sub
End Class