Public Class StreetViewlat

    Private Sub StreetViewlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Indicamos que los txt admite autocompletado
        Dim aspectoFor As New AspectoFormulario
        aspectoFor.CargarControles(Me)
        '****

        Label1.Text = 120 - 90
        Label2.Text = 165
        Label3.Text = 0
        HScrollBar1.Value = CInt(Label1.Text)
        HScrollBar2.Value = CInt(Label2.Text)
        HScrollBar3.Value = CInt(Label3.Text)
        txtlatitud.Text = "40.4168762"
        txtlongitud.Text = "-3.7033046"
        Button1_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            txtlongitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            txtlatitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            Dim mapas As New MapsNet
            Dim tamaño() As Integer = {(600), (400)}
            Dim latLong() As Double = {CDbl((txtlatitud.Text)), CDbl((txtlongitud.Text))}
            PictureBox2.Image = mapas.StreetView(latLong, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value) 'Asignamos la imagen al picture

            'Añadir al autocompletado
            aspectoFormu.autocompletar({txtlatitud.Text, txtlongitud.Text})
        Else
            If aspectoFormu.verificarnumeros(txtlatitud.Text) = False Then txtlatitud.ForeColor = Color.Red
            If aspectoFormu.verificarnumeros(txtlongitud.Text) = False Then txtlongitud.ForeColor = Color.Red
        End If
       
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim latLong() As Double = {CDbl((txtlatitud.Text)), CDbl((txtlongitud.Text))}
        Label1.Text = HScrollBar1.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(600), (400)}
        PictureBox2.Image = mapas.StreetView(latLong, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value)
    End Sub


    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Dim latLong() As Double = {CDbl((txtlatitud.Text)), CDbl((txtlongitud.Text))}
        Label2.Text = HScrollBar2.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(600), (400)}
        PictureBox2.Image = mapas.StreetView(latLong, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value)
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Dim latLong() As Double = {CDbl((txtlatitud.Text)), CDbl((txtlongitud.Text))}
        Label3.Text = HScrollBar3.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(600), (400)}
        PictureBox2.Image = mapas.StreetView(latLong, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim latLong() As Double = {CDbl((txtlatitud.Text)), CDbl((txtlongitud.Text))}
        Dim aspecto As New AspectoFormulario
        Dim bmp As New Bitmap(PictureBox2.Image)
        Dim coordenadas As String = latLong(0) & "," & latLong(1)
        aspecto.guardarcomo(bmp, coordenadas)
    End Sub
End Class