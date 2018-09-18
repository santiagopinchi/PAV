<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_puesto_trabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificar_puesto_trabajo))
        Me.guardar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(33, 249)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(119, 29)
        Me.guardar.TabIndex = 3
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(192, 249)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(119, 29)
        Me.cancelar.TabIndex = 4
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "codigo"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(99, 67)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(33, 141)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(269, 41)
        Me.txt_descripcion.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(99, 93)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(386, 12)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(387, 296)
        Me.dgv_vista.TabIndex = 5
        '
        'modificar_puesto_trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(785, 335)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modificar_puesto_trabajo"
        Me.Text = "Modificar puesto de trabajo."
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guardar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents dgv_vista As DataGridView
End Class
