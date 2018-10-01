Public Class alta_contacto
    Dim _Te As New tratamientos_especiales
    Dim BD As New CONEXION_BD
    Dim contacto As New Contacto

    Private Sub alta_contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Te.carga_combo(cmb_tipo_doc, BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipodoc", "nombre")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        contacto.apellido = txt_apellido.Text
        contacto.nombre = txt_nombre.Text
        contacto.telefono = Long.Parse(txt_telefono.Text)
        contacto.numeroDoc = Long.Parse(txt_nro_doc.Text)
        If cmb_tipo_doc.SelectedValue = -1 Then
            contacto.codTipodoc = 0
        Else
            contacto.codTipodoc = cmb_tipo_doc.SelectedValue
        End If
        contacto.mail = txt_email.Text

        Dim mensaje As String = contacto.validar()
        If mensaje <> "correcto" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            contacto.isnertar()
            txt_apellido.Clear()
            txt_email.Clear()
            txt_nombre.Clear()
            txt_nro_doc.Clear()
            txt_telefono.Clear()
            cmb_tipo_doc.SelectedIndex = -1
            txt_nro_doc.Focus()
        End If
    End Sub

End Class