Public Class alta_producto
    Dim _BD As New CONEXION_BD
    Dim _producto As New producto
    Dim _TE As New tratamientos_especiales

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub transferir_datos_producto()
        Me._producto.codigoTipoprod = Me.cmb_tipo_producto.SelectedValue
        Me._producto.codProducto = Me.txt_cod_producto.Text
        Me._producto.codMarca = Me.cmb_marca.SelectedValue
        Me._producto.descripcion = Me.txt_descripcion.Text
        Me._producto.modelo = Me.txt_modelo.Text
        Me._producto.fechaFabricacion = Me.cmb_fecha_fabricacion.Text
        Me._producto.cantidad = Me.txt_cantidad.Text
    End Sub

    Private Sub blanquear()
        Me.cmb_tipo_producto.SelectedIndex = -1
        Me.txt_cod_producto.Text = ""
        Me.cmb_marca.SelectedIndex = -1
        Me.txt_descripcion.Text = ""
        Me.txt_modelo.Text = ""
        Me.cmb_fecha_fabricacion.Text = ""
        Me.txt_cantidad.Text = ""
    End Sub

    Private Function validacion()
        If Me.cmb_tipo_producto.SelectedIndex = -1 Then
            MsgBox("Elija un Tipo de Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_tipo_producto.BackColor = Color.Red
            Me.cmb_tipo_producto.Focus()
            Return False
        Else
            cmb_tipo_producto.BackColor = Color.White
        End If

        If Me.txt_cod_producto.Text = "" Then
            MsgBox("El codigo de producto no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            txt_cod_producto.BackColor = Color.Red
            Me.txt_cod_producto.Focus()
            Return False
        Else
            txt_cod_producto.BackColor = Color.White
        End If

        If Me.cmb_marca.SelectedIndex = -1 Then
            MsgBox("Elija una Marca, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_marca.BackColor = Color.Red
            Me.cmb_marca.Focus()
            Return False
        Else
            cmb_marca.BackColor = Color.White
        End If

        If Me.txt_descripcion.Text = "" Then
            MsgBox("La descripcion del producto no puede estar vacia", MsgBoxStyle.Critical, "Importante")
            txt_descripcion.BackColor = Color.Red
            Me.txt_descripcion.Focus()
            Return False
        Else
            txt_descripcion.BackColor = Color.White
        End If

        If Me.txt_modelo.Text = "" Then
            MsgBox("El modelo no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            txt_modelo.BackColor = Color.Red
            Me.txt_modelo.Focus()
            Return False
        Else
            txt_modelo.BackColor = Color.White
        End If

        If cmb_fecha_fabricacion.Value = DateAndTime.Now Then
            MsgBox("Ingrese una fecha de fabricación valida", MsgBoxStyle.Critical, "Importante")
            cmb_fecha_fabricacion.BackColor = Color.Red
            cmb_fecha_fabricacion.Focus()
            Return False
        Else
            cmb_fecha_fabricacion.BackColor = Color.White
        End If

        If Me.txt_cantidad.Text = "" Then
            MsgBox("El modelo no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            txt_cantidad.BackColor = Color.Red
            Me.txt_cantidad.Focus()
            Return False
        Else
            txt_cantidad.BackColor = Color.White
        End If

        Return True
    End Function



    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        validacion()
        transferir_datos_producto()

        If validacion() = True Then
            Me._producto.insertar()
            MsgBox("Se grabó con éxito el producto")
            blanquear()
        End If
    End Sub

    Private Sub alta_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _TE.llenar_combo(Me.cmb_tipo_producto, _BD.leo_tabla("SELECT * FROM tipos_productos"), "nombre", "codTipoProd")
        _TE.llenar_combo(Me.cmb_marca, _BD.leo_tabla("SELECT * FROM marca"), "nombre", "codmarca")
        blanquear()
        'lo de abajo es por si la pk era autogenerada
        'Me.txt_cod_producto.Enabled = False
    End Sub
End Class