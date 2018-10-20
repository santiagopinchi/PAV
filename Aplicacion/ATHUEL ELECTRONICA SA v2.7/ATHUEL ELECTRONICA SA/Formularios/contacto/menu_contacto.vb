Public Class menu_contacto
    Dim BD As New CONEXION_BD
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim contacto As New alta_contacto
        contacto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim contacto As New modificar_contacto
        contacto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim contacto As New borrar_contacto
        contacto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub

    Private Sub menu_contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        dgv.DataSource = BD.leo_tabla("SELECT * FROM contacto")
    End Sub
End Class