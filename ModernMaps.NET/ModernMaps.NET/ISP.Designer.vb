<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISP))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtlongitud = New System.Windows.Forms.TextBox()
        Me.txtlatitud = New System.Windows.Forms.TextBox()
        Me.txtregion = New System.Windows.Forms.TextBox()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpais = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'txtlongitud
        '
        Me.txtlongitud.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtlongitud.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlongitud.Location = New System.Drawing.Point(188, 280)
        Me.txtlongitud.Name = "txtlongitud"
        Me.txtlongitud.ReadOnly = True
        Me.txtlongitud.Size = New System.Drawing.Size(243, 22)
        Me.txtlongitud.TabIndex = 6
        '
        'txtlatitud
        '
        Me.txtlatitud.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtlatitud.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlatitud.Location = New System.Drawing.Point(188, 240)
        Me.txtlatitud.Name = "txtlatitud"
        Me.txtlatitud.ReadOnly = True
        Me.txtlatitud.Size = New System.Drawing.Size(243, 22)
        Me.txtlatitud.TabIndex = 5
        '
        'txtregion
        '
        Me.txtregion.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtregion.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregion.Location = New System.Drawing.Point(188, 200)
        Me.txtregion.Name = "txtregion"
        Me.txtregion.ReadOnly = True
        Me.txtregion.Size = New System.Drawing.Size(243, 22)
        Me.txtregion.TabIndex = 4
        '
        'txtip
        '
        Me.txtip.BackColor = System.Drawing.SystemColors.Window
        Me.txtip.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtip.Location = New System.Drawing.Point(188, 80)
        Me.txtip.Name = "txtip"
        Me.txtip.ReadOnly = True
        Me.txtip.Size = New System.Drawing.Size(243, 22)
        Me.txtip.TabIndex = 1
        '
        'txtciudad
        '
        Me.txtciudad.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtciudad.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtciudad.Location = New System.Drawing.Point(188, 120)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.ReadOnly = True
        Me.txtciudad.Size = New System.Drawing.Size(243, 22)
        Me.txtciudad.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 26)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Población"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Región"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Latitud"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Longitud"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Mostrar mapa"
        '
        'txtpais
        '
        Me.txtpais.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtpais.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpais.Location = New System.Drawing.Point(188, 160)
        Me.txtpais.Name = "txtpais"
        Me.txtpais.ReadOnly = True
        Me.txtpais.Size = New System.Drawing.Size(243, 22)
        Me.txtpais.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 26)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "País"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(-2, 361)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(984, 362)
        Me.WebBrowser1.TabIndex = 25
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
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
        Me.Timer4.Interval = 1000
        '
        'Timer5
        '
        Me.Timer5.Interval = 1
        '
        'Timer6
        '
        Me.Timer6.Interval = 1
        '
        'ISP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(470, 360)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.txtpais)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtlongitud)
        Me.Controls.Add(Me.txtlatitud)
        Me.Controls.Add(Me.txtregion)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.txtciudad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ISP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Latitud"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtlongitud As System.Windows.Forms.TextBox
    Friend WithEvents txtlatitud As System.Windows.Forms.TextBox
    Friend WithEvents txtregion As System.Windows.Forms.TextBox
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents txtciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpais As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
End Class
