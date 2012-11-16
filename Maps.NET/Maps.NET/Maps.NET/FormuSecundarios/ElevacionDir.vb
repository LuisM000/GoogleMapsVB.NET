Public Class ElevacionDir

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario

        Dim region = "es" 'Region de búsqueda
        Dim direccionString As ArrayList
        direccionString = objetoMaps.CodificacionGeografica(txtdireccion.Text, region) 'Recibimos datos

        Try
            txtlat.Text = direccionString(0)
            txtlng.Text = direccionString(1)
            txtdirEnc.Text = direccionString(2)

        Catch
            txtlat.Text = "El servidor no responde" 'Si no hay datos
            txtlng.Text = "El servidor no responde" 'Si no hay datos
            txtdirEnc.Text = "Dirección no encontrada"
            PictureBox1.Image = My.Resources.cancel
        End Try

        If IsNumeric(txtlat.Text) And IsNumeric(txtlng.Text) Then
            Dim coordenadas As New ArrayList
            coordenadas.Add(txtlat.Text)
            coordenadas.Add(txtlng.Text)
            Try
                Dim datosElevacion = objetoMaps.Elevacion(coordenadas)
                DataGridView1.Rows.Add(txtlat.Text, txtlng.Text, txtdirEnc.Text, FormatNumber(datosElevacion(0), 3) & " metros", resolucion(0))
                PictureBox1.Image = My.Resources.check

                'Añadir al autocompletado
                aspectoFormu.autocompletar(txtdireccion.Text)
            Catch
            End Try
        End If

    End Sub

    Private Sub ElevacionDir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Indicamos que el txt admite autocompletado
        With txtdireccion
            .AutoCompleteCustomSource = MySource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        'Aspecto del DataGridView
        With DataGridView1
            .BorderStyle = BorderStyle.Fixed3D
            .CellBorderStyle = DataGridViewCellBorderStyle.Sunken
            .RowHeadersBorderStyle = _
                DataGridViewHeaderBorderStyle.Raised
            .ColumnHeadersBorderStyle = _
                DataGridViewHeaderBorderStyle.Raised
            .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Inset
        End With
    End Sub
End Class