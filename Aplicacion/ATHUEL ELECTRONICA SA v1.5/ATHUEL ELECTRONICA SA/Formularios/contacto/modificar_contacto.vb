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
        contacto.apellido = txt_apellido.Text
        contacto.nombre = txt_nombre.Text
        contacto.telefono = Long.Parse(txt_telefono.Text)
        contacto.numeroDoc = Long.Parse(txt_nro_doc.Text)
        contacto.codTipodoc = cmb_tipo_doc.SelectedValue
        contacto.mail = txt_email.Text
        contacto.moodificar()
        txt_apellido.Clear()
        txt_nombre.Clear()
        txt_telefono.Clear()
        txt_nro_doc.Clear()
        cmb_tipo_doc.SelectedIndex = -1
        txt_email.Clear()
        txt_nro_doc.Enabled = True
        cmb_tipo_doc.Enabled = True
    End Sub



End Class