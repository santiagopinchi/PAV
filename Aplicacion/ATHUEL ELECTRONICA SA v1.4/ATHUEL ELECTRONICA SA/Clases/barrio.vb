Public Class barrio
    Dim _BD As New CONEXION_BD
    Public Property codigo As Integer
    Public Property nombre As String
    Public Property codCiudad As Integer

    Public Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT barrio (nombre, codCiudad)"
        sql &= "VALUES("
        sql &= "'" & _nombre & "'"
        sql &= ", " & _codCiudad & ")"

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE barrio "
        sql &= "SET nombre = '" & Me._nombre & "'"
        sql &= ", codCiudad = " & Me._codCiudad
        sql &= " WHERE codBarrio = " & Me._codigo
        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal cod As String)
        Dim sql As String = ""
        sql &= "DELETE FROM barrio"
        sql &= "WHERE codBarrio = " & cod

        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Function validar() As String
        If Me._nombre = "" Then
            Return "El nombre esta vacio."
        End If
        Return "Correcta"
    End Function


    Public Sub buscar_barrio(ByVal cod As String)
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql = "SELECT * FROM barrio"
        sql &= " WHERE  codBarrio = " & cod.Trim()
        tabla = Me._BD.leo_tabla(sql)

        If tabla.Rows.Count = 0 Then
            MsgBox("No se recupero informacion")
            Me.blanquear()
        Else
            Me.transeferir(tabla)
        End If
    End Sub

    Private Sub transeferir(ByVal tabla As DataTable)
        _codigo = tabla.Rows(0)("codBarrio")
        _nombre = tabla.Rows(0)("nombre")
        _codCiudad = tabla.Rows(0)("codCiudad")
    End Sub

    Private Sub blanquear()
        _codCiudad = 0
        _nombre = ""

    End Sub
End Class

