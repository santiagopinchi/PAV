<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alta_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alta_usuario))
        Me.txt_legajo = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pregunta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_respuesta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_legajo
        '
        Me.txt_legajo.Location = New System.Drawing.Point(271, 12)
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.Size = New System.Drawing.Size(85, 20)
        Me.txt_legajo.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(271, 35)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(148, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(271, 61)
        Me.txt_password.Mask = "CCCCCCCC"
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(85, 20)
        Me.txt_password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(204, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(169, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(226, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Legajo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(23, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 94)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(294, 148)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(62, 63)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Transparent
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_agregar.Location = New System.Drawing.Point(152, 148)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(62, 63)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(145, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pregunta de Seguridad ¿"
        '
        'txt_pregunta
        '
        Me.txt_pregunta.Location = New System.Drawing.Point(271, 87)
        Me.txt_pregunta.Name = "txt_pregunta"
        Me.txt_pregunta.Size = New System.Drawing.Size(148, 20)
        Me.txt_pregunta.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(204, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Respuesta."
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(271, 113)
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.Size = New System.Drawing.Size(148, 20)
        Me.txt_respuesta.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(425, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "?"
        '
        'alta_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 218)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_respuesta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_pregunta)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_legajo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alta_usuario"
        Me.Text = "Alta de Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_legajo As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_password As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_pregunta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_respuesta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
