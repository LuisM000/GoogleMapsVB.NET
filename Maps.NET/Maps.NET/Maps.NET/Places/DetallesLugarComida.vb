Public Class DetallesLugarComida
    Dim datos As New ArrayList
    Dim contador = 0
    Dim contadorUrl = 0
    Dim referenreferenciaM = "sin referencia"

    Sub New(ByVal referencia As String)  'Recibimos variables en el constructor
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        referenreferenciaM = referencia
    End Sub

    Private Sub DetallesLugarComida_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint 'Dibujamos línea
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Black, 2)
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = Me.CreateGraphics()
        formGraphics.DrawLine(myPen, 10, 60, Me.Size.Width - 28, 60)
        formGraphics.DrawLine(myPen, 10, 400, Me.Size.Width - 28, 400)
        myPen.Dispose()
        formGraphics.Dispose()
    End Sub
    Private Sub DetallesLugarComida_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Carga del formulario y rellenamos datos
        Dim maps As New MapsNet
        datos = maps.DetallesRestaurante(referenreferenciaM)
        Try
            Me.Text = datos(0)
            lblNombre.Text = datos(0)
            'Label1.Text = maps.UnixToTime(time(contador))
            Dim tiempo = maps.DiasRestantes(time(contador))
            If tiempo(0) > 1 Then
                If tiempo(1) = "días" Then
                    Label1.Text = "Hace " & tiempo(0) & " " & tiempo(1)
                Else
                    Label1.Text = "Hace más de " & tiempo(0) & " " & tiempo(1)
                End If
            Else
                Select Case tiempo(1)
                    Case "años"
                        Label1.Text = "Hace más de " & tiempo(0) & " " & "año"
                    Case "meses"
                        Label1.Text = "Hace más de " & tiempo(0) & " " & "mes"
                    Case "días"
                        Label1.Text = "Hace " & tiempo(0) & " " & "días"
                End Select
                Label1.Text = "Hace más de " & tiempo(0) & " " & tiempo(1)
            End If
                Label2.Text = autor(contador)
                If autor(contador) = "Un usuario de Google" Then
                    Label3.Text = "Sin página Google"
                Else
                    Label3.Text = URLautor(contadorUrl)
                End If
                Label4.Text = textoReview(contador)
        Catch
            contador = 0
            contadorUrl = 0
        End Try

        'Poner las puntuaciones
        Dim puntuacionTip = "Sin puntuaciones"
        Try
            Dim puntuacion = datos(5)
            If puntuacion >= 0 And puntuacion <= 2 Then
                PictureBox1.Image = My.Resources.medalla_de_bronce_blue
                puntuacionTip = "Puntuación: " & puntuacion & ". Mal valorado"

            ElseIf puntuacion > 2 And puntuacion <= 4 Then
                PictureBox1.Image = My.Resources.medalla_de_plata
                puntuacionTip = "Puntuación: " & puntuacion & ". Bien valorado"
            Else
                PictureBox1.Image = My.Resources.medalla_de_oro_blue
                puntuacionTip = "Puntuación: " & puntuacion & ". Excelente"
            End If
            ToolTip1.SetToolTip(PictureBox1, puntuacionTip)
        Catch
            PictureBox1.Image = My.Resources.cancel
            ToolTip1.SetToolTip(PictureBox1, puntuacionTip)
        End Try

    End Sub
   
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'Siguente resultado
        'Activamos timer para realizar los desplazamientos
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'Movemos panel a la izquierda
        If Panel2.Location.X > -700 Then
            Panel2.Location = New Size(Panel2.Location.X - 40, Panel2.Location.Y)
        Else
            Panel2.Location = New Size(1000, Panel2.Location.Y)
            Timer1.Enabled = False
            Timer2.Enabled = True
            actualizar()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'Movemos panel desde la izquierda
        If Panel2.Location.X > 20 Then
            Panel2.Location = New Size(Panel2.Location.X - 40, Panel2.Location.Y)
        Else
            Timer2.Enabled = False
        End If
    End Sub
    Sub actualizar()
        'Si eliminamos los timer, con poner esto en el button 1 es suficiente
        Dim maps As New MapsNet
        contador += 1
        contadorUrl += 1
        Try
            'Label1.Text = maps.UnixToTime(time(contador))
            Dim tiempo = maps.DiasRestantes(time(contador))
            If tiempo(0) > 1 Then
                If tiempo(1) = "días" Then
                    Label1.Text = "Hace " & tiempo(0) & " " & tiempo(1)
                Else
                    Label1.Text = "Hace más de " & tiempo(0) & " " & tiempo(1)
                End If
            Else
                Select Case tiempo(1)
                    Case "años"
                        Label1.Text = "Hace más de " & tiempo(0) & " " & "año"
                    Case "meses"
                        Label1.Text = "Hace más de " & tiempo(0) & " " & "mes"
                    Case "días"
                        Label1.Text = "Hace " & tiempo(0) & " " & "días"
                End Select
            End If

            Label2.Text = autor(contador)
            If autor(contador) = "Un usuario de Google" Then
                Label3.Text = "Sin página Google"
                contadorUrl -= 1
            Else
                Label3.Text = URLautor(contadorUrl)
            End If

            Label4.Text = textoReview(contador)
            Try 'Comprobamos si el siguiente resultado da error
                Dim aux = textoReview(contador + 1)
            Catch ex As Exception 'Si da error, pasamos al primer resultado y repetimos
                contador = -1 'Bajamos contador para que al entrar de nuevo sea 0 (se le suma 1 al inicio)
                contadorUrl = -1
                actualizar()
            End Try
        Catch
            'contador = -1 'Bajamos contador para que al entrar de nuevo sea 0 (se le suma 1 al inicio)
            'contadorUrl = -1

        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click 'Mas/menos detalles
        Try
            If Label5.Text = "Más info [+]" Then
                Label5.Text = "Menos info [+]"
                'Rellenamos los cuadros de texto
                txtnombre.Text = datos(0)
                txtdir1.Text = datos(1)
                txtphone.Text = datos(2)
                txtdir2.Text = datos(3)
                txtgoogle.Text = datos(4)
                txtrating.Text = datos(5)
                txtweb.Text = datos(7)
                mostrarDetalles() 'Visualizamos el panel 2
                Timer3.Enabled = True
            Else
                Timer4.Enabled = True
            End If
        Catch
        End Try
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick 'Movemos las info del local
        Panel2.Visible = False 'El panel con la info review lo ponemos en false
        If Panel1.Location.X > 160 Then
            Panel1.Location = New Size(Panel1.Location.X - 40, Panel1.Location.Y)
        Else
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick 'Sacamos la info del local
        If Panel1.Location.X > -450 Then
            Panel1.Location = New Size(Panel1.Location.X - 40, Panel1.Location.Y)
        Else
            Panel1.Location = New Size(721, Panel1.Location.Y)
            menosDetalles() 'OCultamos panel info local
            Panel2.Visible = True 'Hacemos visible panel review
            Label5.Text = "Más info [+]"
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Sub mostrarDetalles()
        Panel1.Visible = True
    End Sub

    Sub menosDetalles()
        Panel1.Visible = False
    End Sub

    '***********ABRIR PÁGINA DESDE INFO LOCAL********************
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim aspectoFormu As New AspectoFormulario
            Dim nombreFicha As String
            nombreFicha = "Página Google " & Me.Text
            aspectoFormu.NuevaFicha(nombreFicha) 'Abrimos una nueva pestaña
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = New Uri(txtgoogle.Text)
        Catch
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtweb.Text <> "Sin página web" Then
            Try
                Dim aspectoFormu As New AspectoFormulario
                Dim nombreFicha As String
                nombreFicha = "Website " & Me.Text
                aspectoFormu.NuevaFicha(nombreFicha) 'Abrimos una nueva pestaña
                'Este código sirve para seleccionar el navegador de la pestaña activa
                Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
                navegador.Url = New Uri(txtweb.Text)
            Catch
            End Try
        End If
    End Sub
    '************************************************************************************************************¡


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            Dim aspectoFormu As New AspectoFormulario
            Dim nombreFicha As String
            nombreFicha = "Página Google de " & Label2.Text
            aspectoFormu.NuevaFicha(nombreFicha) 'Abrimos una nueva pestaña
            'Este código sirve para seleccionar el navegador de la pestaña activa
            Dim navegador = aspectoFormu.NavegadorActual(FormularioPrincipal.TabControl1.SelectedIndex)
            navegador.Url = New Uri(Label3.Text)
        Catch
        End Try
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Me.Cursor = Cursors.Hand
        Label3.ForeColor = Color.Blue
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Me.Cursor = Cursors.Default
        Label3.ForeColor = Color.Black
    End Sub
 
End Class