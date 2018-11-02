<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_marca
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
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        Me.atras = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Label()
        Me.modificar = New System.Windows.Forms.Label()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(346, 24)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(496, 323)
        Me.dgv_vista.TabIndex = 6
        '
        'atras
        '
        Me.atras.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Fleche_Gauche
        Me.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atras.Location = New System.Drawing.Point(8, 273)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(74, 74)
        Me.atras.TabIndex = 10
        Me.atras.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(6, 165)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(261, 37)
        Me.borrar.TabIndex = 9
        Me.borrar.Text = "Eliminar Marca."
        '
        'insertar
        '
        Me.insertar.AutoSize = True
        Me.insertar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(15, 59)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(243, 37)
        Me.insertar.TabIndex = 7
        Me.insertar.Text = "Cargar Marca."
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(6, 112)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(280, 37)
        Me.modificar.TabIndex = 8
        Me.modificar.Text = "Modificar Marca."
        '
        'menu_marca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(851, 365)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.modificar)
        Me.Name = "menu_marca"
        Me.Text = "menu_marca"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_vista As DataGridView
    Friend WithEvents atras As Button
    Friend WithEvents borrar As Label
    Friend WithEvents insertar As Label
    Friend WithEvents modificar As Label
End Class
