Public Class alta_marca
    Dim _marca As New marca
    Dim _BD As New CONEXION_BD
    Private Sub alta_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blanquear()
    End Sub

    Private Sub blanquear()
        txt_nombre.Text = ""
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_marca()
        Me._marca.nombre = txt_nombre.Text
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        transferir_datos_marca()
        Dim mensaje As String = Me._marca.validar()
        If mensaje <> "Correcta" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        Else
            Me._marca.insertar()
            MsgBox("La marca se grabó con éxito")
            Me.blanquear()
        End If

    End Sub
End Class