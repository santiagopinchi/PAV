Public Class est_empleadoJefe
    Dim _BD As New CONEXION_BD

    Private Sub est_empleadoJefe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select j.apellido as nombre, count(*) as cantidad from empleado e, empleado j, empleadoXpuesto ep
where ep.legajo = e.legajo and ep.legajoJefe = j.legajo
group by j.apellido"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class