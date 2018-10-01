Public Class tipo_producto
    Dim _BD As New CONEXION_BD
    Public Property codigo As String
    Public Property nombre As String
    Public Property descripcion As String
    Public Property tiempoGarantia As Integer

    Public Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT tipos_productos (codTipoProd, nombre, descripcion, tiempoGarantia)"
        sql &= "VALUES("
        sql &= "'" & _codigo & "'"
        sql &= ", '" & _nombre & "'"
        sql &= ", '" & _descripcion & "'"
        sql &= "," & _tiempoGarantia & "')"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE tipos_productos "
        sql &= "SET nombre ='" & Me._nombre & "'"
        sql &= ", descripcion ='" & Me._descripcion & "'"
        sql &= ", tiempoGarantia =" & Me._tiempoGarantia
        sql &= "WHERE codTipoProd = " & Me._codigo

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cod As String)
        Dim sql As String = ""
        sql &= "DELETE FROM tipos_productos"
        sql &= "WHERE codTipoProd = " & cod

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Function validar() As String
        If Me._codigo = "" Then
            Return "El codigo esta vacio."
        End If
        If Me._nombre = "" Then
            Return "El nombre esta vacio."
        End If
        If Me._tiempoGarantia = 0 Then
            Return "Falta el tiempo de garantia."
        End If
        Return "Correcta"
    End Function


    Public Sub buscar_tipos_productos(ByVal cod As String)
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM tipos_productos "
        sql &= " WHERE  codTipoProd = " & cod.Trim()
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero informacion")
            Me.blanquear()
        Else
            Me.transeferir(tabla)

        End If
    End Sub

    Private Sub transeferir(ByVal tabla As DataTable)
        _codigo = tabla.Rows(0)("codTipoProd")
        _nombre = tabla.Rows(0)("nombre")
        If String.IsNullOrEmpty(tabla.Rows(0)("descripcion")) Then
            _descripcion = ""
        Else
            _descripcion = tabla.Rows(0)("descripcion")
        End If
        _descripcion = tabla.Rows(0)("descripcion")
        _tiempoGarantia = tabla.Rows(0)("tiempoGarantia")
    End Sub

    Private Sub blanquear()
        _codigo = ""
        _nombre = ""
        _descripcion = ""
        _tiempoGarantia = 0

    End Sub
End Class


