<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alta_ciudad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alta_ciudad))
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(80, 46)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(192, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(28, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Nombre"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = CType(resources.GetObject("btn_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(199, 84)
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
        Me.btn_agregar.Location = New System.Drawing.Point(88, 84)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(62, 63)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'alta_ciudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(333, 173)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_agregar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alta_ciudad"
        Me.Text = "alta_ciudad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label2 As Label
End Class
