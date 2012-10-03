Public Class MostrarMapa
    Dim direcURL As String
    Sub New(ByVal direccion As String)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        direcURL = direccion
    End Sub
    Private Sub MostrarMapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim URL As New Uri(direcURL)
        WebBrowser1.Url = URL
    End Sub
End Class