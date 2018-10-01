Public Class borrar_contacto
    Dim BD As New CONEXION_BD
    Dim contacto As New Contacto
    Private Sub borrar_contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        dgv.DataSource = BD.leo_tabla("SELECT * FROM contacto")
    End Sub
    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        contacto.codTipodoc = Me.dgv.CurrentRow.Cells(0).Value
        contacto.numeroDoc = Me.dgv.CurrentRow.Cells(1).Value
        Me.contacto.borrar()
        Me.cargar_grilla()
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class