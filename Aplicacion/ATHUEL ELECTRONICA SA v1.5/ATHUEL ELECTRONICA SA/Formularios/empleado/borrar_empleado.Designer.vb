<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class borrar_empleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgv_01 = New System.Windows.Forms.DataGridView()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.dgv_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_01
        '
        Me.dgv_01.AllowUserToAddRows = False
        Me.dgv_01.AllowUserToDeleteRows = False
        Me.dgv_01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_01.Location = New System.Drawing.Point(12, 12)
        Me.dgv_01.Name = "dgv_01"
        Me.dgv_01.ReadOnly = True
        Me.dgv_01.Size = New System.Drawing.Size(1366, 408)
        Me.dgv_01.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(714, 433)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(91, 39)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(419, 433)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(85, 37)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'borrar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1390, 495)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dgv_01)
        Me.Name = "borrar_empleado"
        Me.Text = "Borrar Empleado"
        CType(Me.dgv_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_01 As DataGridView
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_eliminar As Button
End Class
