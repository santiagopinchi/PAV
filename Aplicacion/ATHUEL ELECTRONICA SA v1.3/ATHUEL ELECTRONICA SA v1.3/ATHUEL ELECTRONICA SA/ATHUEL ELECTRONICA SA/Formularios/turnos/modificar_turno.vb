Public Class modificar_turno

    Dim _turno As New turno_trabajo
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD


    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM turnos_trabajo")
    End Sub

    Private Sub dgv_vista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellDoubleClick

        Me.txt_horaInicio.Text = dgv_vista.CurrentRow.Cells(1).Value
        Me.txt_horaFin.Text = dgv_vista.CurrentRow.Cells(2).Value
    End Sub

    Private Sub transferir_datos_puesto()
        Me._turno.horaFin = Me.txt_horaFin.Text
        Me._turno.horaInicio = Me.txt_horaInicio.Text
    End Sub

    Private Sub blanquear()

        Me.txt_horaInicio.Text = ""
        Me.txt_horaFin.Text = ""
        Me.txt_horaInicio.Focus()

    End Sub
    Private Sub modificar_turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        transferir_datos_puesto()
        Me._turno.modificar()
        Me.blanquear()
        Me.cargar_grilla()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class