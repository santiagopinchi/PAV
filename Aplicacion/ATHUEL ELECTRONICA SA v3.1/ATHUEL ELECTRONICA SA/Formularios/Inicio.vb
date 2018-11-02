Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim c As Integer
        Timer1.Start()
        'For c = 0 To 100
        '    If c < 100 Then
        '        ProgressBar1.Value = ProgressBar1.Value + 20
        '        Label2.Text = "Cargando el sistema al " & ProgressBar1.Value & " %"
        '        c = c + 20
        '    Else
        '        Me.Close()
        '    End If
        'Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Close()
        End If
        Label2.Text = "Cargando el sistema al " & ProgressBar1.Value & " %"
    End Sub
End Class