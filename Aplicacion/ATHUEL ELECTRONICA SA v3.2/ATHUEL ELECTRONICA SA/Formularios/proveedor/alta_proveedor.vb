Public Class alta_proveedor

    Dim _BD As New CONEXION_BD
    Dim _proveedor As New proveedores
    Dim _TE As New tratamientos_especiales


    Private Sub button_cancelar_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        Me.Close()
    End Sub
    Private Sub transferir_datos_proveedor()
        Me._proveedor.razon_social = Me.txt_razon_social.Text
        If Me.txt_cuit.Text = "" Then
            Me._proveedor.cuit = 0
        Else
            Me._proveedor.cuit = Long.Parse(Me.txt_cuit.Text)
        End If
        Me._proveedor.fecha_inicio = Me.txt_fecha_inicio.Text
        Me._proveedor.tipo_proveedor = Me.txt_tipo_proveedor.Text
    End Sub


    Private Sub blanquear()

        Me.txt_razon_social.Text = ""
        Me.txt_cuit.Text = ""
        Me.txt_fecha_inicio.Text = ""
        Me.txt_tipo_proveedor.Text = ""
        Me.txt_cuit.Focus()

    End Sub
    Private Sub button_confirmar_Click(sender As Object, e As EventArgs) Handles button_confirmar.Click
        transferir_datos_proveedor()
        Dim mensaje As String = Me._proveedor.validar()

        If mensaje <> "CORRECTO" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else

            If _BD.leo_tabla("SELECT * FROM proveedor WHERE cuit = " & _proveedor.cuit).Rows.Count = 0 Then
                Me._proveedor.insertar()
                MsgBox("el proveedor se cargo exitosamente")
                Me.blanquear()
            Else
                MsgBox("Proveedor ya existente", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub


End Class