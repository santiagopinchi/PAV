﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificar_empleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_legajo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_01 = New System.Windows.Forms.DataGridView()
        Me.txt_legaj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.cmb_ciudad = New System.Windows.Forms.ComboBox()
        Me.txt_dpto = New System.Windows.Forms.TextBox()
        Me.txt_nro_piso = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_nro_calle = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.cmb_fecha_registro = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(245, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Registro"
        '
        'txt_legajo
        '
        Me.txt_legajo.Location = New System.Drawing.Point(62, 36)
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.Size = New System.Drawing.Size(118, 20)
        Me.txt_legajo.TabIndex = 77
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(12, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Legajo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmb_fecha_nacimiento)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_doc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 130)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'cmb_fecha_nacimiento
        '
        Me.cmb_fecha_nacimiento.Checked = False
        Me.cmb_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fecha_nacimiento.Location = New System.Drawing.Point(257, 48)
        Me.cmb_fecha_nacimiento.Name = "cmb_fecha_nacimiento"
        Me.cmb_fecha_nacimiento.Size = New System.Drawing.Size(100, 20)
        Me.cmb_fecha_nacimiento.TabIndex = 85
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_nro_doc.Location = New System.Drawing.Point(130, 47)
        Me.txt_nro_doc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nro_doc.Mask = "99999999"
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(101, 20)
        Me.txt_nro_doc.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(256, 96)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(203, 20)
        Me.txt_nombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(253, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Nac."
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
        Me.txt_apellido.Location = New System.Drawing.Point(20, 96)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(211, 20)
        Me.txt_apellido.TabIndex = 3
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(20, 47)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(88, 21)
        Me.cmb_tipo_doc.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo Doc.:"
        '
        'dgv_01
        '
        Me.dgv_01.AllowUserToAddRows = False
        Me.dgv_01.AllowUserToDeleteRows = False
        Me.dgv_01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_01.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txt_legaj, Me.txt_apellidos, Me.txt_nombres})
        Me.dgv_01.Location = New System.Drawing.Point(490, 12)
        Me.dgv_01.Name = "dgv_01"
        Me.dgv_01.ReadOnly = True
        Me.dgv_01.Size = New System.Drawing.Size(364, 415)
        Me.dgv_01.TabIndex = 80
        '
        'txt_legaj
        '
        Me.txt_legaj.HeaderText = "Legajo"
        Me.txt_legaj.Name = "txt_legaj"
        Me.txt_legaj.ReadOnly = True
        '
        'txt_apellidos
        '
        Me.txt_apellidos.HeaderText = "Apellido"
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.ReadOnly = True
        '
        'txt_nombres
        '
        Me.txt_nombres.HeaderText = "Nombre"
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Controls.Add(Me.cmb_barrio)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.cmb_ciudad)
        Me.GroupBox2.Controls.Add(Me.txt_dpto)
        Me.GroupBox2.Controls.Add(Me.txt_nro_piso)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txt_nro_calle)
        Me.GroupBox2.Controls.Add(Me.txt_calle)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 164)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Contacto"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(293, 89)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(169, 20)
        Me.txt_telefono.TabIndex = 78
        '
        'cmb_barrio
        '
        Me.cmb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(81, 92)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(156, 21)
        Me.cmb_barrio.TabIndex = 77
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(70, 122)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(392, 20)
        Me.txt_email.TabIndex = 13
        '
        'cmb_ciudad
        '
        Me.cmb_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ciudad.FormattingEnabled = True
        Me.cmb_ciudad.Location = New System.Drawing.Point(306, 60)
        Me.cmb_ciudad.Name = "cmb_ciudad"
        Me.cmb_ciudad.Size = New System.Drawing.Size(156, 21)
        Me.cmb_ciudad.TabIndex = 10
        '
        'txt_dpto
        '
        Me.txt_dpto.Location = New System.Drawing.Point(187, 57)
        Me.txt_dpto.Name = "txt_dpto"
        Me.txt_dpto.Size = New System.Drawing.Size(50, 20)
        Me.txt_dpto.TabIndex = 8
        '
        'txt_nro_piso
        '
        Me.txt_nro_piso.Location = New System.Drawing.Point(70, 56)
        Me.txt_nro_piso.Name = "txt_nro_piso"
        Me.txt_nro_piso.Size = New System.Drawing.Size(51, 20)
        Me.txt_nro_piso.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "E-mail"
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Location = New System.Drawing.Point(389, 25)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.Size = New System.Drawing.Size(73, 20)
        Me.txt_nro_calle.TabIndex = 6
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(70, 25)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(263, 20)
        Me.txt_calle.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(238, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Teléfono"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(260, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Ciudad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Barrio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Dpto."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Piso"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(362, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "N°"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Calle"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(401, 381)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(62, 63)
        Me.btn_cancelar.TabIndex = 82
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(114, 393)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(82, 39)
        Me.btn_confirmar.TabIndex = 84
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'cmb_fecha_registro
        '
        Me.cmb_fecha_registro.Checked = False
        Me.cmb_fecha_registro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fecha_registro.Location = New System.Drawing.Point(330, 22)
        Me.cmb_fecha_registro.Name = "cmb_fecha_registro"
        Me.cmb_fecha_registro.Size = New System.Drawing.Size(100, 20)
        Me.cmb_fecha_registro.TabIndex = 86
        '
        'modificar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 439)
        Me.Controls.Add(Me.cmb_fecha_registro)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_01)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_legajo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "modificar_empleado"
        Me.Text = "Modificar Empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_legajo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents txt_nro_doc As MaskedTextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents cmb_tipo_doc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_01 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents cmb_ciudad As ComboBox
    Friend WithEvents txt_dpto As TextBox
    Friend WithEvents txt_nro_piso As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_nro_calle As TextBox
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents txt_legaj As DataGridViewTextBoxColumn
    Friend WithEvents txt_apellidos As DataGridViewTextBoxColumn
    Friend WithEvents txt_nombres As DataGridViewTextBoxColumn
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents cmb_fecha_nacimiento As DateTimePicker
    Friend WithEvents cmb_fecha_registro As DateTimePicker
    Friend WithEvents txt_telefono As TextBox
End Class