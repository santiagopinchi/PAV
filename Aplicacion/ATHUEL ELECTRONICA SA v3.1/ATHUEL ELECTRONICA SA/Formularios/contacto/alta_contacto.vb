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
        If cmb_tipo_doc.SelectedIndex = -1 Then
            MsgBox("El tipo Documento no esta selecionado", MsgBoxStyle.Critical, "Error")
            cmb_tipo_doc.Focus()
            Exit Sub
        End If
        If txt_nro_doc.Text = -1 Then
            MsgBox("El numero documento esta vacio", MsgBoxStyle.Critical, "Error")
            txt_nro_doc.Focus()
            Exit Sub
        End If
        If txt_apellido.Text = "" Then
            MsgBox("El apellido esta vacio", MsgBoxStyle.Critical, "Error")
            txt_apellido.Focus()
            Exit Sub
        End If
        If txt_nombre.Text = "" Then
            MsgBox("El nombre esta vacio", MsgBoxStyle.Critical, "Error")
            txt_nombre.Focus()
            Exit Sub
        End If
        contacto.apellido = txt_apellido.Text
        contacto.nombre = txt_nombre.Text
        contacto.numeroDoc = Long.Parse(txt_nro_doc.Text)
        contacto.codTipodoc = cmb_tipo_doc.SelectedValue


        If txt_telefono.Text = "" Or txt_telefono.Text = 0 Then
            contacto.telefono = 0
        Else
            contacto.telefono = Long.Parse(txt_telefono.Text)
        End If

        If txt_email.Text = "" Then
            contacto.mail = "Null"
        Else
            contacto.mail = txt_email.Text
        End If

        Dim mensaje As String = contacto.validar()
        If mensaje <> "correcto" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            contacto.isnertar()
            MsgBox("contacto cargado satisfactoriamente")
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