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
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora Fin"
        '
        'cancelar
        '
        Me.cancelar.BackgroundImage = CType(resources.GetObject("cancelar.BackgroundImage"), System.Drawing.Image)
        Me.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelar.Location = New System.Drawing.Point(202, 108)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(62, 63)
        Me.cancelar.TabIndex = 83
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.Color.Transparent
        Me.guardar.BackgroundImage = CType(resources.GetObject("guardar.BackgroundImage"), System.Drawing.Image)
        Me.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.guardar.Location = New System.Drawing.Point(91, 108)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(62, 63)
        Me.guardar.TabIndex = 82
        Me.guardar.UseVisualStyleBackColor = False
        '
        'txt_hora_inicio
        '
        Me.txt_hora_inicio.Location = New System.Drawing.Point(91, 44)
        Me.txt_hora_inicio.Mask = "00:00"
        Me.txt_hora_inicio.Name = "txt_hora_inicio"
        Me.txt_hora_inicio.Size = New System.Drawing.Size(35, 20)
        Me.txt_hora_inicio.TabIndex = 84
        Me.txt_hora_inicio.ValidatingType = GetType(Date)
        '
        'txt_hora_fin
        '
        Me.txt_hora_fin.Location = New System.Drawing.Point(91, 74)
        Me.txt_hora_fin.Mask = "00:00"
        Me.txt_hora_fin.Name = "txt_hora_fin"
        Me.txt_hora_fin.Size = New System.Drawing.Size(35, 20)
        Me.txt_hora_fin.TabIndex = 84
        Me.txt_hora_fin.ValidatingType = GetType(Date)
        '
        'alta_turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 183)
        Me.Controls.Add(Me.txt_hora_fin)
        Me.Controls.Add(Me.txt_hora_inicio)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alta_turno"
        Me.Text = "alta_turno"
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
