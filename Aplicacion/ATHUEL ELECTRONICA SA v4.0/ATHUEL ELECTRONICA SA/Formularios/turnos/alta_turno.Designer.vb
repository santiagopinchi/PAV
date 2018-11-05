<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alta_turno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alta_turno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.txt_hora_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora_fin = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(191, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora Fin"
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.Color.Transparent
        Me.cancelar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Symbols_Delete_icon3
        Me.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelar.Location = New System.Drawing.Point(220, 78)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(60, 60)
        Me.cancelar.TabIndex = 3
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.Color.Transparent
        Me.guardar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.kisspng_chroma_key_check_mark_tilde_symbol_green_tick_5ac32c3e1d47701
        Me.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.guardar.Location = New System.Drawing.Point(101, 78)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(60, 60)
        Me.guardar.TabIndex = 2
        Me.guardar.UseVisualStyleBackColor = False
        '
        'txt_hora_inicio
        '
        Me.txt_hora_inicio.Location = New System.Drawing.Point(101, 24)
        Me.txt_hora_inicio.Mask = "00:00"
        Me.txt_hora_inicio.Name = "txt_hora_inicio"
        Me.txt_hora_inicio.Size = New System.Drawing.Size(35, 20)
        Me.txt_hora_inicio.TabIndex = 0
        Me.txt_hora_inicio.ValidatingType = GetType(Date)
        '
        'txt_hora_fin
        '
        Me.txt_hora_fin.Location = New System.Drawing.Point(242, 24)
        Me.txt_hora_fin.Mask = "00:00"
        Me.txt_hora_fin.Name = "txt_hora_fin"
        Me.txt_hora_fin.Size = New System.Drawing.Size(35, 20)
        Me.txt_hora_fin.TabIndex = 1
        Me.txt_hora_fin.ValidatingType = GetType(Date)
        '
        'alta_turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(369, 162)
        Me.Controls.Add(Me.txt_hora_fin)
        Me.Controls.Add(Me.txt_hora_inicio)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alta_turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cancelar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents txt_hora_inicio As MaskedTextBox
    Friend WithEvents txt_hora_fin As MaskedTextBox
End Class
