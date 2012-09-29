Public Class SeguimientoURL

    Private Sub SeguimientoURL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Focus()
        Panel1.Size = New Size(Me.Width - 20, Me.Height - 150)
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
            Dim paquetesPerdidos As Long = 0
            For i = 0 To URLseguimiento.Count - 1 Step 5
                DataGridView1.Rows.Add(URLseguimiento(i), URLseguimiento(i + 1), URLseguimiento(i + 2), URLseguimiento(i + 3), URLseguimiento(i + 4))
                If URLseguimiento(i + 2).ToString = "PERDIDO" Then
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Red
                    paquetesPerdidos += 1
                End If
            Next
            Dim peticiones As Long = CLng(URLseguimiento.Count / 5)
            txtpeticion.Text = peticiones
            txtperdidas.Text = paquetesPerdidos
            txtperdidasporc.Text = FormatNumber((paquetesPerdidos * 100) / peticiones, 2) & "%"
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