Public Class menu_procesos

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim composicion As New composicion_producto
        composicion.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim puestos As New historial_puesto
        puestos.ShowDialog()
    End Sub

    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Dim planificacion As New planificacion
        planificacion.ShowDialog()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim gestion As New gestion_contacto
        gestion.ShowDialog()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub
End Class