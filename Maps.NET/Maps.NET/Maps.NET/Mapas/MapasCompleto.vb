Public Class MapasCompleto


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Añadir marcador a datagridview
        If txtmarcador.Text <> "" Then
            If ComboBox3.SelectedIndex = -1 Then ComboBox3.SelectedIndex = 4 'Si no hay seleccionado tamaño
            Dim color As Color = Button1.BackColor
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            DataGridView1.Rows.Add(txtmarcador.Text, ComboBox3.SelectedIndex, "0x" & hexa, txtlabel.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Color del marcador
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button1.BackColor = colorS
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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

        Dim marcadores As New ArrayList
        For i = 0 To DataGridView1.Rows.Count - 2
            marcadores.Add(cadenasDatagrid(i))
        Next

        Dim rutas As New ArrayList
        If DataGridView2.Rows.Count - 2 > 0 Then
            rutas.Add(cadenasDatagridRuta())
        End If




        Dim maps As New MapsNet
        Dim direccionURL As String = maps.MapasEstaticosCompletos(direccion, zoom, size, tipoFormato, tipoMapa, , marcadores, rutas)
        Dim urlMapa As New Uri(direccionURL)

    End Sub

    Function cadenasDatagrid(ByVal numeroFila As Integer)
        Dim cadena As String
        cadena = "color:" & DataGridView1.Item(2, numeroFila).Value.ToString
        Select Case DataGridView1.Item(1, numeroFila).Value.ToString
            Case 0
                cadena = cadena & "|size:small"
            Case 1
                cadena = cadena & "|size:tiny"
            Case 2
                cadena = cadena & "|size:mid"
            Case 3
                cadena = cadena
        End Select
        cadena = cadena & "|label:" & DataGridView1.Item(3, numeroFila).Value.ToString
        Dim direccion As String = DataGridView1.Item(0, numeroFila).Value.ToString.Replace(" ", "+")
        cadena = cadena & "|" & direccion
        Return cadena
    End Function



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtruta.Text <> "" Then
            Dim color As Color = Button5.BackColor
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            DataGridView2.Rows.Add(txtruta.Text, NumericUpDown4.Value, "0x" & hexa)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Color botón ruta
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button5.BackColor = colorS
        End If
    End Sub


    Function cadenasDatagridRuta()
        Dim cadena As String
        cadena = "color:" & DataGridView2.Item(2, 1).Value.ToString
        cadena = cadena & "|weight:" & DataGridView2.Item(1, 1).Value.ToString
        For i = 0 To DataGridView2.Rows.Count - 2
            Dim direccion As String = DataGridView2.Item(0, i).Value.ToString.Replace(" ", "+")
            cadena = cadena & "|" & direccion
        Next

        Return cadena
    End Function


End Class