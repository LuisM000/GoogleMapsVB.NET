Public Class SeguimientoURL
    Sub Actualizar()
        'Try
        Dim paquetesPerdidos As Long = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(2, i).Value = "PERDIDO" Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                paquetesPerdidos += 1
            End If
        Next
        Dim peticiones = DataGridView1.Rows.Count
        txtpeticion.Text = peticiones
        txtperdidas.Text = paquetesPerdidos
        txtperdidasporc.Text = FormatNumber((paquetesPerdidos * 100) / peticiones, 2) & "%"
        'Catch e As Exception
        'End Try
    End Sub
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
            For i = 0 To URLseguimiento.Count - 1 Step 6
                DataGridView1.Rows.Add(URLseguimiento(i), URLseguimiento(i + 1), URLseguimiento(i + 2), URLseguimiento(i + 3), URLseguimiento(i + 4), URLseguimiento(i + 5))
                If URLseguimiento(i + 2).ToString = "PERDIDO" Then
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Red
                    paquetesPerdidos += 1
                End If
            Next
            Dim peticiones As Long = CLng(URLseguimiento.Count / 6)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Con esto hacemos que si el usuario lo pulsa dos veces, no se dupliquen
        DataGridView1.Rows.Clear()
        SeguimientoURL_Load(sender, e)
        Dim aspectoform As New AspectoFormulario
        aspectoform.rellenarGRidconXMLLOG(DataGridView1)
        Actualizar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim aspectoForm As New AspectoFormulario
        'Abrimos cuadro para guardar 
        Dim salvar As New SaveFileDialog
        With salvar
            .Filter = "Documento XML|*.xml"
            .FileName = "Registro"
            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                If salvar.FileName <> "" Then
                    Dim fs As System.IO.FileStream = CType(salvar.OpenFile(), System.IO.FileStream)
                    fs.Close()
                    aspectoForm.ExportarLOGaXML(DataGridView1, salvar.FileName)
                End If
            End If
        End With

    End Sub
End Class