Imports System.IO
Imports System.Net
Public Class GoogleMaps

    Public Function ObtenerIp()
        Dim req As HttpWebRequest = WebRequest.Create("http://automation.whatismyip.com/n09230945.asp")
        Dim res As HttpWebResponse = req.GetResponse()
        Dim stream As Stream = res.GetResponseStream()
        Dim sr As StreamReader = New StreamReader(stream)
        Return (sr.ReadToEnd())
    End Function

    Public Sub borrarCampos()
        Form1.txtCalle.Text = ""
        Form1.txtCiudad.Text = ""
        Form1.txtcomunidad.Text = ""
        Form1.txtCP.Text = ""
        Form1.txtLat.Text = ""
        Form1.txtlong.Text = ""
        Form1.txtNumero.Text = ""
        Form1.txtPais.Text = ""
        Form1.txtprovincia.Text = ""

    End Sub
End Class
