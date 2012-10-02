Public Class MostarTodosStreetViewvb

    Dim datosRutaE() As String
    Dim Direcciones As New ArrayList
    Sub New(ByVal datosRuta() As String, ByVal coordOrignDestin As ArrayList)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        datosRutaE = datosRuta
        Direcciones = coordOrignDestin
    End Sub

    Private Sub MostarTodosStreetViewvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = 880
        Me.Height = 587
        Dim mapas As New MapsNet

        'Creamos arraylist de las coordenadas
        Dim coordenadasPuntos As New ArrayList
        Dim coordenadasIncial As New ArrayList
        'Creamos arraylist de las direcciones
        Dim DireccionesPuntos As New ArrayList



        'Guardamos la primera dirección
        DireccionesPuntos.Add("INICIO DE TRAYECTO. " & Direcciones(0))


        'La dirección inicial y final no está en lat/long, la transformamos
        Direcciones(0) = Direcciones(0).ToString.Replace(" ", "+")
        Direcciones(1) = Direcciones(1).ToString.Replace(" ", "+")
        coordenadasIncial = (mapas.CodificacionGeografica(Direcciones(0)))

        'Incluimos coordenadas inciales
        coordenadasPuntos.Add(coordenadasIncial(0))
        coordenadasPuntos.Add(coordenadasIncial(1))

        For i = 0 To UBound(datosRutaE) - 1 Step 5
            coordenadasPuntos.Add(datosRutaE(i))
            coordenadasPuntos.Add(datosRutaE(i + 1))
            DireccionesPuntos.Add(datosRutaE(i + 4))

        Next

        'Guardamos la última dirección
        Direcciones(1) = Direcciones(1).ToString.Replace("+", " ")
        DireccionesPuntos.Add("FIN DE TRAYECTO. " & Direcciones(1))


        'Incluimos coordenadas finales
        coordenadasIncial = (mapas.CodificacionGeografica(Direcciones(1)))
        coordenadasPuntos.Add(coordenadasIncial(0))
        coordenadasPuntos.Add(coordenadasIncial(1))



        Me.Panel1.HorizontalScroll.Visible = True
        '-- Scroll Vertical
        Me.Panel1.VerticalScroll.Visible = True
        Me.Panel1.AutoScroll = True
        Dim conjuntoPict(coordenadasPuntos.Count - 1) As PictureBox


        Dim alto As Integer = 20
        Dim bmp As New Bitmap(400, 150)

        Dim latlong(1) As Double
        Dim tamaño(1) As Integer
        tamaño = {(400), (150)}
        For i = 0 To conjuntoPict.Count - 2 Step 2 'For para picturebox
            latlong(0) = coordenadasPuntos(i).ToString
            latlong(1) = coordenadasPuntos(i + 1).ToString

            conjuntoPict(i) = New PictureBox
            conjuntoPict(i).Width = 400
            conjuntoPict(i).Height = 150
            bmp = mapas.StreetView(latlong, tamaño, , , )
            Panel1.Controls.Add(conjuntoPict(i))
            conjuntoPict(i).Image = bmp
            conjuntoPict(i).Location = New Size(20, alto)
            conjuntoPict(i).BorderStyle = BorderStyle.FixedSingle
            alto += 180
        Next

        Dim labelInfo(DireccionesPuntos.Count - 1) As Label
        alto = 70
        For i = 0 To DireccionesPuntos.Count - 1  'For para labels
            'Labels
            labelInfo(i) = New Label
            Panel1.Controls.Add(labelInfo(i))
            labelInfo(i).Text = mapas.QuitarEtiqueta(DireccionesPuntos(i).ToString)
            labelInfo(i).Size = New Size(370, 180)
            labelInfo(i).Location = New Size(460, alto)
            labelInfo(i).Font = New Font("Segoe UI", 10)
            alto += 180
            '-----
        Next
    End Sub
End Class