Public Class TodosResultados
    Dim todosDatos As String()
    Sub New(ByVal datos As String())
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ReDim todosDatos(datos.Count - 1)
        todosDatos = datos
    End Sub

    Private Sub TodosResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Resultados"
        For i = 0 To todosDatos.Count - 1 Step 6 'Rellenamos el richbox y el comboBox
            RichTextBox1.Text += "Nombre: " & todosDatos(i) & vbCrLf
            ComboBox1.Items.Add(todosDatos(i))
            RichTextBox1.Text += "Dirección: " & todosDatos(i + 1) & vbCrLf
            RichTextBox1.Text += "Latitud: " & todosDatos(i + 2) & vbCrLf
            RichTextBox1.Text += "Longitud: " & todosDatos(i + 3) & vbCrLf & vbCrLf
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datos = ((ComboBox1.SelectedIndex + 1) * 5) + ComboBox1.SelectedIndex
        Try
            Dim frm As New DatosLocal(ComboBox1.SelectedItem, todosDatos(datos))
            frm.Show()
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
Poner en negrita y mejorar cosas del richbox
    Quitar datos de los recuadros lati y longt
    comprobar que el tabindex de todosresultados y masInformacion es correcto
    añadir la opción de poner la callle en vez de latu longi
End Class