<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_turno
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_horaInicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_horaFin = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hora Fin"
        '
        'txt_horaInicio
        '
        Me.txt_horaInicio.Location = New System.Drawing.Point(107, 35)
        Me.txt_horaInicio.Mask = "00:00"
        Me.txt_horaInicio.Name = "txt_horaInicio"
        Me.txt_horaInicio.Size = New System.Drawing.Size(35, 20)
        Me.txt_horaInicio.TabIndex = 1
        Me.txt_horaInicio.ValidatingType = GetType(Date)
        '
        'txt_horaFin
        '
        Me.txt_horaFin.Location = New System.Drawing.Point(107, 63)
        Me.txt_horaFin.Mask = "00:00"
        Me.txt_horaFin.Name = "txt_horaFin"
        Me.txt_horaFin.Size = New System.Drawing.Size(35, 20)
        Me.txt_horaFin.TabIndex = 1
        Me.txt_horaFin.ValidatingType = GetType(Date)
        '
        'dgv_vista
        '
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(226, 12)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.Size = New System.Drawing.Size(196, 150)
        Me.dgv_vista.TabIndex = 2
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(30, 139)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(129, 139)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'modificar_turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 180)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.txt_horaFin)
        Me.Controls.Add(Me.txt_horaInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "modificar_turno"
        Me.Text = "modificar_turno"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_horaInicio As MaskedTextBox
    Friend WithEvents txt_horaFin As MaskedTextBox
    Friend WithEvents dgv_vista As DataGridView
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_cancelar As Button
End Class
