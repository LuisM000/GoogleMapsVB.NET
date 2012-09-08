Public Class ISP

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
     

    Private Sub ISP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.Size = New Size(0, 360)
        Me.Opacity = 0
        txtip.Focus()
        Dim objetoMaps As New GoogleMaps
        Dim ip As String = objetoMaps.ObtenerIp
        Dim datosLocalizacion = objetoMaps.localizarIp(ip)
        txtip.Text = ip
        txtlatitud.Text = datosLocalizacion(3)
        txtlongitud.Text = datosLocalizacion(4)
        txtciudad.Text = datosLocalizacion(1)
        txtpais.Text = datosLocalizacion(0)
        txtregion.Text = datosLocalizacion(2)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dim objetoMaps As New GoogleMaps
        Dim direccion = objetoMaps.ObtenerURLlatlongMaps(txtlatitud.Text, txtlongitud.Text)
        Dim url As New Uri(direccion)
        WebBrowser1.Url = url
        Timer4.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Width < 470 Then
            Me.Opacity = Me.Opacity + 0.025
            Me.Width = Me.Width + 10
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.White
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Width < 980 Then
            Me.Width = Me.Width + 10
            Me.Location = New Point(Me.Location.X - 5, Me.Location.Y)
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Height < 700 Then
            Me.Height = Me.Height + 10
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 5)
        Else
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Timer2.Enabled = True
        Timer3.Enabled = True
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
        If Me.Height > 360 Then
            Me.Height = Me.Height - 10
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)
        Else
            Timer6.Enabled = False
        End If
    End Sub
End Class