Imports System.Xml
Imports System.IO
Imports System.Xml.XPath
Imports System.ComponentModel

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
        WebBrowser1.Name = "WebBrowser1"
        WebBrowser1.ScriptErrorsSuppressed = True
        FormularioPrincipal.TabControl1.TabPages(contador).Controls.Add(WebBrowser1)
        abrirEspaña(WebBrowser1)
        WebBrowser1.Dock = DockStyle.Fill

    End Sub
    Sub SiguienteFicha(ByVal PestañaActual As TabPage) 'Siguiente ficha
        Dim paginaActual = FormularioPrincipal.TabControl1.SelectedIndex
        Try
            FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(paginaActual + 1)
        Catch
            'Si hay error está en la última pestaña y lo pasamos a la primera
            FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(0)
        End Try
    End Sub
    Sub AnteriorFicha(ByVal PestañaActual As TabPage) 'Siguiente ficha
        Dim numeroFIchas = FormularioPrincipal.TabControl1.TabCount
        Dim paginaActual = FormularioPrincipal.TabControl1.SelectedIndex
        Try
            FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(paginaActual - 1)
        Catch
            'Si hay error está en la última pestaña y lo pasamos a la primera
            FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(numeroFIchas - 1)
        End Try
    End Sub
    Sub CerrarFicha(ByVal PestañaActual As TabPage) 'Cerramos ficha

        Dim paginaActual = FormularioPrincipal.TabControl1.SelectedIndex

        If paginaActual > 0 Then

            ''liberamos el webbrowser
            Dim control As New WebBrowser()
            control = FormularioPrincipal.TabControl1.TabPages(paginaActual).Controls("WebBrowser1")
            control.Stop()
            control.Dispose()


            Dim numeroPagina = FormularioPrincipal.TabControl1.TabPages.IndexOf(PestañaActual)
            FormularioPrincipal.TabControl1.TabPages.Remove(FormularioPrincipal.TabControl1.TabPages(paginaActual))
            paginaActual -= 1
            FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(paginaActual)
            FormularioPrincipal.TabControl1.TabPages(paginaActual).Focus()

        End If

    End Sub

    Sub CerrarTodasFicha() 'Cerramos tasodas las fichas
        For i = FormularioPrincipal.TabControl1.TabCount - 1 To 1 Step -1

            ''Liberamos el webbrowser
            Dim control As New WebBrowser()
            control = FormularioPrincipal.TabControl1.TabPages(i).Controls("WebBrowser1")
            control.Dispose()

            FormularioPrincipal.TabControl1.TabPages.Remove(FormularioPrincipal.TabControl1.TabPages(i))
        Next

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


    Function listaXML(ByVal rutaDirectorio As String) 'Listar los archivos xml de un directorio
        Dim folder As New DirectoryInfo(rutaDirectorio) 'Directorio
        Dim listaDearchivos As New ArrayList
        For Each file As FileInfo In folder.GetFiles() 'Comprobamos si los archivos xml
            If file.ToString.EndsWith(".xml") = True Then
                listaDearchivos.Add(file.ToString)
            End If
        Next
        Return listaDearchivos
    End Function


    'IMPORTAR XML Y CREAR XML PARA EL LOG *********************************
    '**********************************************************

    Private Function comprobarArchivoLOG() As Boolean
        Dim folder As New DirectoryInfo(System.IO.Directory.GetCurrentDirectory()) 'Directorio
        For Each file As FileInfo In folder.GetFiles() 'Comprobamos si hay un archivo igual
            If file.ToString = "LOG.xml" Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub crearLOG(ByVal nombreArchivo As String)
        Try
            Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter(nombreArchivo, System.Text.Encoding.UTF8)
            myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
            myXmlTextWriter.WriteStartDocument(False)
            'Crear el elemento de documento principal.
            myXmlTextWriter.WriteStartElement("PeticionesHTTP")

            Dim contador As Integer = 0

            For i = 0 To Int((URLseguimiento.Count / 6)) - 1

                myXmlTextWriter.WriteStartElement("peticion")

                'Crear un elemento llamado 'feature' con un nodo de texto
                ' y cerrar el elemento.
                myXmlTextWriter.WriteStartElement("num_peticion")
                myXmlTextWriter.WriteString(URLseguimiento(contador))
                myXmlTextWriter.WriteEndElement()


                myXmlTextWriter.WriteStartElement("hora")
                myXmlTextWriter.WriteString(URLseguimiento(contador + 1))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("estatus")
                myXmlTextWriter.WriteString(URLseguimiento(contador + 2))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("servicio")
                myXmlTextWriter.WriteString(URLseguimiento(contador + 3))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("URL")
                myXmlTextWriter.WriteString(URLseguimiento(contador + 4))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("excepcion")
                myXmlTextWriter.WriteString(URLseguimiento(contador + 5))
                myXmlTextWriter.WriteEndElement()



                'Cerramos peticion
                myXmlTextWriter.WriteEndElement()
                contador += 6
            Next


            'Cerrar el elemento primario peticionesHTTP
            myXmlTextWriter.WriteEndElement()
            myXmlTextWriter.Flush()
            myXmlTextWriter.Close()

        Catch e As System.ArgumentException

        End Try
    End Sub


    Public Sub guardarLOG()
        If My.Settings.GuardarLOG = True Then
            If comprobarArchivoLOG() = True Then
                Try
                    'Preparamos el archivo xml
                    Dim NodeIter As XPathNodeIterator
                    Dim docNav As New XPathDocument("LOG.xml")
                    Dim nav = docNav.CreateNavigator
                    Dim Exnum, Exhora, Exestatus, Exservicio, ExURL, Exexcepcion As String

                    Exnum = "PeticionesHTTP/peticion/num_peticion"
                    Exhora = "PeticionesHTTP/peticion/hora"
                    Exestatus = "PeticionesHTTP/peticion/estatus"
                    Exservicio = "PeticionesHTTP/peticion/servicio"
                    ExURL = "PeticionesHTTP/peticion/URL"
                    Exexcepcion = "PeticionesHTTP/peticion/excepcion"



                    Dim numero As New ArrayList
                    Dim hora As New ArrayList
                    Dim estatus As New ArrayList
                    Dim servicio As New ArrayList
                    Dim URL As New ArrayList
                    Dim excepcion As New ArrayList

                    'Recorremos el xml
                    NodeIter = nav.Select(Exestatus)
                    While (NodeIter.MoveNext())
                        estatus.Add(NodeIter.Current.Value)
                    End While
                    NodeIter = nav.Select(Exexcepcion)
                    While (NodeIter.MoveNext())
                        excepcion.Add(NodeIter.Current.Value)
                    End While
                    NodeIter = nav.Select(Exhora)
                    While (NodeIter.MoveNext())
                        hora.Add(NodeIter.Current.Value)
                    End While
                    NodeIter = nav.Select(Exnum)
                    While (NodeIter.MoveNext())
                        numero.Add(NodeIter.Current.Value)
                    End While
                    NodeIter = nav.Select(Exservicio)
                    While (NodeIter.MoveNext())
                        servicio.Add(NodeIter.Current.Value)
                    End While
                    NodeIter = nav.Select(ExURL)
                    While (NodeIter.MoveNext())
                        URL.Add(NodeIter.Current.Value)
                    End While

                    Dim seguimientoAux As New ArrayList
                    For i = 0 To numero.Count - 1
                        seguimientoAux.Add(numero(i))
                        seguimientoAux.Add(hora(i))
                        seguimientoAux.Add(estatus(i))
                        seguimientoAux.Add(servicio(i))
                        seguimientoAux.Add(URL(i))
                        seguimientoAux.Add(excepcion(i))
                    Next

                    For Each item In URLseguimiento
                        seguimientoAux.Add(item)
                    Next
                    URLseguimiento = seguimientoAux
                    crearLOG("LOG.xml") 'Creamos el archivo de LOG
                Catch
                End Try

            Else
                crearLOG("LOG.xml") 'Creamos el archivo de LOG
            End If
        End If
    End Sub

    Public Sub ExportarLOGaXML(ByVal data As DataGridView, ByVal ruta As String)

        Try
            Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter(ruta, System.Text.Encoding.UTF8)
            myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
            myXmlTextWriter.WriteStartDocument(False)
            'Crear el elemento de documento principal.
            myXmlTextWriter.WriteStartElement("PeticionesHTTP")


            For filas As Integer = 0 To data.RowCount - 1
                myXmlTextWriter.WriteStartElement("peticion")
                '             <num_peticion>1</num_peticion>
                '<hora>21/11/2012 13:54:16</hora>
                '<estatus>OK</estatus>
                '<servicio>URL predeterminada (España)</servicio>
                '<URL>http://maps.google.es/maps?q=España&amp;output=embed</URL>
                '<excepcion>sin excepción</excepcion>
                'Crear un elemento llamado 'feature' con un nodo de texto
                ' y cerrar el elemento.
                myXmlTextWriter.WriteStartElement("num_peticion")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(0, filas).Value))
                myXmlTextWriter.WriteEndElement()


                myXmlTextWriter.WriteStartElement("hora")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(1, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("estatus")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(2, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("servicio")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(3, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("URL")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(4, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("excepcion")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(5, filas).Value))
                myXmlTextWriter.WriteEndElement()


                'Cerramos peticion
                myXmlTextWriter.WriteEndElement()
            Next


            'Cerrar el elemento primario <PeticionesHTTP>.
            myXmlTextWriter.WriteEndElement()
            myXmlTextWriter.Flush()
            myXmlTextWriter.Close()

        Catch
            MessageBox.Show("Caraceteres no válidos en el nombre del archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Sub rellenarGRidconXMLLOG(ByVal grid As DataGridView)
        Try
            'Preparamos el xml
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument("LOG.XML")
            Dim nav = docNav.CreateNavigator

            Dim Exnum, Exhora, Exestatus, Exservicio, ExURL, Exexcepcion As String

            Exnum = "PeticionesHTTP/peticion/num_peticion"
            Exhora = "PeticionesHTTP/peticion/hora"
            Exestatus = "PeticionesHTTP/peticion/estatus"
            Exservicio = "PeticionesHTTP/peticion/servicio"
            ExURL = "PeticionesHTTP/peticion/URL"
            Exexcepcion = "PeticionesHTTP/peticion/excepcion"



            Dim numero As New ArrayList
            Dim hora As New ArrayList
            Dim estatus As New ArrayList
            Dim servicio As New ArrayList
            Dim URL As New ArrayList
            Dim excepcion As New ArrayList

            'Recorremos el xml
            NodeIter = nav.Select(Exestatus)
            While (NodeIter.MoveNext())
                estatus.Add(NodeIter.Current.Value)
            End While
            NodeIter = nav.Select(Exexcepcion)
            While (NodeIter.MoveNext())
                excepcion.Add(NodeIter.Current.Value)
            End While
            NodeIter = nav.Select(Exhora)
            While (NodeIter.MoveNext())
                hora.Add(NodeIter.Current.Value)
            End While
            NodeIter = nav.Select(Exnum)
            While (NodeIter.MoveNext())
                numero.Add(NodeIter.Current.Value)
            End While
            NodeIter = nav.Select(Exservicio)
            While (NodeIter.MoveNext())
                servicio.Add(NodeIter.Current.Value)
            End While
            NodeIter = nav.Select(ExURL)
            While (NodeIter.MoveNext())
                URL.Add(NodeIter.Current.Value)
            End While

            For i = 0 To numero.Count - 1
                grid.Rows.Add(numero(i), hora(i), estatus(i), servicio(i), URL(i), excepcion(i))
            Next
        Catch e As System.IO.FileNotFoundException
            MessageBox.Show("El archivo no se ha encontrado. Es posible que no haya activado la opción de guardar todas las peticiones HTTP de las diferentes sesiones." & vbCrLf & "Si desea activarlo, acceda al menú Configuración/Opciones/Registro y reinicie el programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch e As Exception
            MessageBox.Show("Algo ha ocurrido, por favor, inténtelo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub



    '*************************************************


    'IMPORTAR XML Y CREAR XML DE ESTILOS *********************************
    '**********************************************************

    Private Function comprobarDato(ByVal cadena As String)
        If cadena = "" Then
            comprobarDato = "NO_DATA"
        Else
            comprobarDato = cadena
        End If
    End Function

    Private Function comprobarDatoInversa(ByVal cadena As String)
        If cadena = "NO_DATA" Then
            comprobarDatoInversa = ""
        Else
            comprobarDatoInversa = cadena
        End If
    End Function

    Public Function verificarNombreArchivo(ByVal nombreArchivo As String) As Boolean
        verificarNombreArchivo = True

        Dim folder As New DirectoryInfo(System.IO.Directory.GetCurrentDirectory()) 'Directorio
        For Each file As FileInfo In folder.GetFiles() 'Comprobamos si hay un archivo igual
            If file.ToString = nombreArchivo & ".xml" Then
                verificarNombreArchivo = False
            End If
        Next

    End Function

    Public Sub guardarDataGrid(ByVal data As DataGridView, ByVal nombreArchivo As String)

        Try
            Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter(nombreArchivo & ".xml", System.Text.Encoding.UTF8)
            myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
            myXmlTextWriter.WriteStartDocument(False)
            'Crear el elemento de documento principal.
            myXmlTextWriter.WriteStartElement("config_maps_styles")
            myXmlTextWriter.WriteStartElement("styles")


            For filas As Integer = 0 To data.RowCount - 1
                myXmlTextWriter.WriteStartElement("style")

                'Crear un elemento llamado 'feature' con un nodo de texto
                ' y cerrar el elemento.
                myXmlTextWriter.WriteStartElement("feature")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(0, filas).Value))
                myXmlTextWriter.WriteEndElement()


                myXmlTextWriter.WriteStartElement("element")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(1, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("hue")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(2, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("lightness")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(3, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("saturation")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(4, filas).Value))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("gamma")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(5, filas).Value))
                myXmlTextWriter.WriteEndElement()


                myXmlTextWriter.WriteStartElement("visibility")
                myXmlTextWriter.WriteString(comprobarDato(data.Item(6, filas).Value))
                myXmlTextWriter.WriteEndElement()


                'Cerramos style
                myXmlTextWriter.WriteEndElement()
            Next

            'Cerrar el elemento style.
            myXmlTextWriter.WriteEndElement()
            'Cerrar el elemento primario config_maps_styles.
            myXmlTextWriter.WriteEndElement()
            myXmlTextWriter.Flush()
            myXmlTextWriter.Close()

        Catch e As System.ArgumentException
            MessageBox.Show("Caraceteres no válidos en el nombre del archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub rellenarGRidconXML(ByVal grid As DataGridView, ByVal rutaArchivo As String)
        Try
            'Preparamos el xml
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(rutaArchivo)
            Dim nav = docNav.CreateNavigator

            'Preparamos las rutas
            Dim Exfeature, Exelement, Exhue, Exlightness, Exsaturation, Exgamma, Exvisibility As String

            Exfeature = "config_maps_styles/styles/style/feature"
            Exelement = "config_maps_styles/styles/style/element"
            Exhue = "config_maps_styles/styles/style/hue"
            Exlightness = "config_maps_styles/styles/style/lightness"
            Exsaturation = "config_maps_styles/styles/style/saturation"
            Exgamma = "config_maps_styles/styles/style/gamma"
            Exvisibility = "config_maps_styles/styles/style/visibility"

            Dim features, elements, hues, lightness, saturations, gammas, visibilities As New ArrayList

            'Recorremos el xml
            NodeIter = nav.Select(Exfeature)
            While (NodeIter.MoveNext())
                features.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exelement)
            While (NodeIter.MoveNext())
                elements.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exhue)
            While (NodeIter.MoveNext())
                hues.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exlightness)
            While (NodeIter.MoveNext())
                lightness.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exsaturation)
            While (NodeIter.MoveNext())
                saturations.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exgamma)
            While (NodeIter.MoveNext())
                gammas.Add(NodeIter.Current.Value)
            End While

            NodeIter = nav.Select(Exvisibility)
            While (NodeIter.MoveNext())
                visibilities.Add(NodeIter.Current.Value)
            End While

            For i = 0 To features.Count - 1
                grid.Rows.Add(comprobarDatoInversa(features(i)), comprobarDatoInversa(elements(i)), comprobarDatoInversa(hues(i)), comprobarDatoInversa(lightness(i)), comprobarDatoInversa(saturations(i)), comprobarDatoInversa(gammas(i)), comprobarDatoInversa(visibilities(i)))
            Next
        Catch
        End Try

    End Sub

    Public Function comprobarEstilo(ByVal rutaArchivo As String)
        Try

            'Preparamos el archivo xml
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument(rutaArchivo)
            Dim nav = docNav.CreateNavigator
            Dim ExBuscar As String
            ExBuscar = "config_maps_styles"


            Dim buscar As New ArrayList
            'Recorremos el xml
            NodeIter = nav.Select(ExBuscar)
            While (NodeIter.MoveNext())
                buscar.Add(NodeIter.Current.Value)
            End While

            If buscar.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch
            Return False
        End Try
    End Function



    'FIN DE IMPORTAR/CREAR XML *************************
    '***************************************************


    'AUTOCOMPLETADO*******************************

    'Private Function comprobarArchivo() As Boolean
    '    Dim folder As New DirectoryInfo(System.IO.Directory.GetCurrentDirectory()) 'Directorio
    '    For Each file As FileInfo In folder.GetFiles() 'Comprobamos si hay un archivo igual
    '        If file.ToString = "Autocompletado.xml" Then
    '            Return True
    '        End If
    '    Next
    '    Return False
    'End Function

    'Public Sub autocompletar(ByVal valorGuardado As String)
    '    Try

    '        listaAutocompletar.Add(valorGuardado)
    '        ' Array of strings.
    '        Dim autoArray() As String
    '        autoArray = DirectCast(listaAutocompletar.ToArray(GetType(String)), String())
    '        MySource.AddRange(autoArray)
    '    Catch
    '    End Try
    'End Sub



    Public Sub cargarAutocompletado()

        Try
            'Preparamos el archivo xml
            Dim NodeIter As XPathNodeIterator
            Dim docNav As New XPathDocument("Autocompletado.xml")
            Dim nav = docNav.CreateNavigator
            Dim ExBuscar As String

            ExBuscar = "autocompletado/dato"


            Dim buscar As New ArrayList
            'Recorremos el xml
            NodeIter = nav.Select(ExBuscar)
            While (NodeIter.MoveNext())
                listaAutocompletar.Add(NodeIter.Current.Value)
            End While

        Catch
        End Try
    End Sub

    Public Sub precargaAutocompletar()
        Try
            ' Array of strings.
            Dim autoArray() As String
            autoArray = DirectCast(listaAutocompletar.ToArray(GetType(String)), String())

            'Con .distinct.toarray eliminaos duplicidades
            autoArray = autoArray.Distinct.ToArray
            listaAutocompletar = New ArrayList(autoArray)
            MySource.AddRange(autoArray)

        Catch
        End Try
    End Sub


    Public Sub autocompletar(ByVal valorGuardado() As String, Optional ByVal valorGuardadoOpcional() As String = Nothing)
        If My.Settings.Autocompletado = True Then 'Si la función está activada
            Try
                For Each item In valorGuardado
                    listaAutocompletar.Add(item)
                    ' Array of strings.
                    Dim autoArray() As String
                    autoArray = DirectCast(listaAutocompletar.ToArray(GetType(String)), String())
                    MySource.AddRange(autoArray)
                Next

                'Si hay valor adiccional (opcional) y la variable global setDireccionEncontrada es verdadera
                'My.Settings.SetDireccionEncontrada sirve para saber si se guardan las direcciones encontradas
                'o sólo lo que escribe el usuario
                If valorGuardadoOpcional IsNot Nothing And My.Settings.SetDireccionEncontrada = True Then
                    For Each item In valorGuardadoOpcional
                        listaAutocompletar.Add(item)
                        ' Array of strings.
                        Dim autoArray() As String
                        autoArray = DirectCast(listaAutocompletar.ToArray(GetType(String)), String())
                        MySource.AddRange(autoArray)
                    Next

                End If
            Catch
            End Try
        End If
    End Sub

    Public Sub CargarControles(ByVal formulario As Form) 'Hace que los txt admitan la función de automcompletado
        If My.Settings.Autocompletado = True Then 'Si la función está activada
            For Each c As Control In formulario.Controls
                If TypeOf c Is TextBox Then
                    Dim txt As New TextBox
                    txt = c
                    With txt
                        .AutoCompleteCustomSource = MySource
                        .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                        .AutoCompleteSource = AutoCompleteSource.CustomSource
                    End With
                End If
            Next
        End If
    End Sub

    Sub GuardarAutocompletarXML()
        If My.Settings.SettingAutocompletar = True Then 'Si está configurado para que se guarde

            Try
                Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter("Autocompletado.xml", System.Text.Encoding.UTF8)
                myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
                myXmlTextWriter.WriteStartDocument(False)

                'Crear el elemento de documento principal.
                myXmlTextWriter.WriteStartElement("autocompletado")


                For Each item In listaAutocompletar

                    'Agregamos datos
                    myXmlTextWriter.WriteStartElement("dato")
                    myXmlTextWriter.WriteString(comprobarDato(item.ToString))
                    myXmlTextWriter.WriteEndElement()

                Next

                'Cerrar el elemento primario <autocompletado>
                myXmlTextWriter.WriteEndElement()
                myXmlTextWriter.Flush()
                myXmlTextWriter.Close()


            Catch
            End Try
        End If
    End Sub
    '**********************************
    'FIN DE AUTOCOMPLETADO***********

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

    'Traducir los recursos de los mapas (mapas estáticos)
    Function traducirRecursos(ByVal nombreTraducir As String)
        Dim retornoTraducido As String = "error"
        Select Case nombreTraducir
            Case "Administrativas"
                retornoTraducido = "administrative"
            Case "Administrativas_países"
                retornoTraducido = "administrative.country"
            Case "Administrativas_parcela tierra"
                retornoTraducido = "administrative.land_parcel"
            Case "Administrativas_localidad"
                retornoTraducido = "administrative.locality"
            Case "Administrativas_vecindad"
                retornoTraducido = "administrative.neighborhood"
            Case "Administrativas_provincia"
                retornoTraducido = "administrative.province"
            Case "Todo"
                retornoTraducido = "all"
            Case "Paisaje"
                retornoTraducido = "landscape"
            Case "Paisajes_humanos"
                retornoTraducido = "landscape.man_made"
            Case "Paisajes_naturales"
                retornoTraducido = "landscape.natural"
            Case "Paisajes_naturales_cubierta terrestre"
                retornoTraducido = "landscape.natural.landcover"
            Case "Paisajes_naturales_terreno"
                retornoTraducido = "landscape.natural.terrain"
            Case "Punto de interés"
                retornoTraducido = "poi"
            Case "Punto de interés_turístico"
                retornoTraducido = "poi.attraction"
            Case "Punto de interés_negocios"
                retornoTraducido = "poi.business"
            Case "Punto de interés_edificios estatales"
                retornoTraducido = "poi.government"
            Case "Puntos de interés_médicos"
                retornoTraducido = "poi.medical"
            Case "Punto de interés_parques"
                retornoTraducido = "poi.park"
            Case "Punto de interés_lugares de culto"
                retornoTraducido = "poi.place_of_worship"
            Case "Punto de interés_escuelas"
                retornoTraducido = "poi.school"
            Case "Punto de interés_instalaciones deportivas"
                retornoTraducido = "poi.sports_complex"
            Case "Carreteras"
                retornoTraducido = "road"
            Case "Carreteras_principales"
                retornoTraducido = "road.arterial"
            Case "Carreteras_autopistas"
                retornoTraducido = "road.highway"
            Case "Carreteras_acceso controlado"
                retornoTraducido = "road.highway.controlled_access"
            Case "Carreteras_locales"
                retornoTraducido = "road.local"
            Case "Transportes"
                retornoTraducido = "transit"
            Case "Transportes_línea"
                retornoTraducido = "transit.line"
            Case "Transportes_estación"
                retornoTraducido = "transit.station"
            Case "Transportes_estación_aeropuerto"
                retornoTraducido = "transit.station.airport"
            Case "Transportes_estación_bus"
                retornoTraducido = "transit.station.bus"
            Case "Transportes_estación_tren"
                retornoTraducido = "transit.station.rail"
            Case "Agua"
                retornoTraducido = "water"
        End Select
        Return retornoTraducido
    End Function
End Class
