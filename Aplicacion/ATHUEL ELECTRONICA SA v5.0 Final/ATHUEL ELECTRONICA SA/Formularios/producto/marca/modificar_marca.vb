Public Class modificar_marca
    Dim _marca As New marca
    Dim _BD As New CONEXION_BD


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellContentDoubleClick
        txt_nombre.Text = dgv_vista.CurrentRow.Cells(1).Value
        _marca.codigo = dgv_vista.CurrentRow.Cells(0).Value

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Dim marca As New marca
        If txt_nombre.Text = "" Then
            MsgBox("el nombre esta vacio", MsgBoxStyle.Critical, "Error")
            txt_nombre.Focus()
            Exit Sub
        End If
        marca.nombre = txt_nombre.Text
        marca.codigo = _marca.codigo
        marca.modificar()
        Me.blanquear()
        Me.cargar_grilla()
    End Sub

    Private Sub blanquear()
        txt_nombre.Clear()
    End Sub

    Private Sub cargar_grilla()
        dgv_vista.DataSource = _BD.leo_tabla("select * from marca")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub modificar_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class