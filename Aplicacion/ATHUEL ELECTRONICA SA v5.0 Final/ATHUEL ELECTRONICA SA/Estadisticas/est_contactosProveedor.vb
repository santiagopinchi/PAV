Public Class est_contactosProveedor
    Dim _BD As New CONEXION_BD
    Private Sub est_contactosProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable
        Dim sql As String = "select p.razonSocial as nombre, count(*) as cantidad from productoXproveedor pxp, proveedor p, contacto c
where p.cuit = pxp.cuit and pxp.codTipodocCont = c.codTipodoc and pxp.numeroDocumentoCont = c.numeroDocumento 
group by p.razonSocial"

        tabla = _BD.leo_tabla(sql)
        estadisticaBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class