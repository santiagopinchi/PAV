Public Class borrar_ciudad
    Dim _BD As New CONEXION_BD
    Dim _ciudad As New ciudad

    Private Sub cargar_grilla()
        dgv_vista.DataSource = _BD.leo_tabla("select * from ciudad")
    End Sub

    Private Sub borrar_ciudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim _codigo As Integer
        _codigo = Me.dgv_vista.CurrentRow.Cells(0).Value
        If MessageBox.Show("¿Esta seguro que quiere borrar a: " & Me.dgv_vista.CurrentRow.Cells(1).Value & " ?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Recuerde que al borrar la ciudad se borraran todos sus barrios" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If _BD.leo_tabla("select * from empleado WHERE codBarrio IN (SELECT codBarrio FROM barrio WHERE codCiudad =" & _codigo & ")").Rows.Count = 0 Then
                    _BD.INS_MOD_BOR("DELETE FROM barrio WHERE codCiudad =" & _codigo)
                    Me._ciudad.borrar(_codigo)
                    MsgBox("el borrado se realizo con exito.")
                    Me.cargar_grilla()
                Else
                    MsgBox("No se peude borrar, exiten empleados con algun barrio de esta ciudad.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class