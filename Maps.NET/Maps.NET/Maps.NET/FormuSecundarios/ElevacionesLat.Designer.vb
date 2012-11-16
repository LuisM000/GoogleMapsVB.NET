<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElevacionesLat
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dvgLat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvlng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDuracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvElevacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resolución = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlongitud = New System.Windows.Forms.TextBox()
        Me.txtdirEnc = New System.Windows.Forms.TextBox()
        Me.txtlatitud = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(413, 131)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 31)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Calcular elevación"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dvgLat, Me.dgvlng, Me.dgvDuracion, Me.dgvElevacion, Me.Resolución})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 181)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Size = New System.Drawing.Size(1071, 287)
        Me.DataGridView1.TabIndex = 107
        Me.DataGridView1.TabStop = False
        '
        'dvgLat
        '
        Me.dvgLat.HeaderText = "Latitud"
        Me.dvgLat.Name = "dvgLat"
        '
        'dgvlng
        '
        Me.dgvlng.HeaderText = "Longitud"
        Me.dgvlng.Name = "dgvlng"
        '
        'dgvDuracion
        '
        Me.dgvDuracion.HeaderText = "Dirección"
        Me.dgvDuracion.Name = "dgvDuracion"
        Me.dgvDuracion.Width = 627
        '
        'dgvElevacion
        '
        Me.dgvElevacion.HeaderText = "Elevación"
        Me.dgvElevacion.Name = "dgvElevacion"
        '
        'Resolución
        '
        Me.Resolución.HeaderText = "Resolución"
        Me.Resolución.Name = "Resolución"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Maps.NET.My.Resources.Resources.help
        Me.PictureBox3.Location = New System.Drawing.Point(86, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 116
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Longitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Dir. encontrada"
        '
        'txtlongitud
        '
        Me.txtlongitud.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlongitud.Location = New System.Drawing.Point(132, 93)
        Me.txtlongitud.Name = "txtlongitud"
        Me.txtlongitud.Size = New System.Drawing.Size(156, 23)
        Me.txtlongitud.TabIndex = 1
        '
        'txtdirEnc
        '
        Me.txtdirEnc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdirEnc.Location = New System.Drawing.Point(132, 136)
        Me.txtdirEnc.Name = "txtdirEnc"
        Me.txtdirEnc.ReadOnly = True
        Me.txtdirEnc.Size = New System.Drawing.Size(238, 23)
        Me.txtdirEnc.TabIndex = 110
        Me.txtdirEnc.TabStop = False
        '
        'txtlatitud
        '
        Me.txtlatitud.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlatitud.Location = New System.Drawing.Point(132, 50)
        Me.txtlatitud.Name = "txtlatitud"
        Me.txtlatitud.Size = New System.Drawing.Size(156, 23)
        Me.txtlatitud.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Latitud"
        '
        'ElevacionesLat
        '
        Me.AcceptButton = Me.Button4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 475)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtlongitud)
        Me.Controls.Add(Me.txtdirEnc)
        Me.Controls.Add(Me.txtlatitud)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ElevacionesLat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Elevación"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dvgLat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvlng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDuracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvElevacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Resolución As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlongitud As System.Windows.Forms.TextBox
    Friend WithEvents txtdirEnc As System.Windows.Forms.TextBox
    Friend WithEvents txtlatitud As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
