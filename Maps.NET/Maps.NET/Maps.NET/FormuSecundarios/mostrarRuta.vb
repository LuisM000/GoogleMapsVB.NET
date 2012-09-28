

Public Class mostrarRuta

    Dim datosRutaE
    Sub New(ByVal datosRuta() As String)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        datosRutaE = datosRuta
    End Sub

    Dim colorDesalida = Color.White
    Dim colorDeincorp = Color.White
    Dim colorDedescanso = Color.White

    Private Sub mostrarRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim maps As New MapsNet
        Dim hitos As New ArrayList
        If statusRuta = "OK" Then
            Try
                Me.Text = "Ruta " & rutaID(0).ToString
                With DataGridView1
                    .BorderStyle = BorderStyle.Fixed3D
                    .CellBorderStyle = DataGridViewCellBorderStyle.Sunken
                    .RowHeadersBorderStyle = _
                        DataGridViewHeaderBorderStyle.Raised
                    .ColumnHeadersBorderStyle = _
                        DataGridViewHeaderBorderStyle.Raised
                    .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Inset
                End With
                pintar(Color.White, Color.White, Color.White)
                Dim tiempoAcumulado As Double

                Dim contadorT = 0
                For i = 0 To UBound(datosRutaE) - 1 Step 5
                    DataGridView1.Rows.Add(datosRutaE(i + 2), datosRutaE(i + 3), maps.QuitarEtiqueta(datosRutaE(i + 4)), datosRutaE(i), datosRutaE(i + 1))
                    tiempoAcumulado += CInt(TiempoSegundos(contadorT) / 60)
                    If tiempoAcumulado > 120 Then
                        dgvTiempo.DataGridView.Rows.Add("------------", "------------", "TÓMESE UN DESCANSO", "------------", "------------")
                        tiempoAcumulado = 0
                    End If
                    contadorT += 1
                Next
                'Pintamos celdas
                pintar(Color.PaleGreen, Color.White, Color.White)
                colorDedescanso = Color.PaleGreen
                Dim distancia = 0
                Dim tiempo = 0
                For Each dato In DistanciaTotal
                    distancia += dato
                Next
                For Each dato In DuraciTotal
                    tiempo += dato
                Next
                txtdistancia.Text = distancia / 1000 & " km"
                txttiempo.Text = maps.SegundosAHorMinSeg(tiempo)

                If ordenRuta.Count <> 0 Then
                    Dim lista As New ListBox()
                    lista = Rutas.ListBox1
                    Dim contador = 0
                    For i = 0 To ordenRuta.Count - 1
                        Dim cadena = lista.Items(ordenRuta(i)).ToString
                        ListBox1.Items.Add(cadena)
                        contador += 1
                    Next
                    GroupBox1.Visible = True
                End If

                Label3.Text = copyRuta(0)
            Catch
                MessageBox.Show("")
            End Try
        End If

    End Sub

    Sub pintar(ByVal colorDescanso As Color, ByVal colorSalida As Color, ByVal colorIncorporacion As Color)
        For i = 0 To DataGridView1.RowCount - 2
            If (DataGridView1.Item(2, i).Value.ToString.Contains("Toma la salida")) = True Then
                DataGridView1.Item(2, i).Style.BackColor = colorSalida
            ElseIf (DataGridView1.Item(2, i).Value.ToString.Contains("Incorpórate")) = True Then
                DataGridView1.Item(2, i).Style.BackColor = colorIncorporacion
            ElseIf (DataGridView1.Item(2, i).Value.ToString.Contains("TÓMESE UN DESCANSO")) = True Then
                DataGridView1.Item(2, i).Style.BackColor = colorDescanso
            End If
        Next
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            pintar(colorDedescanso, colorS, colorDeincorp)
            colorDesalida = colorS
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorI = ColorDialog1.Color
            pintar(colorDedescanso, colorDesalida, colorI)
            colorDeincorp = colorI
        End If
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub
End Class


