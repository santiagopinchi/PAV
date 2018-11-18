Public Class modificar_turno

    Dim _turno As New turno_trabajo
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD


    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM turnos_trabajo")
    End Sub

    Private Sub dgv_vista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellDoubleClick
        _turno.codigo = dgv_vista.CurrentRow.Cells(0).Value
        Me.txt_hora_inicio.Text = dgv_vista.CurrentRow.Cells(1).Value
        Me.txt_hora_fin.Text = dgv_vista.CurrentRow.Cells(2).Value
    End Sub

    Private Sub transeferir_datos()
        Me._turno.horaFin = Me.txt_hora_fin.Text
        Me._turno.horaInicio = Me.txt_hora_inicio.Text
    End Sub

    Private Sub blanquear()

        Me.txt_hora_inicio.Text = ""
        Me.txt_hora_fin.Text = ""
        Me.txt_hora_inicio.Focus()

    End Sub
    Private Sub modificar_turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        validarparametro()
        transeferir_datos()
        If validarparametro() = False Then
            Exit Sub
        Else
            Me._turno.modificar()
            MsgBox("el turno se modifico con exito")
            Me.blanquear()
            Me.cargar_grilla()
        End If
    End Sub
    Private Function validarparametro() As Boolean
        Dim hora As New DateTime
        If txt_hora_inicio.Text = "  :" Then
            MsgBox("La hora inicio esta vacia")
            txt_hora_inicio.Focus()
            Return False
        Else
            If DateTime.TryParse(txt_hora_inicio.Text, hora) Then
            Else
                MsgBox("Hora inicio incorrecta")
                txt_hora_inicio.Clear()
                txt_hora_inicio.Focus()
                Return False
            End If
        End If
        If txt_hora_fin.Text = "  :" Then
            MsgBox("La hora fin esta vacia")
            txt_hora_fin.Focus()
            Return False
        Else
            If DateTime.TryParse(txt_hora_fin.Text, hora) Then
            Else
                MsgBox("Hora fin incorrecta")
                txt_hora_fin.Focus()
                txt_hora_fin.Clear()
                Return False
            End If

            If txt_hora_fin.Text = txt_hora_inicio.Text Then
                MsgBox("La hora inicio y la hora fin son iguales")
                txt_hora_inicio.Focus()
                blanquear()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class