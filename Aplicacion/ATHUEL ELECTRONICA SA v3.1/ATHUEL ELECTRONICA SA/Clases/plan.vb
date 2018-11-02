Public Class plan
    Enum estado_validar
        encontrado
        no_encontrado
    End Enum
    Enum estado_transferencia
        datosErroneos
        ok
    End Enum
    Enum a_donde
        a_la_clase
        al_front_end
    End Enum
    Dim datos As New DataTable
    Dim _BD As New CONEXION_BD
    Dim _nombre_tabla As String = "planificacion"
    Public Function transferir(ByRef controles As DataGridView, ByVal a_donde_transferior As a_donde) As estado_transferencia
        If a_donde_transferior = a_donde.a_la_clase Then
            Return transferir_a_la_clase(controles)
        End If
        Return estado_transferencia.datosErroneos
    End Function

    Private Function transferir_a_la_clase(ByRef controles As DataGridView) As estado_transferencia
        Me.estructura_datos()
        Dim c As Integer = 0
        For c = 0 To controles.Rows.Count - 1
            datos.Rows.Add()
            datos.Rows(c)("codigo") = controles.Rows(c).Cells(0).Value
            datos.Rows(c)("legajo") = controles.Rows(c).Cells(1).Value
            datos.Rows(c)("codturno") = controles.Rows(c).Cells(2).Value
            datos.Rows(c)("semana") = controles.Rows(c).Cells(3).Value
            datos.Rows(c)("año") = controles.Rows(c).Cells(4).Value
        Next
        Return estado_transferencia.ok
    End Function
    Public Sub estructura_datos()
        Dim sql As String = "select top 1 * from " & Me._nombre_tabla
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla(sql)
        Dim c As Integer = 0
        datos.Columns.Clear()
        For c = 0 To tabla.Columns.Count - 1
            datos.Columns.Add(tabla.Columns(c).Caption, tabla.Columns(c).DataType())
            'MessageBox.Show(tabla.Columns(c).DataType().Name)
        Next
        'datos.Rows.Add()
    End Sub
    Public Function Insertar(ByVal i As Integer)
        Dim sqlinsert As String = ""
        Dim columnas As String = ""
        Dim valores As String = ""
        Dim sql As String = ""
        For c = 0 To datos.Columns.Count - 1
            columnas += IIf(columnas = "", datos.Columns(c).Caption, ", " + datos.Columns(c).Caption)
            Dim valor As String = ""
            Select Case datos.Columns(c).DataType.Name
                Case "Int32"
                    valor = datos.Rows(i)(c)
                Case "Int64"
                    valor = datos.Rows(i)(c)
                Case "DateTime"
                    valor = "'" & datos.Rows(i)(c) & "'"
                Case "String"
                    valor = "'" & datos.Rows(i)(c) & "'"
            End Select
            valores += IIf(valores = "", valor, ", " + valor)
        Next
        Return "INSERT " & Me._nombre_tabla & " (" & columnas & ") VALUES (" & valores & ") "

    End Function

    Public Function devolver() As DataTable
        Dim tabla As New DataTable
        tabla = datos
        tabla.Rows.Clear()
        tabla.Rows.Add()
        Return tabla
    End Function
End Class
