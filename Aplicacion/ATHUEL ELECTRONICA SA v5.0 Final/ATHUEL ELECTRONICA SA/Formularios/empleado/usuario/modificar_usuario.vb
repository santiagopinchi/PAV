Public Class modificar_usuario

    Dim BD As New CONEXION_BD
    Dim cuenta As Integer = 0
    Public Property restaurar As Boolean = False
    Public Property modificar As Boolean = False
    Public Property usuario As New usuario
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If _restaurar = False Then
            Me.txt_nombre.Focus()
            If Me.txt_nombre.Text = "" Then
                MsgBox("el nombre de usuario está vacío", MsgBoxStyle.Exclamation)
                Me.txt_nombre.Focus()
                Exit Sub
            End If

            If Me.txt_password.Text = "" Then
                MsgBox("la contraseña actual está vacía", MsgBoxStyle.Exclamation)
                Me._txt_password.Focus()
                Exit Sub
            End If

            If Me.txt_password2.Text = "" Then
                MsgBox("la contraseña nueva está vacía", MsgBoxStyle.Exclamation)
                Me._txt_password.Focus()
                Exit Sub
            End If

            If Me.txt_password2.Text = txt_password.Text Then
                MsgBox("la contraseña es la misma", MsgBoxStyle.Exclamation)
                Me.txt_password2.Clear()
                Exit Sub
            End If
        Else
            txt_nombre.Enabled = False
            txt_password.Enabled = False
            If Me.txt_password2.Text = "" Then
                MsgBox("la contraseña nueva está vacía", MsgBoxStyle.Exclamation)
                Me._txt_password.Focus()
                Exit Sub
            End If

            If Me.txt_password2.Text = txt_password.Text Then
                MsgBox("la contraseña es la misma", MsgBoxStyle.Exclamation)
                Me.txt_password2.Clear()
                Exit Sub
            End If
        End If
        usuario.nombreUsuario = Me.txt_nombre.Text
        usuario.password = Me.txt_password.Text
        If BD.leo_tabla("SELECT * FROM usuario WHERE nombreUsuario = '" & usuario.nombreUsuario & "'").Rows.Count = 0 Then
            MsgBox("Usuario equivocado.")
        End If

        usuario.legajo = BD.leo_tabla("SELECT * FROM usuario WHERE nombreUsuario = '" & usuario.nombreUsuario & "'").Rows(0)("legajo")

        If usuario.estaBloqueadoRestaurar() = True Then
            MsgBox("usuario Bloqueado", MsgBoxStyle.Critical, "Error")
        Else
            If usuario.validarLogin() = usuario.estado_validar.encontrado Then
                usuario.password = txt_password2.Text
                usuario.modificar()
                MsgBox("el usuario a sido modificado Correctamente.")
                _modificar = True
                txt_nombre.Enabled = True
                txt_password.Enabled = True
            Else
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cuenta += 1
                Me.txt_password.Clear()
                Me.txt_password2.Clear()
                Me.txt_nombre.Clear()
                Me.txt_nombre.Focus()
                If cuenta = 3 Then
                    MsgBox("El usuario a sido bloqueado, por favor comuniquese con el administrador de base de datos.", MsgBoxStyle.Critical, "Error Fatal.")
                    usuario.bloquear()
                    txt_nombre.Enabled = True
                    txt_password.Enabled = True
                End If
            End If
        End If
        Me.Close()
    End Sub
    Public Sub usuario1(ByVal alegajo As Integer)
        usuario.legajo = alegajo
    End Sub
    Private Sub modificar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _restaurar = True Then
            usuario.buscar()
            txt_nombre.Text = usuario.nombreUsuario
            txt_password.Text = usuario.password
        End If
    End Sub
End Class