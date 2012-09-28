<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostrarRuta
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvTiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDistancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvIndicaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLatitutd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLongitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtdistancia = New System.Windows.Forms.TextBox()
        Me.txttiempo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvTiempo, Me.dgvDistancia, Me.dgvIndicaciones, Me.dgvLatitutd, Me.dgvLongitud})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 144)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Size = New System.Drawing.Size(1250, 559)
        Me.DataGridView1.TabIndex = 2
        '
        'dgvTiempo
        '
        Me.dgvTiempo.HeaderText = "Duración tramo"
        Me.dgvTiempo.Name = "dgvTiempo"
        '
        'dgvDistancia
        '
        Me.dgvDistancia.HeaderText = "Distancia tramo"
        Me.dgvDistancia.Name = "dgvDistancia"
        '
        'dgvIndicaciones
        '
        Me.dgvIndicaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvIndicaciones.HeaderText = "Indicaciones tramo"
        Me.dgvIndicaciones.Name = "dgvIndicaciones"
        '
        'dgvLatitutd
        '
        Me.dgvLatitutd.HeaderText = "Latitud"
        Me.dgvLatitutd.Name = "dgvLatitutd"
        '
        'dgvLongitud
        '
        Me.dgvLongitud.HeaderText = "Longitud"
        Me.dgvLongitud.Name = "dgvLongitud"
        '
        'txtdistancia
        '
        Me.txtdistancia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdistancia.Location = New System.Drawing.Point(191, 15)
        Me.txtdistancia.Name = "txtdistancia"
        Me.txtdistancia.Size = New System.Drawing.Size(171, 23)
        Me.txtdistancia.TabIndex = 3
        '
        'txttiempo
        '
        Me.txttiempo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttiempo.Location = New System.Drawing.Point(191, 44)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(222, 23)
        Me.txttiempo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Distancia recorrida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Duración total estimada"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(6, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(596, 72)
        Me.ListBox1.TabIndex = 58
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(630, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 111)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden de visita de hitos"
        Me.GroupBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(579, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 20)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mostrarRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 699)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.txtdistancia)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "mostrarRuta"
        Me.Text = "Rutas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDistancia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvIndicaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLatitutd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLongitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtdistancia As System.Windows.Forms.TextBox
    Friend WithEvents txttiempo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
