Public Class alta_usuario
    Public Property legajo As Integer
    Dim _usuario As New usuario

    Public Sub transferir()
        _usuario.Legajo = legajo
        _usuario.nombreUsuario = txt_nombre.Text
        _usuario.password = txt_password.Text
    End Sub

    Private Sub alta_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_legajo.Text = legajo
        txt_legajo.Enabled = False
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        transferir()
        _usuario.insertar()
        MsgBox("Usuario ingresado")
        Me.Close()
    End Sub
End Class