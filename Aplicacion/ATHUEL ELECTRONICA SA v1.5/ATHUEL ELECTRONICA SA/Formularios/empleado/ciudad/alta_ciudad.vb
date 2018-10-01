Public Class alta_ciudad
    Dim _ciudad As New ciudad
    Dim _BD As New CONEXION_BD
    Private Sub alta_ciudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blanquear()
    End Sub

    Private Sub blanquear()
        txt_nombre.Text = ""
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_ciudad()
        Me._ciudad.nombre = txt_nombre.Text
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        transferir_datos_ciudad()
        Dim mensaje As String = Me._ciudad.validar()
        If mensaje <> "Correcta" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        Else
            Me._ciudad.insertar()
            MsgBox("La ciudad se grabó con éxito")
            Me.blanquear()
        End If

    End Sub
End Class