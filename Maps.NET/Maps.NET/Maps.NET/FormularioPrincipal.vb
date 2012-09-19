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
End Class
