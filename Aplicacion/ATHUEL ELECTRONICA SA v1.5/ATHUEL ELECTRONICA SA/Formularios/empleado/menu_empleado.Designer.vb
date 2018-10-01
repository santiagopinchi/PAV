<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_empleado
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
        Me.dgv_01 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgv_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'atras
        '
        Me.atras.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Fleche_Gauche
        Me.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atras.Location = New System.Drawing.Point(28, 178)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(88, 84)
        Me.atras.TabIndex = 0
        Me.atras.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(12, 147)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(239, 28)
        Me.borrar.TabIndex = 6
        Me.borrar.Text = "Eliminar Empleado."
        '
        'insertar
        '
        Me.insertar.AutoSize = True
        Me.insertar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(12, 42)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(225, 28)
        Me.insertar.TabIndex = 4
        Me.insertar.Text = "Cargar Empleado."
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(12, 95)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(252, 28)
        Me.modificar.TabIndex = 5
        Me.modificar.Text = "Modificar Empleado."
        '
        'dgv_01
        '
        Me.dgv_01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_01.Location = New System.Drawing.Point(270, 12)
        Me.dgv_01.Name = "dgv_01"
        Me.dgv_01.Size = New System.Drawing.Size(1034, 248)
        Me.dgv_01.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Crear Usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 42)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Menu Ciudad"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'menu_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1336, 272)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_01)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.modificar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_empleado"
        Me.Text = "Menú empleados."
        CType(Me.dgv_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents atras As Button
    Friend WithEvents borrar As Label
    Friend WithEvents insertar As Label
    Friend WithEvents modificar As Label
    Friend WithEvents dgv_01 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
