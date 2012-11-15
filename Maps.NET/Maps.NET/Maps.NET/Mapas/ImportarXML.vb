Public Class ImportarXML
    Dim aspectoform As New AspectoFormulario
    Private Sub ImportarXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listaDearchivos As New ArrayList
        'listamos los archivos xml del directorio(le enviamos el directorio actual)
        listaDearchivos = aspectoform.listaXML(System.IO.Directory.GetCurrentDirectory())

        ListBox1.Items.Clear() 'Borramos lo que había en el listbox

        For Each item In listaDearchivos
            If aspectoform.comprobarEstilo(System.IO.Directory.GetCurrentDirectory() & "\" & item) = True Then
                ListBox1.Items.Add(item)
            End If
        Next
    

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Le pasamos la ruta al formulario de mapas mediante variable global :(
        rutaArchivoimportar = System.IO.Directory.GetCurrentDirectory() & "\" & ListBox1.SelectedItem
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Borrar archivo
        Try
            Dim respuesta As DialogResult = MessageBox.Show("¿Realmente desea eliminar de forma permanente el archivo?", "Maps.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Select Case respuesta
                Case Windows.Forms.DialogResult.Yes 'Borramos el archivo
                    Dim ruta As String
                    ruta = System.IO.Directory.GetCurrentDirectory() & "\" & ListBox1.SelectedItem 'Seleccionamos la ruta del archivo a borrar
                    Kill(ruta)
                Case Windows.Forms.DialogResult.No
                    'No hacemos nada
            End Select
            'Recargamos el listbox
            ImportarXML_Load(sender, e)
        Catch
            MessageBox.Show("Algo ha fallado... inténtelo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Recargamos el listbox
            ImportarXML_Load(sender, e)
        End Try

    End Sub
End Class