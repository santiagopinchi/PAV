<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class alta_proveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alta_proveedor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.button_confirmar = New System.Windows.Forms.Button()
        Me.button_cancelar = New System.Windows.Forms.Button()
        Me.txt_tipo_proveedor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cuit = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUIT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Razón Social: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Inicio Actividad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo Proveedor (N/E)"
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(131, 68)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(198, 20)
        Me.txt_razon_social.TabIndex = 1
        '
        'button_confirmar
        '
        Me.button_confirmar.BackColor = System.Drawing.Color.Transparent
        Me.button_confirmar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.kisspng_chroma_key_check_mark_tilde_symbol_green_tick_5ac32c3e1d47701
        Me.button_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_confirmar.Location = New System.Drawing.Point(116, 205)
        Me.button_confirmar.Name = "button_confirmar"
        Me.button_confirmar.Size = New System.Drawing.Size(60, 60)
        Me.button_confirmar.TabIndex = 4
        Me.button_confirmar.UseVisualStyleBackColor = False
        '
        'button_cancelar
        '
        Me.button_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.button_cancelar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Symbols_Delete_icon2
        Me.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_cancelar.Location = New System.Drawing.Point(218, 205)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(60, 60)
        Me.button_cancelar.TabIndex = 5
        Me.button_cancelar.UseVisualStyleBackColor = False
        '
        'txt_tipo_proveedor
        '
        Me.txt_tipo_proveedor.Location = New System.Drawing.Point(131, 155)
        Me.txt_tipo_proveedor.Mask = "L"
        Me.txt_tipo_proveedor.Name = "txt_tipo_proveedor"
        Me.txt_tipo_proveedor.Size = New System.Drawing.Size(15, 20)
        Me.txt_tipo_proveedor.TabIndex = 3
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(131, 23)
        Me.txt_cuit.Mask = "99999999999"
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(100, 20)
        Me.txt_cuit.TabIndex = 0
        '
        'txt_fecha_inicio
        '
        Me.txt_fecha_inicio.Checked = False
        Me.txt_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_inicio.Location = New System.Drawing.Point(131, 111)
        Me.txt_fecha_inicio.Name = "txt_fecha_inicio"
        Me.txt_fecha_inicio.Size = New System.Drawing.Size(87, 20)
        Me.txt_fecha_inicio.TabIndex = 2
        '
        'alta_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(394, 286)
        Me.Controls.Add(Me.txt_fecha_inicio)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.txt_tipo_proveedor)
        Me.Controls.Add(Me.button_cancelar)
        Me.Controls.Add(Me.button_confirmar)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alta_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_razon_social As TextBox
    Friend WithEvents button_confirmar As Button
    Friend WithEvents button_cancelar As Button
    Friend WithEvents txt_tipo_proveedor As MaskedTextBox
    Friend WithEvents txt_cuit As MaskedTextBox
    Friend WithEvents txt_fecha_inicio As System.Windows.Forms.DateTimePicker
End Class
