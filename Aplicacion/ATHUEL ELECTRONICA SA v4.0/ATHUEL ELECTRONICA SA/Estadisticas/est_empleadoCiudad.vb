Public Class est_empleadoCiudad
    Dim _BD As New CONEXION_BD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tabla As New DataTable
        Dim sql As String = "select ciudad.nombre as nombre, count(*) as cantidad from empleado, ciudad, barrio
where barrio.codBarrio  = empleado.codBarrio and barrio.codCiudad = ciudad.codCiudad 
group by ciudad.nombre"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class