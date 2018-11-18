Public Class est_productosTipos
    Dim _BD As New CONEXION_BD

    Private Sub est_productosTipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select tipos_productos.nombre as nombre, count(*) as cantidad from tipos_productos,producto 
where tipos_productos.codTipoProd = producto.codTipoProd 
group by tipos_productos.nombre"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class