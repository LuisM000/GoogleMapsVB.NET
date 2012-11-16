Public Class CodigoPostal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario

        Dim region = "es" 'Region de búsqueda
        Dim codPostal As String = ""
        Dim direccion As New ArrayList
        codPostal = objetoMaps.CodigoPostal(txtdireccion.Text, region) 'Recibimos datos
        direccion = objetoMaps.CodificacionGeografica(txtdireccion.Text, region) 'Recibimos datos
        Try
            If codPostal <> "" Then
                txtCP.BackColor = Color.White
                txtCP.Text = codPostal
            Else
                txtCP.BackColor = Color.FromArgb(247, 105, 81)
                txtCP.Text = "No encontrado código postal. Sea más específico (indique calle, plaza, etc.)"
            End If
            txtDire.Text = direccion(2)

            'Añadir al autocompletado
            aspectoFormu.autocompletar(txtdireccion.Text)

        Catch
            txtCP.Text = "El servidor no responde" 'Si no hay datos
            txtdireccion.Text = "El servidor no responde" 'Si no hay datos
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If txtDire.Text <> "" Then 'Verificamos que sean numeros
            Dim direccionString = objetoMaps.ObtenerURLdesdeDireccion(txtDire.Text) 'String con la direccion
            Dim direccion As New Uri(direccionString) 'Pasamos el string a URI
            If CheckBox1.Checked = True Then 'Decidimos si lo abrimos en pestaña activa o nueva pestaña
                aspectoFormu.NuevaFicha("Código postal") 'Abrimos una nueva pestaña
            End If
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = direccion
        End If
    End Sub

    Private Sub CodigoPostal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Indicamos que el txt admite autocompletado
        With txtdireccion
            .AutoCompleteCustomSource = MySource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
    End Sub
End Class