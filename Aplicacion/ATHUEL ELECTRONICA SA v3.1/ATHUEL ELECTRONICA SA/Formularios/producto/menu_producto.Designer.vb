<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_producto
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btn_marca = New System.Windows.Forms.Button()
        Me.btn_tipo_prod = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'atras
        '
        Me.atras.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Fleche_Gauche
        Me.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atras.Location = New System.Drawing.Point(31, 171)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(74, 74)
        Me.atras.TabIndex = 4
        Me.atras.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(24, 121)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(305, 37)
        Me.borrar.TabIndex = 3
        Me.borrar.Text = "Eliminar Producto."
        '
        'insertar
        '
        Me.insertar.AutoSize = True
        Me.insertar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(24, 22)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(287, 37)
        Me.insertar.TabIndex = 1
        Me.insertar.Text = "Cargar Producto."
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(24, 73)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(324, 37)
        Me.modificar.TabIndex = 2
        Me.modificar.Text = "Modificar Producto."
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(354, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(801, 233)
        Me.dgv.TabIndex = 0
        '
        'btn_marca
        '
        Me.btn_marca.Location = New System.Drawing.Point(140, 171)
        Me.btn_marca.Name = "btn_marca"
        Me.btn_marca.Size = New System.Drawing.Size(79, 55)
        Me.btn_marca.TabIndex = 5
        Me.btn_marca.Text = "Marcas"
        Me.btn_marca.UseVisualStyleBackColor = True
        '
        'btn_tipo_prod
        '
        Me.btn_tipo_prod.Location = New System.Drawing.Point(250, 171)
        Me.btn_tipo_prod.Name = "btn_tipo_prod"
        Me.btn_tipo_prod.Size = New System.Drawing.Size(79, 55)
        Me.btn_tipo_prod.TabIndex = 5
        Me.btn_tipo_prod.Text = "Tipos de Productos"
        Me.btn_tipo_prod.UseVisualStyleBackColor = True
        '
        'menu_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1167, 271)
        Me.Controls.Add(Me.btn_tipo_prod)
        Me.Controls.Add(Me.btn_marca)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.modificar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_producto"
        Me.Text = "Menú producto."
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents atras As Button
    Friend WithEvents borrar As Label
    Friend WithEvents insertar As Label
    Friend WithEvents modificar As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btn_marca As Button
    Friend WithEvents btn_tipo_prod As Button
End Class
