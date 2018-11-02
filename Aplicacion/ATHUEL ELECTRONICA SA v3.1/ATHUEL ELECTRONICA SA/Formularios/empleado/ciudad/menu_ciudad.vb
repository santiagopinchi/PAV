Public Class menu_ciudad
    Dim barrio As New barrio
    Dim _BD As New CONEXION_BD
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim ciudad As New alta_ciudad
        ciudad.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim ciudad As New modificar_ciudad
        ciudad.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim ciudad As New borrar_ciudad
        ciudad.ShowDialog()
        Me.cargar_grilla()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub

    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM ciudad")
    End Sub

    Private Sub menu_ciudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu_barrio As New menu_barrio
        menu_barrio.codigoCiudad = barrio.codCiudad
        menu_barrio.ShowDialog()
    End Sub
End Class