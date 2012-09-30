Public Class FormularioPrincipal

    Dim aspectoFormu As New AspectoFormulario 'Variable para manejar aspecto formulario

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aspectoFormu.TabControlYpanel() 'Ajustamos el tabcontrol
        aspectoFormu.abrirEspaña(aspectoFormu.NavegadorActual(Me.TabControl1.SelectedIndex))
    End Sub

    Private Sub VerURLActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerURLActualToolStripMenuItem.Click
        Try
            Dim frm As New Dialog1(aspectoFormu.URLactual().ToString)
            frm.Show()
        Catch
        End Try
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
        Places.Show()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        PlacesDir.Show()
    End Sub

   
    Private Sub CalcularRutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularRutaToolStripMenuItem.Click
        Rutas.Show()
    End Sub

    Private Sub ElevaciónPorDirecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElevaciónPorDirecciónToolStripMenuItem.Click
        ElevacionDir.Show()
    End Sub

    
    Private Sub SeguimientoPeticionesHTTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoPeticionesHTTPToolStripMenuItem.Click
        SeguimientoURL.Show()
    End Sub

    Private Sub ElevaciónPorLatitudlongitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElevaciónPorLatitudlongitudToolStripMenuItem.Click
        ElevacionesLat.Show()
    End Sub
End Class
