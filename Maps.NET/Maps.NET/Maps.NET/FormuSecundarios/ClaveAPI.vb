Public Class ClaveAPI
    Dim maps As New MapsNet
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click

        maps.ClaveMaps = TextBox1.Text
        MessageBox.Show("Clave guardada", "Maps.NET", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClaveAPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If maps.ClaveMaps <> Nothing Then
            TextBox1.Text = maps.ClaveMaps
        End If
    End Sub
End Class