Public Class modificar_empleado
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD
    Private Property legajo As Long = 0

    Private Sub modificar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        _TE.carga_combo(cmb_tipo_doc, _BD.leo_tabla("SELECT * FROM tipo_documento"), "codTipoDoc", "nombre")
        _TE.carga_combo(cmb_ciudad, _BD.leo_tabla("SELECT * FROM ciudad"), "codCiudad", "nombre")
        _TE.carga_combo(cmb_barrio, _BD.leo_tabla("SELECT * FROM barrio"), "codbarrio", "nombre")
        _TE.carga_combo(cmb_puesto, _BD.leo_tabla("SELECT * FROM puestos_trabajo"), "codPuesto", "nombre")
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
    Private Function validacion()
        If Me.cmb_tipo_doc.SelectedIndex = -1 Then
            MsgBox("Elija un Tipo de Documento, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_tipo_doc.BackColor = Color.Aqua
            Me.cmb_tipo_doc.Focus()
            Return False
        Else
            cmb_tipo_doc.BackColor = Color.White
        End If

        If Me.txt_nro_doc.Text = "" Then
            MsgBox("El Nro de Documento no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            txt_nro_doc.BackColor = Color.Aqua
            Me.txt_nro_doc.Focus()
            Return False
        Else
            txt_nro_doc.BackColor = Color.White
        End If

        If txt_fecha_nacimiento.Value = DateAndTime.Now Then
            MsgBox("Ingrese una fecha de nacimiento valida", MsgBoxStyle.Critical, "Importante")
            txt_fecha_nacimiento.BackColor = Color.Aqua
            txt_fecha_nacimiento.Focus()
            Return False
        Else
            txt_fecha_nacimiento.BackColor = Color.White
        End If

        If txt_apellido.Text = String.Empty Then
            MsgBox("Debe ingresar el Apellido", MsgBoxStyle.Critical, "Importante")
            txt_apellido.BackColor = Color.Aqua
            txt_apellido.Focus()
            Return False
        Else
            txt_apellido.BackColor = Color.White
        End If

        If txt_nombre.Text = String.Empty Then
            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Critical, "Importante")
            txt_nombre.BackColor = Color.Aqua
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If
        If cmb_puesto.SelectedIndex = -1 Then
            MsgBox("Elija un puesto", MsgBoxStyle.Critical, "Importante")
            cmb_puesto.BackColor = Color.Aqua
            cmb_puesto.Focus()
            Return False
        Else
            cmb_puesto.BackColor = Color.White
        End If
        If txt_calle.Text = String.Empty Then
            MsgBox("Ingrese el nombre de una calle", MsgBoxStyle.Critical, "Importante")
            txt_calle.BackColor = Color.Aqua
            txt_calle.Focus()
            Return False
        Else
            txt_calle.BackColor = Color.White
        End If

        If txt_nro_calle.Text = String.Empty Then
            MsgBox("Ingrese el nro. de casa", MsgBoxStyle.Critical, "Importante")
            txt_nro_calle.BackColor = Color.Aqua
            txt_nro_calle.Focus()
            Return False
        Else
            txt_nro_calle.BackColor = Color.White
        End If

        'If txt_nro_piso.Text = String.Empty Then
        '    _empleado.piso = 0
        'End If

        'If txt_dpto.Text = String.Empty Then
        '    _empleado.dpto = "NULL"
        'End If

        'If txt_email.Text = String.Empty Then
        '    _empleado.email = "NULL"
        'End If



        If cmb_ciudad.SelectedIndex = -1 Then
            MsgBox("Elija una ciudad", MsgBoxStyle.Critical, "Importante")
            cmb_ciudad.BackColor = Color.Aqua
            cmb_ciudad.Focus()
            Return False
        Else
            cmb_ciudad.BackColor = Color.White
        End If


        If cmb_barrio.SelectedIndex = -1 Then
            MsgBox("Elija un barrio", MsgBoxStyle.Critical, "Importante")
            cmb_barrio.BackColor = Color.Aqua
            cmb_barrio.Focus()
            Return False
        Else
            cmb_barrio.BackColor = Color.White
        End If


        If txt_telefono.Text = String.Empty Then
            MsgBox("El telefono esta vacio", MsgBoxStyle.Critical, "Importante")
            txt_telefono.BackColor = Color.Aqua
            txt_telefono.Focus()
            Return False
        Else
            txt_telefono.BackColor = Color.White
        End If
        Return True
    End Function
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
        If Me.txt_nro_piso.Text = "" Then
            Me._empleado.piso = 0
        Else
            Me._empleado.piso = Integer.Parse(Me.txt_nro_piso.Text)
        End If
        Me._empleado.dpto = Me.txt_dpto.Text
        Me._empleado.email = Me.txt_email.Text
        Me._empleado.nro_documento = Integer.Parse(Me.txt_nro_doc.Text)
        Me._empleado.tipo_documento = Me.cmb_tipo_doc.SelectedValue
        Me._empleado.fecha_nac = Me.txt_fecha_nacimiento.Text
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
        Me.cmb_puesto.SelectedIndex = -1
        txt_jefe_apellido.Clear()
        txt_jefe_nombre.Clear()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If validacion() = True Then
            transferir_datos_empleado()
            Me._empleado.modificar()
            If _legajo <> 0 Then
                Dim tabla As New DataTable
                tabla = _BD.leo_tabla("SELECT * FROM empleadoXpuesto WHERE legajo =" & _legajo & " AND codPuesto= " & cmb_puesto.SelectedValue)
                If tabla.Rows.Count = 0 Then
                    _BD.INS_MOD_BOR("INSERT empleadoXpuesto  (legajo, codPuesto, fechaDesde, legajoJefe) VALUES (" & _empleado.legajo & ", " & cmb_puesto.SelectedValue & ", '" & cmb_fecha_registro.Text & "', " & _legajo & ")")
                    MsgBox("Se grabó con éxito el empleado")
                End If
                'Else
                '    _BD.INS_MOD_BOR("INSERT empleadoXpuesto  (legajo, codPuesto, fechaDesde, legajoJefe) VALUES (" & _empleado.legajo & ", " & cmb_puesto.SelectedValue & ", '" & cmb_fecha_registro.Text & "', Null)")
                '    MsgBox("Se grabó con éxito el empleado")
            End If
                Me.blanquear()
            Me.cargar_grilla()
            txt_legajo.Enabled = True
            cmb_fecha_registro.Enabled = True
        End If
    End Sub

    Private Sub cmb_barrio_SelectedIndexChanged(sender As Object, e As EventArgs)
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
        Me.txt_fecha_nacimiento.Text = _empleado.fecha_nac
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
        Me.cmb_puesto.SelectedValue = _BD.leo_tabla("SELECT * FROM empleadoXpuesto WHERE legajo = " & _empleado.legajo & "ORDER BY fechaDesde DESC").Rows(0)("codPuesto")
        txt_legajo.Enabled = False
    End Sub

    Private Sub cmb_ciudad_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT * FROM barrio WHERE codCiudad = " & cmb_ciudad.SelectedValue)
        _TE.carga_combo(cmb_barrio, tabla, "codBarrio", "nombre")
    End Sub
    Private Sub btn_jefe_Click(sender As Object, e As EventArgs) Handles btn_jefe.Click
        Dim legajojefe As Long
        Dim buscar_jefe As New buscar_jefe
        Dim tabla As New DataTable
        buscar_jefe.ShowDialog()
        legajojefe = buscar_jefe.legajo
        If legajojefe <> 0 Then
            tabla = _BD.leo_tabla("SELECT * FROM empleado WHERE legajo =" & legajojefe)
            txt_jefe_apellido.Text = tabla.Rows(0)("apellido")
            txt_jefe_nombre.Text = tabla.Rows(0)("nombre")
            _legajo = legajojefe
        End If
    End Sub
End Class