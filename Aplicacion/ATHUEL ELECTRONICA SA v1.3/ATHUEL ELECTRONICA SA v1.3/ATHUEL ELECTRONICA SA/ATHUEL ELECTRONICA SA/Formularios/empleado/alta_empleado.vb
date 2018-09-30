Public Class alta_empleado
    Dim _BD As New CONEXION_BD
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_empleado()
        'Me._empleado.legajo = Integer.Parse(Me.txt_legajo.Text)
        Me._empleado.nombre = Me.txt_nombre.Text
        Me._empleado.apellido = Me.txt_apellido.Text
        Me._empleado.id_barrio = Me.cmb_barrio.SelectedValue
        Me._empleado.calle = Me.txt_calle.Text
        Me._empleado.nroCalle = Integer.Parse(Me.txt_nro_calle.Text)
        Me._empleado.piso = Me.txt_nro_piso.Text
        Me._empleado.dpto = Me.txt_dpto.Text
        Me._empleado.email = Me.txt_email.Text
        Me._empleado.nro_documento = Integer.Parse(Me.txt_nro_doc.Text)
        Me._empleado.tipo_documento = Me.cmb_tipo_doc.SelectedValue
        Me._empleado.fecha_nac = Me.cmb_fecha_nac.Text
        Me._empleado.fecha_ingreso = Me.cmb_fecha_alta.Text
    End Sub

    Private Sub blanquear()
        'Me.txt_legajo.Text = ""
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
        Me.cmb_fecha_nac.Text = ""
        Me.cmb_fecha_alta.Text = ""
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        transferir_datos_empleado()
        'Dim mensaje As String = Me._empleado.validar()
        'If mensaje <> "Validación correcta" Then
        '    MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        'Else
        '    Me._empleado.insertar()
        '    MsgBox("Se grabó con éxito el empleado")
        '    Me.blanquear()
        'End If
        If txt_nro_piso.Text = "" Then
            Me._empleado.piso = txt_nro_piso.Text = "NULL"
        End If
        If txt_dpto.Text = "" Then
            Me._empleado.dpto = txt_dpto.Text = "NULL"
        End If
        Me._empleado.insertar()
        MsgBox("Se grabó con éxito el empleado")
        Me.blanquear()

    End Sub

    Private Sub llenar_combo(ByVal cmb As ComboBox, ByVal source As Object, ByVal display As String, ByRef value As String)
        cmb.DataSource = source
        cmb.DisplayMember = display
        cmb.ValueMember = value
        cmb.SelectedIndex = -1
    End Sub

    Private Sub alta_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_combo(cmb_tipo_doc, _BD.leo_tabla("SELECT * FROM tipo_documento"), "nombre", "codTipoDoc")
        'cmb_tipo_doc.DataSource = _BD.leo_tabla("SELECT * FROM tipo_documento")
        'cmb_tipo_doc.DisplayMember = "nombre"
        'cmb_tipo_doc.ValueMember = "codTipoDoc"

        llenar_combo(cmb_barrio, _BD.leo_tabla("SELECT * FROM barrio"), "nombre", "codBarrio")
        'cmb_barrio.DataSource = _BD.leo_tabla("SELECT * FROM barrio")
        'cmb_barrio.DisplayMember = "nombre"
        'cmb_barrio.ValueMember = "codBarrio"

        llenar_combo(cmb_ciudad, _BD.leo_tabla("SELECT * FROM ciudad"), "nombre", "codCiudad")
        'cmb_ciudad.DataSource = ("SELECT * FROM ciudad")
        'cmb_ciudad.DisplayMember = "nombre"
        'cmb_ciudad.ValueMember = "codCiudad"
        Me.txt_legajo.Enabled = False
        blanquear()
    End Sub
End Class