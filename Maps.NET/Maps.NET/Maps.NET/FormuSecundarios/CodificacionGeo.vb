Public Class CodificacionGeo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario

        Dim region = "es" 'Region de búsqueda
        Dim direccionString As ArrayList
        direccionString = objetoMaps.CodificacionGeografica(txtdireccion.Text, region) 'Recibimos datos

        Try
            txtlatitud.Text = direccionString(0)
            txtlongitud.Text = direccionString(1)
            txtdir.Text = direccionString(2)

        Catch
            txtlatitud.Text = "El servidor no responde" 'Si no hay datos
            txtlongitud.Text = "El servidor no responde" 'Si no hay datos
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            Dim direccionString = objetoMaps.ObtenerURLdesdelatlong(txtlatitud.Text, txtlongitud.Text) 'String con la direccion
            Dim direccion As New Uri(direccionString) 'Pasamos el string a URI
            If CheckBox1.Checked = True Then 'Decidimos si lo abrimos en pestaña activa o nueva pestaña
                aspectoFormu.NuevaFicha("Codificación Geográfica") 'Abrimos una nueva pestaña
            End If
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = direccion
        End If
    End Sub
End Class