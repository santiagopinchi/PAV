<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_contacto
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
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.buscar_dni = New System.Windows.Forms.Button()
        Me.buscar_pellido_nombre = New System.Windows.Forms.Button()
        Me.btn_blanquear = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(23, 149)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(392, 20)
        Me.txt_email.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "E-mail"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Teléfono"
        '
        'txt_nro_doc
        '
        Me.txt_nro_doc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_nro_doc.Location = New System.Drawing.Point(133, 46)
        Me.txt_nro_doc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nro_doc.Mask = "99999999"
        Me.txt_nro_doc.Name = "txt_nro_doc"
        Me.txt_nro_doc.Size = New System.Drawing.Size(101, 20)
        Me.txt_nro_doc.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(205, 95)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(203, 20)
        Me.txt_nombre.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "N° Doc."
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(23, 95)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(148, 20)
        Me.txt_apellido.TabIndex = 3
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(23, 46)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(88, 21)
        Me.cmb_tipo_doc.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(202, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Tipo Doc.:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(486, 19)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(623, 272)
        Me.dgv.TabIndex = 10
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(36, 246)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 8
        Me.btn_modificar.Text = "Confirmar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(205, 246)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(23, 203)
        Me.txt_telefono.Mask = "9999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(88, 20)
        Me.txt_telefono.TabIndex = 7
        '
        'buscar_dni
        '
        Me.buscar_dni.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.user_magnify_47867
        Me.buscar_dni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buscar_dni.Location = New System.Drawing.Point(259, 38)
        Me.buscar_dni.Name = "buscar_dni"
        Me.buscar_dni.Size = New System.Drawing.Size(39, 35)
        Me.buscar_dni.TabIndex = 2
        Me.buscar_dni.UseVisualStyleBackColor = True
        '
        'buscar_pellido_nombre
        '
        Me.buscar_pellido_nombre.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.user_magnify_47867
        Me.buscar_pellido_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buscar_pellido_nombre.Location = New System.Drawing.Point(429, 80)
        Me.buscar_pellido_nombre.Name = "buscar_pellido_nombre"
        Me.buscar_pellido_nombre.Size = New System.Drawing.Size(39, 35)
        Me.buscar_pellido_nombre.TabIndex = 5
        Me.buscar_pellido_nombre.UseVisualStyleBackColor = True
        '
        'btn_blanquear
        '
        Me.btn_blanquear.Location = New System.Drawing.Point(395, 246)
        Me.btn_blanquear.Name = "btn_blanquear"
        Me.btn_blanquear.Size = New System.Drawing.Size(73, 23)
        Me.btn_blanquear.TabIndex = 89
        Me.btn_blanquear.Text = "Blanquear "
        Me.btn_blanquear.UseVisualStyleBackColor = True
        '
        'modificar_contacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1130, 316)
        Me.Controls.Add(Me.btn_blanquear)
        Me.Controls.Add(Me.buscar_pellido_nombre)
        Me.Controls.Add(Me.buscar_dni)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txt_nro_doc)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.cmb_tipo_doc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modificar_contacto"
        Me.Text = "modificar_contacto"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Private WithEvents txt_nro_doc As MaskedTextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents cmb_tipo_doc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents buscar_dni As System.Windows.Forms.Button
    Friend WithEvents buscar_pellido_nombre As System.Windows.Forms.Button
    Friend WithEvents btn_blanquear As System.Windows.Forms.Button
End Class
