<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_ciudad
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
        Me.borrar = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Label()
        Me.modificar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(402, 27)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(496, 323)
        Me.dgv_vista.TabIndex = 0
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(62, 168)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(274, 37)
        Me.borrar.TabIndex = 3
        Me.borrar.Text = "Eliminar Ciudad."
        '
        'insertar
        '
        Me.insertar.AutoSize = True
        Me.insertar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(71, 62)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(256, 37)
        Me.insertar.TabIndex = 1
        Me.insertar.Text = "Cargar Ciudad."
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(62, 115)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(293, 37)
        Me.modificar.TabIndex = 2
        Me.modificar.Text = "Modificar Ciudad."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Barrios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'atras
        '
        Me.atras.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Fleche_Gauche
        Me.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atras.Location = New System.Drawing.Point(64, 276)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(74, 74)
        Me.atras.TabIndex = 4
        Me.atras.UseVisualStyleBackColor = True
        '
        'menu_ciudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(927, 379)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.modificar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_ciudad"
        Me.Text = "menu_ciudad"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_vista As DataGridView
    Friend WithEvents atras As Button
    Friend WithEvents borrar As Label
    Friend WithEvents insertar As Label
    Friend WithEvents modificar As Label
    Friend WithEvents Button1 As Button
End Class
