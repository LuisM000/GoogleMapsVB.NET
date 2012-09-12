Public Class StreetView
    Dim pulsado As Integer

    Private Sub StreetView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Enabled = True
        Dim objetoMaps As New GoogleMaps
        Dim direccion As New Uri(objetoMaps.ImagenStreetViewDireccion(streetViewDIreccion, 787, 787, Label2.Text, Label3.Text, 120 - Label1.Text))
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox1.Image = bmp
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Timer2.Enabled = True
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.ImageLocation = "imagenes/white/cancel.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.ImageLocation = "imagenes/black/cancel.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.03
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.03
        Else
            Me.Close()
            Timer1.Enabled = False
        End If
    End Sub

    
    Private Sub PictureBox4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseUp
        Timer3.Enabled = False
        Dim ancho As Integer
        ancho = Label1.Text

        ancho += 1
        If ancho <> 100 Then Label1.Text = ancho
        pulsado = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccion As New Uri(objetoMaps.ImagenStreetViewDireccion(streetViewDIreccion, 787, 787, Label2.Text, Label3.Text, 120 - Label1.Text))
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox1.Image = bmp

    End Sub
    Private Sub PictureBox4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseDown
        If CInt(Label1.Text) <= 99 Then
            Timer3.Interval = 100
            Timer3.Enabled = True
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If pulsado = 0 Then
            pulsado += 1
        Else
            Dim ancho As Integer
            ancho = Label1.Text
            If ancho < 99 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer3.Interval = 10
                End If
                ancho += 1
                Label1.Text = ancho
            End If
        End If
    End Sub
 
  
    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseUp
        Timer4.Enabled = False
        Dim ancho As Integer
        ancho = Label1.Text
        If ancho <> 0 Then Label1.Text = ancho - 1
        ancho -= 1
        pulsado = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccion As New Uri(objetoMaps.ImagenStreetViewDireccion(streetViewDIreccion, 787, 787, Label2.Text, Label3.Text, 120 - Label1.Text))
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox1.Image = bmp
    End Sub
    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        If CInt(Label1.Text) >= 0 Then
            Timer4.Interval = 100
            Timer4.Enabled = True
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If pulsado = 0 Then
            pulsado += 1
        Else
            Dim ancho As Integer
            ancho = Label1.Text
            If ancho > 0 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer4.Interval = 10
                End If
                ancho -= 1
                Label1.Text = ancho
            End If
        End If
    End Sub

   

    Private Sub PictureBox6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseUp
        Timer5.Enabled = False
        Dim ancho As Integer
        ancho = Label2.Text
        ancho += 1
        If ancho <> 360 Then Label2.Text = ancho
        pulsado = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccion As New Uri(objetoMaps.ImagenStreetViewDireccion(streetViewDIreccion, 787, 787, Label2.Text, Label3.Text, 120 - Label1.Text))
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox1.Image = bmp
    End Sub
    Private Sub PictureBox6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseDown
        If CInt(Label2.Text) <= 359 Then
            Timer5.Interval = 100
            Timer5.Enabled = True
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If pulsado = 0 Then
            pulsado += 1
        Else
            Dim ancho As Integer
            ancho = Label2.Text
            If ancho < 359 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer5.Interval = 10
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
        Dim direccion As New Uri(objetoMaps.ImagenStreetViewDireccion(streetViewDIreccion, 787, 787, Label2.Text, Label3.Text, 120 - Label1.Text))
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox1.Image = bmp
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




    Private Sub PictureBox8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseUp
        Timer7.Enabled = False
        Dim ancho As Integer
        ancho = Label3.Text
        ancho += 1
        If ancho <> 90 Then Label3.Text = ancho
        pulsado = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccion As New Uri(objetoMaps.ImagenStreetViewDireccion(streetViewDIreccion, 787, 787, Label2.Text, Label3.Text, 120 - Label1.Text))
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox1.Image = bmp
    End Sub
    Private Sub PictureBox8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseDown
        If CInt(Label3.Text) <= 89 Then
            Timer7.Interval = 100
            Timer7.Enabled = True
        End If
    End Sub
    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If pulsado = 0 Then
            pulsado += 1
        Else
            Dim ancho As Integer
            ancho = Label3.Text
            If ancho < 89 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer7.Interval = 10
                End If
                ancho += 1
                Label3.Text = ancho
            End If
        End If
    End Sub

    

End Class