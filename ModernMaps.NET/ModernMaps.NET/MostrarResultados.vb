Public Class MostrarResultados

    Private Sub MostrarResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer4.Enabled = True
        Label7.Text = localizacion
        Me.Opacity = 0
        Dim objetoMaps As New GoogleMaps
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLlatlongMaps(latitudLongitud(0), latitudLongitud(1))
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.03
        Else
            Timer4.Enabled = False
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
End Class