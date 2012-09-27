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
            Dim aspecto As New AspectoFormulario
            If txtdirEncHito.Text <> "" Then
                Dim cadena As String = "Hito - " & "<coordenadas>" & txtlatHito.Text & "," & txtlngHito.Text & "</coordenadas>" & " - " & "<hito>" & txtdirEncHito.Text & "</hito>"
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
        End If



      

    End Sub

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtdirEncDest.Text <> "" And txtdirEncOrig.Text <> "" Then
            Dim maps As New MapsNet
            'Peajes
            Dim peajes = 0
            If RadioButton2.Checked = True Then
                peajes = 0
            ElseIf RadioButton1.Checked = True Then
                peajes = 1
            Else
                peajes = 2
            End If

            'Transporte
            Dim transporte = 0
            If RadioButton4.Checked = True Then
                transporte = 0
            ElseIf RadioButton6.Checked = True Then
                transporte = 2
            Else
                transporte = 1
            End If

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
                        Dim frm As New mostrarRuta(datosruta)
                        frm.Show()
                    Catch
                    End Try
            End Select

        End If
    End Sub

End Class