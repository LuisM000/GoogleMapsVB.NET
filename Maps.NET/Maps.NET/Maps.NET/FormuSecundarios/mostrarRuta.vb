

Public Class mostrarRuta

    Dim datosRutaE
    Sub New(ByVal datosRuta() As String)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        datosRutaE = datosRuta
    End Sub


    Private Sub mostrarRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mas As New MapsNet
        Dim hitos As New ArrayList
        If statusRuta = "OK" Then
            Try
                For i = 0 To UBound(datosRutaE) - 1 Step 5
                    RichTextBox1.Text = RichTextBox1.Text & datosRutaE(i) & "||| "
                    RichTextBox1.Text = RichTextBox1.Text & datosRutaE(i + 1) & "||| "
                    RichTextBox1.Text = RichTextBox1.Text & datosRutaE(i + 2) & "||| "
                    RichTextBox1.Text = RichTextBox1.Text & datosRutaE(i + 3) & "||| "
                    RichTextBox1.Text = RichTextBox1.Text & datosRutaE(i + 4) & "||| " & vbCrLf
                Next
                RichTextBox1.Text = mas.QuitarEtiqueta(RichTextBox1.Text)
                With DataGridView1
                    .BorderStyle = BorderStyle.Fixed3D
                    .CellBorderStyle = DataGridViewCellBorderStyle.Sunken
                    .RowHeadersBorderStyle = _
                        DataGridViewHeaderBorderStyle.Raised
                    .ColumnHeadersBorderStyle = _
                        DataGridViewHeaderBorderStyle.Raised
                    .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Inset
                End With

                For i = 0 To UBound(datosRutaE) - 1 Step 5
                    dgvTiempo.DataGridView.Rows.Add(datosRutaE(i + 2), datosRutaE(i + 3), mas.QuitarEtiqueta(datosRutaE(i + 4)), datosRutaE(i), datosRutaE(i + 1))
                Next

                Dim distancia = 0

                For Each dato In DistanciaTotal
                    distancia += dato
                Next
                txtdistancia.Text = distancia / 1000 & " km"
                txttiempo.Text = DuraciTotal(0)
            Catch
            End Try
        End If

    End Sub
End Class




'Private Sub Rutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    
'End Sub