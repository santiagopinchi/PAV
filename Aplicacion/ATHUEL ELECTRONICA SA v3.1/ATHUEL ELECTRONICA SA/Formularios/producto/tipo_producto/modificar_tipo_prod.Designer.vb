<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_tipo_prod
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
        Me.txt_garantia = New System.Windows.Forms.MaskedTextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codigo_tipo_prod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_garantia
        '
        Me.txt_garantia.Location = New System.Drawing.Point(408, 58)
        Me.txt_garantia.Mask = "999999"
        Me.txt_garantia.Name = "txt_garantia"
        Me.txt_garantia.Size = New System.Drawing.Size(40, 20)
        Me.txt_garantia.TabIndex = 2
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(86, 99)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(362, 97)
        Me.txt_descripcion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(316, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Garantia (meses)"
        '
        'txt_codigo_tipo_prod
        '
        Me.txt_codigo_tipo_prod.Location = New System.Drawing.Point(86, 17)
        Me.txt_codigo_tipo_prod.Name = "txt_codigo_tipo_prod"
        Me.txt_codigo_tipo_prod.Size = New System.Drawing.Size(111, 20)
        Me.txt_codigo_tipo_prod.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(34, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Codigo"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(86, 58)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(192, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(34, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Nombre"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(373, 236)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(86, 236)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(512, 17)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(372, 211)
        Me.dgv_vista.TabIndex = 4
        '
        'modificar_tipo_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 288)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.txt_garantia)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_codigo_tipo_prod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "modificar_tipo_prod"
        Me.Text = "modificar_tipo_prod"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_garantia As MaskedTextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_codigo_tipo_prod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents dgv_vista As DataGridView
End Class
