Public Class SecundariaStreet

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.03
        Else
            Timer1.Enabled = False
        End If
    End Sub


    Private Sub SecundariaStreet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Enabled = True
        Dim objetoMaps As New GoogleMaps
        Dim enviaDIreccion As String
        enviaDIreccion = streetViewDIreccion.Replace(" ", "+")
        Dim direccion As New Uri(objetoMaps.ImagenStreetViewDireccion(enviaDIreccion, 150, 150, 10, 0, 110))
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(direccion)
        Dim response As System.Net.WebResponse = request.GetResponse()
        Dim responseStream As System.IO.Stream = response.GetResponseStream()
        Dim bmp As New Bitmap(responseStream)
        PictureBox1.Image = bmp
    End Sub
End Class