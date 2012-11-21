Public Class InformarError

    Private Sub InformarError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim urlE As New Uri("https://docs.google.com/spreadsheet/viewform?formkey=dGVDN1BwaFA3YTVsNUVzc2FTd3FaR2c6MQ")
        WebBrowser1.Url = urlE
    End Sub

    Private Sub CopiarLOGAPortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarLOGAPortapapelesToolStripMenuItem.Click
        Try
            Dim aspectoForm As New AspectoFormulario
            'Creamos un archivo temporal con el LOG en xml
            aspectoForm.crearLOG("ArchivoPortapapeles.xml")
            Dim LOGtexto As String
            'Guardamos el archivo y lo leemos
            Dim sr As New System.IO.StreamReader("ArchivoPortapapeles.xml")
            LOGtexto = sr.ReadToEnd()
            sr.Close()
            'Lo copiamos en el portapapeles
            My.Computer.Clipboard.SetText(LOGtexto, TextDataFormat.Text)
            'Borramos el archivo temporal
            Kill("ArchivoPortapapeles.xml")
        Catch
            MessageBox.Show("Algo ha ocurrido, es posible que el LOG no se haya podido copiar en el portapapeles." & vbCrLf & "Recuerde, también puede ir a la ventana de peticiones HTTP y exportarlo como XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class