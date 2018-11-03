Public Class menu_marca
    Dim _BD As New CONEXION_BD
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim marca As New alta_marca
        marca.ShowDialog()
        Me.cargar_grilla()
        End Sub

        Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim marca As New modificar_marca
        marca.ShowDialog()
        Me.cargar_grilla()
        End Sub

        Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim marca As New baja_marca
        marca.ShowDialog()
        Me.cargar_grilla()
        End Sub

        Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
            Me.Close()
        End Sub

        Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM marca")
    End Sub

    Private Sub menu_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class