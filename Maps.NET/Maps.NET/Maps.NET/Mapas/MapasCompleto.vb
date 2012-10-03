Public Class MapasCompleto

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

    Function cadenasVisible(ByVal mumeroFila As Integer)
        Dim cadena As String
        cadena = DataGridView3.Item(0, mumeroFila).Value & "|"
        Return cadena
    End Function

    Function cadenasDatagridRuta()
        Dim cadena As String
        cadena = "color:" & DataGridView2.Item(2, 1).Value.ToString
        cadena = cadena & "|weight:" & DataGridView2.Item(1, 1).Value.ToString

        If CheckBox1.Checked = True Then 'Cerramos la ruta
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", Button7.BackColor.R, Button7.BackColor.G, Button7.BackColor.B)
            cadena = cadena & "|fillcolor:" & "0x" & hexa
        End If

        For i = 0 To DataGridView2.Rows.Count - 2
            Dim direccion As String = DataGridView2.Item(0, i).Value.ToString.Replace(" ", "+")
            cadena = cadena & "|" & direccion
        Next

        If CheckBox2.Checked = True Then 'Añadimos marcadores
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", Button9.BackColor.R, Button9.BackColor.G, Button9.BackColor.B)
            cadena = cadena & "&markers=color:" & "0x" & hexa
            For i = 0 To DataGridView2.Rows.Count - 2
                Dim direccion As String = DataGridView2.Item(0, i).Value.ToString.Replace(" ", "+")
                cadena = cadena & "|" & direccion
            Next
        End If

        Return cadena
    End Function




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Añadir marcador a datagridview
        If txtmarcador.Text <> "" Then
            Dim mapas As New MapsNet
            If ComboBox3.SelectedIndex = -1 Then ComboBox3.SelectedIndex = 3 'Si no hay seleccionado tamaño
            Dim direccionAux As New ArrayList
            direccionAux = mapas.CodificacionGeografica(txtmarcador.Text)
            txtmarcadorENC.Text = direccionAux(2)
            Dim color As Color = Button1.BackColor
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            DataGridView1.Rows.Add(txtmarcadorENC.Text, ComboBox3.SelectedIndex, "0x" & hexa, txtlabel.Text)
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

        Dim visibles As New ArrayList
        For i = 0 To DataGridView3.Rows.Count - 2
            visibles.Add(cadenasVisible(i))
        Next




        Dim maps As New MapsNet
        Dim direccionURL As String = maps.MapasEstaticosCompletos(direccion, zoom, size, tipoFormato, tipoMapa, , marcadores, rutas, visibles)
        Try
            Dim frm As New MostrarMapa(direccionURL)
            frm.Show()
        Catch
        End Try

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtruta.Text <> "" Then
            Dim mapas As New MapsNet
            Dim direccionAux As New ArrayList
            direccionAux = mapas.CodificacionGeografica(txtruta.Text)
            txtrutaEnc.Text = direccionAux(2)
            Dim color As Color = Button5.BackColor
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            DataGridView2.Rows.Add(txtrutaEnc.Text, NumericUpDown4.Value, "0x" & hexa)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Color botón ruta
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button5.BackColor = colorS
            Dim color As Color = Button5.BackColor
            Dim hexa As String = "0x" & String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            For i = 0 To DataGridView2.Rows.Count - 2
                DataGridView2.Item(2, i).Value = hexa


            Next
        End If
    End Sub




    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label10.Enabled = True
            Button7.Enabled = True
        Else
            Label10.Enabled = False
            Button7.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button7.BackColor = colorS
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label15.Enabled = True
            Button9.Enabled = True
        Else
            Label15.Enabled = False
            Button9.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button9.BackColor = colorS
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        For i = 0 To DataGridView2.Rows.Count - 2
            DataGridView2.Item(1, i).Value = NumericUpDown4.Value
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If txtvisible.Text <> "" Then
            Dim mapas As New MapsNet
            Dim direccionAux As New ArrayList
            direccionAux = mapas.CodificacionGeografica(txtvisible.Text)
            txtvisibleENC.Text = direccionAux(2)
            DataGridView3.Rows.Add(txtvisibleENC.Text)
        End If
    End Sub

End Class