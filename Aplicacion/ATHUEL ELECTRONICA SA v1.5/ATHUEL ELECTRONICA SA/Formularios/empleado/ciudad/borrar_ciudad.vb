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
        Dim codigo As Integer
        codigo = Me.dgv_vista.CurrentRow.Cells(0).Value
        Me._ciudad.borrar(codigo)
        Me.cargar_grilla()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class