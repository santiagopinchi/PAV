Public Class tratamientos_especiales
    Public Sub carga_combo(ByRef combo As ComboBox, ByVal tabla As DataTable, ByVal pk As String, ByVal descriptor As String)

        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk

    End Sub

    Public Sub cargar_grilla(ByRef grilla As DataGridView, ByVal tabla As DataTable)
        grilla.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            grilla.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1), tabla.Rows(c)(2), tabla.Rows(c)(3))
        Next
    End Sub
    Public Sub cargar_grilla_1(ByRef grilla As DataGridView, ByVal tabla As DataTable)
        grilla.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            grilla.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1), tabla.Rows(c)(2))
        Next
    End Sub
End Class
