Public Class contactos
    Dim BD As New CONEXION_BD
    Public Property numeroDoc As Long
    Public Property tipoDoc As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        _tipoDoc = dgv.CurrentRow.Cells(0).Value
        _numeroDoc = dgv.CurrentRow.Cells(1).Value
        MsgBox("Contacto seleccionado")
        Me.Close()
    End Sub

    Private Sub buscar_jefe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        Me.dgv.DataSource = BD.leo_tabla("SELECT * FROM contacto")
    End Sub
End Class