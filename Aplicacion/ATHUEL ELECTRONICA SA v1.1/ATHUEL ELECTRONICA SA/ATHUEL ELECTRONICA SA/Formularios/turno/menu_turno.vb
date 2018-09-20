Public Class menu_turno
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        MsgBox("Acceso denegado”, MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        MsgBox("Acceso denegado”, MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        MsgBox("Acceso denegado”, MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub
End Class