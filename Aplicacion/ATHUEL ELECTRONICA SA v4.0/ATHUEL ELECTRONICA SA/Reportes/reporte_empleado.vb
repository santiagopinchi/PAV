Public Class reporte_empleado

    Dim BD As New CONEXION_BD
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT * FROM empleado"
        Dim tabla As New DataTable

        If IsNumeric(txt_info.Text) Then

            sql &= " WHERE legajo=" & txt_info.Text

        Else
            If txt_info.Text.IndexOf("-") >= 1 Then
                Dim extremos As String()
                extremos = txt_info.Text.Split("-")
                If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
                    sql &= " WHERE BETWEEN" & extremos(0) & " AND " & extremos(1)
                Else
                    MsgBox("Error en el dato a ingresar")
                End If
            Else
                sql &= " WHERE apellido like '%" & txt_info.Text & "%'"



            End If
        End If

        tabla = BD.leo_tabla(sql)
        listado_empleadoBindingSource.DataSource = tabla

        Me.rv1.RefreshReport()
    End Sub

    Private Sub reporte_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_info.Text = ""
    End Sub
End Class