Public Class Borrar_puesto_trabajo

    Dim _puesto As New puesto_trabajo
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub


    Private Sub dgv_vista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Me.cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM puestos_trabajo")
    End Sub


    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim codPuesto As Integer
        codPuesto = Me.dgv_vista.CurrentRow.Cells(0).Value
        Me._puesto.borrar(codPuesto)
        Me.cargar_grilla()
    End Sub

    Private Sub Borrar_puesto_trabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class