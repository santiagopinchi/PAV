Public Class modificar_ciudad
    Dim _ciudad As New ciudad
    Dim _BD As New CONEXION_BD

    Dim codCiudad As String

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vista.CellContentDoubleClick
        txt_nombre.Text = dgv_vista.CurrentRow.Cells(1).Value
        codCiudad = dgv_vista.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        _ciudad.nombre = txt_nombre.Text
        _ciudad.codigo = Integer.Parse(codCiudad)
        _ciudad.modificar()
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
