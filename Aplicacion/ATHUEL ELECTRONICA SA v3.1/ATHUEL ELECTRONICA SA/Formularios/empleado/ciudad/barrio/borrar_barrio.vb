Public Class borrar_barrio

    Dim _barrio As New barrio
    Dim _BD As New CONEXION_BD

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim codigo As Integer
        codigo = Me.dgv_vista.CurrentRow.Cells(0).Value
        If MessageBox.Show("¿Esta seguro que quiere borrar a: " & Me.dgv_vista.CurrentRow.Cells(1).Value & " ?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me._barrio.borrar(codigo)
            Me.cargar_grilla()
            MsgBox("el borrado se realizo con exito.")
        End If
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM barrio ")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub borrar_barrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class
