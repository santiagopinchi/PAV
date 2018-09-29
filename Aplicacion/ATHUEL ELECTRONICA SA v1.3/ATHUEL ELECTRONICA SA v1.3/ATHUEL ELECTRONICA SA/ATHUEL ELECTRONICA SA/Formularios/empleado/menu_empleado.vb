Public Class menu_empleado
    Dim _TE As tratamientos_especiales
    Dim _BD As CONEXION_BD

    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim empleado As New alta_empleado
        empleado.ShowDialog()
        cargar_grilla()
        ' MsgBox("Acceso denegado”, MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim empleado As New modificar_empleado
        empleado.ShowDialog()
        cargar_grilla()
        'MsgBox("Acceso denegado”, MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim empleado As New borrar_empleado
        empleado.ShowDialog()
        cargar_grilla()
        'MsgBox("Acceso denegado”, MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub

    Private Sub menu_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub


    Private Sub cargar_grilla()
        Me.dgv_01.DataSource = _BD.leo_tabla("SELECT * FROM empleado")
    End Sub
End Class