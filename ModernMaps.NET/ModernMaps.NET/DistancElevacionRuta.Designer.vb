<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistancElevacionRuta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DistancElevacionRuta))
        Me.txtprovincia = New System.Windows.Forms.TextBox()
        Me.txtpoblacion = New System.Windows.Forms.TextBox()
        Me.txtcalle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtprovincia2 = New System.Windows.Forms.TextBox()
        Me.txtpoblacion2 = New System.Windows.Forms.TextBox()
        Me.txtcalle2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcompleta1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcompleta2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdistancia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttiempo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtelevacion = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtprovincia
        '
        Me.txtprovincia.BackColor = System.Drawing.SystemColors.Window
        Me.txtprovincia.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprovincia.Location = New System.Drawing.Point(464, 192)
        Me.txtprovincia.Name = "txtprovincia"
        Me.txtprovincia.Size = New System.Drawing.Size(243, 22)
        Me.txtprovincia.TabIndex = 38
        '
        'txtpoblacion
        '
        Me.txtpoblacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtpoblacion.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoblacion.Location = New System.Drawing.Point(464, 120)
        Me.txtpoblacion.Name = "txtpoblacion"
        Me.txtpoblacion.Size = New System.Drawing.Size(243, 22)
        Me.txtpoblacion.TabIndex = 36
        '
        'txtcalle
        '
        Me.txtcalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtcalle.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcalle.Location = New System.Drawing.Point(464, 156)
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(243, 22)
        Me.txtcalle.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(281, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 26)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Calle"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(281, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 26)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Provincia"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(281, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 26)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Población"
        '
        'txtprovincia2
        '
        Me.txtprovincia2.BackColor = System.Drawing.SystemColors.Window
        Me.txtprovincia2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprovincia2.Location = New System.Drawing.Point(936, 202)
        Me.txtprovincia2.Name = "txtprovincia2"
        Me.txtprovincia2.Size = New System.Drawing.Size(243, 22)
        Me.txtprovincia2.TabIndex = 44
        '
        'txtpoblacion2
        '
        Me.txtpoblacion2.BackColor = System.Drawing.SystemColors.Window
        Me.txtpoblacion2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoblacion2.Location = New System.Drawing.Point(936, 130)
        Me.txtpoblacion2.Name = "txtpoblacion2"
        Me.txtpoblacion2.Size = New System.Drawing.Size(243, 22)
        Me.txtpoblacion2.TabIndex = 42
        '
        'txtcalle2
        '
        Me.txtcalle2.BackColor = System.Drawing.SystemColors.Window
        Me.txtcalle2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcalle2.Location = New System.Drawing.Point(936, 166)
        Me.txtcalle2.Name = "txtcalle2"
        Me.txtcalle2.Size = New System.Drawing.Size(243, 22)
        Me.txtcalle2.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(753, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 26)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Calle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(753, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 26)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Provincia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(753, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 26)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Población"
        '
        'txtcompleta1
        '
        Me.txtcompleta1.BackColor = System.Drawing.SystemColors.Window
        Me.txtcompleta1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompleta1.Location = New System.Drawing.Point(464, 245)
        Me.txtcompleta1.Name = "txtcompleta1"
        Me.txtcompleta1.ReadOnly = True
        Me.txtcompleta1.Size = New System.Drawing.Size(243, 22)
        Me.txtcompleta1.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 26)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Dirección completa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(753, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 26)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Dirección completa"
        '
        'txtcompleta2
        '
        Me.txtcompleta2.BackColor = System.Drawing.SystemColors.Window
        Me.txtcompleta2.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompleta2.Location = New System.Drawing.Point(936, 249)
        Me.txtcompleta2.Name = "txtcompleta2"
        Me.txtcompleta2.ReadOnly = True
        Me.txtcompleta2.Size = New System.Drawing.Size(243, 22)
        Me.txtcompleta2.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(334, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 26)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Distancia"
        '
        'txtdistancia
        '
        Me.txtdistancia.BackColor = System.Drawing.SystemColors.Window
        Me.txtdistancia.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdistancia.Location = New System.Drawing.Point(588, 310)
        Me.txtdistancia.Name = "txtdistancia"
        Me.txtdistancia.ReadOnly = True
        Me.txtdistancia.Size = New System.Drawing.Size(243, 22)
        Me.txtdistancia.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(334, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 26)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Tiempo de recorrido"
        '
        'txttiempo
        '
        Me.txttiempo.BackColor = System.Drawing.SystemColors.Window
        Me.txttiempo.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttiempo.Location = New System.Drawing.Point(588, 349)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.ReadOnly = True
        Me.txttiempo.Size = New System.Drawing.Size(243, 22)
        Me.txttiempo.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(334, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 26)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Elevación del punto 1 al 2"
        '
        'txtelevacion
        '
        Me.txtelevacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtelevacion.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelevacion.Location = New System.Drawing.Point(588, 388)
        Me.txtelevacion.Name = "txtelevacion"
        Me.txtelevacion.ReadOnly = True
        Me.txtelevacion.Size = New System.Drawing.Size(243, 22)
        Me.txtelevacion.TabIndex = 54
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 26)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Dirección punto 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(753, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 26)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Dirección punto 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(92, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 26)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Andando"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(92, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 26)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Coche"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(92, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 26)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Bicicleta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(92, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 26)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Tipo de tránsito"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(92, 240)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 26)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Evitar peajes"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(92, 328)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 26)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "No"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(92, 292)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 26)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "Sí"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'Timer5
        '
        Me.Timer5.Interval = 1
        '
        'DistancElevacionRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(733, 358)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtelevacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdistancia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcompleta2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcompleta1)
        Me.Controls.Add(Me.txtprovincia2)
        Me.Controls.Add(Me.txtpoblacion2)
        Me.Controls.Add(Me.txtcalle2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprovincia)
        Me.Controls.Add(Me.txtpoblacion)
        Me.Controls.Add(Me.txtcalle)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DistancElevacionRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DistancElevacionRuta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtprovincia As System.Windows.Forms.TextBox
    Friend WithEvents txtpoblacion As System.Windows.Forms.TextBox
    Friend WithEvents txtcalle As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtprovincia2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpoblacion2 As System.Windows.Forms.TextBox
    Friend WithEvents txtcalle2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcompleta1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcompleta2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdistancia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttiempo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtelevacion As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
End Class
