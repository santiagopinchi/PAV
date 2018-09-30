Public Class login
    Public Property estado_de_login As Boolean
    Dim cuenta As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _usuario As New usuario
        Me.txt_usuario.Focus()
        If Me._txt_usuario.Text = "" Then
            MsgBox("el nombre de usuario está vacío", MsgBoxStyle.Exclamation)
            Me._txt_usuario.Focus()
            Exit Sub
        End If
        If Me._txt_password.Text = "" Then
            MsgBox("el password está vacío", MsgBoxStyle.Exclamation)
            Me._txt_password.Focus()
            Exit Sub
        End If
        _usuario.nombreUsuario = Me._txt_usuario.Text
        _usuario.password = Me._txt_password.Text
        If _usuario.validarLogin() = usuario.estado_validar.encontrado Then
            Me._estado_de_login = True
            Me.Close()
        Else
            MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cuenta += 1
            Me._estado_de_login = False
            Me._txt_password.Clear()
            If cuenta = 3 Then
                MsgBox("Tres intesntos fallidos. Cerrando sistema", MsgBoxStyle.Critical, "Error Fatal.")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class