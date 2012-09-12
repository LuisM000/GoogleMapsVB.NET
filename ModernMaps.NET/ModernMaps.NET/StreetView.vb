Public Class StreetView
    Dim pulsado As Integer

    Private Sub StreetView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Enabled = True
        Dim objetoMaps As New GoogleMaps
        Dim direccion = objetoMaps.ImagenStreetViewDireccion(streetViewDIreccion, 787, 787, Label2.Text, Label3.Text, 120 - Label1.Text)
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
        If ancho <> 180 Then Label3.Text = ancho
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
        If CInt(Label3.Text) <= 179 Then
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
            If ancho < 179 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer7.Interval = 10
                End If
                ancho += 1
                Label3.Text = ancho
            End If
        End If
    End Sub

   
    Private Sub PictureBox7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseUp
        Timer8.Enabled = False
        Dim ancho As Integer
        ancho = Label3.Text
        If ancho <> -90 Then Label3.Text = ancho - 1
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

    Private Sub PictureBox7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseDown
        If CInt(Label3.Text) >= -90 Then
            Timer8.Interval = 100
            Timer8.Enabled = True
        End If
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        If pulsado = 0 Then
            pulsado += 1
        Else
            Dim ancho As Integer
            ancho = Label3.Text
            If ancho > -90 Then
                pulsado += 1
                If pulsado > 10 Then
                    Timer8.Interval = 10
                End If
                ancho -= 1
                Label3.Text = ancho
            End If
        End If
    End Sub


    '*************************************************************************************
    '*************************************************************************************

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.ImageLocation = "imagenes/white/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.ImageLocation = "imagenes/black/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.ImageLocation = "imagenes/white/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.ImageLocation = "imagenes/black/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.ImageLocation = "imagenes/white/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.ImageLocation = "imagenes/black/minus.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub




    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.ImageLocation = "imagenes/white/add.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.ImageLocation = "imagenes/black/add.png"
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

    Private Sub PictureBox8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.ImageLocation = "imagenes/white/add.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.ImageLocation = "imagenes/black/add.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
 

    Private Sub PictureBox9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.ImageLocation = "imagenes/white/save.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.ImageLocation = "imagenes/black/save.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Dim bmp As New Bitmap(PictureBox1.Image)
        Dim salvar As New SaveFileDialog
        With salvar
            .Filter = "Ficheros BMP|*.bmp" & _
                      "|Ficheros GIF|*.gif" & _
                      "|Ficheros JPG o JPEG|*.jpg;*.jpeg" & _
                      "|Ficheros PNG|*.png" & _
                      "|Ficheros TIFF|*.tif"
            .FilterIndex = 3
            Dim nombreSalida = streetViewDIreccion.Replace("+", "_")
            nombreSalida = nombreSalida.Replace(":", "-")
            .FileName = "CapturaStreetView-" & nombreSalida
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

    
End Class