Public Class StreetViewDIr
    Dim aspectoFormu As New AspectoFormulario
    Private Sub StreetViewDIr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

           'Indicamos que los txt admite autocompletado
        Dim aspectoFor As New AspectoFormulario
        aspectoFor.CargarControles(Me)

        Label1.Text = 120 - 90
        Label2.Text = 165
        Label3.Text = 0
        HScrollBar1.Value = CInt(Label1.Text)
        HScrollBar2.Value = CInt(Label2.Text)
        HScrollBar3.Value = CInt(Label3.Text)
        txtdireccion.Text = "Puerta del Sol, 28013 Madrid, España"
        Button1_Click(sender, e)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(600), (400)}
        Dim direccion As String = txtdireccion.Text.Replace(" ", "+")
        PictureBox2.Image = mapas.StreetView(txtdireccion.Text, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value) 'Asignamos la imagen al picture
        'Añadir al autocompletado
        aspectoFormu.autocompletar({txtdireccion.Text})
    End Sub


    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.Text = HScrollBar1.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(600), (400)}
        PictureBox2.Image = mapas.StreetView(txtdireccion.Text, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value)
    End Sub


    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label2.Text = HScrollBar2.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(600), (400)}
        PictureBox2.Image = mapas.StreetView(txtdireccion.Text, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value)
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Label3.Text = HScrollBar3.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(600), (400)}
        PictureBox2.Image = mapas.StreetView(txtdireccion.Text, tamaño, HScrollBar2.Value, HScrollBar3.Value, 120 - HScrollBar1.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aspecto As New AspectoFormulario
        Dim bmp As New Bitmap(PictureBox2.Image)
        aspecto.guardarcomo(bmp, txtdireccion.Text)
    End Sub
End Class