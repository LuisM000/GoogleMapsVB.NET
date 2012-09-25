Public Class DetallesLugarComida
    Dim datos As New ArrayList
    Dim contador = 0
    Dim contadorUrl = 0
    Dim referenreferenciaM = "CnRqAAAA88J3FlljOZTbaI2hIF1pu8LW5hGJINjW5x8zbCbNA1lW61cxJcdR9u0c_ismLPTVTlYXK7lhANpxrEa_tshoVAdUSJZ_eg9LHzuxjdTOeGtVAktLP5FAxq8OkAFyQisGlK2N0CKDJyYXVGbfVGELlBIQ3Li4vTx8DfNhGpxTPuBQHxoUH-_PEyTMClzgacA666Z4GXFPyTI"
    Private Sub DetallesLugarComida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maps As New MapsNet
        datos = maps.DetallesRestaurante(referenreferenciaM)
        Try
            Me.Text = datos(0)
            lblNombre.Text = datos(0)
            Label1.Text = maps.UnixToTime(time(contador))
            Label2.Text = autor(contador)
            If autor(contador) = "Un usuario de Google" Then
                Label3.Text = "Sin página Google"
            Else
                Label3.Text = URLautor(contadorUrl)
            End If
            Label4.Text = textoReview(contador)
        Catch
            contador = 0
            contadorUrl = 0
        End Try

        Dim puntuacion = datos(5)
        Dim puntuacionTip = "Sin puntuaciones"
        Try
            If puntuacion >= 0 And puntuacion <= 2 Then
                PictureBox1.Image = My.Resources.medalla_de_bronce_blue
                puntuacionTip = "Puntuación: " & puntuacion & ". Mal valorado"

            ElseIf puntuacion > 2 And puntuacion <= 4 Then
                PictureBox1.Image = My.Resources.medalla_de_plata
                puntuacionTip = "Puntuación: " & puntuacion & ". Bien valorado"
            Else
                PictureBox1.Image = My.Resources.medalla_de_oro_blue
                puntuacionTip = "Puntuación: " & puntuacion & ". Excelente"
            End If
            ToolTip1.SetToolTip(PictureBox1, puntuacionTip)
        Catch
            PictureBox1.Image = My.Resources.cancel
            ToolTip1.SetToolTip(PictureBox1, puntuacionTip)
        End Try

    End Sub
   
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Activamos timer para realizar los desplazamientos
        Timer1.Enabled = True
    End Sub
    Sub actualizar()
        'Si eliminamos los timer, con poner esto en el button 1 es suficiente
        contador += 1
        contadorUrl += 1
        Try
            Label1.Text = time(contador)
            Label2.Text = autor(contador)
            If autor(contador) = "Un usuario de Google" Then
                Label3.Text = "Sin página Google"
                contadorUrl -= 1
            Else
                Label3.Text = URLautor(contador)
            End If

            Label4.Text = textoReview(contador)

        Catch
            contador = -1 'Bajamos contador para que al entrar de nuevo sea 0 (se le suma 1 al inicio)
            contadorUrl = -1
            'Button1_Click(sender, e) 'Ejecutamos de nuevo
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label4.Location.X > -500 Then
            Label1.Location = New Size(Label1.Location.X - 15, Label1.Location.Y)
            Label2.Location = New Size(Label2.Location.X - 15, Label2.Location.Y)
            Label3.Location = New Size(Label3.Location.X - 15, Label3.Location.Y)
            Label4.Location = New Size(Label4.Location.X - 15, Label4.Location.Y)
            Label13.Location = New Size(Label13.Location.X - 15, Label13.Location.Y)
            Label14.Location = New Size(Label14.Location.X - 15, Label14.Location.Y)
            Label15.Location = New Size(Label15.Location.X - 15, Label15.Location.Y)
            Label16.Location = New Size(Label16.Location.X - 15, Label16.Location.Y)
        Else
            Label1.Location = New Size(1000, Label1.Location.Y)
            Label2.Location = New Size(1000, Label2.Location.Y)
            Label3.Location = New Size(1000, Label3.Location.Y)
            Label4.Location = New Size(1000, Label4.Location.Y)
            Label13.Location = New Size(1000, Label13.Location.Y)
            Label14.Location = New Size(1000, Label14.Location.Y)
            Label15.Location = New Size(1000, Label15.Location.Y)
            Label16.Location = New Size(1000, Label16.Location.Y)
            Timer1.Enabled = False
            Timer2.Enabled = True
            actualizar()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label13.Location.X > 20 Then
            If Label1.Location.X > 113 Then
                Label1.Location = New Size(Label1.Location.X - 15, Label1.Location.Y)
                Label2.Location = New Size(Label2.Location.X - 15, Label2.Location.Y)
                Label3.Location = New Size(Label3.Location.X - 15, Label3.Location.Y)
                Label4.Location = New Size(Label4.Location.X - 15, Label4.Location.Y)
            End If
            Label13.Location = New Size(Label13.Location.X - 15, Label13.Location.Y)
            Label14.Location = New Size(Label14.Location.X - 15, Label14.Location.Y)
            Label15.Location = New Size(Label15.Location.X - 15, Label15.Location.Y)
            Label16.Location = New Size(Label16.Location.X - 15, Label16.Location.Y)
        Else

            Timer2.Enabled = False

        End If
    End Sub


    Private Sub DetallesLugarComida_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint 'Dibujamos línea
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Black, 2)
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = Me.CreateGraphics()
        formGraphics.DrawLine(myPen, 10, 60, Me.Size.Width - 28, 60)
        formGraphics.DrawLine(myPen, 10, 400, Me.Size.Width - 28, 400)
        myPen.Dispose()
        formGraphics.Dispose()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Label5.Text = "Más info [+]" Then
            Label5.Text = "Menos info [+]"
            txtnombre.Text = datos(0)
            txtdir1.Text = datos(1)
            txtphone.Text = datos(2)
            txtdir2.Text = datos(3)
            txtgoogle.Text = datos(4)
            txtrating.Text = datos(5)
            txtweb.Text = datos(7)
            mostrarDetalles()
            Timer3.Enabled = True
        Else
            Timer4.Enabled = True
        End If
    End Sub
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub


    Sub mostrarDetalles()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Button1.Visible = False
        txtnombre.Visible = True
        txtdir1.Visible = True
        txtphone.Visible = True
        txtdir2.Visible = True
        txtgoogle.Visible = True
        txtrating.Visible = True
        txtweb.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Button2.Visible = True
        Button4.Visible = True

    End Sub

    Sub menosDetalles()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Button1.Visible = True
        txtnombre.Visible = False
        txtdir1.Visible = False
        txtphone.Visible = False
        txtdir2.Visible = False
        txtgoogle.Visible = False
        txtrating.Visible = False
        txtweb.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Button2.Visible = False
        Button4.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim aspectoFormu As New AspectoFormulario
            Dim nombreFicha As String
            nombreFicha = "Página google " & Me.Text
            aspectoFormu.NuevaFicha(nombreFicha) 'Abrimos una nueva pestaña
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = New Uri(txtgoogle.Text)
        Catch
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtweb.Text <> "Sin página web" Then
            Try
                Dim aspectoFormu As New AspectoFormulario
                Dim nombreFicha As String
                nombreFicha = "Website " & Me.Text
                aspectoFormu.NuevaFicha(nombreFicha) 'Abrimos una nueva pestaña
                'Este código sirve para seleccionar el navegador de la pestaña activa
                Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
                navegador.Url = New Uri(txtweb.Text)
            Catch
            End Try
        End If
    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick 'Movemos las info del local
        If Label6.Location.X > 170 Then
            Label6.Location = New Size(Label6.Location.X - 10, Label6.Location.Y)
            Label7.Location = New Size(Label7.Location.X - 10, Label7.Location.Y)
            Label8.Location = New Size(Label8.Location.X - 10, Label8.Location.Y)
            Label9.Location = New Size(Label9.Location.X - 10, Label9.Location.Y)
            Label10.Location = New Size(Label10.Location.X - 10, Label10.Location.Y)
            Label11.Location = New Size(Label11.Location.X - 10, Label11.Location.Y)
            Label12.Location = New Size(Label12.Location.X - 10, Label12.Location.Y)
            txtnombre.Location = New Size(txtnombre.Location.X - 10, txtnombre.Location.Y)
            txtdir1.Location = New Size(txtdir1.Location.X - 10, txtdir1.Location.Y)
            txtphone.Location = New Size(txtphone.Location.X - 10, txtphone.Location.Y)
            txtdir2.Location = New Size(txtdir2.Location.X - 10, txtdir2.Location.Y)
            txtgoogle.Location = New Size(txtgoogle.Location.X - 10, txtgoogle.Location.Y)
            txtrating.Location = New Size(txtrating.Location.X - 10, txtrating.Location.Y)
            txtweb.Location = New Size(txtweb.Location.X - 10, txtweb.Location.Y)
            Button2.Location = New Size(Button2.Location.X - 10, Button2.Location.Y)
            Button4.Location = New Size(Button4.Location.X - 10, Button4.Location.Y)
        Else
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick 'Sacamos la info del local
        If Label6.Location.X < 745 Then
            Label6.Location = New Size(Label6.Location.X + 10, Label6.Location.Y)
            Label7.Location = New Size(Label7.Location.X + 10, Label7.Location.Y)
            Label8.Location = New Size(Label8.Location.X + 10, Label8.Location.Y)
            Label9.Location = New Size(Label9.Location.X + 10, Label9.Location.Y)
            Label10.Location = New Size(Label10.Location.X + 10, Label10.Location.Y)
            Label11.Location = New Size(Label11.Location.X + 10, Label11.Location.Y)
            Label12.Location = New Size(Label12.Location.X + 10, Label12.Location.Y)
            txtnombre.Location = New Size(txtnombre.Location.X + 10, txtnombre.Location.Y)
            txtdir1.Location = New Size(txtdir1.Location.X + 10, txtdir1.Location.Y)
            txtphone.Location = New Size(txtphone.Location.X + 10, txtphone.Location.Y)
            txtdir2.Location = New Size(txtdir2.Location.X + 10, txtdir2.Location.Y)
            txtgoogle.Location = New Size(txtgoogle.Location.X + 10, txtgoogle.Location.Y)
            txtrating.Location = New Size(txtrating.Location.X + 10, txtrating.Location.Y)
            txtweb.Location = New Size(txtweb.Location.X + 10, txtweb.Location.Y)
            Button2.Location = New Size(Button2.Location.X + 10, Button2.Location.Y)
            Button4.Location = New Size(Button4.Location.X + 10, Button4.Location.Y)
      
        Else
            menosDetalles()
            Label5.Text = "Más info [+]"
            Timer4.Enabled = False
        End If
    End Sub


End Class