Public Class reporte_historial
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim BD As New CONEXION_BD
        Dim sql As String = "SELECT * FROM empleadoXpuesto"
        Dim tabla As New DataTable
        If IsNumeric(txt_info.Text) Then
            sql &= " WHERE legajo = " & txt_info.Text
        Else
            If txt_info.Text.IndexOf("-") >= 1 Then
                Dim extremo As String()
                extremo = txt_info.Text.Split("-")
                If IsNumeric(extremo(0)) And IsNumeric(extremo(1)) Then
                    sql &= " WHERE legajo BETWEEN " & extremo(0) & " AND " & extremo(1)
                Else
                    MsgBox("Error en dato de calculo")
                    Exit Sub
                End If
            End If
        End If
        tabla = BD.leo_tabla(sql)
        listado_empleado_puestoBindingSource.DataSource = tabla
        Me.rv1.RefreshReport()
    End Sub

    Private Sub reporte_historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class