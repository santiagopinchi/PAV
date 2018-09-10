<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_puestos = New System.Windows.Forms.Button()
        Me.btn_estadisticas = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.btn_proveedores = New System.Windows.Forms.Button()
        Me.btn_empleados = New System.Windows.Forms.Button()
        Me.btn_turnos = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AMBUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_puestos)
        Me.Panel1.Controls.Add(Me.btn_estadisticas)
        Me.Panel1.Controls.Add(Me.btn_productos)
        Me.Panel1.Controls.Add(Me.btn_proveedores)
        Me.Panel1.Controls.Add(Me.btn_empleados)
        Me.Panel1.Controls.Add(Me.btn_turnos)
        Me.Panel1.Location = New System.Drawing.Point(77, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 493)
        Me.Panel1.TabIndex = 12
        '
        'btn_puestos
        '
        Me.btn_puestos.BackColor = System.Drawing.Color.Transparent
        Me.btn_puestos.BackgroundImage = CType(resources.GetObject("btn_puestos.BackgroundImage"), System.Drawing.Image)
        Me.btn_puestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_puestos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_puestos.FlatAppearance.BorderSize = 0
        Me.btn_puestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_puestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_puestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_puestos.Location = New System.Drawing.Point(77, 276)
        Me.btn_puestos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_puestos.Name = "btn_puestos"
        Me.btn_puestos.Size = New System.Drawing.Size(91, 98)
        Me.btn_puestos.TabIndex = 16
        Me.btn_puestos.UseVisualStyleBackColor = False
        '
        'btn_estadisticas
        '
        Me.btn_estadisticas.BackColor = System.Drawing.Color.Transparent
        Me.btn_estadisticas.BackgroundImage = CType(resources.GetObject("btn_estadisticas.BackgroundImage"), System.Drawing.Image)
        Me.btn_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_estadisticas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_estadisticas.FlatAppearance.BorderSize = 0
        Me.btn_estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estadisticas.Location = New System.Drawing.Point(232, 379)
        Me.btn_estadisticas.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_estadisticas.Name = "btn_estadisticas"
        Me.btn_estadisticas.Size = New System.Drawing.Size(83, 83)
        Me.btn_estadisticas.TabIndex = 15
        Me.btn_estadisticas.UseVisualStyleBackColor = False
        '
        'btn_productos
        '
        Me.btn_productos.BackColor = System.Drawing.Color.Transparent
        Me.btn_productos.BackgroundImage = CType(resources.GetObject("btn_productos.BackgroundImage"), System.Drawing.Image)
        Me.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_productos.FlatAppearance.BorderSize = 0
        Me.btn_productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_productos.Location = New System.Drawing.Point(384, 113)
        Me.btn_productos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(82, 89)
        Me.btn_productos.TabIndex = 14
        Me.btn_productos.UseVisualStyleBackColor = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BackColor = System.Drawing.Color.Transparent
        Me.btn_proveedores.BackgroundImage = CType(resources.GetObject("btn_proveedores.BackgroundImage"), System.Drawing.Image)
        Me.btn_proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_proveedores.FlatAppearance.BorderSize = 0
        Me.btn_proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proveedores.Location = New System.Drawing.Point(380, 282)
        Me.btn_proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(93, 107)
        Me.btn_proveedores.TabIndex = 13
        Me.btn_proveedores.UseVisualStyleBackColor = False
        '
        'btn_empleados
        '
        Me.btn_empleados.BackColor = System.Drawing.Color.Transparent
        Me.btn_empleados.BackgroundImage = CType(resources.GetObject("btn_empleados.BackgroundImage"), System.Drawing.Image)
        Me.btn_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_empleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_empleados.FlatAppearance.BorderSize = 0
        Me.btn_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_empleados.Location = New System.Drawing.Point(226, 14)
        Me.btn_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_empleados.Name = "btn_empleados"
        Me.btn_empleados.Size = New System.Drawing.Size(89, 98)
        Me.btn_empleados.TabIndex = 12
        Me.btn_empleados.UseVisualStyleBackColor = False
        '
        'btn_turnos
        '
        Me.btn_turnos.BackColor = System.Drawing.Color.Transparent
        Me.btn_turnos.BackgroundImage = CType(resources.GetObject("btn_turnos.BackgroundImage"), System.Drawing.Image)
        Me.btn_turnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_turnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_turnos.FlatAppearance.BorderSize = 0
        Me.btn_turnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_turnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_turnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_turnos.Location = New System.Drawing.Point(73, 101)
        Me.btn_turnos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_turnos.Name = "btn_turnos"
        Me.btn_turnos.Size = New System.Drawing.Size(95, 108)
        Me.btn_turnos.TabIndex = 11
        Me.btn_turnos.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(10, 10)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.AltaToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 130)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.AutoSize = False
        Me.UsuariosToolStripMenuItem.BackgroundImage = CType(resources.GetObject("UsuariosToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AMBUsuariosToolStripMenuItem, Me.ListadoUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(89, 138)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        Me.UsuariosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.AutoSize = False
        Me.AltaToolStripMenuItem.BackgroundImage = CType(resources.GetObject("AltaToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.AltaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(89, 138)
        Me.AltaToolStripMenuItem.Text = "Altas"
        Me.AltaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.AutoSize = False
        Me.ConsultarToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ConsultarToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ConsultarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(89, 138)
        Me.ConsultarToolStripMenuItem.Text = "Consultas"
        Me.ConsultarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.AutoSize = False
        Me.EliminarToolStripMenuItem.BackgroundImage = CType(resources.GetObject("EliminarToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(89, 138)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(235, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Empleados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(389, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Productos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(383, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Proveedores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(96, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Turnos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(95, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Puestos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(235, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Estadisticas"
        '
        'AMBUsuariosToolStripMenuItem
        '
        Me.AMBUsuariosToolStripMenuItem.Name = "AMBUsuariosToolStripMenuItem"
        Me.AMBUsuariosToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.AMBUsuariosToolStripMenuItem.Text = "AMB Usuarios"
        '
        'ListadoUsuariosToolStripMenuItem
        '
        Me.ListadoUsuariosToolStripMenuItem.Name = "ListadoUsuariosToolStripMenuItem"
        Me.ListadoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ListadoUsuariosToolStripMenuItem.Text = "Listado Usuarios"
        '
        'Menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(714, 664)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Menu_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_puestos As Button
    Friend WithEvents btn_estadisticas As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents btn_proveedores As Button
    Friend WithEvents btn_empleados As Button
    Friend WithEvents btn_turnos As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AMBUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoUsuariosToolStripMenuItem As ToolStripMenuItem
End Class
