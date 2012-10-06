Public Class MostrarMapa
    Dim direcURL As String
    Dim tamañoFormulario(1) As Integer
    Sub New(ByVal direccion As String, ByVal tamaño() As Integer)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        direcURL = direccion
        tamañoFormulario(0) = tamaño(0)
        tamañoFormulario(1) = tamaño(1)
    End Sub
    Private Sub MostrarMapa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(tamañoFormulario(0) + 27, tamañoFormulario(1) + 54)
        WebBrowser1.ScrollBarsEnabled = False
        Dim URL As New Uri(direcURL)
        WebBrowser1.Url = URL
    End Sub
End Class