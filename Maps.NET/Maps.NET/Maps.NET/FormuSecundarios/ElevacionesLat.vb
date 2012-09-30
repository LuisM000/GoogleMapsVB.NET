﻿Public Class ElevacionesLat

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            txtlongitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            txtlatitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            Dim region = "es" 'Region de búsqueda
            Dim direccionString As ArrayList
            Try
                direccionString = objetoMaps.CodificacionGeograficaInversa(txtlatitud.Text, txtlongitud.Text, region) 'Recibimos datos
                txtdirEnc.Text = direccionString(0)
            Catch
                txtdirEnc.Text = "Dirección no encontrada"
            End Try

            Try
                Dim coordenadas As New ArrayList
                coordenadas.Add(txtlatitud.Text)
                coordenadas.Add(txtlongitud.Text)
                Dim datosElevacion = objetoMaps.Elevacion(coordenadas)
                DataGridView1.Rows.Add(txtlatitud.Text, txtlongitud.Text, txtdirEnc.Text, FormatNumber(datosElevacion(0), 3) & " metros", resolucion(0))
            Catch
            End Try
        Else
            If aspectoFormu.verificarnumeros(txtlatitud.Text) = False Then txtlatitud.ForeColor = Color.Red
            If aspectoFormu.verificarnumeros(txtlongitud.Text) = False Then txtlongitud.ForeColor = Color.Red
        End If
    End Sub
End Class