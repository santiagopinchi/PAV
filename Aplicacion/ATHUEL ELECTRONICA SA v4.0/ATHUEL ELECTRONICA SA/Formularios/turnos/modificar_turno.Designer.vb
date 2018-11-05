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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificar_turno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_hora_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora_fin = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(27, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hora Fin"
        '
        'txt_hora_inicio
        '
        Me.txt_hora_inicio.Location = New System.Drawing.Point(107, 35)
        Me.txt_hora_inicio.Mask = "00:00"
        Me.txt_hora_inicio.Name = "txt_hora_inicio"
        Me.txt_hora_inicio.Size = New System.Drawing.Size(35, 20)
        Me.txt_hora_inicio.TabIndex = 1
        Me.txt_hora_inicio.ValidatingType = GetType(Date)
        '
        'txt_hora_fin
        '
        Me.txt_hora_fin.Location = New System.Drawing.Point(107, 63)
        Me.txt_hora_fin.Mask = "00:00"
        Me.txt_hora_fin.Name = "txt_hora_fin"
        Me.txt_hora_fin.Size = New System.Drawing.Size(35, 20)
        Me.txt_hora_fin.TabIndex = 2
        Me.txt_hora_fin.ValidatingType = GetType(Date)
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(193, 9)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(350, 175)
        Me.dgv_vista.TabIndex = 0
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.Transparent
        Me.btn_confirmar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.kisspng_chroma_key_check_mark_tilde_symbol_green_tick_5ac32c3e1d47702
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_confirmar.Location = New System.Drawing.Point(14, 124)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(60, 60)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Symbols_Delete_icon3
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.Location = New System.Drawing.Point(109, 124)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(60, 60)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'modificar_turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 199)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.txt_hora_fin)
        Me.Controls.Add(Me.txt_hora_inicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modificar_turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Turno"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_hora_inicio As MaskedTextBox
    Friend WithEvents txt_hora_fin As MaskedTextBox
    Friend WithEvents dgv_vista As DataGridView
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_cancelar As Button
End Class
