Public Class MapasSencillos

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aspectoFormu As New AspectoFormulario
        If txtdireccion.Text <> "" Then
            Dim direccion As String = txtdireccion.Text 'Variable direccion
            Dim zoom As Integer = NumericUpDown1.Value 'Variable zoom
            Dim size(1) As Integer 'Variable tamaño imagen
            size(0) = NumericUpDown2.Value
            size(1) = NumericUpDown3.Value
            Dim tipoMapa As Integer 'Tipo de mapa
            Select Case ComboBox1.SelectedIndex
                Case 0
                    tipoMapa = 0
                Case 1
                    tipoMapa = 1
                Case 2
                    tipoMapa = 2
                Case 3
                    tipoMapa = 3
            End Select
            Dim tipoFormato As Integer 'Tipo de formato
            Select Case ComboBox2.SelectedIndex
                Case 0
                    tipoFormato = 0
                Case 1
                    tipoFormato = 1
                Case 2
                    tipoFormato = 2
                Case 3
                    tipoFormato = 3
                Case 4
                    tipoFormato = 4
            End Select
            Dim maps As New MapsNet
            Dim marcador As String = "&markers=color:red|label:1|" & direccion
            Dim direccionURL As String = maps.MapasEstaticos(direccion, zoom, size, tipoFormato, tipoMapa, , marcador)
            Dim urlMapa As New Uri(direccionURL)
            Me.WebBrowser1.Url = urlMapa

            'Añadir al autocompletado
            aspectoFormu.autocompletar(txtdireccion.Text)
        End If
    End Sub

    Private Sub MapasSencillos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maps As New MapsNet
        txtdireccion.Text = "Puerta del Sol, Madrid, España"
        Dim zoom As Integer = NumericUpDown1.Value 'Variable zoom
        Dim size(1) As Integer 'Variable tamaño imagen
        size(0) = NumericUpDown2.Value
        size(1) = NumericUpDown3.Value
        Dim marcador As String = "&markers=color:red|label:1|" & "Puerta del Sol, Madrid, España"
        Dim direccionURL As String = maps.MapasEstaticos("Puerta del Sol, Madrid, España", zoom, size, 0, 0, , marcador)
        Dim urlMapa As New Uri(direccionURL)
        Me.WebBrowser1.Url = urlMapa

        'Indicamos que el txt admite autocompletado
        With txtdireccion
            .AutoCompleteCustomSource = MySource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

    End Sub
End Class