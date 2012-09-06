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
        Me.Button1.Location = New System.Drawing.Point(104, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(53, 161)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(502, 341)
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
        Me.txtPais.Location = New System.Drawing.Point(222, 104)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(173, 20)
        Me.txtPais.TabIndex = 4
        Me.txtPais.Text = "País"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(222, 135)
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
        Me.txtlong.Location = New System.Drawing.Point(467, 37)
        Me.txtlong.Name = "txtlong"
        Me.txtlong.Size = New System.Drawing.Size(173, 20)
        Me.txtlong.TabIndex = 7
        Me.txtlong.Text = "Longitud"
        '
        'txtLat
        '
        Me.txtLat.Location = New System.Drawing.Point(467, 11)
        Me.txtLat.Name = "txtLat"
        Me.txtLat.Size = New System.Drawing.Size(173, 20)
        Me.txtLat.TabIndex = 8
        Me.txtLat.Text = "Latitud"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(534, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(673, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 72)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Detectar ISP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtprovincia
        '
        Me.txtprovincia.Location = New System.Drawing.Point(222, 78)
        Me.txtprovincia.Name = "txtprovincia"
        Me.txtprovincia.Size = New System.Drawing.Size(173, 20)
        Me.txtprovincia.TabIndex = 11
        Me.txtprovincia.Text = "Provincia"
        '
        'txtcomunidad
        '
        Me.txtcomunidad.Location = New System.Drawing.Point(222, 37)
        Me.txtcomunidad.Name = "txtcomunidad"
        Me.txtcomunidad.Size = New System.Drawing.Size(173, 20)
        Me.txtcomunidad.TabIndex = 12
        Me.txtcomunidad.Text = "Comunidad"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(725, 252)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 66)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 527)
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

End Class
