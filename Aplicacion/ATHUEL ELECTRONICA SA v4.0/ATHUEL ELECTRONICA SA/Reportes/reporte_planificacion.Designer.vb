<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_planificacion
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
        Me.listado_planificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New ATHUEL_ELECTRONICA_SA.DataSet1()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.rv1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_info = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.listado_planificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listado_planificacionBindingSource
        '
        Me.listado_planificacionBindingSource.DataMember = "listado_planificacion"
        Me.listado_planificacionBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(218, 18)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 14
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'rv1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.listado_planificacionBindingSource
        Me.rv1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv1.LocalReport.ReportEmbeddedResource = "ATHUEL_ELECTRONICA_SA.ReportePlanificaciones.rdlc"
        Me.rv1.Location = New System.Drawing.Point(10, 53)
        Me.rv1.Name = "rv1"
        Me.rv1.Size = New System.Drawing.Size(799, 426)
        Me.rv1.TabIndex = 11
        '
        'txt_info
        '
        Me.txt_info.Location = New System.Drawing.Point(96, 18)
        Me.txt_info.Name = "txt_info"
        Me.txt_info.Size = New System.Drawing.Size(103, 20)
        Me.txt_info.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Dato a Buscar:"
        '
        'reporte_planificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ATHUEL_ELECTRONICA_SA.My.Resources.Resources._66edbf7779c60bbdc43ad3061f8a7741
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 497)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.rv1)
        Me.Controls.Add(Me.txt_info)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reporte_planificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte: Planificaciones"
        CType(Me.listado_planificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscar As Button
    Friend WithEvents rv1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt_info As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listado_planificacionBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
End Class
