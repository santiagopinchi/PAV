Public Class Menu_principal


    Private Sub cerrar_sesion_Click(sender As Object, e As EventArgs) Handles cerrar_sesion.Click
        Dim loguear As New login
        loguear.estado_de_login = False
        loguear.ShowDialog()
        If loguear.estado_de_login = False Then
            Me.Close()
        End If
    End Sub

    Private Sub Menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loguear As New login
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
End Class
