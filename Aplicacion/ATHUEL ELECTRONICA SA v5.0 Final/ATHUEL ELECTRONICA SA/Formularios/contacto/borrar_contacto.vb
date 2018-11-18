Public Class borrar_contacto
    Dim BD As New CONEXION_BD
    Dim TE As New tratamientos_especiales
    Dim contacto As New Contacto
    Private Sub borrar_contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        gb_filtros.Visible = False
        TE.carga_combo(cmb_tipo_doc, BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipodoc", "nombre")
    End Sub
    Private Sub cargar_grilla()
        dgv.DataSource = BD.leo_tabla("SELECT * FROM contacto")
    End Sub
    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        contacto.codTipodoc = Me.dgv.CurrentRow.Cells(0).Value
        contacto.numeroDoc = Me.dgv.CurrentRow.Cells(1).Value
        If MessageBox.Show("¿Esta seguro que quiere borrar a: " & dgv.CurrentRow.Cells(3).Value & ", " & dgv.CurrentRow.Cells(2).Value & " ?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.contacto.borrar()
            MsgBox("el borrado se realizo con exito.")
            Me.cargar_grilla()
        End If
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
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
        dgv.DataSource = tabla
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

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If gb_filtros.Visible = False Then
            gb_filtros.Visible = True
        Else
            gb_filtros.Visible = False
            txt_apellido.Clear()
            txt_nombre.Clear()
            txt_nro_doc.Clear()
            cmb_tipo_doc.SelectedIndex = -1
        End If
    End Sub
End Class