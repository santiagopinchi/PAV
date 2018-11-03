Public Class est_empleadoPuesto
    Dim _BD As New CONEXION_BD

    Private Sub est_empleadoPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select p.nombre  as nombre, count(*) as cantidad from empleadoXpuesto ep, puestos_trabajo p
where p.codPuesto = ep.codPuesto 
group by p.nombre "

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class