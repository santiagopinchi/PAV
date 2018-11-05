<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificar_proveedor))
        Me.txt_tipo_proveedor = New System.Windows.Forms.MaskedTextBox()
        Me.button_cancelar = New System.Windows.Forms.Button()
        Me.button_confirmar = New System.Windows.Forms.Button()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.txt_cuit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        Me.txt_fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_tipo_proveedor
        '
        Me.txt_tipo_proveedor.Location = New System.Drawing.Point(128, 125)
        Me.txt_tipo_proveedor.Mask = "L"
        Me.txt_tipo_proveedor.Name = "txt_tipo_proveedor"
        Me.txt_tipo_proveedor.Size = New System.Drawing.Size(15, 20)
        Me.txt_tipo_proveedor.TabIndex = 4
        '
        'button_cancelar
        '
        Me.button_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.button_cancelar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Symbols_Delete_icon2
        Me.button_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_cancelar.Location = New System.Drawing.Point(155, 210)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(60, 60)
        Me.button_cancelar.TabIndex = 6
        Me.button_cancelar.UseVisualStyleBackColor = False
        '
        'button_confirmar
        '
        Me.button_confirmar.BackColor = System.Drawing.Color.Transparent
        Me.button_confirmar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.guardar
        Me.button_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_confirmar.Location = New System.Drawing.Point(43, 210)
        Me.button_confirmar.Name = "button_confirmar"
        Me.button_confirmar.Size = New System.Drawing.Size(60, 60)
        Me.button_confirmar.TabIndex = 5
        Me.button_confirmar.UseVisualStyleBackColor = False
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(128, 65)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(100, 20)
        Me.txt_razon_social.TabIndex = 2
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(128, 35)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(100, 20)
        Me.txt_cuit.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tipo Proveedor (N/E)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Inicio Actividad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Razón Social: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CUIT:"
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(254, 34)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(467, 236)
        Me.dgv_vista.TabIndex = 0
        '
        'txt_fecha_inicio
        '
        Me.txt_fecha_inicio.Checked = False
        Me.txt_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_inicio.Location = New System.Drawing.Point(128, 92)
        Me.txt_fecha_inicio.Name = "txt_fecha_inicio"
        Me.txt_fecha_inicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_inicio.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(251, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 13)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Hacer doble clic sobre alguna fila de la grilla."
        '
        'modificar_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 283)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_fecha_inicio)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.txt_tipo_proveedor)
        Me.Controls.Add(Me.button_cancelar)
        Me.Controls.Add(Me.button_confirmar)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modificar_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Proveedor"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_tipo_proveedor As MaskedTextBox
    Friend WithEvents button_cancelar As Button
    Friend WithEvents button_confirmar As Button
    Friend WithEvents txt_razon_social As TextBox
    Friend WithEvents txt_cuit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_vista As DataGridView
    Friend WithEvents txt_fecha_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As Label
End Class
