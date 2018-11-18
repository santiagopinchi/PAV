Public Class alta_tipo_prod
    Dim _BD As New CONEXION_BD
    Dim _TE As New tratamientos_especiales
    Dim tipo_prod As New tipo_producto

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_tipo_prod()
        Me.tipo_prod.codigo = Me.txt_codigo_tipo_prod.Text
        Me.tipo_prod.nombre = Me.txt_nombre.Text
        Me.tipo_prod.descripcion = Me.txt_descripcion.Text
        Me.tipo_prod.tiempoGarantia = Integer.Parse(Me.txt_garantia.Text)


    End Sub

    Private Sub blanquear()
        Me.txt_codigo_tipo_prod.Clear()
        Me.txt_nombre.Clear()
        Me.txt_descripcion.Clear()
        Me.txt_garantia.Clear()

    End Sub
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        transferir_datos_tipo_prod()
        Dim mensaje As String = Me.tipo_prod.validar()
        If mensaje <> "Correcta" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        Else
            If _BD.leo_tabla("SELECT * FROM tipos_productos WHERE codTipoProd = '" & tipo_prod.codigo & "'").Rows.Count = 0 Then
                Me.tipo_prod.insertar()
                MsgBox("Se grabó con éxito")
                Me.blanquear()
            Else
                MsgBox("Tipo de producto ya existente", MsgBoxStyle.Critical, "Error")
            End If

        End If
        Me.txt_codigo_tipo_prod.Focus()
    End Sub

    Private Sub alta_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blanquear()
    End Sub

End Class