Public Class alta_empleado
    Dim _BD As New CONEXION_BD
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_empleado()
        Me._empleado.legajo = Me.txt_legajo.Text
        Me._empleado.nombre = Me.txt_nombre.Text
        Me._empleado.apellido = Me.txt_apellido.Text
        Me._empleado.id_barrio = Me.cmb_barrio.Text
        Me._empleado.calle = Me.txt_calle.Text
        Me._empleado.nro_documento = Me.txt_nro_doc.Text
        Me._empleado.tipo_documento = Me.cmb_tipo_doc.Text
        Me._empleado.fecha_nac = Me.cmb_fecha_nac.Text
        Me._empleado.fecha_ingreso = Me.cmb_fecha_alta.Text
    End Sub

    Private Sub blanquear()
        Me.txt_legajo.Text = 0
        Me.txt_nombre.Text = ""
        Me.txt_apellido.Text = ""
        Me.cmb_barrio.Text = ""
        Me.txt_calle.Text = ""
        Me.txt_nro_doc.Text = 0
        Me.cmb_tipo_doc.Text = ""
        Me.cmb_fecha_nac.Text = ""
        Me.cmb_fecha_alta.Text = ""
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        transferir_datos_empleado()
        Dim mensaje As String = Me._empleado.validar()
        If mensaje <> "CORRECTO" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        Else
            Me._empleado.insertar()
            Me.blanquear()
        End If
    End Sub
End Class