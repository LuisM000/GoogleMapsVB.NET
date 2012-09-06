<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtlong = New System.Windows.Forms.TextBox()
        Me.txtLat = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtprovincia = New System.Windows.Forms.TextBox()
        Me.txtcomunidad = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(12, 12)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(173, 20)
        Me.txtCalle.TabIndex = 0
        Me.txtCalle.Text = "Calle/Local"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(36, 263)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(587, 363)
        Me.WebBrowser1.TabIndex = 2
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(222, 11)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(173, 20)
        Me.txtCiudad.TabIndex = 3
        Me.txtCiudad.Text = "Ciudad"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(222, 90)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(173, 20)
        Me.txtPais.TabIndex = 4
        Me.txtPais.Text = "País"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(12, 64)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(173, 20)
        Me.txtCP.TabIndex = 5
        Me.txtCP.Text = "Código Postal"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(12, 38)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(173, 20)
        Me.txtNumero.TabIndex = 6
        Me.txtNumero.Text = "Número"
        '
        'txtlong
        '
        Me.txtlong.Location = New System.Drawing.Point(450, 37)
        Me.txtlong.Name = "txtlong"
        Me.txtlong.Size = New System.Drawing.Size(173, 20)
        Me.txtlong.TabIndex = 7
        Me.txtlong.Text = "Longitud"
        '
        'txtLat
        '
        Me.txtLat.Location = New System.Drawing.Point(450, 12)
        Me.txtLat.Name = "txtLat"
        Me.txtLat.Size = New System.Drawing.Size(173, 20)
        Me.txtLat.TabIndex = 8
        Me.txtLat.Text = "Latitud"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(467, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(467, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 41)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Detectar ISP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtprovincia
        '
        Me.txtprovincia.Location = New System.Drawing.Point(222, 38)
        Me.txtprovincia.Name = "txtprovincia"
        Me.txtprovincia.Size = New System.Drawing.Size(173, 20)
        Me.txtprovincia.TabIndex = 11
        Me.txtprovincia.Text = "Provincia"
        '
        'txtcomunidad
        '
        Me.txtcomunidad.Location = New System.Drawing.Point(222, 64)
        Me.txtcomunidad.Name = "txtcomunidad"
        Me.txtcomunidad.Size = New System.Drawing.Size(173, 20)
        Me.txtcomunidad.TabIndex = 12
        Me.txtcomunidad.Text = "Comunidad"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(310, 161)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 66)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(675, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(675, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Buscar latitud/longitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(675, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Codificación geográfica (obtener latitud/longitud)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(675, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Buscar ISP"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(222, 116)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(173, 20)
        Me.txtIP.TabIndex = 18
        Me.txtIP.Text = "IP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 527)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtcomunidad)
        Me.Controls.Add(Me.txtprovincia)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtLat)
        Me.Controls.Add(Me.txtlong)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCalle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtlong As System.Windows.Forms.TextBox
    Friend WithEvents txtLat As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtprovincia As System.Windows.Forms.TextBox
    Friend WithEvents txtcomunidad As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox

End Class
