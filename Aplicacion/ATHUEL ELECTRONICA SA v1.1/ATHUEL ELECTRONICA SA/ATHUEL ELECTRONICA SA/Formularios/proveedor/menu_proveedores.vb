Public Class menu_proveedores
    Dim _TE As tratamientos_especiales
    Dim _BD As New CONEXION_BD


    Private Sub menu_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim proveedor As New alta_proveedor
        proveedor.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim proveedor As New modificar_proveedor
        proveedor.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim proveedor As New borrar_proveedor
        proveedor.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM proveedor")
    End Sub
End Class