<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.txt_password = New System.Windows.Forms.MaskedTextBox()
        Me.restaurar = New System.Windows.Forms.LinkLabel()
        Me.modificar = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(385, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 55)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(181, 119)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(276, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(19, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 152)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(222, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(246, 62)
        Me.txt_usuario.Mask = "CCCCCCCCCCCCCCCCCCCC"
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(147, 20)
        Me.txt_usuario.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(246, 121)
        Me.txt_password.Mask = "CCCCCCCCCCCC"
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(147, 20)
        Me.txt_password.TabIndex = 1
        '
        'restaurar
        '
        Me.restaurar.ActiveLinkColor = System.Drawing.Color.Black
        Me.restaurar.AutoSize = True
        Me.restaurar.BackColor = System.Drawing.Color.White
        Me.restaurar.LinkColor = System.Drawing.Color.Black
        Me.restaurar.Location = New System.Drawing.Point(383, 102)
        Me.restaurar.Name = "restaurar"
        Me.restaurar.Size = New System.Drawing.Size(129, 13)
        Me.restaurar.TabIndex = 4
        Me.restaurar.TabStop = True
        Me.restaurar.Text = "¿olvidaste tu contraseña?"
        Me.restaurar.VisitedLinkColor = System.Drawing.Color.Black
        '
        'modificar
        '
        Me.modificar.ActiveLinkColor = System.Drawing.Color.Black
        Me.modificar.AutoSize = True
        Me.modificar.BackColor = System.Drawing.Color.White
        Me.modificar.LinkColor = System.Drawing.Color.Black
        Me.modificar.Location = New System.Drawing.Point(397, 83)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(100, 13)
        Me.modificar.TabIndex = 5
        Me.modificar.TabStop = True
        Me.modificar.Text = "cambiar contraseña"
        Me.modificar.VisitedLinkColor = System.Drawing.Color.Black
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 252)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.restaurar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As MaskedTextBox
    Friend WithEvents txt_password As MaskedTextBox
    Friend WithEvents restaurar As System.Windows.Forms.LinkLabel
    Friend WithEvents modificar As System.Windows.Forms.LinkLabel
End Class
