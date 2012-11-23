<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoPC
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblvirtualuso = New System.Windows.Forms.Label()
        Me.lblfisicaenuso = New System.Windows.Forms.Label()
        Me.lblvirtualdispo = New System.Windows.Forms.Label()
        Me.lblvirtualtotal = New System.Windows.Forms.Label()
        Me.lblfisicadisponible = New System.Windows.Forms.Label()
        Me.lblfisicatotal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grafiInferior = New System.Windows.Forms.Label()
        Me.GrafSuperior = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMaximo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Memoria física total (MB): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Memoria física disponible (MB): "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Memoria virtual total (MB): "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Memoria virtual disponible (MB): "
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(856, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(130, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cerrar pestañas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(11, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 36)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Liberar memoria"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Memoria física en uso (MB): "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Memoria virtual en uso (MB): "
        '
        'lblvirtualuso
        '
        Me.lblvirtualuso.AutoSize = True
        Me.lblvirtualuso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvirtualuso.ForeColor = System.Drawing.Color.Black
        Me.lblvirtualuso.Location = New System.Drawing.Point(215, 268)
        Me.lblvirtualuso.Name = "lblvirtualuso"
        Me.lblvirtualuso.Size = New System.Drawing.Size(150, 17)
        Me.lblvirtualuso.TabIndex = 14
        Me.lblvirtualuso.Text = "Memoria virtual en uso: "
        '
        'lblfisicaenuso
        '
        Me.lblfisicaenuso.AutoSize = True
        Me.lblfisicaenuso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfisicaenuso.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblfisicaenuso.Location = New System.Drawing.Point(221, 91)
        Me.lblfisicaenuso.Name = "lblfisicaenuso"
        Me.lblfisicaenuso.Size = New System.Drawing.Size(137, 17)
        Me.lblfisicaenuso.TabIndex = 13
        Me.lblfisicaenuso.Text = "Memoria física en uso"
        '
        'lblvirtualdispo
        '
        Me.lblvirtualdispo.AutoSize = True
        Me.lblvirtualdispo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvirtualdispo.ForeColor = System.Drawing.Color.Black
        Me.lblvirtualdispo.Location = New System.Drawing.Point(215, 237)
        Me.lblvirtualdispo.Name = "lblvirtualdispo"
        Me.lblvirtualdispo.Size = New System.Drawing.Size(172, 17)
        Me.lblvirtualdispo.TabIndex = 12
        Me.lblvirtualdispo.Text = "Memoria virtual disponible: "
        '
        'lblvirtualtotal
        '
        Me.lblvirtualtotal.AutoSize = True
        Me.lblvirtualtotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvirtualtotal.ForeColor = System.Drawing.Color.Black
        Me.lblvirtualtotal.Location = New System.Drawing.Point(215, 206)
        Me.lblvirtualtotal.Name = "lblvirtualtotal"
        Me.lblvirtualtotal.Size = New System.Drawing.Size(137, 17)
        Me.lblvirtualtotal.TabIndex = 11
        Me.lblvirtualtotal.Text = "Memoria virtual total: "
        '
        'lblfisicadisponible
        '
        Me.lblfisicadisponible.AutoSize = True
        Me.lblfisicadisponible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfisicadisponible.ForeColor = System.Drawing.Color.Black
        Me.lblfisicadisponible.Location = New System.Drawing.Point(221, 60)
        Me.lblfisicadisponible.Name = "lblfisicadisponible"
        Me.lblfisicadisponible.Size = New System.Drawing.Size(166, 17)
        Me.lblfisicadisponible.TabIndex = 10
        Me.lblfisicadisponible.Text = "Memoria física disponible: "
        '
        'lblfisicatotal
        '
        Me.lblfisicatotal.AutoSize = True
        Me.lblfisicatotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfisicatotal.ForeColor = System.Drawing.Color.Black
        Me.lblfisicatotal.Location = New System.Drawing.Point(221, 29)
        Me.lblfisicatotal.Name = "lblfisicatotal"
        Me.lblfisicatotal.Size = New System.Drawing.Size(131, 17)
        Me.lblfisicatotal.TabIndex = 9
        Me.lblfisicatotal.Text = "Memoria física total: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(398, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(568, 217)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'grafiInferior
        '
        Me.grafiInferior.AutoSize = True
        Me.grafiInferior.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grafiInferior.ForeColor = System.Drawing.Color.DimGray
        Me.grafiInferior.Location = New System.Drawing.Point(930, 249)
        Me.grafiInferior.Name = "grafiInferior"
        Me.grafiInferior.Size = New System.Drawing.Size(36, 17)
        Me.grafiInferior.TabIndex = 16
        Me.grafiInferior.Text = "1000"
        '
        'GrafSuperior
        '
        Me.GrafSuperior.AutoSize = True
        Me.GrafSuperior.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrafSuperior.ForeColor = System.Drawing.Color.DimGray
        Me.GrafSuperior.Location = New System.Drawing.Point(930, 9)
        Me.GrafSuperior.Name = "GrafSuperior"
        Me.GrafSuperior.Size = New System.Drawing.Size(36, 17)
        Me.GrafSuperior.TabIndex = 17
        Me.GrafSuperior.Text = "1000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(395, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Uso de memoria (MB)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(395, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "60 segundos"
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimo.ForeColor = System.Drawing.Color.Green
        Me.lblMinimo.Location = New System.Drawing.Point(221, 153)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(137, 17)
        Me.lblMinimo.TabIndex = 21
        Me.lblMinimo.Text = "Memoria física en uso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(22, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(199, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Máximo en uso alcanzado (MB): "
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximo.ForeColor = System.Drawing.Color.Red
        Me.lblMaximo.Location = New System.Drawing.Point(221, 122)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(137, 17)
        Me.lblMaximo.TabIndex = 23
        Me.lblMaximo.Text = "Memoria física en uso"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(22, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(196, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Mínimo en uso alcanzado (MB): "
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(287, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 25)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Activar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button5.Location = New System.Drawing.Point(287, 87)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 25)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Desactivar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Green
        Me.Button6.Location = New System.Drawing.Point(287, 149)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(78, 25)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Activar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'InfoPC
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 356)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GrafSuperior)
        Me.Controls.Add(Me.grafiInferior)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblvirtualuso)
        Me.Controls.Add(Me.lblfisicaenuso)
        Me.Controls.Add(Me.lblvirtualdispo)
        Me.Controls.Add(Me.lblvirtualtotal)
        Me.Controls.Add(Me.lblfisicadisponible)
        Me.Controls.Add(Me.lblfisicatotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InfoPC"
        Me.ShowInTaskbar = False
        Me.Text = "Información recursos"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblvirtualuso As System.Windows.Forms.Label
    Friend WithEvents lblfisicaenuso As System.Windows.Forms.Label
    Friend WithEvents lblvirtualdispo As System.Windows.Forms.Label
    Friend WithEvents lblvirtualtotal As System.Windows.Forms.Label
    Friend WithEvents lblfisicadisponible As System.Windows.Forms.Label
    Friend WithEvents lblfisicatotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grafiInferior As System.Windows.Forms.Label
    Friend WithEvents GrafSuperior As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblMinimo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMaximo As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
