Public Class SeguimientoURL

    Private Sub SeguimientoURL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Size = New Size(Me.Width - 20, Me.Height - 130)
        Panel1.Location = New Size(Me.Location.X + 10, Me.Location.Y + 86)
        DataGridView1.Rows.Clear()
        'Aspecto del DataGridView
        With DataGridView1
            .BorderStyle = BorderStyle.Fixed3D
            .CellBorderStyle = DataGridViewCellBorderStyle.Sunken
            .RowHeadersBorderStyle = _
                DataGridViewHeaderBorderStyle.Raised
            .ColumnHeadersBorderStyle = _
                DataGridViewHeaderBorderStyle.Raised
            .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Inset
        End With

        Try
            For i = 0 To URLseguimiento.Count - 1 Step 3
                DataGridView1.Rows.Add(URLseguimiento(i + 1), URLseguimiento(i + 2), URLseguimiento(i))
            Next
            Dim peticiones As Long = CLng(URLseguimiento.Count / 3)
            txtpeticion.Text = peticiones
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SeguimientoURL_Load(sender, e)
    End Sub

    Private Sub SeguimientoURL_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DataGridView1.Size = Panel1.Size
    End Sub
End Class