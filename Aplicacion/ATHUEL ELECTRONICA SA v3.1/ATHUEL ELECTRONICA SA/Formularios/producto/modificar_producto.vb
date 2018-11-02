Public Class modificar_producto
    Dim producto As New producto
    Dim BD As New CONEXION_BD
    Dim _TE As New tratamientos_especiales

    Private Sub modificar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        _TE.llenar_combo(Me.cmb_tipo_producto, BD.leo_tabla("SELECT * FROM tipos_productos"), "nombre", "codTipoProd")
        _TE.llenar_combo(Me.cmb_marca, BD.leo_tabla("SELECT * FROM marca"), "nombre", "codmarca")
    End Sub
    Private Sub cargar_grilla()
        dgv.DataSource = BD.leo_tabla("SELECT * FROM producto")
    End Sub
    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Me.cmb_tipo_producto.SelectedValue = dgv.CurrentRow.Cells(0).Value
        Me.txt_cod_producto.Text = Integer.Parse(dgv.CurrentRow.Cells(1).Value)
        Me.cmb_marca.SelectedValue = dgv.CurrentRow.Cells(2).Value
        Me.txt_descripcion.Text = dgv.CurrentRow.Cells(3).Value.ToString
        Me.txt_modelo.Text = dgv.CurrentRow.Cells(4).Value.ToString
        Me.cmb_fecha_fabricacion.Text = dgv.CurrentRow.Cells(5).Value
        Me.txt_cantidad.Text = Integer.Parse(dgv.CurrentRow.Cells(6).Value)
        cmb_tipo_producto.Enabled = False
        txt_cod_producto.Enabled = False
    End Sub
    Private Sub button_cancelar_Click(sender As Object, e As EventArgs) Handles button_cancelar.Click
        Me.Close()
    End Sub
    Private Sub transferir_datos_producto()
        Me.producto.codigoTipoprod = cmb_tipo_producto.SelectedValue
        Me.producto.codProducto = Integer.Parse(txt_cod_producto.Text)
        Me.producto.codMarca = cmb_marca.SelectedValue
        Me.producto.descripcion = txt_descripcion.Text
        Me.producto.modelo = txt_modelo.Text
        Me.producto.fechaFabricacion = cmb_fecha_fabricacion.Text
        Me.producto.cantidad = Integer.Parse(txt_cantidad.Text)
    End Sub
    Private Sub blanquear()
        Me.cmb_tipo_producto.SelectedValue = -1
        Me.txt_cod_producto.Clear()
        Me.cmb_marca.SelectedValue = -1
        Me.txt_descripcion.Clear()
        Me.txt_modelo.Clear()
        Me.txt_cantidad.Clear()
        cmb_tipo_producto.Enabled = True
        txt_cod_producto.Enabled = True
    End Sub
    Private Sub button_confirmar_Click(sender As Object, e As EventArgs) Handles button_confirmar.Click
        transferir_datos_producto()
        Me.producto.modificar()
        Me.blanquear()
        Me.cargar_grilla()
    End Sub
End Class
