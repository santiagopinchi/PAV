Public Class borrar_empleado
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim legajo As Integer
        legajo = Me.dgv_01.CurrentRow.Cells(0).Value
        Me._empleado.borrar(legajo)
        Me.cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_01.DataSource = _BD.leo_tabla("SELECT * FROM empleado")
    End Sub

End Class