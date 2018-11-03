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
        If MessageBox.Show("¿Esta seguro que quiere borrar a: " & codTipoprod & ", " & codProducto & " ?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            Me.producto.borrar(codProducto, codTipoprod)
            MsgBox("el borrado se realizo con exito.")
        End If

        Me.cargar_grilla()
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class