Public Class BuscarParaComer

    Private Sub BuscarParaComer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.ImageLocation = "imagenes/white/check.png"
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.ImageLocation = "imagenes/black/check.png"
        Me.Cursor = Cursors.Default
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
        If Me.Height < 430 Then
            Me.Height = Me.Height + 10
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 5)
        Else

            Dim onobjetoMaps As New GoogleMaps
            Dim objetoMpas As New GoogleMaps
            Dim datos() As String
            datos = objetoMpas.GooglePlaces(42.5483753, -6.5833189, 5000)
            If txtradio.Text <> "" And txtestabl.Text <> "" Then
                datos = objetoMpas.GooglePlaces(42.5483753, -6.5833189, txtradio.Text, , txtestabl.Text)
            End If

            If txtradio.Text = "" And txtestabl.Text = "" Then
                datos = objetoMpas.GooglePlaces(42.5483753, -6.5833189, 5000)
            End If

            If txtradio.Text <> "" And txtestabl.Text = "" Then
                datos = objetoMpas.GooglePlaces(42.5483753, -6.5833189, txtradio.Text, , )
            End If
            If txtradio.Text = "" And txtestabl.Text <> "" Then
                datos = objetoMpas.GooglePlaces(42.5483753, -6.5833189, 5000, , txtestabl.Text)
            End If
            Dim datos2(contadorPlaces - 1) As String
            For i = 0 To contadorPlaces - 1
                datos2(i) = datos(i)
            Next

            Label5.Text = "Establecimiento: "
            Label8.Text = "Latitud: "
            Label9.Text = "Longitud: "
            Label10.Text = "Rating: "
            Label11.Text = "Icono: "

            If datos2.Length > 8 Then
                If datos2(0) = "name" Then
                    Label5.Text = Label5.Text & datos2(1)
                End If
                If datos2(2) = "lat" Then
                    Label8.Text = Label8.Text & datos2(3)
                End If
                If datos2(4) = "lng" Then
                    Label9.Text = Label9.Text + datos2(5)
                End If
                If datos2(6) = "rating" Then
                    Label10.Text = Label10.Text + datos2(7)
                End If
                If datos2(8) = "icon" Then
                    Label11.Text = Label11.Text + datos2(9)
                End If
            ElseIf datos2.Length = 8 Then
                If datos2(0) = "name" Then
                    Label5.Text = Label5.Text + datos2(1)
                End If
                If datos2(2) = "lat" Then
                    Label8.Text = Label8.Text + datos2(3)
                End If
                If datos2(4) = "lng" Then
                    Label9.Text = Label9.Text + datos2(5)
                End If
                If datos2(6) = "icon" Then
                    Label11.Text = Label11.Text + datos2(7)
                End If
            End If
            Timer4.Enabled = False
        End If
    End Sub
End Class