Public Class Dirección

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario

        Dim direccionString = objetoMaps.ObtenerURLdesdeDireccion(txtdireccion.Text) 'String con la direccion
        Dim direccion As New Uri(direccionString) 'Pasamos el string a URI
        If CheckBox1.Checked = True Then 'Decidimos si lo abrimos en pestaña activa o nueva pestaña
            aspectoFormu.NuevaFicha("Dirección") 'Abrimos una nueva pestaña
        End If
        'Este código sirve para seleccionar el navegador de la pestaña activa
        Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
        navegador.Url = direccion
        'Añadir al autocompletado
        aspectoFormu.autocompletar({txtdireccion.Text})

    End Sub

    Private Sub Dirección_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aspectoFor As New AspectoFormulario
        aspectoFor.CargarControles(Me)
    End Sub
End Class