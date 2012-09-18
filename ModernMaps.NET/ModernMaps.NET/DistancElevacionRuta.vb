Public Class DistancElevacionRuta

    Private Sub DistancElevacionRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(0, 357)
        Me.Opacity = 0
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        txtdistancia.Visible = False
        txttiempo.Visible = False
        txtelevacion.Visible = False
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).TextChanged, AddressOf BuscarD
            End If
        Next
        Label12.ForeColor = Color.White
        Label20.ForeColor = Color.White
        Timer2.Enabled = True
    End Sub
    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.LightCyan
    End Sub

    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub BuscarD(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtcalle.Text <> "" And txtpoblacion.Text <> "" And txtprovincia.Text <> "" And txtcalle2.Text <> "" And txtpoblacion2.Text <> "" And txtprovincia2.Text <> "" Then
            Timer1.Enabled = True
        End If
        If txtcalle.Text <> "" And txtpoblacion.Text <> "" And txtprovincia.Text <> "" Then
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Height < 430 Then
            Me.Height = Me.Height + 10
            Me.Location = New Size(Me.Location.X, Me.Location.Y - 5)
        Else
            Timer1.Interval = 2500
            Dim objetoMaps As New GoogleMaps
            Dim datosRuta(3) As String
            Dim direccion1, direccion2 As String
            Dim tipoTransito As Integer
            Dim tiporuta As Boolean
            For Each c As Control In Me.Controls
                If TypeOf c Is Label Then
                    If c.ForeColor = Color.White Then
                        Select Case c.Text
                            Case "Andando"
                                tipoTransito = 1
                            Case "Coche"
                                tipoTransito = 0
                            Case "Bicicleta"
                                tipoTransito = 2
                            Case "Sí"
                                tiporuta = True
                            Case "No"
                                tiporuta = False
                            Case Else

                        End Select
                    End If
                End If
            Next

            direccion1 = txtcalle.Text & " " & txtpoblacion.Text & " " & txtprovincia.Text
            direccion2 = txtcalle2.Text & " " & txtpoblacion2.Text & " " & txtprovincia2.Text
            datosRuta = objetoMaps.CalcularRuta(direccion1, direccion2, tiporuta, tipoTransito)
            txtcompleta1.Text = datosRuta(0)
            txtcompleta2.Text = datosRuta(1)
            txttiempo.Text = datosRuta(2)
            txtdistancia.Text = datosRuta(3)
            Dim elevacion(1) As String
            elevacion = objetoMaps.ElevacionDosPuntos(txtcompleta1.Text, txtcompleta2.Text)
            txtelevacion.Text = elevacion(1) - elevacion(0) & " m"
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            txtdistancia.Visible = True
            txttiempo.Visible = True
            txtelevacion.Visible = True
            Timer1.Enabled = False
        End If
    End Sub














    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer4.Enabled = True
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.ImageLocation = "imagenes/white/back.png"
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = "imagenes/black/back.png"
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Label11.ForeColor = Color.White
        Label12.ForeColor = Color.Black
        Label13.ForeColor = Color.Black
        BuscarD(sender, e)
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.White
        Label13.ForeColor = Color.Black
        BuscarD(sender, e)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        Label13.ForeColor = Color.White
        BuscarD(sender, e)
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As EventArgs) Handles Label12.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label12_MouseLeave(sender As Object, e As EventArgs) Handles Label12.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As EventArgs) Handles Label13.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles Label13.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Label21.ForeColor = Color.White
        Label20.ForeColor = Color.Black
        BuscarD(sender, e)
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Label21.ForeColor = Color.Black
        Label20.ForeColor = Color.White
        BuscarD(sender, e)
    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As EventArgs) Handles Label21.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label21_MouseLeave(sender As Object, e As EventArgs) Handles Label21.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As EventArgs) Handles Label20.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label20_MouseLeave(sender As Object, e As EventArgs) Handles Label20.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Width < 728 Then
            Me.Width = Me.Width + 10
            Me.Opacity = Me.Opacity + 0.023
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Width < 1210 Then
            Me.Width = Me.Width + 10
            Me.Location = New Size(Me.Location.X - 5, Me.Location.Y)
        Else
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        txtdistancia.Visible = False
        txttiempo.Visible = False
        txtelevacion.Visible = False
        If Me.Height > 358 Then
            Me.Height = Me.Height - 10
            Me.Location = New Size(Me.Location.X, Me.Location.Y + 5)
        Else
            timer5.enabled = True
            Timer4.Enabled = False
        End If


    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Me.Width > 2 Then
            Me.Width = Me.Width - 15
            Me.Opacity = Me.Opacity - 0.02
        Else
            Timer5.Enabled = False
            Me.Close()
            Principal.Show()
        End If
    End Sub
End Class