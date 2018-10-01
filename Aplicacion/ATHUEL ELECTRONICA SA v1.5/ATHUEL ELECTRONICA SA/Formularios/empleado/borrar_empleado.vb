Public Class borrar_empleado
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Me._empleado.legajo = Me.dgv_01.CurrentRow.Cells(0).Value
        Me._empleado.borrar()
        Me.cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_01.DataSource = _BD.leo_tabla("SELECT * FROM empleado")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub borrar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class