Public Class reporte_tipos_producto
    Dim BD As New CONEXION_BD
    Private Sub reporte_tipo_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_codigo_tipo.Text = ""
        txt_nombre_tipo.Text = ""
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT * FROM tipos_productos"
        Dim tabla As New DataTable
        If txt_codigo_tipo.Text = "" Then
            sql &= " WHERE nombre like '%" & txt_nombre_tipo.Text & "%'"
        Else
            sql &= " WHERE codTipoProd = '" & txt_codigo_tipo.Text & "'"
            If txt_nombre_tipo.Text <> "" Then
                sql &= " AND nombre like '%" & txt_nombre_tipo.Text & "%'"
            End If
        End If
        tabla = BD.leo_tabla(sql)
        listado_tipoProductoBindingSource.DataSource = tabla
        Me.rv1.RefreshReport()
    End Sub
End Class