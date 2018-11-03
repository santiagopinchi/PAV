Public Class reporte_contacto

    Dim conexion As New CONEXION_BD

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT * FROM contacto"
        Dim tabla As New DataTable
        If IsNumeric(txt_info.Text) Then
            If txt_info.Text = "numeroDocumento" Then
                sql &= " WHERE numeroDocumento=" & txt_info.Text
            Else
                MsgBox("No se ha ingresado el Número de Documento")
            End If
        Else
            If txt_info.Text.IndexOf("-") >= 1 Then
                Dim extremo As String()
                extremo = txt_info.Text.Split("-")
                If IsNumeric(extremo(0)) & " AND" & IsNumeric(extremo(1)) Then
                    sql &= " WHERE numeroDocumento BETWEEN" & extremo(0) & "AND" & extremo(1)
                Else
                    MsgBox("Error en el dato a ingresar")
                End If
            Else
                If txt_info.Text = "apellido" Then
                    sql &= " WHERE apellido like '%" & txt_info.Text & "%'"
                Else
                    MsgBox("No se ha ingresado el apellido")
                End If
            End If
        End If
        tabla = conexion.leo_tabla(sql)
        DataSet1BindingSource.DataSource = tabla
        Me.rv1.RefreshReport()
    End Sub
End Class