Public Class AspectoFormulario


    Sub TabControlYpanel() 'Ajustamos el tabcontrol al panel
        FormularioPrincipal.TabControl1.Dock = DockStyle.Fill
        FormularioPrincipal.TabControl1.Padding = New Size(10, 7)
    End Sub

    Sub NuevaFicha(Optional ByVal nombreficha As String = "") 'Creamos nueva ficha
        Dim contador = FormularioPrincipal.TabControl1.TabCount
        Dim nombre = "Maps" & contador + 1
        If nombreficha <> "" Then
            nombre = nombreficha
        End If
        FormularioPrincipal.TabControl1.TabPages.Add(nombre)
        FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(contador)
        Dim WebBrowser1 As New WebBrowser
        FormularioPrincipal.TabControl1.TabPages(contador).Controls.Add(WebBrowser1)
        abrirEspaña(WebBrowser1)
        WebBrowser1.Dock = DockStyle.Fill
    End Sub
    Sub CerrarFicha(ByVal PestañaActual As TabPage) 'Cerramos ficha
        Dim paginaActual = FormularioPrincipal.TabControl1.SelectedIndex
        If paginaActual > 0 Then
            FormularioPrincipal.TabControl1.TabPages.Remove(PestañaActual)
            Dim numeroPagina = FormularioPrincipal.TabControl1.TabPages.IndexOf(PestañaActual)
            paginaActual -= 1
            FormularioPrincipal.TabControl1.SelectedTab = FormularioPrincipal.TabControl1.TabPages(paginaActual)
        End If
    End Sub

    Sub abrirEspaña(ByVal browser As WebBrowser) 'Abrimos España en el Webbrowser
        browser.Url = New Uri("http://maps.google.es/maps?q=España&output=embed")
    End Sub

    Public Function NavegadorActual(ByVal pestañaActiva As Integer) 'Enviamos el WebBrowser de la pestaña activa
        Dim NavegadorActivo = FormularioPrincipal.TabControl1.TabPages(pestañaActiva).Controls()
        Dim navegador As WebBrowser
        navegador = NavegadorActivo(0)
        Return navegador
    End Function
End Class
