<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_turno
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
        Me.atras = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Label()
        Me.modificar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'atras
        '
        Me.atras.Image = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Sin_título
        Me.atras.Location = New System.Drawing.Point(40, 201)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(143, 45)
        Me.atras.TabIndex = 0
        Me.atras.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(33, 128)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(254, 37)
        Me.borrar.TabIndex = 6
        Me.borrar.Text = "Eliminar Turno."
        '
        'insertar
        '
        Me.insertar.AutoSize = True
        Me.insertar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(33, 18)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(236, 37)
        Me.insertar.TabIndex = 4
        Me.insertar.Text = "Cargar Turno."
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(33, 72)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(273, 37)
        Me.modificar.TabIndex = 5
        Me.modificar.Text = "Modificar Turno."
        '
        'menu_turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 266)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.modificar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_turno"
        Me.Text = "Menú turno."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents atras As Button
    Friend WithEvents borrar As Label
    Friend WithEvents insertar As Label
    Friend WithEvents modificar As Label
End Class
