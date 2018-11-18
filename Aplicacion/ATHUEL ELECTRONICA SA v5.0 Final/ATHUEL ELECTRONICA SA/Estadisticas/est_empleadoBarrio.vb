Public Class est_empleadoBarrio
    Dim _BD As New CONEXION_BD
    Private Sub est_empleadoBarrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select barrio.nombre as nombre, count(*) as cantidad from empleado, barrio
where empleado.codBarrio = barrio.codBarrio 
group by barrio.nombre"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class