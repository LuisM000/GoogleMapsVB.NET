Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.RichTextBox1.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        Dim aspectoFormu As New AspectoFormulario
        aspectoFormu.NuevaFicha("Acerca de") 'Abrimos una nueva pestaña
        'Este código sirve para seleccionar el navegador de la pestaña activa
        Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
        Dim direccion As New Uri(e.LinkText.ToString)
        navegador.Url = direccion
    End Sub
End Class
