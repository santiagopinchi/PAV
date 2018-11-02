Public Class planificacion
    Private Property legajo_empleado As Long
    Dim BD As New conexion_BD_transaccion
    Dim TE As New tratamientos_especiales
    Dim plan As New plan
    Private Property codigoPlan As Long = 0
    Private Sub btn_empleado_Click(sender As Object, e As EventArgs) Handles btn_empleado.Click
        Dim buscar As New buscar_jefe
        Dim tabla As New DataTable
        buscar.ShowDialog()
        _legajo_empleado = buscar.legajo
        tabla = BD.leo_tabla("SELECT * FROM empleado WHERE legajo = " & _legajo_empleado)
        txt_apellido.Text = tabla.Rows(0)("apellido")
        txt_nombre.Text = tabla.Rows(0)("nombre")
        txt_nro_doc.Text = tabla.Rows(0)("numeroDocumento")
        cmb_tipo_doc.SelectedValue = tabla.Rows(0)("CodTipodoc")
        cargar_grilla(_legajo_empleado)
        txt_semana.Clear()
        cmb_turno.SelectedIndex = -1
    End Sub

    Private Sub cargar_grilla(ByVal legajo As Long)
        Dim tabla As New DataTable
        tabla = BD.leo_tabla("SELECT p.codigo, p.codturno, t.horarioinicio, t.horarioFin, p.semana, p.año  FROM planificacion p, turnos_trabajo t WHERE p.legajo =" & legajo & " AND t.codTurno = p.codturno  ORDER BY p.año DESC, p.semana DESC")
        dgv.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            dgv.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1), tabla.Rows(c)(2), tabla.Rows(c)(3), tabla.Rows(c)(4), tabla.Rows(c)(5))
        Next
    End Sub

    Private Sub planificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TE.carga_combo(cmb_tipo_doc, BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipodoc", "nombre")
        TE.carga_combo(cmb_turno, BD.leo_tabla("SELECT * FROM turnos_trabajo"), "codTurno", "horarioInicio")
        txt_año.Text = Year(Now)
    End Sub

    Private Sub btn_agragar_Click(sender As Object, e As EventArgs) Handles btn_agragar.Click
        Dim tabla As New DataTable
        If cmb_tipo_doc.SelectedIndex = -1 Then
            MsgBox("Empleado no selecionado", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cmb_turno.SelectedIndex = -1 Then
            MsgBox("El turno no ha sido selecionado", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txt_semana.Text = "" Then
            MsgBox("No se ingresó una semana", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txt_año.Text = "" Then
            MsgBox("No se ingresó un año", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If 0 < Integer.Parse(txt_semana.Text) < 53 Then
        Else
            MsgBox("Semana fuera de rango", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        tabla = BD.leo_tabla("SELECT * FROM planificacion WHERE legajo =" & _legajo_empleado & " AND codturno = " & cmb_turno.SelectedValue & " AND semana =" & Integer.Parse(txt_semana.Text) & " AND año = " & Integer.Parse(txt_año.Text))
        If tabla.Rows.Count <> 0 And _codigoPlan = 0 Then
            MsgBox("Turno ya cargado.")
            Exit Sub
        Else 
            tabla = BD.leo_tabla("SELECT * FROM planificacion WHERE legajo =" & _legajo_empleado & " AND semana =" & Integer.Parse(txt_semana.Text) & " AND año = " & Integer.Parse(txt_año.Text))
            If tabla.Rows.Count = 1 And _codigoPlan = 0 Then
                MsgBox("No se pe Puede dar dos turnos seguidos en la misma semana.")
                Exit Sub
            Else
            End If

            If _codigoPlan <> 0 Then
                BD.INS_MOD_BOR("UPDATE planificacion SET codturno = " & cmb_turno.SelectedValue & ", semana = " & Integer.Parse(txt_semana.Text) & ", año = " & Integer.Parse(txt_año.Text) & " WHERE codigo = " & _codigoPlan)
                MsgBox("Se modifico con exito")
                _codigoPlan = 0
            Else
                BD.INS_MOD_BOR("INSERT planificacion (legajo, codTurno, semana, año) VALUES (" & _legajo_empleado & ", " & cmb_turno.SelectedValue & ", " & Integer.Parse(txt_semana.Text) & ", " & Integer.Parse(txt_año.Text) & ")")
                MsgBox("Se agrego con exito")
                txt_semana.Text = Integer.Parse(txt_semana.Text) + 1
                If Integer.Parse(txt_semana.Text) = 53 Then
                    txt_semana.Text = 1
                    txt_año.Text = Integer.Parse(txt_año.Text) + 1

                End If
            End If
        End If
        cmb_turno.SelectedIndex = -1
        Me.cargar_grilla(_legajo_empleado)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        cmb_turno.SelectedValue = dgv.CurrentRow.Cells(5).Value
        Me.txt_año.Text = dgv.CurrentRow.Cells(0).Value
        Me.txt_semana.Text = dgv.CurrentRow.Cells(1).Value
        _codigoPlan = dgv.CurrentRow.Cells(4).Value
    End Sub
End Class
