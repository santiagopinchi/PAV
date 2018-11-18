Public Class est_proveedoresContactos
    Dim _BD As New CONEXION_BD

    Private Sub est_proveedoresContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select c.apellido as nombre, count(*) as cantidad from productoXproveedor pxp, proveedor p, contacto c
where p.cuit = pxp.cuit and pxp.codTipodocCont = c.codTipodoc and pxp.numeroDocumentoCont = c.numeroDocumento 
group by c.apellido"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class