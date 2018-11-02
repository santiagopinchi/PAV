<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class composicion_producto
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 37)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Consultar Manual."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 37)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cargar Manual."
        '
        'atras
        '
        Me.atras.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Fleche_Gauche
        Me.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atras.Location = New System.Drawing.Point(12, 215)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(74, 74)
        Me.atras.TabIndex = 11
        Me.atras.UseVisualStyleBackColor = True
        '
        'composicion_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(411, 301)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "composicion_producto"
        Me.Text = "Menu Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents atras As System.Windows.Forms.Button
End Class
