Public Class menu_puesto

    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim puesto As New alta_puesto_trabajo
        puesto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim puesto As New modificar_puesto_trabajo
        puesto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim puesto As New Borrar_puesto_trabajo
        puesto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub

    Private Sub dgv_vista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Me.cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM puestos_trabajo")
    End Sub

    Private Sub menu_puesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class