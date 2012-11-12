Public Class Formulario

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uriF As New Uri("https://docs.google.com/spreadsheet/embeddedform?formkey=dDVDanVZaUV1ZWZOMi1NUkNKR0l1RlE6MQ")
        WebBrowser1.Url = uriF
    End Sub

    'Para cerrar la ventana automáticamente
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If WebBrowser1.Url IsNot Nothing Then
            If WebBrowser1.Url.ToString.Contains("theme") = True Then
                Me.Close()
            End If
        End If
    End Sub
End Class