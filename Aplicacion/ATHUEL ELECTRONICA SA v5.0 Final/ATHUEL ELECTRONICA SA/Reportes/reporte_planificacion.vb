﻿Public Class reporte_planificacion
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim BD As New CONEXION_BD
        Dim sql As String = "SELECT * FROM planificacion"
        Dim tabla As New DataTable
        If IsNumeric(txt_info.Text) Then
            If txt_info.Text > 0 Then
                sql &= " WHERE año = " & txt_info.Text
            Else
                MsgBox("Error de dato.")
                txt_info.Clear()
                Exit Sub
            End If

        Else
            If txt_info.Text.IndexOf("-") >= 1 Then
                Dim extremo As String()
                extremo = txt_info.Text.Split("-")
                If IsNumeric(extremo(0)) And IsNumeric(extremo(1)) Then
                    sql &= " WHERE año BETWEEN " & extremo(0) & " AND " & extremo(1)
                Else
                    MsgBox("Error en dato de calculo")
                    Exit Sub
                End If
            End If
        End If
        tabla = BD.leo_tabla(sql)
        listado_planificacionBindingSource.DataSource = tabla
        Me.rv1.RefreshReport()
    End Sub

    Private Sub reporte_planificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_info.Text = ""
    End Sub
End Class