<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cargar_manual
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
        Me.txt_fecha_registro = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_cod_producto = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_agregar_paso = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_cod_producto_parte = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_tipo_producto_parte = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.codTipoProdFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codProdFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codTipoProdPar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codProdPar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_paso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_fecha_registro
        '
        Me.txt_fecha_registro.Checked = False
        Me.txt_fecha_registro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_registro.Location = New System.Drawing.Point(771, 13)
        Me.txt_fecha_registro.Name = "txt_fecha_registro"
        Me.txt_fecha_registro.Size = New System.Drawing.Size(87, 20)
        Me.txt_fecha_registro.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(668, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Fecha de Registro:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_ver)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_registro)
        Me.GroupBox1.Controls.Add(Me.cmb_cod_producto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_producto)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(876, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificación"
        '
        'btn_ver
        '
        Me.btn_ver.Location = New System.Drawing.Point(790, 39)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(68, 21)
        Me.btn_ver.TabIndex = 3
        Me.btn_ver.Text = "Ver"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código de Producto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Producto:"
        '
        'cmb_cod_producto
        '
        Me.cmb_cod_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_cod_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cod_producto.FormattingEnabled = True
        Me.cmb_cod_producto.Location = New System.Drawing.Point(354, 35)
        Me.cmb_cod_producto.Name = "cmb_cod_producto"
        Me.cmb_cod_producto.Size = New System.Drawing.Size(136, 21)
        Me.cmb_cod_producto.TabIndex = 1
        '
        'cmb_tipo_producto
        '
        Me.cmb_tipo_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto.FormattingEnabled = True
        Me.cmb_tipo_producto.Location = New System.Drawing.Point(102, 35)
        Me.cmb_tipo_producto.Name = "cmb_tipo_producto"
        Me.cmb_tipo_producto.Size = New System.Drawing.Size(136, 21)
        Me.cmb_tipo_producto.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_agregar_paso)
        Me.GroupBox2.Controls.Add(Me.txt_descripcion)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmb_cod_producto_parte)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_tipo_producto_parte)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 230)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identificación"
        '
        'btn_agregar_paso
        '
        Me.btn_agregar_paso.Location = New System.Drawing.Point(790, 27)
        Me.btn_agregar_paso.Name = "btn_agregar_paso"
        Me.btn_agregar_paso.Size = New System.Drawing.Size(68, 34)
        Me.btn_agregar_paso.TabIndex = 3
        Me.btn_agregar_paso.Text = "Agregar Paso"
        Me.btn_agregar_paso.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(102, 84)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(752, 126)
        Me.txt_descripcion.TabIndex = 4
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(553, 35)
        Me.txt_cantidad.Mask = "9999999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(49, 20)
        Me.txt_cantidad.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(498, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cantidad"
        '
        'cmb_cod_producto_parte
        '
        Me.cmb_cod_producto_parte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_cod_producto_parte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cod_producto_parte.FormattingEnabled = True
        Me.cmb_cod_producto_parte.Location = New System.Drawing.Point(354, 36)
        Me.cmb_cod_producto_parte.Name = "cmb_cod_producto_parte"
        Me.cmb_cod_producto_parte.Size = New System.Drawing.Size(136, 21)
        Me.cmb_cod_producto_parte.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Código de Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo de Producto:"
        '
        'cmb_tipo_producto_parte
        '
        Me.cmb_tipo_producto_parte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_producto_parte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto_parte.FormattingEnabled = True
        Me.cmb_tipo_producto_parte.Location = New System.Drawing.Point(102, 35)
        Me.cmb_tipo_producto_parte.Name = "cmb_tipo_producto_parte"
        Me.cmb_tipo_producto_parte.Size = New System.Drawing.Size(136, 21)
        Me.cmb_tipo_producto_parte.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codTipoProdFinal, Me.codProdFinal, Me.orden, Me.codTipoProdPar, Me.codProdPar, Me.descripcion_paso, Me.fecha, Me.cantidad})
        Me.dgv.Location = New System.Drawing.Point(31, 351)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(876, 225)
        Me.dgv.TabIndex = 2
        '
        'codTipoProdFinal
        '
        Me.codTipoProdFinal.HeaderText = "Tipo Prod Final"
        Me.codTipoProdFinal.Name = "codTipoProdFinal"
        Me.codTipoProdFinal.ReadOnly = True
        '
        'codProdFinal
        '
        Me.codProdFinal.HeaderText = "Codigo Final"
        Me.codProdFinal.Name = "codProdFinal"
        Me.codProdFinal.ReadOnly = True
        '
        'orden
        '
        Me.orden.HeaderText = "Orden de paso"
        Me.orden.Name = "orden"
        Me.orden.ReadOnly = True
        '
        'codTipoProdPar
        '
        Me.codTipoProdPar.HeaderText = "Tipo Prod Parcial"
        Me.codTipoProdPar.Name = "codTipoProdPar"
        Me.codTipoProdPar.ReadOnly = True
        '
        'codProdPar
        '
        Me.codProdPar.HeaderText = "Codigo Parcial"
        Me.codProdPar.Name = "codProdPar"
        Me.codProdPar.ReadOnly = True
        '
        'descripcion_paso
        '
        Me.descripcion_paso.HeaderText = "Descripcion"
        Me.descripcion_paso.Name = "descripcion_paso"
        Me.descripcion_paso.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'btn_finalizar
        '
        Me.btn_finalizar.Location = New System.Drawing.Point(833, 582)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(68, 34)
        Me.btn_finalizar.TabIndex = 4
        Me.btn_finalizar.Text = "Finalizar"
        Me.btn_finalizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(31, 582)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(68, 34)
        Me.btn_cerrar.TabIndex = 3
        Me.btn_cerrar.Text = "Cancelar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(529, 593)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(305, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "(Recuerde que al finalizar se hara la carga como el ultimo paso)"
        '
        'cargar_manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 625)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "cargar_manual"
        Me.Text = "cargar_manual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_fecha_registro As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_cod_producto As ComboBox
    Friend WithEvents cmb_tipo_producto As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_cantidad As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_cod_producto_parte As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_tipo_producto_parte As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btn_agregar_paso As Button
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents btn_ver As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents codTipoProdFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codProdFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents orden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codTipoProdPar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codProdPar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion_paso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
