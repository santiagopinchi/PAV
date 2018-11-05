Public Class borrar_empleado
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Me._empleado.legajo = Me.dgv_01.CurrentRow.Cells(0).Value
        If MessageBox.Show("¿Esta seguro que quiere borrar a: " & Me.dgv_01.CurrentRow.Cells(4).Value & ", " & Me.dgv_01.CurrentRow.Cells(3).Value & " ?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("¿Recuerde que al borrar al empleado borrara todo su histrial de puestos?" _
                              , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                _BD.INS_MOD_BOR("DELETE FROM empleadoXpuesto WHERE legajo = " & _empleado.legajo)
                _BD.INS_MOD_BOR("DELETE FROM usuario WHERE legajo = " & _empleado.legajo)
                Me._empleado.borrar()
                MsgBox("el borrado se realizo con exito.")
                Me.cargar_grilla()
                Me._empleado.borrar()
            End If
        End If

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