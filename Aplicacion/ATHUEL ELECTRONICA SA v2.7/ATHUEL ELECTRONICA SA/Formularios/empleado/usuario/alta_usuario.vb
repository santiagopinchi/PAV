Public Class alta_usuario
    Public Property legajo As Integer
    Dim _usuario As New usuario
    Dim BD As New CONEXION_BD

    Public Sub transferir()
        _usuario.Legajo = legajo
        _usuario.nombreUsuario = txt_nombre.Text
        _usuario.password = txt_password.Text
        _usuario.pregunta_seguridad = txt_pregunta.Text
        _usuario.respuesta = txt_respuesta.Text
    End Sub

    Private Sub alta_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_legajo.Text = legajo
        txt_legajo.Enabled = False
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_nombre.Text = "" Then
            MsgBox("El nombre de usuario esta vacio", MsgBoxStyle.Critical, "Error")
            txt_nombre.Focus()
            Exit Sub
        End If
        If txt_password.Text = "" Then
            MsgBox("La contraseña del usuario esta vacia", MsgBoxStyle.Critical, "Error")
            txt_password.Focus()
            Exit Sub
        End If
        If txt_pregunta.Text = "" Then
            MsgBox("La pregunta de seguridad del usuario esta vacia", MsgBoxStyle.Critical, "Error")
            txt_pregunta.Focus()
            Exit Sub
        End If
        If txt_respuesta.Text = "" Then
            MsgBox("La respuesta de la pregutna de seguridad esta vacia", MsgBoxStyle.Critical, "Error")
            txt_respuesta.Focus()
            Exit Sub
        End If
        If BD.leo_tabla(" SELECT * FROM usuario WHERE legajo =" & _usuario.legajo).Rows.Count = 0 Then
            transferir()
            _usuario.insertar()
            MsgBox("Usuario ingresado")
        Else
            MsgBox("El usuario ya esta cargado.", MsgBoxStyle.Critical, "Error")
        End If
        Me.Close()
    End Sub
End Class