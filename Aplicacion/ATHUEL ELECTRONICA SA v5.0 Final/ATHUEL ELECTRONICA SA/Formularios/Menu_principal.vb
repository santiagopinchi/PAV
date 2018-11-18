Public Class Menu_principal


    Private Sub Menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loguear As New login
        Dim inicio As New Inicio
        inicio.ShowDialog()
        loguear.estado_de_login = False
        loguear.ShowDialog()
        If loguear.estado_de_login = False Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_proveedores_Click(sender As Object, e As EventArgs) Handles btn_proveedores.Click
        Dim prov As New menu_proveedores
        prov.ShowDialog()
    End Sub

    Private Sub btn_puestos_Click(sender As Object, e As EventArgs) Handles btn_puestos.Click
        Dim puesto As New menu_puesto
        puesto.ShowDialog()
    End Sub

    Private Sub btn_empleados_Click(sender As Object, e As EventArgs) Handles btn_empleados.Click
        Dim empleado As New menu_empleado
        empleado.ShowDialog()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        Dim producto As New menu_producto
        producto.ShowDialog()
    End Sub

    Private Sub btn_turnos_Click(sender As Object, e As EventArgs) Handles btn_turnos.Click
        Dim turno As New menu_turno
        turno.ShowDialog()
    End Sub

    Private Sub btn_estadisticas_Click(sender As Object, e As EventArgs) Handles btn_estadisticas.Click
        frm_menu_estadisticas_reportes.ShowDialog()
    End Sub

    Private Sub fin_sesion_Click(sender As Object, e As EventArgs)
        Dim loguear As New login
        loguear.estado_de_login = False
        loguear.ShowDialog()
        If loguear.estado_de_login = False Then
            Me.Close()
        End If
    End Sub

    Private Sub cerrar_sesion_Click(sender As Object, e As EventArgs) Handles cerrar_sesion.Click
        Dim loguear As New login
        loguear.estado_de_login = False
        loguear.ShowDialog()
        If loguear.estado_de_login = False Then
            Me.Close()
        End If
    End Sub

    Private Sub procesos_Click(sender As Object, e As EventArgs) Handles procesos.Click
        Dim procesos As New menu_procesos
        procesos.ShowDialog()
    End Sub
End Class
