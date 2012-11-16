Public Class CodifInversa
    Dim direccionString As New ArrayList()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            txtlongitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            txtlatitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            direccionString = objetoMaps.CodificacionGeograficaInversa(txtlatitud.Text, txtlongitud.Text) 'String con la direccion
            'Controlamos excepciones e introducimos los datos en los textBox
            Try
                txtdireccion.Text = direccionString(0)
            Catch
                txtdireccion.Text = "No se han encontrado resultados"
            End Try
            Try
                txtdireccion1.Text = direccionString(1)
            Catch
                txtdireccion1.Text = "No se han encontrado resultados"
            End Try
            Try
                txtdireccion2.Text = direccionString(2)
            Catch
                txtdireccion2.Text = "No se han encontrado resultados"
            End Try
            Try
                txtdireccion3.Text = direccionString(3)
            Catch
                txtdireccion3.Text = "No se han encontrado resultados"
            End Try

            'Añadir al autocompletado
            aspectoFormu.autocompletar(txtlatitud.Text)
            aspectoFormu.autocompletar(txtlongitud.Text)
        Else
            If aspectoFormu.verificarnumeros(txtlatitud.Text) = False Then txtlatitud.ForeColor = Color.Red
            If aspectoFormu.verificarnumeros(txtlongitud.Text) = False Then txtlongitud.ForeColor = Color.Red
        End If

    End Sub


    Private Sub txtlatitud_GotFocus(sender As Object, e As EventArgs) Handles txtlatitud.GotFocus
        txtlatitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlongitud_GotFocus(sender As Object, e As EventArgs) Handles txtlongitud.GotFocus
        txtlongitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlatitud_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlatitud.KeyDown
        txtlatitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlongitud_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlongitud.KeyDown
        txtlongitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtdireccion.Text <> "" Then
            Dim objetoMaps As New MapsNet
            Dim aspectoFormu As New AspectoFormulario

            Dim direccionString = objetoMaps.ObtenerURLdesdeDireccion(txtdireccion.Text) 'String con la direccion
            Dim direccion As New Uri(direccionString) 'Pasamos el string a URI
            If CheckBox1.Checked = True Then 'Decidimos si lo abrimos en pestaña activa o nueva pestaña
                aspectoFormu.NuevaFicha("Codificación inversa") 'Abrimos una nueva pestaña
            End If
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = direccion
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Moastra en el mapa el resto de resultados
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        Dim direccion As String = "España"

        'Buscarmos el radioButton seleccionado
        If RadioButton1.Checked = True Then direccion = txtdireccion1.Text
        If RadioButton2.Checked = True Then direccion = txtdireccion2.Text
        If RadioButton3.Checked = True Then direccion = txtdireccion3.Text

        Dim direccionString = objetoMaps.ObtenerURLdesdeDireccion(direccion) 'String con la direccion
        Dim direccionM As New Uri(direccionString) 'Pasamos el string a URI
        If CheckBox1.Checked = True Then 'Decidimos si lo abrimos en pestaña activa o nueva pestaña
            aspectoFormu.NuevaFicha("Codificación inversa") 'Abrimos una nueva pestaña
        End If
        'Este código sirve para seleccionar el navegador de la pestaña activa
        Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
        navegador.Url = direccionM

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click 'Mostrar más resultados
        If txtdireccion.Text <> "" And Label4.Text = "Mostrar más resultados" Then 'Si ya ha buscado resultados y se muestran
            Timer1.Enabled = True
            
        End If
        If Label4.Text = "Mostrar menos resultados" Then 'Para plegar el formulario
            Timer2.Enabled = True
        End If
    End Sub


    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter 'Pintamos y cambiamos puntero
        Label4.ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave 'Pintamos y cambiamos puntero
        Label4.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'Desplegamos los resultados
        If Me.Height < 380 Then
            Me.Height += 10
        Else
            Label4.Text = "Mostrar menos resultados"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'Para plegar el formulario

        If Me.Height > 249 Then
            Me.Height -= 10
        Else
            Label4.Text = "Mostrar más resultados"
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub CodifInversa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Indicamos que el txt admite autocompletado
        With txtlatitud
            .AutoCompleteCustomSource = MySource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        With txtlongitud
            .AutoCompleteCustomSource = MySource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
    End Sub
End Class