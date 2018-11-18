<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrar_puesto_trabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borrar_puesto_trabajo))
        Me.cancelar = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.Color.Transparent
        Me.cancelar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Symbols_Delete_icon3
        Me.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancelar.Location = New System.Drawing.Point(309, 291)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(60, 60)
        Me.cancelar.TabIndex = 2
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'borrar
        '
        Me.borrar.BackColor = System.Drawing.Color.Transparent
        Me.borrar.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.basura
        Me.borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.borrar.Location = New System.Drawing.Point(164, 291)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(60, 60)
        Me.borrar.TabIndex = 1
        Me.borrar.UseVisualStyleBackColor = False
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(42, 12)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(464, 267)
        Me.dgv_vista.TabIndex = 0
        '
        'Borrar_puesto_trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(529, 363)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Borrar_puesto_trabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrar Puesto Trabajo"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cancelar As Button
    Friend WithEvents borrar As Button
    Friend WithEvents dgv_vista As DataGridView
End Class
