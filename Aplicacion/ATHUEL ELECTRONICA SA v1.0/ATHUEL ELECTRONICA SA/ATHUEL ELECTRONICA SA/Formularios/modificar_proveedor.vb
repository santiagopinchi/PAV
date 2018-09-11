Public Class modificar_proveedor
    Dim _proveedor As New proveedores
    Dim _TE As New tratamientos_especiales
    Dim _BD As New CONEXION_BD

    Private Sub modificar_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        Me.dgv_vista.DataSource = _BD.leo_tabla("SELECT * FROM proveedor")
    End Sub
    Private Sub dgv_vista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellDoubleClick
        Me.txt_cuit.Text = dgv_vista.CurrentRow.Cells(0).Value
        Me.txt_razon_social.Text = dgv_vista.CurrentRow.Cells(1).Value
        Me.txt_fecha_inicio.Text = dgv_vista.CurrentRow.Cells(2).Value
        Me.txt_tipo_proveedor.Text = dgv_vista.CurrentRow.Cells(3).Value


        Me.txt_cuit.Enabled = False
    End Sub
    Private Sub button_cancelar_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        Me.Close()
    End Sub
    Private Sub transferir_datos_proveedor()
        Me._proveedor.cuit = Me.txt_cuit.Text
        Me._proveedor.razon_social = Me.txt_razon_social.Text
        Me._proveedor.fecha_inicio = Me.txt_fecha_inicio.Text
        Me._proveedor.tipo_proveedor = Me.txt_tipo_proveedor.Text
    End Sub

    Private Sub blanquear()

        Me.txt_razon_social.Text = ""
        Me.txt_cuit.Text = ""
        Me.txt_fecha_inicio.Text = ""
        Me.txt_tipo_proveedor.Text = ""
        Me.txt_cuit.Focus()

    End Sub
    Private Sub button_confirmar_Click(sender As Object, e As EventArgs) Handles button_confirmar.Click
        transferir_datos_proveedor()
        Me._proveedor.modificar(Integer.Parse(Me.txt_cuit.Text))
        Me.blanquear()
        Me.cargar_grilla()
    End Sub
    Private Sub dgv_vista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Me.cargar_grilla()
    End Sub

End Class