<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapasRuta
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoCarreteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoCarretera2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 463)
        Me.Panel1.TabIndex = 1
        '
        'MapasRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MapasRuta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mapas de la ruta"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoCarreteraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoNormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ModoCarretera2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
