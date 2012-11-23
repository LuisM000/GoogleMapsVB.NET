Public Class InfoPC

    'Código para liberar RAM disponible en************************
    'http://gdev.wordpress.com/2005/11/30/liberar-memoria-con-vb-net/
    'Declaración de la API
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    'Funcion de liberacion de memoria
    Public Sub ClearMemory()

        Try
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch ex As Exception
            'Control de errores
        End Try
    End Sub



    Dim contadorTiempo As Long = 0
    Dim contadorTiempo2 As Long = 0
    Dim estado = 0
    Dim estado2 = 0
    Dim tiempo As Integer = 0
    Dim valorInferior As Integer
    Dim estadoMAX = 0
    Dim estado2MAX = 0
    Dim estadoMIN = 0
    Dim estado2MIN = 0

    Dim lapizActual, lapizMax, lapizMin As Pen

    Sub cargarInformacion()
        Dim Picture1 As Graphics = PictureBox1.CreateGraphics
        lblfisicatotal.Text = Math.Round(My.Computer.Info.TotalPhysicalMemory / Math.Pow(1024, 2), 2)
        lblfisicadisponible.Text = Math.Round(My.Computer.Info.AvailablePhysicalMemory / Math.Pow(1024, 2), 2)
        lblfisicaenuso.Text = Math.Round(lblfisicatotal.Text - lblfisicadisponible.Text, 2)
        lblvirtualtotal.Text = Math.Round(My.Computer.Info.TotalVirtualMemory / Math.Pow(1024, 2), 2)
        lblvirtualuso.Text = Math.Round(My.Computer.Info.AvailableVirtualMemory / Math.Pow(1024, 2), 2)
        lblvirtualdispo.Text = Math.Round(lblvirtualtotal.Text - lblvirtualuso.Text, 2)

        If lblfisicaenuso.Text > lblMaximo.Text Then lblMaximo.Text = lblfisicaenuso.Text
        If lblfisicaenuso.Text < lblMinimo.Text Then lblMinimo.Text = lblfisicaenuso.Text



        contadorTiempo = contadorTiempo2
        contadorTiempo2 += 1



        Dim coeficiente As Double = CDbl((PictureBox1.Height) / CDbl(lblfisicatotal.Text - valorInferior))

        'PARA EL VALOR ACTUAL
        estado2 = CInt(lblfisicaenuso.Text)
        If contadorTiempo > 560 Then
            Picture1.Clear(Color.Lavender)
            contadorTiempo = 0
            contadorTiempo2 = 0
        End If
        
        'ESTADO MÄXIMO
        estado2MAX = CInt(lblMaximo.Text)
        'Se resta 2 en y, y2 para corregir fallo de picturebox
        Dim yMAX = PictureBox1.Height - CInt((estadoMAX - valorInferior) * coeficiente) - 4
        Dim y2MAX = PictureBox1.Height - CInt((estado2MAX - valorInferior) * coeficiente) - 4
        Picture1.DrawLine(lapizMax, contadorTiempo, yMAX, contadorTiempo2, y2MAX)
        estadoMAX = estado2MAX

        'ESTADO MÏNIMO
        estado2MIN = CInt(lblMinimo.Text)
        'Se resta 2 en y, y2 para corregir fallo de picturebox
        Dim ymin = PictureBox1.Height - CInt((estadoMIN - valorInferior) * coeficiente) - 4
        Dim y2min = PictureBox1.Height - CInt((estado2MIN - valorInferior) * coeficiente) - 4
        Picture1.DrawLine(lapizMin, contadorTiempo, ymin, contadorTiempo2, y2min)
        estadoMIN = estado2MIN


        'ESTADO ACTUAL
        'Se resta 2 en y, y2 para corregir fallo de picturebox
        Dim y = PictureBox1.Height - CInt((estado - valorInferior) * coeficiente) - 4
        Dim y2 = PictureBox1.Height - CInt((estado2 - valorInferior) * coeficiente) - 4
        Picture1.DrawLine(lapizActual, contadorTiempo, y, contadorTiempo2, y2)
        estado = estado2



        tiempo += 1

    End Sub
    Private Sub InfoPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Actualizamos labels
        lblfisicatotal.Text = Math.Round(My.Computer.Info.TotalPhysicalMemory / Math.Pow(1024, 2), 2)
        lblfisicadisponible.Text = Math.Round(My.Computer.Info.AvailablePhysicalMemory / Math.Pow(1024, 2), 2)
        lblfisicaenuso.Text = Math.Round(lblfisicatotal.Text - lblfisicadisponible.Text, 2)
        lblvirtualtotal.Text = Math.Round(My.Computer.Info.TotalVirtualMemory / Math.Pow(1024, 2), 2)
        lblvirtualuso.Text = Math.Round(My.Computer.Info.AvailableVirtualMemory / Math.Pow(1024, 2), 2)
        lblvirtualdispo.Text = Math.Round(lblvirtualtotal.Text - lblvirtualuso.Text, 2)

        lblMaximo.Text = lblfisicaenuso.Text
        lblMinimo.Text = lblfisicaenuso.Text

        valorInferior = (lblfisicaenuso.Text) - 700
        grafiInferior.Text = valorInferior
        GrafSuperior.Text = CInt(lblfisicatotal.Text)

        estado = CInt(lblfisicaenuso.Text)
        estado2 = estado

        lapizActual = New Pen(Brushes.DodgerBlue, 1)
        lapizMax = New Pen(Brushes.Transparent, 1)
        lapizMin = New Pen(Brushes.Transparent, 1)

        cargarInformacion()
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cargarInformacion()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearMemory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aspectoFormu As New AspectoFormulario
        aspectoFormu.CerrarTodasFicha()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


  
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Desactivar" Then
            Button4.Text = "Activar"
            lapizMax = New Pen(Brushes.Transparent, 0)
        Else
            Button4.Text = "Desactivar"
            lapizMax = New Pen(Brushes.Red, 1)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "Desactivar" Then
            Button5.Text = "Activar"
            lapizActual = New Pen(Brushes.Transparent, 0)
        Else
            Button5.Text = "Desactivar"
            lapizActual = New Pen(Brushes.DodgerBlue, 1)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "Desactivar" Then
            Button6.Text = "Activar"
            lapizMin = New Pen(Brushes.Transparent, 0)
        Else
            Button6.Text = "Desactivar"
            lapizMin = New Pen(Brushes.Green, 1)
        End If
    End Sub
End Class