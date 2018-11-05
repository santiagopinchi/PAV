<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class planificacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(planificacion))
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_agragar = New System.Windows.Forms.Button()
        Me.txt_año = New System.Windows.Forms.MaskedTextBox()
        Me.txt_semana = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_turno = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_fecha_registro = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codturno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.semana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleado"
        '
        'btn_empleado
        '
        Me.btn_empleado.BackColor = System.Drawing.Color.White
        Me.btn_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empleado.Location = New System.Drawing.Point(759, 33)
        Me.btn_empleado.Name = "btn_empleado"
        Me.btn_empleado.Size = New System.Drawing.Size(75, 37)
        Me.btn_empleado.TabIndex = 4
        Me.btn_empleado.Text = "Buscar Empleado"
        Me.btn_empleado.UseVisualStyleBackColor = False
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_agragar)
        Me.GroupBox2.Controls.Add(Me.txt_año)
        Me.GroupBox2.Controls.Add(Me.txt_semana)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_turno)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(885, 85)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Turno"
        '
        'btn_agragar
        '
        Me.btn_agragar.BackColor = System.Drawing.Color.White
        Me.btn_agragar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agragar.Location = New System.Drawing.Point(759, 33)
        Me.btn_agragar.Name = "btn_agragar"
        Me.btn_agragar.Size = New System.Drawing.Size(75, 37)
        Me.btn_agragar.TabIndex = 3
        Me.btn_agragar.Text = "Agregar"
        Me.btn_agragar.UseVisualStyleBackColor = False
        '
        'txt_año
        '
        Me.txt_año.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_año.Location = New System.Drawing.Point(450, 49)
        Me.txt_año.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_año.Mask = "9999"
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(37, 20)
        Me.txt_año.TabIndex = 2
        '
        'txt_semana
        '
        Me.txt_semana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_semana.Location = New System.Drawing.Point(203, 49)
        Me.txt_semana.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_semana.Mask = "99"
        Me.txt_semana.Name = "txt_semana"
        Me.txt_semana.Size = New System.Drawing.Size(23, 20)
        Me.txt_semana.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Semana (entre 0 y 52)"
        '
        'cmb_turno
        '
        Me.cmb_turno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_turno.FormattingEnabled = True
        Me.cmb_turno.Location = New System.Drawing.Point(20, 49)
        Me.cmb_turno.Name = "cmb_turno"
        Me.cmb_turno.Size = New System.Drawing.Size(125, 21)
        Me.cmb_turno.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(447, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Año:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Turno:"
        '
        'txt_fecha_registro
        '
        Me.txt_fecha_registro.Checked = False
        Me.txt_fecha_registro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_registro.Location = New System.Drawing.Point(810, 12)
        Me.txt_fecha_registro.Name = "txt_fecha_registro"
        Me.txt_fecha_registro.Size = New System.Drawing.Size(87, 20)
        Me.txt_fecha_registro.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(707, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Fecha de Registro:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.codturno, Me.horaInicio, Me.horaFin, Me.semana, Me.año})
        Me.dgv.Location = New System.Drawing.Point(12, 250)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(885, 318)
        Me.dgv.TabIndex = 2
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        Me.codigo.Width = 150
        '
        'codturno
        '
        Me.codturno.HeaderText = "Código Turno"
        Me.codturno.Name = "codturno"
        Me.codturno.ReadOnly = True
        Me.codturno.Visible = False
        Me.codturno.Width = 150
        '
        'horaInicio
        '
        Me.horaInicio.HeaderText = "Hora Inicio"
        Me.horaInicio.Name = "horaInicio"
        Me.horaInicio.ReadOnly = True
        '
        'horaFin
        '
        Me.horaFin.HeaderText = "Hora Fin"
        Me.horaFin.Name = "horaFin"
        Me.horaFin.ReadOnly = True
        '
        'semana
        '
        Me.semana.HeaderText = "Semana"
        Me.semana.Name = "semana"
        Me.semana.ReadOnly = True
        Me.semana.Width = 150
        '
        'año
        '
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        '
        'planificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(910, 581)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txt_fecha_registro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "planificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planificación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents txt_año As MaskedTextBox
    Private WithEvents txt_semana As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_turno As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_fecha_registro As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_agragar As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents codturno As DataGridViewTextBoxColumn
    Friend WithEvents horaInicio As DataGridViewTextBoxColumn
    Friend WithEvents horaFin As DataGridViewTextBoxColumn
    Friend WithEvents semana As DataGridViewTextBoxColumn
    Friend WithEvents año As DataGridViewTextBoxColumn
End Class
