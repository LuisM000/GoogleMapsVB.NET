Public Class MapasRuta

    Dim polilineasMapa As ArrayList
    Dim indicacionesMapa As ArrayList
    Dim modo As String = "carreteras"
    Sub New(ByVal datosPolilinea As ArrayList, ByVal Indicaciones As ArrayList)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        polilineasMapa = datosPolilinea
        indicacionesMapa = Indicaciones
    End Sub
    Private Sub MapasRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 900
        Me.Height = 587
        Dim mapas As New MapsNet

        Me.MenuStrip1.Visible = True

        Me.Panel1.HorizontalScroll.Visible = True
        '-- Scroll Vertical
        Me.Panel1.VerticalScroll.Visible = True
        Me.Panel1.AutoScroll = True
        Dim conjuntoPict(polilineasMapa.Count - 1) As WebBrowser


        Dim alto As Integer = 20

        Dim tamaño(1) As Integer
        tamaño = {(450), (200)}
        For i = 0 To conjuntoPict.Count - 1  'For para picturebox
            Dim url1 = "http://maps.google.com/maps/api/staticmap?&size=400x150&format=png&maptype=roadmap&language=es&path=color:0xFF0000|weight:6|enc:"
            Select Case modo
                Case "carreteras"
                    url1 = url1 & polilineasMapa(i) & "&style=feature:road.local%7Celement:geometry%7Chue:0x00ff00%7Csaturation:100&style=feature:landscape%7Celement:geometry%7Clightness:-100&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
                Case "normal"
                    url1 = url1 & polilineasMapa(i) & "&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
                Case "carreteras2"
                    url1 = url1 & polilineasMapa(i) & "&style=feature:road.highway%7Celement:geometry%7Chue:0xff0022%7Csaturation:60%7Clightness:-20&style=feature:road.arterial%7Celement:geometry%7Chue:0x2200ff%7Clightness:-40:visibility:simplified%7Csaturation:30&style=feature:road.local%7Chue:0xf6ff00%7Csaturation:60%7Cgamma:0.7%7Cvisibility:simplified&style=feature:water%7Celement:geometry%7Csaturation:40%7Clightness:40&style=road.highway%7Celement:labels%7Cvisibility:on%7Csaturation:98&style=feature:administrative.locality%7Celement:labels%7Chue:0x0022ff%7Csaturation:50%7Clightness:-10%7Cgamma:0.9&style=feature:transit.line%7Celement:geometry%7Chue:0xff0000%7Cvisibility:on%7Clightness:-70&sensor=false&key=AIzaSyCzWaJYw_MW87ganzyaVlxB9igfGMTTrW8"
                Case Else
                    url1 = url1 & polilineasMapa(i) & "&sensor=false"
            End Select
            Dim urlF As New Uri(url1)
            conjuntoPict(i) = New WebBrowser
            conjuntoPict(i).Width = 450
            conjuntoPict(i).Height = 200
            conjuntoPict(i).ScrollBarsEnabled = False
            conjuntoPict(i).Url = urlF
            Panel1.Controls.Add(conjuntoPict(i))
            conjuntoPict(i).Location = New Size(20, alto)
            alto += 230

          
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
         
        Next


        Dim labelInfo(indicacionesMapa.Count - 1) As Label
        alto = 90
        For i = 0 To indicacionesMapa.Count - 1  'For para labels
            'Labels
            labelInfo(i) = New Label
            Panel1.Controls.Add(labelInfo(i))
            labelInfo(i).Text = mapas.QuitarEtiqueta(indicacionesMapa(i).ToString)
            labelInfo(i).Size = New Size(370, 180)
            labelInfo(i).Location = New Size(490, alto)
            labelInfo(i).Font = New Font("Segoe UI", 10)
            alto += 230
            '-----
        Next
        'Label general
        Dim labelgen As New Label
        Panel1.Controls.Add(labelgen)
        labelgen.Text = "Mapa completo de la ruta"
        labelgen.Size = New Size(370, 180)
        labelgen.Location = New Size(490, alto)
        labelgen.Font = New Font("Segoe UI", 10)


    End Sub

    Private Sub ModoCarreteraToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModoCarreteraToolStripMenuItem.Click
        Panel1.Controls.Clear()
        modo = "carreteras"
        MapasRuta_Load(sender, e)
    End Sub

    Private Sub ModoNormalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModoNormalToolStripMenuItem.Click
        Panel1.Controls.Clear()
        modo = "normal"
        MapasRuta_Load(sender, e)
    End Sub

    Private Sub ModoCarretera2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoCarretera2ToolStripMenuItem.Click
        Panel1.Controls.Clear()
        modo = "carreteras2"
        MapasRuta_Load(sender, e)
    End Sub
End Class