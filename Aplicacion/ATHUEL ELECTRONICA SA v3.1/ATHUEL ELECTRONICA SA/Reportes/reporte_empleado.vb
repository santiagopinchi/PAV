Public Class reporte_empleado

    Dim BD As New CONEXION_BD
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT * FROM empleado"
        Dim tabla As New DataTable

        If IsNumeric(txt_info.Text) Then
            If txt_info.Text = "legajo" Then
                sql &= " WHERE legajo=" & txt_info.Text
            Else
                MsgBox("No se ha ingresado el legajo")
            End If
        Else
            If txt_info.Text.IndexOf("-") >= 1 Then
                Dim extremos As String()
                extremos = txt_info.Text.Split("-")
                If IsNumeric(extremos(0)) & " AND" & IsNumeric(extremos(1)) Then
                    sql &= " WHERE BETWEEN" & extremos(0) & " AND " & extremos(1)
                Else
                    MsgBox("Error en el dato a ingresar")
                End If
            Else
                If txt_info.Text = "nombre" Then
                    sql &= " WHERE nombre like '%" & txt_info.Text & "%'"
                Else
                    MsgBox("No se ha ingresado el nombre")
                End If
            End If
        End If

        tabla = BD.leo_tabla(sql)
        listado_empleadoBindingSource.DataSource = tabla

        Me.rv1.RefreshReport()
    End Sub

    Private Sub reporte_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class