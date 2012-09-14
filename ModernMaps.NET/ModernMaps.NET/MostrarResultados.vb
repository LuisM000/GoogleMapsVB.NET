Public Class MostrarResultados
    Dim pulsado As Integer

    Private Sub MostrarResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = 10
        Me.Location = New Point(Me.Location.X + 1, Me.Location.Y)
        Label7.Text = localizacion
        Me.Opacity = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLlatlongMaps(latitudLongitud(0), latitudLongitud(1))
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion
        Dim direccion2 = objetoMaps.ImagenStreetViewLatiLong(latitudLongitud(0), latitudLongitud(1), 551, 412, Label2.Text)
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion2)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox2.Image = bmp
        Timer1.Enabled = True
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer5.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.03
        Else
            Timer4.Enabled = False
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Me.Width > 594 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X - 10, PictureBox1.Location.Y)
            Me.Width -= 10
            Me.Location = New Point(Me.Location.X + 5, Me.Location.Y)

        Else
            Timer2.Enabled = True
            Timer5.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.ImageLocation = "imagenes/white/cancel.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = "imagenes/black/cancel.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer4.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.03
        Else
            Me.Close()
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Timer3.Enabled = True
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.White
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Width < 1150 Then
            Me.Width += 10
            Me.Location = New Point(Me.Location.X - 5, Me.Location.Y)
            PictureBox1.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y)
        Else
            Timer3.Enabled = False

        End If
    End Sub








    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.ImageLocation = "imagenes/white/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.ImageLocation = "imagenes/black/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.ImageLocation = "imagenes/white/add.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.ImageLocation = "imagenes/black/add.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    Private Sub PictureBox6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseUp
        Timer7.Enabled = False
        Dim ancho As Integer
        ancho = Label2.Text
        ancho += 1
        If ancho <> 360 Then Label2.Text = ancho
        pulsado = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccion2 = objetoMaps.ImagenStreetViewLatiLong(latitudLongitud(0), latitudLongitud(1), 551, 412, Label2.Text)
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion2)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox2.Image = bmp
    End Sub
    Private Sub PictureBox6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseDown
        If CInt(Label2.Text) <= 359 Then
            Timer7.Interval = 100
            Timer7.Enabled = True
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If pulsado = 0 Then
            pulsado += 1
        Else
            Dim ancho As Integer
            ancho = Label2.Text
            If ancho < 359 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer7.Interval = 10
                End If
                ancho += 1
                Label2.Text = ancho
            End If
        End If
    End Sub

    Private Sub PictureBox5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseUp
        Timer6.Enabled = False
        Dim ancho As Integer
        ancho = Label2.Text
        If ancho <> 0 Then Label2.Text = ancho - 1
        ancho -= 1
        pulsado = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccion2 = objetoMaps.ImagenStreetViewLatiLong(latitudLongitud(0), latitudLongitud(1), 551, 412, Label2.Text)
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion2)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox2.Image = bmp
    End Sub

    Private Sub PictureBox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseDown
        If CInt(Label2.Text) >= 0 Then
            Timer6.Interval = 100
            Timer6.Enabled = True
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If pulsado = 0 Then
            pulsado += 1
        Else
            Dim ancho As Integer
            ancho = Label2.Text
            If ancho > 0 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer6.Interval = 10
                End If
                ancho -= 1
                Label2.Text = ancho
            End If
        End If
    End Sub

   
End Class