Public Class menu_producto
    Dim BD As New CONEXION_BD
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim producto As New alta_producto
        producto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim producto As New modificar_producto
        producto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim producto As New borrar_producto 
        producto.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub

    Private Sub menu_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        dgv.DataSource = BD.leo_tabla("SELECT * FROM producto")
    End Sub
End Class