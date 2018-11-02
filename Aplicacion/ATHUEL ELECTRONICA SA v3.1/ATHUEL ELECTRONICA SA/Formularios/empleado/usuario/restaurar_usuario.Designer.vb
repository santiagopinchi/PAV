<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restaurar_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(restaurar_usuario))
        Me.lbl_pregutna = New System.Windows.Forms.Label()
        Me.txt_respuesta = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_pregutna
        '
        Me.lbl_pregutna.AutoSize = True
        Me.lbl_pregutna.Location = New System.Drawing.Point(230, 86)
        Me.lbl_pregutna.Name = "lbl_pregutna"
        Me.lbl_pregutna.Size = New System.Drawing.Size(65, 13)
        Me.lbl_pregutna.TabIndex = 1
        Me.lbl_pregutna.Text = "lbl_pregutna"
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(207, 111)
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.Size = New System.Drawing.Size(136, 20)
        Me.txt_respuesta.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Respuesta:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(245, 177)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(62, 63)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Transparent
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(95, 177)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(62, 63)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 94)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'restaurar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 262)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_respuesta)
        Me.Controls.Add(Me.lbl_pregutna)
        Me.Name = "restaurar_usuario"
        Me.Text = "restaurar_usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_pregutna As System.Windows.Forms.Label
    Friend WithEvents txt_respuesta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
