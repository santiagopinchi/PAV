Public Class alta_turno
    Dim _BD As New CONEXION_BD
    Dim _turno As New turno_trabajo
    Dim _TE As New tratamientos_especiales

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        transeferir_datos()
        Dim mensaje As String = Me._turno.validar()
        If mensaje <> "Correcta" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        Else
            _turno.insertar()
            Me.blanquear()
        End If
    End Sub
    Private Sub transeferir_datos()
        Me._turno.horaFin = txt_hora_fin.Text
        Me._turno.horaInicio = txt_hora_inicio.Text
    End Sub

    Private Sub blanquear()
        Me.txt_hora_inicio.Text = ""
        Me.txt_hora_fin.Text = ""
    End Sub


End Class