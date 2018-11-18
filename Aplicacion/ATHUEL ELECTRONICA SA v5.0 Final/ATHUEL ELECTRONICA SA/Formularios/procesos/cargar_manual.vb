Public Class cargar_manual

    Dim TE As New tratamientos_especiales
    Dim BD As New conexion_BD_transaccion
    Dim composicion As New composicion
    Dim i As Integer
    Private Property orden_paso As Integer = 0
    Private Property orden_modificar As Integer = 0
    Private Property control As Boolean = True
    Private Property plan As Boolean = False
    Private Sub cargar_manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TE.llenar_combo(Me.cmb_tipo_producto, BD.leo_tabla("SELECT * FROM tipos_productos"), "nombre", "codTipoProd")
        TE.llenar_combo(Me.cmb_tipo_producto_parte, BD.leo_tabla("SELECT * FROM tipos_productos"), "nombre", "codTipoProd")
        blanquear()
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btn_finalizar, "Recuerde que al finalizar se hara la carga como el ultimo paso")
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


        If Me.cmb_tipo_producto_parte.SelectedIndex = -1 Then
            MsgBox("Elija un Tipo de Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_tipo_producto_parte.BackColor = Color.Aqua
            Me.cmb_tipo_producto_parte.Focus()
            Return False
        Else
            cmb_tipo_producto_parte.BackColor = Color.White
        End If


        If Me.cmb_cod_producto_parte.SelectedIndex = -1 Then
            MsgBox("Elija un Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_cod_producto_parte.BackColor = Color.Aqua
            Me.cmb_cod_producto_parte.Focus()
            Return False
        Else
            cmb_cod_producto_parte.BackColor = Color.White
        End If

        Return True
    End Function
    Private Sub blanquear_paso()
        cmb_tipo_producto_parte.SelectedIndex = -1
        cmb_cod_producto_parte.SelectedIndex = -1
        txt_descripcion.Clear()
        txt_cantidad.Clear()
    End Sub

    Public Sub blanquear()
        Me.blanquear_paso()
        cmb_tipo_producto.SelectedIndex = -1
        cmb_cod_producto.SelectedIndex = -1
    End Sub
    Private Sub cmb_tipo_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_producto.SelectedIndexChanged
        Dim tabla As New DataTable
        If cmb_tipo_producto.SelectedIndex <> -1 Then
            Dim cadena As String = cmb_tipo_producto.SelectedValue.ToString
            tabla = BD.leo_tabla("SELECT codProd, modelo FROM producto WHERE codTipoProd ='" & cadena & "'")
            TE.llenar_combo(Me.cmb_cod_producto, tabla, "modelo", "codProd")
        End If
    End Sub

    Private Sub cmb_tipo_producto_parte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_producto_parte.SelectedIndexChanged
        Dim tabla As New DataTable
        If cmb_tipo_producto_parte.SelectedIndex <> -1 Then
            Dim cadena As String = cmb_tipo_producto_parte.SelectedValue.ToString
            tabla = BD.leo_tabla("SELECT codProd, modelo FROM producto WHERE codTipoProd ='" & cadena & "'")
            TE.llenar_combo(Me.cmb_cod_producto_parte, tabla, "modelo", "codProd")
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        If _control = False Then
            If MessageBox.Show("¿Esta seguro que desea salir y perder todos los datos no guardados?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                _control = True
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btn_agregar_paso_Click(sender As Object, e As EventArgs) Handles btn_agregar_paso.Click
        If _control = True Then
            BD.iniciar_transaccion()
            _control = False
        End If
        If carga() = True Then
            blanquear_paso()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        If _orden_modificar <> 0 Then
            MsgBox("Se ha marcado una parte del producto a modificar.")
            Exit Sub
        End If

        blanquear()
            _orden_paso = 0
            cmb_cod_producto.Enabled = True
            cmb_tipo_producto.Enabled = True
            txt_fecha_registro.Enabled = True



        Me.composicion.transferir(dgv, composicion.a_donde.a_la_clase)
        Dim i As Integer
        For i = 0 To dgv.Rows.Count - 1
            BD.INS_MOD_BOR(composicion.Insertar(i))
        Next
        BD.fin_transaccion()
        dgv.Rows.Clear()
    End Sub

    Private Function carga() As Boolean
        Dim tabla As New DataTable
        tabla = BD.leo_tabla("SELECT * FROM composicionProducto WHERE fecha = '" & txt_fecha_registro.Text & "' AND codTipoProdFinal = '" & cmb_tipo_producto.SelectedValue & "' AND codProdFinal = " & cmb_cod_producto.SelectedValue & " ORDER BY orden DESC")
        If tabla.Rows.Count <> 0 And _orden_paso = 0 And _orden_modificar = 0 Then
            If MessageBox.Show("El manual ya esta ingresado ¿Desea continuar con la carga?" _
                               , "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                _orden_paso = tabla.Rows(0)("orden")
            Else
                Return False
                Exit Function
            End If
        End If
        If orden_modificar = 0 Then
            If validar() = False Then
                Return False
                Exit Function
            End If
            Dim _cantidad As Integer
            If txt_cantidad.Text = "" Then
                _cantidad = 0
            Else
                _cantidad = Integer.Parse(txt_cantidad.Text)
            End If

            cmb_cod_producto.Enabled = False
            cmb_tipo_producto.Enabled = False
            txt_fecha_registro.Enabled = False

            _orden_paso = _orden_paso + 1
            dgv.Rows.Add()
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(0).Value = cmb_tipo_producto.SelectedValue
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(1).Value = Long.Parse(cmb_cod_producto.SelectedValue)
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(2).Value = _orden_paso
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(3).Value = cmb_tipo_producto_parte.SelectedValue
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(4).Value = Long.Parse(cmb_cod_producto_parte.SelectedValue)
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(5).Value = txt_descripcion.Text
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(6).Value = txt_fecha_registro.Text
            Me.dgv.Rows(Me.dgv.Rows().Count - 1).Cells(7).Value = _cantidad
            Return True

        Else
            cmb_cod_producto.Enabled = False
            cmb_tipo_producto.Enabled = False
            txt_fecha_registro.Enabled = False

            If Me.cmb_tipo_producto.SelectedIndex = -1 Then
                MsgBox("Elija un Tipo de Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
                cmb_tipo_producto.BackColor = Color.Aqua
                Me.cmb_tipo_producto.Focus()
                Return False
                Exit Function
            Else
                cmb_tipo_producto.BackColor = Color.White
            End If


            If Me.cmb_cod_producto.SelectedIndex = -1 Then
                MsgBox("Elija un Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
                cmb_cod_producto.BackColor = Color.Aqua
                Me.cmb_cod_producto.Focus()
                Return False
                Exit Function
            Else
                cmb_cod_producto.BackColor = Color.White
            End If
            Dim cantidad As Integer
            If txt_cantidad.Text = "" Then
                cantidad = 0
            Else
                cantidad = Integer.Parse(txt_cantidad.Text)
            End If

            tabla = BD.leo_tabla("SELECT * FROM composicionProducto WHERE fecha = '" & txt_fecha_registro.Text & "' AND codTipoProdFinal = '" & cmb_tipo_producto.SelectedValue & "' AND codProdFinal = " & cmb_cod_producto.SelectedValue & " AND orden=" & _orden_modificar & "")

            If tabla.Rows.Count = 0 Then
                Me.dgv.Rows(i).Cells(0).Value = cmb_tipo_producto.SelectedValue
                Me.dgv.Rows(i).Cells(1).Value = Long.Parse(cmb_cod_producto.SelectedValue)
                Me.dgv.Rows(i).Cells(2).Value = _orden_modificar
                Me.dgv.Rows(i).Cells(3).Value = cmb_tipo_producto_parte.SelectedValue
                Me.dgv.Rows(i).Cells(4).Value = Long.Parse(cmb_cod_producto_parte.SelectedValue)
                Me.dgv.Rows(i).Cells(5).Value = txt_descripcion.Text
                Me.dgv.Rows(i).Cells(6).Value = txt_fecha_registro.Text
                Me.dgv.Rows(i).Cells(7).Value = cantidad
                _orden_modificar = 0
                Return True
            Else
                Dim sql As String
                sql = "UPDATE composicionProducto SET codTipoProdPar= '" & cmb_tipo_producto_parte.SelectedValue & "', codProdPar= " & cmb_cod_producto_parte.SelectedValue & ", "
                sql &= "descripcion_paso='" & txt_descripcion.Text & "', cantidad= " & cantidad & " WHERE codTipoProdFinal= '" & cmb_tipo_producto.SelectedValue & "' AND "
                sql &= "codProdFinal= " & cmb_cod_producto.SelectedValue & " AND orden=" & _orden_modificar & " AND fecha='" & txt_fecha_registro.Text & "'"
                BD.INS_MOD_BOR(sql)
                MsgBox("Paso modificado.")
                _orden_modificar = 0
                cargar_grilla()
                Return True
            End If
        End If
    End Function


    Public Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String
        dgv.Rows.Clear()
        Dim c As Integer = 0

        sql = "SELECT * "
        sql &= " FROM tipos_productos tp, producto p, composicionProducto cp"
        sql &= " WHERE tp.codTipoProd = cp.codTipoProdPar"
        sql &= " AND(cp.codTipoProdPar = p.codTipoProd AND cp.codProdPar = p.codProd)"
        sql &= " AND cp.fecha = '" & txt_fecha_registro.Text & "'"
        sql &= " AND cp.codTipoProdFinal = '" & cmb_tipo_producto.SelectedValue & "'"
        sql &= " AND cp.codProdFinal = " & cmb_cod_producto.SelectedValue & ""
        tabla = BD.leo_tabla(sql)
        If tabla.Rows.Count = 0 Then
            MsgBox("Manual no encontrado")
            Exit Sub
        End If
        For c = 0 To tabla.Rows.Count - 1
            dgv.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1), tabla.Rows(c)(2), tabla.Rows(c)(3), tabla.Rows(c)(4), tabla.Rows(c)(5), tabla.Rows(c)(6), tabla.Rows(c)(7))
        Next

    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        If _control = True Then
            BD.iniciar_transaccion()
            _control = False
        Else
            MsgBox("Transaccion ya iniciada.")
        End If

        If Me.cmb_tipo_producto.SelectedIndex = -1 Then
            MsgBox("Elija un Tipo de Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_tipo_producto.BackColor = Color.Aqua
            Me.cmb_tipo_producto.Focus()
            Exit Sub
        Else
            cmb_tipo_producto.BackColor = Color.White
        End If


        If Me.cmb_cod_producto.SelectedIndex = -1 Then
            MsgBox("Elija un Producto, no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            cmb_cod_producto.BackColor = Color.Aqua
            Me.cmb_cod_producto.Focus()
            Exit Sub
        Else
            cmb_cod_producto.BackColor = Color.White
        End If

        Me.cargar_grilla()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        i = e.RowIndex
        _orden_modificar = dgv.CurrentRow.Cells(2).Value
        cmb_tipo_producto_parte.SelectedValue = dgv.CurrentRow.Cells(3).Value
        cmb_cod_producto_parte.SelectedValue = dgv.CurrentRow.Cells(4).Value
        txt_descripcion.Text = dgv.CurrentRow.Cells(5).Value.ToString
        txt_cantidad.Text = dgv.CurrentRow.Cells(7).Value.ToString
    End Sub

End Class