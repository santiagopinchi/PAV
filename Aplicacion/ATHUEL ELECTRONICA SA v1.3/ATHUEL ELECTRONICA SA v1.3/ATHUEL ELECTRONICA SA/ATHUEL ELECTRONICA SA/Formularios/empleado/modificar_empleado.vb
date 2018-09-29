Public Class modificar_empleado
    Dim _empleado As New empleado
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub modificar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Public Sub cargar_grilla()
        Me.dgv_01.DataSource = _BD.leo_tabla("SELECT * FROM empleado")
    End Sub

    Private Sub dgv_01_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_01.CellContentClick
        Me.txt_legajo.Text = dgv_01.CurrentRow.Cells(0).Value
        Me.txt_apellido.Text = dgv_01.CurrentRow.Cells(1).Value
        Me.txt_nombre.Text = dgv_01.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_empleado()
        Me._empleado.legajo = Me.txt_legajo.Text
        Me._empleado.apellido = Me.txt_apellido.Text
        Me._empleado.nombre = Me.txt_nombre.Text
    End Sub

    Private Sub blanquear()
        Me.txt_nombre.Text = ""
        Me.txt_nro_calle.Text = ""
        Me.txt_calle.Text = ""
        Me.txt_nro_doc.Text = ""
        Me.txt_nro_piso.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_dpto.Text = ""
        Me.cmb_fecha_nacimiento.Text = ""
        Me.cmb_tipo_doc.Text = ""
        Me.cmb_fecha_registro.Text = ""
        Me.cmb_ciudad.Text = ""
        Me.cmb_barrio.Text = ""
        Me.txt_legajo.Text = ""
        Me.txt_email.Text = ""
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        transferir_datos_empleado()
        Me._empleado.modificar()
        Me.blanquear()
        Me.cargar_grilla()
    End Sub
End Class