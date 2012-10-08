Imports System.Text.RegularExpressions

Public Class Rutas
    Dim hitos As New ArrayList

    'MANEJO DE HITOS****************************************************************************
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Añadimos hito
        Dim mapas As New MapsNet
        txtdirEncHito.Text = ""
        'Comprobamos hito
        Dim datosOrigen = mapas.CodificacionGeografica(txtdirhito.Text)
        Try
            txtlatHito.Text = datosOrigen(0)
            txtlngHito.Text = datosOrigen(1)
            txtdirEncHito.Text = datosOrigen(2)
        Catch ex As Exception
            txtlatHito.Text = "No encontrado"
            txtlngHito.Text = "No encontrado"
            txtdirEncHito.Text = ""
        End Try


        If txtdirEncHito.Text <> "" Then
            txtdirhito.Text = ""
            Dim aspecto As New AspectoFormulario
            If txtdirEncHito.Text <> "" Then
                Dim contador = ListBox1.Items.Count + 1
                Dim cadena As String = "Punto " & contador & " - " & "<coordenadas>" & txtlatHito.Text & "," & txtlngHito.Text & "</coordenadas>" & " - " & "<hito>" & txtdirEncHito.Text & "</hito>"
                ListBox1.Items.Add(cadena)
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
        Catch
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ListBox1.Items.Clear()
        Catch
        End Try
    End Sub
    'Fin MANEJO DE HITOS****************************************************************************




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim mapas As New MapsNet
        'Dirección origen
        If txtdirorigen.Text <> "" Then
            Dim datosOrigen = mapas.CodificacionGeografica(txtdirorigen.Text)
            Try
                txtlatOrigen.Text = datosOrigen(0)
                txtlngOrigen.Text = datosOrigen(1)
                txtdirEncOrig.Text = datosOrigen(2)
                PictureBox1.Image = My.Resources.check
            Catch ex As Exception
                txtlatOrigen.Text = "No encontrado"
                txtlngOrigen.Text = "No encontrado"
                txtdirEncOrig.Text = ""
                PictureBox1.Image = My.Resources.cancel
            End Try
        Else
            PictureBox1.Image = My.Resources.cancel
        End If

        'Dirección destino
        If txtdirdestin.Text <> "" Then
            Dim datosOrigen = mapas.CodificacionGeografica(txtdirdestin.Text)
            Try
                txtlatDestin.Text = datosOrigen(0)
                txtlngDestin.Text = datosOrigen(1)
                txtdirEncDest.Text = datosOrigen(2)
                PictureBox2.Image = My.Resources.check
            Catch ex As Exception
                txtlatDestin.Text = "No encontrado"
                txtlngDestin.Text = "No encontrado"
                txtdirEncDest.Text = ""
                PictureBox2.Image = My.Resources.cancel
            End Try
        Else
            PictureBox2.Image = My.Resources.cancel
        End If



      

    End Sub

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then
            Dim maps As New MapsNet

            'Peajes
            Dim peajes = 0
            If ComboBox2.SelectedIndex() = 0 Then
                peajes = 0
            ElseIf ComboBox2.SelectedIndex() = 1 Then
                peajes = 1
            Else
                peajes = 2
            End If
            If ComboBox2.SelectedIndex() = -1 Then peajes = 0

            'Transporte
            Dim transporte = 0
            If ComboBox1.SelectedIndex() = 0 Then
                transporte = 0
            ElseIf ComboBox1.SelectedIndex() = 1 Then
                transporte = 1
            Else
                transporte = 2
            End If
            If ComboBox1.SelectedIndex() = -1 Then transporte = 0

            'Optimizar
            Dim optimizar As Boolean = False
            If CheckBox1.Checked = True Then
                optimizar = True
            Else
                optimizar = False
            End If

            'Guardamos en un arraylist los hitos
            Dim lista = ListBox1.Items
            Dim RegExp As String = "<hito[^>]*>[^<]*</hito>"
            Dim R As New Regex(RegExp)
            hitos.Clear()
            For Each item In lista
                Dim mc As MatchCollection = R.Matches(item)
                If mc.Count > 0 Then
                    For Each m In mc
                        Dim cadena = ((m.Result("$0").ToString))
                        hitos.Add(cadena.ToString.Replace("<hito>", "").Replace("</hito>", ""))
                    Next
                End If
            Next

            'Coordenadas inicio/fin recorrido
            Dim coord As New ArrayList
            coord.Add(txtlatOrigen.Text)
            coord.Add(txtlngOrigen.Text)
            coord.Add(txtlatDestin.Text)
            coord.Add(txtlngDestin.Text)



            '---------------------------
            Dim datosruta = maps.Rutas(txtdirorigen.Text, txtdirdestin.Text, transporte, hitos, optimizar, peajes, , )
            Select Case statusRuta
                Case "NOT_FOUND"
                    MessageBox.Show("Una de las ubicaciones especificadas en los orígenes, el destino o los hitos de la solicitud no se pudo codificar de forma geográfica.", "NOT_FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "ZERO_RESULTS"
                    MessageBox.Show("No se pudo encontrar ninguna ruta entre el origen y el destino", "ZERO_RESULTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "MAX_WAYPOINTS_EXCEEDED"
                    MessageBox.Show("Excedido el número de hitos. El máximo permitido son 8.", "MAX_WAYPOINTS_EXCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "INVALID_REQUEST"
                    MessageBox.Show("Solicitud enviada no válida. Contacte con el desarrollador", "INVALID_REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "OVER_QUERY_LIMIT"
                    MessageBox.Show("Revasado número de peticiones", "OVER_QUERY_LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "REQUEST_DENIED"
                    MessageBox.Show("Se ha denegado el uso del servicio de rutas a la aplicación", "REQUEST_DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "UNKNOWN_ERROR"
                    MessageBox.Show("Error del servidor. Inténtelo de nuevo", "UNKNOWN_ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "OK"
                    Try
                        Dim frm As New mostrarRuta(datosruta, coord)
                        frm.Show()
                    Catch
                    End Try
            End Select
        Else
            Button3_Click(sender, e) 'Comprobamos
            If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then 'Si se han creado bien, calculamos ruta
                Button4_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub txtdirhito_GotFocus(sender As Object, e As EventArgs) Handles txtdirhito.GotFocus 'Ponemos foco en añadir hito
        Me.AcceptButton = Button1
    End Sub

    Private Sub txtdirhito_LostFocus(sender As Object, e As EventArgs) Handles txtdirhito.LostFocus 'Ponemos foco en comprobar
        Me.AcceptButton = Button4
    End Sub

 

    Private Sub Rutas_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Gray, 1)
        'Dim formGraphics As System.Drawing.Graphics
        'formGraphics = Me.CreateGraphics()
        ''formGraphics.DrawLine(myPen, 127, Label2.Location.Y + 20, 957, Label2.Location.Y + 20)
        'formGraphics.DrawLine(myPen, 100, Label11.Location.Y - 30, Me.Size.Width - 100, Label11.Location.Y - 30)
        ''formGraphics.DrawLine(myPen, 10, ListBox1.Location.Y + ListBox1.Height + 20, Me.Size.Width - 28, ListBox1.Location.Y + ListBox1.Height + 20)
        'myPen.Dispose()
        'formGraphics.Dispose()
    End Sub

    Private Sub txtdirorigen_GotFocus(sender As Object, e As EventArgs) Handles txtdirorigen.GotFocus
        Me.AcceptButton = Button3 'Foco en botón comprombar
    End Sub

    Private Sub txtdirdestin_GotFocus(sender As Object, e As EventArgs) Handles txtdirdestin.GotFocus
        Me.AcceptButton = Button3 'Foco en botón comprombar
    End Sub

   
    Private Sub txtdirorigen_LostFocus(sender As Object, e As EventArgs) Handles txtdirorigen.LostFocus
        Me.AcceptButton = Button4 'Foco en botón calcular
    End Sub

    Private Sub txtdirdestin_LostFocus(sender As Object, e As EventArgs) Handles txtdirdestin.LostFocus
        Me.AcceptButton = Button4 'Foco en botón calcular
    End Sub


    'PROBLEMA DEL VIAJANTE
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click 'Abrimos wikipedia viajante
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        aspectoFormu.NuevaFicha("Problema del viajante") 'Abrimos una nueva pestaña          
        Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
        Dim direccion As New Uri("http://es.wikipedia.org/wiki/Problema_del_viajante")
        navegador.Url = direccion

    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub


   
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button3_Click(sender, e) 'Comprobamos
        If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then
            Dim maps As New MapsNet

            'Peajes
            Dim peajes = 0
            If ComboBox2.SelectedIndex() = 0 Then
                peajes = 0
            ElseIf ComboBox2.SelectedIndex() = 1 Then
                peajes = 1
            Else
                peajes = 2
            End If
            If ComboBox2.SelectedIndex() = -1 Then peajes = 0

            'Transporte
            Dim transporte = 0
            If ComboBox1.SelectedIndex() = 0 Then
                transporte = 0
            ElseIf ComboBox1.SelectedIndex() = 1 Then
                transporte = 1
            Else
                transporte = 2
            End If
            If ComboBox1.SelectedIndex() = -1 Then transporte = 0

            'Optimizar
            Dim optimizar As Boolean = False
            If CheckBox1.Checked = True Then
                optimizar = True
            Else
                optimizar = False
            End If

            'Guardamos en un arraylist los hitos
            Dim lista = ListBox1.Items
            Dim RegExp As String = "<hito[^>]*>[^<]*</hito>"
            Dim R As New Regex(RegExp)
            hitos.Clear()
            For Each item In lista
                Dim mc As MatchCollection = R.Matches(item)
                If mc.Count > 0 Then
                    For Each m In mc
                        Dim cadena = ((m.Result("$0").ToString))
                        hitos.Add(cadena.ToString.Replace("<hito>", "").Replace("</hito>", ""))
                    Next
                End If
            Next

            'Coordenadas inicio/fin recorrido
            Dim direccionOrDe As New ArrayList
            direccionOrDe.Add(txtdirEncOrig.Text)
            direccionOrDe.Add(txtdirEncDest.Text)


            '---------------------------
            Dim datosruta = maps.Rutas(txtdirorigen.Text, txtdirdestin.Text, transporte, hitos, optimizar, peajes, , )
            Select Case statusRuta
                Case "NOT_FOUND"
                    MessageBox.Show("Una de las ubicaciones especificadas en los orígenes, el destino o los hitos de la solicitud no se pudo codificar de forma geográfica.", "NOT_FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "ZERO_RESULTS"
                    MessageBox.Show("No se pudo encontrar ninguna ruta entre el origen y el destino", "ZERO_RESULTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "MAX_WAYPOINTS_EXCEEDED"
                    MessageBox.Show("Excedido el número de hitos. El máximo permitido son 8.", "MAX_WAYPOINTS_EXCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "INVALID_REQUEST"
                    MessageBox.Show("Solicitud enviada no válida. Contacte con el desarrollador", "INVALID_REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "OVER_QUERY_LIMIT"
                    MessageBox.Show("Revasado número de peticiones", "OVER_QUERY_LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "REQUEST_DENIED"
                    MessageBox.Show("Se ha denegado el uso del servicio de rutas a la aplicación", "REQUEST_DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "UNKNOWN_ERROR"
                    MessageBox.Show("Error del servidor. Inténtelo de nuevo", "UNKNOWN_ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "OK"
                    Try
                        Dim frm As New StreetViewRuta(datosruta, direccionOrDe)
                        frm.Show()
                        frm.TopLevel = True
                    Catch
                    End Try
            End Select
        Else
            Button3_Click(sender, e) 'Comprobamos
            If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then 'Si se han creado bien, calculamos ruta
                Button6_Click(sender, e)
            End If

        End If
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click 'Lanzamos hilo para abrir las imágenes
        Button3_Click(sender, e)
        If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then
            PictureBox6.Visible = True
            Label12.Visible = True
            hiloImagenes = New Threading.Thread(AddressOf mostrarstreet) 'Es variable global
            If hiloImagenes.ThreadState <> Threading.ThreadState.Running Then
                hiloImagenes.Start()
            End If
        End If
    End Sub
    Sub mostrarstreet() 'Gestionamos hilo
        Do
            Try
                'Button3_Click(sender, e) 'Comprobamos

                Dim maps As New MapsNet

                'Peajes
                Dim peajes = 0
                If ComboBox2.SelectedIndex() = 0 Then
                    peajes = 0
                ElseIf ComboBox2.SelectedIndex() = 1 Then
                    peajes = 1
                Else
                    peajes = 2
                End If
                If ComboBox2.SelectedIndex() = -1 Then peajes = 0

                'Transporte
                Dim transporte = 0
                If ComboBox1.SelectedIndex() = 0 Then
                    transporte = 0
                ElseIf ComboBox1.SelectedIndex() = 1 Then
                    transporte = 1
                Else
                    transporte = 2
                End If
                If ComboBox1.SelectedIndex() = -1 Then transporte = 0

                'Optimizar
                Dim optimizar As Boolean = False
                If CheckBox1.Checked = True Then
                    optimizar = True
                Else
                    optimizar = False
                End If

                'Guardamos en un arraylist los hitos
                Dim lista = ListBox1.Items
                Dim RegExp As String = "<hito[^>]*>[^<]*</hito>"
                Dim R As New Regex(RegExp)
                hitos.Clear()
                For Each item In lista
                    Dim mc As MatchCollection = R.Matches(item)
                    If mc.Count > 0 Then
                        For Each m In mc
                            Dim cadena = ((m.Result("$0").ToString))
                            hitos.Add(cadena.ToString.Replace("<hito>", "").Replace("</hito>", ""))
                        Next
                    End If
                Next

                'Coordenadas inicio/fin recorrido
                Dim direccionOrDe As New ArrayList
                direccionOrDe.Add(txtdirEncOrig.Text)
                direccionOrDe.Add(txtdirEncDest.Text)


                '---------------------------
                Dim datosruta = maps.Rutas(txtdirorigen.Text, txtdirdestin.Text, transporte, hitos, optimizar, peajes, , )
                Select Case statusRuta
                    Case "NOT_FOUND"
                        MessageBox.Show("Una de las ubicaciones especificadas en los orígenes, el destino o los hitos de la solicitud no se pudo codificar de forma geográfica.", "NOT_FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "ZERO_RESULTS"
                        MessageBox.Show("No se pudo encontrar ninguna ruta entre el origen y el destino", "ZERO_RESULTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "MAX_WAYPOINTS_EXCEEDED"
                        MessageBox.Show("Excedido el número de hitos. El máximo permitido son 8.", "MAX_WAYPOINTS_EXCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "INVALID_REQUEST"
                        MessageBox.Show("Solicitud enviada no válida. Contacte con el desarrollador", "INVALID_REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "OVER_QUERY_LIMIT"
                        MessageBox.Show("Revasado número de peticiones", "OVER_QUERY_LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "REQUEST_DENIED"
                        MessageBox.Show("Se ha denegado el uso del servicio de rutas a la aplicación", "REQUEST_DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "UNKNOWN_ERROR"
                        MessageBox.Show("Error del servidor. Inténtelo de nuevo", "UNKNOWN_ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "OK"
                        If hiloImagenes.ThreadState = Threading.ThreadState.Aborted Or hiloImagenes.ThreadState = Threading.ThreadState.AbortRequested Then
                            Exit Do
                        End If
                        Dim frm As New MostarTodosStreetViewvb(datosruta, direccionOrDe)
                        frm.ShowDialog()
                End Select
                PictureBox6.Visible = False
                Label12.Visible = False
                hiloImagenes.Abort()
            Catch
            End Try

        Loop
        hiloImagenes = Nothing


    End Sub
    Private Sub Rutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Cargamos lo relacionado con el hilo
        PictureBox6.Visible = False
        Label12.Visible = False
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

   
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button3_Click(sender, e)
        If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then
            PictureBox6.Visible = True
            Label12.Visible = True
            hiloMapas = New Threading.Thread(AddressOf mostrarmapas) 'Es variable global
            If hiloMapas.ThreadState <> Threading.ThreadState.Running Then
                hiloMapas.ApartmentState = Threading.ApartmentState.STA 'Esto hace que no aparezca excepción ya que los componentes ActiveX (webbrowser por ejemlplo) la producen al crear hilos
                hiloMapas.Start()
            End If
        End If
    End Sub





    Sub mostrarmapas() 'Gestionamos hilo
        Do
            Try
                Dim maps As New MapsNet

                'Peajes
                Dim peajes = 0
                If ComboBox2.SelectedIndex() = 0 Then
                    peajes = 0
                ElseIf ComboBox2.SelectedIndex() = 1 Then
                    peajes = 1
                Else
                    peajes = 2
                End If
                If ComboBox2.SelectedIndex() = -1 Then peajes = 0

                'Transporte
                Dim transporte = 0
                If ComboBox1.SelectedIndex() = 0 Then
                    transporte = 0
                ElseIf ComboBox1.SelectedIndex() = 1 Then
                    transporte = 1
                Else
                    transporte = 2
                End If
                If ComboBox1.SelectedIndex() = -1 Then transporte = 0

                'Optimizar
                Dim optimizar As Boolean = False
                If CheckBox1.Checked = True Then
                    optimizar = True
                Else
                    optimizar = False
                End If

                'Guardamos en un arraylist los hitos
                Dim lista = ListBox1.Items
                Dim RegExp As String = "<hito[^>]*>[^<]*</hito>"
                Dim R As New Regex(RegExp)
                hitos.Clear()
                For Each item In lista
                    Dim mc As MatchCollection = R.Matches(item)
                    If mc.Count > 0 Then
                        For Each m In mc
                            Dim cadena = ((m.Result("$0").ToString))
                            hitos.Add(cadena.ToString.Replace("<hito>", "").Replace("</hito>", ""))
                        Next
                    End If
                Next

                'Coordenadas inicio/fin recorrido
                Dim direccionOrDe As New ArrayList
                direccionOrDe.Add(txtdirEncOrig.Text)
                direccionOrDe.Add(txtdirEncDest.Text)


                '---------------------------
                Dim datosruta = maps.Rutas(txtdirorigen.Text, txtdirdestin.Text, transporte, hitos, optimizar, peajes, , )
                Select Case statusRuta
                    Case "NOT_FOUND"
                        MessageBox.Show("Una de las ubicaciones especificadas en los orígenes, el destino o los hitos de la solicitud no se pudo codificar de forma geográfica.", "NOT_FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "ZERO_RESULTS"
                        MessageBox.Show("No se pudo encontrar ninguna ruta entre el origen y el destino", "ZERO_RESULTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "MAX_WAYPOINTS_EXCEEDED"
                        MessageBox.Show("Excedido el número de hitos. El máximo permitido son 8.", "MAX_WAYPOINTS_EXCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "INVALID_REQUEST"
                        MessageBox.Show("Solicitud enviada no válida. Contacte con el desarrollador", "INVALID_REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "OVER_QUERY_LIMIT"
                        MessageBox.Show("Revasado número de peticiones", "OVER_QUERY_LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "REQUEST_DENIED"
                        MessageBox.Show("Se ha denegado el uso del servicio de rutas a la aplicación", "REQUEST_DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "UNKNOWN_ERROR"
                        MessageBox.Show("Error del servidor. Inténtelo de nuevo", "UNKNOWN_ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case "OK"

                        If hiloMapas.ThreadState = Threading.ThreadState.Aborted Or hiloMapas.ThreadState = Threading.ThreadState.AbortRequested Then
                            Exit Do
                        End If
                Dim indicaciones As New ArrayList
                        For i = 4 To UBound(datosruta) Step 5
                            indicaciones.Add(maps.QuitarEtiqueta(datosruta(i)))
                        Next
                Dim frm As New MapasRuta(Polilineas, indicaciones)
                frm.ShowDialog()
                End Select
                PictureBox6.Visible = False
                Label12.Visible = False
                hiloMapas.Abort()
            Catch
            End Try
        Loop
        hiloMapas = Nothing


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button3_Click(sender, e) 'Comprobamos
        If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then
            Dim maps As New MapsNet

            'Peajes
            Dim peajes = 0
            If ComboBox2.SelectedIndex() = 0 Then
                peajes = 0
            ElseIf ComboBox2.SelectedIndex() = 1 Then
                peajes = 1
            Else
                peajes = 2
            End If
            If ComboBox2.SelectedIndex() = -1 Then peajes = 0

            'Transporte
            Dim transporte = 0
            If ComboBox1.SelectedIndex() = 0 Then
                transporte = 0
            ElseIf ComboBox1.SelectedIndex() = 1 Then
                transporte = 1
            Else
                transporte = 2
            End If
            If ComboBox1.SelectedIndex() = -1 Then transporte = 0

            'Optimizar
            Dim optimizar As Boolean = False
            If CheckBox1.Checked = True Then
                optimizar = True
            Else
                optimizar = False
            End If

            'Guardamos en un arraylist los hitos
            Dim lista = ListBox1.Items
            Dim RegExp As String = "<hito[^>]*>[^<]*</hito>"
            Dim R As New Regex(RegExp)
            hitos.Clear()
            For Each item In lista
                Dim mc As MatchCollection = R.Matches(item)
                If mc.Count > 0 Then
                    For Each m In mc
                        Dim cadena = ((m.Result("$0").ToString))
                        hitos.Add(cadena.ToString.Replace("<hito>", "").Replace("</hito>", ""))
                    Next
                End If
            Next

            'Coordenadas inicio/fin recorrido
            Dim direccionOrDe As New ArrayList
            direccionOrDe.Add(txtdirEncOrig.Text)
            direccionOrDe.Add(txtdirEncDest.Text)


            '---------------------------
            Dim datosruta = maps.Rutas(txtdirorigen.Text, txtdirdestin.Text, transporte, hitos, optimizar, peajes, , )
            Select Case statusRuta
                Case "NOT_FOUND"
                    MessageBox.Show("Una de las ubicaciones especificadas en los orígenes, el destino o los hitos de la solicitud no se pudo codificar de forma geográfica.", "NOT_FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "ZERO_RESULTS"
                    MessageBox.Show("No se pudo encontrar ninguna ruta entre el origen y el destino", "ZERO_RESULTS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "MAX_WAYPOINTS_EXCEEDED"
                    MessageBox.Show("Excedido el número de hitos. El máximo permitido son 8.", "MAX_WAYPOINTS_EXCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "INVALID_REQUEST"
                    MessageBox.Show("Solicitud enviada no válida. Contacte con el desarrollador", "INVALID_REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "OVER_QUERY_LIMIT"
                    MessageBox.Show("Revasado número de peticiones", "OVER_QUERY_LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "REQUEST_DENIED"
                    MessageBox.Show("Se ha denegado el uso del servicio de rutas a la aplicación", "REQUEST_DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "UNKNOWN_ERROR"
                    MessageBox.Show("Error del servidor. Inténtelo de nuevo", "UNKNOWN_ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case "OK"
                    Try
                        Dim indicaciones As New ArrayList
                        For i = 4 To UBound(datosruta) Step 5
                            indicaciones.Add(maps.QuitarEtiqueta(datosruta(i)))
                        Next
                        Dim frm As New MapasRutaPasoaPaso(Polilineas, indicaciones)
                        frm.Show()
                        frm.TopMost = True

                    Catch
                    End Try
            End Select
        Else
            Button3_Click(sender, e) 'Comprobamos
            If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then 'Si se han creado bien, calculamos ruta
                Button9_Click(sender, e)
            End If

        End If
    End Sub
End Class