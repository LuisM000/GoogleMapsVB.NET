Public Class latlong

    Private Sub latlong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Dim direccion As New Uri(" http://maps.google.es/maps?q=España&output=embed")
        WebBrowser1.Url = direccion
        Me.Size = New Size(0, 333)
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).KeyDown, AddressOf Buscar
            End If
        Next
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next
        txtpoblacion.Focus()
        Timer4.Interval = 1000
        Timer4.Enabled = True
    End Sub
    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.LightCyan
    End Sub


    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub
    Private Sub Buscar(ByVal sender As Object, ByVal e As System.EventArgs)
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer5.Enabled = True
        Timer6.Enabled = True
    End Sub
    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.ImageLocation = "imagenes/white/back.png"
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = "imagenes/black/back.png"
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim objetoMaps As New GoogleMaps
        Dim latlong(1) As Double
        Dim calle = txtcalle.Text
        If txtcalle.Text <> "" Then
            calle = calle.ToLower()
            Dim posicion = calle.Contains("calle")
            If posicion = False Then
                calle = "calle " + txtcalle.Text
            End If
        Else
            calle = ""
        End If
        latlong = objetoMaps.ObternetLatLong(calle, txtpoblacion.Text, txtprovincia.Text, txtcomunidad.Text, txtpais.Text)
        txtlat.Text = latlong(0)
        txtlong.Text = latlong(1)
        Dim direccion As New Uri(objetoMaps.ObtenerURLlatlongMaps(latlong(0), latlong(1)))
        WebBrowser1.Url = direccion
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Height < 700 Then
            Me.Height = Me.Height + 10
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 5)
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Width < 980 Then
            Me.Width = Me.Width + 10
            Me.Location = New Point(Me.Location.X - 5, Me.Location.Y)
        Else
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Me.Width < 470 Then
            Timer4.Interval = 1
            Me.Opacity = Me.Opacity + 0.025
            Me.Width = Me.Width + 10
        Else
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Me.Width > 2 Then
            Me.Width = Me.Width - 10
            If Me.Width > 470 Then
                Me.Location = New Point(Me.Location.X + 5, Me.Location.Y)
            Else
                Me.Opacity = Me.Opacity - 0.023
            End If
        Else
            Timer5.Enabled = False
            Me.Close()
            Principal.Show()
        End If

    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If Me.Height > 333 Then
            Me.Height = Me.Height - 10

            Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)

        Else
            Timer6.Enabled = False
        End If
    End Sub
End Class