Public Class Opciones

    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Comprobamos si está activado/desactivada la función de guardar autocompletar al cerrar programa
        If My.Settings.SettingAutocompletar = True Then CheckBox1.Checked = True Else CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Guardamos si está activado/desactivada la función de guardar autocompletar al cerrar programa
        If CheckBox1.Checked = True Then
            My.Settings.SettingAutocompletar = True
        Else
            My.Settings.SettingAutocompletar = False
        End If

        Me.Close()
    End Sub

  

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim aspectoFOrm As New AspectoFormulario
        If CheckBox2.Checked = True Then 'Borramos el historial autocompletado
            Dim resultado = MessageBox.Show("¿Está seguro de borrar todo el contenido de autocompletado?." & vbCrLf & "Esta opción no se puede deshacer.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resultado = vbYes Then
                'Borramos el contenido de la sesión
                listaAutocompletar.Clear() 'Borramos el arraylist
                MySource.Clear()
                Try
                    Kill("Autocompletado.xml")
                    CheckBox2.Enabled = False
                Catch ex As Exception
                    CheckBox2.Checked = False
                End Try
            Else
                CheckBox2.Checked = False
            End If
        End If
    End Sub
End Class