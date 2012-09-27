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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvTiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDistancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvIndicaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLatitutd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLongitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtdistancia = New System.Windows.Forms.TextBox()
        Me.txttiempo = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 84)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(772, 117)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 16)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvTiempo, Me.dgvDistancia, Me.dgvIndicaciones, Me.dgvLatitutd, Me.dgvLongitud})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 240)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Size = New System.Drawing.Size(1133, 316)
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
        Me.txtdistancia.Location = New System.Drawing.Point(562, 8)
        Me.txtdistancia.Name = "txtdistancia"
        Me.txtdistancia.Size = New System.Drawing.Size(171, 23)
        Me.txtdistancia.TabIndex = 3
        '
        'txttiempo
        '
        Me.txttiempo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttiempo.Location = New System.Drawing.Point(562, 34)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(171, 23)
        Me.txttiempo.TabIndex = 4
        '
        'mostrarRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 568)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.txtdistancia)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "mostrarRuta"
        Me.Text = "Rutas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDistancia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvIndicaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLatitutd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLongitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtdistancia As System.Windows.Forms.TextBox
    Friend WithEvents txttiempo As System.Windows.Forms.TextBox
End Class
