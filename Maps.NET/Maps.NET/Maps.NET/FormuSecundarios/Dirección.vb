Public Class Dirección

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario

        Dim direccionString = objetoMaps.ObtenerURLdesdeDireccion(txtdireccion.Text) 'String con la direccion
        Dim direccion As New Uri(direccionString) 'Pasamos el string a URI
        'Este código sirve para seleccionar el navegador de la pestaña activa
        Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
        navegador.Url = direccion

    End Sub
End Class