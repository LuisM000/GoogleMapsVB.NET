Public Class DatosLocal
    Dim referenciaM As String
    Dim nombreFor As String
    Sub New(ByVal nombreForm As String, ByVal referencia As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "Detalles de " & nombreForm 'Asignamos el nombre al formulario
        nombreFor = nombreForm
        referenciaM = referencia  'Mandamos referencia google maps
    End Sub

    Private Sub DatosLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objetoMaps As New MapsNet
        Dim datos = objetoMaps.DetallesLugar(referenciaM)
        txtnombre.Text = datos(0)
        txtdir1.Text = datos(1)
        txtphone.Text = datos(2)
        txtdir2.Text = datos(3)
        txtgoogle.Text = datos(4)
        txtrating.Text = datos(5)
        txtweb.Text = datos(7)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim aspectoFormu As New AspectoFormulario
            Dim nombreFicha As String
            nombreFicha = "Página google " & nombreFor
            aspectoFormu.NuevaFicha(nombreFicha) 'Abrimos una nueva pestaña
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = New Uri(txtgoogle.Text)
        Catch
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtweb.Text <> "Sin página web" Then
            Try
                Dim aspectoFormu As New AspectoFormulario
                Dim nombreFicha As String
                nombreFicha = "Website " & nombreFor
                aspectoFormu.NuevaFicha(nombreFicha) 'Abrimos una nueva pestaña
                'Este código sirve para seleccionar el navegador de la pestaña activa
                Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
                navegador.Url = New Uri(txtweb.Text)
            Catch
            End Try
        End If
    End Sub
End Class