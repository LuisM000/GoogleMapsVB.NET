Imports System.Xml
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objetoMaps As New GoogleMaps
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLDireccionMaps(txtCalle.Text, txtNumero.Text, txtCP.Text, txtCiudad.Text, txtprovincia.Text, txtcomunidad.Text, txtPais.Text)
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objetoMaps As New GoogleMaps
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLlatlongMaps(CDbl(txtLat.Text), CDbl(txtlong.Text))
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtCiudad.ReadOnly = False
        txtIP.ReadOnly = False
        txtLat.ReadOnly = False
        txtlong.ReadOnly = False
        txtcomunidad.ReadOnly = False
        txtPais.ReadOnly = False
        txtCalle.ReadOnly = True
        txtCP.ReadOnly = True
        txtNumero.ReadOnly = True
        txtprovincia.ReadOnly = True
        Dim objetoMaps As New GoogleMaps
        Dim ip As String = objetoMaps.ObtenerIp()
        txtIP.Text = ip
        Dim DatosRetorno(4) As String
        DatosRetorno=objetoMaps.localizarIp(ip)
        objetoMaps.borrarCampos()
        txtPais.Text = DatosRetorno(0)
        txtCiudad.Text = DatosRetorno(1)
        txtcomunidad.Text = DatosRetorno(2)
        txtLat.Text = DatosRetorno(3)
        txtlong.Text = DatosRetorno(4)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim calle, poblacion, provincia, comunidad, pais As String
        calle = "calle " + txtCalle.Text
        poblacion = txtCiudad.Text
        provincia = txtprovincia.Text
        comunidad = txtcomunidad.Text
        pais = txtPais.Text
        Dim objetoMaps As New GoogleMaps
        Dim latlong(1) As Double
        latlong = objetoMaps.ObternetLatLong(calle, poblacion, provincia, comunidad, pais)
        Dim direccionAux As String
        direccionAux = objetoMaps.ObtenerURLlatlongMaps(latlong(0), latlong(1))
        Dim direccion As New Uri(direccionAux)
        WebBrowser1.Url = direccion

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        txtIP.ReadOnly = True
        txtLat.ReadOnly = True
        txtlong.ReadOnly = True
        txtIP.Text = ""
        txtLat.Text = ""
        txtlong.Text = ""
        txtCalle.ReadOnly = False
        txtCiudad.ReadOnly = False
        txtcomunidad.ReadOnly = False
        txtCP.ReadOnly = False
        txtNumero.ReadOnly = False
        txtprovincia.ReadOnly = False
        txtPais.ReadOnly = False
        Label1.ForeColor = Color.Blue
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        txtLat.ReadOnly = False
        txtlong.ReadOnly = False
        txtIP.ReadOnly = True
        txtCalle.ReadOnly = True
        txtCiudad.ReadOnly = True
        txtcomunidad.ReadOnly = True
        txtCP.ReadOnly = True
        txtNumero.ReadOnly = True
        txtprovincia.ReadOnly = True
        txtPais.ReadOnly = True

        txtIP.Text = ""
        txtCalle.Text = ""
        txtCiudad.Text = ""
        txtcomunidad.Text = ""
        txtCP.Text = ""
        txtNumero.Text = ""
        txtprovincia.Text = ""
        txtPais.Text = ""
        Label2.ForeColor = Color.Blue
        Label1.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
End Class
