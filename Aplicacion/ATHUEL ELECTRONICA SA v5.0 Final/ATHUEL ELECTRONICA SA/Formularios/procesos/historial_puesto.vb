Public Class historial_puesto
    Dim BD As New CONEXION_BD
    Dim TE As New tratamientos_especiales
    Private Property legajo As Long
    Private Sub btn_empleado_Click(sender As Object, e As EventArgs) Handles btn_empleado.Click
        Dim buscar As New buscar_jefe
        Dim tabla As New DataTable
        buscar.ShowDialog()
        _legajo = buscar.legajo
        tabla = BD.leo_tabla("SELECT * FROM empleado WHERE legajo = " & _legajo)
        txt_apellido.Text = tabla.Rows(0)("apellido")
        txt_nombre.Text = tabla.Rows(0)("nombre")
        txt_nro_doc.Text = tabla.Rows(0)("numeroDocumento")
        cmb_tipo_doc.SelectedValue = tabla.Rows(0)("CodTipodoc")
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        tabla = BD.leo_tabla("SELECT p.nombre, ep.fechaDesde, j.nombre, j.apellido FROM  puestos_trabajo p , empleadoXpuesto ep LEFT OUTER JOIN empleado j ON  ep.legajoJefe = j.legajo  WHERE ep.legajo = " & _legajo & " AND ep.codPuesto = P.codPuesto ORDER BY ep.fechaDesde DESC")
        dgv.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            dgv.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1), tabla.Rows(c)(2), tabla.Rows(c)(3))
        Next
    End Sub

    Private Sub historial_puesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TE.carga_combo(cmb_tipo_doc, BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipodoc", "nombre")
    End Sub
End Class