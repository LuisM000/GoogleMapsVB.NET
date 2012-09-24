Public Class ISP

    Private Sub ISP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objetoMaps As New MapsNet
        Dim datos = objetoMaps.localizarIp()
        'Rellenamos los datos con lo que nos devuelve el método
        txtpais.Text = datos(0)
        txtpoblacion.Text = datos(1)
        txtregion.Text = datos(2)
        txtlatitud.Text = datos(3)
        txtlongitud.Text = datos(4)
        txtIP.Text = datos(5)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            txtlongitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            txtlatitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            Dim direccionString = objetoMaps.ObtenerURLdesdelatlong(txtlatitud.Text, txtlongitud.Text) 'String con la direccion
            Dim direccion As New Uri(direccionString) 'Pasamos el string a URI
            If CheckBox1.Checked = True Then 'Decidimos si lo abrimos en pestaña activa o nueva pestaña
                aspectoFormu.NuevaFicha("ISP") 'Abrimos una nueva pestaña
            End If
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = direccion
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim objetoMaps As New MapsNet
        Dim aspectoFormu As New AspectoFormulario
        If aspectoFormu.verificarnumeros(txtlatitud.Text) And aspectoFormu.verificarnumeros(txtlongitud.Text) Then 'Verificamos que sean numeros
            txtlongitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            txtlatitud.ForeColor = Color.Black 'Pintamos de negro el dato correcto
            Dim direccionString = objetoMaps.ObtenerURLdesdelatlong(txtlatitud.Text, txtlongitud.Text) 'String con la direccion
            Dim direccion As New Uri(direccionString) 'Pasamos el string a URI
            'Este código sirve para seleccionar el navegador de la pestaña activa

            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = direccion
        Else
            txtlatitud.ReadOnly = False : txtlongitud.ReadOnly = False
            If aspectoFormu.verificarnumeros(txtlatitud.Text) = False Then txtlatitud.ForeColor = Color.Red 'Pintamos si el datos es erróneo
            If aspectoFormu.verificarnumeros(txtlongitud.Text) = False Then txtlongitud.ForeColor = Color.Red 'Pintamos si el datos es erróneo
        End If
    End Sub
End Class