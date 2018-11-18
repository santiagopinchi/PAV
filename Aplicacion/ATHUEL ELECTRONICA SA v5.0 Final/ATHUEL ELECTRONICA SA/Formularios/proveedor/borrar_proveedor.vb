Public Class borrar_proveedor
    Dim _proveedor As New proveedores
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Dim cuit As Long
        cuit = Me.dgv_vista.CurrentRow.Cells(0).Value
        If MessageBox.Show("¿Esta seguro que quiere borrar a: " & Me.dgv_vista.CurrentRow.Cells(1).Value & " ?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me._proveedor.borrar(cuit)
            MsgBox("el borrado se realizo con exito.")
            Me.cargar_grilla()
        End If
    End Sub
    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM proveedor")
    End Sub

    Private Sub borrar_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class