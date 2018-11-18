Public Class frm_menu_estadisticas_reportes
    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        reporte_ciudad.ShowDialog()
    End Sub

    Private Sub ContactosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactosToolStripMenuItem.Click
        reporte_contacto.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        reporte_empleado.ShowDialog()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        reporte_historial.ShowDialog()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        reporte_marca.ShowDialog()
    End Sub

    Private Sub PlanificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanificacionesToolStripMenuItem.Click
        reporte_planificacion.ShowDialog()
    End Sub

    Private Sub ProductosPorMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorMarcaToolStripMenuItem.Click
        reporte_producto_marca.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        reporte_proveedor.ShowDialog()
    End Sub

    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click
        reporte_puesto.ShowDialog()
    End Sub

    Private Sub TiposProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposProductosToolStripMenuItem.Click
        reporte_tipos_producto.ShowDialog()
    End Sub

    Private Sub ContactosPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactosPorProveedorToolStripMenuItem.Click
        est_contactosProveedor.ShowDialog()
    End Sub

    Private Sub EmpleadosPorBarrioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorBarrioToolStripMenuItem.Click
        est_empleadoBarrio.ShowDialog()
    End Sub

    Private Sub EmpleadosPorCiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorCiudadToolStripMenuItem.Click
        est_empleadoCiudad.ShowDialog()
    End Sub

    Private Sub EmpleadosPorJefeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorJefeToolStripMenuItem.Click
        est_empleadoJefe.ShowDialog()
    End Sub

    Private Sub EmpleadoPorPuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoPorPuestoToolStripMenuItem.Click
        est_empleadoPuesto.ShowDialog()
    End Sub

    Private Sub ProductosPorMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorMarcasToolStripMenuItem.Click
        est_productosMarcas.ShowDialog()
    End Sub

    Private Sub ProductosPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorProveedorToolStripMenuItem.Click
        est_productosProveedor.ShowDialog()
    End Sub

    Private Sub ProductosPorTipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorTipoToolStripMenuItem.Click
        est_productosTipos.ShowDialog()
    End Sub

    Private Sub ProveedoresPorContactoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresPorContactoToolStripMenuItem.Click
        est_proveedoresContactos.ShowDialog()
    End Sub

    Private Sub SemanasTrabajadasPorAñoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemanasTrabajadasPorAñoToolStripMenuItem.Click
        est_semanasAños.ShowDialog()
    End Sub
End Class