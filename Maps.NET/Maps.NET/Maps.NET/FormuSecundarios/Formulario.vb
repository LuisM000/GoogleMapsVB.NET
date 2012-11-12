Public Class Formulario

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uriF As New Uri("https://docs.google.com/spreadsheet/embeddedform?formkey=dDVDanVZaUV1ZWZOMi1NUkNKR0l1RlE6MQ")
        WebBrowser1.Url = uriF
    End Sub
End Class