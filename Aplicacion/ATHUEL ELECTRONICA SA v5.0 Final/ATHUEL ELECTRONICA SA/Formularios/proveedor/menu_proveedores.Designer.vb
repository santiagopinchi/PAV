﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_proveedores))
        Me.modificar = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Label()
        Me.borrar = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        Me.dgv_vista = New System.Windows.Forms.DataGridView()
        Me.btn_contacto = New System.Windows.Forms.Button()
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.BackColor = System.Drawing.Color.Transparent
        Me.modificar.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(14, 79)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(288, 26)
        Me.modificar.TabIndex = 2
        Me.modificar.Text = "Modificar Proveedor"
        '
        'insertar
        '
        Me.insertar.AutoSize = True
        Me.insertar.BackColor = System.Drawing.Color.Transparent
        Me.insertar.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(14, 29)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(256, 26)
        Me.insertar.TabIndex = 1
        Me.insertar.Text = "Cargar Proveedor"
        '
        'borrar
        '
        Me.borrar.AutoSize = True
        Me.borrar.BackColor = System.Drawing.Color.Transparent
        Me.borrar.Font = New System.Drawing.Font("Copperplate Gothic Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(14, 133)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(267, 26)
        Me.borrar.TabIndex = 3
        Me.borrar.Text = "Eliminar Proveedor"
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.Color.Transparent
        Me.atras.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources.Undo_Icon1
        Me.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atras.Location = New System.Drawing.Point(19, 258)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(58, 60)
        Me.atras.TabIndex = 4
        Me.atras.UseVisualStyleBackColor = False
        '
        'dgv_vista
        '
        Me.dgv_vista.AllowUserToAddRows = False
        Me.dgv_vista.AllowUserToDeleteRows = False
        Me.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vista.Location = New System.Drawing.Point(445, 12)
        Me.dgv_vista.Name = "dgv_vista"
        Me.dgv_vista.ReadOnly = True
        Me.dgv_vista.Size = New System.Drawing.Size(497, 306)
        Me.dgv_vista.TabIndex = 0
        '
        'btn_contacto
        '
        Me.btn_contacto.Location = New System.Drawing.Point(19, 183)
        Me.btn_contacto.Name = "btn_contacto"
        Me.btn_contacto.Size = New System.Drawing.Size(104, 35)
        Me.btn_contacto.TabIndex = 7
        Me.btn_contacto.Text = "Menú Contacto"
        Me.btn_contacto.UseVisualStyleBackColor = True
        '
        'menu_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._fondo_sistema
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(955, 331)
        Me.Controls.Add(Me.btn_contacto)
        Me.Controls.Add(Me.dgv_vista)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.modificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Proveedor"
        CType(Me.dgv_vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modificar As Label
    Friend WithEvents insertar As Label
    Friend WithEvents borrar As Label
    Friend WithEvents atras As Button
    Friend WithEvents dgv_vista As DataGridView
    Friend WithEvents btn_contacto As System.Windows.Forms.Button
End Class
