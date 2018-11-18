Public Class reporte_producto_marca
    Dim BD As New CONEXION_BD
    Dim TE As New tratamientos_especiales


    Private Sub reporte_producto_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_marca.SelectedIndex = -1
        TE.carga_combo(cmb_marca, BD.leo_tabla("SELECT * FROM marca"), "codmarca", "nombre")
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.cmb_marca.SelectedIndex = -1
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT * FROM producto"
        Dim tabla As New DataTable
        If cmb_marca.SelectedIndex <> -1 Then
            sql &= " WHERE codmarca = " & cmb_marca.SelectedValue
        End If
        tabla = BD.leo_tabla(sql)
        ListadoproductoBindingSource1.DataSource = tabla
        Me.rv1.RefreshReport()
    End Sub
End Class