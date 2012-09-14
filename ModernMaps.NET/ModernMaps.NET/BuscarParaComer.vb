Public Class BuscarParaComer

    Private Sub BuscarParaComer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Me.Opacity = 0
        Me.Size = New Point(0, 257)
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).KeyDown, AddressOf Buscar
            End If
        Next
        Timer1.Enabled = True

    End Sub
    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.LightCyan
    End Sub

    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub
    Private Sub Buscar(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtcalle.Text <> "" And txtpoblacion.Text <> "" And txtprovincia.Text <> "" Then
            Timer4.Enabled = True
        End If
    End Sub

   
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer3.Enabled = True
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.ImageLocation = "imagenes/white/back.png"
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = "imagenes/black/back.png"
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Width < 588 Then
            Me.Width = Me.Width + 10
            Me.Opacity = Me.Opacity + 0.023
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Width > 2 Then
            Me.Width = Me.Width - 10
            If Me.Width > 588 Then
                Me.Location = New Point(Me.Location.X + 5, Me.Location.Y)
            Else
                Me.Opacity = Me.Opacity - 0.023
            End If
        Else
            Timer2.Enabled = False
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Height > 257 Then
            Me.Height = Me.Height - 10
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)
        Else
            Timer2.Enabled = True
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Me.Height < 462 Then
            Me.Height = Me.Height + 10
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 5)
        Else
            Timer5.Enabled = True
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim onobjetoMaps As New GoogleMaps
        Dim objetoMpas As New GoogleMaps
        Dim datos(1000) As String
        datos(0) = ""
        Dim latlong(1) As Double
        Dim calle As String
        calle = txtcalle.Text
        If txtcalle.Text <> "" Then
            calle = calle.ToLower()
            Dim posicion = calle.Contains("calle")
            If posicion = False Then
                calle = "calle " + txtcalle.Text
            End If
        Else
            calle = ""
        End If
        latlong = onobjetoMaps.CodificacionGeo(calle, txtpoblacion.Text, txtprovincia.Text)
        If txtradio.Text <> "" And txtestabl.Text <> "" Then
            datos = objetoMpas.GooglePlaces(latlong(0), latlong(1), txtradio.Text, "food", txtestabl.Text)
        End If

        If txtradio.Text = "" And txtestabl.Text = "" Then
            datos = objetoMpas.GooglePlaces(latlong(0), latlong(1), 5000, "food")
        End If

        If txtradio.Text <> "" And txtestabl.Text = "" Then
            datos = objetoMpas.GooglePlaces(latlong(0), latlong(1), txtradio.Text, "food", )
        End If
        If txtradio.Text = "" And txtestabl.Text <> "" Then
            datos = objetoMpas.GooglePlaces(latlong(0), latlong(1), 5000, "food", txtestabl.Text)
        End If
        Dim datos2(contadorPlaces - 1) As String
        For i = 0 To contadorPlaces - 1
            datos2(i) = datos(i)
        Next
        Label5.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False

        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

        Label5.Text = "Establecimiento: "
        Label8.Text = "Establecimiento: "
        Label9.Text = "Establecimiento: "
        Label10.Text = "Establecimiento: "
        Label11.Text = "Establecimiento: "
        Dim auxiliar(100, 4) As String
        Dim contador As Integer = 0
        Dim URLimagenes(4) As String
        If datos2.Length >= 7 Then
            For i = 0 To UBound(datos2) - 1
                Select Case datos2(i)
                    Case "name"
                        auxiliar(contador, 0) = datos2(i + 1)

                    Case "lat"
                        auxiliar(contador, 1) = " (" & datos2(i + 1) & ","

                    Case "lng"
                        auxiliar(contador, 2) = datos2(i + 1) & ")."

                    Case "rating"
                        If datos2(i + 1) = Nothing Then
                            auxiliar(contador, 3) = "Restaurante no valorado. " & datos2(i + 1)
                        Else
                            auxiliar(contador, 3) = "Valoración: " & datos2(i + 1)
                        End If

                    Case "icon"
                        auxiliar(contador, 4) = datos2(i + 1)
                        If contador <= 4 Then
                            URLimagenes(contador) = datos2(i + 1)
                        End If
                        contador += 1
                End Select
            Next

        End If
       
        For i = 0 To 3
            Label5.Text = Label5.Text + auxiliar(0, i)
        Next
        For i = 0 To 3
            Label8.Text = Label8.Text + auxiliar(1, i)
        Next
        For i = 0 To 3
            Label9.Text = Label9.Text + auxiliar(2, i)
        Next
        For i = 0 To 3
            Label10.Text = Label10.Text + auxiliar(3, i)
        Next
        For i = 0 To 3
            Label11.Text = Label11.Text + auxiliar(4, i)
        Next
       
        PictureBox2.Image = objetoMpas.cargarrecursoweb(URLimagenes(0))
        PictureBox3.Image = objetoMpas.cargarrecursoweb(URLimagenes(1))
        PictureBox4.Image = objetoMpas.cargarrecursoweb(URLimagenes(2))
        PictureBox5.Image = objetoMpas.cargarrecursoweb(URLimagenes(3))
        PictureBox6.Image = objetoMpas.cargarrecursoweb(URLimagenes(4))

       
        If Label5.Text <> "Establecimiento: " Then Label5.Visible = True : PictureBox2.Visible = True
        If Label8.Text <> "Establecimiento: " Then Label8.Visible = True : PictureBox3.Visible = True
        If Label9.Text <> "Establecimiento: " Then Label9.Visible = True : PictureBox4.Visible = True
        If Label10.Text <> "Establecimiento: " Then Label10.Visible = True : PictureBox5.Visible = True
        If Label11.Text <> "Establecimiento: " Then Label11.Visible = True : PictureBox6.Visible = True

        Timer5.Enabled = False
    End Sub
End Class