﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_producto
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.button_cancelar = New System.Windows.Forms.Button()
        Me.button_confirmar = New System.Windows.Forms.Button()
        Me.cmb_fecha_fabricacion = New System.Windows.Forms.DateTimePicker()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod_producto = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 191)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(1061, 335)
        Me.dgv.TabIndex = 21
        '
        'button_cancelar
        '
        Me.button_cancelar.Location = New System.Drawing.Point(998, 81)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.button_cancelar.TabIndex = 20
        Me.button_cancelar.Text = "Cancelar"
        Me.button_cancelar.UseVisualStyleBackColor = True
        '
        'button_confirmar
        '
        Me.button_confirmar.Location = New System.Drawing.Point(998, 47)
        Me.button_confirmar.Name = "button_confirmar"
        Me.button_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.button_confirmar.TabIndex = 19
        Me.button_confirmar.Text = "Guardar"
        Me.button_confirmar.UseVisualStyleBackColor = True
        '
        'cmb_fecha_fabricacion
        '
        Me.cmb_fecha_fabricacion.Checked = False
        Me.cmb_fecha_fabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fecha_fabricacion.Location = New System.Drawing.Point(480, 119)
        Me.cmb_fecha_fabricacion.Name = "cmb_fecha_fabricacion"
        Me.cmb_fecha_fabricacion.Size = New System.Drawing.Size(87, 20)
        Me.cmb_fecha_fabricacion.TabIndex = 31
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(661, 119)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(606, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Fecha de Fabricación:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(429, 84)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(385, 20)
        Me.txt_descripcion.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Descripción:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(606, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Modelo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(357, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Marca:"
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(661, 48)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(153, 20)
        Me.txt_modelo.TabIndex = 27
        '
        'cmb_marca
        '
        Me.cmb_marca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(403, 47)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(172, 21)
        Me.cmb_marca.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Código de Producto:"
        '
        'txt_cod_producto
        '
        Me.txt_cod_producto.Location = New System.Drawing.Point(175, 81)
        Me.txt_cod_producto.Name = "txt_cod_producto"
        Me.txt_cod_producto.Size = New System.Drawing.Size(126, 20)
        Me.txt_cod_producto.TabIndex = 37
        '
        'cmb_tipo_producto
        '
        Me.cmb_tipo_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto.FormattingEnabled = True
        Me.cmb_tipo_producto.Location = New System.Drawing.Point(169, 49)
        Me.cmb_tipo_producto.Name = "cmb_tipo_producto"
        Me.cmb_tipo_producto.Size = New System.Drawing.Size(136, 21)
        Me.cmb_tipo_producto.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Tipo de Producto:"
        '
        'modificar_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 538)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cod_producto)
        Me.Controls.Add(Me.cmb_tipo_producto)
        Me.Controls.Add(Me.cmb_fecha_fabricacion)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.cmb_marca)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.button_cancelar)
        Me.Controls.Add(Me.button_confirmar)
        Me.Name = "modificar_producto"
        Me.Text = "modificar_producto"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents button_cancelar As Button
    Friend WithEvents button_confirmar As Button
    Friend WithEvents cmb_fecha_fabricacion As DateTimePicker
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents cmb_marca As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cod_producto As TextBox
    Friend WithEvents cmb_tipo_producto As ComboBox
    Friend WithEvents Label1 As Label
End Class