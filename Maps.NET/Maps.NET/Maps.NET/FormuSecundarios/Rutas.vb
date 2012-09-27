

Public Class Rutas

    Private Sub Rutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mas As New MapsNet
        Dim hitos As New ArrayList
        hitos.Add("Toledo")
        hitos.Add("león")
        Dim ss = mas.Rutas("monasterio de carracedo, ponferrada", "madrid", 0, hitos, True, 0, , )
        For i = 0 To UBound(ss) - 1 Step 5
            RichTextBox1.Text = RichTextBox1.Text & ss(i) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 1) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 2) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 3) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 4) & "||| " & vbCrLf
        Next


       
        RichTextBox1.Text = mas.QuitarEtiqueta(RichTextBox1.Text)

    End Sub
    

   
End Class