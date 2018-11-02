Public Class modificar_ciudad
    Dim _ciudad As New ciudad
    Dim _BD As New CONEXION_BD
    Dim tabla As New DataTable

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellContentDoubleClick
        txt_nombre.Text = dgv_vista.CurrentRow.Cells(1).Value
        _ciudad.codigo = dgv_vista.CurrentRow.Cells(0).Value
        tabla = _BD.leo_tabla("SELECT codBarrio FROM barrio WHERE nombre = '" & txt_nombre.Text & "'")
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Dim barrio As New barrio
        If txt_nombre.Text = "" Then
            MsgBox("el nombre esta vacio", MsgBoxStyle.Critical, "Error")
            txt_nombre.Focus()
            Exit Sub
        End If
        If tabla.Rows.Count = 0 Then
            _ciudad.nombre = txt_nombre.Text
            _ciudad.modificar()
            MsgBox("la ciudad se modifico con exitosamente")
        Else
            _ciudad.nombre = txt_nombre.Text
            _ciudad.modificar()
            barrio.codigo = tabla.Rows(0)("codBarrio")
            barrio.nombre = txt_nombre.Text
            barrio.modificar()
            MsgBox("la ciudad se modifico con exitosamente")
        End If
        Me.blanquear()
        Me.cargar_grilla()
    End Sub

    Private Sub blanquear()
        txt_nombre.Clear()
    End Sub

    Private Sub cargar_grilla()
        dgv_vista.DataSource = _BD.leo_tabla("select * from ciudad")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub modificar_ciudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class
