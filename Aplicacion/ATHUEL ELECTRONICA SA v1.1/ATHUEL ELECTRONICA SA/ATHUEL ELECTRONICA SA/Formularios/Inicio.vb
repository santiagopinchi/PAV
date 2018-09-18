Public Class Inicio
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 20
            Label2.Text = "Cargando el sistema al " & ProgressBar1.Value & " %"
        Else

            Timer1.Enabled = False
            Menu_principal.Show()
            'Me.Close()
        End If
    End Sub
End Class