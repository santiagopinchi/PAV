<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alta_producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alta_producto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cod_producto = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_fecha_fabricacion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_cod_producto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_producto)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificación"
        '
        'txt_cod_producto
        '
        Me.txt_cod_producto.Location = New System.Drawing.Point(348, 35)
        Me.txt_cod_producto.Mask = "9999999"
        Me.txt_cod_producto.Name = "txt_cod_producto"
        Me.txt_cod_producto.Size = New System.Drawing.Size(126, 20)
        Me.txt_cod_producto.TabIndex = 1
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
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.cmb_fecha_fabricacion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_descripcion)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_modelo)
        Me.GroupBox2.Controls.Add(Me.cmb_marca)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripción General"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(319, 107)
        Me.txt_cantidad.Mask = "9999999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 4
        '
        'cmb_fecha_fabricacion
        '
        Me.cmb_fecha_fabricacion.Checked = False
        Me.cmb_fecha_fabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fecha_fabricacion.Location = New System.Drawing.Point(138, 107)
        Me.cmb_fecha_fabricacion.Name = "cmb_fecha_fabricacion"
        Me.cmb_fecha_fabricacion.Size = New System.Drawing.Size(87, 20)
        Me.cmb_fecha_fabricacion.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha de Fabricación:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(87, 72)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(387, 20)
        Me.txt_descripcion.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Modelo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Marca:"
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(319, 36)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(155, 20)
        Me.txt_modelo.TabIndex = 1
        '
        'cmb_marca
        '
        Me.cmb_marca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(61, 35)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(172, 21)
        Me.cmb_marca.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(282, 278)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(62, 63)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Transparent
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(171, 278)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(62, 63)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'alta_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(515, 360)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alta_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_tipo_producto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents cmb_marca As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents cmb_fecha_fabricacion As DateTimePicker
    Friend WithEvents txt_cod_producto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
End Class
