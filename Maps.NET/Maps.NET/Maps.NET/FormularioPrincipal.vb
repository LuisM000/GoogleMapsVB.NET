Public Class FormularioPrincipal

    Dim aspectoFormu As New AspectoFormulario 'Variable para manejar aspecto formulario

    Private Sub FormularioPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        aspectoFormu.guardarLOG()
        aspectoFormu.GuardarAutocompletarXML()

    End Sub
 
    
    
    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aspectoFormu.TabControlYpanel() 'Ajustamos el tabcontrol
        aspectoFormu.abrirEspaña(aspectoFormu.NavegadorActual(Me.TabControl1.SelectedIndex))
        aspectoFormu.cargarAutocompletado() 'Cargamos los datos del autocompletado en el arraylist
        aspectoFormu.precargaAutocompletar() 'Precargamos el autocompletar
        If My.Settings.CuadroHerramientas = True Then 'Activamos/desactivamos cuadro de herramientas
            ToolStrip1.Visible = True
            CuadroDeHerramientasToolStripMenuItem.Checked = True
        Else
            ToolStrip1.Visible = False
            CuadroDeHerramientasToolStripMenuItem.Checked = False
        End If
    End Sub


    Private Sub VerURLActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerURLActualToolStripMenuItem.Click
        Try
            Dim frm As New Dialog1(aspectoFormu.URLactual().ToString)
            frm.Show()
        Catch
        End Try
    End Sub

    Private Sub NuevaPestañaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaPestañaToolStripMenuItem1.Click
        aspectoFormu.NuevaFicha() 'Abrimos nueva pestaña
    End Sub

    Private Sub BorrarPestañaActivarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrarPestañaActivarToolStripMenuItem1.Click
        aspectoFormu.CerrarFicha(TabControl1.SelectedTab) 'Cerramos pestaña actual

    End Sub


    Private Sub CerrarTodasLasPestañasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasLasPestañasToolStripMenuItem.Click
        aspectoFormu.CerrarTodasFicha() 'Cerramos todas las fichas
    End Sub

    Private Sub SiguientePestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiguientePestañaToolStripMenuItem.Click
        aspectoFormu.SiguienteFicha(TabControl1.SelectedTab) 'Siguiente pestaña
    End Sub
    Private Sub AnteriorPestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnteriorPestañaToolStripMenuItem.Click
        aspectoFormu.AnteriorFicha(TabControl1.SelectedTab) 'Anterior pestaña
    End Sub

    'Abrimos/cerramos cuadro de herramientas
    Private Sub CuadroDeHerramientasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadroDeHerramientasToolStripMenuItem.Click
        If ToolStrip1.Visible = True Then
            ToolStrip1.Visible = False
            CuadroDeHerramientasToolStripMenuItem.Checked = False
        Else
            ToolStrip1.Visible = True
            CuadroDeHerramientasToolStripMenuItem.Checked = True
        End If
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

    Private Sub CódigoPostalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CódigoPostalToolStripMenuItem.Click
        CodigoPostal.Show()
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

    Private Sub StreetViewPorDirecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StreetViewPorDirecciónToolStripMenuItem.Click
        StreetViewDIr.Show()
    End Sub

    Private Sub StreetViewPorLatitudlongitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StreetViewPorLatitudlongitudToolStripMenuItem.Click
        StreetViewlat.Show()
    End Sub

   
    Private Sub GeneradorBásicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneradorBásicoToolStripMenuItem.Click
        MapasSencillos.Show()
    End Sub

    Private Sub GeneradorCompletoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneradorCompletoToolStripMenuItem.Click
        MapasCompleto.Show()
    End Sub

    'Cuadro acerca de
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    'Formulario feedbacl
    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        Formulario.Show()
    End Sub

    ''***ACCESOS RÁPIDOS DESDE BARRA HERRAMIENTAS****'''

    'Abrir pestaña
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        NuevaPestañaToolStripMenuItem1_Click(sender, e)
    End Sub

    'Cerrar pestaña
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        BorrarPestañaActivarToolStripMenuItem1_Click(sender, e)
    End Sub

    'Buscar dirección
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        DirecciónToolStripMenuItem_Click(sender, e)
    End Sub

    'Buscar locañ
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ToolStripMenuItem1_Click(sender, e)
    End Sub

    'Calcular ruta
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        CalcularRutaToolStripMenuItem_Click(sender, e)
    End Sub

    'Generador mapa
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        GeneradorCompletoToolStripMenuItem_Click(sender, e)
    End Sub

    'Peticiones HTTP
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        SeguimientoPeticionesHTTPToolStripMenuItem_Click(sender, e)
    End Sub

    'Abrimos/cerramos cuadro de herramientas
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        CuadroDeHerramientasToolStripMenuItem_Click(sender, e)
    End Sub
 
    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click
        Opciones.Show()
    End Sub

    Private Sub InformarDeUnErrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformarDeUnErrorToolStripMenuItem.Click
        InformarError.Show()
    End Sub


    Private Sub SadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SadaToolStripMenuItem.Click
        InfoPC.Show()
    End Sub

   
End Class
