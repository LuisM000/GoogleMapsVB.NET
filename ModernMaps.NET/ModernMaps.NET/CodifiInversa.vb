Imports System.Windows.Input

Public Class CodifiInversa

    Private Sub CodifiInversa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False
        Me.Opacity = 0
        Dim direccion As New Uri(" http://maps.google.es/maps?q=España&output=embed")
        WebBrowser1.Url = direccion
        Me.Size = New Size(0, 162)
        labelres.Text = ""
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
        Timer3.Interval = 1000
        Timer3.Enabled = True
        txtlat.Focus()
    End Sub
    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.LightCyan
    End Sub

    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer4.Enabled = True
        Timer5.Enabled = True
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.ImageLocation = "imagenes/white/back.png"
        Me.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = "imagenes/black/back.png"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub Buscar(ByVal sender As Object, ByVal e As System.EventArgs)
        Timer2.Enabled = True
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If IsNumeric(txtlat.Text) And IsNumeric(txtlong.Text) Then
            If Me.Width < 980 Then
                Me.Width = Me.Width + 10
                Me.Location = New Point(Me.Location.X - 5, Me.Location.Y)
            Else
                Timer1.Interval = 1000
                Dim objetoMaps As New GoogleMaps
                Dim direccionAux As String
                Dim resultado = objetoMaps.CodificacionGeoInv(txtlat.Text, txtlong.Text)
                labelres.Text = resultado
                resultado = resultado.Replace("Dirección postal: ", "")
                resultado = resultado.Replace("Ruta: ", "")
                resultado = resultado.Replace("Intersección: ", "")
                resultado = resultado.Replace("Dirección: ", "")
                resultado = resultado.Replace("Dirección no encontrada", "")
                resultado = resultado.Replace(" ", "+")
                resultado = resultado.Replace("  ", "+")
                direccionAux = objetoMaps.ObtenerURLDireccionMaps(resultado)
                Dim direccion As New Uri(direccionAux)
                If direccionAux <> "http://maps.google.es/maps?q=      &output=embed" Then
                    WebBrowser1.Url = direccion
                End If
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If IsNumeric(txtlat.Text) And IsNumeric(txtlong.Text) Then
            If Me.Height < 700 Then
                Me.Height = Me.Height + 10
                Me.Location = New Point(Me.Location.X, Me.Location.Y - 5)
            Else
                Timer2.Enabled = False
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Width < 467 Then
            Timer3.Interval = 1
            Me.Opacity = Me.Opacity + 0.025
            Me.Width = Me.Width + 10
        Else
            Timer3.Enabled = False
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Me.Width > 2 Then
            Me.Width = Me.Width - 10
            If Me.Width > 467 Then
                Me.Location = New Point(Me.Location.X + 5, Me.Location.Y)
            Else
                Me.Opacity = Me.Opacity - 0.023
            End If
        Else
            Timer4.Enabled = False
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Me.Height > 162 Then
            Me.Height = Me.Height - 10

            Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)

        Else
            Timer5.Enabled = False
        End If
    End Sub

 

    'Private Function getMouseLoc() As Point
    '    getMouseLoc = Me.PointToClient(Windows.Forms.Cursor.Position)
    '    Return getMouseLoc
    'End Function
    Private Sub labelres_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles labelres.MouseEnter
        'Dim mouseLoc As Point = getMouseLoc()
        'mouseLoc.Y -= 150
        'mouseLoc.X += 25
        'PictureBox2.Location = mouseLoc
           labelres.ForeColor = Color.White
        streetViewDIreccion = labelres.Text
        Me.Cursor = Windows.Forms.Cursors.Hand
        SecundariaStreet.Show()


        Select Case labelres.Size.Width
            Case Is > 750
                SecundariaStreet.Location = New Point(1050, 95)
            Case Is < 400
                SecundariaStreet.Location = New Point(675, 95)
            Case Else
                Dim ancho = labelres.Size.Width + 300
                SecundariaStreet.Location = New Point(ancho, 100)
        End Select


    End Sub

    Private Sub labelres_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles labelres.MouseLeave
        SecundariaStreet.Close()
        labelres.ForeColor = Color.Black
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub


    Private Sub labelres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelres.Click
        streetViewDIreccion = labelres.Text.Replace(" ", "+")
        StreetView.Show()
    End Sub

End Class