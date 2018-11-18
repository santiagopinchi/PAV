Public Class consultar_manual
    Dim TE As New tratamientos_especiales
    Dim BD As New CONEXION_BD
    Private Property orden_paso As Integer = 0
    
    Private Sub consultar_manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TE.llenar_combo(Me.cmb_tipo_producto, BD.leo_tabla("SELECT * FROM tipos_productos"), "nombre", "codTipoProd")
        TE.llenar_combo(Me.cmb_tipo_producto_parte, BD.leo_tabla("SELECT * FROM tipos_productos"), "nombre", "codTipoProd")
        blanquear()
    End Sub

    Private Sub blanquear_paso()
        txt_descripcion.Clear()
        txt_cantidad.Clear()
        txt_orden.Clear()
        cmb_tipo_producto_parte.SelectedIndex = -1
        cmb_cod_producto_parte.SelectedIndex = -1
    End Sub

    Public Sub blanquear()
        Me.blanquear_paso()
        cmb_fecha_registro.SelectedIndex = -1
        cmb_cod_producto.SelectedIndex = -1
        cmb_tipo_producto.SelectedIndex = -1
    End Sub

    Private Function validar() As Boolean
        If Me.cmb_tipo_producto.SelectedIndex = -1 Then
            MsgBox("Elija un Tipo de Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_tipo_producto.BackColor = Color.Aqua
            Me.cmb_tipo_producto.Focus()
            Return False
        Else
            cmb_tipo_producto.BackColor = Color.White
        End If


        If Me.cmb_cod_producto.SelectedIndex = -1 Then
            MsgBox("Elija un Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_cod_producto.BackColor = Color.Aqua
            Me.cmb_cod_producto.Focus()
            Return False
        Else
            cmb_cod_producto.BackColor = Color.White
        End If


        If Me.cmb_fecha_registro.SelectedIndex = -1 Then
            MsgBox("Elija una fecha de manual, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_fecha_registro.BackColor = Color.Aqua
            Me.cmb_fecha_registro.Focus()
            Return False
        Else
            cmb_fecha_registro.BackColor = Color.White
        End If
        Return True
    End Function

    Private Sub btm_siguiente_Click(sender As Object, e As EventArgs) Handles btm_siguiente.Click
        Dim tabla As New DataTable
        Dim sql As String
        If validar() = True Then
            _orden_paso = orden_paso + 1
            sql = "SELECT * FROM composicionProducto "
            sql &= " WHERE orden= " & _orden_paso
            sql &= " AND fecha = '" & cmb_fecha_registro.SelectedValue & "'"
            sql &= " AND codTipoProdFinal = '" & cmb_tipo_producto.SelectedValue & "'"
            sql &= " AND codProdFinal = " & cmb_cod_producto.SelectedValue
            tabla = BD.leo_tabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("fin del manual")
                _orden_paso = 0
                Me.blanquear()
                Exit Sub
            End If
            blanquear_paso()

            cmb_tipo_producto_parte.SelectedValue = tabla.Rows(0)("codTipoProdPar").ToString
            TE.carga_combo(Me.cmb_cod_producto_parte, BD.leo_tabla("SELECT * FROM producto WHERE codTipoProd ='" & cmb_tipo_producto_parte.SelectedValue & "'"), "codProd", "modelo")
            cmb_cod_producto_parte.SelectedValue = tabla.Rows(0)("codProdPar")
            txt_cantidad.Text = tabla.Rows(0)("cantidad")
            txt_orden.Text = tabla.Rows(0)("orden")
            txt_descripcion.Text = tabla.Rows(0)("descripcion_paso").ToString
        End If
    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        Dim tabla As New DataTable
        Dim sql As String
        If validar() = True Then
            _orden_paso = orden_paso - 1
            sql = "SELECT * FROM composicionProducto "
            sql &= " WHERE orden= " & _orden_paso
            sql &= " AND fecha = '" & cmb_fecha_registro.SelectedValue & "'"
            sql &= " AND codTipoProdFinal = '" & cmb_tipo_producto.SelectedValue & "'"
            sql &= " AND codProdFinal = " & cmb_cod_producto.SelectedValue
            If _orden_paso < 0 Then
                MsgBox("Accion incorrecta.", MsgBoxStyle.Critical, "Error")
                blanquear_paso()
                Exit Sub
            End If
            tabla = BD.leo_tabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("Accion incorrecta.", MsgBoxStyle.Critical, "Error")
                blanquear_paso()
                Exit Sub
            End If
            blanquear_paso()
            cmb_tipo_producto_parte.SelectedValue = tabla.Rows(0)("codTipoProdPar").ToString
            TE.carga_combo(Me.cmb_cod_producto_parte, BD.leo_tabla("SELECT * FROM producto WHERE codTipoProd ='" & cmb_tipo_producto_parte.SelectedValue & "'"), "codProd", "modelo")
            cmb_cod_producto_parte.SelectedValue = tabla.Rows(0)("codProdPar")
            txt_cantidad.Text = tabla.Rows(0)("cantidad")
            txt_orden.Text = tabla.Rows(0)("orden")
            txt_descripcion.Text = tabla.Rows(0)("descripcion_paso").ToString
        End If
    End Sub


    Private Sub cmb_tipo_producto_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_tipo_producto.SelectedIndexChanged
        Dim tabla As New DataTable
        If cmb_tipo_producto.SelectedIndex <> -1 Then
            Dim cadena As String = cmb_tipo_producto.SelectedValue.ToString
            tabla = BD.leo_tabla("SELECT DISTINCT cp.codProdFinal, p.modelo  FROM composicionProducto cp LEFT OUTER JOIN producto p ON p.codProd = cp.codProdFinal AND cp.codTipoProdFinal= p.codTipoProd WHERE cp.codTipoProdFinal='" & cadena & "' AND cp.orden = 1")
            TE.llenar_combo(Me.cmb_cod_producto, tabla, "modelo", "codProdFinal")
        End If
    End Sub

    Private Sub cmb_cod_producto_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_cod_producto.SelectedIndexChanged
        Dim tabla As New DataTable
        If cmb_cod_producto.SelectedIndex <> -1 Or cmb_tipo_producto.SelectedIndex = -1 Then
            tabla = BD.leo_tabla("SELECT * FROM composicionProducto WHERE codProdFinal =" & cmb_cod_producto.SelectedValue & " AND codTipoProdFinal ='" & cmb_tipo_producto.SelectedValue & "' AND orden = 1")
            TE.llenar_combo(Me.cmb_fecha_registro, tabla, "fecha", "fecha")
        End If
    End Sub
End Class