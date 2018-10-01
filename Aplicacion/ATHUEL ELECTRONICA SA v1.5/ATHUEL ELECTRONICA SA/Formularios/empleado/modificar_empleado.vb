Public Class modificar_empleado
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub modificar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        _TE.carga_combo(cmb_tipo_doc, _BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipoDoc", "nombre")
        _TE.carga_combo(cmb_ciudad, _BD.leo_tabla("SELECT * FROM ciudad"), "codCiudad", "nombre")
        _TE.carga_combo(cmb_barrio, _BD.leo_tabla("SELECT * FROM barrio"), "codbarrio", "nombre")
        Me.txt_legajo.Enabled = False
    End Sub
    Public Sub cargar_grilla()
        dgv_01.Columns.Clear()
        dgv_01.Columns.Add(txt_legaj)
        dgv_01.Columns.Add(txt_apellidos)
        dgv_01.Columns.Add(txt_nombres)
        Dim tabla As DataTable
        Dim c As Integer
        tabla = _BD.leo_tabla("SELECT * FROM empleado")
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_01.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(4), tabla.Rows(c)(3))
        Next
    End Sub

    'Private Sub dgv_01_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_01.CellContentClick
    '    Dim tabla As DataTable
    '    tabla = _BD.leo_tabla("SELECT * FROM empleado WHERE legajo = " & dgv_01.CurrentRow.Cells(0).Value)
    '    _empleado.transferir(tabla)
    '    Me.txt_legajo.Text = _empleado.legajo
    '    Me.cmb_fecha_registro.Text = _empleado.fecha_ingreso
    '    Me.cmb_fecha_nacimiento.Text = _empleado.fecha_nac
    '    Me.txt_nombre.Text = _empleado.nombre
    '    Me.txt_apellido.Text = _empleado.apellido
    '    Me.cmb_tipo_doc.SelectedValue = _empleado.tipo_documento
    '    Me.txt_nro_doc.Text = _empleado.nro_documento
    '    Me.txt_calle.Text = _empleado.calle
    '    Me.txt_nro_calle.Text = _empleado.nroCalle
    '    Me.txt_nro_piso.Text = _empleado.piso
    '    Me.txt_dpto.Text = _empleado.dpto
    '    Me.txt_email.Text = _empleado.email
    '    Me.cmb_barrio.SelectedValue = _empleado.id_barrio
    '    tabla = _BD.leo_tabla("select codCiudad from barrio where codBarrio = " & _empleado.id_barrio)
    '    Me.cmb_ciudad.SelectedValue = tabla.Rows(0)("codCiudad")
    '    txt_legajo.Enabled = False
    '    cmb_fecha_registro.Enabled = False
    'End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_empleado()
        Me._empleado.legajo = Integer.Parse(Me.txt_legajo.Text)
        Me._empleado.nombre = Me.txt_nombre.Text
        Me._empleado.apellido = Me.txt_apellido.Text
        Me._empleado.id_barrio = Me.cmb_barrio.SelectedValue
        Me._empleado.calle = Me.txt_calle.Text
        Me._empleado.nroCalle = Integer.Parse(Me.txt_nro_calle.Text)
        Me._empleado.piso = Integer.Parse(Me.txt_nro_piso.Text)
        Me._empleado.dpto = Me.txt_dpto.Text
        Me._empleado.email = Me.txt_email.Text
        Me._empleado.nro_documento = Integer.Parse(Me.txt_nro_doc.Text)
        Me._empleado.tipo_documento = Me.cmb_tipo_doc.SelectedValue
        Me._empleado.fecha_nac = Me.cmb_fecha_nacimiento.Text
        Me._empleado.telefono = Long.Parse(Me.txt_telefono.Text)


    End Sub

    Private Sub blanquear()
        Me.txt_legajo.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_apellido.Text = ""
        Me.cmb_barrio.SelectedIndex = -1
        Me.cmb_ciudad.SelectedIndex = -1
        Me.txt_calle.Text = ""
        Me.txt_nro_calle.Text = ""
        Me.txt_nro_piso.Text = ""
        Me.txt_dpto.Text = ""
        Me.txt_email.Text = ""
        Me.txt_nro_doc.Text = ""
        Me.cmb_tipo_doc.SelectedIndex = -1
        Me.txt_telefono.Clear()

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        transferir_datos_empleado()
        Me._empleado.modificar()
        Me.blanquear()
        Me.cargar_grilla()
        txt_legajo.Enabled = True
        cmb_fecha_registro.Enabled = True
    End Sub

    Private Sub cmb_barrio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_barrio.SelectedIndexChanged
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT * FROM barrio WHERE codCiudad = " & cmb_ciudad.SelectedIndex + 1)
        _TE.carga_combo(cmb_barrio, tabla, "codBarrio", "nombre")
    End Sub

    Private Sub dgv_01_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_01.CellClick
        Dim tabla As DataTable
        tabla = _BD.leo_tabla("SELECT * FROM empleado WHERE legajo = " & dgv_01.CurrentRow.Cells(0).Value)
        _empleado.transferir(tabla)
        Me.txt_legajo.Text = _empleado.legajo
        Me.cmb_fecha_registro.Text = _empleado.fecha_ingreso
        Me.cmb_fecha_nacimiento.Text = _empleado.fecha_nac
        Me.txt_nombre.Text = _empleado.nombre
        Me.txt_apellido.Text = _empleado.apellido
        Me.cmb_tipo_doc.SelectedValue = _empleado.tipo_documento
        Me.txt_nro_doc.Text = _empleado.nro_documento
        Me.txt_calle.Text = _empleado.calle
        Me.txt_nro_calle.Text = _empleado.nroCalle
        Me.txt_nro_piso.Text = _empleado.piso
        Me.txt_dpto.Text = _empleado.dpto
        Me.txt_email.Text = _empleado.email
        Me.txt_telefono.Text = _empleado.telefono
        Me.cmb_barrio.SelectedValue = _empleado.id_barrio
        tabla = _BD.leo_tabla("select codCiudad from barrio where codBarrio = " & _empleado.id_barrio)
        Me.cmb_ciudad.SelectedValue = tabla.Rows(0)("codCiudad")
        txt_legajo.Enabled = False
        cmb_fecha_registro.Enabled = False
    End Sub
End Class