Public Class reporte_proveedor
    Dim BD As New CONEXION_BD
    Private Sub btn_buscar_marca_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT * FROM proveedor"
        Dim tabla As New DataTable
        If IsNumeric(txt_info.Text) Then
            sql &= " WHERE cuit  = " & txt_info.Text
        Else
            If txt_info.Text.IndexOf("-") >= 1 Then
                Dim extremo As String()
                extremo = txt_info.Text.Split("-")
                If IsNumeric(extremo(0)) And IsNumeric(extremo(1)) Then
                    sql &= " WHERE cuit BETWEEN " & extremo(0) & " AND " & extremo(1)
                Else
                    MsgBox("Error en dato de calculo")
                    Exit Sub
                End If
            Else
                sql &= " WHERE razonSocial like '%" & txt_info.Text & "%'"
            End If
        End If
        tabla = BD.leo_tabla(sql)
        listado_proveedorBindingSource.DataSource = tabla

        Me.rv1.RefreshReport()
    End Sub
End Class