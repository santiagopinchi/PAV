﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_contacto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_contacto))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.borrar = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Label()
        Me.modificar = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(342, 13)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(535, 233)
        Me.dgv.TabIndex = 0
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.BackColor = System.Drawing.Color.Transparent
        Me.borrar.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(12, 127)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(257, 26)
        Me.borrar.TabIndex = 2
        Me.borrar.Text = "Eliminar Contacto"
        '
        'insertar
        '
        Me.insertar.AutoSize = True
        Me.insertar.BackColor = System.Drawing.Color.Transparent
        Me.insertar.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(12, 25)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(246, 26)
        Me.insertar.TabIndex = 0
        Me.insertar.Text = "Cargar Contacto"
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.BackColor = System.Drawing.Color.Transparent
        Me.modificar.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(12, 76)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(278, 26)
        Me.modificar.TabIndex = 1
        Me.modificar.Text = "Modificar Contacto"
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.Color.Transparent
        Me.atras.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Undo_Icon
        Me.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atras.Location = New System.Drawing.Point(17, 186)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(60, 60)
        Me.atras.TabIndex = 3
        Me.atras.UseVisualStyleBackColor = False
        '
        'menu_contacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 264)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.modificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_contacto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Contacto"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents atras As Button
    Friend WithEvents borrar As Label
    Friend WithEvents insertar As Label
    Friend WithEvents modificar As Label
End Class
