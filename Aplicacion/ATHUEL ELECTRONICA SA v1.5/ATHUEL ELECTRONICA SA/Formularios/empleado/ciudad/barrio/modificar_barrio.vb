Public Class modificar_barrio
    Dim _barrio As New barrio
    Dim _BD As New CONEXION_BD
    Dim codBar As Integer
    Dim codCiudad As Integer

    'Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellContentDoubleClick
    '    txt_nombre.Text = dgv_vista.CurrentRow.Cells(1).Value
    '    codBar = dgv_vista.CurrentRow.Cells(0).Value
    '    codCiudad = dgv_vista.CurrentRow.Cells(2).Value
    'End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        _barrio.nombre = txt_nombre.Text
        _barrio.codigo = Integer.Parse(codBar)
        _barrio.codCiudad = Integer.Parse(codCiudad)
        _barrio.modificar()
        Me.blanquear()
        Me.cargar_grilla()
    End Sub

    Private Sub blanquear()
        txt_nombre.Clear()
    End Sub

    Private Sub cargar_grilla()
        dgv_vista.DataSource = _BD.leo_tabla("select * from barrio")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub modificar_barrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub dgv_vista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellClick
        txt_nombre.Text = dgv_vista.CurrentRow.Cells(1).Value
        codBar = dgv_vista.CurrentRow.Cells(0).Value
        codCiudad = dgv_vista.CurrentRow.Cells(2).Value
    End Sub
End Class