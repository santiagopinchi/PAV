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
        Me.txt_tipo_proveedor = New System.Windows.Forms.MaskedTextBox()
        Me.button_cancelar = New System.Windows.Forms.Button()
        Me.button_confirmar = New System.Windows.Forms.Button()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.txt_cuit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_tipo_proveedor
        '
        Me.txt_tipo_proveedor.Location = New System.Drawing.Point(128, 108)
        Me.txt_tipo_proveedor.Mask = "L"
        Me.txt_tipo_proveedor.Name = "txt_tipo_proveedor"
        Me.txt_tipo_proveedor.Size = New System.Drawing.Size(15, 20)
        Me.txt_tipo_proveedor.TabIndex = 13
        '
        'button_cancelar
        '
        Me.button_cancelar.Location = New System.Drawing.Point(153, 177)
        Me.button_cancelar.Name = "button_cancelar"
        Me.button_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.button_cancelar.TabIndex = 16
        Me.button_cancelar.Text = "Cancelar"
        Me.button_cancelar.UseVisualStyleBackColor = True
        '
        'button_confirmar
        '
        Me.button_confirmar.Location = New System.Drawing.Point(27, 177)
        Me.button_confirmar.Name = "button_confirmar"
        Me.button_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.button_confirmar.TabIndex = 15
        Me.button_confirmar.Text = "Confirmar"
        Me.button_confirmar.UseVisualStyleBackColor = True
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(128, 48)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(100, 20)
        Me.txt_razon_social.TabIndex = 9
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(128, 18)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(100, 20)
        Me.txt_cuit.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tipo Proveedor (N/E)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Inicio Act.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Razón Social: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CUIT:"
        '
        'txt_fecha_inicio
        '
        Me.txt_fecha_inicio.Location = New System.Drawing.Point(128, 78)
        Me.txt_fecha_inicio.Mask = "00/00/0000"
        Me.txt_fecha_inicio.Name = "txt_fecha_inicio"
        Me.txt_fecha_inicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha_inicio.TabIndex = 18
        Me.txt_fecha_inicio.ValidatingType = GetType(Date)
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(276, 12)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(435, 258)
        Me.dgv_vista.TabIndex = 19
        '
        'modificar_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 293)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.txt_fecha_inicio)
        Me.Controls.Add(Me.txt_tipo_proveedor)
        Me.Controls.Add(Me.button_cancelar)
        Me.Controls.Add(Me.button_confirmar)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "modificar_proveedor"
        Me.Text = "modificar_proveedor"
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
    Friend WithEvents txt_fecha_inicio As MaskedTextBox
    Friend WithEvents dgv_vista As DataGridView
End Class
