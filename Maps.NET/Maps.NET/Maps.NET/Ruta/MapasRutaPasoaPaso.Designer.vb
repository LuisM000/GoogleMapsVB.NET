<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapasRutaPasoaPaso
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoCarreteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoCarretera2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(30, 81)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(640, 370)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.TabStop = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(575, 290)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(260, 190)
        Me.WebBrowser2.TabIndex = 1
        Me.WebBrowser2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(640, 43)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Datos de la ruta"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(686, 57)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(129, 31)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Siguiente"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(686, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Anterior"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(686, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Empezar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModoCarreteraToolStripMenuItem, Me.ModoCarretera2ToolStripMenuItem, Me.ModoNormalToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ModoCarreteraToolStripMenuItem
        '
        Me.ModoCarreteraToolStripMenuItem.Name = "ModoCarreteraToolStripMenuItem"
        Me.ModoCarreteraToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ModoCarreteraToolStripMenuItem.Text = "Modo carretera"
        '
        'ModoCarretera2ToolStripMenuItem
        '
        Me.ModoCarretera2ToolStripMenuItem.Name = "ModoCarretera2ToolStripMenuItem"
        Me.ModoCarretera2ToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ModoCarretera2ToolStripMenuItem.Text = "Modo carretera alternativo"
        '
        'ModoNormalToolStripMenuItem
        '
        Me.ModoNormalToolStripMenuItem.Name = "ModoNormalToolStripMenuItem"
        Me.ModoNormalToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ModoNormalToolStripMenuItem.Text = "Modo normal"
        '
        'MapasRutaPasoaPaso
        '
        Me.AcceptButton = Me.Button7
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 507)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MapasRutaPasoaPaso"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Mapas de ruta"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoCarreteraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoCarretera2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoNormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
