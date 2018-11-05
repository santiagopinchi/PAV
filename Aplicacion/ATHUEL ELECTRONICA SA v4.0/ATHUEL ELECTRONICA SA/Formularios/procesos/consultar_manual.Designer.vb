<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultar_manual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultar_manual))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_cod_producto_parte = New System.Windows.Forms.ComboBox()
        Me.txt_orden = New System.Windows.Forms.MaskedTextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_producto_parte = New System.Windows.Forms.ComboBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_cod_producto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_fecha_registro = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btm_siguiente = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmb_cod_producto_parte)
        Me.GroupBox2.Controls.Add(Me.txt_orden)
        Me.GroupBox2.Controls.Add(Me.txt_descripcion)
        Me.GroupBox2.Controls.Add(Me.cmb_tipo_producto_parte)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(871, 230)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identificación"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Paso Nº:"
        '
        'cmb_cod_producto_parte
        '
        Me.cmb_cod_producto_parte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_cod_producto_parte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cod_producto_parte.Enabled = False
        Me.cmb_cod_producto_parte.FormattingEnabled = True
        Me.cmb_cod_producto_parte.Location = New System.Drawing.Point(354, 36)
        Me.cmb_cod_producto_parte.Name = "cmb_cod_producto_parte"
        Me.cmb_cod_producto_parte.Size = New System.Drawing.Size(136, 21)
        Me.cmb_cod_producto_parte.TabIndex = 5
        '
        'txt_orden
        '
        Me.txt_orden.Enabled = False
        Me.txt_orden.Location = New System.Drawing.Point(76, 13)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.Size = New System.Drawing.Size(41, 20)
        Me.txt_orden.TabIndex = 6
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Enabled = False
        Me.txt_descripcion.Location = New System.Drawing.Point(102, 84)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(752, 126)
        Me.txt_descripcion.TabIndex = 3
        '
        'cmb_tipo_producto_parte
        '
        Me.cmb_tipo_producto_parte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_producto_parte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto_parte.Enabled = False
        Me.cmb_tipo_producto_parte.FormattingEnabled = True
        Me.cmb_tipo_producto_parte.Location = New System.Drawing.Point(102, 36)
        Me.cmb_tipo_producto_parte.Name = "cmb_tipo_producto_parte"
        Me.cmb_tipo_producto_parte.Size = New System.Drawing.Size(136, 21)
        Me.cmb_tipo_producto_parte.TabIndex = 3
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Enabled = False
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
        Me.Label7.Text = "Descripción"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmb_cod_producto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_producto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_fecha_registro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificación"
        '
        'cmb_cod_producto
        '
        Me.cmb_cod_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_cod_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cod_producto.FormattingEnabled = True
        Me.cmb_cod_producto.Location = New System.Drawing.Point(354, 35)
        Me.cmb_cod_producto.Name = "cmb_cod_producto"
        Me.cmb_cod_producto.Size = New System.Drawing.Size(136, 21)
        Me.cmb_cod_producto.TabIndex = 6
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
        'cmb_tipo_producto
        '
        Me.cmb_tipo_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto.FormattingEnabled = True
        Me.cmb_tipo_producto.Location = New System.Drawing.Point(102, 36)
        Me.cmb_tipo_producto.Name = "cmb_tipo_producto"
        Me.cmb_tipo_producto.Size = New System.Drawing.Size(136, 21)
        Me.cmb_tipo_producto.TabIndex = 4
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
        'cmb_fecha_registro
        '
        Me.cmb_fecha_registro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_fecha_registro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fecha_registro.FormattingEnabled = True
        Me.cmb_fecha_registro.Location = New System.Drawing.Point(653, 35)
        Me.cmb_fecha_registro.Name = "cmb_fecha_registro"
        Me.cmb_fecha_registro.Size = New System.Drawing.Size(136, 21)
        Me.cmb_fecha_registro.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(550, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Fecha de Registro:"
        '
        'btm_siguiente
        '
        Me.btm_siguiente.BackColor = System.Drawing.Color.Transparent
        Me.btm_siguiente.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.images
        Me.btm_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btm_siguiente.Location = New System.Drawing.Point(823, 348)
        Me.btm_siguiente.Name = "btm_siguiente"
        Me.btm_siguiente.Size = New System.Drawing.Size(60, 60)
        Me.btm_siguiente.TabIndex = 1
        Me.btm_siguiente.UseVisualStyleBackColor = False
        '
        'btn_anterior
        '
        Me.btn_anterior.BackColor = System.Drawing.Color.White
        Me.btn_anterior.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Undo_Icon1
        Me.btn_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_anterior.Location = New System.Drawing.Point(12, 348)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(60, 60)
        Me.btn_anterior.TabIndex = 2
        Me.btn_anterior.UseVisualStyleBackColor = False
        '
        'consultar_manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 414)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.btm_siguiente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consultar_manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Manual"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_cantidad As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_fecha_registro As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btm_siguiente As Button
    Friend WithEvents btn_anterior As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_orden As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_cod_producto As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipo_producto As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cod_producto_parte As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipo_producto_parte As System.Windows.Forms.ComboBox
End Class
