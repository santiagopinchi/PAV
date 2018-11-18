Public Class buscar_jefe
    Dim BD As New CONEXION_BD
    Public Property legajo As Long = 0
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        _legajo = dgv.CurrentRow.Cells(0).Value
        MsgBox("Empleado seleccionado")
        Me.Close()
    End Sub

    Private Sub buscar_jefe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        Me.dgv.DataSource = BD.leo_tabla("SELECT * FROM empleado")
    End Sub
End Class