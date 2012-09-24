Public Class Places

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            txtlongitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            txtlatitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            Dim TiposSeleccionados = recuperarTypes() 'Conseguimos arraylist con los tipos de establecimientos
            TiposSeleccionados = aspectoFormu.DevuelveEstablecimientosIngles(TiposSeleccionados)
            Dim datosPlaces = objetoMaps.PlacesLatLong(txtlatitud.Text, txtlongitud.Text, NumericUpDown1.Value, TiposSeleccionados, txtestablecimiento.Text, ) 'String con la direccion
            rellenarTXT(datosPlaces)

        Else
            If aspectoFormu.verificarnumeros(txtlatitud.Text) = False Then txtlatitud.ForeColor = Color.Red
            If aspectoFormu.verificarnumeros(txtlongitud.Text) = False Then txtlongitud.ForeColor = Color.Red
        End If
    End Sub

  

    Function recuperarTypes()
        Dim datos As New ArrayList()
        For Each item As Object In ListBox2.Items
            datos.Add(item.ToString())
        Next
        Return datos

    End Function


    Sub rellenarTXT(datos() As String)
        Dim aspectoFor As New AspectoFormulario
        txtplace1.Text = "Sin datos"
        txtplace2.Text = "Sin datos"
        txtplace4.Text = "Sin datos"
        pc1.Image = Nothing
        pc2.Image = Nothing
        pc3.Image = Nothing
        pc4.Image = Nothing
        Try
            txtplace1.Text = datos(0) & ". " & datos(1) & " (" & datos(2) & "," & datos(3) & ")"
            pc1.Image = aspectoFor.CargarImagenURL(datos(4))
        Catch
            txtplace1.Text = "Sin datos"
        End Try
        Try
            txtplace2.Text = datos(6) & ". " & datos(7) & " (" & datos(8) & "," & datos(9) & ")"
            pc2.Image = aspectoFor.CargarImagenURL(datos(10))
        Catch
            txtplace2.Text = "Sin datos"
            pc2.Image = aspectoFor.CargarImagenURL("error")
        End Try
        Try
            txtplace3.Text = datos(12) & ". " & datos(13) & " (" & datos(14) & "," & datos(15) & ")"
            pc3.Image = aspectoFor.CargarImagenURL(datos(16))
        Catch
            txtplace3.Text = "Sin datos"
            pc3.Image = aspectoFor.CargarImagenURL("error")
        End Try
        Try
            txtplace4.Text = datos(18) & ". " & datos(19) & " (" & datos(20) & "," & datos(21) & ")"
            pc4.Image = aspectoFor.CargarImagenURL(datos(22))
        Catch
            txtplace4.Text = "Sin datos"
            pc4.Image = aspectoFor.CargarImagenURL("error")
        End Try
    End Sub











    Private Sub txtlatitud_GotFocus(sender As Object, e As EventArgs) Handles txtlatitud.GotFocus
        txtlatitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlongitud_GotFocus(sender As Object, e As EventArgs) Handles txtlongitud.GotFocus
        txtlongitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlatitud_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlatitud.KeyDown
        txtlatitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub

    Private Sub txtlongitud_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlongitud.KeyDown
        txtlongitud.ForeColor = Color.Black 'Pintamos de negro para actualizar
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Añadimos los elemntos
        For Each elemento In ListBox1.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox3.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox4.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox5.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox6.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox7.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox8.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox9.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox10.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox11.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
        For Each elemento In ListBox12.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
     
        ListBox1.ClearSelected()
        ListBox3.ClearSelected()
        ListBox4.ClearSelected()
        ListBox5.ClearSelected()
        ListBox6.ClearSelected()
        ListBox7.ClearSelected()
        ListBox8.ClearSelected()
        ListBox9.ClearSelected()
        ListBox10.ClearSelected()
        ListBox11.ClearSelected()
        ListBox12.ClearSelected()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Quitamos elementos
        While ListBox2.SelectedIndex <> -1
            For Each elemento In ListBox2.SelectedIndices
                ListBox2.Items.RemoveAt(elemento)
            Next
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Borramos toda la selección
        ListBox2.Items.Clear()
        ListBox1.ClearSelected()
        ListBox3.ClearSelected()
        ListBox4.ClearSelected()
        ListBox5.ClearSelected()
        ListBox6.ClearSelected()
        ListBox7.ClearSelected()
        ListBox8.ClearSelected()
        ListBox9.ClearSelected()
        ListBox10.ClearSelected()
        ListBox11.ClearSelected()
        ListBox12.ClearSelected()
    End Sub
End Class