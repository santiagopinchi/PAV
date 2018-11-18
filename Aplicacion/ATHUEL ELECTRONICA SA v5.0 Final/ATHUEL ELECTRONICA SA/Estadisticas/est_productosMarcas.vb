Public Class est_productosMarcas
    Dim _BD As New CONEXION_BD

    Private Sub est_productosMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select marca.nombre as nombre, count(*) as cantidad from marca,producto 
where marca.codmarca = producto.codmarca 
group by marca.nombre"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class