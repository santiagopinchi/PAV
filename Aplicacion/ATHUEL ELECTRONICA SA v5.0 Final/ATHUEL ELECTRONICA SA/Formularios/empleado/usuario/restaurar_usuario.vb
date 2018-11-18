Public Class restaurar_usuario
    Dim tabla As New DataTable
    Dim BD As New CONEXION_BD
    Dim modificar As New modificar_usuario
    Public Property usuario As New usuario
    Public Property nombre As String


    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        tabla = BD.leo_tabla("SELECT pregunta_control, respuesta, legajo FROM usuario WHERE nombreUsuario= '" & _nombre & "'")
        usuario.legajo = tabla.Rows(0)("legajo")
        If txt_respuesta.Text = tabla.Rows(0)("respuesta") Then
            modificar.usuario1(usuario.legajo)
            modificar.restaurar = True
            modificar.ShowDialog()
            Me.Close()
        Else
            MsgBox("El usuario a sido bloqueado, por favor comuniquese con el administrador de base de datos.", MsgBoxStyle.Critical, "Error Fatal.")
            usuario.bloquear()
        End If
        Me.Close()
    End Sub

    Private Sub restaurar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla = BD.leo_tabla("SELECT pregunta_control, respuesta, legajo FROM usuario WHERE nombreUsuario= '" & _nombre & "'")
        lbl_pregutna.Text = "¿ " & tabla.Rows(0)("pregunta_control").ToString & " ?"
    End Sub
End Class