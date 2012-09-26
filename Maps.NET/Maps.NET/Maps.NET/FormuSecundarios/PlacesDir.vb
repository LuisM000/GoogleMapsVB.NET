Public Class PlacesDir

    Dim datosPlaces() As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  'Buscar
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        Dim latLong = objetoMaps.CodificacionGeografica(txtdireccion.Text) 'Buscamos por codificacion geografica la lati/long
        Try
            txtlatitud.Text = latLong(0)
            txtlongitud.Text = latLong(1)
            txtdir2.Text = latLong(2)
        Catch
        End Try
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            Dim TiposSeleccionados = recuperarTypes() 'Conseguimos arraylist con los tipos de establecimientos
            TiposSeleccionados = aspectoFormu.DevuelveEstablecimientosIngles(TiposSeleccionados)
            contadorNext = 0 'Para el contador al ver más resultados
            Button6.Enabled = True : Button7.Enabled = True 'Habilitamos los botones siguiente y todos resultados
            datosPlaces = objetoMaps.PlacesLatLong(txtlatitud.Text, txtlongitud.Text, NumericUpDown1.Value, TiposSeleccionados, txtestablecimiento.Text, ) 'String con la direccion
            rellenarTXT(datosPlaces)
        Else
            If aspectoFormu.verificarnumeros(txtlatitud.Text) = False Then txtlatitud.ForeColor = Color.Red
            If aspectoFormu.verificarnumeros(txtlongitud.Text) = False Then txtlongitud.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 'Todos los resultados
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            Try
                Dim frm As New TodosResultados(datosPlaces)
                frm.Show()
            Catch
            End Try
        Else
            If aspectoFormu.verificarnumeros(txtlatitud.Text) = False Then txtlatitud.ForeColor = Color.Red
            If aspectoFormu.verificarnumeros(txtlongitud.Text) = False Then txtlongitud.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Try
            Dim frm As New DetallesLugarComida(datosPlaces(5 + contadorNext))
            frm.Show()
        Catch
        End Try
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Try
            Dim frm As New DetallesLugarComida(datosPlaces(11 + contadorNext))
            frm.Show()
        Catch
        End Try
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Try
            Dim frm As New DetallesLugarComida(datosPlaces(23 + contadorNext))
            frm.Show()
        Catch
        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Try
            Dim frm As New DetallesLugarComida(datosPlaces(17 + contadorNext))
            frm.Show()
        Catch
        End Try
    End Sub



    Function recuperarTypes()
        Dim datos As New ArrayList()
        For Each item As Object In ListBox2.Items
            datos.Add(item.ToString())
        Next
        Return datos

    End Function


    Sub rellenarTXT(datos() As String)
        Dim aspectoFor As New AspectoFormulario
        txtplace1.Text = "Sin datos"
        txtplace2.Text = "Sin datos"
        txtplace4.Text = "Sin datos"
        pc1.Image = Nothing
        pc2.Image = Nothing
        pc3.Image = Nothing
        pc4.Image = Nothing
        Try
            txtplace1.Text = datos(0) & ". " & datos(1) & " (" & datos(2) & "," & datos(3) & ")"
            pc1.Image = aspectoFor.CargarImagenURL(datos(4))
        Catch
            txtplace1.Text = "Sin datos"
        End Try
        Try
            txtplace2.Text = datos(6) & ". " & datos(7) & " (" & datos(8) & "," & datos(9) & ")"
            pc2.Image = aspectoFor.CargarImagenURL(datos(10))
        Catch
            txtplace2.Text = "Sin datos"
            pc2.Image = aspectoFor.CargarImagenURL("error")
        End Try
        Try
            txtplace3.Text = datos(12) & ". " & datos(13) & " (" & datos(14) & "," & datos(15) & ")"
            pc3.Image = aspectoFor.CargarImagenURL(datos(16))
        Catch
            txtplace3.Text = "Sin datos"
            pc3.Image = aspectoFor.CargarImagenURL("error")
        End Try
        Try
            txtplace4.Text = datos(18) & ". " & datos(19) & " (" & datos(20) & "," & datos(21) & ")"
            pc4.Image = aspectoFor.CargarImagenURL(datos(22))
        Catch
            txtplace4.Text = "Sin datos"
            pc4.Image = aspectoFor.CargarImagenURL("error")
        End Try
    End Sub











    Private Sub txtlatitud_GotFocus(sender As Object, e As EventArgs) Handles txtdireccion.GotFocus
        txtdireccion.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlongitud_GotFocus(sender As Object, e As EventArgs) Handles txtlatitud.GotFocus
        txtlatitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlatitud_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdireccion.KeyDown
        txtdireccion.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlongitud_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlatitud.KeyDown
        txtlatitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Añadimos los elemntos
        For Each elemento In ListBox1.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox3.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox4.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox5.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox6.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox7.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox8.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox9.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox10.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox11.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox12.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox13.SelectedItems
            ListBox2.Items.Add(elemento)
        Next


        ListBox1.ClearSelected()
        ListBox3.ClearSelected()
        ListBox4.ClearSelected()
        ListBox5.ClearSelected()
        ListBox6.ClearSelected()
        ListBox7.ClearSelected()
        ListBox8.ClearSelected()
        ListBox9.ClearSelected()
        ListBox10.ClearSelected()
        ListBox11.ClearSelected()
        ListBox12.ClearSelected()
        ListBox13.ClearSelected()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Quitamos elementos
        While ListBox2.SelectedIndex <> -1
            For Each elemento In ListBox2.SelectedIndices
                ListBox2.Items.RemoveAt(elemento)
            Next
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Borramos toda la selección
        ListBox2.Items.Clear()
        ListBox1.ClearSelected()
        ListBox3.ClearSelected()
        ListBox4.ClearSelected()
        ListBox5.ClearSelected()
        ListBox6.ClearSelected()
        ListBox7.ClearSelected()
        ListBox8.ClearSelected()
        ListBox9.ClearSelected()
        ListBox10.ClearSelected()
        ListBox11.ClearSelected()
        ListBox12.ClearSelected()
        ListBox13.ClearSelected()
    End Sub



    'PINTAMOS LOS LABEL DE MÁS DETALLES
    Private Sub Places_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.TabStop = False 'Desde el diseñador no lo reconocía bien..
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(Label) Then
                If c.ToString.Contains("Más detalles") Then
                    AddHandler DirectCast(c, Label).MouseEnter, AddressOf conFoco
                    AddHandler DirectCast(c, Label).MouseLeave, AddressOf sinFoco
                End If
            End If
        Next
    End Sub

    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, Label).ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub


    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, Label).ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Seleccionamos el que mostrar
            Dim direccion = "España"
            Dim encabezado = "Place - "
            If RadioButton1.Checked = True Then
                direccion = datosPlaces(0) & "." & datosPlaces(1)
                encabezado += datosPlaces(0)
            End If
            If RadioButton2.Checked = True Then
                direccion = datosPlaces(6) & "." & datosPlaces(7)
                encabezado += datosPlaces(6)
            End If
            If RadioButton3.Checked = True Then
                direccion = datosPlaces(12) & "." & datosPlaces(13)
                encabezado += datosPlaces(12)
            End If
            If RadioButton4.Checked = True Then
                direccion = datosPlaces(18) & "." & datosPlaces(19)
                encabezado += datosPlaces(18)
            End If
            Dim objetoMaps As New MapsNet
            Dim aspectoFormu As New AspectoFormulario

            Dim direccionString = objetoMaps.ObtenerURLdesdeDireccion(direccion) 'String con la direccion
            Dim direccionWeb As New Uri(direccionString) 'Pasamos el string a URI
            If CheckBox1.Checked = True Then 'Decidimos si lo abrimos en pestaña activa o nueva pestaña
                aspectoFormu.NuevaFicha(encabezado) 'Abrimos una nueva pestaña
            End If
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = direccionWeb
        Catch
        End Try
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click 'Siguientes resultados
        rellenarTXTNext(datosPlaces)
    End Sub
    Dim contadorNext As Integer = 0 'Variable para saber qué resultado mostrar
    Sub rellenarTXTNext(datos() As String) 'Siguientes resultados
        contadorNext += 24
        If txtplace2.Text = "Sin datos" Then contadorNext = 0 'Si ya no hay más datos volvemos al principio
        Dim aspectoFor As New AspectoFormulario
        txtplace1.Text = "Sin datos"
        txtplace2.Text = "Sin datos"
        txtplace4.Text = "Sin datos"
        pc1.Image = Nothing
        pc2.Image = Nothing
        pc3.Image = Nothing
        pc4.Image = Nothing

        Try
            txtplace1.Text = datos(0 + contadorNext) & ". " & datos(1 + contadorNext) & " (" & datos(2 + contadorNext) & "," & datos(3 + contadorNext) & ")"
            pc1.Image = aspectoFor.CargarImagenURL(datos(4 + contadorNext))
        Catch
            txtplace1.Text = "Sin datos"
        End Try
        Try
            txtplace2.Text = datos(6 + contadorNext) & ". " & datos(7 + contadorNext) & " (" & datos(8 + contadorNext) & "," & datos(9 + contadorNext) & ")"
            pc2.Image = aspectoFor.CargarImagenURL(datos(10 + contadorNext))
        Catch
            txtplace2.Text = "Sin datos"
            pc2.Image = aspectoFor.CargarImagenURL("error")
        End Try
        Try
            txtplace3.Text = datos(12 + contadorNext) & ". " & datos(13 + contadorNext) & " (" & datos(14 + contadorNext) & "," & datos(15 + contadorNext) & ")"
            pc3.Image = aspectoFor.CargarImagenURL(datos(16 + contadorNext))
        Catch
            txtplace3.Text = "Sin datos"
            pc3.Image = aspectoFor.CargarImagenURL("error")
        End Try
        Try
            txtplace4.Text = datos(18 + contadorNext) & ". " & datos(19 + contadorNext) & " (" & datos(20 + contadorNext) & "," & datos(21 + contadorNext) & ")"
            pc4.Image = aspectoFor.CargarImagenURL(datos(22 + contadorNext))
        Catch
            txtplace4.Text = "Sin datos"
            pc4.Image = aspectoFor.CargarImagenURL("error")
        End Try
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus 'Borramos contenido al poner el foco
        If TextBox1.Text = "Buscador" Then
            TextBox1.Text = "" 'Borramos contenido
        End If
        ListBox13.ClearSelected() 'Realizamos esto porque si no se activa el primero resultado del listbox
        Me.AcceptButton = Button5 'el botón asociado a intro es el de pasar al listbox 2
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Me.AcceptButton = Button2 'el botón asociado a intro es el de buscar
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged 'Buscamos en el listoBox de todos
        Dim returnValue As Boolean
        Dim comparisonType As StringComparison
        For i = ListBox13.Items.Count - 1 To 0 Step -1
            returnValue = LCase(ListBox13.Items(i)).StartsWith(LCase(TextBox1.Text), comparisonType)
            If returnValue = True Then
                eliminarElementos() 'Borramos las selecciones anteriores
                TabControl1.SelectedTab = TabControl1.TabPages(11) 'Cambiamos a la pestaña de todos
                TextBox1.Focus() 'Establecemos el foco en el texbox
                ListBox13.SetSelected(i, True)
            End If
        Next
    End Sub
    Sub eliminarElementos()
        ListBox1.ClearSelected()
        ListBox3.ClearSelected()
        ListBox4.ClearSelected()
        ListBox5.ClearSelected()
        ListBox6.ClearSelected()
        ListBox7.ClearSelected()
        ListBox8.ClearSelected()
        ListBox9.ClearSelected()
        ListBox10.ClearSelected()
        ListBox11.ClearSelected()
        ListBox12.ClearSelected()
        ListBox13.ClearSelected()
    End Sub

End Class