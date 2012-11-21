<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeguimientoURL
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.peti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvgLat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvURL = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.excep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpeticion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtperdidas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtperdidasporc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.peti, Me.hora, Me.Estatus, Me.dvgLat, Me.dgvURL, Me.excep})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(890, 233)
        Me.DataGridView1.TabIndex = 3
        Me.DataGridView1.TabStop = False
        '
        'peti
        '
        Me.peti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.peti.HeaderText = "Número petición"
        Me.peti.Name = "peti"
        Me.peti.ReadOnly = True
        Me.peti.Width = 112
        '
        'hora
        '
        Me.hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.hora.HeaderText = "Hora de la petición"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        Me.hora.Width = 121
        '
        'Estatus
        '
        Me.Estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Width = 69
        '
        'dvgLat
        '
        Me.dvgLat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dvgLat.HeaderText = "Servicio que realiza la petición"
        Me.dvgLat.Name = "dvgLat"
        Me.dvgLat.ReadOnly = True
        Me.dvgLat.Width = 134
        '
        'dgvURL
        '
        Me.dgvURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvURL.HeaderText = "URL"
        Me.dgvURL.Name = "dgvURL"
        Me.dgvURL.ReadOnly = True
        Me.dgvURL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvURL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvURL.Width = 53
        '
        'excep
        '
        Me.excep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.excep.HeaderText = "Excepción"
        Me.excep.Name = "excep"
        Me.excep.ReadOnly = True
        Me.excep.Width = 85
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 233)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 17)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Número total de peticiones"
        '
        'txtpeticion
        '
        Me.txtpeticion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeticion.Location = New System.Drawing.Point(186, 32)
        Me.txtpeticion.Name = "txtpeticion"
        Me.txtpeticion.ReadOnly = True
        Me.txtpeticion.Size = New System.Drawing.Size(113, 23)
        Me.txtpeticion.TabIndex = 99
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(607, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 29)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "Recargar peticiones actuales"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtperdidas
        '
        Me.txtperdidas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperdidas.Location = New System.Drawing.Point(477, 13)
        Me.txtperdidas.Name = "txtperdidas"
        Me.txtperdidas.ReadOnly = True
        Me.txtperdidas.Size = New System.Drawing.Size(113, 23)
        Me.txtperdidas.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Peticiones perdidas"
        '
        'txtperdidasporc
        '
        Me.txtperdidasporc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperdidasporc.Location = New System.Drawing.Point(477, 43)
        Me.txtperdidasporc.Name = "txtperdidasporc"
        Me.txtperdidasporc.ReadOnly = True
        Me.txtperdidasporc.Size = New System.Drawing.Size(113, 23)
        Me.txtperdidasporc.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Porcentaje perdidas "
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(803, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 29)
        Me.Button2.TabIndex = 106
        Me.Button2.Text = "Ver registro de peticiones"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(999, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 29)
        Me.Button3.TabIndex = 107
        Me.Button3.Text = "Exportar a XML"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SeguimientoURL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 360)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtperdidasporc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtperdidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpeticion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "SeguimientoURL"
        Me.Text = "Seguimiento peticiones HTTP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpeticion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtperdidas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtperdidasporc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents peti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dvgLat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvURL As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents excep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
