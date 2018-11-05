Public Class gestion_contacto

    Dim BD As New CONEXION_BD
    Dim TE As New tratamientos_especiales
    Private Property numeroDoc As Long = 0
    Private Property tipoDoc As Integer = 0
    Private Sub buscar_dni_Click(sender As Object, e As EventArgs) Handles buscar_dni.Click
        Dim contactos As New contactos
        Dim tabla As New DataTable
        contactos.ShowDialog()
        _tipoDoc = contactos.tipoDoc
        _numeroDoc = contactos.numeroDoc

        tabla = BD.leo_tabla("SELECT * FROM contacto WHERE codTipodoc = " & _tipoDoc & " AND numeroDocumento = " & _numeroDoc)

        cmb_tipo_doc.SelectedValue = _tipoDoc
        txt_nro_doc.Text = _numeroDoc
        txt_apellido.Text = tabla.Rows(0)("apellido")
        txt_nombre.Text = tabla.Rows(0)("nombre")
    End Sub

    Private Sub gestion_contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_proveedor.SelectedIndex = -1
        cmb_tipo_doc.SelectedIndex = -1
        cmb_tipo_producto.SelectedIndex = -1

        TE.carga_combo(Me.cmb_tipo_producto, BD.leo_tabla("SELECT * FROM tipos_productos"), "codTipoProd", "nombre")
        TE.carga_combo(Me.cmb_proveedor, BD.leo_tabla("SELECT * FROM proveedor"), "cuit", "razonsocial")
        TE.carga_combo(cmb_tipo_doc, BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipodoc", "nombre")
        cargar_grilla()
    End Sub


    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim tabla As New DataTable
        If Me.cmb_tipo_doc.SelectedIndex = -1 Then
            MsgBox("Elija un Tipo de Documento, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_tipo_doc.BackColor = Color.Aqua
            Me.cmb_tipo_doc.Focus()
            Exit Sub
        Else
            cmb_tipo_doc.BackColor = Color.White
        End If

        If Me.cmb_tipo_producto.SelectedIndex = -1 Then
            MsgBox("Elija un Tipo de producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_tipo_producto.BackColor = Color.Aqua
            Me.cmb_tipo_producto.Focus()
            Exit Sub
        Else
            cmb_tipo_producto.BackColor = Color.White
        End If

        If Me.cmb_proveedor.SelectedIndex = -1 Then
            MsgBox("Elija un proveedor, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_proveedor.BackColor = Color.Aqua
            Me.cmb_proveedor.Focus()
            Exit Sub
        Else
            cmb_proveedor.BackColor = Color.White
        End If

        tabla = BD.leo_tabla("SELECT * FROM productoXproveedor WHERE cuit = " & cmb_proveedor.SelectedValue & " AND codTipoProd = '" & cmb_tipo_producto.SelectedValue & "'")

        If tabla.Rows.Count = 0 Then
            BD.INS_MOD_BOR("INSERT productoXproveedor (codTipoProd, cuit, codTipodocCont, numeroDocumentoCont) VALUES ('" & cmb_tipo_producto.SelectedValue & "', " & cmb_proveedor.SelectedValue & ", " & _tipoDoc & ", " & _numeroDoc & ")")
            MsgBox("Se guardo el contacto de este producto con exito.")
        Else
            If MessageBox.Show("El proveedor ya dio un contacto para este tipo de producto ¿Desea modificarlo?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                BD.INS_MOD_BOR("UPDATE productoXproveedor SET codTipodocCont= " & _tipoDoc & ", numeroDocumentoCont =" & _numeroDoc & " WHERE codTipoProd ='" & cmb_tipo_producto.SelectedValue & "' AND cuit =  " & cmb_proveedor.SelectedValue)
                MsgBox("Se modifico el contacto de este producto con exito.")
            End If
        End If
        cargar_grilla()
    End Sub

    Public Sub cargar_grilla()
        Dim tabla As New DataTable
        tabla = BD.leo_tabla("SELECT t.nombre, p.razonSocial, c.nombre, c.Apellido, c.mail, c.telefono  FROM  proveedor p, tipos_productos t, contacto c, productoXproveedor pp WHERE p.cuit = pp.cuit AND t.codTipoProd = pp.codTipoProd AND c.codTipodoc= pp.codTipodocCont AND c.numeroDocumento= pp.numeroDocumentoCont")
        dgv.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            dgv.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1), tabla.Rows(c)(2), tabla.Rows(c)(3), tabla.Rows(c)(4), tabla.Rows(c)(5))
        Next
    End Sub

End Class