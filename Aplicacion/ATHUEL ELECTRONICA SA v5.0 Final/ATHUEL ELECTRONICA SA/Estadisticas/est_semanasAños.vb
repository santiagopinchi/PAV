Public Class est_semanasAños
    Dim _BD As New CONEXION_BD
    Private Sub est_semanasAños_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select p.año as nombre, count(*) as cantidad from planificacion p
group by p.año"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class