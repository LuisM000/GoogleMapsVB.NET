Public Class MapasCompleto

    Function cadenasDatagrid(ByVal numeroFila As Integer)
        Dim cadena As String
        cadena = "color:" & DataGridView1.Item(2, numeroFila).Value.ToString
        Select Case DataGridView1.Item(1, numeroFila).Value.ToString
            Case 0
                cadena = cadena & "|size:small"
            Case 1
                cadena = cadena & "|size:tiny"
            Case 2
                cadena = cadena & "|size:mid"
            Case 3
                cadena = cadena
        End Select
        cadena = cadena & "|label:" & DataGridView1.Item(3, numeroFila).Value.ToString
        Dim direccion As String = DataGridView1.Item(0, numeroFila).Value.ToString.Replace(" ", "+")
        cadena = cadena & "|" & direccion
        Return cadena
    End Function

    Function cadenasVisible(ByVal mumeroFila As Integer)
        Dim cadena As String
        cadena = DataGridView3.Item(0, mumeroFila).Value & "|"
        Return cadena
    End Function

    Function cadenasDatagridRuta()
        Dim cadena As String
        cadena = "color:" & DataGridView2.Item(2, 1).Value.ToString
        cadena = cadena & "|weight:" & DataGridView2.Item(1, 1).Value.ToString

        If CheckBox1.Checked = True Then 'Cerramos la ruta
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", Button7.BackColor.R, Button7.BackColor.G, Button7.BackColor.B)
            cadena = cadena & "|fillcolor:" & "0x" & hexa
        End If

        For i = 0 To DataGridView2.Rows.Count - 2
            Dim direccion As String = DataGridView2.Item(0, i).Value.ToString.Replace(" ", "+")
            cadena = cadena & "|" & direccion
        Next

        If CheckBox2.Checked = True Then 'Añadimos marcadores
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", Button9.BackColor.R, Button9.BackColor.G, Button9.BackColor.B)
            cadena = cadena & "&markers=color:" & "0x" & hexa
            For i = 0 To DataGridView2.Rows.Count - 2
                Dim direccion As String = DataGridView2.Item(0, i).Value.ToString.Replace(" ", "+")
                cadena = cadena & "|" & direccion
            Next
        End If

        Return cadena
    End Function

    Function cadenasDatagridEstilos()
        Dim cadenaEst As String = ""

        For i = 0 To DataGridView4.Rows.Count - 2

            'Feature
            Dim feature As String = "feature:" & DataGridView4.Item(0, i).Value.ToString.Replace(vbTab, "").Replace(" ", "")
            cadenaEst = cadenaEst & "&style=" & feature & "|"

            'Element
            cadenaEst = cadenaEst & "element:" & DataGridView4.Item(1, i).Value.ToString & "|"

            'Color
            cadenaEst = cadenaEst & "hue:" & DataGridView4.Item(2, i).Value.ToString & "|"

            'Brillo
            cadenaEst = cadenaEst & "lightness:" & DataGridView4.Item(3, i).Value.ToString & "|"

            'Saturación
            cadenaEst = cadenaEst & "saturation:" & DataGridView4.Item(4, i).Value.ToString & "|"

            'Gamma
            cadenaEst = cadenaEst & "gamma:" & DataGridView4.Item(5, i).Value.ToString & "|"

            'Visibilidad
            cadenaEst = cadenaEst & "visibility:" & DataGridView4.Item(6, i).Value.ToString

        Next

        Return cadenaEst
    End Function

    


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Añadir marcador a datagridview
        If txtmarcador.Text <> "" Then
            Dim mapas As New MapsNet
            If ComboBox3.SelectedIndex = -1 Then ComboBox3.SelectedIndex = 3 'Si no hay seleccionado tamaño
            Dim direccionAux As New ArrayList
            direccionAux = mapas.CodificacionGeografica(txtmarcador.Text)
            txtmarcadorENC.Text = direccionAux(2)
            Dim color As Color = Button1.BackColor
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            DataGridView1.Rows.Add(txtmarcadorENC.Text, ComboBox3.SelectedIndex, "0x" & hexa, txtlabel.Text)
            txtmarcador.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Color del marcador
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button1.BackColor = colorS
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim direccion As String = txtdireccion.Text 'Variable direccion
        Dim zoom As Integer = NumericUpDown1.Value 'Variable zoom
        Dim size(1) As Integer 'Variable tamaño imagen
        size(0) = NumericUpDown2.Value
        size(1) = NumericUpDown3.Value
        Dim tipoMapa As Integer 'Tipo de mapa
        Select Case ComboBox1.SelectedIndex
            Case 0
                tipoMapa = 0
            Case 1
                tipoMapa = 1
            Case 2
                tipoMapa = 2
            Case 3
                tipoMapa = 3
        End Select
        Dim tipoFormato As Integer 'Tipo de formato
        Select Case ComboBox2.SelectedIndex
            Case 0
                tipoFormato = 0
            Case 1
                tipoFormato = 1
            Case 2
                tipoFormato = 2
            Case 3
                tipoFormato = 3
            Case 4
                tipoFormato = 4
        End Select

        Dim marcadores As New ArrayList
        For i = 0 To DataGridView1.Rows.Count - 2
            marcadores.Add(cadenasDatagrid(i))
        Next

        Dim rutas As New ArrayList
        If DataGridView2.Rows.Count - 2 > 0 Then
            rutas.Add(cadenasDatagridRuta())
        End If

        Dim visibles As New ArrayList
        For i = 0 To DataGridView3.Rows.Count - 2
            visibles.Add(cadenasVisible(i))
        Next


        Dim estilos As New ArrayList
        If DataGridView4.Rows.Count - 1 > 0 Then
            estilos.Add(cadenasDatagridEstilos())
        End If


        Dim maps As New MapsNet
        Dim direccionURL As String = maps.MapasEstaticosCompletos(direccion, zoom, size, tipoFormato, tipoMapa, , marcadores, rutas, visibles, estilos)
        Try
            Dim frm As New MostrarMapa(direccionURL, size)
            frm.Show()
        Catch
        End Try

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtruta.Text <> "" Then
            Dim mapas As New MapsNet
            Dim direccionAux As New ArrayList
            direccionAux = mapas.CodificacionGeografica(txtruta.Text)
            txtrutaEnc.Text = direccionAux(2)
            Dim color As Color = Button5.BackColor
            Dim hexa As String = String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            DataGridView2.Rows.Add(txtrutaEnc.Text, NumericUpDown4.Value, "0x" & hexa)
            txtruta.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Color botón ruta
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button5.BackColor = colorS
            Dim color As Color = Button5.BackColor
            Dim hexa As String = "0x" & String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
            For i = 0 To DataGridView2.Rows.Count - 2
                DataGridView2.Item(2, i).Value = hexa


            Next
        End If
    End Sub




    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label10.Enabled = True
            Button7.Enabled = True
        Else
            Label10.Enabled = False
            Button7.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button7.BackColor = colorS
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label15.Enabled = True
            Button9.Enabled = True
        Else
            Label15.Enabled = False
            Button9.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS = ColorDialog1.Color
            Button9.BackColor = colorS
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        For i = 0 To DataGridView2.Rows.Count - 2
            DataGridView2.Item(1, i).Value = NumericUpDown4.Value
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If txtvisible.Text <> "" Then
            Dim mapas As New MapsNet
            Dim direccionAux As New ArrayList
            direccionAux = mapas.CodificacionGeografica(txtvisible.Text)
            txtvisibleENC.Text = direccionAux(2)
            DataGridView3.Rows.Add(txtvisibleENC.Text)
            txtvisible.Text = ""
        End If
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        DataGridView3.Rows.Clear()
    End Sub



    '********PARTE DE DISEÑO***************************************************
  
    Private Sub MapasCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelAct = Panel1
        Panel1.Location = New Size(30, 94)
        limpiarColores(Label18)
        For Each c As Object In Me.Controls
            If (c.ToString = Label18.ToString Or c.ToString = Label20.ToString Or c.ToString = Label19.ToString Or c.ToString = Label21.ToString Or c.ToString = Label23.ToString) Then
                If c.GetType Is GetType(Label) Then
                    AddHandler DirectCast(c, Label).MouseEnter, AddressOf conFoco
                    AddHandler DirectCast(c, Label).MouseLeave, AddressOf sinFoco
                End If
            End If
        Next
        txtdireccion.Focus() : tabuladores() : txtdireccion.TabStop = True
    End Sub
    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub


    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MapasCompleto_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Black, 2)
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = Me.CreateGraphics()
        formGraphics.DrawLine(myPen, 10, 60, Me.Size.Width - 28, 60)
        formGraphics.DrawLine(myPen, 10, 300, Me.Size.Width - 28, 300)
        myPen.Dispose()
        formGraphics.Dispose()
    End Sub

    Dim panelAct As Panel
    Dim panelActSec As Panel
    Dim panelAct2 As Panel
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        If (Timer1.Enabled = False And Timer2.Enabled = False) Then 'Evita que se pulse dos veces y se colapsen los paneles
            If panelAct IsNot Panel1 Then
                txtdireccion.Focus()
                limpiarColores(Label18)
                Timer1.Enabled = True
                panelAct2 = Panel1
                tabuladores() : txtdireccion.TabStop = True
            End If
        End If
       
    End Sub
    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        If (Timer1.Enabled = False And Timer2.Enabled = False) Then
            If panelAct IsNot Panel2 Then
                txtmarcador.Focus()
                limpiarColores(Label19)
                Timer1.Enabled = True
                panelAct2 = Panel2
                tabuladores() : txtmarcador.TabStop = True : Button3.TabStop = True

            End If
        End If
    End Sub


    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        If (Timer1.Enabled = False And Timer2.Enabled = False) Then
            If panelAct IsNot Panel3 Then
                txtruta.Focus()
                limpiarColores(Label20)
                Timer1.Enabled = True
                panelAct2 = Panel3
                tabuladores() : txtruta.TabStop = True : Button4.TabStop = True
            End If
        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        If (Timer1.Enabled = False And Timer2.Enabled = False) Then
            If panelAct IsNot Panel4 Then
                txtvisible.Focus()
                limpiarColores(Label21)
                Timer1.Enabled = True
                panelAct2 = Panel4
                tabuladores() : txtvisible.TabStop = True : Button10.TabStop = True
            End If
        End If
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        If (Timer1.Enabled = False And Timer2.Enabled = False) Then
            If panelAct IsNot Panel5 Then
                'txtmarcador.Focus()
                limpiarColores(Label23)
                Timer1.Enabled = True
                panelAct2 = Panel5
                'tabuladores() : txtmarcador.TabStop = True : Button3.TabStop = True

            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If panelAct.Location.X > -1000 Then
            panelAct.Location = New Size(panelAct.Location.X - 50, panelAct.Location.Y)
        Else
            panelAct.Location = New Size(1000, panelAct.Location.Y)

            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

   
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If panelAct2.Location.X > 30 Then
            panelAct2.Location = New Size(panelAct2.Location.X - 50, panelAct2.Location.Y)
        Else
            panelAct = panelAct2
            Timer2.Enabled = False
        End If
    End Sub

    Sub limpiarColores(ByVal labelACtivo As Label)
        Label18.ForeColor = Color.Black
        Label19.ForeColor = Color.Black
        Label20.ForeColor = Color.Black
        Label21.ForeColor = Color.Black
        Label23.ForeColor = Color.Black
        labelACtivo.ForeColor = Color.Blue
    End Sub

    Sub tabuladores()
        For i = 0 To Panel1.Controls.Count - 1
            Panel1.Controls(i).TabStop = False
        Next
        For i = 0 To Panel2.Controls.Count - 1
            Panel2.Controls(i).TabStop = False
        Next
        For i = 0 To Panel3.Controls.Count - 1
            Panel3.Controls(i).TabStop = False
        Next
        For i = 0 To Panel4.Controls.Count - 1
            Panel4.Controls(i).TabStop = False
        Next
    End Sub

    Private Sub txtmarcador_GotFocus(sender As Object, e As EventArgs) Handles txtmarcador.GotFocus
        Me.AcceptButton = Button3
    End Sub

    Private Sub txtruta_GotFocus(sender As Object, e As EventArgs) Handles txtruta.GotFocus
        Me.AcceptButton = Button4
    End Sub

    Private Sub txtvisible_GotFocus(sender As Object, e As EventArgs) Handles txtvisible.GotFocus
        Me.AcceptButton = Button10
    End Sub

    Private Sub txtdireccion_GotFocus(sender As Object, e As EventArgs) Handles txtdireccion.GotFocus
           Me.AcceptButton = Button2
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'panel 1
        txtdireccion.Text = ""
        NumericUpDown3.Value = 650
        NumericUpDown2.Value = 650
        NumericUpDown1.Value = 14
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

        'panel2
        txtmarcador.Text = ""
        txtmarcadorENC.Text = ""
        ComboBox3.SelectedIndex = 3
        Button1.BackColor = Color.Black
        txtlabel.Text = ""
        Button6_Click_1(sender, e)

        'panel3
        txtruta.Text = ""
        txtrutaEnc.Text = ""
        NumericUpDown4.Value = 5
        Button5.BackColor = Color.Black
        Button7.BackColor = Color.Black
        Button9.BackColor = Color.Black
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        Button8_Click(sender, e)

        'panel4
        txtvisible.Text = ""
        txtvisibleENC.Text = ""
        Button12_Click(sender, e)

        'panel5
        ListBox2.Items.Clear()
        Button13_Click(sender, e)
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
        Button16.BackColor = Color.Black
        HScrollBar1.Value = 0
        HScrollBar2.Value = 0
        HScrollBar3.Value = 100
        lblBrillo.Text = 0
        lblSaturacion.Text = 0
        lblGamma.Text = 1
        Button17_Click(sender, e)
        CheckBox3.Checked = False
        Button16.Enabled = False
    End Sub

  
    'ESTILOS************************************

    'Añadir selección
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        For Each elemento In ListBox1.SelectedItems
            ListBox2.Items.Add(elemento)
        Next
    End Sub

    'Borrar elemento
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        While ListBox2.SelectedIndex <> -1
            For Each elemento In ListBox2.SelectedIndices
                ListBox2.Items.RemoveAt(elemento)
            Next
        End While
    End Sub

    'Borrar selección listbox
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ListBox1.ClearSelected()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim cuadroCOlor As New ColorDialog
        cuadroCOlor.FullOpen = True
        If cuadroCOlor.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim colorS2 = cuadroCOlor.Color
            Button16.BackColor = colorS2
        End If
    End Sub

    'Scroll del brillo
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        lblBrillo.Text = HScrollBar1.Value
    End Sub
    'Scroll del saturación
    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        lblSaturacion.Text = HScrollBar2.Value
    End Sub
    'Scroll del gamma
    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        lblGamma.Text = CDbl(HScrollBar3.Value / 100)
    End Sub

    'Restablecer scroll
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        HScrollBar1.Value = 0
        HScrollBar2.Value = 0
        HScrollBar3.Value = 100
        lblBrillo.Text = 0
        lblSaturacion.Text = 0
        lblGamma.Text = 1
    End Sub

    'Añadir elemento
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim ObjAspecto As New AspectoFormulario
        Dim elementos As String = ""
        Select Case ComboBox5.SelectedIndex
            Case 0
                elementos = "all"
            Case 1
                elementos = "geometry"
            Case 2
                elementos = "labels"
            Case Else
                elementos = "all"
        End Select

        Dim visibilidad As String = ""
        Select Case ComboBox4.SelectedIndex
            Case 0
                visibilidad = "on"
            Case 1
                visibilidad = "off"
            Case 2
                visibilidad = "simplified"
            Case Else
                visibilidad = "on"
        End Select

        Dim hexa As String = ""
        If CheckBox3.Checked = True Then 'Si se ha puesto un color en concreto
            Dim color As Color = Button16.BackColor
            hexa = "0x" & String.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)
        Else
            hexa = ""
        End If
        Dim recursos As String = ""
        For i = 0 To ListBox2.Items.Count - 1
            recursos = ListBox2.Items(i)
            DataGridView4.Rows.Add(ObjAspecto.traducirRecursos(recursos), elementos, hexa, lblBrillo.Text, lblSaturacion.Text, lblGamma.Text, visibilidad)
        Next


    End Sub

    'Limpiar registros
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        DataGridView4.Rows.Clear()
    End Sub

   

    'Habilitar color
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Button16.Enabled = True
        Else
            Button16.Enabled = False
        End If
    End Sub

    'ESTILOS PREDETERMINADOS
   
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Enabled = True Then
            CheckBox5.Enabled = False
            EstilosPredeterminados("caso1")
        End If
        If CheckBox4.Checked = False Then
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Enabled = True Then
            CheckBox4.Enabled = False
            EstilosPredeterminados("caso2")
        End If
        If CheckBox5.Checked = False Then
            CheckBox4.Enabled = True
        End If
    End Sub

    Sub EstilosPredeterminados(ByVal estilo As String)
        DataGridView4.Rows.Clear() 'Borramos los campos del datagridview
        Select Case estilo
            Case "caso1"
                DataGridView4.Rows.Add("road.local", "geometry", "0x00ff00", "0", "100", "1", "on")
                DataGridView4.Rows.Add("landscape", "geometry", "", "-100", "0", "1", "on")
            Case "caso2"
                DataGridView4.Rows.Add("road.highway", "geometry", "0xff0022", "-20", "60", "", "")
                DataGridView4.Rows.Add("road.arterial", "geometry", "0x2200ff", "", "30", "", "simplified")
                DataGridView4.Rows.Add("road.local", "", "0xf6ff00", "", "60", "0.7", "simplified")
                DataGridView4.Rows.Add("water", "geometry", "", "40", "40", "", "")
                DataGridView4.Rows.Add("road.highway", "labels", "", "", "98", "", "")
                DataGridView4.Rows.Add("administrative.locality", "labels", "0x0022ff", "-10", "50", "0.9", "")
                DataGridView4.Rows.Add("transit.line", "geometry", "0xff0000", "-70", "", "", "on")
        End Select
    End Sub
End Class