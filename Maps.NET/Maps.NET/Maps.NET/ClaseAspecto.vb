Public Class AspectoFormulario


    Sub TabControlYpanel() 'Ajustamos el tabcontrol al panel
        FormularioPrincipal.TabControl1.Dock = DockStyle.Fill
        FormularioPrincipal.TabControl1.Padding = New Size(10, 7)
    End Sub

    Sub NuevaFicha(Optional ByVal nombreficha As String = "") 'Creamos nueva ficha
        Dim contador = FormularioPrincipal.TabControl1.TabCount
        Dim nombre = "Maps" & contador + 1
        If nombreficha <> "" Then
            nombre = nombreficha
        End If
        FormularioPrincipal.TabControl1.TabPages.Add(nombre)
        FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(contador)
        Dim WebBrowser1 As New WebBrowser
        FormularioPrincipal.TabControl1.TabPages(contador).Controls.Add(WebBrowser1)
        abrirEspaña(WebBrowser1)
        WebBrowser1.Dock = DockStyle.Fill
    End Sub
    Sub CerrarFicha(ByVal PestañaActual As TabPage) 'Cerramos ficha
        Dim paginaActual = FormularioPrincipal.TabControl1.SelectedIndex
        If paginaActual > 0 Then
            FormularioPrincipal.TabControl1.TabPages.Remove(PestañaActual)
            Dim numeroPagina = FormularioPrincipal.TabControl1.TabPages.IndexOf(PestañaActual)
            paginaActual -= 1
            FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(paginaActual)
        End If
    End Sub

    Sub abrirEspaña(ByVal browser As WebBrowser) 'Abrimos España en el Webbrowser
        browser.Url = New Uri("http://maps.google.es/maps?q=España&output=embed")
        'Seguimiento de las variables
        numeroInstancia += 1
        URLseguimiento.Add(numeroInstancia)
        URLseguimiento.Add(Now.ToString)
        URLseguimiento.Add("OK")
        URLseguimiento.Add("URL predeterminada (España)")
        URLseguimiento.Add("http://maps.google.es/maps?q=España&output=embed")
        URLseguimiento.Add("sin excepción")


    End Sub

    Public Function NavegadorActual(ByVal pestañaActiva As Integer) 'Enviamos el WebBrowser de la pestaña activa
        Dim NavegadorActivo = FormularioPrincipal.TabControl1.TabPages(pestañaActiva).Controls()
        Dim navegador As WebBrowser
        navegador = NavegadorActivo(0)
        Return navegador
    End Function
  
    Public Function verificarnumeros(ByVal datos As String) 'Enviamos True si el dato es número
        Dim dato As Boolean = False
        If IsNumeric(datos) Then
            dato = True
        Else
            dato = False
        End If
        Return dato
    End Function

    Function CargarImagenURL(ByVal enlace As String) 'Carga imagen directamente desde URL
        Dim BItmapOriginal As New Bitmap(My.Resources.cancel)
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

    Function URLactual() 'Saber url de la pestaña activa
        Dim navegador As WebBrowser
        navegador = Me.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
        Return (navegador.Url)

    End Function
    Function DevuelveEstablecimientosIngles(ByVal Establecimientos As ArrayList) 'TRasnformamos a idioma válido para places
        Dim establIngles As New ArrayList
        Dim valor As String = "establishment"
        For Each item As Object In Establecimientos

            Select Case item
                'COMUNES
                Case "Ayuntamiento"
                    valor = "city_hall"
                Case "Banco"
                    valor = "bank"
                Case "Biblioteca"
                    valor = "library"
                Case "Cajero automático"
                    valor = "atm"
                Case "Centro comercial"
                    valor = "shopping_mall"
                Case "Cine"
                    valor = "movie_theater"
                Case "Comida"
                    valor = "food"
                Case "Estación de bus"
                    valor = "bus_station"
                Case "Estación de metro"
                    valor = "subway_station"
                Case "Gasolinera"
                    valor = "gas_station"
                Case "Oficina de correos"
                    valor = "post_office"
                Case "Supermercado"
                    valor = "grocery_or_supermarket"

                    'TRANSPORTE
                Case "Aeropuerto"
                    valor = "airport"
                Case "Estación de bus"
                    valor = "bus_station"
                Case "Estación de metro"
                    valor = "subway_station"
                Case "Estación de tren"
                    valor = "train_station"
                Case "Parada de taxis"
                    valor = "taxi_stand"



                    'OCIO AIRE LIBRE
                Case "Acuario"
                    valor = "aquarium"
                Case "Camping"
                    valor = "campground"
                Case "Estadio"
                    valor = "stadium"
                Case "Parque de atracciones"
                    valor = "amusement_park"
                Case "RV Park"
                    valor = "rv_park"
                Case "Zoo"
                    valor = "zoo"



                    'OCIO INTERIOR
                Case "Bolera"
                    valor = "bowling_alley"
                Case "Casino"
                    valor = "casino"
                Case "Cine"
                    valor = "movie_theater"
                Case "Galería de arte"
                    valor = "art_gallery"
                Case "Museo"
                    valor = "museum"
                Case "Parque"
                    valor = "park"
                Case "Spa"
                    valor = "spa"



                    'COMIDA
                Case "Comida"
                    valor = "food"
                Case "Comida para llevar"
                    valor = "meal_takeaway"
                Case "Entrega de comida"
                    valor = "meal_delivery"
                Case "Panadería"
                    valor = "bakery"
                Case "Restaurante"
                    valor = "restaurant"
                Case "Supermercado"
                    valor = "grocery_or_supermarket"
                Case "Tienda de licor"
                    valor = "liquor_store"


                    'SERVICIOS FINANCIEROS
                Case "Banco"
                    valor = "bank"
                Case "Cajero automático"
                    valor = "atm"
                Case "Contabilidad"
                    valor = "accounting"
                Case "Finanzas"
                    valor = "finance"


                    'SERVICIOS BÁSICOS
                Case "Escuela"
                    valor = "school"
                Case "Farmacia"
                    valor = "pharmacy"
                Case "Hospital"
                    valor = "hospital"
                Case "Médico"
                    valor = "doctor"
                Case "Salud"
                    valor = "health"
                Case "Tienda de artículos básicos"
                    valor = "home_goods_store"


                    'BARES
                Case "Bar"
                    valor = "bar"
                Case "Café"
                    valor = "cafe"
                Case "Night Club"
                    valor = "night_club"



                    'RELIGIÓN
                Case "Cementerio"
                    valor = "cemetery"
                Case "Iglesia"
                    valor = "church"
                Case "Lugar de culto"
                    valor = "place_of_worship"
                Case "Mezquita"
                    valor = "mosque"
                Case "Sinagoga"
                    valor = "synagogue"
                Case "Templo hindú"
                    valor = "hindu_temple"


                    'PÚBLICOS
                Case "Ayuntamiento"
                    valor = "city_hall"
                Case "Embajada"
                    valor = "embassy"
                Case "Oficina de correos"
                    valor = "post_office"
                Case "Oficina del gobierno local"
                    valor = "local_government_office"
                Case "Palacio de Justicia"
                    valor = "courthouse"
                Case "Parque de bomberos"
                    valor = "fire_station"
                Case "Policía"
                    valor = "police"
                Case "Universidad"
                    valor = "university"



                    'OTROS
                Case "Abogado"
                    valor = "lawyer"
                Case "Agencia de seguros"
                    valor = "insurance_agency"
                Case "Agencia de viajes"
                    valor = "travel_agency"
                Case "Alquiler de coches"
                    valor = "car_rental"
                Case "Alquiler de películas"
                    valor = "movie_rental"
                Case "Agencia inmobiliaria"
                    valor = "real_estate_agency"
                Case "Almacén"
                    valor = "storage"
                Case "Alojamiento"
                    valor = "lodging"
                Case "Biblioteca"
                    valor = "library"
                Case "Centro comercial"
                    valor = "shopping_mall"
                Case "Cerrajero"
                    valor = "locksmith"
                Case "Clínica veterinaria"
                    valor = "veterinary_care"
                Case "Concesionario"
                    valor = "car_dealer"
                Case "Contratista de techos"
                    valor = "roofing_contractor"
                Case "Contratista general"
                    valor = "general_contractor"
                Case "Dentista"
                    valor = "dentist"
                Case "Droguería"
                    valor = "hardware_store"
                Case "Electricista"
                    valor = "electrician"
                Case "Empresa de mudanzas"
                    valor = "moving_company"
                Case "Establecimiento"
                    valor = "establishment"
                Case "Fisioterapeuta"
                    valor = "physiotherapist"
                Case "Florista"
                    valor = "florist"
                Case "Fontanero"
                    valor = "plumber"
                Case "Funeraria"
                    valor = "funeral_home"
                Case "Gasolinera"
                    valor = "gas_station"
                Case "Gimnasio"
                    valor = "gym"
                Case "Grandes almacenes"
                    valor = "department_store"
                Case "Joyería"
                    valor = "jewelry_store"
                Case "Lavandería"
                    valor = "laundry"
                Case "Lavado de coches"
                    valor = "car_wash"
                Case "Librería"
                    valor = "book_store"
                Case "Parking"
                    valor = "parking"
                Case "Peluquería"
                    valor = "hair_care"
                Case "Pintor"
                    valor = "painter"
                Case "Reparación de automóviles"
                    valor = "car_repair"
                Case "Salón de belleza"
                    valor = "beauty_salon"
                Case "Tienda de bicicletas"
                    valor = "bicycle_store"
                Case "Tienda de conveniencia"
                    valor = "convenience_store"
                Case "Tienda de electrónica"
                    valor = "electronics_store"
                Case "Tienda de mascotas"
                    valor = "pet_store"
                Case "Tienda de muebles"
                    valor = "furniture_store"
                Case "Tienda de ropa"
                    valor = "clothing_store"
                Case "Zapatería"
                    valor = "shoe_store"
                Case Else
                    valor = "establishment"
            End Select
            establIngles.Add(valor)
        Next
        Return establIngles
    End Function

    Sub guardarcomo(ByVal bmp As Bitmap, ByVal nombre As String, Optional ByVal filtrado As Integer = 3) 'Guardar imagen
        Dim salvar As New SaveFileDialog
        With salvar
            .Filter = "Ficheros BMP|*.bmp" & _
                      "|Ficheros GIF|*.gif" & _
                      "|Ficheros JPG o JPEG|*.jpg;*.jpeg" & _
                      "|Ficheros PNG|*.png" & _
                      "|Ficheros TIFF|*.tif"
            .FilterIndex = filtrado
            .FileName = nombre
            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then

                If salvar.FileName <> "" Then
                    Dim fs As System.IO.FileStream = CType(salvar.OpenFile(), System.IO.FileStream)
                    Select Case salvar.FilterIndex
                        Case 1
                            bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp)
                        Case 2
                            bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Gif)
                        Case 3
                            bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Case 4
                            bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
                        Case 5
                            bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff)
                    End Select
                    fs.Close()
                End If
            End If
        End With
    End Sub
End Class
