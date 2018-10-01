Public Class borrar_producto
    Dim BD As New CONEXION_BD
    Dim producto As New producto
    Private Sub borrar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        dgv.DataSource = BD.leo_tabla("SELECT * FROM producto")
    End Sub
    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Dim codTipoprod As String
        Dim codProducto As Integer
        codTipoprod = Me.dgv.CurrentRow.Cells(0).Value.ToString
        codProducto = Me.dgv.CurrentRow.Cells(1).Value
        Me.producto.borrar(codProducto, codTipoprod)
        Me.cargar_grilla()
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class