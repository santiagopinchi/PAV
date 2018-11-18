Public Class modificar_contacto
    Dim TE As New tratamientos_especiales
    Dim BD As New CONEXION_BD
    Dim contacto As New Contacto
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub modificar_contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.DataSource = BD.leo_tabla("SELECT * FROM contacto")
        TE.carga_combo(cmb_tipo_doc, BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipodoc", "nombre")
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        cmb_tipo_doc.SelectedValue = dgv.CurrentRow.Cells(0).Value
        txt_nro_doc.Text = dgv.CurrentRow.Cells(1).Value
        txt_nombre.Text = dgv.CurrentRow.Cells(2).Value
        txt_apellido.Text = dgv.CurrentRow.Cells(3).Value
        txt_telefono.Text = dgv.CurrentRow.Cells(4).Value
        txt_email.Text = dgv.CurrentRow.Cells(5).Value
        cmb_tipo_doc.Enabled = False
        txt_nro_doc.Enabled = False

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If cmb_tipo_doc.SelectedIndex = -1 Then
            MsgBox("El tipo Documento no esta selecionado", MsgBoxStyle.Critical, "Error")
            cmb_tipo_doc.Focus()
            Exit Sub
        End If
        If txt_nro_doc.Text = "" Then
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

        If txt_telefono.Text = "" Or txt_telefono.Text = 0 Then
            contacto.telefono = 0
        Else
            contacto.telefono = Long.Parse(txt_telefono.Text)
        End If
        contacto.mail = txt_email.Text
        contacto.apellido = txt_apellido.Text
        contacto.nombre = txt_nombre.Text
        contacto.numeroDoc = Long.Parse(txt_nro_doc.Text)
        contacto.codTipodoc = cmb_tipo_doc.SelectedValue
        contacto.moodificar()
        MsgBox("contacto modificado satisfactoriamente")
        txt_apellido.Clear()
        txt_nombre.Clear()
        txt_telefono.Clear()
        txt_nro_doc.Clear()
        cmb_tipo_doc.SelectedIndex = -1
        txt_email.Clear()
        txt_nro_doc.Enabled = True
        cmb_tipo_doc.Enabled = True
    End Sub



    Private Sub buscar_dni_Click(sender As Object, e As EventArgs) Handles buscar_dni.Click
        Dim tabla As DataTable
        If cmb_tipo_doc.SelectedIndex = -1 Then
            MsgBox("El tipo Documento no esta selecionado", MsgBoxStyle.Critical, "Error")
            cmb_tipo_doc.Focus()
            Exit Sub
        End If
        If txt_nro_doc.Text = "" Then
            MsgBox("El numero documento esta vacio", MsgBoxStyle.Critical, "Error")
            txt_nro_doc.Focus()
            Exit Sub
        End If
        contacto.numeroDoc = Long.Parse(txt_nro_doc.Text)
        contacto.codTipodoc = cmb_tipo_doc.SelectedValue
        tabla = BD.leo_tabla("SELECT * FROM contacto WHERE codTipodoc = " & contacto.codTipodoc & "AND numeroDocumento = " & contacto.numeroDoc)
        If tabla.Rows.Count = 0 Then
            MsgBox("Contacto no encontrado", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            txt_apellido.Text = tabla.Rows(0)("apellido")
            txt_email.Text = tabla.Rows(0)("mail")
            txt_nombre.Text = tabla.Rows(0)("nombre")
            txt_telefono.Text = Long.Parse(tabla.Rows(0)("telefono"))
            txt_nro_doc.Enabled = False
            cmb_tipo_doc.Enabled = False
        End If
    End Sub

    Private Sub buscar_pellido_nombre_Click(sender As Object, e As EventArgs) Handles buscar_pellido_nombre.Click
        Dim tabla As New DataTable
        Dim control As Boolean = False
        If txt_apellido.Text = "" And txt_nombre.Text = "" Then
            MsgBox("El los campos nombre y apellido estan vacios", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If txt_nombre.Text = "" And txt_apellido.Text <> "" Then
            contacto.apellido = txt_apellido.Text
            tabla = BD.leo_tabla("SELECT * FROM contacto WHERE apellido LIKE '" & txt_apellido.Text & "%'")
            control = True
        End If

        If txt_nombre.Text <> "" And txt_apellido.Text = "" Then
            contacto.nombre = txt_nombre.Text
            tabla = BD.leo_tabla("SELECT * from contacto where nombre LIKE '" & txt_nombre.Text & "%'")
            control = True
        End If

        If txt_nombre.Text <> "" And txt_apellido.Text <> "" Then
            contacto.apellido = txt_apellido.Text
            contacto.nombre = txt_nombre.Text
            tabla = BD.leo_tabla("SELECT * from contacto where apellido LIKE '" & txt_apellido.Text & "%' AND nombre like '" & txt_nombre.Text & "%'")
            control = True
        End If

        If tabla.Rows.Count = 0 And control = True Then
            MsgBox("Contacto no encontrado", MsgBoxStyle.Critical, "Error")
            control = False
            Exit Sub
        End If

        dgv.DataSource = tabla
        txt_apellido.Clear()
        txt_nombre.Clear()
    End Sub

    Private Sub btn_blanquear_Click(sender As Object, e As EventArgs) Handles btn_blanquear.Click
        txt_apellido.Clear()
        txt_nombre.Clear()
        txt_telefono.Clear()
        txt_nro_doc.Clear()
        cmb_tipo_doc.SelectedIndex = -1
        txt_email.Clear()
        txt_nro_doc.Enabled = True
        cmb_tipo_doc.Enabled = True
        dgv.DataSource = BD.leo_tabla("SELECT * FROM contacto")
    End Sub
End Class