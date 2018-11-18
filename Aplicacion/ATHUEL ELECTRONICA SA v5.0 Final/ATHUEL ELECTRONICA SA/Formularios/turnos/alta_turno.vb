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
            blanquear()
            txt_hora_inicio.Focus()
            Exit Sub
        Else
            If validarparametro() = True Then
                _turno.insertar()
                MsgBox("el turno se cargo con exito")
                Me.blanquear()
            End If
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

    Private Function validarparametro() As Boolean
        Dim hora As New DateTime
        If txt_hora_inicio.Text = "  :" Then
            MsgBox("La hora inicio esta vacia")
            txt_hora_inicio.Focus()
            Return False
        Else
            If DateTime.TryParse(txt_hora_inicio.Text, hora) Then
            Else
                MsgBox("Hora inicio incorrecta")
                txt_hora_inicio.Clear()
                txt_hora_inicio.Focus()
                Return False
            End If
        End If
        If txt_hora_fin.Text = "  :" Then
            MsgBox("La hora fin esta vacia")
            txt_hora_fin.Focus()
            Return False
        Else
            If DateTime.TryParse(txt_hora_fin.Text, hora) Then
            Else
                MsgBox("Hora fin incorrecta")
                txt_hora_fin.Focus()
                txt_hora_fin.Clear()
                Return False
            End If

            If txt_hora_fin.Text = txt_hora_inicio.Text Then
                MsgBox("La hora inicio y la hora fin son iguales")
                txt_hora_inicio.Focus()
                blanquear()
                Return False
            End If
        End If
        Return True
    End Function
End Class