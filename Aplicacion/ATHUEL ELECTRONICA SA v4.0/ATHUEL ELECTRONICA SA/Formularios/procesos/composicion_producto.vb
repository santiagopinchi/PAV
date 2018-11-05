Public Class composicion_producto

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim cargar As New cargar_manual
        cargar.ShowDialog()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim consultar As New consultar_manual
        consultar.ShowDialog()
    End Sub
End Class