<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rutas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rutas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdirorigen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlatOrigen = New System.Windows.Forms.TextBox()
        Me.txtdirEncOrig = New System.Windows.Forms.TextBox()
        Me.txtlngOrigen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlngDestin = New System.Windows.Forms.TextBox()
        Me.txtdirEncDest = New System.Windows.Forms.TextBox()
        Me.txtlatDestin = New System.Windows.Forms.TextBox()
        Me.txtdirdestin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtlngHito = New System.Windows.Forms.TextBox()
        Me.txtdirEncHito = New System.Windows.Forms.TextBox()
        Me.txtlatHito = New System.Windows.Forms.TextBox()
        Me.txtdirhito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Origen (*)"
        '
        'txtdirorigen
        '
        Me.txtdirorigen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirorigen.Location = New System.Drawing.Point(141, 67)
        Me.txtdirorigen.Name = "txtdirorigen"
        Me.txtdirorigen.Size = New System.Drawing.Size(238, 23)
        Me.txtdirorigen.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Dirección"
        '
        'txtlatOrigen
        '
        Me.txtlatOrigen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlatOrigen.Location = New System.Drawing.Point(408, 67)
        Me.txtlatOrigen.Name = "txtlatOrigen"
        Me.txtlatOrigen.ReadOnly = True
        Me.txtlatOrigen.Size = New System.Drawing.Size(141, 23)
        Me.txtlatOrigen.TabIndex = 56
        Me.txtlatOrigen.TabStop = False
        Me.txtlatOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdirEncOrig
        '
        Me.txtdirEncOrig.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirEncOrig.Location = New System.Drawing.Point(733, 68)
        Me.txtdirEncOrig.Name = "txtdirEncOrig"
        Me.txtdirEncOrig.ReadOnly = True
        Me.txtdirEncOrig.Size = New System.Drawing.Size(238, 23)
        Me.txtdirEncOrig.TabIndex = 58
        Me.txtdirEncOrig.TabStop = False
        Me.txtdirEncOrig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlngOrigen
        '
        Me.txtlngOrigen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlngOrigen.Location = New System.Drawing.Point(574, 67)
        Me.txtlngOrigen.Name = "txtlngOrigen"
        Me.txtlngOrigen.ReadOnly = True
        Me.txtlngOrigen.Size = New System.Drawing.Size(141, 23)
        Me.txtlngOrigen.TabIndex = 59
        Me.txtlngOrigen.TabStop = False
        Me.txtlngOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(786, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Dirección encontrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(615, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Longitud"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Latitud"
        '
        'txtlngDestin
        '
        Me.txtlngDestin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlngDestin.Location = New System.Drawing.Point(574, 121)
        Me.txtlngDestin.Name = "txtlngDestin"
        Me.txtlngDestin.ReadOnly = True
        Me.txtlngDestin.Size = New System.Drawing.Size(141, 23)
        Me.txtlngDestin.TabIndex = 67
        Me.txtlngDestin.TabStop = False
        Me.txtlngDestin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdirEncDest
        '
        Me.txtdirEncDest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirEncDest.Location = New System.Drawing.Point(733, 122)
        Me.txtdirEncDest.Name = "txtdirEncDest"
        Me.txtdirEncDest.ReadOnly = True
        Me.txtdirEncDest.Size = New System.Drawing.Size(238, 23)
        Me.txtdirEncDest.TabIndex = 4
        Me.txtdirEncDest.TabStop = False
        Me.txtdirEncDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlatDestin
        '
        Me.txtlatDestin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlatDestin.Location = New System.Drawing.Point(408, 121)
        Me.txtlatDestin.Name = "txtlatDestin"
        Me.txtlatDestin.ReadOnly = True
        Me.txtlatDestin.Size = New System.Drawing.Size(141, 23)
        Me.txtlatDestin.TabIndex = 65
        Me.txtlatDestin.TabStop = False
        Me.txtlatDestin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdirdestin
        '
        Me.txtdirdestin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirdestin.Location = New System.Drawing.Point(141, 121)
        Me.txtdirdestin.Name = "txtdirdestin"
        Me.txtdirdestin.Size = New System.Drawing.Size(238, 23)
        Me.txtdirdestin.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Destino (*)"
        '
        'txtlngHito
        '
        Me.txtlngHito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlngHito.Location = New System.Drawing.Point(574, 265)
        Me.txtlngHito.Name = "txtlngHito"
        Me.txtlngHito.ReadOnly = True
        Me.txtlngHito.Size = New System.Drawing.Size(141, 23)
        Me.txtlngHito.TabIndex = 72
        Me.txtlngHito.TabStop = False
        Me.txtlngHito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdirEncHito
        '
        Me.txtdirEncHito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirEncHito.Location = New System.Drawing.Point(733, 266)
        Me.txtdirEncHito.Name = "txtdirEncHito"
        Me.txtdirEncHito.ReadOnly = True
        Me.txtdirEncHito.Size = New System.Drawing.Size(238, 23)
        Me.txtdirEncHito.TabIndex = 71
        Me.txtdirEncHito.TabStop = False
        Me.txtdirEncHito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlatHito
        '
        Me.txtlatHito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlatHito.Location = New System.Drawing.Point(408, 265)
        Me.txtlatHito.Name = "txtlatHito"
        Me.txtlatHito.ReadOnly = True
        Me.txtlatHito.Size = New System.Drawing.Size(141, 23)
        Me.txtlatHito.TabIndex = 70
        Me.txtlatHito.TabStop = False
        Me.txtlatHito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdirhito
        '
        Me.txtdirhito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirhito.Location = New System.Drawing.Point(141, 265)
        Me.txtdirhito.Name = "txtdirhito"
        Me.txtdirhito.Size = New System.Drawing.Size(238, 23)
        Me.txtdirhito.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Hitos (8 máx)"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(6, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(937, 106)
        Me.ListBox1.TabIndex = 73
        Me.ListBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(888, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = False
        Me.Button1.Text = "[+] Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(977, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 75
        Me.Button2.TabStop = False
        Me.Button2.Text = "[-] Quitar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(842, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.TabStop = False
        Me.Button3.Text = "Comprobar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(938, 518)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 31)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Calcular ruta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(938, 556)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 21)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Optimizar ruta"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(977, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(977, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(977, 394)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 23)
        Me.Button5.TabIndex = 88
        Me.Button5.TabStop = False
        Me.Button5.Text = "[x] Limpiar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(455, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Latitud"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(615, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Longitud"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(786, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 17)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Dirección encontrada"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(150, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 17)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Dirección"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Maps.NET.My.Resources.Resources.help
        Me.PictureBox3.Location = New System.Drawing.Point(110, 68)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 93
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Es recomendable separar las unidades geográficas por comas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Puerta del Sol, Madr" & _
        "id,España")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Maps.NET.My.Resources.Resources.help
        Me.PictureBox4.Location = New System.Drawing.Point(110, 265)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 94
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Los hitos establecen las ubicaciones específicas por las que debe pasar la ruta e" & _
        "ntre el" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "origen y el destino." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El máximo de hitos posibles en una ruta es de 8.")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Maps.NET.My.Resources.Resources.help
        Me.PictureBox5.Location = New System.Drawing.Point(1047, 556)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 95
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, resources.GetString("PictureBox5.ToolTip"))
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(22, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(949, 137)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hitos incluidos"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Coche (predeterminada)", "Bicicleta", "A pie"})
        Me.ComboBox1.Location = New System.Drawing.Point(22, 545)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 23)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.TabStop = False
        Me.ComboBox1.Text = "Medio de transporte"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Sin restricciones (predeterminada)", "Evitar peajes en puentes y carreteras", "Evitar autopista y autovías"})
        Me.ComboBox2.Location = New System.Drawing.Point(22, 511)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(194, 23)
        Me.ComboBox2.TabIndex = 5
        Me.ComboBox2.TabStop = False
        Me.ComboBox2.Text = "Peajes"
        '
        'Rutas
        '
        Me.AcceptButton = Me.Button4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 588)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtlngHito)
        Me.Controls.Add(Me.txtdirEncHito)
        Me.Controls.Add(Me.txtlatHito)
        Me.Controls.Add(Me.txtdirhito)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtlngDestin)
        Me.Controls.Add(Me.txtdirEncDest)
        Me.Controls.Add(Me.txtlatDestin)
        Me.Controls.Add(Me.txtdirdestin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtlngOrigen)
        Me.Controls.Add(Me.txtdirEncOrig)
        Me.Controls.Add(Me.txtlatOrigen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdirorigen)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Rutas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creador de rutas"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdirorigen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlatOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtdirEncOrig As System.Windows.Forms.TextBox
    Friend WithEvents txtlngOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlngDestin As System.Windows.Forms.TextBox
    Friend WithEvents txtdirEncDest As System.Windows.Forms.TextBox
    Friend WithEvents txtlatDestin As System.Windows.Forms.TextBox
    Friend WithEvents txtdirdestin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtlngHito As System.Windows.Forms.TextBox
    Friend WithEvents txtdirEncHito As System.Windows.Forms.TextBox
    Friend WithEvents txtlatHito As System.Windows.Forms.TextBox
    Friend WithEvents txtdirhito As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
