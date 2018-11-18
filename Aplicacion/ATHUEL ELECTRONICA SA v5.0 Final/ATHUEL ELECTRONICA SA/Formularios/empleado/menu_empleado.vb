Public Class menu_empleado
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD
    Dim _empleado As New empleado

    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim empleado As New alta_empleado
        empleado.ShowDialog()
        cargar_grilla()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim empleado As New modificar_empleado
        empleado.ShowDialog()
        cargar_grilla()
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim empleado As New borrar_empleado
        empleado.ShowDialog()
        cargar_grilla()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub

    Private Sub menu_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        _empleado.legajo = 0
    End Sub


    Private Sub cargar_grilla()
        Me.dgv_01.DataSource = _BD.leo_tabla("SELECT * FROM empleado")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If _empleado.legajo <> 0 Then
            Dim carga_usuario As New alta_usuario
            carga_usuario.legajo = _empleado.legajo
            carga_usuario.ShowDialog()
        Else
            MsgBox("No se a selecionado ningun empleado.")
        End If
    End Sub

    Private Sub dgv_01_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_01.CellClick
        _empleado.legajo = dgv_01.CurrentRow.Cells(0).Value
        MsgBox("Empleado seleccionado")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim menu_ciudad As New menu_ciudad
        menu_ciudad.ShowDialog()
    End Sub
End Class