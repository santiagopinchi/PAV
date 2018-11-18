Public Class modificar_tipo_prod
    Dim tipo_prod As New tipo_producto
    Dim BD As New CONEXION_BD
    Dim _TE As New tratamientos_especiales

    Private Sub modificar_tipo_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()

    End Sub
    Private Sub cargar_grilla()
        dgv_vista.DataSource = BD.leo_tabla("SELECT * FROM tipos_productos")
    End Sub
    Private Sub dgv_vista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellDoubleClick
        Me.txt_codigo_tipo_prod.Text = dgv_vista.CurrentRow.Cells(0).Value.ToString
        Me.txt_nombre.Text = dgv_vista.CurrentRow.Cells(1).Value.ToString
        Me.txt_descripcion.Text = dgv_vista.CurrentRow.Cells(2).Value.ToString
        Me.txt_garantia.Text = Integer.Parse(dgv_vista.CurrentRow.Cells(3).Value)

        txt_codigo_tipo_prod.Enabled = False
    End Sub
    Private Sub button_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Private Sub transferir_datos_tipo_producto()
        Me.tipo_prod.codigo = txt_codigo_tipo_prod.Text
        Me.tipo_prod.nombre = txt_nombre.Text
        Me.tipo_prod.descripcion = txt_descripcion.Text
        If txt_garantia.Text <> "" Then
            Me.tipo_prod.tiempoGarantia = Integer.Parse(txt_garantia.Text)
        Else
            Me.tipo_prod.tiempoGarantia = 0
        End If


    End Sub
    Private Sub blanquear()

        Me.txt_codigo_tipo_prod.Clear()
        Me.txt_descripcion.Clear()
        Me.txt_nombre.Clear()
        Me.txt_garantia.Clear()
        txt_codigo_tipo_prod.Enabled = True

    End Sub
    Private Sub button_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        transferir_datos_tipo_producto()
        Dim mensaje As String = Me.tipo_prod.validar()
        If mensaje <> "Correcta" Then
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error")
        Else
            Me.tipo_prod.modificar()
            Me.blanquear()
            Me.cargar_grilla()

        End If
        Me.txt_codigo_tipo_prod.Focus()
    End Sub


End Class