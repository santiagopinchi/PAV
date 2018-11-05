Public Class login
    Public Property estado_de_login As Boolean
    Dim cuenta As Integer = 0
    Dim _usuario As New usuario
    Dim BD As New CONEXION_BD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loguear()
    End Sub


    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            loguear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub loguear()
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
        If _usuario.estaBloqueado() = True Then
            MsgBox("usuario Bloqueado", MsgBoxStyle.Critical, "Error")
        Else
            If _usuario.validarLogin() = usuario.estado_validar.encontrado Then
                Me._estado_de_login = True
                Me.Close()
            Else
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cuenta += 1
                Me._estado_de_login = False
                Me._txt_password.Clear()
                Me.txt_usuario.Clear()
                If cuenta = 3 Then
                    MsgBox("Tres intesntos fallidos. Cerrando sistema", MsgBoxStyle.Critical, "Error Fatal.")
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub modificar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles modificar.LinkClicked
        Dim modificar As New modificar_usuario
        modificar.ShowDialog()
    End Sub

    Private Sub restaurar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles restaurar.LinkClicked
        Dim restaurar As New restaurar_usuario
        If Me.txt_usuario.Text = "" Then
            MsgBox("el nombre de usuario está vacío", MsgBoxStyle.Exclamation)
            Me._txt_usuario.Focus()
            Exit Sub
        Else
            Dim tabla As New DataTable
            tabla = BD.leo_tabla("SELECT * FROM usuario WHERE nombreUsuario = '" & txt_usuario.Text & "'")
            If tabla.Rows.Count = 0 Then
                MsgBox("Usuario equivocado")
                Exit Sub
            End If
            _usuario.legajo = tabla.Rows(0)("legajo")
            If _usuario.estaBloqueadoRestaurar() = True Then
                MsgBox("usuario Bloqueado", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                restaurar.nombre = txt_usuario.Text
                restaurar.ShowDialog()
            End If
        End If
    End Sub


End Class