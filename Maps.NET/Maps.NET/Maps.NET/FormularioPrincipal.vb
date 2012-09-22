Public Class FormularioPrincipal

    Dim aspectoFormu As New AspectoFormulario 'Variable para manejar aspecto formulario

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aspectoFormu.TabControlYpanel() 'Ajustamos el tabcontrol
    End Sub

    Private Sub NuevaPestañaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaPestañaToolStripMenuItem1.Click
        aspectoFormu.NuevaFicha() 'Ajustamos el tabcontrol
    End Sub

    Private Sub BorrarPestañaActivarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrarPestañaActivarToolStripMenuItem1.Click
        aspectoFormu.CerrarFicha(TabControl1.SelectedTab) 'Ajustamos el tabcontrol
    End Sub

    Private Sub DirecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirecciónToolStripMenuItem.Click
        Dirección.Show()
    End Sub

    Private Sub LatitudLongitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LatitudLongitudToolStripMenuItem.Click
        Latitud.Show()
    End Sub

    Private Sub ISPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISPToolStripMenuItem.Click
        ISP.Show()
    End Sub

    Private Sub DirectaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectaToolStripMenuItem.Click
        CodificacionGeo.Show()
    End Sub

    Private Sub InversaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversaToolStripMenuItem.Click
        CodifInversa.Show()
    End Sub

    Private Sub BuscarServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarServicioToolStripMenuItem.Click
        Dim maps As New MapsNet
        Dim local(0) As String
        local(0) = "food"


        Dim ss = maps.PlacesLatLong(42.5463315, -6.5908331, 2000, local, , )
    End Sub
End Class
