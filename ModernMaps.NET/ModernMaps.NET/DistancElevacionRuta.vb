Public Class DistancElevacionRuta

    Private Sub DistancElevacionRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim objetoMaps As New GoogleMaps
        Dim datosRuta(3) As String
        Dim direccion1, direccion2 As String
        direccion1 = txtcalle.Text & " " & txtpoblacion.Text & " " & txtprovincia.Text
        direccion2 = txtcalle2.Text & " " & txtpoblacion2.Text & " " & txtprovincia2.Text
        datosRuta = objetoMaps.CalcularRuta(direccion1, direccion2)
        txtcompleta1.Text = datosRuta(0)
        txtcompleta2.Text = datosRuta(1)
        txttiempo.Text = datosRuta(2)
        txtdistancia.Text = datosRuta(3)
        Dim elevacion(1) As String
        elevacion = objetoMaps.ElevacionDosPuntos(txtcompleta1.Text, txtcompleta2.Text)
        txtelevacion.Text = elevacion(1) - elevacion(0) & " m"
        Timer1.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.ImageLocation = "imagenes/white/back.png"
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = "imagenes/black/back.png"
        Me.Cursor = Cursors.Default
    End Sub
End Class