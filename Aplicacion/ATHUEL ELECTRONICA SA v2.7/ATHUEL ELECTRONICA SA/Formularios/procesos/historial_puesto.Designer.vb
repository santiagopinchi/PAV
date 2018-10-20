<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historial_puesto
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
        Me.txt_fecha_registro = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_empleado = New System.Windows.Forms.Button()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.nombrePuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feschaDesde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidoJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_fecha_registro
        '
        Me.txt_fecha_registro.Checked = False
        Me.txt_fecha_registro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_registro.Location = New System.Drawing.Point(806, 6)
        Me.txt_fecha_registro.Name = "txt_fecha_registro"
        Me.txt_fecha_registro.Size = New System.Drawing.Size(87, 20)
        Me.txt_fecha_registro.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(703, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Fecha de Registro:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_empleado)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_doc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(897, 92)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleado"
        '
        'btn_empleado
        '
        Me.btn_empleado.Location = New System.Drawing.Point(759, 33)
        Me.btn_empleado.Name = "btn_empleado"
        Me.btn_empleado.Size = New System.Drawing.Size(75, 37)
        Me.btn_empleado.TabIndex = 4
        Me.btn_empleado.Text = "Buscar Empleado"
        Me.btn_empleado.UseVisualStyleBackColor = True
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_nro_doc.Enabled = False
        Me.txt_nro_doc.Location = New System.Drawing.Point(130, 50)
        Me.txt_nro_doc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nro_doc.Mask = "99999999"
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(101, 20)
        Me.txt_nro_doc.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(490, 49)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(203, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(127, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "N° Doc."
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(254, 50)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(211, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_doc.Enabled = False
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(20, 49)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(88, 21)
        Me.cmb_tipo_doc.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Doc.:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombrePuesto, Me.feschaDesde, Me.apellidoJ, Me.nombreJ})
        Me.dgv.Location = New System.Drawing.Point(12, 123)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(893, 303)
        Me.dgv.TabIndex = 81
        '
        'nombrePuesto
        '
        Me.nombrePuesto.HeaderText = "nombre Puesto"
        Me.nombrePuesto.Name = "nombrePuesto"
        Me.nombrePuesto.ReadOnly = True
        Me.nombrePuesto.Width = 200
        '
        'feschaDesde
        '
        Me.feschaDesde.HeaderText = "Fecha de alta"
        Me.feschaDesde.Name = "feschaDesde"
        Me.feschaDesde.ReadOnly = True
        Me.feschaDesde.Width = 150
        '
        'apellidoJ
        '
        Me.apellidoJ.HeaderText = "Nombre del jefe"
        Me.apellidoJ.Name = "apellidoJ"
        Me.apellidoJ.ReadOnly = True
        Me.apellidoJ.Width = 150
        '
        'nombreJ
        '
        Me.nombreJ.HeaderText = "Apellido del jefe"
        Me.nombreJ.Name = "nombreJ"
        Me.nombreJ.ReadOnly = True
        Me.nombreJ.Width = 200
        '
        'historial_puesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(917, 438)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txt_fecha_registro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "historial_puesto"
        Me.Text = "historial_puesto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_fecha_registro As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_empleado As Button
    Private WithEvents txt_nro_doc As MaskedTextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents cmb_tipo_doc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents nombrePuesto As DataGridViewTextBoxColumn
    Friend WithEvents feschaDesde As DataGridViewTextBoxColumn
    Friend WithEvents apellidoJ As DataGridViewTextBoxColumn
    Friend WithEvents nombreJ As DataGridViewTextBoxColumn
End Class
