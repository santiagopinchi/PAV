<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_tipos_producto
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.listado_tipoProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New ATHUEL_ELECTRONICA_SA.DataSet1()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.rv1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_nombre_tipo = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codigo_tipo = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.listado_tipoProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listado_tipoProductoBindingSource
        '
        Me.listado_tipoProductoBindingSource.DataMember = "listado_tipoProducto"
        Me.listado_tipoProductoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(236, 23)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 14
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'rv1
        '
        Me.rv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.listado_tipoProductoBindingSource
        Me.rv1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv1.LocalReport.ReportEmbeddedResource = "ATHUEL_ELECTRONICA_SA.ReporteTiposProductos.rdlc"
        Me.rv1.Location = New System.Drawing.Point(10, 80)
        Me.rv1.Name = "rv1"
        Me.rv1.Size = New System.Drawing.Size(799, 426)
        Me.rv1.TabIndex = 11
        '
        'txt_nombre_tipo
        '
        Me.txt_nombre_tipo.Location = New System.Drawing.Point(107, 46)
        Me.txt_nombre_tipo.Name = "txt_nombre_tipo"
        Me.txt_nombre_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre_tipo.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(54, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre:"
        '
        'txt_codigo_tipo
        '
        Me.txt_codigo_tipo.Location = New System.Drawing.Point(107, 20)
        Me.txt_codigo_tipo.Name = "txt_codigo_tipo"
        Me.txt_codigo_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo_tipo.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.txt_codigo_tipo, "Recordar que el código del producto es alfanumérico.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Código Producto:"
        '
        'reporte_tipos_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 497)
        Me.Controls.Add(Me.txt_nombre_tipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_codigo_tipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.rv1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reporte_tipos_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte: Tipos de Productos"
        CType(Me.listado_tipoProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscar As Button
    Friend WithEvents rv1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents listado_tipoProductoBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents txt_nombre_tipo As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_codigo_tipo As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
