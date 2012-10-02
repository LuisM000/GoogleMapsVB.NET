Public Class StreetViewRuta
    Dim datosRutaE
    Dim Direcciones As New ArrayList
    Dim direccionACtual As String
    Sub New(ByVal datosRuta() As String, ByVal coordOrignDestin As ArrayList)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        datosRutaE = datosRuta
        Direcciones = coordOrignDestin
        direccionACtual = CStr(Direcciones(0))
    End Sub


    Sub ponerContadores()
        Label1.Text = 90
        Label2.Text = 20
        Label3.Text = 0
        HScrollBar1.Value = CInt(Label1.Text)
        HScrollBar2.Value = CInt(Label2.Text)
        HScrollBar3.Value = CInt(Label3.Text)
    End Sub
    Private Sub StreetView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Modificacmos scrolls
        ponerContadores()
        '___________________________________

        txtdireccion.Text = "INICIO DE TRAYECTO. " & Direcciones(0) 'Completamos el cuadro de texto
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(500), (300)}
        PictureBox1.Image = mapas.StreetView(Direcciones(0), tamaño, 20) 'Asignamos la imagen al picture
        direccionACtual = Direcciones(0).ToString.Replace(" ", "+")   'Asignamos el valor a la variable global
        'Mostramos ruta completa
        Dim hitos As New ArrayList
        If statusRuta = "OK" Then
            Try
                Me.Text = "Ruta " & rutaID(0).ToString
                With DataGridView1
                    .BorderStyle = BorderStyle.Fixed3D
                    .CellBorderStyle = DataGridViewCellBorderStyle.Sunken
                    .RowHeadersBorderStyle = _
                        DataGridViewHeaderBorderStyle.Raised
                    .ColumnHeadersBorderStyle = _
                        DataGridViewHeaderBorderStyle.Raised
                    .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Inset
                End With
                Dim tiempoAcumulado As Double
                Dim contadorT = 0
                For i = 0 To UBound(datosRutaE) - 1 Step 5
                    DataGridView1.Rows.Add(datosRutaE(i + 2), datosRutaE(i + 3), mapas.QuitarEtiqueta(datosRutaE(i + 4)), datosRutaE(i), datosRutaE(i + 1))
                    tiempoAcumulado += CInt(TiempoSegundos(contadorT) / 60)
                    If tiempoAcumulado > 120 Then
                        dgvTiempo.DataGridView.Rows.Add("------------", "------------", "TÓMESE UN DESCANSO", "------------", "------------")
                        tiempoAcumulado = 0
                    End If
                    contadorT += 1
                Next
            Catch
            End Try
        End If

    End Sub

    Dim contador As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mapas As New MapsNet
        Try
            txtdireccion.Text = datosRutaE(contador) & "," & datosRutaE(contador + 1) & ". " & mapas.QuitarEtiqueta(datosRutaE(contador + 4))
            Dim tamaño() As Integer = {(500), (300)}
            Dim latlong() As Double = {datosRutaE(contador), datosRutaE(contador + 1)}
            PictureBox1.Image = mapas.StreetView(latlong, tamaño, 20)
            direccionACtual = latlong(0) & "," & latlong(1)  'Asignamos el valor a la variable global
            ponerContadores()
            contador += 5
        Catch
            txtdireccion.Text = "FIN DE TRAYECTO. " & Direcciones(1)
            Dim tamaño() As Integer = {(500), (400)}
            PictureBox1.Image = mapas.StreetView(Direcciones(1), tamaño)
            direccionACtual = Direcciones(1).ToString.Replace(" ", "+")   'Asignamos el valor a la variable global
            contador = 0
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mapas As New MapsNet
        Select Case contador
            Case 0
            Case 5 'VOlver al inicio
                txtdireccion.Text = "INICIO DE TRAYECTO. " & Direcciones(0) 'Completamos el cuadro de texto
                Dim tamaño() As Integer = {(500), (300)}
                PictureBox1.Image = mapas.StreetView(Direcciones(0), tamaño, 20) 'Asignamos la imagen al picture
                direccionACtual = Direcciones(0).ToString.Replace(" ", "+")   'Asignamos el valor a la variable global
                contador = 0
            Case Else
                contador -= 10
                txtdireccion.Text = datosRutaE(contador) & "," & datosRutaE(contador + 1) & ". " & mapas.QuitarEtiqueta(datosRutaE(contador + 4))
                Dim tamaño() As Integer = {(500), (300)}
                Dim latlong() As Double = {datosRutaE(contador), datosRutaE(contador + 1)}
                PictureBox1.Image = mapas.StreetView(latlong, tamaño, 20)
                direccionACtual = latlong(0) & "," & latlong(1)  'Asignamos el valor a la variable global
                ponerContadores()
                contador += 5
        End Select

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador = 0
        txtdireccion.Text = "INICIO DE TRAYECTO. " & Direcciones(0)
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(500), (300)}
        PictureBox1.Image = mapas.StreetView(Direcciones(0), tamaño, 20)
        direccionACtual = Direcciones(0).ToString.Replace(" ", "+")   'Asignamos el valor a la variable global
        ponerContadores()
    End Sub

    'Configuramos los scrolls


    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.Text = HScrollBar1.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(500), (300)}
        PictureBox1.Image = mapas.StreetView(direccionACtual, tamaño, HScrollBar2.Value, HScrollBar3.Value, HScrollBar1.Value)
    End Sub


    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label2.Text = HScrollBar2.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(500), (300)}
        PictureBox1.Image = mapas.StreetView(direccionACtual, tamaño, HScrollBar2.Value, HScrollBar3.Value, HScrollBar1.Value)
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Label3.Text = HScrollBar3.Value
        Dim mapas As New MapsNet
        Dim tamaño() As Integer = {(500), (300)}
        PictureBox1.Image = mapas.StreetView(direccionACtual, tamaño, HScrollBar2.Value, HScrollBar3.Value, HScrollBar1.Value)
    End Sub










    'MOSTRAR OCULTAR RUTA
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If Label9.Text = "Mostrar tabla con ruta" Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter
        Me.Cursor = Cursors.Hand
        Label9.ForeColor = Color.Blue
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Me.Cursor = Cursors.Default
        Label9.ForeColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Height < 680 Then
            Me.Height = Me.Height + 10
            Me.Location = New Size(Me.Location.X, Me.Location.Y - 1)
        Else
            Label9.Text = "Ocultar tabla con ruta"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Height > 419 Then
            Me.Height = Me.Height - 10
            Me.Location = New Size(Me.Location.X, Me.Location.Y + 1)
        Else
            Label9.Text = "Mostrar tabla con ruta"
            Timer2.Enabled = False
        End If
    End Sub


End Class